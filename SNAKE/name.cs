using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    public class Name
    {
        public static string name = "";
        public static char[] typename = new char[9];

        public static void Setname()
        {

            Console.Clear();

            Console.WriteLine("╔═══════════════════════════════════════════╗");

            Console.Write("║              1 » ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("SET NAME");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                 ║");

            char endname = '_';

            Console.Write("║          » ");
            Console.Write("_ _ _ _ _ _ _ _ " +endname);
            Console.WriteLine("              ║");

            Console.WriteLine("║                                           ║");

            Console.Write("║         ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("PRESS 'SPACE' FOR NOTHING");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         ║");

            Console.Write("║        ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("EVERY LINE NEEDS TO BE FULL");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        ║");

            Console.WriteLine("╚═══════════════════════════════════════════╝");

            Console.SetCursorPosition(0, 0);

            int count = 11;
            char inputkey = 'A';

            for (int i = 0; i < 9; i++)
            {
                count = count + 1;
                Console.SetCursorPosition(count, 2);
                Console.ForegroundColor = ConsoleColor.Green;

                string nameControl = Convert.ToString(Console.ReadKey().KeyChar);
                inputkey = Convert.ToChar(nameControl);

                Console.Write(inputkey);

                Console.SetCursorPosition(count, 2);

                count = count + 1;
                Console.Write(" ");

                typename[i] = inputkey;
                
            }

            if (endname != '_')
            {
                Console.ReadKey();
            }

        }

    }
}
