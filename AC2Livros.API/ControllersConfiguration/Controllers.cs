using Livros.Domain.Entities;
using Livros.Infra;

namespace AC2Livros.API.ControllersConfiguration;
public static class Controllers
{
    public static void ApplyControllers(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("/v1/livros", (ApplicationContext context) =>
        {
            AddLivros(context);
            var livros = context.Livros.ToList();
            return livros is not null ? Results.Ok(livros) : Results.NotFound();
        }).Produces<Livro>();
    }

    //Popula a base com alguns dados
    private static void AddLivros(ApplicationContext context)
    {
        context.Livros.AddRange(
            new Livro("Clean Code", "Robert Cecil Martin"),
            new Livro("The Clean Coder", "Robert Cecil Martin"),
            new Livro("Clean Architecture", "Robert Cecil Martin"));
        context.SaveChanges();
    }
}