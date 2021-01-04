namespace Registrar.Models
{
  public class Enrollments
  {
    public int EnrollmentsId { get; set; } //Plural or singular?
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
  }
}