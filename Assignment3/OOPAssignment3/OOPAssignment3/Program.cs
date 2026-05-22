using System;
using System.Runtime.InteropServices.Marshalling;
using System.IO;
using OOPAssignment3;
using System.Runtime.Intrinsics.X86;

namespace OOPAssignment3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int decision = 0;
            Polynomial p1 = new Polynomial();
            Polynomial p2 = new Polynomial();
            Polynomial answer = new Polynomial();

            Console.WriteLine("Welcome to the polynomial calculator!");
            Console.WriteLine("Here are the options");
            Console.WriteLine("1. Enter Polynomial 1");
            Console.WriteLine("2. Enter Polynomial 2");
            Console.WriteLine("3. Add Polynomials");
            Console.WriteLine("4. Subtract Polynomials");
            Console.WriteLine("5. End Program");

            while(true)
            {
                Console.WriteLine("Select an option from the menu: ");
                decision = int.Parse(Console.ReadLine());

                switch(decision)
                {
                    case 1:
                        Console.WriteLine("Enter the first polynomial: ");
                        p1 = new Polynomial();
                        p1.ReadPolynomial(Console.ReadLine());
                        Console.WriteLine("Polynomial 1: " + p1.ToString());
                        break;

                    case 2:
                        Console.WriteLine("Enter the second polynomial: ");
                        p2 = new Polynomial();
                        p2.ReadPolynomial(Console.ReadLine());
                        Console.WriteLine("Polynomial 2: " + p2.ToString());
                        break;

                    case 3:
                        if(p1.GetIsError() == false || p2.GetIsError() == false)
                        {
                            Console.WriteLine("One of the polynomials is missing. Please enter both polynomials before performing addition.");
                        }
                        else if (p1.GetError() == 1 || p2.GetError() == 1)
                        {
                            Console.WriteLine("One of the polynomials is invalid. Please enter valid polynomials before performing addition.");
                        }
                        else
                        {
                            answer = new Polynomial();
                            answer.SetC1(p1.GetC1() + p2.GetC1());
                            answer.SetC2(p1.GetC2() + p2.GetC2());
                            answer.SetC3(p1.GetC3() + p2.GetC3());
                            Console.WriteLine("Answer: " + answer.ToString());
                        }
                        break;
                    case 4:
                        if (p1.GetIsError() == false || p2.GetIsError() == false)
                        {
                            Console.WriteLine("One of the polynomials is missing. Please enter both polynomials before performing addition.");
                        }
                        else if (p1.GetError() == 1 || p2.GetError() == 1)
                        {
                            Console.WriteLine("One of the polynomials is invalid. Please enter valid polynomials before performing addition.");
                        }
                        else
                        {
                            answer = p1 - p2;
                            answer.SetPoly();
                            Console.WriteLine("Answer: " + answer.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using the polynomial calculator! Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option from the menu.");
                        break;
                }

                if (decision == 5)
                {
                    break;
                }


            }


        }

    }
}