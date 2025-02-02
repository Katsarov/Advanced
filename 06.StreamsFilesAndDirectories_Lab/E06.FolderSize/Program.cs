﻿using System;
using System.IO;

namespace E06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Console.ReadLine();

            string[] files = Directory.GetFiles(directoryPath);
            double sum = 0;
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{info.FullName} --> {info.Length} bytes.");
                sum += info.Length;
            }

            Console.WriteLine(sum);
        }
    }
}
