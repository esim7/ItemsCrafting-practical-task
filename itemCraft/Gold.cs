using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemCraft
{
    class Gold
    {
        private string _symbol;

        public Gold()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            _symbol = "G";
        }

        public string GetGoldSymbol()
        {
            return _symbol;
        }
    }

    
}
