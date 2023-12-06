using Mono.Cecil;
using System.Text;

namespace MpDumper
{
    public static class Dumper
    {
        static string solutionPath = @"C:\Users\" + Environment.UserName + @"\Documents\GitHub\ff7ecapi\";
        static string apkPath = solutionPath + @"ApkDumper\bin\Debug\net8.0\";
        public static string UnityAssembly = apkPath + @"il2cppdump\DummyDll\Command.Domain.dll";
        public static string OutputDirectory = solutionPath + @"ff7ecmp\";
        public static string DumpClass(TypeDefinition message)
        {
            var mpfile = new StringBuilder();
            var messageName = message.Name;
            mpfile.AppendLine("using MessagePack;");
            //mpfile.AppendLine("namespace ffecmp");
            if (message.Namespace.Length > 0)
                mpfile.AppendLine("namespace " + message.Namespace);
            else
                mpfile.AppendLine("namespace Command.DB");
            mpfile.AppendLine("{");
            mpfile.AppendLine("    [MessagePackObject] public class " + messageName);
            mpfile.AppendLine("    {");
            var i = 0;
            foreach (var p in message.Properties)
            {
                mpfile.AppendLine("        [Key(" + i++ + ")] public " + p.PropertyType.ToString()
                    .Replace("Command.Work.I", "")
                    .Replace(".IReadOnlyList`1", ".List")
                    .Replace(".List`1", ".List")
                    .Replace(".Dictionary`2", ".Dictionary")
                    .Replace("System.ValueTuple`2", "Dictionary")
                    .Replace("[]", "")
                    .Replace("Command.Work." + messageName + "/I", "")
                    //.Replace("Command.Work.", "")
                    .Replace("Command.Permil", "int")
                    .Replace("Command.SyncTime", "long")
                    //.Replace("Command.Enums.", "")
                    + " " + p.Name + " { get; set; }");
            }
            if (message.Properties.Count == 0 && message.Fields.Count > 0)
            {
                foreach (var p in message.Fields)
                {
                    mpfile.AppendLine("        [Key(" + i++ + ")] public " + p.FieldType.ToString()
                        .Replace("Command.Work.I", "")
                        .Replace(".IReadOnlyList`1", ".List")
                        .Replace(".List`1", ".List")
                        .Replace(".Dictionary`2", ".Dictionary")
                        .Replace("System.ValueTuple`2", "Dictionary")
                        .Replace("[]", "")
                        .Replace("Command.Work." + messageName + "/I", "")
                        //.Replace("Command.Work.", "")
                        .Replace("Command.Permil", "int")
                        .Replace("Command.SyncTime", "long")
                        //.Replace("Command.Enums.", "")
                        + " " + p.Name + " { get; set; }");
                }
            }
            mpfile.AppendLine("    }");
            mpfile.AppendLine("}");
            File.WriteAllText(OutputDirectory + @"MessagePacks\" + messageName + ".cs", mpfile.ToString());
            return mpfile.ToString();
        }
        public static string DumpTable(TypeDefinition message)
        {
            var mpfile = new StringBuilder();
            var messageName = message.Name;
            mpfile.AppendLine("using MessagePack;");
            //mpfile.AppendLine("namespace ffecmp");
            if (message.Namespace.Length > 0)
                mpfile.AppendLine("namespace " + message.Namespace);
            else
                mpfile.AppendLine("namespace Command.DB");
            mpfile.AppendLine("{");
            mpfile.AppendLine("    [MessagePackObject] public class " + messageName);
            mpfile.AppendLine("    {");
            var i = 0;
            foreach (var p in message.Properties)
            {
                mpfile.AppendLine("        [Key(" + i++ + ")] public " + p.PropertyType.ToString() + " " + p.Name + " { get; set; }");
            }
            mpfile.AppendLine("    }");
            mpfile.AppendLine("}");
            File.WriteAllText(OutputDirectory + @"MessagePacks\" + messageName + ".cs", mpfile.ToString());
            return mpfile.ToString();
        }
        public static void Dump()
        {
            var assemblyDefinition = AssemblyDefinition.ReadAssembly(UnityAssembly);
            var messages = assemblyDefinition.MainModule.Types.Where(t => t.CustomAttributes.Any(a=>a.AttributeType.Name == "MemoryTableAttribute"));
            foreach (var message in messages)
            {
                DumpTable(message);
            }
        }
    }
}
