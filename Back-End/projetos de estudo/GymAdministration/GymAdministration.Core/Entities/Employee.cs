using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAdministration.Core.Entities
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishDate { get; set; }
        public StatusEnum Status { get; set; }

        
        public Employee(string name)
        {
            Name = name;
            Status = StatusEnum.Active;
        }
    }
}
