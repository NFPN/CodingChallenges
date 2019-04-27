///NatanaelFPN - 04112019 - Teste de programação Saulo, Senac SJRP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        /*class Resposta
        {
            private string Texto { get; set; }
            private bool IsCorreta { get; set; }

            public Resposta SetValues(string t, bool ic = false)
            {
                return new Resposta() { Texto = t, IsCorreta = ic };
            }
        }*/

        public struct Jogador
        {
            public string nome;
            public int pontos;
        }
        public struct Perguntas
        {
            public string titulo;
            public string[] respostas;
            public int indiceCorreto;

            public Perguntas(string t, string[] r, int i)
            {
                titulo = t;
                respostas = r;
                indiceCorreto = i;
            }
        }

        static void Main(string[] args)
        {
            Perguntas[] perguntas = PerguntasPadrao();
            List<Jogador> ranking = new List<Jogador>();
            ranking.Add(new Jogador() { nome = "teste1", pontos = 1 });
            ranking.Add(new Jogador() { nome = "teste2", pontos = 2 });
            ranking.Add(new Jogador() { nome = "teste3", pontos = 3 });

            do
            {
                Console.Clear();
                int option = 0;
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!! QUIZ DO SAL !!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n\n");
                Escreve("\n1 - Jogar" +
                    "\n2 - Ranking de pontos" +
                    "\n3 - Sair");

                Escreve("\nDigite sua escolha: ");
                try
                {
                    option = int.Parse(Console.ReadLine());
                    if (option == 3)
                        Environment.Exit(0);
                    else
                        Escolha(option, perguntas, ranking);

                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Escreve("\nUM ERRO INESPERADO OCORREU!!\n");
                    Console.WriteLine(e);
                    Console.ForegroundColor = ConsoleColor.White;
                    Escreve("\n\nAperte qualquer tecla para voltar ao menu principal...\n");
                    Console.ReadKey();
                }
            } while (true);
        }

        //set de perguntas descrevidas no enunciado
        static public Perguntas[] PerguntasPadrao()
        {
            Perguntas[] perguntas = new Perguntas[7];

            //Resposta resp = new Resposta().SetValues("teste",true);
            

            perguntas[0] = new Perguntas(
                "Qual foi a Joia do Infinito que apareceu no segundo filme do Thor?",
                new string[]
                {
                    "Alma",
                    "Mente",
                    "Poder",
                    "Espaço",
                    "Tempo",
                    "Realidade"
                }, 5);

            perguntas[1] = new Perguntas(
                "Em qual filme Capitão América perde seu escudo oficial?",
                new string[]
                {
                    "Capitão América: Guerra Civil",
                    "Thor ragnarok",
                    "Avengers: Era de Ultron",
                    "Homem de Ferro 2"
                }, 0);

            perguntas[2] = new Perguntas(
                "Quem foi que f@! #$%(estragou o plano) para derrotar o Thanos?",
                new string[]
                {
                    "O Miranha",
                    "Peter Quill",
                    "Senhor das Estrelas",
                    "Gamora",
                    "Doutor Estranho"
                }, 1);
            perguntas[3] = new Perguntas(
                "O Doutor Estranho era...",
                new string[]
                {
                    "Neurocirurgião",
                    "Médico",
                    "Cirurgião plástico",
                    "Cirurgião batriatrico"
                }, 0);
            perguntas[4] = new Perguntas(
                "Que dia o maior herói da Marvel Stan Lee morreu?",
                new string[]
                {
                    "2 de dezembro de 2018",
                    "8 de janeiro de 2019",
                    "15 de dezembro de 2018",
                    "20 de janeiro de 2019",
                    "2 de fevereiro de 2019",
                    "12 de novembro de 2018"
                }, 5);
            perguntas[5] = new Perguntas(
                "Qual herói o Thanos tem mais medo?",
                new string[]
                {
                    "Homem de Ferro",
                    "Gamora (putz)",
                    "Capitão América",
                    "O Miranha",
                    "Thor",
                    "Grott",
                    "Capitã Mar-vell"
                }, 0);
            perguntas[6] = new Perguntas(
                "Quem morreu no filme Guerra Infinita?",
                new string[]
                {
                    "50% da população do universo",
                    "Gamora, Loki, Senhor das estrela, Visão, Pantera Negra, Grott, Feiticeira, Buck, Doutor Estranho"
                }, 0);

            return perguntas;
        }

        //pega uma lista e embaralha os elementos dela, retorna uma lista embaralhada
        static public List<T> EmbaralhaLista<T>(List<T> listaDeEntrada)
        {
            List<T> randomList = new List<T>();

            Random r = new Random();
            int randomIndex = 0;
            while (listaDeEntrada.Count > 0)
            {
                randomIndex = r.Next(0, listaDeEntrada.Count); // numero aleátorio entre 0 e numero de itens da lista
                randomList.Add(listaDeEntrada[randomIndex]); // adiciona o item com o indice de numero aleatório
                listaDeEntrada.RemoveAt(randomIndex); // remove o item[indice] para evitar duplicidade
            }
            return randomList;
        }

        //digita caractere por caractere com tempo predefinido, mas pode ser mudado ao invocar
        static void Escreve(string texto, int velocidadeDeEscrita = 30, bool pulaLinha = true)
        {
            foreach (char c in texto)
            {
                Console.Write(c);
                Thread.Sleep(velocidadeDeEscrita);
            }
            if (pulaLinha)
                Console.Write("\n");
        }
        //executa as opções e retorna ranking pro main
        private static List<Jogador> Escolha(int option, Perguntas[] pergs, List<Jogador> rank)
        {
            switch (option)
            {
                case 1:
                    rank = Jogo(pergs, rank);
                    break;
                case 2:
                    if (rank.Count > 0)
                    {
                        //Organiza o ranking por pontuação do maior para o menor
                        rank = rank.OrderByDescending(j => j.pontos).ToList();

                        Console.WriteLine("!!!!!!!!!!!! Ranking !!!!!!!!!!!!!!");

                        foreach (var jogador in rank)
                            Console.WriteLine("!!\tNome:{0} Pontos: {1}", jogador.nome, jogador.pontos);

                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    }
                    else
                        Escreve("\n\n Ningúem jogou ainda.");

                    break;
                default:
                    break;
            }

            Escreve("\n\n Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            return rank;
        }
        
        //Executa o Quiz, adiciona um jogador no ranking e retorna ranking
        static public List<Jogador> Jogo(Perguntas[] p, List<Jogador> r)
        {
            int resposta, generatedNum;
            Jogador jogador = new Jogador();
            Random randomNum = new Random();

            bool[] respondeu = new bool[p.Length];
            for (int i = 0; i < respondeu.Length; i++)
                respondeu[i] = false;


            Console.Clear();
            Escreve("\nPrepare-se pois o jogo está prestes a começar!\n");
            Escreve("\nMas antes disso...");
            Escreve("Qual o seu nome: ");
            jogador.nome = Console.ReadLine();
            jogador.pontos = 0;
            Escreve("\nMuito bem " + jogador.nome + " vamos começar o jogo pra valer agora!");

            List<int> sequenciaAleatoria = new List<int>();
            for (int i = 0; i < p.Length; i++)
                sequenciaAleatoria.Add(i);

            sequenciaAleatoria = EmbaralhaLista(sequenciaAleatoria);

            for (int i = 0; i < p.Length; i++)
            {
                generatedNum = sequenciaAleatoria.ElementAt(i);
                respondeu[generatedNum] = true;

                Console.WriteLine("----------------------------------------------------------");
                Escreve("\nPergunta número " + (i + 1) + ":");

                Escreve("\n" + p[generatedNum].titulo);
                for (int j = 0; j < p[generatedNum].respostas.Length; j++)
                {
                    Escreve((j + 1) + ": " + p[generatedNum].respostas[j]);
                }

                Escreve("\nQual sua resposta: ");
                resposta = int.Parse(Console.ReadLine()) - 1;

                Escreve("\nA resposta está", 80, false);
                Escreve("\n... ", 300);

                if (resposta == p[generatedNum].indiceCorreto)
                {
                    jogador.pontos++;
                    Escreve("Correta!\n");
                }
                else
                {
                    Escreve("Errada!\n");
                }
                Escreve("Pontos: " + jogador.pontos,80);
            }
            r.Add(jogador);
            if (jogador.pontos == p.Length) Escreve("\nParabéns você acertou tudo! Você ganhou um biscoito virtual.\n\n");
            else if (jogador.pontos == 0) Escreve("\n\nXiii, não sabe nada em,\n");
            else Escreve("\nPelo menos algo você sabia(ou chutou muito bem)\n\n");

            Escreve("\n Você fez " + jogador.pontos + " pontos no total.\n\n");

            Console.ReadKey();
            return r;
        }
    }
}
