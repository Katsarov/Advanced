using System;
using System.IO;

namespace D06.Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("../../../TestFolder2");
            //Directory.Delete("TestFolder");
        }
    }
}
