using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class ClassCounter  //Это класс - в котором производится счет.
    {
        public delegate void MethodContainer();
        public delegate void MethodContainer2();

        public event MethodContainer onCount71;
        public event MethodContainer2 onCount15;
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 15)
                    onCount15();


                if (i == 71)
                    onCount71();
                System.Threading.Thread.Sleep(100);
                Console.WriteLine(  i);

            }
        }
    }
}
