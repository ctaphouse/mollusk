using Microsoft.EntityFrameworkCore;
using mollusk.api.Persistence.Entities;

namespace mollusk.api.Persistence;

public class MolluskContext : DbContext
{
    public MolluskContext(DbContextOptions<MolluskContext> options) : base(options)
    {
        
    }

    public DbSet<Student>? Students { get; set; }
    public DbSet<Major>? Majors { get; set; }
    public DbSet<Teacher>? Teachers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}