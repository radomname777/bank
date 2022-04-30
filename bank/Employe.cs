using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    abstract class Employe : Person
    {
        public abstract string? Postion { get; set; }
        public abstract int Salary { get; set; }
        protected Employe(string name, string surname, int age,string postion,int salary) : base(name, surname, age)
        {
            Postion = postion;
            Salary = salary;
        }
    }
}
