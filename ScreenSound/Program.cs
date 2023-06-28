Banda pg = new Banda("PG");

Album albumDoPG = new Album("Eu sou livre");

Musica musica1 = new Musica(pg, "Quem sou eu?")
{
    Duracao = 300,
    Disponivel = true,
};

Musica musica2 = new Musica(pg, "Te vejo")
{
    Duracao =  207,
    Disponivel = false,

};

albumDoPG.AdicionarMusica(musica1);
albumDoPG.AdicionarMusica(musica2);
pg.AdicionarAlbum(albumDoPG);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoPG.ExibirMusicaDoAlbum();
pg.ExibirDiscografia();
