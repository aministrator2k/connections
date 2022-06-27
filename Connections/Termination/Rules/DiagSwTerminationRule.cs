using Connections.Board;
using Connections.Players;
using Connections.Termination.Validator;

namespace Connections.Termination.Rules;

internal class DiagSwTerminationRule : ITerminationRule
{
    // We new it here because it is an internal implementation and not a dependency
    private readonly LineFinder _lineFinder = new();
    private readonly int _lineLength;

    public DiagSwTerminationRule(int lineLength)
    {
        _lineLength = lineLength;
    }

    public TerminationResult Assess(Grid board)
    {
        return _lineFinder.Find(board, new NavigationParameters
        {
            RowStart = _lineLength - 1,
            RowEnd = board.GetWidth(),
            ColStart = _lineLength - 1,
            ColEnd = board.GetHeight(),
            RowIncFactor = -1,
            ColIncFactor = -1,
            LineLength = _lineLength
        });
    }
}