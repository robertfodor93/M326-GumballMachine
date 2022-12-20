using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M326_GumballMachine
{
    public class NoCoinState : IState
    {
        GumballMachine gumballMachine;

        public NoCoinState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Coin has been inserted, please turn the crank to release Gumball");
            gumballMachine.SetState(gumballMachine.GetCoinState());
        }

        public void EjectCoin()
        {
            Console.WriteLine("There is no coin in the Machine");
        }

        public void TurnCrank()
        {
            Console.WriteLine("There is no coin in the Machine");
        }

        public void Dispense()
        {
            Console.WriteLine("There is no coin in the Machine");
        }

        public void Refill()
        {

        }
    }
}
