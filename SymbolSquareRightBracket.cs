using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpritator
{
    internal class SymbolSquareRightBracket : Symbol
    {
        public void Operation(MemoryArray memoryArray)
        {
            if (memoryArray.arr[memoryArray.IndexMemory] == '\0')
            {
                memoryArray.branch++;
                while (memoryArray.branch == 0)
                {
                    memoryArray.i++;
                    if (memoryArray.code[memoryArray.i] == '[')
                        memoryArray.branch++;
                    if (memoryArray.code[memoryArray.i] == ']')
                        memoryArray.branch--;
                }
            }
        }
    }
}
