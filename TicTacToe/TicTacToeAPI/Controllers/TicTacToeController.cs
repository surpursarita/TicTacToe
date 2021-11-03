using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TicTacToe.API.Service.Interface;

namespace TicTacToe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicTacToeController : ControllerBase
    {
        private readonly ILogger<TicTacToeController> logger;
        private readonly IBoardValidateService boardValidateService;
        private readonly ITicTacToeService ticTacToeService;

        public TicTacToeController(ILogger<TicTacToeController> logger, IBoardValidateService boardValidateService, ITicTacToeService ticTacToeService)
        {
            this.logger = logger;
            this.boardValidateService = boardValidateService;
            this.ticTacToeService = ticTacToeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string board)
        {            
            if (!ModelState.IsValid || !boardValidateService.IsBoardValid(board))
            {
                return BadRequest();
            }

            board = board == null ? string.Empty : board;
            var response = await ticTacToeService.nextMove(board);
            return Ok(response);
        }
    }
}
