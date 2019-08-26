using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class BaseClass
    {
        /// <summary>
        /// Открытый метод BaseClass
        /// </summary>
        public void Method()
        {
            Method1();
            Method2();
        }

        /// <summary>
        /// Защищенный метод №1 BaseClass
        /// </summary>
        protected virtual void Method1()
        {
            Console.WriteLine("BaseClass.Method1");
        }
        /// <summary>
        /// Защищенный метод №1 BaseClass
        /// </summary>
        protected virtual void Method2()
        {
            Console.WriteLine("BaseClass.Method2");
        }
    }
}
