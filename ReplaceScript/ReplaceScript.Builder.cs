using System;

namespace ReplaceScript
{
    //the builder portion of this class
    public partial class ReplaceScript
    {
        private bool isBuilt;
        private Parser parser;

        private ReplaceScript()
        {
            isBuilt = false;
        }

        public static ReplaceScript Create()
        {
            return new ReplaceScript();
        }

        //init parser to parse from file
        public ReplaceScript FromFile(string path)
        {
            FileInputProvider provider = new FileInputProvider(path);
            Tokenizer tokenizer = new Tokenizer(provider);
            parser = new Parser(tokenizer);

            return this;
        }

        //init parser to parse from given string
        public ReplaceScript FromString(string str)
        {
            var provider = new StringInputProvider(str);
            Tokenizer tokenizer = new Tokenizer(provider);
            parser = new Parser(tokenizer);
            return this;
        }


        //execute tokenizing and parsing
        //this builds the ReplaceScript rule once.  If the file changes the rule needs to be rebuilt
        public ReplaceScript Build()
        {



            isBuilt = true;
            return this;
        }
    }
}