using System.Threading.Tasks;

namespace TicTacToe.API.Service.Interface
{
    public interface ITicTacToeService
    {
        Task<string> nextMove(string board);
    }
}
