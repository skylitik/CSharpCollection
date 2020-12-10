using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MonthOfYear =
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            Console.WriteLine("Which month do you want to display?");
            Console.WriteLine("January = 1, February = 2, and etc. :");
            int month = int.Parse(Console.ReadLine());
            string chooseMonth = MonthOfYear[month - 1];

            Console.WriteLine($"You choose {chooseMonth}");
        }
    }
}
