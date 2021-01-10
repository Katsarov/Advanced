﻿using System;
using System.IO;


namespace D02.BinaryReaderDemo

{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../input.txt");
            using (reader)
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
