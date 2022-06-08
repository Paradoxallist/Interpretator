using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpritator
{
    internal class SymbolDot : Symbol
    {
        public void Operation(MemoryArray memoryArray)
        {
            StringBuilder output = memoryArray.GetOutput();
            output.Append(memoryArray.GetMemoryElement());
        }
    }
}
