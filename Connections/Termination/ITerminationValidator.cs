using Connections.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connections.Termination
{
    public interface ITerminationValidator
    {
        TerminationResult Validate(Grid board);
    }
}
