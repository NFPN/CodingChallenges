using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeCon
{
    class Jogador
    {
        public Jogador() { }
        public Jogador(string nome, Pokemon[] pokemons)
        {
            Nome = nome;
            Pokemons = pokemons == null ? new Pokemon[3] : pokemons;
        }

        public string Nome { get; }
        public Pokemon[] Pokemons { get; set; }
    }
}

