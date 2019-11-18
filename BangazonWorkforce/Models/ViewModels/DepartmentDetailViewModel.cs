using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWorkforce.Models.ViewModels
{
    public class DepartmentDetailViewModel
    {
        public Department Department { get; set; }
        public int EmployeeCount { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
