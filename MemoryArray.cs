using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpritator
{
    internal class MemoryArray
    {
        public char[] arrMemory;
        public int IndexMemory => indexMemory;
        private int indexMemory = 0;
        public string code;
        public int IndexLine => indexLine;
        private int indexLine = 0;

        public MemoryArray(int length, string _code)
        {
            arrMemory = new char[length];
            code = _code;
        }

        public void SetMemoryElement(char element)
        {
            arrMemory[indexMemory] = element;
        }
        public char GetMemoryElement()
        {
            return arrMemory[indexMemory];
        }

        public void SetCode(string _code)
        {
            code = _code;
        }

        public void SetIndexMemory(int _IndexMemory)
        {
            indexMemory = _IndexMemory;
        }

        public void SetIndexLine(int _IndexLine)
        {
            indexLine = _IndexLine;
        }
    }
}
