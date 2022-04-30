using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Worker : Employe, GuidID
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public override string? Postion { get; set; }
        public override int Salary { get; set; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override int Age { get; set; }
        public Guid ID { get; set; }
        public Worker(string name, string surname, int age, string postion, int salary,TimeOnly starttime, TimeOnly endtime) : base(name, surname, age, postion, salary)
        {
            StartTime = starttime;
            EndTime = endtime;
        }

    }
}
