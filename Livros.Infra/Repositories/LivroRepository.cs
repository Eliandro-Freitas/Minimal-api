using Livros.Domain.Entities;
using Livros.Domain.Repositories;

namespace Livros.Infra.Repositories;
public class LivroRepository : ILivroRepository
{
    private readonly ApplicationContext _context;

    public LivroRepository(ApplicationContext context)
        => _context = context;

    public IEnumerable<Livro> Get()
        => _context.Livros.ToList();
}