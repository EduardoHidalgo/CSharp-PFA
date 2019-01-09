using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Date = DateTime.Today;
            var DaysInMonth = DateTime.DaysInMonth(Date.Year, Date.Month);
            var lastDay = new DateTime(Date.Year, Date.Month, DaysInMonth);
            Date = lastDay;
            Console.WriteLine("ultimo dia de este mes:" + Date);
            Date = Date.AddMonths(1);
            Console.WriteLine("ultimo dia del siguiente mes:" + Date);
            DaysInMonth = DateTime.DaysInMonth(Date.Year, Date.Month);
            lastDay = new DateTime(Date.Year, Date.Month, DaysInMonth);
            Date = lastDay;
            Console.WriteLine("ultimo dia del siguiente mes:" + Date);


            Console.ReadLine();
        }
    }
}
