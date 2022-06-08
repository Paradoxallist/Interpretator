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
            Console.Write(memoryArray.GetMemoryElement());
        }
    }
}
