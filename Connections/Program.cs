// See https://aka.ms/new-console-template for more information

using Connections;
using Connections.Board;
using Connections.Board.TicTacToe;
using Connections.Gameplay;
using Connections.Players;
using Connections.Termination.Rules;
using Connections.Termination.Validator;
using Connections.UserInterface;

var game = new Game(new ConsoleGameInputPrompt(),
    new SimpleTurnSelector(new[]
    {
        new Player { Id = 1, Marker = new XMarker() },
        new Player { Id = 2, Marker = new OMarker() }
    }),
    new TicTacToeInputPrompt(),
    new TerminationValidator(new ITerminationRule[]
    {
        new RowTerminationRule(3),
        new ColTerminationRule(3),
        new DiagNeTerminationRule(3),
        new DiagSwTerminationRule(3),
        new BoardFullRule()
    }),
    new ConsoleResultOutput(),
    new TicTacToeGridFactory());

game.Run();