using TicTacToe.API.Service.Interface;
using TicTacToe.API.Common;

namespace TicTacToe.API.Service.Service
{
    public class BoardValidateService: IBoardValidateService
    {
        public bool IsBoardValid(string board)
        {            
            if (string.IsNullOrEmpty(board))
                return true;

            char[] boardElements = board.ToUpper().ToCharArray();
            // It is invalid, if there are more or less than 9 characters.
            if (board.Length != 9)
            {
                return false;
            }
            else
            {
                int oCount = 0, xCount = 0, spaceCount = 0;
                foreach(char element in boardElements)
                {
                    if (element.Equals(Constants.PLAYER_O))
                    {
                        oCount++;
                    }
                    else if (element.Equals(Constants.PLAYER_X))
                    {
                        xCount++;
                    }
                    else if (element.Equals(Constants.SPACE))
                    {
                        spaceCount++;
                    }
                    // It is invalid, if any other character exists otjher than o,x or space
                    else
                    {
                        return false;
                    }
                }
                // It is invalid, if following are not true
                // O player is played as many as X Player (Player 1 is 'O')
                // X player is played one extra move than O Player (Player 1 is 'X')
                if (!(oCount.Equals(xCount) || oCount.Equals(xCount - 1)))
                {
                    return false;
                }
                // It is invalid, if no more moves are possible as board is full.
                else if (spaceCount.Equals(0))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
