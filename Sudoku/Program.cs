using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[,] veryHardBoard = {{8, 0, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 3, 6, 0, 0, 0, 0, 0},
                                    {0, 7, 0, 0, 9, 0, 2, 0, 0},
                                    {0, 5, 0, 0, 0, 7, 0, 0, 0},
                                    {0, 0, 0, 0, 4, 5, 7, 0, 0},
                                    {0, 0, 0, 1, 0, 0, 0, 3, 0},
                                    {0, 0, 1, 0, 0, 0, 0, 6, 8},
                                    {0, 0, 8, 5, 0, 0, 0, 1, 0},
                                    {0, 9, 0, 0, 0, 0, 4, 0, 0}};

            SudokuSolver game = new SudokuSolver(veryHardBoard);

            if (game.Solve())
            {
                game.Print();
            }
            else
            {
                Console.WriteLine("No solution found");
            }

            Console.Read();

        }
    }
}
