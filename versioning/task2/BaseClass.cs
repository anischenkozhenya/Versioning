using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    abstract class BaseClass
    {
        protected abstract void Method1();
        protected abstract void Method2();
        public void Method()
        {
            Method1();
            Method2();
        }
    }
}
