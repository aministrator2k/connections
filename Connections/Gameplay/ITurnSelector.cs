using Connections.Players;

namespace Connections.Gameplay;

public interface ITurnSelector
{
    Player Next();
}