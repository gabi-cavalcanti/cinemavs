using System.Runtime.CompilerServices;

namespace filmes.alura;

public class filme
{
    public string titulo { get; }
    private double duracao { get; }
    private List<artistas> elenco { get; }

    public filme(string Titulo, double Duracao)
    {
        this.titulo = Titulo;
        this.duracao = Duracao;
        this.elenco = new List<artistas>();
    }

    public void adicionarartista(params artistas[] listaartista)
    {
        foreach (var artista in listaartista)
        if(!elenco.Contains(artista))
        {
            elenco.Add(artista);

            artista.Adicionarfilme(this);

        }
    }
    public void Exibirfichatecnica()
    {
        Console.WriteLine($"nome do filme {titulo}:");
        Console.WriteLine($"duração do filme {duracao} minutos:");
        foreach (var artistas in elenco)
        {
            Console.WriteLine($"artista do filme {artistas.nome}");
        }

    }
}
public class artistas
{
   public string nome { get; }
   private int idade { get; }
   private List<filme> filmes { get; }
    public artistas (string Nome, int Idade)
    {

        this.nome = Nome;
        this.idade = Idade;
        this.filmes =new List<filme>();
    }

    public void Adicionarfilme (params filme[] listafilme)
    {
        foreach (var filme in listafilme)
        if (!filmes.Contains(filme))
        {
            filmes.Add(filme);
            filme.adicionarartista(this);
        }
    }
    public void exibirfichatecnicaartistaI()
    {
        Console.WriteLine($"nome do artista {nome}:");
        Console.WriteLine($"idade do artista {idade} anos");
        foreach (var filme in filmes)
        {
            Console.WriteLine($"filmes do artista {filme.titulo}");
        }
    }
}


