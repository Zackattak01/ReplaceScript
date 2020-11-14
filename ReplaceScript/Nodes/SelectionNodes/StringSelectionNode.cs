using System;

namespace ReplaceScript
{
    internal class StringSelectionNode : INode
    {
        private string selection;
        public StringSelectionNode(string selection)
        {
            this.selection = selection;
        }

        public string Evaluate()
        {
            return selection;
        }
    }
}