using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal interface IBlock
    {
        int? joint { get; set; }
        string command { get; set; }
        Block.Type type { get; set; }        
    }
}
