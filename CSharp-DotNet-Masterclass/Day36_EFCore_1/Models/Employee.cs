using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day36_EFCore_1.Models
{
    [Table("Employees")]
    public class Employee
    {
        // Attributes 
        // Help to define database rules in model c# class
        // 1. Table - tells EF which table class represents 
        // 2. Column : if property name is different fromm database column
        // 3. key : to define which is primary key
        // 4. Data Validation Enforce :
        // [Required] required property always
        // [MaxLength] maximum lenght accpet
        // [NotMapped] will be excluding in dataabase mapping
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column(TypeName ="decimal(5,2)")]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }

        [NotMapped]
        public string MobileNumber { get; set; }
    }
}
