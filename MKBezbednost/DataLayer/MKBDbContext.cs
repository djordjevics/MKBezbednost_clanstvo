using DataLayer.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataLayer;

public class MKBDbContext : DbContext, IMKBDbContext
{
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<MemberCard> MemberCards { get; set; }
    public DbSet<MemberNote> MemberNotes { get; set; }
    public DbSet<Membership> Memberships { get; set; }
    public DbSet<Gear> Gears { get; set; }
    public DbSet<Training> Tranings { get; set; }

    public MKBDbContext(DbContextOptions<MKBDbContext> options)
        : base(options)
    {
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var DbPath = Path.GetFullPath("./mkb.db");

        options.UseSqlite($"Data Source={DbPath}");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Member>()
            .HasKey(e => e.Id);

        modelBuilder.Entity<Member>()
            .HasMany(e => e.MemberCards)
            .WithOne(e => e.Member);

        modelBuilder.Entity<Member>()
            .HasMany(e => e.MemberNotes)
            .WithOne(e => e.Member);

        modelBuilder.Entity<Member>()
            .HasMany(e => e.Memberships)
            .WithOne(e => e.Member);

        modelBuilder.Entity<Member>()
            .HasMany(e => e.Trainings)
            .WithOne(e => e.Member);

        modelBuilder.Entity<Member>()
            .HasOne(e => e.Gear)
            .WithOne(e => e.Member);
    }
}
