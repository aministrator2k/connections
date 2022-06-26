using Connections.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connections.Termination
{
    public class TerminationResult
    {
        public enum State
        {
            Won,
            Draw
        }

        public State EndState { get; set; }
        public Player WinningPlayer { get; set; }
    }
}
