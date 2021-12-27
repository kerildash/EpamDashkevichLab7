using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.UI
{
    class PolynomialCli
    {
        public void Add()
        {
            Polynomial p1 = InputPoly();
            Polynomial p2 = InputPoly();
            Polynomial result = p1 + p2;
            Console.WriteLine($"{p1}\n +\n{p2}\n =\n{result}");
        }
        public void Subtract()
        {
            Polynomial p1 = InputPoly();
            Polynomial p2 = InputPoly();
            Polynomial result = p1 - p2;
            Console.WriteLine($"{p1}\n -\n{p2}\n =\n{result}");
        }

        public void Multiply()
        {
            Polynomial p1 = InputPoly();
            Polynomial p2 = InputPoly();
            Polynomial result = p1 * p2;
            Console.WriteLine($"{p1}\n *\n{p2}\n =\n{result}");
        }

        public void Equality()
        {
            Polynomial p1 = InputPoly();
            Polynomial p2 = InputPoly();
            bool result = (p1 == p2);
            if (result)
            {
                Console.WriteLine($"{p1} == {p2}");
            }
            else
            {
                Console.WriteLine($"{p1} != {p2}");
            }
        }

        private Polynomial InputPoly()
        {
            int power;
            double[] coefficients;

            Console.Write("\nEnter power: ");
            power = int.Parse(Console.ReadLine());
            coefficients = new double[power + 1];

            Console.WriteLine("Enter coefficients.");
            for (int i = 0; i <= power; i++)
            {
                Console.Write($"a*x^{i}. a = ");
                coefficients[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            return new Polynomial(power, coefficients);
        }
        private double InputNumber()
        {
            double number;

            Console.Write("Enter number: ");
            number = double.Parse(Console.ReadLine());

            return number;
        }
    }
}
