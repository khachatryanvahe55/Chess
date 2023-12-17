using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class ChessTable
    {
        public ChessTable()
        {



            Console.WriteLine("   A B C D E F G H");
            for (int row = 8; row >= 1; row--)
            {
                Console.Write(row + "  ");
                for (char col = 'A'; col <= 'H'; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.Write("  ");


                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
