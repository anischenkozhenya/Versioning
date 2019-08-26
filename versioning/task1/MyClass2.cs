using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    /// <summary>
    /// MyClass2 унаследованный от BaseClass
    /// </summary>
    class MyClass2:BaseClass
    {
        /// <summary>
        /// Замещенный метод1
        /// </summary>
        protected new void Method1()
        {
            Console.WriteLine("MyClass2.Method1");
        }
        /// <summary>
        /// Переопределенный метод2
        /// </summary>
        protected sealed override void Method2()
        {
            Console.WriteLine("MyClass2.Method2");
        }
    }
}
