using Microsoft.EntityFrameworkCore;
using Ian.Core.Interfaces;
public class IanContext : DbContext //inheritance
{
    public DbSet<IUser> Users => Set<IUser>();
    public DbSet<ILedgerEntry> LedgerEntries => Set<ILedgerEntry>();

    public DbSet<IAccount> Accounts => Set<IAccount>();

    public IanContext(DbContextOptions<IanContext> options)
        : base(options)
    {

    }
}