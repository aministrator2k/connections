using System.Drawing;
using Connections.Players;

namespace Connections.Board;

public class Grid
{
    private readonly Box[,] _boxes;

    public Grid(Size boardSize)
    {
        _boxes = new Box[boardSize.Width, boardSize.Height];
    }

    public Grid Initialize()
    {
        for (int i = 0; i < _boxes.GetLength(0); i++)
            for (int j = 0; j < _boxes.GetLength(1); j++)
                _boxes[i, j] = new Box();

        return this;
    }

    public void Set(Point location, Player player)
    {
        // TODO: Validations
        _boxes[location.X, location.Y].Player = player;
    }

    public Player Get(Point location)
    {
        return Get(location.X, location.Y);
    }

    public Player Get(int x, int y)
    {
        return _boxes[x, y].Player;
    }

    public int GetWidth()
    {
        return _boxes.GetLength(0);
    }

    public int GetHeight()
    {
        return _boxes.GetLength(1);
    }
}