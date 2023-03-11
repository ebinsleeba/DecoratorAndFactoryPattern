using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFactoryDesignPattern
{
    public class Counter
    {
        private int value;
        public Counter(int v) { value = v; }
        public Counter(Counter cc) { value = cc.value; }
        virtual public int read_value() { return value; }
        virtual public void increment() { value++; }
        virtual public void decrement()
        {
            value--;
        }
    }
}
