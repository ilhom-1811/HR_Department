using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Room
    {
        public int Id_R { get; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Employee> Employees { get; }
    }
}
