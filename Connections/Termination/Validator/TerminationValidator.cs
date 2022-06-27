using Connections.Board;
using Connections.Termination.Rules;

namespace Connections.Termination.Validator;

class TerminationValidator : ITerminationValidator
{
    private readonly IEnumerable<ITerminationRule> _rules;

    public TerminationValidator(IEnumerable<ITerminationRule> rules)
    {
        _rules = rules;
    }

    public TerminationResult Assess(Grid board)
    {
        foreach (ITerminationRule rule in _rules)
        {
            TerminationResult result = rule.Assess(board);
            if (result.IsEnded)
            {
                return result;
            }
        }

        return new TerminationResult
        {
            IsEnded = false,
            WinningPlayer = null
        };
    }
}