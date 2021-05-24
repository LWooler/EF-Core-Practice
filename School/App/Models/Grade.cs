using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class Grade
    {
        public int Id;

        public int StudentId;

        public string CourseName;

        [Column(TypeName = "decimal(5, 2)")]
        public float Value;
    }
}