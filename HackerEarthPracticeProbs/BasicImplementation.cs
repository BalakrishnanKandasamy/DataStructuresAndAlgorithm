using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarthPracticeProbs
{
    class BasicImplementation
    {
        static void Main() 
        {
            string inputString = Console.ReadLine();
            Dictionary<int, int> digitOccurences = new Dictionary<int, int>();
            foreach (char ip in inputString) 
            {
                int digit = Convert.ToInt32(ip.ToString());
                if (digitOccurences.ContainsKey(digit))
                {
                    digitOccurences[digit] = digitOccurences[digit] + 1;
                }
                else 
                {
                    digitOccurences.Add(digit, 1);
                }
            }

            for (int counter = 0; counter < 10; counter++) 
            {
                if (digitOccurences.ContainsKey(counter))
                {
                    Console.WriteLine(String.Format("{0} {1}", counter, digitOccurences[counter]));
                }
                else 
                {
                    Console.WriteLine(String.Format("{0} {1}", counter, 0));
                }

            }
        }
    }
}
