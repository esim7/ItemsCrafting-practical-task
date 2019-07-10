using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemCraft
{
    class Stone
    {
        private string _symbol;

        public Stone()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            _symbol = "S";
        }
        public string GetStoneSymbol()
        {
            return _symbol;
        }
    }
}
