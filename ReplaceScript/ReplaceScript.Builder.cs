using System;

namespace ReplaceScript
{
    //the builder portion of this class
    public partial class Script
    {
        private bool isBuilt;
        private Parser parser;

        private ActionNode headNode;

        private Script()
        {
            isBuilt = false;
        }

        public static Script Create()
        {
            return new Script();
        }

        //init parser to parse from file
        public Script FromFile(string path)
        {
            FileInputProvider provider = new FileInputProvider(path);
            Tokenizer tokenizer = new Tokenizer(provider);
            parser = new Parser(tokenizer);

            return this;
        }

        //init parser to parse from given string
        public Script FromString(string str)
        {
            var provider = new StringInputProvider(str);
            Tokenizer tokenizer = new Tokenizer(provider);
            parser = new Parser(tokenizer);
            return this;
        }


        //execute tokenizing and parsing
        //this builds the ReplaceScript rule once.  If the file changes the rule needs to be rebuilt
        public Script Build()
        {
            headNode = parser.Parse();

            isBuilt = true;
            return this;
        }
    }
}