using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapisyZHodin
{
    internal class Program
    {
        static void WriteNumber(int number)
        {
            Console.WriteLine(number);

            if (number <= 1000)
            {
                WriteNumber(number + 1);

            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
               Console.WriteLine(i);
            }
            WriteNumber(999);
            Console.ReadKey();
        }
    }
}
