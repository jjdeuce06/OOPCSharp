using System;
using System.Runtime.InteropServices.Marshalling;

namespace OOPAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.setfname("John");
            c1.setlname("Doe");
            c1.Setoldmeter("9500");
            c1.Setnewmeter("200");

            if(c1.GetError() == 0)
            {
                c1.DisplayBill();
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }
    }
}