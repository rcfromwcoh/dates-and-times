using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());

            //Just display the month/date/year
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.Month);
            
            //DateTime myRetirementDay = new DateTime(2024, 10, 6);
            //DateTime today = new DateTime(2016, 8, 30);
            //TimeSpan t = (myRetirementDay - today);
            //double numberOfDays = t.TotalDays;
            //Console.WriteLine(numberOfDays);

            //Console.WriteLine(myRetirementDay.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("05/27/1981");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);


            Console.ReadLine();
        }
    }
}
