namespace PokeCon
{
    class Pokemon
    {
        public Pokemon() { }
        public Pokemon(string nome, int dano, int defesa, int vitalidade)
        {
            Nome = nome;
            Dano = dano;
            Defesa = defesa;
            Vitalidade = vitalidade;
        }

        public string Nome { get; }
        public int Dano { get; }
        public int Defesa { get; }
        public int Vitalidade { get; }

    }
}
