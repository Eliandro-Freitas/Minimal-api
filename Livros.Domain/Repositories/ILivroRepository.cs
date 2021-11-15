using Livros.Domain.Entities;

namespace Livros.Domain.Repositories;
public interface ILivroRepository
{
    IEnumerable<Livro> Get();
}
