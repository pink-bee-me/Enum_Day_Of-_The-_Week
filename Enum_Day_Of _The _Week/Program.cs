using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Day_Of__The__Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day are you planning on going to the beach?");
            string value = Console.ReadLine();

            Enum_DayOfWeek day;
            try
            {
                day = (Enum_DayOfWeek)Enum.Parse(typeof(Enum_DayOfWeek), value);
            }
            catch (Exception)
            {
                
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
