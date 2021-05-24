using System.Collections.Generic;

namespace App.Models
{
    enum Classification {
        Freshman,
        Sophmore,
        Junior,
        Senior
    }
    public class Student
    {
        int id;
        string FirstName;
        string LastName;
        int Age;
        Classification Classification;
        List<Grade> Grades;
    }
}