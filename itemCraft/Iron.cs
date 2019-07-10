using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemCraft
{
    class Iron
    {
        private string _symbol;

        public Iron()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            _symbol = "I";
        }

        public string GetIronSymbol()
        {
            return _symbol;
        }
    }
}
