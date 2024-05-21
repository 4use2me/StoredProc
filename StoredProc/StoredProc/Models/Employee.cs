using System.ComponentModel.DataAnnotations;

namespace StoredProc.Models
{
    public class Employee
    {
        [Key]
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Salary { get; set; }
    }
}
