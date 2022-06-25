using Connections.Board;

namespace Connections.Players;

public class Player
{
    public int Id { get; set; }
    public IMarker Marker { get; set; }
}