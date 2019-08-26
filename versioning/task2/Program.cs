using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Выучите описание шаблона Template method(Шаблонный метод). 
//Обратите внимание на применимость шаблона, а также на состав
//его участников и связи отношения между ними.Напишите небольшую 
//программу на языке C#, представляющую собой абстрактную реализацию данного шаблона. 

//Приводится к шаблонным классам(abstract) или интерфейсам
//Создание экземпляра классов наследников или реализаций интерфейсов
//и  использование их как обьектов базового класса после приведения
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseClass> listExemple= new List<BaseClass>(){ new MyClass1 { }, new MyClass2 { } };
            foreach (BaseClass item in listExemple)
            {
                item.Method();
                Console.WriteLine(new string('_',20));
            }
            Console.ReadKey();
        }
    }
}
