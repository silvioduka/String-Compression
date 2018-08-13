/*
String Compression from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-04  

Write a method that takes a string as input and returns a compressed version of it, as shown in the example below: 
input: aaabbbbccd 
output: a3b4c2d 

You can assume the string contains only letters. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "aaabbbbccdaaaaa"; // Insert here a string to compress
            string output = String.Empty;

            char old = ' ';
            int count = 0;

            foreach (char c in input)
            {
                if (c != old)
                {
                    output += ((count > 1) ? count.ToString() : String.Empty) + c;
                    count = 0;
                }

                old = c;
                count++;
            }

            output += ((count > 1) ? count.ToString() : String.Empty);

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {output}");
        }
    }
}