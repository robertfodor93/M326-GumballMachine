using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M326_GumballMachine
{
    public interface IState
    {
        void InsertCoin();
        void EjectCoin();
        void TurnCrank();
        void Dispense();
        void Refill();
    }
}
