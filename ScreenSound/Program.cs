Episodio ep1 = new(2, "Tecnica de facilitacao", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Macelo");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(1, "Tecnica de apredizado", 67);
ep2.AdicionarConvidados("Maria");
ep2.AdicionarConvidados("Macelo");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Podcast Dev.net", "Matheus");

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();