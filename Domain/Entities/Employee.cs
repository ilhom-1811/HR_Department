using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee
    {
        public int Id_E{ get; }
        public string Name { get; set; }
        public Department CurrentDepartment { get; set; }
        public List<PastPosition> PastPositions { get; }
        public Room CurrentRoom { get; set; }
    }
}
