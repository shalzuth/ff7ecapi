namespace Utils
{
    public class Xor
    {
        public static byte[] Cipher(byte[] data, byte[] xorKey, int seed = 0)
        {
            var result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++) result[i] = (byte)(data[i] ^ xorKey[seed++ % xorKey.Length]);
            return result;
        }
        public static byte[] StaticFileCipher(byte[] buffer, string mask, byte firstByte = 0x55)
        {
            var headerLength = buffer.Length;
            var maskLen = mask.Length << 1;
            var maskBuffer = new byte[maskLen];
            StringToMaskBytes(mask, maskBuffer);
            var i = 0;
            var output = new byte[headerLength];
            do
            {
                var k = i / maskLen;
                output[i] = (byte)(maskBuffer[i - (k * maskLen)] ^ buffer[i]);
                i++;
            } while (i < headerLength);
            output[0] = firstByte; // U, from Unity
            return output;
        }
        private static void StringToMaskBytes(string mask, byte[] output)
        {
            var maskLen = mask.Length;
            int i = 0, j = 0, k = output.Length - 1;
            {
                do
                {
                    var c = mask[j];
                    j++;
                    output[i] = (byte)c;
                    i += 2;
                    output[k] = (byte)c;
                    k -= 2;
                } while (maskLen != j);
            }
            var byteLen = output.Length;
            int l = byteLen, a = 0;
            maskLen = 0xab;
            j = l;
            do
            {
                j--;
                maskLen = (((maskLen & 1) << 7) | (maskLen >> 1)) ^ output[a];
                a++;
            } while (j != 0);
            var b = 0;
            do
            {
                l--;
                output[b] = (byte)(output[b] ^ (byte)maskLen);
                b++;
            } while (l != 0);
        }
    }
}
