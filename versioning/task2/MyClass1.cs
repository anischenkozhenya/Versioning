using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyClass1 : BaseClass
    {
        protected override void Method1()
        {
            Console.WriteLine("Метод1 класса MyClass1");
        }

        protected override void Method2()
        {
            Console.WriteLine("метод2 класса MyClass1");
        }
    }
}
