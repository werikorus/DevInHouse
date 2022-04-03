using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAdministration.Core.Entities
{
    class ActivityClass
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartedActivity { get; private set; }
        public DateTime FinishActivity { get; set; }
        public StatusEnum Status { get; set; }
        public Employee Employee { get; set; }
        public Student  Student  { get; set; }


        public ActivityClass (string name, string description, DateTime startedActivity)
        {
            Name = name;
            Description = description;
            StartedActivity = startedActivity;
            Status = StatusEnum.Active;
        }
    }
}
