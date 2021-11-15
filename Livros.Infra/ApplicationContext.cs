using Livros.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Livros.Infra;
public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
    {
        
    }

    public DbSet<Livro> Livros { get; set; }
}