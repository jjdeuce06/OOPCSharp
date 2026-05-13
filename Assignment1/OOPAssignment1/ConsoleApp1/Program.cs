using System;
using System.Runtime.InteropServices.Marshalling;
using System.IO;

namespace OOPAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputfileName;
            string outputfileName;
            string errorfileName = "error.txt";
            Console.WriteLine("Enter file name to be read: ");
            inputfileName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(inputfileName) || !File.Exists(inputfileName))
            {
                Console.WriteLine("Please enter a valid file name: ");
                inputfileName = Console.ReadLine();
            }

            Console.WriteLine("Enter output file name: ");
            outputfileName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(outputfileName))
            {
                Console.WriteLine("Please enter a valid output file name: ");
                outputfileName = Console.ReadLine();
            }

            if (File.Exists(outputfileName))
            {
                Console.WriteLine("Output file already exists.");
                Console.Write("Overwrite? (Y/N): ");

                string response = Console.ReadLine();

                if (response.ToUpper() != "Y")
                {
                    Console.WriteLine("Program terminated.");
                    return;
                }

                File.Delete(outputfileName);
            }

            using (StreamReader reader = new StreamReader(inputfileName))
            using (StreamWriter writer = new StreamWriter(outputfileName, true))
            using (StreamWriter errorWriter = new StreamWriter(errorfileName, true))
            {
                string Line;
                while ((Line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(Line);
                    string[] data = Line.Split(' ');
                    Customer customer = new Customer();
                    customer.Setfname(data[0]);
                    customer.Setlname(data[1]);
                    customer.Setoldmeter(data[2]);
                    customer.Setnewmeter(data[3]);
                    float bill = customer.GetBill();
                    int error = customer.GetError();
                    if (error == 0)
                    {
                        customer.DisplayBill();
                        writer.WriteLine(data[1] + ", " + data[0] + " " + bill.ToString("F2"));
                    }
                    else
                    {
                            errorWriter.WriteLine(data[0] + " " + data[1] + " " + data[2] + " " + data[3]);
                    }

                }
          
            }

 
                

            /*if (c1.GetError() == 0)
            {
                c1.DisplayBill();
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();*/
        }
    }
}