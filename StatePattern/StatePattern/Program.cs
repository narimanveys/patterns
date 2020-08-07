using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new GumballMachine(2);
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.GetCandy();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.GetCandy();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.GetCandy();
            Console.ReadKey();
        }
    }
}
