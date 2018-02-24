using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    public class StartingGame
    {

        public static Random leftpos1 = new Random();
        public static Random toppos1 = new Random();
        public static bool ready = false;

        public static void Zone()   // PLAYGROUND
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.SetWindowSize(Program.winw2, Program.winh2);
            Console.WriteLine(" ╔════════════════════════════════════════════╗");
            Console.WriteLine("╔╝  Name :             Points :               ║");

            // Name Position
            Console.SetCursorPosition(11, 1);
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < 9; i++)
            {
                Console.Write(Name.typename[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;

            // Points Position
            Console.SetCursorPosition(32, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Models.points);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("╠═════════════════════════════════════════════╣");

            for (int i = 0; i < 29; i++)
            {
                Console.WriteLine("║                                             ║"); // 31
            }

            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.SetCursorPosition(0, 0);

        }


        public static char movekey;
        public static int leftpos = 23, toppos = 16;
        public static bool movement = true;

        public static void Control()
        {
            // Start

            Console.SetCursorPosition(23, 16);
            Console.Write(Models.pmhead);

            int leftposint = 0;
            int topposint = 0;

            do
            {
                if (ready == false) // Random Points position
                {
                    leftposint = leftpos1.Next(1, 44);
                    topposint = toppos1.Next(3, 31);

                    Console.SetCursorPosition(leftposint, topposint);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Models.heart);
                    Console.ForegroundColor = ConsoleColor.White;
                    ready = true;
                }

                Console.SetCursorPosition(0, 0);

                string tempControl = Convert.ToString(Console.ReadKey().KeyChar);
                movekey = Convert.ToChar(tempControl);


                // Nach Oben
                if (movekey == 'w' || movekey == 'W')
                {
                    Console.SetCursorPosition(leftpos, toppos--);
                    Console.Write("  ");
                    Console.SetCursorPosition(leftpos, toppos);
                    Console.Write(Models.pmhead);
                    Console.SetCursorPosition(leftpos, toppos);

                }

                // Nach Unten
                if (movekey == 's' || movekey == 'S')
                {
                    Console.SetCursorPosition(leftpos, toppos++);
                    Console.Write("  ");
                    Console.SetCursorPosition(leftpos, toppos);
                    Console.Write(Models.pmhead);
                    Console.SetCursorPosition(leftpos, toppos);
                }

                // Nach Rechts
                if (movekey == 'd' || movekey == 'D')
                {
                    Console.SetCursorPosition(leftpos++, toppos);
                    Console.Write("  ");
                    Console.SetCursorPosition(leftpos, toppos);
                    Console.Write(Models.pmhead);
                    Console.SetCursorPosition(leftpos, toppos);
                }

                // Nach Links
                if (movekey == 'a' || movekey == 'A')
                {
                    Console.SetCursorPosition(leftpos-- , toppos);
                    Console.Write("  ");
                    Console.SetCursorPosition(leftpos , toppos);
                    Console.Write(Models.pmhead);
                    Console.SetCursorPosition(leftpos, toppos);
                }


                // Game Over Zone

                if (leftpos == 0 || leftpos == 45 || toppos == 2 || toppos == 32)
                {
                    GameOver.Over();
                }

                // Heart (Point-system)
                if (ready == true)
                {
                    if (leftpos == leftposint && toppos == topposint)
                    {
                        Models.points = Models.points + 1000;
                        ready = false;

                        Console.SetCursorPosition(32, 1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Models.points);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }

            } while(movement == true);

            
        }


    }
}