using Connections.Board;
using Connections.Players;
using Connections.Termination.Validator;

namespace Connections.Termination.Rules;

public interface ITerminationRule
{
    TerminationResult Assess(Grid board);
}