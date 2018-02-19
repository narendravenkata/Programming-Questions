using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Characters_In_A_String
{
    class Program
    {

        static bool IsUnique(string str)
        {
            bool[] char_Set = new bool[128];
            for(int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (char_Set[val])
                {
                    return false;
                }
                char_Set[val] = true;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please Enter a string");
            }
            else
            {
                bool result = IsUnique(input);
                if (result)
                {
                    Console.WriteLine("String {0} has all unique characters", input);
                }
                else
                {
                    Console.WriteLine("String {0} doesn't have all unique characters", input);
                }
            }

            Console.Read();
        }
    }
}
