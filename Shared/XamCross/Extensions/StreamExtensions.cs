using System;
using System.IO;
using System.Threading.Tasks;

namespace XamCross
{
    public static class StreamExtensions
    {
        public static byte[] ToBytes(this Stream input, long offset, int length)
        {
            input.Seek(offset, SeekOrigin.Begin);

            var contents = new byte[length];
            var len = input.Read(contents, 0, contents.Length);

            if (len == length)
            {
                return contents;
            }

            var rest = new byte[len];

            Array.Copy(contents, rest, len);

            return rest;
        }

        public static async Task<byte[]> ToBytesAsync(this Stream input, long offset, int length)
        {
            input.Seek(offset, SeekOrigin.Begin);

            var contents = new byte[length];
            var len = await input.ReadAsync(contents, 0, contents.Length);

            if (len == length)
            {
                return contents;
            }

            var rest = new byte[len];

            Array.Copy(contents, rest, len);

            return rest;
        }
    }
}