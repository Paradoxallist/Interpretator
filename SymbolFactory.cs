using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpritator
{
    internal static class SymbolFactory
    {
        public static void CharacterAssignment(Dictionary<char, Symbol> dic)
        {
            dic['+'] = new SymbolPlus();
            dic['-'] = new SymbolMinus();
            dic['>'] = new SymbolRightArrow();
            dic['<'] = new SymbolLeftArrow();
            dic['.'] = new SymbolDot();
            dic['['] = new SymbolSquareRightBracket();
            dic[']'] = new SymbolSquareLeftBracket();
        }
    }
}
