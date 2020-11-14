using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace ReplaceScript
{
    //this class is to be inheritied in order to provide the runtime state i.e. the word the ReplaceScript is being executed on
    //state is synced across All StatefulNodes via the SyncState method.  New StatefulNode's are NOT subject to the syncing
    //this means all StatefulNodes will NOT have any state if SyncState is not called AFTER the Node's creation
    public abstract class StatefulNode : INode
    {
        protected string selection;

        protected StatefulNode()
        {
            StateChanged += StateSync;
        }

        private void StateSync(string newSelection)
        {
            selection = newSelection;
        }

        protected delegate void StateChangedHandler(string newSelection);

        protected static StateChangedHandler StateChanged;

        public static void SyncState(string selection)
        {
            StateChanged(selection);
        }

        public abstract string Evaluate();
    }
}