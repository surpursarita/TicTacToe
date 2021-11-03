using TicTacToe.API.Common;

namespace TicTacToe.API.Service.Strategy
{
    internal class OppositeCornerStrategy : ITicTacToeStrategy
    {
        public bool ApplyStrategy(char[][] boardMatrix)
        {
            int[] cornerPossible = new int[2] { -1, -1 };
            if(StrategyHelpers.OppositeCornerOne(boardMatrix, Constants.PLAYER_X, cornerPossible)
                || StrategyHelpers.OppositeCornerTwo(boardMatrix, Constants.PLAYER_X, cornerPossible)
                || StrategyHelpers.OppositeCornerThree(boardMatrix, Constants.PLAYER_X, cornerPossible)
                || StrategyHelpers.OppositeCornerFour(boardMatrix, Constants.PLAYER_X, cornerPossible))
            {
                boardMatrix[cornerPossible[0]][cornerPossible[1]] = Constants.PLAYER_O;
                return true;
            }

            return false;
        }
    }
}
