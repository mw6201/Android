using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tag = new DateTime(2012, 7, 13);

            Console.WriteLine("Start at: " + DateTime.Now.ToString());

            while (true)
            {
                tag = tag.AddDays(7);

                if (tag.Day == 13 & tag.DayOfWeek == DayOfWeek.Friday)
                {
                    Console.WriteLine("Der nächste Freitag der 13 ist am " + tag.ToString());

                    break;
                }
            }

            Console.WriteLine("End at: " + DateTime.Now.ToString());

            Console.ReadKey();

        }
    }
}
