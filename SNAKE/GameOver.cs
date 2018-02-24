using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class GameOver
    {

        public static int overswitch = 0;

        public static void Over()
        {
            do
            {
                Console.Clear();
                Console.SetWindowSize(Program.winw, Program.winh);

                Console.WriteLine("╔═══════════════════════════════════════════╗");
                Console.WriteLine("║                                           ║");

                Console.Write("║           ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" YOU LOST ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                      ║");


                Console.Write("║        1 » ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("BACK TO MAIN MENU");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("              ║");

                Console.Write("║        2 » ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("EXIT");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                           ║");

                Console.WriteLine("║                                           ║");
                Console.WriteLine("╚═══════════════════════════════════════════╝");
                Console.SetCursorPosition(0, 0);


                do
                {
                    string tempMenu = Convert.ToString(Console.ReadKey().KeyChar);
                    overswitch = Convert.ToChar(tempMenu);
                } while (overswitch != '1' && overswitch != '2');

            } while (overswitch != '1' && overswitch != '2');

            switch (overswitch)
            {
                case '1': // Back To Main Menu

                    Console.Clear();
                    MainMenu.Menu();

                    break;

                case '2': // Exit

                    Console.Clear();
                    Environment.Exit(0);

                    break;
            }

            Console.ReadKey();
        }
    }



}
