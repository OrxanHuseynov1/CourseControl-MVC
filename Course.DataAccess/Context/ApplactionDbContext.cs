using Course.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Course.DataAccess.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Domain.Entites.Course> Courses { get; set; }
}
