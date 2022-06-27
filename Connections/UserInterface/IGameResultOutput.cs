using Connections.Termination.Validator;

namespace Connections.UserInterface;

public interface IGameResultOutput
{
    void ShowResult(TerminationResult result);
}

class ConsoleResultOutput : IGameResultOutput
{
    public void ShowResult(TerminationResult result)
    {
        if (result.IsEnded)
        {
            if (result.WinningPlayer == null)
            {
                Console.WriteLine($"Game was draw! No winner :(");
            }
            else
            {
                Console.Write($"Player {result.WinningPlayer.Id} won!");
            }
        }
        else
        {
            Console.WriteLine("The game has not ended yet.");
        }
    }
}