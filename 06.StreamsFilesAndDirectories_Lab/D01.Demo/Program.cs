using System;
using System.IO;

namespace D01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../input.txt");
            string student = reader.ReadToEnd();
            Console.WriteLine(student);
            //string student = reader.ReadLine();
            //while (student != null)
            //{
            //    Console.WriteLine(student);
            //    student = reader.ReadLine();
            //}
            
            reader.Close();


            //StreamWriter writer = new StreamWriter("../../../students.txt");
            //writer.Write("First student!!");
            //writer.WriteLine("Second student Pesho!");
            //writer.WriteLine("Third student Anton!");
            //writer.Close();
        }
    }
}
