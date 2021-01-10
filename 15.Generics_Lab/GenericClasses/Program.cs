using System;

namespace GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> list = new GenericList<string>();
            var newVariable = list.GetElement(1);
            list.Add("Pesho");
            list.Add("55");
            list.Add("hey");

            GenericList<int> listInt = new GenericList<int>();
            var newVariable2 = listInt.GetElement(2);
            listInt.Add(33);
            listInt.Add(1);


            //ObjectList studentName = new ObjectList();
            //studentName.Add("555");
            //studentName.Add("Gosho");
            //studentName.Add(27);
        }
    }
    class Student
    {
        public int Age { get; set; }
    }
}
