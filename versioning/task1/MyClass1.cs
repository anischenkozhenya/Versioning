using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{/// <summary>
/// MyClass1 унаследованный от BaseClass
/// </summary>
    class MyClass1:BaseClass
    {
        /// <summary>
        /// Переопределенный метод1
        /// </summary>
        protected sealed override void Method1()
        {
            Console.WriteLine("MyClass1.Method1");
        }
        /// <summary>
        /// Переопределенный метод2
        /// </summary>
        protected sealed override void Method2()
        {
            Console.WriteLine("MyClass1.Method2");
        }
    }
}
