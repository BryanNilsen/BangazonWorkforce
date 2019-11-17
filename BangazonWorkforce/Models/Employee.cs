using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWorkforce.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Is Supervisor")]
        public bool IsSupervisor { get; set; }
        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public Computer? Computer { get; set; }

    }
}
