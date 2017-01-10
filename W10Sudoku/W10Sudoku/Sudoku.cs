using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10Sudoku
{
    public class Sudoku
    {
        public bool VerifyAll(int[,] sudokuBoard, int size)
        {
            bool result=true;
            for(int i = 0; i < size; i++)
            {
                if (result == true)
                {
                    result = VerifyRow(sudokuBoard, i, size);
                }
                else break;
                if (result == true)
                {
                    result = VerifyColumn(sudokuBoard, i, size);
                }
                else break;
            }
            return result;
        }
        public bool VerifyColumn(int[,] sudokuBoard, int column, int size)
        {
            bool[] matchedNumbers = new bool[size];
            int numberOfBools = 0;
            //1.create an array of bools
            for (int i = 0; i < size; ++i) matchedNumbers[i] = false;
            //2.toggle the bools to trues
            matchedNumbers = ToggleArrayOfBoolsByColumn(sudokuBoard, column, size, matchedNumbers);
            //3.count the trues in array
            for (int i = 0; i < size; ++i)
            {
                if (matchedNumbers[i] == true) numberOfBools++;
            }
            //4.return if trues equal size of board
            return numberOfBools == size;
        }
        private bool[] ToggleArrayOfBoolsByColumn(int[,] sudokuBoard, int column, int size, bool[] matchedNumbers)
        {
            for (int i = 0; i < size; i++)
            {
                int num = sudokuBoard[i, column];
                if (num > 0 && num <= size) matchedNumbers[num - 1] = true;
            }
            return matchedNumbers;
        }
        public bool VerifyRow(int[,] sudokuBoard, int row, int size)
        {
            bool[] matchedNumbers = new bool[size];
            int numberOfBools = 0;
            //1.create an array of bools
            for (int i = 0 ; i < size; ++i) matchedNumbers[i] = false;
            //2.toggle the bools to trues
            matchedNumbers = ToggleArrayOfBools(sudokuBoard, row, size, matchedNumbers);
            //3.count the trues in array
            for (int i = 0; i < size; ++i)
            {
                if (matchedNumbers[i] == true) numberOfBools++;
            }
            //4.return if trues equal size of board
            return numberOfBools == size;
        }
        private bool[] ToggleArrayOfBools(int[,] sudokuBoard, int row, int size, bool[] matchedNumbers)
        {
            for (int i=0; i < size; i++)
            {
                int num = sudokuBoard[row, i];
                if (num > 0 && num <= size) matchedNumbers[num - 1] = true;
            }
            return matchedNumbers;
        }

    }
}
