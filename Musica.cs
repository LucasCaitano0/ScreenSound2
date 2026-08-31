class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {nome}");
        Console.WriteLine($"Artista da música: {artista}");
        Console.WriteLine($"Duração da música: {duracao} segundos");
        if (disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Não disponível no plano.");
        }
        
    }
}

