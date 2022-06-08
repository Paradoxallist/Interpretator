using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpritator
{
    internal class SymbolRightArrow :Symbol
    {
        public void Operation(MemoryArray memoryArray)
        {
            memoryArray.IndexMemory++;
        }
    }
}
