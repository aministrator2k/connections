using System.Drawing;
using Connections.Board;
using Connections.Gameplay;
using Connections.Players;
using Connections.Termination.Validator;
using Connections.UserInterface;

namespace Connections;

public class Game
{
    private readonly IGameInputPrompt _gameInput;
    private readonly IPlayerInputPrompt _playerInputPrompt;
    private readonly ITerminationValidator _terminationValidator;
    private readonly IGameResultOutput _resultOutput;
    private readonly IGridFactory _gridFactory;
    private readonly ITurnSelector _turnSelector;

    public Game(IGameInputPrompt gameInput, ITurnSelector turnSelector, IPlayerInputPrompt playerInputPrompt,
        ITerminationValidator terminationValidator, IGameResultOutput resultOutput, IGridFactory gridFactory)
    {
        _gameInput = gameInput;
        _turnSelector = turnSelector;
        _playerInputPrompt = playerInputPrompt;
        _terminationValidator = terminationValidator;
        _resultOutput = resultOutput;
        _gridFactory = gridFactory;
    }

    public void Run()
    {
        // Parse game input
        Size boardSize = _gameInput.GetBoardSize();

        // Initialize the board
        Grid board = _gridFactory.CreateGrid();

        TerminationResult result = TerminationResult.NotEnded;

        while (!result.IsEnded)
        {
            // Select Turn
            Player player = _turnSelector.Next();

            // Get Input
            Point nextMove = _playerInputPrompt.GetPlayerMove(player);

            // Optionally add validators to verify the move is acceptable

            // Apply Input to Board
            board.Set(nextMove, player);

            // Assess End Conditions
            result = _terminationValidator.Assess(board);
        }

        // print results
        _resultOutput.ShowResult(result);
    }
}