using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace NETCore3WebApp.Domain
{
    [Table("Entity")]
    public class Entity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
    }

    [Table("Student")]
    public class Student
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        
        [Column("FirstMidName")]
        public string FirstMidName { get; set; }

        [Column("EnrollmentDate")]
        public DateTime EnrollmentDate { get; set; }
        
        public IEnumerable<Enrollment> Enrollments { get; set; }
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }
    }

    [Table("Course")]
    public class Course
    {
        [Key]
        [Column("CourseID")]
        public int CourseId { get; set; }
        [Column("Title")]
        public string Title { get; set; }
        [Column("Credits")]
        public int Credits { get; set; }

        public IEnumerable<Enrollment> Enrollments { get; set; }

        public Course()
        {
            Enrollments = new List<Enrollment>();
        }
    }

    [Table("Enrollment")]
    public class Enrollment
    {
        [Key]
        [Column("EnrollmentID")]
        public int EnrollmentID { get; set; }
        [Column("CourseID")]
        public int CourseID { get; set; }
        public Course Course { get; set; }
        [Column("StudentID")]
        public int StudentID { get; set; }
        public Student Student { get; set; }
        [Column("Grade")]
        public int Grade { get; set; }
    }
}
