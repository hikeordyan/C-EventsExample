using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class Handler_I //Это класс, реагирующий на событие (счет равен 71) записью строки в консоли.
    {
        public void Message()
        {
            //Не забудьте using System 
            //для вывода в консольном приложении
            Console.WriteLine("Handler_I 15!");
        }
    }

    class Handler_II
    {
        public void Message()
        {
            Console.WriteLine("Handler_II 71!");
        }
    }
}
