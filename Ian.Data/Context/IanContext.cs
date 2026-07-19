using Microsoft.EntityFrameworkCore;
public class IanContext : DbContext //inheritance
{
    public DbSet<User> Users => Set<User>();


    public IanContext(DbContextOptions<IanContext> options)
        : base(options)
    {
        
    }
}