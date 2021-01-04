using Microsoft.EntityFrameworkCore;

namespace Registrar.Models
{
  public class RegistrarContext : DbContext
  {
    public virtual DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollments> Enrollments { get; set; }

    public RegistrarContext(DbContextOptions options) : base(options) {}
  }
}