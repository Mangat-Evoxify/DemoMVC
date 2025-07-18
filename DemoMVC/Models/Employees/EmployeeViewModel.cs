using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class EmployeeViewModel
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Position { get; set; }

        public decimal Salary { get; set; }
    }
}
