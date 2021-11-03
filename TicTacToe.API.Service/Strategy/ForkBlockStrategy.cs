using TicTacToe.API.Common;

namespace TicTacToe.API.Service.Strategy
{
    internal class ForkBlockStrategy : ITicTacToeStrategy
    {
        public bool ApplyStrategy(char[][] boardMatrix)
        {
            int[] emptySidePossible = new int[2] { -1, -1 };
            if(StrategyHelpers.ForkBlockCornerOne(boardMatrix, emptySidePossible)
                || StrategyHelpers.ForkBlockCornerTwo(boardMatrix, emptySidePossible))
            {
                boardMatrix[emptySidePossible[0]][emptySidePossible[1]] = Constants.PLAYER_O;
                return true;
            }

            return false;
        }
    }
}
