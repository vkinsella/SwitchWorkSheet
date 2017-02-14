using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch pracital  question 1

            Console.Write("Enter the day of the week : ");
            int dayNum = int.Parse(Console.ReadLine());

            string dayName;

            switch (dayNum)
            {
                case 1:  // daynum is eual to the value 1
                    dayName = "Monday";  // note that i am not writing out the dayname here, best to keep things seperate
                    break;
                case 2: 
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "error";
                    break;
            }

            Console.WriteLine("The day is {0}", dayName);
        }
    }
}
