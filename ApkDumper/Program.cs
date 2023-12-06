var ff7ecPkg = "com.square_enix.android_googleplay.ff7ecww";
ApkDumper.Downloader.DownloadApk(ff7ecPkg);
ApkDumper.Unity.ExtractRelevantFiles(ff7ecPkg);
var xor = ApkDumper.Unity.ExtractXor();
File.WriteAllBytes("global-metadata-decrypted.dat", Utils.Xor.Cipher(File.ReadAllBytes("global-metadata.dat"), xor));
ApkDumper.Unity.DumpIl2Cpp(@"Il2CppDumper\"); // put in path to Il2CppDumper -> https://github.com/Perfare/Il2CppDumper