using System;
using System.Collections.Generic;
using System.Linq;

namespace SantasPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boxes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> materials = new Stack<int>(boxes);

            int[]magics = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> magic = new Queue<int>(magics);

            //Console.WriteLine(string.Join(", ", materialBoxes));
            //Console.WriteLine(string.Join(", ", levelMagics));

            List<Toy> toys = new List<Toy>()
            {
                new Toy("Doll", 150),
                new Toy("Wooden train", 250),
                new Toy("Teddy bear", 300),
                new Toy("Bicycle", 400)
            };

            while (materials.Any() && magic.Any())
            {
                int product = materials.Peek() * magic.Peek();

                if (toys.Any(p => p.MaterialsNeededToCraft == product))
                {
                    toys.Find(p => p.MaterialsNeededToCraft == product).ToyCount++;
                    materials.Pop();
                    magic.Dequeue();
                }

                else if (product < 0)
                {
                    product = materials.Peek() + magic.Peek();
                    materials.Pop();
                    magic.Dequeue();
                    materials.Push(product);
                        
                }

                else if (product == 0)
                {
                    if (materials.Peek() == 0)
                    {
                        materials.Pop();
                    }
                    if (magic.Peek() == 0)
                    {
                        magic.Dequeue();
                    }
                }

                else
                {
                    materials.Push(materials.Pop() + 15);
                    magic.Dequeue();
                }
            }

            if ((toys.Where(p => p.Name == "Doll" && p.ToyCount > 0).Count() != 0
                && toys.Where(p => p.Name == "Wooden train" && p.ToyCount > 0).Count() != 0)
                || (toys.Where(p => p.Name == "Teddy bear" && p.ToyCount > 0).Count() != 0
                && toys.Where(p => p.Name == "Bicycle" && p.ToyCount > 0).Count() != 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Any())
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if (magic.Any())
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magic)}");
            }

            foreach (var item in toys.Where(p => p.ToyCount > 0).OrderBy(p => p.Name))
            {
                Console.WriteLine($"{item.Name}: {item.ToyCount}");
            }
        }
    }

    public class Toy
    {
        public Toy(string name, int materialsNeeded)
        {
            this.Name = name;
            this.MaterialsNeededToCraft = materialsNeeded;
        }

        public string Name { get; set; }
        public int MaterialsNeededToCraft { get; set; }
        public int ToyCount { get; set; }
    }
}
