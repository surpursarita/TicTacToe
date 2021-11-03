using System;
using System.Text;

namespace TicTacToe.API.Service.Strategy
{
    // The Context defines the interface of interest to clients.
    internal class Context
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private ITicTacToeStrategy ticTacToeStrategy;

        public Context()
        { }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public Context(ITicTacToeStrategy ticTacToeStrategy)
        {
            this.ticTacToeStrategy = ticTacToeStrategy;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(ITicTacToeStrategy ticTacToeStrategy)
        {
            this.ticTacToeStrategy = ticTacToeStrategy;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public string ExecuteStrategy(string board)
        {
            char[] boardElements = board.Equals(string.Empty) ? "         ".ToCharArray() : board.ToUpper().ToCharArray();
            char[][] boardMatrix = new char[][] { "   ".ToCharArray(), "   ".ToCharArray(), "   ".ToCharArray() };
            for (int i = 0, k = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardMatrix[i][j] = boardElements[k];
                    k++;
                }
            }
            
            if (this.ticTacToeStrategy.ApplyStrategy(boardMatrix))
            {
                for (int i = 0, k = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        boardElements[k] = boardMatrix[i][j];
                        k++;
                    }
                }
                return new string(boardElements);
            }

            return null;
        }
    }
}
