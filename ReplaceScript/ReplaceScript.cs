using System;
using System.Data;

namespace ReplaceScript
{
    //the non-builder portion of this class
    public partial class Script
    {
        public string Execute(string str)
        {
            if (!isBuilt)
            {
                throw new Exception("Replace Script has not been built");
            }

            StatefulNode.SyncState(str);
            return headNode.Evaluate();
        }
    }
}
