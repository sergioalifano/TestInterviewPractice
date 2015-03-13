using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine(Year.IsLeap(20));

        Console.ReadKey();
    }
}

//The tricky thing here is that a leap year occurs:
//on every year that is evenly divisible by 4
//  except every year that is evenly divisible by 100
//    unless the year is also evenly divisible by 400
class Year
{
    public static bool IsLeap(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0 && (year % 400==0))
            {
                return true;
            }
            if (year % 100 == 0)
            {
                return false;
            }
            else return true;
        }

        return false; // Replace this
    }
}

