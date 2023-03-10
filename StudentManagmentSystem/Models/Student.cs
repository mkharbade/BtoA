using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagmentSystem.Models
{
    public class Student 
    {
        //Student Information

        [Key]
        public int StudentId { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string? Uid { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string FirstName { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string MiddleName { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string LastName { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string StudentMobile { get; set; } = "";

        [Required]
        [EmailAddress]
        [Column(TypeName = "nvarchar(50)")]
        public string EmailId { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string AbcId { get; set; } = "";

        //Personal Information

        [Column(TypeName = "nvarchar(10)")]
        public string Gender { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string MaritialStatus { get; set; } = "";

        [Column(TypeName = "nvarchar(25)")]
        public string DateOfBirth { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public string IdType { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public string IdNumber { get; set; } = "";

        //Parent Contact Details

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string FatherName { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public string FatherMobile { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string FatherEmail { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string MotherName { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public string MotherMobile { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string MotherEmail { get; set; } = "";

        //Address Details

        [Column(TypeName = "nvarchar(50)")]
        public string AddressLine1 { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string AddressLine2 { get; set; } = "";

        [Column(TypeName = "nvarchar(25)")]
        public string Country { get; set; } = "";

        [Column(TypeName = "nvarchar(30)")]
        public string State { get; set; } = "";

        [Column(TypeName = "nvarchar(30)")]
        public string City { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public int PostalCode { get; set; }

        // Course Details

        [Column(TypeName = "nvarchar(50)")]
        public string Cluster { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Department { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Course { get; set; } = "";

        // Other

        [Column(TypeName = "nvarchar(50)")]
        public string Other1 { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Other2 { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Other3 { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Other4 { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Other5 { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Other6 { get; set; } = "";

        // Education Details

        public virtual ICollection<EducationDetails> educationDetails { get; set; }
    }
}
