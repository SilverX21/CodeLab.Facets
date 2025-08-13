using CodeLab.Facets.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeLab.Facets;

internal class AppDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    //Here we set the in memory database for testing purposes.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("CodeLabFacetsDb");
    }
}