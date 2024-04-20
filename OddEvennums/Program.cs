using System;
using System.Collections.Generic;
using System.Linq;

namespace OddEvennums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Printnums("numbers", num);
            Printnums("Even nums", num.Where(x => isEven(x)));
            Printnums("Odd nums", num.Where(x => isOdd(x)));
        }
        public static void Printnums(string title,IEnumerable<int> numbers) 
        {
            Console.WriteLine();
            Console.Write($"{title}: [");
            foreach(int i in numbers) Console.Write(i);
            Console.Write($"]");
            Console.WriteLine();

        }
        public static bool isEven(int num) => num % 2 == 0;
        public static bool isOdd(int num)=> !isEven(num);

    }

}
