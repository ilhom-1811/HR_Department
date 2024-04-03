using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HR_Department
    {
        public int Id_HR_D { get; }
        public List<Employee> Employees { get; }
        public List<Department> Departments { get; }
        public List<Room> Rooms { get; }
    }
}
