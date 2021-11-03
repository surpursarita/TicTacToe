using TicTacToe.API.Common;

namespace TicTacToe.API.Service.Strategy
{
    internal class EmptySideStrategy : ITicTacToeStrategy
    {
        public bool ApplyStrategy(char[][] boardMatrix)
        {
            int[] emptySidePossible = new int[2] { -1, -1 };
            if(StrategyHelpers.EmptySideOne(boardMatrix, emptySidePossible)
                || StrategyHelpers.EmptySideTwo(boardMatrix, emptySidePossible)
                || StrategyHelpers.EmptySideThree(boardMatrix, emptySidePossible)
                || StrategyHelpers.EmptySideFour(boardMatrix, emptySidePossible))
            {
                boardMatrix[emptySidePossible[0]][emptySidePossible[1]] = Constants.PLAYER_O;
                return true;
            }

            return false;
        }
    }
}
