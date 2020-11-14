using System;

namespace ReplaceScript
{
    public class DefaultSelectionNode : StatefulNode
    {
        public override string Evaluate()
        {
            return selection;
        }
    }
}