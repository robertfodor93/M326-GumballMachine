using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M326_GumballMachine
{
    public class GumballMachine
    {
        private IState hasCoinState;
        private IState noCoinState;
        private IState soldState;
        private IState soldOutState;
        private IState winnerState;

        private IState state;
        int count = 0;

        public GumballMachine(int gumballStock)
        {
            hasCoinState = new HasCoinState(this);
            noCoinState = new NoCoinState(this);
            soldState = new SoldState(this);
            soldOutState = new SoldOutState(this);
            winnerState = new WinnerState(this);
            this.count = gumballStock;

            if(gumballStock > 0)
            {
                state = noCoinState;
            }
            else
            {
                state = soldState;
            }
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public IState GetState()
        {
            return this.state;
        }

        public IState GetCoinState()
        {
            return this.hasCoinState;
        }

        public IState GetNoCoinState()
        {
            return this.noCoinState;
        }

        public IState GetSoldState()
        {
            return this.soldState;
        }

        public IState GetWinnerState()
        {
            return this.winnerState;
        }

        public int GetCount()
        {
            return count;
        }

        public IState GetSoldOutState()
        {
            return this.soldOutState;
        }

        public void InsertCoin()
        {
            state.InsertCoin();
        }

        public void ejectCoin()
        {
            state.EjectCoin();
        }
        
        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void ReleaseGumball()
        {
            Console.WriteLine("A gumball has been dispensed, please wait..");
            if(count != 0)
            {
                count = count - 1;
            }
        }

        public void Refill(int count)
        {
            this.count += count;
            Console.WriteLine("The Gumball Machine has been refilled, the new stock is:" + this.count);
            state.Refill();
        }
    }
}
