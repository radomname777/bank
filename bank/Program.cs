using System;

namespace bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeOnly a1 = new TimeOnly();
            CEO[] ceo = new CEO[] { new CEO("XXXX", "XXXX", 50, "XXXX", 200000) };

            Worker[] worker = new Worker[] { new Worker("XXXX", "XXXX", 20, "XXXX", 200, a1, a1) };
            Manager[] manager = new Manager[] { new Manager("XXXX", "XXXX", 30, "XXXX", 2000) };
            Credit a3 = new Credit(2000, 11, 12);
            Client[] cl = new Client[] { new Client("Nihad", "XXXX", 20, "XXXX", 800, "XXXX", "XXXX", a3)};

            Bank bank = new Bank("Bank of Baku",200,ceo,worker,manager,cl);
            bank.ShowClient("Nihad");
        }
    }
}