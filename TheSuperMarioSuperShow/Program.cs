/**********************
 * Developer: Jack Malone
 * Title: Running Mario
 * Description: It's just mario running
 * Date: 05/03/2020
************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheSuperMarioSuperShow
{
    class Program
    {
        static int milliseconds = 40;
        static int count = 0;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            while (true == true)
            {
                while (count < 191)
                {
                    Run1();
                    Thread.Sleep(milliseconds);

                    count++;

                    Run2();
                    Thread.Sleep(milliseconds);

                    count++;

                    Run3();
                    Thread.Sleep(milliseconds);

                    count++;

                    Run2();
                    Thread.Sleep(milliseconds);

                    count++;
                }

                count = 0;
            }
        }

        static void Run1()
        {
            Console.Clear();

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }

            //Line 1
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line 2
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("     ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line3
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("         ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line4
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line5
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line6
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line7
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("    ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line8
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line9
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line10
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line11
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line12
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("       ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line13
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("        ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line14
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line15
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line16
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("    ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //End
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
        }

        static void Run2()
        {
            Console.Clear();

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }

            //Line1
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("     ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line2
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("         ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line3
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line4
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line5
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line6
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("    ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line7
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line8
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line 9
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("  ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line10
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line11
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("     ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line12
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line13
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line14
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line15
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("       ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line16
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("    ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //End
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
        }

        static void Run3()
        {
            Console.Clear();

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }

            //Line1
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("     ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line2
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("         ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line3
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line4
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line5
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line6
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("    ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line7
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line8
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("  ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line9
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line10
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line11
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("       ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line12
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("         ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("  ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line13
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("  ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line14
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("  ");

            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line15
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("   ");
            
            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //Line16
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("   ");
            
            for (int i = 0; i < count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            //End
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
        }
    }
}