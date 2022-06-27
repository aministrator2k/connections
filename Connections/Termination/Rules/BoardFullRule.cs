using Connections.Board;
using Connections.Termination.Validator;

namespace Connections.Termination.Rules;

public class BoardFullRule : ITerminationRule
{
    public TerminationResult Assess(Grid board)
    {
        for (int i = 0; i < board.GetWidth(); i++)
            for (int j = 0; j < board.GetHeight(); j++)
            {
                if (board.Get(i, j) == null)
                    return new TerminationResult
                    {
                        IsEnded = false,
                        WinningPlayer = null
                    };
            }

        return new TerminationResult
        {
            IsEnded = true,
            WinningPlayer = null
        };
    }
}