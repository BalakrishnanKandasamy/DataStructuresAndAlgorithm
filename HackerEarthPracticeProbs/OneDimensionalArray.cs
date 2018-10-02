using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarthPracticeProbs
{
    class OneDimensionalArray
    {
        static void Main() 
        {
           int arraySize= Convert.ToInt32(Console.ReadLine());
           int[] inputArray = new int[arraySize];
           for (int counter = 0; counter < arraySize; counter++) 
           {
               inputArray[counter] = Convert.ToInt32(Console.ReadLine());
           }

           for (int reverseCounter = arraySize - 1; reverseCounter >= 0; reverseCounter--)
           {
               Console.WriteLine(inputArray[reverseCounter]);
           }
        }
    }
}
