using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFactoryDesignPattern
{
    public class LowerLimit:Decorator
    {
        public LowerLimit(Counter cc) : base(cc)
        {
        }

        public override void decrement()
        {
            if (counter.read_value() >0)
            {
                counter.decrement();
            }
            else
            {
                Console.WriteLine("Too Low Value");
            }
        }

        public override void increment()
        {
            counter.increment();
        }

        public override int read_value()
        {
            return counter.read_value();
        }
    }
}
