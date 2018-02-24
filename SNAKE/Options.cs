using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    public class Options
    {

        public static void Option(int optioninput = 0)
        {
        
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║                                           ║");
            Console.WriteLine("║        1 » CHANGE SNAKE DESIGN            ║");
            Console.WriteLine("║        2 » CHANGE SNAKE COLOR             ║");
            Console.WriteLine("║        3 » BACK TO MAIN MENU              ║");
            Console.WriteLine("║                                           ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");
            Console.SetCursorPosition(0, 0);

            Console.SetWindowSize(Program.winw, Program.winh);

            do {
                string tempMenu = Convert.ToString(Console.ReadKey().KeyChar);
                optioninput = Convert.ToInt32(tempMenu);
            } while (optioninput != 1 && optioninput != 2 && optioninput != 3);

            if (optioninput == 1)       // CHANGE SNAKE DESIGN
            {
                // Not Done ( Maybe another Options )
            }

            if (optioninput == 2)       // CHANGE SKIN COLOR
            {
                // Not Done ( Maybe another Options )
            }

            if (optioninput == 3)       // BACK TO MENU
            {
                Console.Clear();
                MainMenu.Menu();
            }


        }

    }
}
