using Gee.External.Capstone;
using Gee.External.Capstone.Arm64;
using Mono.Cecil;
using Mono.Cecil.Rocks;
using ProtobufDumper; // https://github.com/SteamRE/SteamKit/tree/master/Resources/ProtobufDumper
using System.Text;
using System.Text.Json.Nodes;

namespace PbDumper
{
    public static class Dumper
    {
        static string solutionPath = @"C:\Users\" + Environment.UserName + @"\Documents\GitHub\ff7ecapi\";
        static string apkPath = solutionPath + @"ApkDumper\bin\Debug\net8.0\";
        static string dummyDll = @"il2cppdump\DummyDll\";
        static AssemblyDefinition assemblySharp = AssemblyDefinition.ReadAssembly(apkPath + dummyDll + "Assembly-CSharp.dll");
        static CapstoneArm64Disassembler disassembler = CapstoneDisassembler.CreateArm64Disassembler(Arm64DisassembleMode.Arm);
        static Dictionary<int, string> stringLiterals = JsonNode.Parse(File.ReadAllText(apkPath + @"il2cppdump\stringliteral.json")).AsArray().ToDictionary(
            a => int.Parse(a["address"].ToString().Substring(2), System.Globalization.NumberStyles.HexNumber), a => a["value"].ToString());
        static byte[] armCode = File.ReadAllBytes(apkPath + "libil2cpp.so");
        public static void DumpProtos()
        {
            var protobufDefinition = AssemblyDefinition.ReadAssembly(apkPath + dummyDll + "Google.Protobuf.dll");
            var commandDomain = AssemblyDefinition.ReadAssembly(apkPath + dummyDll + "Command.Domain.dll");
            var assemblySharp = AssemblyDefinition.ReadAssembly(apkPath + dummyDll + "Assembly-CSharp.dll");
            var reflectionClasses1 = protobufDefinition.MainModule.Types.Where(t => t.Properties.Count == 1 && t.Properties[0].Name == "Descriptor" && t.Name.Contains("Reflection"));
            var reflectionClasses2 = commandDomain.MainModule.Types.Where(t => t.Properties.Count == 1 && t.Properties[0].Name == "Descriptor");
            var reflectionClasses = reflectionClasses1.Concat(reflectionClasses2);
            //var reflectionClasses = reflectionClasses1.Concat(reflectionClasses2).Where(p=>p.Name.Contains("RoomPrivateCreate"));
            var pad = Enumerable.Range(0, 100).Select(b => (byte)0);
            var protobin = pad.ToArray();
            var sb = new StringBuilder();
            foreach (var r in reflectionClasses)
            {
                var cctor = r.GetStaticConstructor();
                var cctorOffset = int.Parse(cctor.CustomAttributes.First(a => a.AttributeType.Name == "AddressAttribute").Fields.First(f => f.Name == "Offset").Argument.Value.ToString().Substring(2), System.Globalization.NumberStyles.AllowHexSpecifier);
                var funcSearch = armCode.Skip(cctorOffset);
                //var sig = Convert.FromHexString("04 00 80 D2 05 00 80 D2 06 00 80 D2 07 00 80 D2".Replace(" ", ""));
                var sig = Convert.FromHexString("E4 03 1F AA E5 03 1F AA E6 03 1F AA E7 03 1F AA".Replace(" ", ""));
                var funcLength = 0x10000;
                for (var i = 0; i < funcSearch.Count(); i++)
                {
                    if (funcSearch.Skip(i).Take(sig.Length).SequenceEqual(sig))
                    {
                        funcLength = i;
                        break;
                    }
                }
                //if (funcLength > 0x10000) funcLength = 0x10000;
                var func = disassembler.Disassemble(armCode.Skip(cctorOffset).Take(funcLength).ToArray());
                var area = func.SkipWhile(f => f.Mnemonic != "cbz").ToArray();
                var b64 = "";
                var prevOffset = 0l;
                for (var i = 0; i < area.Length; i++)
                {
                    if (area[i].Mnemonic == "adrp" && area[i + 1].Mnemonic == "ldr")
                    {
                        if (!(area[i + 2].Mnemonic == "mov" || area[i + 2].Mnemonic == "add" || area[i + 2].Mnemonic.Contains("mov"))) continue;
                        var pageAddress = ((cctorOffset + area[i].Address - 0x1000) & 0xfffff000) - 0x1000;
                        var offset = cctorOffset + area[i].Address - 0x1000;
                        if (offset - prevOffset != 72 && offset - prevOffset != 80 && offset - prevOffset != 84 && offset - prevOffset != 68 && prevOffset != 0) // failed to find the next part of the protobuf
                            Console.WriteLine(offset - prevOffset);
                        if (offset - prevOffset == 160)
                        {
                            b64 += "K3Bvc3RfcHZ0X2V2ZW50X3Njb3JlX2R1bmdlb25fZnJpZW5kX3JhbmtpbmcY"; // dumb hack, need to fix
                        }
                        prevOffset = offset;
                        var p2 = disassembler.Disassemble(armCode.Skip(cctorOffset + (int)area[i].Address - 0x1000).Take(0x20).ToArray())[0];
                        var p3 = disassembler.Disassemble(armCode.Skip(cctorOffset + (int)area[i + 1].Address - 0x1000).Take(0x20).ToArray())[0];
                        //var pageOffset = int.Parse(area[i].Operand.Split("0x")[1], System.Globalization.NumberStyles.HexNumber);
                        var pageOffset = int.Parse(p2.Operand.Split("0x")[1], System.Globalization.NumberStyles.HexNumber);
                        var suc = int.TryParse(area[i + 1].Operand.Split("#").Last().Replace("0x", "").Replace("]", ""), System.Globalization.NumberStyles.HexNumber, null, out int absOffsetl);
                        if (!suc)
                            absOffsetl = 0;
                        var s2 = (int)pageAddress + pageOffset + absOffsetl;
                        var s = BitConverter.ToInt32(armCode, s2 - 0x1000);
                        //if (!stringLiterals.ContainsKey(s)) continue;
                        var sl = stringLiterals[s];
                        //if (stringLiterals[s].Length != 60 && !sl.EndsWith("="))
                        //    continue;
                        b64 += stringLiterals[s];
                        sb.AppendLine(stringLiterals[s]);
                    }
                    if (area[i].Mnemonic == "adrp" && area[i + 1].Mnemonic == "adrp")
                    {
                        break;
                    }
                }
                protobin = protobin.Concat(Convert.FromBase64String(b64)).Concat(pad).ToArray();
            }
            var qq = sb.ToString();
            File.WriteAllBytes("payload.pb", protobin);

            Executor.Execute(new string[] { "payload.pb" });

            var pbPath = solutionPath + @"ff7ecpb\";
            Directory.Delete(pbPath + @"proto\api", true);
            Directory.Delete(pbPath + @"proto\entity", true);
            Directory.Delete(pbPath + @"proto\enums", true);
            Directory.Move(@"payload\api", pbPath + @"proto\api");
            Directory.Move(@"payload\entity", pbPath + @"proto\entity");
            Directory.Move(@"payload\enums", pbPath + @"proto\enums");
        }
        public static void DumpApi()
        {
            var apiClasses = assemblySharp.MainModule.Types.Where(t => t.BaseType?.Name == "ApiCommon");
            var apiSb = new StringBuilder();
            apiSb.AppendLine("using Api;");
            apiSb.AppendLine("namespace ffecnet");
            apiSb.AppendLine("{");
            apiSb.AppendLine("    public class API");
            apiSb.AppendLine("    {");
            apiSb.AppendLine("        public ffecutils.HttpRequest http;");
            apiSb.AppendLine("        public long userId;");
            apiSb.AppendLine("        static string apiUrl = \"https://game-q74z3cyn.app.gl.ffviiec.com\";");
            apiSb.AppendLine("        public API(long id)");
            apiSb.AppendLine("        {");
            apiSb.AppendLine("            userId = id;");
            apiSb.AppendLine("            http = new ffecutils.HttpRequest();");
            apiSb.AppendLine("        }");
            foreach (var a in apiClasses)
            {
                var cctor = a.GetConstructors().First();
                var cctorOffset = int.Parse(cctor.CustomAttributes.First(a => a.AttributeType.Name == "AddressAttribute").Fields.First(f => f.Name == "Offset").Argument.Value.ToString().Substring(2), System.Globalization.NumberStyles.AllowHexSpecifier);
                var func = disassembler.Disassemble(armCode.Skip(cctorOffset).Take(0x1000).ToArray());
                var area = func.SkipWhile(a => a.Mnemonic != "strb").ToArray();
                var b64 = "";
                var reqType = a.Properties.First(p => p.Name == "RequestParameter").PropertyType.Name;
                var respType = ((GenericInstanceType)a.Methods.First(m => m.Name == "RequestAsync").ReturnType).GenericArguments.First().Name;
                for (var i = 0; i < area.Length; i++)
                {
                    if (area[i].Mnemonic == "adrp" && area[i + 1].Mnemonic == "adrp" && area[i + 2].Mnemonic == "ldr" && area[i + 1 + 2].Mnemonic == "ldr")
                    {
                        var pageAddress = ((cctorOffset + area[i].Address - 0x1000) & 0xfffff000) - 0x1000;
                        var p2 = disassembler.Disassemble(armCode.Skip(cctorOffset + (int)area[i + 0].Address - 0x1000).Take(0x20).ToArray())[0];
                        var p3 = disassembler.Disassemble(armCode.Skip(cctorOffset + (int)area[i + 2].Address - 0x1000).Take(0x20).ToArray())[0];
                        //var pageOffset = int.Parse(area[i].Operand.Split("0x")[1], System.Globalization.NumberStyles.HexNumber);
                        var pageOffset = int.Parse(p2.Operand.Split("0x")[1], System.Globalization.NumberStyles.HexNumber);
                        var absOffsetl = int.Parse(p3.Operand.Split("#").Last().Replace("0x", "").Replace("]", ""), System.Globalization.NumberStyles.HexNumber);
                        var s2 = (int)pageAddress + pageOffset + absOffsetl;
                        var s = BitConverter.ToInt32(armCode, s2 - 0x1000);
                        var url = stringLiterals[s];
                        apiSb.AppendLine("        public async Task<" + respType + "> " + reqType.Replace("Request", "") + "(" + reqType + " request)");
                        apiSb.AppendLine("        {");
                        apiSb.AppendLine("            return await http.ApiRequestAsync<" + respType + ">(apiUrl + \"" + url + "\".Replace(\"{0}\",userId.ToString()), request);");
                        apiSb.AppendLine("        }");
                        break;
                    }
                }
            }
            apiSb.AppendLine("    }");
            apiSb.AppendLine("}");

            File.WriteAllText(solutionPath + @"ff7ecnet\API.cs", apiSb.ToString());
        }
    }
}
