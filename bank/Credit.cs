using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Credit : GuidID
    {
        public int Amount { get; set; }
        public int Percent { get; set; }
        public int Months { get; set; }
        public double Payment { get; set; }
        public Guid ID { get; set; } = Guid.NewGuid();
        public Credit() { }
        public Credit(int amount, int percent, int months)
        {
            Amount = amount;
            Percent = percent;
            Months = months;
            Payment = Calculate(amount, percent);
        }

        public double Calculate(int amount,double percent)
        {
            double var = 0;
            var = (amount * amount) / 100;
            return (var+ amount)/Months;
        }


        public override string ToString()
            => $"ID : {ID} Amount : {Amount} Month: {Months} Payment: {Payment}";
    }
}
