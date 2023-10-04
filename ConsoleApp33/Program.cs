using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();

            string reg = @"^(^[;:])(-*)(\(+|\)+|\[+|\]+)$";


            if (Regex.IsMatch(str1, reg))
            {
                Console.WriteLine($"СМАЙЛИКИ: {str1}");
            }

            else
            {
                Console.WriteLine($"НЕ ЯВЛЯЮТСЯ СМАЙЛИКАМИ: {str1}");
            }
            
        }
    }
}
