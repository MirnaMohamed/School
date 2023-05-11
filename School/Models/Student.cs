using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models


{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public int Age { get; set; }
        public int Gpa { get; set; }
    }
}