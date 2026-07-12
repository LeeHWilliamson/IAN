using Microsoft.EntityFrameworkCore;
public class IanContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    public IanContext(DbContextOptions<IanContext> options)
        : base(options)
    {
    }
}