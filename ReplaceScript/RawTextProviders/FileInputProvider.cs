using System;
using System.IO;
using System.Text;

namespace ReplaceScript
{
    public class FileInputProvider : IUnparsedInputProvider
    {
        StreamReader streamReader;
        string path;

        public FileInputProvider(string path)
        {
            this.path = path;
        }

        public string NextLine()
        {
            if (streamReader == null)
            {
                streamReader = new StreamReader(path);
            }

            string line = streamReader.ReadLine();

            if (line == null)
            {
                streamReader.Dispose();
                streamReader = null;
                return null;
            }

            return line;
        }


    }
}