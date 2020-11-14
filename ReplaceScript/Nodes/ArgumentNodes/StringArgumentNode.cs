using System;

namespace ReplaceScript
{
    internal class StringArgumentNode : INode
    {
        private string arg;
        public StringArgumentNode(string arg)
        {
            this.arg = arg;
        }

        public string Evaluate()
        {
            return arg;
        }
    }
}