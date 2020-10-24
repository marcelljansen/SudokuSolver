using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sudoku.UnitTests
{
    [TestClass]
    public class SudokuSolverTests
    {

        [TestMethod]
        public void CheckIfRowIsValid_RowIsValid_ReturnsTrue()
        {
            int[,] mediumBoard = {
                {0, 4, 0, 0, 2, 0, 0, 0, 0},
                {0, 0, 0, 4, 3, 0, 0, 0, 6},
                {0, 9, 0, 0, 0, 0, 3, 0, 0},
                {6, 0, 8, 0, 0, 7, 9, 0, 0},
                {0, 0, 2, 1, 0, 0, 0, 0, 0},
                {0, 0, 7, 8, 0, 0, 0, 5, 0},
                {0, 0, 0, 0, 5, 8, 0, 0, 2},
                {0, 6, 0, 3, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 3, 0}};
            SudokuSolver game = new SudokuSolver(mediumBoard);
            
            bool result = game.CheckIfRowIsValid(0, 3);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfRowIsValid_RowIsInvalid_ReturnsFalse()
        {
            int[,] mediumBoard = {
                {0, 4, 0, 0, 2, 0, 0, 0, 0},
                {0, 0, 0, 4, 3, 0, 0, 0, 6},
                {0, 9, 0, 0, 0, 0, 3, 0, 0},
                {6, 0, 8, 0, 0, 7, 9, 0, 0},
                {0, 0, 2, 1, 0, 0, 0, 0, 0},
                {0, 0, 7, 8, 0, 0, 0, 5, 0},
                {0, 0, 0, 0, 5, 8, 0, 0, 2},
                {0, 6, 0, 3, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 3, 0}};
            SudokuSolver game = new SudokuSolver(mediumBoard);

            bool result = game.CheckIfRowIsValid(0, 4);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfColumnIsValid_ColumnIsValid_ReturnsTrue()
        {
            int[,] mediumBoard = {
                {0, 4, 0, 0, 2, 0, 0, 0, 0},
                {0, 0, 0, 4, 3, 0, 0, 0, 6},
                {0, 9, 0, 0, 0, 0, 3, 0, 0},
                {6, 0, 8, 0, 0, 7, 9, 0, 0},
                {0, 0, 2, 1, 0, 0, 0, 0, 0},
                {0, 0, 7, 8, 0, 0, 0, 5, 0},
                {0, 0, 0, 0, 5, 8, 0, 0, 2},
                {0, 6, 0, 3, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 3, 0}};
            SudokuSolver game = new SudokuSolver(mediumBoard);

            bool result = game.CheckIfColumnIsValid(1, 5);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfColumnIsValid_ColumnIsInvalid_ReturnsFalse()
        {
            int[,] mediumBoard = {
                {0, 4, 0, 0, 2, 0, 0, 0, 0},
                {0, 0, 0, 4, 3, 0, 0, 0, 6},
                {0, 9, 0, 0, 0, 0, 3, 0, 0},
                {6, 0, 8, 0, 0, 7, 9, 0, 0},
                {0, 0, 2, 1, 0, 0, 0, 0, 0},
                {0, 0, 7, 8, 0, 0, 0, 5, 0},
                {0, 0, 0, 0, 5, 8, 0, 0, 2},
                {0, 6, 0, 3, 0, 0, 0, 0, 0}, 
                {1, 0, 0, 0, 0, 0, 0, 3, 0}};
            SudokuSolver game = new SudokuSolver(mediumBoard);

            bool result = game.CheckIfColumnIsValid(0, 6);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfBoxIsValid_BoxIsValid_ReturnsTrue()
        {
            int[,] mediumBoard = {
                {0, 4, 0, 0, 2, 0, 0, 0, 0},
                {0, 0, 0, 4, 3, 0, 0, 0, 6},
                {0, 9, 0, 0, 0, 0, 3, 0, 0},
                {6, 0, 8, 0, 0, 7, 9, 0, 0},
                {0, 0, 2, 1, 0, 0, 0, 0, 0},
                {0, 0, 7, 8, 0, 0, 0, 5, 0},
                {0, 0, 0, 0, 5, 8, 0, 0, 2},
                {0, 6, 0, 3, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 3, 0}};
            SudokuSolver game = new SudokuSolver(mediumBoard);

            bool result = game.CheckIfBoxIsValid(1, 1,6);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfBoxIsValid_BoxIsInvalid_ReturnsFalse()
        {
            int[,] mediumBoard = {
                {0, 4, 0, 0, 2, 0, 0, 0, 0},
                {0, 0, 0, 4, 3, 0, 0, 0, 6},
                {0, 9, 0, 0, 0, 0, 3, 0, 0},
                {6, 0, 8, 0, 0, 7, 9, 0, 0},
                {0, 0, 2, 1, 0, 0, 0, 0, 0},
                {0, 0, 7, 8, 0, 0, 0, 5, 0},
                {0, 0, 0, 0, 5, 8, 0, 0, 2},
                {0, 6, 0, 3, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 3, 0}};
            SudokuSolver game = new SudokuSolver(mediumBoard);

            bool result = game.CheckIfBoxIsValid(1, 2,9);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfMoveIsValid_MoveIsValid_ReturnsTrue()
        {
            int[,] mediumBoard = {
                {0, 4, 0, 0, 2, 0, 0, 0, 0},
                {0, 0, 0, 4, 3, 0, 0, 0, 6},
                {0, 9, 0, 0, 0, 0, 3, 0, 0},
                {6, 0, 8, 0, 0, 7, 9, 0, 0},
                {0, 0, 2, 1, 0, 0, 0, 0, 0},
                {0, 0, 7, 8, 0, 0, 0, 5, 0},
                {0, 0, 0, 0, 5, 8, 0, 0, 2},
                {0, 6, 0, 3, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 3, 0}};

            SudokuSolver game = new SudokuSolver(mediumBoard);

            bool result = game.CheckIfMoveIsValid(0, 0, 5);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfMoveIsValid_MoveIsInvalid_ReturnsFalse()
        {
            int[,] mediumBoard = {
                {0, 4, 0, 0, 2, 0, 0, 0, 0},
                {0, 0, 0, 4, 3, 0, 0, 0, 6},
                {0, 9, 0, 0, 0, 0, 3, 0, 0},
                {6, 0, 8, 0, 0, 7, 9, 0, 0},
                {0, 0, 2, 1, 0, 0, 0, 0, 0},
                {0, 0, 7, 8, 0, 0, 0, 5, 0},
                {0, 0, 0, 0, 5, 8, 0, 0, 2},
                {0, 6, 0, 3, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 3, 0}};

            SudokuSolver game = new SudokuSolver(mediumBoard);

            bool result = game.CheckIfMoveIsValid(0, 0, 1);

            Assert.IsFalse(result);
        }
    }
}
