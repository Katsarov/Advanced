using System;
using System.Collections.Generic;

namespace D02.Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet<int> nums = new HashSet<int>();
            //nums.Add(5);
            //nums.Add(6);
            //nums.Add(4);
            //nums.Add(9);
            //nums.Add(1);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //nums.Remove(9);
            //Console.WriteLine();

            //Console.WriteLine(nums.Contains(6));
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            HashSet<string> names = new HashSet<string>();
            names.Add("Pesho");
            names.Add("Pesho");
            names.Add("Gosho");
            Console.WriteLine(string.Join(", ", names));
        }
    }
}
