using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyClass2 : BaseClass
    {
        protected override void Method1()
        {
            Console.WriteLine("Метод1 класса MyClass2");
        }

        protected override void Method2()
        {
            Console.WriteLine("метод2 класса MyClass2");
        }
    }
}
