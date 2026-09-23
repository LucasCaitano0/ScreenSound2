Episodio ep1 = new(1, "Introdução ao C#", 30);
ep1.AdicionarConvidado("Alice");
ep1.AdicionarConvidado("Bob"); 

Episodio ep2 = new(2, "Técnica de aprendizado", 15);
ep2.AdicionarConvidado("Joao");
ep2.AdicionarConvidado("Pedro");
ep2.AdicionarConvidado("Marcos");

Podcast podcast = new("Aprendendo C#", "Carlos");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();