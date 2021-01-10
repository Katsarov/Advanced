using System;
using System.IO;

namespace D03.Streams_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = new byte[100];
            //for (byte i = 0; i < 100; i++)
            //{
            //    buffer[i] = i;
            //}

            using (FileStream stream = new FileStream("../../../input.txt", FileMode.OpenOrCreate))
            {

                Console.WriteLine($"Stream Position: {stream.Position}");
                //stream.Write(buffer, 0, buffer.Length);
                stream.Read(buffer, 0, 3);
                Console.WriteLine($"Stream Position: {stream.Position}");

                stream.Read(buffer, 0, 3);
                Console.WriteLine($"Stream Position: {stream.Position}");

                Console.WriteLine(string.Join(" ", buffer));
            }
        }
    }
}
