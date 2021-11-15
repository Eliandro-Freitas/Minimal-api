namespace Livros.Domain.Entities;
public class Livro
{
    public Livro(string name, string autor)
    {
        Name = name;
        Autor = autor;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Autor { get; set; }
}