using System;

namespace ReplaceScript
{
    //the builder portion of this class
    public partial class ReplaceScript
    {
        private bool isBuilt;
        public ReplaceScript(){
            isBuilt = false;
        }

        public static ReplaceScript Create()
        {
            return new ReplaceScript();
        }
        
        //init parser to parse from file
        public ReplaceScript FromFile(string path){

            return null;
        }

        //init parser to parse from given string
        public ReplaceScript FromString(string str){
            
            return null;
        }

        //execute tokenizing and parsing
        //this builds the ReplaceScript rule once.  If the files changes the rule needs to be rebuilt
        public ReplaceScript Build(){
            


            isBuilt = true;
            return null;
        }
    }
}