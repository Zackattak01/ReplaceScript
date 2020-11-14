using System;

namespace ReplaceScript
{
    internal abstract class ActionNode : StatefulNode
    {
        protected ActionArgumentsSupplier argSupplier;

        protected ActionNode(ActionArgumentsSupplier argSupplier)
        {
            this.argSupplier = argSupplier;
        }

    }
}