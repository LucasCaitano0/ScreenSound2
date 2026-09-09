class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";


    public void EscreverDisponivel(bool value)
    {
        Disponivel = value;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Artista da música: {Artista}");
        Console.WriteLine($"Duração da música: {Duracao} segundos");

        Console.WriteLine(DescricaoResumida);
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Não disponível no plano.");
        }

    }
        
}

