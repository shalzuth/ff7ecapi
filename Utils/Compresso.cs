using K4os.Compression.LZ4.Streams;
using System.IO.Compression;

namespace Utils
{
    public class Compresso
    {
        public static byte[] DecompressGz(byte[] data)
        {
            using (var compressedStream = new MemoryStream(data))
            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
            using (var resultStream = new MemoryStream())
            {
                zipStream.CopyTo(resultStream);
                return resultStream.ToArray();
            }
        }
        public static byte[] DecompressLz(byte[] data)
        {
            using var ms = new MemoryStream();
            using var dataStream = new MemoryStream(data);
            using var d = LZ4Stream.Decode(dataStream);
            d.CopyTo(ms);
            return ms.ToArray();
        }
        public static Stream DecompressLz(Stream stream)
        {
            using var ms = new MemoryStream();
            stream.CopyTo(ms);
            var data = ms.ToArray();
            var decompressed = DecompressLz(data);
            return new MemoryStream(decompressed);
        }
        public static byte[] CompressLz(byte[] data)
        {
            using (var ms = new MemoryStream())
            {
                using (var stream = LZ4Stream.Encode(ms))
                    stream.Write(data, 0, data.Length);
                return ms.ToArray();
            }
        }
        public static Stream CompressLz(Stream stream)
        {
            using var ms = new MemoryStream();
            stream.CopyTo(ms);
            var data = ms.ToArray();
            using (var ms2 = new MemoryStream())
            {
                using (var lzStream = LZ4Stream.Encode(ms2))
                    lzStream.Write(data, 0, data.Length);
                return ms2;
            }
        }
    }
}
