using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
        private string name;
        private string element;

        public string Name { get; set; }


        public string Element { get; set; }

        private int health;

        public int Health { get; set; }
    }
}
