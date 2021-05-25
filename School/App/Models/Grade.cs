using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class Grade
    {
        public int Id {get; set;}

        public int StudentId {get; set;}

        public string CourseName {get; set;}

        [Column(TypeName = "decimal(5, 2)")]
        public float Value {get; set;}
        public Student Student {get; set;}  
    }
}