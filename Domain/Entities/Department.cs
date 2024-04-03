using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Department
    {
        public int Id_D { get; }
        public string Name { get; set; }
        public List<Employee> Employees { get; }
        public List<Room> Rooms { get; }
    }
}
