using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M326_GumballMachine
{
    public class GumballMachineConsole
    {
		public static void Main(string[] args)
		{
			GumballMachine gumballMachine =
				new GumballMachine(10);

			Console.WriteLine(gumballMachine);

			gumballMachine.InsertCoin();
			gumballMachine.TurnCrank();
			gumballMachine.InsertCoin();
			gumballMachine.TurnCrank();

			Console.WriteLine(gumballMachine);

			gumballMachine.InsertCoin();
			gumballMachine.TurnCrank();
			gumballMachine.InsertCoin();
			gumballMachine.TurnCrank();

			Console.WriteLine(gumballMachine);

			gumballMachine.InsertCoin();
			gumballMachine.TurnCrank();
			gumballMachine.InsertCoin();
			gumballMachine.TurnCrank();

			Console.WriteLine(gumballMachine);

			gumballMachine.InsertCoin();
			gumballMachine.TurnCrank();
			gumballMachine.InsertCoin();
			gumballMachine.TurnCrank();

			Console.WriteLine(gumballMachine);

			gumballMachine.InsertCoin();
			gumballMachine.TurnCrank();
			gumballMachine.InsertCoin();
			gumballMachine.TurnCrank();

			Console.WriteLine(gumballMachine);
		}
	}
}
