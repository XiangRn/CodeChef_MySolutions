using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[t];
            for (int i = 0; i < t; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }           
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(string.Join("", numbers[i].ToString().Reverse().ToArray()));
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
