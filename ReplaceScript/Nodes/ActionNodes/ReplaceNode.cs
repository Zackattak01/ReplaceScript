using System;

namespace ReplaceScript
{
    internal class ReplaceNode : ActionNode
    {
        INode oldStr;
        INode newStr;

        public ReplaceNode(string selection, ActionArgumentsSupplier argSupplier) : base(selection, argSupplier)
        {
            oldStr = argSupplier.NextArgument();
            newStr = argSupplier.NextArgument();
        }

        public override string Evaluate()
        {
            return selection.Replace(oldStr.Evaluate(), newStr.Evaluate());
        }
    }
}