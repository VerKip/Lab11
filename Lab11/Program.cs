using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения k и b");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Result result = new Result(k,b);
            Console.WriteLine(result.Root());
            Console.ReadKey();
        }
    }
}
