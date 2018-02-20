using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation_Of_Another_String
{
    // This is a program to find if one string is a permutation of another
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter string 2");
            string str2 = Console.ReadLine();

            bool result = CompareTwoStrings(str1, str2);
            if (result)
            {
                Console.WriteLine("String 1 {0} is a permutation of string 2 {1}", str1, str2);
            }
            else
            {
                Console.WriteLine("String 1 {0} is not a permutation of string 2 {1}", str1, str2);
            }
            Console.Read();
        }

        private static bool CompareTwoStrings(string str1, string str2)
        {
            if(str1.Length!=str2.Length)
            return false;
            char[] char1 = str1.ToCharArray();
            Array.Sort(char1);
            //Console.WriteLine(char1);
            char[] char2 = str2.ToCharArray();
            Array.Sort(char2);
            //Console.WriteLine(char1);
            bool result= char1.SequenceEqual(char2);
            return result;
        }
    }
}
