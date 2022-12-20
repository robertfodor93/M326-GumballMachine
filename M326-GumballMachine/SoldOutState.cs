using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M326_GumballMachine
{
    public class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Machine is out of stock, please try again later");
        }

        public void EjectCoin()
        {
            Console.WriteLine("No coin in the Machine");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Machine is out of stock, please try again later");
        }

        public void Dispense()
        {
            Console.WriteLine("No Gumball dispensed");
        }

        public void Refill()
        {
            gumballMachine.SetState(gumballMachine.GetNoCoinState());
        }
    }
}
