using System;

namespace ReplaceScript
{
    internal abstract class ActionNode : INode
    {
        protected string selection;
        protected ActionArgumentsSupplier argSupplier;

        protected ActionNode(string selection, ActionArgumentsSupplier argSupplier)
        {
            this.selection = selection;
            this.argSupplier = argSupplier;
        }

        public abstract string Evaluate();
    }
}