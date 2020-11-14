using System;

namespace ReplaceScript
{
    internal class Tokenizer
    {
        public Token CurrentToken { get; private set; }
        public string CurrentArgument { get; private set; }

        private IUnparsedInputProvider inputProvider;


        private string[] unparsedTokens;

        private int unparsedTokenIndex;

        public Tokenizer(IUnparsedInputProvider provider)
        {
            inputProvider = provider;
        }

        private string NextUnparsedToken()
        {
            unparsedTokenIndex++;
            return unparsedTokens[unparsedTokenIndex];
        }

        public void MoveNextLine()
        {
            unparsedTokens = inputProvider.NextLine().Split(' ');
            unparsedTokenIndex = -1;
        }

        public Token NextToken()
        {
            string currentUnparsedToken = NextUnparsedToken().ToLower();

            switch (currentUnparsedToken)
            {
                case "replace":
                    CurrentToken = Token.Replace;
                    return Token.Replace;

                case "with":
                    CurrentToken = Token.With;
                    return Token.With;


            }

            CurrentArgument = currentUnparsedToken;
            return Token.Argument;
        }


    }
}