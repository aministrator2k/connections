using System.Drawing;
using Connections.Players;

namespace Connections.UserInterface;

public class TicTacToeInputPrompt : IPlayerInputPrompt
{
    public Point GetPlayerMove(Player player)
    {
        Console.WriteLine($"Player {player.Id}, your marker is {player.Marker}.");
        Console.WriteLine($"Enter X for your next move:");
        string x = Console.ReadLine();
        Console.WriteLine($"Enter Y for your next move:");
        string y = Console.ReadLine();

        return new Point(int.Parse(x), int.Parse(y));
    }
}