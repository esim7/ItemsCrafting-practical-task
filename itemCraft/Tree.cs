using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemCraft
{
    class Tree
    {
        private string _symbol;

        public Tree()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _symbol = "T";
        }
        public string GetTreeSymbol()
        {
            return _symbol;
        }
    }
}
