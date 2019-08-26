using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Реализуйте шаблон NVI в собственной иерархии наследования.

/// <summary>
/// 1.Открытый метод определен в базовом классе
/// и вызывает защищенные методы
/// 2.Переопределенные защищенные методы 
/// в классах-наследниках переопределяют 
/// реализацию их в отрытом методе
/// 3.Открытый метод ничего не знает о замещенном методе
/// поэтому реализуется как в базовом
/// </summary>

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass1 = new MyClass1();
            var myClass2 = new MyClass2();
            Console.WriteLine("myClass1 До приведения к базовому");
            myClass1.Method();
            Console.WriteLine(new string('_', 20));
            BaseClass baseClass = myClass1;
            Console.WriteLine("myClass1 после приведения к базовому");
            baseClass.Method();
            Console.WriteLine(new string('_', 20));
            Console.WriteLine("myClass2 До приведения к базовому");
            myClass2.Method();
            Console.WriteLine(new string('_', 20));
            baseClass = myClass2;
            Console.WriteLine("myClass2 после приведения к базовому");
            baseClass.Method();
            Console.WriteLine(new string('_', 20));
            Console.ReadKey();
        }
    }
}
