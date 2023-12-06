using Gee.External.Capstone;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkDumper
{
    public static class Unity
    {
        public static void ExtractRelevantFiles(string com)
        {
            var apk = File.ReadAllBytes(com + ".apk");
            using (var memory = new MemoryStream(apk))
            using (var zip = new ZipArchive(memory, ZipArchiveMode.Read))
            {
                foreach (var entry in zip.Entries)
                {
                    if (!(entry.Name.Equals("libil2cpp.so") || entry.Name.Equals("global-metadata.dat"))) continue;
                    entry.ExtractToFile(entry.Name, true);
                }
            }
        }
        public static byte[] ExtractXor()
        {
            var disassembler = CapstoneDisassembler.CreateArm64Disassembler(Gee.External.Capstone.Arm64.Arm64DisassembleMode.Arm);
            var armCode = File.ReadAllBytes("libil2cpp.so");
            var sigscan = new SigScanner(armCode);
            var addr = sigscan.FindPattern("0A 19 40 92 6B 6A 68 38"); // search "Metadata" in the file
            var xorLocs = disassembler.Disassemble(armCode.Skip(addr - 12).Take(12).ToArray());
            var pageAddress = ((addr - 12 + xorLocs[0].Address - 0x1000) & 0xfffff000) - 0x1000;
            var pageOffset = int.Parse(xorLocs[0].Operand.Split("0x")[1], NumberStyles.HexNumber);
            var absOffsetl = int.Parse(xorLocs[2].Operand.Split("#").Last().Replace("0x", ""), NumberStyles.HexNumber);
            var s = (int)pageAddress + pageOffset + absOffsetl;
            var xor = armCode.Skip(s).Take(128).ToArray();
            return xor;
        }
        public static void DumpIl2Cpp(string il2cppDumperPath)
        {
            Directory.Delete("il2cppdump", true);
            Directory.CreateDirectory("il2cppdump");
            var il2cpp = Process.Start(il2cppDumperPath + "Il2CppDumper.exe", new List<string> { "libil2cpp.so", "global-metadata-decrypted.dat", "il2cppdump" });
            il2cpp.WaitForExit();
        }
    }
}
