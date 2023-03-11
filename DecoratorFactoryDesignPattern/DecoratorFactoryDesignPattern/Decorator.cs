using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFactoryDesignPattern
{
    public class Decorator:Counter
    {
        protected Counter counter;

        public Decorator(Counter c):base(c)
        {
            counter = c;
        }
    }
}
