using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechNovaSolutions.Models
{
    public class DepartmentEmployee
    {
        [Key]
        public int EId { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Only letters and spaces are allowed.")]

        [Column("EmployeName", TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Required]
        [Range(0, 100)]
        public int EmpAge { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Only letters and spaces are allowed.")]

        public string EmpOccupation { get; set; }

        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Only digits are allowed in salary")]
        public decimal  EmpSalary { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters.")]

        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
2
        public string EmpEmail { get; set; }

        public int PhoNo { get; set; }


    }
}
