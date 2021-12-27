using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.UI
{
    class VectorCli
    {
        public void Add()
        {
            Vector v1 = InputVector();
            Vector v2 = InputVector();
            Vector result = v1 + v2;
            Console.WriteLine($"{v1}\n +\n{v2}\n =\n{result}");
        }
        public void Subtract()
        {
            Vector v1 = InputVector();
            Vector v2 = InputVector();
            Vector result = v1 - v2;
            Console.WriteLine($"{v1}\n -\n{v2}\n =\n{result}");
        }
        public void ScalarProduct()
        {
            Vector v1 = InputVector();
            Vector v2 = InputVector();
            double result = v1 * v2;
            Console.WriteLine($"{v1}\n *\n{v2}\n =\n{result}");
        }
        public void ProductOfNumberByVector()
        {
            double number = InputNumber();
            Vector vector = InputVector();
            Vector result = number * vector;
            Console.WriteLine($"{number} * {vector} = {result}");
        }
        public void Equality()
        {
            Vector v1 = InputVector();
            Vector v2 = InputVector();
            bool result = (v1 == v2);
            if (result)
            {
                Console.WriteLine($"{v1} == {v2}");
            }
            else
            {
                Console.WriteLine($"{v1} != {v2}");
            }
        }

        private Vector InputVector()
        {
           var array = new double[3];

            Console.WriteLine("Enter elements of vector.");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"x{i+1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            return new Vector(array);
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
