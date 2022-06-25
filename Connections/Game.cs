using System.Drawing;
using Connections.Board;
using Connections.Gameplay;
using Connections.Players;
using Connections.UserInterface;

namespace Connections;

public class Game
{
    private readonly IGameInputPrompt _gameInput;
    private readonly ITurnSelector _turnSelector;
    private readonly IPlayerInputPrompt _playerInputPrompt;

    public Game(IGameInputPrompt gameInput, ITurnSelector turnSelector, IPlayerInputPrompt playerInputPrompt)
    {
        _gameInput = gameInput;
        _turnSelector = turnSelector;
        _playerInputPrompt = playerInputPrompt;
    }

    public void Run()
    {
        // Parse game input
        var boardSize = _gameInput.GetBoardSize();

        // Initialize the board
        var boardGrid = new Grid(boardSize); // Could use a factory class instead of new
        boardGrid.Initialize();


        // Select Turn
        Player player = _turnSelector.Next();

        // Get Input
        Point nextMove = _playerInputPrompt.GetPlayerMove(player);

        // Apply Input to Board
        boardGrid.Set(nextMove, player);

        // Validate End Conditions
        // .repeat
    }
}