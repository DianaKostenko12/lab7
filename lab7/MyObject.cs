using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public abstract class MyObject
    {
        public abstract string GetInfo();

        public void ShowPopupInfo()
        {
            Console.WriteLine("Спливаюче повідомлення:" + GetInfo());
        }

        public void PrintInfoToConsole()
        {
            Console.WriteLine("Інформація про об'єкт: " + GetInfo());
        }
    }
}
