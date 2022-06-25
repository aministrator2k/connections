using System.Drawing;

namespace Connections.UserInterface;

public class GameInputPrompt : IGameInputPrompt
{
    public Size GetBoardSize()
    {
        //TODO: validations
        Console.WriteLine("Enter board size, X:");
        string x = Console.ReadLine();
        Console.WriteLine("Enter board size, Y:");
        string y = Console.ReadLine();

        return new  Size(int.Parse(x), int.Parse(y));
    }
}