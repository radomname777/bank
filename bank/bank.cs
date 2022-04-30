using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Bank
    {
        private string myVar;

        public string Name
        {
            get { return myVar; }
            set
            {
               while (value.Length < 3)
               {
                    Console.WriteLine("Enter: ");
                    value = Console.ReadLine();
                    Console.Clear();
               }
               myVar = value; 
            }
            
        }
        public int Budget { get; set; }
        public double Profit { get; set; }
        public CEO[] Ceo { get; set; }
        public Worker[] Worker { get; set; }
        public Manager[] Manager { get; set; }
        public Client[] Clients { get; set; }
        
        public Bank()
        {

        }
        public Bank(string name,int budget,CEO[] ceo,Worker[] worker,Manager[] manager,Client[] clients)
        {
            Name = name;
            Budget = budget;
            Ceo = ceo;
            Worker = worker;
            Manager = manager;
            Clients = clients;
            Profit = CalPrifit();
           
        }
        public double CalPrifit()
        {
            double sum=0;
            foreach (var cl in Clients)
            {
                sum += cl.Credit.Payment;
            }
            return sum;
        }
        public void ShowClient(string fullname)
        {
            if (Clients==null)
            {
                Console.WriteLine("No Client");
                return;
            }
            foreach (var item in Clients)
            {
                if (item.Name== fullname)
                {
                    Console.WriteLine(item);
                    return;
                }
            }

            Console.WriteLine("No Client");
        }
        public void ShowAllCredit(string fullname)
        {
            
            if (Clients == null)
            {
                Console.WriteLine("No Client");
                return;
            }

            double sum = 0;

            foreach (var item in Clients)
            {
                sum += item.Credit.Amount;
            }

            Console.WriteLine(sum);

        }


    }
}
