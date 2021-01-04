using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<Enrollments>();
    }

    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string EnrollDate { get; set; }
    public ICollection<Enrollments> Courses { get; }
  }
}