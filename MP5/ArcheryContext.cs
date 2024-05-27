using Microsoft.EntityFrameworkCore;

namespace MP5;

public class ArcheryContext : DbContext
{
    public DbSet<Archer> Archers { get; set; }
    public DbSet<Coach> Coaches { get; set; }

    public ArcheryContext()
    {
        SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=archery.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Archer>()
            .HasOne<Coach>(a => a.Coach)
            .WithMany(c => c.Archers)
            .HasForeignKey(a => a.CoachId);

        modelBuilder.Entity<Coach>()
            .HasMany<Archer>(c => c.Archers)
            .WithOne(a => a.Coach)
            .HasForeignKey(a => a.CoachId);

    }
    
}