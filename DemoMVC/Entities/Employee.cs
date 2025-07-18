using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Position { get; set; }

        public decimal Salary { get; set; }
    }
}
