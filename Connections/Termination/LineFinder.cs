using Connections.Board;
using Connections.Players;

namespace Connections.Termination;

internal class NavigationParameters
{
    public int RowStart { get; set; }
    public int RowEnd { get; set; }
    public int ColStart { get; set; }
    public int ColEnd { get; set; }
    public int LineLength { get; set; }
    public int RowIncFactor { get; set; }
    public int ColIncFactor { get; set; }
}

// This is an internal helper class and as such will be tested indirectly with other classes unit tests
internal class LineFinder
{
    public Player? Find(Grid board, NavigationParameters nav)
    {
        for (int i = nav.RowStart; i < nav.RowEnd; i++)
        {
            for (int j = nav.ColStart; j < nav.ColEnd; j++)
            {
                bool found = true;
                Player curVal = board.Get(i, j);
                for (int k = 1; k < nav.LineLength; k++)
                {
                    if (board.Get(i + nav.RowIncFactor * k, j +  nav.ColIncFactor * k) != curVal)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                    return curVal;
            }
        }

        return null;
    }
}