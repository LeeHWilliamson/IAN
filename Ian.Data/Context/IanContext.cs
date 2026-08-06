using Microsoft.EntityFrameworkCore;
using Ian.Core.Models;
using System.Dynamic;
public class IanContext : DbContext //inheritance
{
    public DbSet<User> Users => Set<User>();
    public DbSet<LedgerEntry> LedgerEntries => Set<LedgerEntry>();

    public DbSet<Account> Accounts => Set<Account>(); 

    public IanContext(DbContextOptions<IanContext> options)
        : base(options)
    {
        
    }
}