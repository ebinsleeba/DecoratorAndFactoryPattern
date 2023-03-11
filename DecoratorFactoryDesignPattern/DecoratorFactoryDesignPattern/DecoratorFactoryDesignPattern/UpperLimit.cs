using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFactoryDesignPattern
{
    public class UpperLimit:Decorator
    {
        public UpperLimit(Counter cc) : base(cc)
        {
        }

        public override void increment()
        {
            if (counter.read_value() < 20)
            {
                counter.increment();
            }
            else
            {
                Console.WriteLine("Upper limit is 20");
            }
        }

        public override void decrement()
        {
            counter.decrement();
        }

        public override int read_value()
        {
            return counter.read_value();
        }
    }
}
