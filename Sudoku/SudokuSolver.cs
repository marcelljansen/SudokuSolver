using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class SudokuSolver
    {
        private int[,] Sudoku;

        public SudokuSolver()
        {
            Sudoku = new int[9, 9];
        }

        public SudokuSolver(int[,] sudoku)
        {
            this.Sudoku = sudoku;
        }

        public bool Solve()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (Sudoku[row, col] == 0)
                    {
                        for (int number = 1; number <= 9; number++)
                        {
                            if (CheckIfMoveIsValid(row, col, number))
                            {
                                Sudoku[row, col] = number;
                                if (Solve())
                                {
                                    return true;
                                }
                                else
                                {
                                    Sudoku[row, col] = 0;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public bool CheckIfRowIsValid(int row, int number)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Sudoku[row, i] == number)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckIfColumnIsValid(int col, int number)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Sudoku[i, col] == number)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckIfBoxIsValid(int row, int col, int number)
        {
            // r and c represent the upper left corner of the grid where you try to place number
            int r = row - row % 3;
            int c = col - col % 3;
            for (int i = r; i < r + 3; i++)
            {
                for (int j = c; j < c + 3; j++)
                {
                    if (Sudoku[i, j] == number)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        public bool CheckIfMoveIsValid(int row, int col, int number)
        {
            return CheckIfRowIsValid(row, number) && CheckIfColumnIsValid(col, number) && CheckIfBoxIsValid(row, col, number);
        }

        public void Print()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("- - - - - - - - ");
                }
                for (int j = 0; j < 9; j++)
                {
                    if (j % 3 == 0 && j != 0)
                    {
                        Console.Write(" | ");
                    }
                    Console.Write(Sudoku[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
