using TicTacToe.API.Common;

namespace TicTacToe.API.Service.Strategy
{
    internal class BlockStrategy : ITicTacToeStrategy
    {
        public bool ApplyStrategy(char[][] boardMatrix)
        {
            int[] winPossible = new int[2] { -1, -1 };
            if (StrategyHelpers.WinRowOne(boardMatrix, Constants.PLAYER_X, winPossible)
                || StrategyHelpers.WinRowTwo(boardMatrix, Constants.PLAYER_X, winPossible)                
                || StrategyHelpers.WinRowThree(boardMatrix, Constants.PLAYER_X, winPossible)               
                || StrategyHelpers.WinColumnOne(boardMatrix, Constants.PLAYER_X, winPossible)               
                || StrategyHelpers.WinColumnTwo(boardMatrix, Constants.PLAYER_X, winPossible)               
                || StrategyHelpers.WinColumnThree(boardMatrix, Constants.PLAYER_X, winPossible)               
                || StrategyHelpers.WinDiagonalOne(boardMatrix, Constants.PLAYER_X, winPossible)               
                || StrategyHelpers.WinDiagonalTwo(boardMatrix, Constants.PLAYER_X, winPossible))
            {
                boardMatrix[winPossible[0]][winPossible[1]] = Constants.PLAYER_O;
                return true;
            }

            return false;
        }
    }
}
