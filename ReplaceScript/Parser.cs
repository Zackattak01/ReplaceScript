using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ReplaceScript
{
    internal class Parser
    {
        //selection starts out as the string provided
        //can be changed by actions
        string currentSelection;
        private Tokenizer tokenizer;

        public Parser(Tokenizer tokenizer, string selection)
        {
            this.tokenizer = tokenizer;
            currentSelection = selection;
        }

        public INode Parse()
        {
            tokenizer.MoveNextLine();
            tokenizer.NextToken();
            INode node = ParseAction();
            return node;
        }

        private INode ParseAction()
        {
            INode selection = ParseSelection();

            Token currentToken = tokenizer.CurrentToken;

            ActionArgumentsSupplier argSupplier = ParseArguments();

            ActionNode actionNode = ParseActionToken(currentToken, argSupplier);
            return actionNode;
        }

        private ActionNode ParseActionToken(Token actionToken, ActionArgumentsSupplier supplier)
        {
            switch (actionToken)
            {
                case Token.Replace:
                    return new ReplaceNode(currentSelection, supplier);
                default:
                    throw new Exception("No action defined in line");
            }
        }

        private ActionArgumentsSupplier ParseArguments()
        {
            if (tokenizer.NextToken() != Token.Argument)
            {
                throw new InvalidOperationException("TODO: Implement proper exception!  Error: Expected Argument");
            }

            ActionArgumentsSupplier argumentsSupplier = new ActionArgumentsSupplier();
            argumentsSupplier.AddArgument(new StringArgumentNode(tokenizer.CurrentArgument));
            argumentsSupplier.AddArguments(ParseSuppliers());
            return argumentsSupplier;

        }
        private INode[] ParseSuppliers()
        {


            if (tokenizer.NextToken() == Token.With && tokenizer.NextToken() == Token.Argument)
            {
                return new INode[1] { new StringArgumentNode(tokenizer.CurrentArgument) };
            }
            else throw new Exception("BAD THING");
        }

        //no support for custom text selections has been included
        //return default selection as a result 
        private INode ParseSelection()
        {
            return new StringSelectionNode(currentSelection);
        }

    }
}