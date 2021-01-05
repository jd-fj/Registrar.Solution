using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;

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
    // public string EnrollDate { get; set; }
    [DisplayName("Add EnrollDate")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
    public DateTime EnrollDate { get; set; }
    public ICollection<Enrollments> Courses { get; }
  }
}