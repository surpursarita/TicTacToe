using TicTacToe.API.Common;

namespace TicTacToe.API.Service.Strategy
{
    internal class WinStrategy : ITicTacToeStrategy
    {
        public bool ApplyStrategy(char[][] boardMatrix)
        {
            int[] winPossible = new int[2] { -1, -1 };
            if (StrategyHelpers.WinRowOne(boardMatrix, Constants.PLAYER_O, winPossible)
                || StrategyHelpers.WinRowTwo(boardMatrix, Constants.PLAYER_O, winPossible)                
                || StrategyHelpers.WinRowThree(boardMatrix, Constants.PLAYER_O, winPossible)               
                || StrategyHelpers.WinColumnOne(boardMatrix, Constants.PLAYER_O, winPossible)               
                || StrategyHelpers.WinColumnTwo(boardMatrix, Constants.PLAYER_O, winPossible)               
                || StrategyHelpers.WinColumnThree(boardMatrix, Constants.PLAYER_O, winPossible)               
                || StrategyHelpers.WinDiagonalOne(boardMatrix, Constants.PLAYER_O, winPossible)               
                || StrategyHelpers.WinDiagonalTwo(boardMatrix, Constants.PLAYER_O, winPossible))
            {
                boardMatrix[winPossible[0]][winPossible[1]] = Constants.PLAYER_O;
                return true;
            }

            return false;
        }
    }
}
