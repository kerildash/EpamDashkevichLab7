using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.UI
{
    class Menus
    {
        VectorCli vectorCli = new VectorCli();
        PolynomialCli polynomialCli = new PolynomialCli();
        public void Main()
        {
            try
            {
                Console.WriteLine("\n   MENU");
                Console.WriteLine("1. Operations with vectors.");
                Console.WriteLine("2. Operations with polynomials.");
                Console.WriteLine("");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("");
                Console.Write("Choose what to do: ");
                int menuItem = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (menuItem)
                {
                    case 1:
                        Vector();
                        break;
                    case 2:
                        Polynomial();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        Main();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Vector()
        {
            bool isExit = false;
            while (!isExit)
            {
                try
                {
                    Console.WriteLine("\n  MENU");
                    Console.WriteLine("1. Sum of vectors.");
                    Console.WriteLine("2. Vector difference.");                    
                    Console.WriteLine("3. Scalar product of vectors.");
                    Console.WriteLine("");
                    Console.WriteLine("4. Product of number by a vector.");
                    Console.WriteLine("");
                    Console.WriteLine("5. Equality of vectors.");
                    Console.WriteLine("");
                    Console.WriteLine("0. Return to main menu.");
                    Console.WriteLine("");
                    Console.Write("Choose what to do: ");
                    int menuItem = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    switch (menuItem)
                    {
                        case 1:
                            vectorCli.Add();
                            break;
                        case 2:
                            vectorCli.Subtract();
                            break;
                        case 3:
                            vectorCli.ScalarProduct();
                            break;
                        case 4:
                            vectorCli.ProductOfNumberByVector();
                            break;
                        case 5:
                            vectorCli.Equality();
                            break;
                        case 0:
                            isExit = true;
                            break;
                        default:
                            Console.WriteLine("Incorrect input");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Main();
        }
        public void Polynomial()
        {
            bool isExit = false;
            while (!isExit)
            {
                try
                {
                    Console.WriteLine("\n   MENU");
                    Console.WriteLine("1. Sum of polynomials.");
                    Console.WriteLine("2. polynomial difference.");
                    Console.WriteLine("3. Multiplication polynomials.");
                    Console.WriteLine("");
                    Console.WriteLine("4. Equality of polynomials.");
                    Console.WriteLine("");
                    Console.WriteLine("0. Return to main menu.");
                    Console.WriteLine("");
                    Console.Write("Choose what to do: ");
                    int menuItem = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    switch (menuItem)
                    {
                        case 1:
                            polynomialCli.Add();
                            break;
                        case 2:
                            polynomialCli.Subtract();
                            break;
                        case 3:
                            polynomialCli.Multiply();
                            break;
                        case 4:
                            polynomialCli.Equality();
                            break;
                        case 0:
                            isExit = true;
                            break;
                        default:
                            Console.WriteLine("Incorrect input");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Main();
        }
    }
}
