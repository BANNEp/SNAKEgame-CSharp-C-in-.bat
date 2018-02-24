using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    public class MainMenu
    {
        

        public static void Menu(int menuswitch = 0)
        {

            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║                                           ║");

            Console.Write("║        1 » ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("START GAME");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                     ║");


            Console.Write("║        2 » ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("OPTIONS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                        ║");


            Console.Write("║        3 » ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("EXIT");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                           ║");

            Console.WriteLine("║                                           ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");
            Console.SetCursorPosition(0, 0);


            do
            {
                string tempMenu = Convert.ToString(Console.ReadKey().KeyChar);
                menuswitch = Convert.ToInt32(tempMenu);
            } while (menuswitch != 1 && menuswitch != 2 && menuswitch != 3);


            switch (menuswitch)
            {
                case 1: // Starting Game

                    Name.Setname();
                    StartingGame.Zone();
                    StartingGame.Control();

                    break;

                case 2: // Options

                    Console.Clear();
                    Options.Option();

                    break;

                case 3: //Exit

                    Environment.Exit(0);

                    break;
            }

            Console.ReadKey();
        }
    }
}
