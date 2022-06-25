using System.Drawing;
using Connections.Players;

namespace Connections.UserInterface;

public interface IPlayerInputPrompt
{
    Point GetPlayerMove(Player player);
}