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
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Only letters and spaces are allowed.")]
        [Column("EmployeName", TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Required]
        [Range(0, 100)]
        public int EmployeAge { get; set; }

        [Required]
        public string EmpOccupation { get; set; }

        [Required]
        public decimal  EmpSalary { get; set; } 

    }
}
