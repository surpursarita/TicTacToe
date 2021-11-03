using TicTacToe.API.Common;

namespace TicTacToe.API.Service.Strategy
{
    internal class CentreStrategy : ITicTacToeStrategy
    {
        public bool ApplyStrategy(char[][] boardMatrix)
        {
            if(boardMatrix[1][1].Equals(Constants.SPACE))
            {
                boardMatrix[1][1] = Constants.PLAYER_O;
                return true;
            }

            return false;
        }
    }
}
