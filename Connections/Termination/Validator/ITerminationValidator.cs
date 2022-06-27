using Connections.Board;

namespace Connections.Termination.Validator;

public interface ITerminationValidator
{
    TerminationResult Assess(Grid board);
}