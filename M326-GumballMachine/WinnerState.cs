using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M326_GumballMachine
{
    public class WinnerState : IState
    {
        GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Gumball has already been dispensed, please wait");
        }

        public void EjectCoin()
        {
            Console.WriteLine("Gumball has already been dispensed, please wait");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Crank has already been turned, please wait for the Gumball to dispense");
        }

        public void Dispense()
        {
            gumballMachine.ReleaseGumball();
            if(gumballMachine.GetCount() == 0)
            {
                Console.WriteLine("Machine is out of Stock");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            } 
            else
            {
                gumballMachine.ReleaseGumball();
                Console.WriteLine("YOU WON! You are getting two gumballs!");
                if(gumballMachine.GetCount() > 0)
                {
                    gumballMachine.SetState(gumballMachine.GetNoCoinState());
                }
                else
                {
                    Console.WriteLine("Machine is out of Stock");
                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
            }
        }

        public void Refill()
        {

        }
    }
}
