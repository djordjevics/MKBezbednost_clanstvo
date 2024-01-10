using DataLayer.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DataLayer;

public class MKBContext : DbContext
{
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<MemberCard> MemberCards { get; set; }
    public DbSet<MemberNote> MemberNotes { get; set; }
    public DbSet<Membership> Memberships { get; set; }
    public DbSet<Gear> Gears { get; set; }
    public DbSet<Training> Tranings { get; set; }

    public string DbPath { get; }

    public MKBContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "mkb.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AuditLog>()
            .Property(e => e.Timestamp)
            .HasDefaultValue(DateTime.Now);

        modelBuilder.Entity<Member>()
            .Property(e => e.LastUpdateTimestamp)
            .HasDefaultValue(DateTime.Now);
    }
}
