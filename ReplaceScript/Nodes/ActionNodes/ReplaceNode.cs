using System;

namespace ReplaceScript
{
    internal class ReplaceNode : ActionNode
    {
        INode oldStr;
        INode newStr;

        public ReplaceNode(ActionArgumentsSupplier argSupplier) : base(argSupplier)
        {
            oldStr = argSupplier.NextArgument();

            if (oldStr == null)
            {
                throw new ArgumentException("The \"Replace\" action requires two arguements", "oldStr");
            }

            newStr = argSupplier.NextArgument();

            if (newStr == null)
            {
                throw new ArgumentException("The \"Replace\" action requires two arguements", "newStr");
            }
        }

        public override string Evaluate()
        {
            return selection.Replace(oldStr.Evaluate(), newStr.Evaluate());
        }
    }
}