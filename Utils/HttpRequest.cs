using Api;
using Google.Protobuf;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Collections;
namespace Utils
{
    public class HttpRequest
    {
        static HttpClientHandler _handler = new HttpClientHandler { };
        static HttpClient _client = new HttpClient(_handler);
        public async Task<byte[]> GetResourceAsync(string uri)
        {
            return await GetAsync(uri, new Dictionary<string, string> {
            { "User-Agent", "FF7EC.47/25 CFNetwork/1410.0.3 Darwin/22.6.0" },
            { "Accept", "application/x-protobuf,x-octo-app/0" },
           // { "X-OCTO-KEY", "6sbcaxqe9tj505wkb97o7pisx03g0sd4" },
            { "X-OCTO-KEY", "10kd245cqkwhjy95okob5h8ayg59xhve" },
            { "Accept-Language", "en-US,en;q=0.9" },
            //{ "Content-Length", "0" },
            { "Accept-Encoding", "gzip, deflate, br" },
            { "X-Unity-Version", "2021.3.16f1" }
        });
        }
        static Dictionary<string, string> masterDataHeaders = new Dictionary<string, string> {
            { "Accept", "*/*" },
            { "Accept-Encoding", "gzip, deflate, br" },
            { "User-Agent", "FF7EC.47/25 CFNetwork/1410.0.3 Darwin/22.6.0" },
            { "Accept-Language", "en-US,en;q=0.9" },
            { "X-Unity-Version", "2021.3.16f1" }
        };

        public async Task<byte[]> GetAsync(string uri)
        {
            return await GetAsync(uri, masterDataHeaders);
        }
        public async Task<byte[]> GetAsync(string uri, Dictionary<string, string> headers = null)
        {
            if (headers == null) headers = masterDataHeaders;
            _client.DefaultRequestHeaders.Clear();
            headers.ToList().ForEach(h => _client.DefaultRequestHeaders.Add(h.Key, h.Value));
            using var response = await _client.GetAsync(uri);
            return await response.Content.ReadAsByteArrayAsync();
        }

        public async Task<string> PostAsync(string uri, string data, string contentType)
        {
            using HttpContent content = new StringContent(data, Encoding.UTF8, contentType);

            HttpRequestMessage requestMessage = new HttpRequestMessage()
            {
                Content = content,
                Method = HttpMethod.Post,
                RequestUri = new Uri(uri)
            };

            using HttpResponseMessage response = await _client.SendAsync(requestMessage);

            return await response.Content.ReadAsStringAsync();
        }
        public Dictionary<string, IEnumerable<string>> ResponseHeaders = new Dictionary<string, IEnumerable<string>>();
        public Guid DeviceId = Guid.NewGuid();
        public string LoginToken = "";
        public string XToken;
        public Dictionary<string, string> HeaderHack = new Dictionary<string, string> { };
        public static string xmasterpath = "/catalogs/4EYMOQ6ON2MAY6SESEBQZH7CGEKSNWNDNVPTDR2D5ZJ2JUK7U2HQ.json";

