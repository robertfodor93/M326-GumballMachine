using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M326_GumballMachine
{
    public class HasCoinState : IState
    {
        GumballMachine gumballMachine;

        public HasCoinState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("There is already a coin in the Machine");
        }

        public void EjectCoin()
        {
            Console.WriteLine("The coin has been ejected, please remove it from the slot");
            gumballMachine.SetState(gumballMachine.GetNoCoinState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("The crank has been turned, please wait for the Gumball to dispense");
            gumballMachine.SetState(gumballMachine.GetSoldState());
        }

        public void Dispense()
        {
            Console.WriteLine("No Gumball dispensed");
        }

        public void Refill()
        {

        }
    }
}
