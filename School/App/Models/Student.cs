using System.Collections.Generic;

namespace App.Models
{
    public enum Classification {
        Freshman,
        Sophmore,
        Junior,
        Senior
    }
    public class Student
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public int Age {get; set;}
        public Classification Classification {get; set;}
        public List<Grade> Grades {get; set;}
    }
}