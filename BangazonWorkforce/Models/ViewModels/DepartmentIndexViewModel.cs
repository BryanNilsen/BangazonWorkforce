using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWorkforce.Models.ViewModels
{
    public class DepartmentIndexViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public int Budget { get; set; }

        [Display(Name = "Employee Count")]
        public int EmployeeCount { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

    }
}

