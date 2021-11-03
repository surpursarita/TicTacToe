using System.Threading.Tasks;
using TicTacToe.API.Service.Interface;
using TicTacToe.API.Service.Strategy;

namespace TicTacToe.API.Service.Service
{
    public class TicTacToeService: ITicTacToeService
    {
        public async Task<string> nextMove(string board)
        {
            var context = new Context();
            context.SetStrategy(new WinStrategy());
            var result = context.ExecuteStrategy(board);

            if (result != null)
                return result;
            
            context.SetStrategy(new BlockStrategy());
            result = context.ExecuteStrategy(board);

            if (result != null)
                return result;

            context.SetStrategy(new ForkBlockStrategy());
            result = context.ExecuteStrategy(board);

            if (result != null)
                return result;

            context.SetStrategy(new CentreStrategy());
            result = context.ExecuteStrategy(board);

            if (result != null)
                return result;

            context.SetStrategy(new OppositeCornerStrategy());
            result = context.ExecuteStrategy(board);

            if (result != null)
                return result;

            context.SetStrategy(new EmptyCornerStrategy());
            result = context.ExecuteStrategy(board);

            if (result != null)
                return result;

            context.SetStrategy(new EmptySideStrategy());
            result = context.ExecuteStrategy(board);

            if (result != null)
                return result;

            return board;
        }
    }
}
