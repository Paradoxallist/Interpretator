using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpritator
{
    internal class MemoryArray
    {
        public char[] arr;
        public int IndexMemory = 0;
        public int branch = 0;
        public string code;
        public int i = 0;

        Dictionary<char, Symbol> dic = new Dictionary<char, Symbol>();

        public MemoryArray(int length)
        {
            arr = new char[length];
            dic['+'] = new SymbolPlus();//
            dic['-'] = new SymbolMinus(); 
            dic['>'] = new SymbolRightArrow();
            dic['<'] = new SymbolLeftArrow();
            dic['.'] = new SymbolDot();
            dic['['] = new SymbolSquareRightBracket();
            dic[']'] = new SymbolSquareLeftBracket();//fabrica
            //class result
        }

        public void SetCode(string _code)
        {
            code = _code;
            if (!CheckCode(code))
            {
                Console.WriteLine("код написан некорректно");
                return;
            }
            else
            {
                Performance();
            }

        }

        private void Performance()//eche klass
        {
            for (i = 0;i < code.Length; i++)
            {
                dic[code[i]].Operation(this);
            }
        }


        private bool CheckCode(string code)
        {
            int State = 0;
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '[') State++;
                if (code[i] == ']') State--;
            }
            return State == 0;
        }
    }
}
