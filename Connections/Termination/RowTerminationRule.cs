using Connections.Board;
using Connections.Players;

namespace Connections.Termination;

class RowTerminationRule : ITerminationRule
{
    private readonly int _lineLength;
    private readonly LineFinder _lineFinder = new (); // We new it here because it is an internal implementation and not a dependency

    public RowTerminationRule(int lineLength)
    {
        _lineLength = lineLength;
    }

    public Player? Find(Grid board)
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