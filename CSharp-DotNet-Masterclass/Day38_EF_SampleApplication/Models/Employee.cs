using System.ComponentModel.DataAnnotations;

namespace Day38_EF_SampleApplication.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }


        [MaxLength(20)]
        public string LastName { get; set; }    

        public string Email { get; set; }

        public decimal Salary { get; set; }

        public bool IsActive { get; set; }
    }
}
