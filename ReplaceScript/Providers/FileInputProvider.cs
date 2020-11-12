using System;
using System.IO;
using System.Text;

namespace ReplaceScript
{
    public class FileInputProvider : IUnparsedInputProvider
    {
        StreamReader streamReader;

        public FileInputProvider(string path){
            streamReader = new StreamReader(path);
        }

        public string NextLine()
        {
            return streamReader.ReadLine();
        }
    }
}