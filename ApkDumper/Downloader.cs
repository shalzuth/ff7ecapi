using System.Net;
using System.Text.Json;
using System.Web;

namespace ApkDumper
{
    internal class Downloader
    {
        static string ObjToQueryString(object obj)
        {
            var step1 = JsonSerializer.Serialize(obj);
            var step2 = JsonSerializer.Deserialize<IDictionary<string, string>>(step1);
            var step3 = step2.Select(x => HttpUtility.UrlEncode(x.Key) + "=" + HttpUtility.UrlEncode(x.Value));
            return string.Join("&", step3);
        }
        static byte[] DownloadApp(string app)
        {
            var encoding = ObjToQueryString(new
            {
                supported_abis = "x86,armeabi-v7a,armeabi",
                device = "beyond1q",
                base_apk_version = "0",
                locale = "en",
                opengl = "196609",
                rooted = "true",
                screen = "900,1600",
                userId = "58009610",
                device_model = "SM-G973N",
                sdk_version = "22",
                base_apk_md5 = "null",
                user_id = "58009610",
                version_code = "317",
                version_name = "8.1.7",
                os = "android+5.1.1",
                adid = "", // snip in prod
                type = "app",
                uuid = "", // snip in prod
                device_id = "", // snip in prod
                package_id = "com.qooapp.qoohelper",
                otome = "0",
                token = "", // snip in prod
                android_id = "", // snip in prod
                sa_distinct_id = "", // snip in prod
                patch_code = "48",
                density = "320",
                system_locale = "en_US",
            });
            var webRequest = (HttpWebRequest)WebRequest.Create("https://api.qoo-app.com/v6/apps/" + app + "/download?" + encoding);
            webRequest.Headers.Clear();
            webRequest.Method = WebRequestMethods.Http.Get;
            webRequest.UserAgent = "QooApp 8.1.7";
            webRequest.Timeout = 150000;
            webRequest.Headers[HttpRequestHeader.AcceptEncoding] = "gzip";
            webRequest.Headers["device-id"] = ""; // snip in prod
            using (var response = webRequest.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var ms = new MemoryStream())
            {
                var buffer = new byte[4096];
                var count = 0;
                while ((count = stream.Read(buffer, 0, buffer.Length)) != 0)
                    ms.Write(buffer, 0, count);
                var rawResponse = ms.ToArray();
                return rawResponse;
            }
        }
        public static void DownloadApk(string com)
        {
            var apk = DownloadApp(com);
            File.WriteAllBytes(com + ".apk", apk);
        }
    }
}
