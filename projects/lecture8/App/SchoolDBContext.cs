using Microsoft.EntityFrameworkCore;
using System.Reflection;

using App.Entities;
namespace App;

public class SchoolDBContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Education> Educations => Set<Education>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string? exeFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        optionsBuilder.UseSqlite(@$"Data Source = {exeFolder}/School.db"); // This works only on 
    }
}
