namespace TicTacToe.API.Service.Strategy
{
    internal interface ITicTacToeStrategy
    {
        bool ApplyStrategy(char[][] boardMatrix);
    }
}
