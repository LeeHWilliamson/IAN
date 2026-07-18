using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class IanContextFactory : IDesignTimeDbContextFactory<IanContext>
{
    public IanContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<IanContext>();

        options.UseNpgsql(
            "Host=localhost;Port=5432;Database=ian;Username=ian;Password=goodboy");

        return new IanContext(options.Options);
    }
}