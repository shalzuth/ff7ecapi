using Google.Protobuf;
using MessagePack;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Utils;

namespace NetDumper
{
    public static class Dumper
    {
        public const string DefaultApiServerDomain = "https://game-q74z3cyn.app.gl.ffviiec.com";
        public const string DefaultApiServerDomainJp = "https://game-d92afpwh.app.jp.ffviiec.com";
        public const string DefaultWebviewDomain = "https://webview-w62j4u3y.app.gl.ffviiec.com";
        public static string resourcesUrl = "https://resources-api-c9ps53g2.app.gl.ffviiec.com/v1/";
        public static string dumpPath = @"data\";
        static HttpRequest http = new HttpRequest { };
        static JsonFormatter prettyJson = new JsonFormatter(JsonFormatter.Settings.Default.WithIndentation());
        static JsonSerializerOptions prettyJsonNet = new JsonSerializerOptions { WriteIndented = true };
        public static async Task DownloadTranslations()
        {
            var oldFiles = new Dictionary<string, string> { };
            if (File.Exists(dumpPath + @"masterData\masterLanguage.json"))
            {
                var oldData = JsonNode.Parse(File.ReadAllText(dumpPath + @"masterData\masterLanguage.json"));
                oldFiles = oldData["files"].AsArray().ToDictionary(f => f["name"].ToString(), f => f["hash"].ToString());
            }
            var data = JsonNode.Parse(Encoding.UTF8.GetString(Crypto.DecryptFile(await http.GetAsync(HttpRequest.MasterBaseUrl + HttpRequest.MasterLanguagePath))));

            Directory.CreateDirectory(dumpPath + @"masterData\en");
            File.WriteAllText(dumpPath + @"masterData\masterLanguage.json", data.ToJsonString(prettyJsonNet));
            foreach(var file in data["files"].AsArray())
            {
                var tableName = file["name"].ToString().StartsWith("m_") ? string.Join("", file["name"].ToString().Split('_').Skip(1).Select(s => s.Substring(0, 1).ToUpper() + s.Substring(1))) : file["name"].ToString();
                if (File.Exists(dumpPath + @"masterData\en\" + tableName + ".json"))
                {
                    if (file["hash"].ToString() == oldFiles[file["name"].ToString()])
                    {
                        continue;
                    }
                }
                var d = JsonNode.Parse(Encoding.UTF8.GetString(Compresso.DecompressGz(Crypto.DecryptFile(await http.GetAsync(HttpRequest.MasterBaseUrl + file["path"])))));
                File.WriteAllText(dumpPath + @"masterData\en\" + tableName + ".json", d.ToJsonString(prettyJsonNet));
            }
        }
        public static async Task DownloadMasterData()
        {
            var oldFiles = new Dictionary<string, string> { };
            if (File.Exists(dumpPath + @"masterData\masterData.json"))
            {
                var oldData = JsonNode.Parse(File.ReadAllText(dumpPath + @"masterData\masterData.json"));
                oldFiles = oldData["tables"].AsArray().ToDictionary(f => f["table"].ToString(), f => f["hash"].ToString());
            }
            var data = JsonNode.Parse(Encoding.UTF8.GetString(Crypto.DecryptFile(await http.GetAsync(HttpRequest.MasterBaseUrl + HttpRequest.MasterPath)))); // https://client-masterdata-c9ps53g2.app.gl.ffviiec.com/prd  /catalogs/CNZZCIADKN5MYGG4T7COL6DWDL7VIKDP6W3NG2UHGMCNWMIP5KWQ.json
            Directory.CreateDirectory(dumpPath + @"masterData\raw");
            Directory.CreateDirectory(dumpPath + @"masterData\tables");
            File.WriteAllText(dumpPath + @"masterData\masterData.json", data.ToJsonString(prettyJsonNet));
            foreach (var file in data["tables"].AsArray())
            {
                var tableName = String.Join("", file["table"].ToString().Split('_').Skip(1).Select(s => s.Substring(0, 1).ToUpper() + s.Substring(1)));
                if (File.Exists(dumpPath + @"masterData\tables\" + tableName + ".json"))
                {
                    if (oldFiles.ContainsKey(file["table"].ToString()) && file["hash"].ToString() == oldFiles[file["table"].ToString()])
                    {
                        continue;
                    }
                }
                var magic = new byte[] { 0x04, 0x22, 0x4D, 0x18, 0x60, 0x40, 0x82 };
                var encrypted = await http.GetAsync(HttpRequest.MasterBaseUrl + file["path"]);
                File.WriteAllBytes(dumpPath + @"masterData\raw\" + tableName + ".bin", encrypted);
                var decrypted = Crypto.DecryptFile(encrypted);
                if (!decrypted.Take(magic.Length).SequenceEqual(magic)) Console.WriteLine("BAD MAGIC FOR " + tableName);
                var decompressed = Compresso.DecompressLz(decrypted);
                var type = typeof(Command.DB.Accessory).Assembly.GetType("Command.DB." + tableName);
                if (type != null)
                {
                    type = typeof(List<>).MakeGenericType(type);
                    var obj = MessagePackSerializer.Deserialize(type, decompressed);
                    var output = JsonSerializer.Serialize(obj, prettyJsonNet);
                    File.WriteAllText(dumpPath + @"masterData\tables\" + tableName + ".json", output);
                }
            }
        }

        public static async Task DumpOcto()
        {
            //var revision = Octo.Proto.Database.Parser.ParseFrom(await http.GetResourceAsync(resourcesUrl + "revision/123173171")); // jp version
            var revision = Octo.Proto.Database.Parser.ParseFrom(await http.GetResourceAsync(resourcesUrl + "revision/123173179")); // gl version
            if (revision.Revision == 0)
            {

            }
           // var octocacheevai = Octo.Proto.Database.Parser.ParseFrom(await http.GetResourceAsync(resourcesUrl + "list/123173171/0")); // last thing filters more the higher you go
            var octocacheevai = Octo.Proto.Database.Parser.ParseFrom(await http.GetResourceAsync(resourcesUrl + "list/123173179/0")); // last thing filters more the higher you go
            Directory.CreateDirectory(dumpPath + "octo");
            File.WriteAllBytes(dumpPath + @"octo\octocacheevai.bin", octocacheevai.ToByteArray());
            File.WriteAllText(dumpPath + @"octo\octocacheevai.json", prettyJson.Format(octocacheevai));
            foreach (var data in octocacheevai.AssetBundleList)
            {
                if (data.Name == "environment/common/skybox.d") continue;
                var regenFile = true;
                if (File.Exists(dumpPath + @"octo\" + data.Name))
                {
                    if (data.Size == new FileInfo(dumpPath + @"octo\" + data.Name).Length)
                    {
                        //var crc = BitConverter.ToUInt32(new CRC32().ComputeHash( Xor.StaticFileCipher(File.ReadAllBytes(dumpPath + @"octo\" + data.Name), data.Name, 1)));
                        //if (data.Crc == oldoctocacheevai.AssetBundleList.FirstOrDefault(d => d.Name == data.Name)?.Crc)
                        {
                            regenFile = false;
                        }
                    }
                }
                if (regenFile)
                {
                    var assetPayload = await http.GetAsync(octocacheevai.UrlFormat.Replace("{o}", data.ObjectName), new Dictionary<string, string> {
                        { "Accept", "*/*" },
                        { "Accept-Encoding", "gzip, deflate, br" },
                        { "User-Agent", "FF7EC.47/25 CFNetwork/1410.0.3 Darwin/22.6.0" },
                    });
                    assetPayload = Xor.StaticFileCipher(assetPayload, data.Name);
                    Directory.CreateDirectory(Path.GetDirectoryName(dumpPath + @"octo\" + data.Name));
                    File.WriteAllBytes(dumpPath + @"octo\" + data.Name, assetPayload);
                    //var image = Helper.ExtractImage(assetPayload);
                    //if (image != null)
                    {
                        //image.SaveAsPng(dumpPath + @"octo\" + data.Name + ".png");
                    }
                }
            }
            foreach (var data in octocacheevai.ResourceList)
            {
                if (!File.Exists(dumpPath + @"octo\resources\" + data.Name))
                {
                    var file = await http.GetAsync(octocacheevai.UrlFormat.Replace("{o}", data.ObjectName), new Dictionary<string, string> {
                        { "Accept", "*/*" },
                        { "Accept-Encoding", "gzip, deflate, br" },
                        { "User-Agent", "FF7EC.47/25 CFNetwork/1410.0.3 Darwin/22.6.0" },
                    });
                    Directory.CreateDirectory(Path.GetDirectoryName(dumpPath + @"octo\resources\" + data.Name));
                    File.WriteAllBytes(dumpPath + @"octo\resources\" + data.Name, file);
                }
            }
        }
        public static void DumpImagesFromAssets()
        {
            //var files = Directory.GetFiles(dumpPath + @"octo\sprites\", "*.a", SearchOption.AllDirectories);
            //var files = Directory.GetFiles(dumpPath + @"octo\", "**ui**", SearchOption.AllDirectories);
            var files = Directory.GetFiles(dumpPath + @"octo\", "*", SearchOption.AllDirectories);
            //var files = Directory.GetFiles(dumpPath + @"octo\data\dungeonbuffgroup\ui", "*", SearchOption.AllDirectories);
            //var files = Directory.GetFiles(dumpPath + @"octo\data\dungeonmap", "*", SearchOption.AllDirectories);
           // var files = Directory.GetFiles(dumpPath + @"octo\data\", "*", SearchOption.AllDirectories);
          //  var files = Directory.GetFiles(dumpPath + @"octo\data\", "*", SearchOption.AllDirectories);
            var filePayloads = files.Select(f => File.ReadAllBytes(f));
            foreach (var file in files)
            {
                if (!(file.EndsWith(".a") || file.EndsWith(".d"))) continue;
                if (file.Contains("dungeoncamera")) continue;
                var assetPayload = File.ReadAllBytes(file);
                try
                {
                    //Console.WriteLine("parser : " + file);
                    /*var images = Helper.ExtractImage(assetPayload);
                    foreach (var image in images)
                    {
                        //Console.WriteLine("     " + image.Key);
                        //if (image.Key.StartsWith("tex")) continue;
                        var savePath = file.Replace(@"ff7ecdb\data\octo\", @"ff7ecdb\data\images\");
                        var saveDir = Path.GetDirectoryName(savePath);
                        Directory.CreateDirectory(saveDir);
                        image.Value.SaveAsPng(saveDir + @"\" + image.Key + ".png");
                    }*/
                }catch (Exception e)
                {
                }
            }
        }
    }
}
