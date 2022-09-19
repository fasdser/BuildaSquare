using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildaSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateShape(2));

            Console.ReadLine();
        }

        public static string GenerateShape(int n)
        {
            if (n == 0)
            {
                return "";
            }
            if (n == 1)
            {
                return "+";
            }
            string place = "+";
            string square = "";
            int a = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    square += place;
                }
                square += "\n";
            }
          
            return square.Remove(square.Length-1);
        }

        public static string GenerateShape1(int n)
    => string.Join("\n", Enumerable.Repeat(new string('+', n), n));

        public static string GenerateShape2(int n)
        {
            string[] tempAns = new string[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tempAns[i] += "+";
                }
            }

            return string.Join("\n", tempAns);
        }

        public static string GenerateShape3(int n)
        {
            string s = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    s += "+";
                }
                if (i == n)
                    break;
                s += "\n";
            }
            return s;
        }
    }

   
}
