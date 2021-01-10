using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Badges = 0;
        }
        public Trainer(string name, int badges, List<Pokemon> pokemons)
            : this(name)
        {

            this.Badges = badges;
            this.Pokemons = pokemons;
        }

        private string name;

        private List<Pokemon> pokemons;

        public string Name { get; set; }

        private int badges;

        public int Badges { get; set; }
       

        public List<Pokemon> Pokemons { get; set; }

    }
}