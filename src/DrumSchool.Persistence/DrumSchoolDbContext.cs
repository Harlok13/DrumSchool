using Microsoft.EntityFrameworkCore;

namespace DrumSchool.Persistence;

/// <summary>
/// Контекст базы данных школы барабанов.
/// </summary>
public class DrumSchoolDbContext : DbContext
{
    /// <summary>
    /// Контекст базы данных школы барабанов.
    /// </summary>
    public DrumSchoolDbContext() { }
    
    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DrumSchoolDbContext).Assembly);
    }
}