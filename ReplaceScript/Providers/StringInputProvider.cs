using System;

namespace ReplaceScript
{
    public class StringInputProvider : IUnparsedInputProvider
    {
        string[] lines;
        int index = -1;

        public StringInputProvider(string str){
            lines = str.Split('\n');
        }

        public string NextLine()
        {
            index++;
            if(lines.Length-1 == index){
                return null;
            }

            return lines[0];
        }
    }
}