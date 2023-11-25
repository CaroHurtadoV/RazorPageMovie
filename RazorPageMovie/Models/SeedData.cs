using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;

namespace RazorPageMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPageMovieContext>>()))
            {
                //En caso de conexto nulo, se envia un mensaje de error
                if (context == null || context.Movie == null) 
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                
                }

                if (context.Movie.Any())
                {
                    //Base de datos muestra todo lo que contiene esta clase
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Spiderman",
                        RealeseDate = DateTime.Parse("1991-02-01"),
                        Genre = "Aventura",
                        Price = 55.96M,
                    },
                    new Movie
                    {
                        Title = "Spiderman II",
                        RealeseDate = DateTime.Parse("1999-10-11"),
                        Genre = "Comic",
                        Price = 45M,
                    },
                    new Movie
                    {
                        Title = "Spiderman III",
                        RealeseDate = DateTime.Parse("2023-10-15"),
                        Genre = "Caricatura",
                        Price = 6.55M,
                    }

                    );
                context.SaveChanges();

            }
        }
    }
}
