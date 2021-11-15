using Livros.Domain.Entities;
using Livros.Infra;

namespace Livros.API.Controllers;
public static class LivrosController
{
    public static void GetControllers(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("/v1/livros", (ApplicationContext context) =>
        {
            var livros = context.Livros.ToList();
            return livros is not null ? Results.Ok(livros) : Results.NotFound();
        }).Produces<Livro>();
    }
}