Musica musica1 = new Musica();
musica1.Nome = "Infinitamente";
musica1.Artista = "Novo som";
musica1.Duracao = 300;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "Isaias 6";
musica2.Artista = "Rodolf Abrante";
musica2.Duracao = 400;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();