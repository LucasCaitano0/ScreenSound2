Album albumMatue = new Album();
albumMatue.Nome = "XTRANHO";

Musica musica1 = new Musica();
musica1.Nome = "Anos Luz";
musica1.Duracao = 320;
musica1.Genero = "Rap";

Musica musica2 = new Musica();
musica2.Nome = "Backstage";
musica2.Duracao = 296;

albumMatue.AdicionarMusica(musica1);
albumMatue.AdicionarMusica(musica2);

albumMatue.ExibirMusicasDoAlbum();

