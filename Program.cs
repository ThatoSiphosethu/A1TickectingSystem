using System;

namespace stringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = DateTime.Now;

            Console.WriteLine($"1.{day.ToString("MMMM dd,yyyy")}");

            Console.WriteLine($"2.{day.ToString("yyyy.MM.dd")}");

            Console.WriteLine($"3.Day{day.ToString(" dd")} of {day.ToString("MMMM,yyyy")}");

            Console.WriteLine($"4.Year:{day.ToString("yyyy")}, Month:{day.ToString("MM")}, Day:{day.ToString("dd")}");

            Console.WriteLine($"5.{day.ToString("dddd"),10}");

            Console.WriteLine($"6.{day.ToString("hh:mm tttt")}{day.ToString("dddd"),10}");

            Console.WriteLine($"7.h:{day.ToString("hh")}, m:{day.ToString("mm")}, s:{day.ToString("ss")}");

            Console.WriteLine($"8.{day.ToString("yyyy.MM.dd.hh.mm.ss")}");

            double pi = 3.1415;
            Console.WriteLine("{0:C}", pi);
            Console.WriteLine("{0:n3}", pi);



            
           
        }
    }
}
