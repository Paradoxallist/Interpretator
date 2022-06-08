using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpritator
{
    internal class SymbolLeftArrow : Symbol
    {
        public void Operation(MemoryArray memoryArray)
        {
            int IndexMemory = memoryArray.IndexMemory;
            memoryArray.SetIndexMemory(--IndexMemory);
        }
    }
}
