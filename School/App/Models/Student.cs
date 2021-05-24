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
        public int Id;
        public string FirstName;
        public string LastName;
        public int Age;
        public Classification Classification;
        public List<Grade> Grades;
    }
}