using Connections.Players;

namespace Connections.Gameplay;

public class SimpleTurnSelector : ITurnSelector
{
    private readonly Player[] _players;
    private int _counter = 0;

    // This could be a PlayerRepository instead
    public SimpleTurnSelector(Player[] players)
    {
        _players = players;
    }

    public Player Next()
    {
        return _players[_counter++ % 2];
    }
}