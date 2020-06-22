using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XeHonda xeHonda = new XeHonda();
            //xemacdinh.banhxe = 5;
            xeHonda.setBanhXe(5);


            Console.WriteLine("banh xe mac dinh la " + xeHonda.getBanhXe());

           
        }
    }
}
