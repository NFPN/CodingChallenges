using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
        static public void Escreve(string texto, bool pulaLinha = true)
        {
            if (pulaLinha) Console.WriteLine(texto);
            else Console.Write(texto);
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
            setPokes.Add(new Pokemon("Treecko", 30, 30, 40));
            setPokes.Add(new Pokemon("Torchic", 50, 30, 20));
            setPokes.Add(new Pokemon("Turtwig", 15, 40, 45));

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
            jogadores[0] = new Jogador(Console.ReadLine(),null);

            //Adiciona jogador 2
            Escreve("\nDigite o nome do segundo Treinador de pokemons: ");
            jogadores[1] = new Jogador(Console.ReadLine(),null);

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

            /*//Mostra na tela os pokemons de cada jogador
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
            }*/
            ComecaBatalha(jogadores);
        }

        /// <summary>
        /// Executa combate usando os pokemons escolhidos até que algúem fique sem nenhum
        /// </summary>
        private static void ComecaBatalha(Jogador[] jogadores)
        {
            //jogador inicial é aleátorio, após é sempre intercalado
            Random rnd = new Random();
            int player1Index = rnd.Next(1000) % 2 == 0 ? 0 : 1,
                player2Index = player1Index == 1 ? 0 : 1;


            string escolha = "", ganhador = "";
            bool existeEscolha;

            int pokeOut = 0, pokeAtkID = 0, pokeDefID = 0, turno = 1, dano = 0, aux = 0;

            Escreve("\nA batalha pokemon irá começar!\n\tO jogador escolhido foi: " + jogadores[player1Index].Nome);

            Escreve("\nAperte qualquer tecla para começar...");
            Console.ReadKey();


            Escreve("\n\n\tTurno " + turno + "\n---------------------------------\n");
            //jogador escolhe pokemon para atacar
            do
            {
                existeEscolha = false;
                Escreve("\n\n" + jogadores[player1Index].Nome + " escolha o pokémon com qual deseja ATACAR: ");

                //Mostra e escolhe pokemon atacante
                foreach (var pokemon in jogadores[player1Index].Pokemons)
                {
                    if (pokemon.Vitalidade > 0)
                        Escreve(pokemon.Nome);
                }
                escolha = PegaValor("");

                //foreach (var pokemon in jogadores[playerIndex % 2].Pokemons)
                for (int i = 0; i < jogadores[player1Index].Pokemons.Length; i++)
                    if (escolha.ToLower() == jogadores[player1Index].Pokemons[i].Nome.ToLower()&&
                        jogadores[player1Index].Pokemons[i].Vitalidade > 0)
                    {
                        existeEscolha = true;
                        pokeAtkID = i;
                        break;
                    }


                if (!existeEscolha)
                {
                    Escreve("\nEste pokemon não está em sua mochila, ou está inconsciente\n");
                    continue;
                }
                else
                {
                    //segundo jogador escolhe o pokemon que irá defender
                    do
                    {
                        existeEscolha = false;
                        Escreve("\n\n" + jogadores[player2Index].Nome +
                            " escolha o pokémon com qual deseja DEFENDER: ");

                        // Mostra e escolhe pokemon defensor
                        foreach (var pokemon in jogadores[player2Index].Pokemons)
                            if (pokemon.Vitalidade > 0)
                                Escreve(pokemon.Nome);
                        escolha = PegaValor("");
                        for (int i = 0; i < jogadores[player2Index].Pokemons.Length; i++)
                            if (escolha.ToLower() == jogadores[player2Index].Pokemons[i].Nome.ToLower()&&
                                jogadores[player1Index].Pokemons[i].Vitalidade > 0)
                            {
                                existeEscolha = true;
                                pokeDefID = i;
                                break;
                            }

                        if (!existeEscolha)
                        {
                            Escreve("\nEste pokemon não está em sua mochila, ou está inconsciente\n");
                            continue;
                        }
                        else
                            break;
                    } while (true);

                    //mostra pokemons escolhidos e mostra resultado pokemonDefendor.hp = atk - pokemonDefensor.def
                    Escreve("\n" +
                        jogadores[player1Index].Pokemons[pokeAtkID].Nome + " ataca " +
                        jogadores[player2Index].Pokemons[pokeDefID].Nome);

                    dano = jogadores[player1Index].Pokemons[pokeAtkID].Dano -
                           jogadores[player2Index].Pokemons[pokeDefID].Defesa;

                    //Pokemon defendeu
                    if (dano <= 0)
                    {
                        dano = 1;
                        Escreve("Seu ataque foi extremamente....INEFICIENTE");
                        Escreve(jogadores[player2Index].Pokemons[pokeDefID].Nome + " Perde 1 de vida");
                        jogadores[player2Index].Pokemons[pokeDefID].Vitalidade -= 1;
                    }
                    else
                    {
                        //Pokemon fora de combate
                        if (dano >= jogadores[player2Index].Pokemons[pokeDefID].Vitalidade)
                        {
                            Escreve("Seu ataque foi extremamente....EFICIENTE!");
                            Escreve(jogadores[player2Index].Pokemons[pokeDefID].Nome + " está fora de combate!");
                            jogadores[player2Index].Pokemons[pokeDefID].Vitalidade = 0;
                        }
                        //Pokemon levou dano mas não está fora de combate
                        else
                        {
                            Escreve(jogadores[player2Index].Pokemons[pokeDefID].Nome + " recebeu " + dano + " de dano");
                            jogadores[player2Index].Pokemons[pokeDefID].Vitalidade -= dano;
                        }
                    }
                    Escreve("\nAperte qualquer tecla para passar o turno...");
                    Console.ReadKey();
                }

                //Se um jogador tiver todos os pokemons com a vitalidade zerada o jogo acaba
                for (int i = 0; i < 2; i++)
                {
                    pokeOut = 0;
                    for (int j = 0; j < 3; j++)
                        if (jogadores[i].Pokemons[j].Vitalidade == 0)
                            pokeOut++;
                    if (pokeOut >= 3)
                    {
                        ganhador = i == 0 ? jogadores[1].Nome : jogadores[0].Nome;
                        break;
                    }
                }
                if (pokeOut >= 3)
                    break;
                //Se não continua e troca os indices
                turno++;
                Escreve("\n\n\tTurno "+turno+"\n---------------------------------\n");
                aux = player1Index;
                player1Index = player2Index;
                player2Index = aux;
            } while (true);

            Escreve("\n\nO ganhador foi " + ganhador + "\n\n\tPARABENS VOCE É O MELHOR MESTRE POKEMON!\n\n\n");
            Console.ReadKey();
        }
    }
}
