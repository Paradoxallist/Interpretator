using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Interpritator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Код - ");
            string code = Console.ReadLine();
            MemoryArray arr = new MemoryArray(30000);
            arr.SetCode(code);
        }
    }
}
