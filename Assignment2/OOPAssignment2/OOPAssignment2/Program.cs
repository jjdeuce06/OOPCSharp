using System;
using System.Runtime.InteropServices.Marshalling;
using System.IO;
using OOPAssignment2;
using System.Runtime.Intrinsics.X86;

namespace OOPAssignment2
{
    internal class Program
    {
        static float INVALID = -1000;
        static void Main(string[] args)
        {

            string inputFileName;
            string outputFileName;
            string errorFileName = "error.txt";
            Console.WriteLine("Eneter a file name to be read: ");
            inputFileName = Console.ReadLine();
            string temp1, temp2, temp3, temp4;

            while (string.IsNullOrWhiteSpace(inputFileName) || !File.Exists(inputFileName))
            {
                Console.WriteLine("Please enter a valid file name: ");
                inputFileName = Console.ReadLine();
            }

            Console.WriteLine("Enter output file name: ");
            outputFileName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(outputFileName))
            {
                Console.WriteLine("Please enter a valid output file name: ");
                outputFileName = Console.ReadLine();
            }

            if (File.Exists(outputFileName))
            {
                Console.WriteLine("Output file already exists.");
                Console.Write("Overwrite? (Y/N): ");

                string response = Console.ReadLine();

                if (response.ToUpper() != "Y")
                {
                    Console.WriteLine("Program terminated.");
                    return;
                }

                File.Delete(outputFileName);
            }

            using (StreamReader reader = new StreamReader(inputFileName))
            using (StreamWriter writer = new StreamWriter(outputFileName, true))
            using (StreamWriter errorWriter = new StreamWriter(errorFileName, true))
            {
                while ((temp1 = reader.ReadLine()) != null)
                {
                    temp2 = reader.ReadLine();
                    temp3 = reader.ReadLine();
                    temp4 = reader.ReadLine();

                    Employee employee1 = new Employee();

                    if (CheckString(temp1))
                    {
                        employee1.SetFName(temp1);
                    }

                    else
                    {
                        employee1.SetError(1);
                    }

                    if (CheckString(temp2))
                    {
                        employee1.SetLName(temp2);
                    }
                    else
                    {
                        employee1.SetError(1);
                    }

                    if (CheckRate(temp3) != INVALID)
                    {
                        employee1.SetHourlyRate(CheckRate(temp3));

                    }
                    else
                    {
                        employee1.SetError(1);
                    }

                    if (CheckHours(temp4) != INVALID)
                    {
                        employee1.SetHoursWorked(CheckHours(temp4));
                    }
                    else
                    {
                        employee1.SetError(1);
                    }

                    employee1.SetGrossPay(employee1.GetHourlyRate(), employee1.GetHoursWorked());
                    employee1.DisplayEmployee();

                    int error = employee1.GetError();
                    if (error == 0)
                    {
                        employee1.DisplayEmployee();
                        writer.WriteLine(temp1 + ", " + temp2 + " " + employee1.GetGrossPay().ToString("F2"));
                    }
                    else
                    {
                        errorWriter.WriteLine(temp1 + " " + temp2 + " " + temp3 + " " + temp4);
                    }
                }
            }

        }


        public static bool CheckString(string temp1)
        {
            if (temp1.Length > 0)
            {
                if (temp1.IndexOf(" ") == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static float CheckRate(string temp3)
        {
            if (temp3.All(c => "0123456789.".Contains(c)))
            {
                int dec = 0;
                for (int i = 0; i < temp3.Length; i++)
                {
                    if (temp3[i] == '.')
                    {
                        dec++;
                    }
                }
                if (dec == 1)
                {
                    float rate = float.Parse(temp3);
                    if (rate >= 8.25)
                    {
                        return rate;
                    }
                    else
                    {
                        return INVALID;
                    }
                }
            }
            else
            {
                return INVALID;
            }

            return INVALID;
        }

        public static float CheckHours(string temp4)
        {
            if (temp4.All(c => "0123456789.".Contains(c)))
            {
                int dec = 0;
                for (int i = 0; i < temp4.Length; i++)
                {
                    if (temp4[i] == '.')
                    {
                        dec++;
                    }
                }
                if (dec == 1)
                {
                    float hours = float.Parse(temp4);
                    if (hours >= 0)
                    {
                        return hours;
                    }
                    else
                    {
                        return INVALID;
                    }
                }
            }
            else
            {
                return INVALID;
            }

            return INVALID;
        }
    }
}