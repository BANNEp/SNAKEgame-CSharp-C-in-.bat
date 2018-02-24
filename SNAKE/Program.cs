using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Program
    {
        public static int winh = 7, winw = 45;
        public static int winh2 = 33, winw2 = 47;
        static void Main(string[] args)
        {
          

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(winw, winh);
           
            MainMenu.Menu();

        }
    }
}
