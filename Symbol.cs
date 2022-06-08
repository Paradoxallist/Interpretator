using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpritator
{
    internal interface Symbol
    {
        void Operation(MemoryArray memoryArray);
    }
}
