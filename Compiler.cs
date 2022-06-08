using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpritator
{
    internal class Compiler
    {
        private MemoryArray arr;

        Dictionary<char, Symbol> dic = new Dictionary<char, Symbol>();

        public Compiler(MemoryArray memoryArray)
        {
            arr = memoryArray;
            SymbolFactory.CharacterAssignment(dic);
        }

        public string Performance()
        {
            for (arr.SetIndexLine(0); arr.IndexLine < arr.Code.Length; arr.SetIndexLine(arr.IndexLine + 1))
            {
                dic[arr.Code[arr.IndexLine]].Operation(arr);
            }
            return arr.GetOutput().ToString();
        }
    }
}
