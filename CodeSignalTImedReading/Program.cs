using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeSignalTImedReading
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello my friends";
            
            int a = timedReading(4, text);

            Console.WriteLine(a);
            Console.ReadLine();
        }
        public static int timedReading(int maxLength, string text)
        {
            int count = 0;
            string[] str = text.Split();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length <= maxLength && Regex.IsMatch(str[i], @"[a-zA-Z]"))
                    count++;
                else if (str[i].Contains("?") && Regex.IsMatch(str[i], @"[a-zA-Z]"))
                    count++;
            }
            return count;


        }
    }
}
