using System.Drawing;

namespace Connections.Board;

public interface IGridFactory
{
    Grid CreateGrid();
}

class TicTacToeGridFactory : IGridFactory
{
    public Grid CreateGrid()
    {
        return new Grid(new Size(3, 3)).Initialize();
    }
}