using System;

namespace Advanced_Database_and_ORM_Concepts.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
