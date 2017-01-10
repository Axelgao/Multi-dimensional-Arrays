using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using W10Sudoku;

namespace W10SudokuTest
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void VerifyRowIsOkTest()
        {
            int[,] sudokuBoard = { {1,2,3,4}, {1,3,4,2} };
            Sudoku sudoku = new Sudoku();
            Assert.IsTrue(sudoku.VerifyRow(sudokuBoard, 1, 4));
        }

        [TestMethod()]
        public void VerifyColumnIsOkTest()
        {
            int[,] sudokuBoard = { { 1, 2, 3, 4 }, { 2, 3, 4, 2 }, { 3, 2, 3, 4 }, { 4, 2, 3, 4 } };
            Sudoku sudoku = new Sudoku();
            Assert.IsTrue(sudoku.VerifyColumn(sudokuBoard, 0, 4));
        }

        [TestMethod()]
        public void VerifyColumnIsWrongTest()
        {
            int[,] sudokuBoard = { { 1, 2, 3, 4 }, { 2, 3, 4, 2 }, { -1, 2, 3, 4 }, { 4, 2, 3, 4 } };
            Sudoku sudoku = new Sudoku();
            Assert.IsFalse(sudoku.VerifyColumn(sudokuBoard, 0, 4));
        }

        [TestMethod()]
        public void VerifyColumnIsTooLargeTest()
        {
            int[,] sudokuBoard = { { 1, 2, 3, 4 }, { 2, 3, 4, 2 }, { 5, 2, 3, 4 }, { 4, 2, 3, 4 } };
            Sudoku sudoku = new Sudoku();
            Assert.IsFalse(sudoku.VerifyColumn(sudokuBoard, 0, 4));
        }

        [TestMethod()]
        public void VerifyAllTest()
        {
            int[,] sudokuBoard = { { 2, 1, 4, 3 }, { 4, 3, 2, 1 }, { 1, 2, 3, 4 }, { 3, 4, 1, 2 } };
            Sudoku sudoku = new Sudoku();
            Assert.IsTrue(sudoku.VerifyAll(sudokuBoard, 4));
        }
        [TestMethod()]
        public void VerifyAllTestBreak()
        {
            int[,] sudokuBoard = { { 3, 1, 4, 3 }, { 4, 3, 2, 1 }, { 1, 2, 3, 4 }, { 3, 4, 1, 2 } };
            Sudoku sudoku = new Sudoku();
            Assert.IsTrue(sudoku.VerifyAll(sudokuBoard, 4));
        }
        [TestMethod()]
        public void VerifyRowIsWrongTest()
        {
            int[,] sudokuBoard = { { 3, 1, 4, 3 }, { 4, 3, 2, 1 }, { 1, 2, 3, 4 }, { 3, 4, 1, 2 } };
            Sudoku sudoku = new Sudoku();
            Assert.IsFalse(sudoku.VerifyRow(sudokuBoard, 0, 4));
        }

        [TestMethod()]
        public void VerifyRowIsTooLargeTest()
        {
            int[,] sudokuBoard = { { 3, 1, 4, 3 }, { 4, 3, 2, 1 }, { 1, 2, 3, 4 }, { 3, 4, 1, 2 } };
            Sudoku sudoku = new Sudoku();
            Assert.IsFalse(sudoku.VerifyRow(sudokuBoard, 0, 4));
        }
    }
}
