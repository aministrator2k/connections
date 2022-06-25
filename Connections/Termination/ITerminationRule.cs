using Connections.Board;
using Connections.Players;

namespace Connections.Termination;

public interface ITerminationRule
{
    Player? Find(Grid board);
}