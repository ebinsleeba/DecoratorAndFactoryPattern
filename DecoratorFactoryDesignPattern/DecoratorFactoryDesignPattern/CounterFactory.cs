using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFactoryDesignPattern
{
    public class CounterFactory
    {
        public Counter GetCounter(int value, string type)
        {
            if (type == "1")
            {
                Console.WriteLine("Lower");
                return new LowerLimit(new Counter(value));
            }
            else if (type == "2")
            {
                Console.WriteLine("Upper");
                return new UpperLimit(new Counter(value));
            }
            else
            {
                Console.WriteLine("Both");
                return new LowerLimit(new UpperLimit(new Counter(value)));
            }
        }
    }
}
