using Connections.Board;
using Connections.Players;
using Connections.Termination.Validator;

namespace Connections.Termination.Rules;

internal class RowTerminationRule : ITerminationRule
{
    // We new it here because it is an internal implementation and not a dependency
    private readonly LineFinder _lineFinder = new();
    private readonly int _lineLength;

    public RowTerminationRule(int lineLength)
    {
        _lineLength = lineLength;
    }

    public TerminationResult Assess(Grid board)
    {
        return _lineFinder.Find(board, new NavigationParameters
        {
            RowStart = 0,
            RowEnd = board.GetWidth() - _lineLength + 1,
            ColStart = 0,
            ColEnd = board.GetHeight(),
            RowIncFactor = 0,
            ColIncFactor = 1,
            LineLength = _lineLength
        });
    }
}