using System;
using System.Collections.Generic;

namespace ReplaceScript
{
    internal class ActionArgumentsSupplier
    {
        List<INode> arguments;

        int index;

        public ActionArgumentsSupplier()
        {
            arguments = new List<INode>();
            index = -1;
        }

        public INode NextArgument()
        {
            index++;

            if (index >= arguments.Count - 1)
            {
                return null;
            }

            return arguments[index];
        }

        public void AddArgument(INode arg)
        {
            arguments.Add(arg);
        }

        public void AddArguments(IEnumerable<INode> args)
        {
            arguments.AddRange(args);
        }

    }
}