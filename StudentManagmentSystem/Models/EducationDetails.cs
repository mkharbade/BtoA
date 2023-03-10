using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagmentSystem.Models
{
    public class EducationDetails
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string EducationType { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string College { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string University { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Degree { get; set; } = "";

        [ForeignKey("StudentId")]
        public virtual int StudentId { get; set; }



    }
}
