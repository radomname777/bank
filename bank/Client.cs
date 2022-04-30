using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Client : Employe,GuidID
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Work_address { get; set; }
        public string Live_address { get; set; }
        public override string? Postion { get; set; }
        public override int Salary { get; set; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override int Age { get; set; }
        public Credit Credit { get; set; }
        public Client(string name, string surname, int age, string postion, int salary,string workaddres,string liveaddres,Credit credit) 
            : base(name, surname, age, postion, salary)
        {
            Work_address = workaddres;
            Live_address = liveaddres;
            Credit = credit;
        }
        public override string ToString()
        {
            return $"Id: {ID} Name: {Name} Surname: {Surname} Credit: {Credit.Amount} Azn \n"; 
        }

    }
}
