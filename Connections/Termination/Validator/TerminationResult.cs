using Connections.Players;

namespace Connections.Termination.Validator;

public class TerminationResult
{
    public Player? WinningPlayer { get; set; }
    public bool IsEnded { get; set; }

    public static TerminationResult NotEnded => new TerminationResult
    {
        IsEnded = false,
        WinningPlayer = null
    };
}