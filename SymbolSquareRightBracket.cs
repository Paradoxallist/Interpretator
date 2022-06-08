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
            if (memoryArray.ArrMemory[memoryArray.IndexMemory] == '\0')
            {
                branch++;
                while (branch == 0)
                {
                    memoryArray.SetIndexLine(memoryArray.IndexLine + 1);
                    if (memoryArray.Code[memoryArray.IndexLine] == '[')
                        branch++;
                    if (memoryArray.Code[memoryArray.IndexLine] == ']')
                        branch--;
                }
            }
        }
    }
}
