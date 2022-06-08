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
            int branch = 0;
            if (memoryArray.arrMemory[memoryArray.IndexMemory] == '\0')
            {
                branch++;
                while (branch == 0)
                {
                    memoryArray.SetIndexLine(memoryArray.IndexLine + 1);
                    if (memoryArray.code[memoryArray.IndexLine] == '[')
                        branch++;
                    if (memoryArray.code[memoryArray.IndexLine] == ']')
                        branch--;
                }
            }
        }
    }
}
