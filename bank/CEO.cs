using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class CEO : Employe, GuidID
    {
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override int Age {get; set; }
        public Guid ID { get; set; }
        public override string? Postion { get; set; }
        public override int Salary { get; set; }

        public CEO(string name, string surname, int age,string postion,int salary) : base(name, surname, age,postion,salary)
        {

        }

    }
}
