Album albumMatue = new Album();
albumMatue.Nome = "XTRANHO";

Musica musica1 = new Musica();
musica1.Nome = "Anos Luz";
musica1.Duracao = 320;

Musica musica2 = new Musica();
musica2.Nome = "Backstage";
musica2.Duracao = 296;

albumMatue.AdicionarMusica(musica1);
albumMatue.AdicionarMusica(musica2);

Banda matue = new Banda();
matue.Nome = "Matue";
matue.AdicionarAlbum(albumMatue);
matue.ExibirDiscografia();


