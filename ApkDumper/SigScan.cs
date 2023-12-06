namespace ApkDumper
{
    public class SigScanner
    {
        private byte[] buffer;
        public SigScanner(byte[] bytes)
        {
            buffer = bytes;
        }
        bool ComparePattern(int o, byte[] pattern)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == 0) continue;
                if (pattern[i] != buffer[o + i]) return false;
            }
            return true;
        }
        public int FindPattern(string stringPattern)
        {
            var pattern = stringPattern.Split(' ').Select(b => b == "?" ? (byte)0 : Convert.ToByte(b, 16)).ToArray();
            for (var i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] != pattern[0]) continue;
                if (ComparePattern(i, pattern)) return i;
            }
            throw new Exception("not found");
        }
    }
}
