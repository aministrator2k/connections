using Connections.Board;
using Connections.Players;
using Connections.Termination.Validator;

namespace Connections.Termination.Rules;

public class ColTerminationRule : ITerminationRule
{
    // We new it here because it is an internal implementation and not a dependency
    private readonly LineFinder _lineFinder = new();
    private readonly int _lineLength;

    public ColTerminationRule(int lineLength)
    {
        _lineLength = lineLength;
    }

    public TerminationResult Assess(Grid board)
    {
        return _lineFinder.Find(board, new NavigationParameters
        {
            RowStart = 0,
            RowEnd = board.GetWidth(),
            ColStart = 0,
            ColEnd = board.GetHeight() - _lineLength + 1,
            RowIncFactor = 1,
            ColIncFactor = 0,
            LineLength = _lineLength
        });
    }
}