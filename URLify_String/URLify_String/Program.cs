using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLify_String
{
    /*URLify: Write a method to replace all spaces in a string with'%20'. You may assume that
      the string has sufficient space at the end of the string to hold the additional
      characters, and that you are given the "true" length of the string.
       EXAMPLE:
      Input:  "Mr John Smith    "
      Output: "Mr%20John%20Smith"  */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            Console.WriteLine("Enter true length");
            int length = Convert.ToInt32(Console.ReadLine());
            char[] inputArray = input.ToCharArray();
            char[] output = replaceString(inputArray, length);
            Console.WriteLine(new String(output));
            Console.Read();
        }

        private static Char [] replaceString(Char[] input, int truelength)
        {
            int spacesCount = 0;
            int i = 0;
            //Initally we need to count the spaces in the input
            for (i = 0; i < truelength; i++)
            {
                if (input[i] == ' ')
                {
                    spacesCount++;
                }
            }

            // Now we got the spaces count , so we need to find the new length to accommodate the '%20' in the place of space

            // here we multiplied by 2 because we already have place of one character in the place of space

            int newLength = truelength + spacesCount * 2;

           //Considering the example given in question, We start at 'h' that is true length and if we encounter a space we
           // append the "%20" and if no space is encountered we shift the characters backwards.

            for (i = truelength - 1; i >= 0; i--)
            {
                if (input[i] == ' ')
                {
                    input[newLength - 1] = '0';
                    input[newLength - 2] = '2';
                    input[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else
                {
                    input[newLength - 1]= input[i];
                    newLength--;
                }
            }
            return input;
        }
    }
}