        public Entity.Tables UserData = new Entity.Tables();
        public static string MasterBaseUrl = "";
        public static string MasterLanguagePath = "";
        public static string MasterPath = "";
        public async Task<T> ApiRequestAsync<T>(string uri, IMessage data) where T : IMessage
        {
            var requestMessage = new HttpRequestMessage { RequestUri = new Uri(uri), Method = HttpMethod.Get };
            requestMessage.Headers.Clear();
            var apiRequest = new ApiRequest
            {
                Common = new Entity.CommonRequest { OnetimeToken = "355b6511-ec5a-4599-b7b9-d9dab556f17bgl9yBcZ8jStIcnhf1p1dPECyk9uJmvHDEe7kj3bFMYw=" },
            };
            var xToken = XToken ?? (ResponseHeaders.ContainsKey("X-Token") ? ResponseHeaders["X-Token"].FirstOrDefault() : null);
            if (xToken != null)
            {
                apiRequest.Common.OnetimeToken = xToken;
                requestMessage.Headers.Add("x-token", xToken);
            }
            var p = apiRequest.GetType().GetProperties().First(p => p.PropertyType == data.GetType());
            p.SetValue(apiRequest, data);
            var reqBytes = apiRequest.ToByteArray();
            requestMessage.Headers.Add("Accept", "application/protobuf");
            requestMessage.Headers.Add("Accept-Encoding", "lz4");
            requestMessage.Headers.Add("Accept-Language", "en-US,en;q=0.9");
            requestMessage.Headers.Add("User-Agent", "FF7EC.96/32 CFNetwork/1410.0.3 Darwin/22.6.0");
            if (data.GetType().Name.EndsWith("BattleEndRequest"))
            {
                throw new Exception(":)");
            }
            requestMessage.Headers.Add("x-country-code", "US");
            requestMessage.Headers.Add("x-battle-server-area-id", "1");
            requestMessage.Headers.Add("x-content-encoding-secure", "1");
            requestMessage.Headers.Add("x-device-name", "iPhone12,1");
            requestMessage.Headers.Add("x-advertising-id", "00000000-0000-0000-0000-000000000000");
            requestMessage.Headers.Add("x-platform-type", "1");
            //requestMessage.Headers.Add("x-adjust-id", ""); // snip
            requestMessage.Headers.Add("x-device-id", DeviceId.ToString().ToUpper());
            requestMessage.Headers.Add("x-terminal-id", DeviceId.ToString().ToUpper());
            requestMessage.Headers.Add("x-os-version", "iOS 16.6.1");
            requestMessage.Headers.Add("X-Unity-Version", "2021.3.16f1");
            requestMessage.Headers.Add("x-app-version", "1.3.20");
            requestMessage.Headers.Add("x-language", "en");
            requestMessage.Headers.Add("x-server-master-version", "1696816297");
            requestMessage.Headers.Add("x-accept-encoding-secure", "1");
            requestMessage.Headers.Add("x-keychain-user-id", "123456789123456789");
            if (ResponseHeaders.ContainsKey("X-Master-Path")) xmasterpath = ResponseHeaders["X-Master-Path"].First();
            requestMessage.Headers.Add("x-master-path", xmasterpath);
            var compressed = Compresso.CompressLz(reqBytes);
            var encrypted = Crypto.EncryptApi(compressed);
            var sha256 = Convert.ToBase64String(SHA256.HashData(compressed)).Replace("+","-").Replace("/","_");
            requestMessage.Headers.Add("x-content-hash", sha256);
            if (data is GetCheckRequest) encrypted = new byte[0];
            using var content = new ByteArrayContent(encrypted);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/protobuf");
            content.Headers.ContentEncoding.Add("lz4");
            requestMessage.Content = content;
            if (encrypted.Length > 0) requestMessage.Method = HttpMethod.Post;

            using var response = await _client.SendAsync(requestMessage);
            if (response.StatusCode == (HttpStatusCode)482) // ip ban on reg
            {
                throw new Exception("ip banned");
            }
            var responseBytes = await response.Content.ReadAsByteArrayAsync();
            ResponseHeaders = response.Headers.ToDictionary();
            if (ResponseHeaders.ContainsKey("X-Token")) XToken = ResponseHeaders["X-Token"].FirstOrDefault();
            try
            {
                responseBytes = Crypto.DecryptApi(responseBytes);
            }
            catch { }
            try
            {
                responseBytes = Compresso.DecompressLz(responseBytes);
            }
            catch { }
            var apiResponse = ApiResponse.Parser.ParseFrom(responseBytes);
            apiResponse.Common?.User?.Update?.GetType().GetProperties().Where(p=> p.Name != "Parser" && p.Name != "Descriptor").ToList().ForEach(p =>
            {
                var update = p.GetValue(apiResponse.Common.User.Update) as IEnumerable;
                if (update?.Cast<object>().Count() > 0)
                {
                    var fieldName = p.Name.Substring(0, 1).ToLower() + p.Name.Substring(1) + "_";
                    var f = apiResponse.Common.User.Update.GetType().GetField(fieldName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    var origArray = f.GetValue(UserData);
                    var addRange = origArray.GetType().GetMethod("AddRange");
                    addRange.Invoke(origArray, new object[1] { update });
                }
            });
            if (data is GetCheckRequest)
            {
                MasterBaseUrl = ResponseHeaders["X-Master-Base-Url"].First();
                MasterLanguagePath = ResponseHeaders["X-Master-Language-Path"].First();
                MasterPath = ResponseHeaders["X-Master-Path"].First();
            }
            if (response.IsSuccessStatusCode)
            {
                var obj = apiResponse.GetType().GetProperties().First(p => p.PropertyType == typeof(T));
                return (T)obj.GetValue(apiResponse);
            }
            else
            {
                throw new Exception("API ERROR on " + uri + " : " + apiResponse);
            }
        }
    }
}