Album albumMatue = new Album();
albumMatue.Nome = "XTRANHO";

Musica musica1 = new Musica();
musica1.nome = "Fogueira";
musica1.artista = "Jorge e Mateus";
musica1.duracao = 275;
musica1.disponivel = true;

Musica musica2 = new Musica();
musica2.Nome = "Backstage";

albumMatue.AdicionarMusica(musica1);
albumMatue.AdicionarMusica(musica2);

