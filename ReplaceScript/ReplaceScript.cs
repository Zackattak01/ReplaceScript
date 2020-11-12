using System;

namespace ReplaceScript
{
    public class ReplaceScript
    {
        private bool isBuilt;
        public ReplaceScript(){
            isBuilt = false;
        }

        public static ReplaceScript Create()
        {
            return new ReplaceScript();
        }

        public ReplaceScript FromFile(string path){
            //init parser to parse from file
            return null;
        }

        public ReplaceScript FromString(string str){
            //init parser to parse from given string
            return null;
        }

        public ReplaceScript Build(){
            //execute tokenizing and parsing


            isBuilt = true;
            return null;
        }


    }
}
