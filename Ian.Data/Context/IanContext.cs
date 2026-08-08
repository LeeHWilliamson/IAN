using Microsoft.EntityFrameworkCore;
using Ian.Core.Interfaces;
using Ian.Core.Models;
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