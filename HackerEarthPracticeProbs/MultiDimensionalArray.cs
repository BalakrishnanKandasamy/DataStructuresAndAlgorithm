using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarthPracticeProbs
{
    class MultiDimensionalArray
    {
        static void Main()
        {
            string[] rowsAndColsInfo = Console.ReadLine().Split();
            int rows = Convert.ToInt32(rowsAndColsInfo[0]);
            int cols = Convert.ToInt32(rowsAndColsInfo[1]);

            int[,] inputArray = new int[rows, cols];

            for (int rowCounter = 0; rowCounter < rows; rowCounter++)
            {
                string[] rowElements = Console.ReadLine().Split();
                for (int colCounter = 0; colCounter < cols; colCounter++)
                {
                    inputArray[rowCounter, colCounter] = Convert.ToInt32(rowElements[colCounter]);
                }
            }

            int transposedRows = cols;
            int transposedCols = rows;
            int[,] outputArray = new int[transposedRows, transposedCols];

            for (int colCounter = 0; colCounter < cols; colCounter++)
            {
                for (int rowCounter = 0; rowCounter < rows; rowCounter++)
                {
                    outputArray[colCounter, rowCounter] = inputArray[rowCounter, colCounter];
                    Console.Write(String.Format("{0} ", inputArray[rowCounter, colCounter]));
                }
                Console.WriteLine();
            }
        }
    }
}
