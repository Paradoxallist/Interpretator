using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Interpritator
{
    internal class SymbolPlus : Symbol
    {
        public void Operation(MemoryArray memoryArray)
        {
            char element = memoryArray.GetMemoryElement();
            memoryArray.SetMemoryElement(++element);
        }
    }
}
