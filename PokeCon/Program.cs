using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeCon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu
            do
            {
                Console.Clear();
                Escreve("----------------------------");
                Escreve("--------- PokéCon ----------");
                Escreve("----------------------------");
                Escreve("1 - Jogar");
                Escreve("2 - Sair");
                Escreve("----------------------------");
                try
                {
                    int opt = int.Parse(Console.ReadLine());
                    if (opt == 1)
                        SetupInicial();
                    else if (opt == 2)
                        Environment.Exit(0);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Escreve("\nUm erro terrível aconteceu!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Escreve(e + "\n\n\n");
                }
                Console.ReadKey();
            } while (true);
        }

        /// <summary>
        /// Mostra mensagem e retorna o que o usuario escrever
        /// </summary>
        static public string PegaValor(string msg)
        {
            Escreve(msg);
            return Console.ReadLine();
        }

        /// <summary>
        /// writeline mais simples
        /// </summary>
        static public void Escreve(string texto)
        {
            Console.WriteLine(texto);
        }

        /// <summary>
        /// Mostra todos os pokemons da lista
        /// </summary>
        static public void MostraPokemons(List<Pokemon> pkms)
        {
            Console.Clear();
            Escreve("--------------- Lista de Pokemons---------------------");
            foreach (var pokemon in pkms)
            {
                Escreve(pokemon.Nome);
            }
        }

        /// <summary>
        /// Cria uma lista de pokemons iniciais e retora ela
        /// </summary>
        /// <returns></returns>
        static public List<Pokemon> PokemonsPadrao()
        {
            List<Pokemon> setPokes = new List<Pokemon>();

            setPokes.Add(new Pokemon("Bulbasaur", 60, 10, 30));
            setPokes.Add(new Pokemon("Charmander", 30, 50, 20));
            setPokes.Add(new Pokemon("Squirtle", 55, 20, 25));
            setPokes.Add(new Pokemon("Chikorita", 45, 20, 25));
            setPokes.Add(new Pokemon("Totodile", 50, 30, 20));
            setPokes.Add(new Pokemon("Cyndaquil", 40, 55, 5));
            setPokes.Add(new Pokemon("Mudkip", 70, 25, 5));
            setPokes.Add(new Pokemon("Treecko", 0, 0, 0));
            setPokes.Add(new Pokemon("Torchic", 0, 0, 0));
            setPokes.Add(new Pokemon("Turtwig", 0, 0, 0));

            return setPokes;
        }

        /// <summary>
        /// Define jogadores e seus respectivos pokemons, então inicia o jogo
        /// </summary>
        static public void SetupInicial()
        {
            //inicia variáveis vitais
            List<Pokemon> pokemonsIniciais = PokemonsPadrao();
            Jogador[] jogadores = new Jogador[2];
            Escreve("\nO jogo vai começar!\n");

            //Adiciona jogador 1
            Escreve("Digite o nome do primeiro Treinador de pokemons: ");
            jogadores[0] = new Jogador(Console.ReadLine(), new Pokemon[3]);
            //Adiciona jogador 2
            Escreve("Digite o nome do segundo Treinador de pokemons: ");
            jogadores[1] = new Jogador(Console.ReadLine(), new Pokemon[3]);

            Escreve("\nCada jogador deve escolher um pokemon por vez (Max 3)\n");

            //Intercala entre os jogadores para escolherem um pokemon por vez
            for (int i = 0; i < 6; i++)
            {
                //Mostra lista sempre atualizada
                MostraPokemons(pokemonsIniciais);

                //Escolhe o pokemon
                string escolha = PegaValor("\n" + jogadores[i % 2].Nome + " digite o nome de um pokemon:");

                //Verifica se o pokemon escolhido existe
                bool existePokemon = false;
                foreach (var pokemon in pokemonsIniciais)
                {
                    if (escolha.ToLower() == pokemon.Nome.ToLower())
                        existePokemon = true;
                }
                if (!existePokemon)
                {
                    Escreve("\nEste pokemon não está na lista, Tente novamente...");
                    Console.ReadKey();
                    i--;
                    continue;
                }

                //adiciona o pokemon e remove da lista inicial
                for (int j = 0; j < pokemonsIniciais.Count; j++)
                {
                    if (pokemonsIniciais[j].Nome.ToLower() == escolha.ToLower())
                    {
                        Escreve("\nPokebola de " + pokemonsIniciais[j].Nome + " adicionado a sua mochila!");
                        jogadores[i % 2].Pokemons[i % 3] = pokemonsIniciais[j];
                        pokemonsIniciais.RemoveAt(j);
                    }
                }
                Console.ReadKey();
            }

            Escreve("\n--------------------------");
            for (int i = 0; i < 2; i++)
            {
                Escreve("\n--------------------------\n\t" + jogadores[i].Nome + "\n");
                foreach (var pokemon in jogadores[i].Pokemons)
                {
                    Escreve("\n" + pokemon.Nome);
                    Escreve("Ataque: " + pokemon.Dano);
                    Escreve("Defesa: " + pokemon.Defesa);
                    Escreve("Vida: " + pokemon.Vitalidade);
                }
            }
            ComecaBatalha(jogadores);
        }

        private static void ComecaBatalha(Jogador[] jogadores)
        {
            Random rnd = new Random();
            int playerIndex;


            //jogador inicial é aleátorio, após é sempre intercalado
            //jogador inicial escolhe pokemon para atacar
            //segundo jogador escolhe o pokemon que irá defender
            //mostra status dos pokemons escolhidos e mostra resultado pokemonDefendor.hp = atk - pokemonDefensor.def
        }
    }
}
