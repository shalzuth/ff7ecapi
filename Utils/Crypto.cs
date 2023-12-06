using System.Security.Cryptography;
namespace Utils
{
    public static class Crypto
    {
        static byte[] DecryptAes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                var ms = new MemoryStream();
                using (var msDecrypt = new MemoryStream(cipherText))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    csDecrypt.CopyTo(ms);
                return ms.ToArray();
            }
        }
        static byte[] EncryptAes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using var ms = new MemoryStream();
                using (var msDecrypt = new MemoryStream(cipherText))
                using (var csDecrypt = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    msDecrypt.CopyTo(csDecrypt);
                return ms.ToArray();
            }
        }
        public static byte[] DecryptFile(byte[] payload)
        {
            var key = new byte[] { 102, 213, 122, 113, 226, 89, 169, 26, 130, 132, 188, 167, 10, 45, 6, 6, 121, 122, 150, 83, 91, 70, 132, 153, 161, 61, 144, 105, 181, 62, 72, 144 };
            return Decrypt(payload, key);
        }
        public static byte[] EncryptFile(byte[] payload)
        {
            var key = new byte[] { 102, 213, 122, 113, 226, 89, 169, 26, 130, 132, 188, 167, 10, 45, 6, 6, 121, 122, 150, 83, 91, 70, 132, 153, 161, 61, 144, 105, 181, 62, 72, 144 };
            return Encrypt(payload, key);
        }
        public static byte[] Decrypt(byte[] payload, byte[] key)
        {
            var iv = payload.Take(16).ToArray();
            var data = payload.Skip(16).ToArray();
            return DecryptAes(data, key, iv);
        }
        public static byte[] Encrypt(byte[] payload, byte[] key)
        {
            var iv = RandomNumberGenerator.GetBytes(16);
            return iv.Concat(EncryptAes(payload, key, iv)).ToArray();
        }
        public static byte[] clientApiKey = Convert.FromBase64String("Gs69+UiZDGBrjzj0uGq/m6mFs66bBUAP5ykHOROesZ4=");
        public static byte[] serverApiKey = Convert.FromBase64String("CMMnsenXvr7izAFborJvCZHwFrG40sykNgUSqgJ99+A=");
        public static byte[] EncryptApi(byte[] payload)
        {
            if (payload.Length == 0) return payload;
            var iv = RandomNumberGenerator.GetBytes(16);
            return iv.Concat(EncryptAes(payload, clientApiKey, iv)).ToArray();
        }
        public static byte[] EncryptApi(byte[] payload, bool client = true)
        {
            if (payload.Length == 0) return payload;
            var iv = RandomNumberGenerator.GetBytes(16);
            if (client) return iv.Concat(EncryptAes(payload, clientApiKey, iv)).ToArray();
            else return iv.Concat(EncryptAes(payload, serverApiKey, iv)).ToArray();
        }
        public static byte[] DecryptApi(byte[] payload, bool server = true)
        {
            var iv = payload.Take(16).ToArray();
            var data = payload.Skip(16).ToArray();
            if (server) return DecryptAes(data, serverApiKey, iv);
            else return DecryptAes(data, clientApiKey, iv);
        }
    }
}
