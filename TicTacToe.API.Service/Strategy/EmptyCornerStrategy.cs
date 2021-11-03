using TicTacToe.API.Common;

namespace TicTacToe.API.Service.Strategy
{
    internal class EmptyCornerStrategy : ITicTacToeStrategy
    {
        public bool ApplyStrategy(char[][] boardMatrix)
        {
            int[] emptyCornerPossible = new int[2] { -1, -1 };
            if(StrategyHelpers.EmptyCornerOne(boardMatrix, emptyCornerPossible)
                || StrategyHelpers.EmptyCornerTwo(boardMatrix, emptyCornerPossible)
                || StrategyHelpers.EmptyCornerThree(boardMatrix, emptyCornerPossible)
                || StrategyHelpers.EmptyCornerFour(boardMatrix, emptyCornerPossible))
            {
                boardMatrix[emptyCornerPossible[0]][emptyCornerPossible[1]] = Constants.PLAYER_O;
                return true;
            }

            return false;
        }
    }
}
