using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxFromNumberString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a list of numbers separated by a comma.");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);
            foreach (var stringNum in numbers)
            {
                var checkNum = Convert.ToInt32(stringNum);
                if (checkNum > max) max = checkNum;
            }
            Console.WriteLine(max);
        }
    }
}
