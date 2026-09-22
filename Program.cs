Banda matue = new Banda("Matue");

Album albumMatue = new Album("XTRANHO");

Musica musica1 = new Musica(matue, "Anos Luz")
{
    Duracao = 320,
    Disponivel = true
};

Musica musica2 = new Musica(matue, "Backstage")
{
    Duracao = 296,
    Disponivel = false
};

albumMatue.AdicionarMusica(musica1);
albumMatue.AdicionarMusica(musica2);
matue.AdicionarAlbum(albumMatue);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumMatue.ExibirMusicasDoAlbum();
matue.ExibirDiscografia();


