using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OOPAssignment1
{
    internal class Customer
    {
        private string fname;
        private string lname;
        private float oldmeter;
        private float newmeter;
        private int error;

        public Customer()
        {
            oldmeter = 0;
            newmeter = 0;
            error = 0;
        }


        public static void Setlname(string temp1)
        {
            if (temp1.Length > 0)
            {
                lname = temp1;
            }
            else
            {
                lname = temp1;
                error = 1;
            }
        }

        public static void Setfname(string temp2)
        {
            if (temp2.Length > 0)
            {
                fname = temp2;
            }
            else
            {
                fname = temp2;
                error = 1;
            }
        }

        public static void Setoldmeter(string temp3)
        {
            if(temp3.Length > 0)
            {
                if (float.TryParse(temp3, out float result))
                {
                    oldmeter = result;
                }
                else
                {
                    oldmeter = 0;
                    error = 1;
                }
                if(oldmeter > 9999 || oldmeter <0)
                {
                    error = 1;
                }
            }
            else
            {
                oldmeter = 0;
                error = 1;
            }
        }

        public static void Setnewmeter(string temp4)
        {
            if (temp4.Length > 0)
            {
                if (float.TryParse(temp4, out float result))
                {
                    newmeter = result;
                }
                else
                {
                    newmeter = 0;
                    error = 1;
                }
                if (newmeter > 9999 || newmeter < 0)
                {
                    error = 1;
                }
            }
            else
            {
                newmeter = 0;
                error = 1;
            }
        }

        public static int GetError()
        {
            return error;
        }

        public static float GetBill()
        {
            if (newmeter >= oldmeter)
            {
                return (newmeter - oldmeter) * 0.20f;
            }
            else if (newmeter < oldmeter)
            {
                return ((10000-oldmeter) + newmeter) * 0.20f;
            }
            return 0;
        }

        public static void DisplayBill()
        {
            Console.WriteLine($"Customer name: {fname} {lname}");
            Console.WriteLine($"Old meter reading: {oldmeter}");
            Console.WriteLine($"New meter reading: {newmeter}");
            Console.WriteLine($"Total bill: {GetBill()}");
        }

    }
}