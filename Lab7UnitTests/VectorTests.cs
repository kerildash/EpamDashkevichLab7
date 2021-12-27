using NUnit.Framework;
using Lab7;
using System;

namespace Lab7UnitTests
{
    public class VectorTests
    {
        Vector vector;
        Vector anotherVector;

        [SetUp]
        public void Setup()
        {
            vector = new Vector(2, 3, 5);
            anotherVector = new Vector(6, -6, 6);
        }

        [Test]
        public void Indexer_Returns_Correct_Element_Of_Vector()
        {
            Assert.AreEqual(3, vector[1]);
        }

        [Test]
        public void Vector_Plus_Vector_Returns_Correct_Vector()
        {
            var result = new Vector();

            result = vector + anotherVector;

            Assert.AreEqual(8, result[0]);
            Assert.AreEqual(-3, result[1]);
            Assert.AreEqual(11, result[2]);
        }
        [Test]
        public void Vector_Minus_Vector_Returns_Correct_Vector()
        {
            var result = new Vector();

            result = vector - anotherVector;

            Assert.AreEqual(-4, result[0]);
            Assert.AreEqual(9, result[1]);
            Assert.AreEqual(-1, result[2]);
        }

        [Test]
        public void Scalar_Product_Of_Vectors_Returns_Correct_Scalar()
        {
            double product = 0;

            product = vector * anotherVector;

            Assert.AreEqual(24, product);
        }

        [Test]
        public void Product_Of_Scalar_And_Vector_Returns_Correct_Vector()
        {
            var result = new Vector();

            result = 2 * vector;

            Assert.AreEqual(4, result[0]);
            Assert.AreEqual(6, result[1]);
            Assert.AreEqual(10, result[2]);
        }

        [Test]
        public void Product_Of_Vector_And_Scalar_Returns_Correct_Vector()
        {
            var result = new Vector();

            result = vector * 2;

            Assert.AreEqual(4, result[0]);
            Assert.AreEqual(6, result[1]);
            Assert.AreEqual(10, result[2]);
        }
        [Test]
        public void ToString_Returns_Correct_String()
        {
            Assert.AreEqual("{ 2, 3, 5 }", vector.ToString());
        }
        [Test]
        public void Incorrect_Indexer_Throws_Exception()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => vector[5].ToString());
        }

        #region == !=
        [Test]
        public void Vector_Equals_To_Same_Vector_Returns_True()
        {
            var equal = new Vector(2, 3, 5);
            bool isEqual = (vector == equal);
            Assert.AreEqual(true, isEqual);
        }
        [Test]
        public void Vector_Equals_To_Not_Same_Vector_Returns_False()
        {
            bool isEqual = (vector == anotherVector);
            Assert.AreEqual(false, isEqual);
        }
        [Test]
        public void Vector_Equals_To_Not_A_Vector_Returns_False()
        {
            object poly = new Polynomial(new double[] { 2, 3, 5 });
            bool isEqual = (vector == anotherVector);
            Assert.AreEqual(false, isEqual);
        }
        [Test]
        public void Vector_Not_Equals_To_Same_Vector_Returns_False()
        {
            var equal = new Vector(2, 3, 5);
            bool isEqual = (vector != equal);
            Assert.AreEqual(false, isEqual);
        }
        [Test]
        public void Vector_Not_Equals_To_Not_Same_Vector_Returns_True()
        {
            bool isEqual = (vector != anotherVector);
            Assert.AreEqual(true, isEqual);
        }
        [Test]
        public void Vector_Not_Equals_To_Not_A_Vector_Returns_True()
        {
            object poly = new Polynomial(new double[] { 2, 3, 5 });
            bool isEqual = (vector != anotherVector);
            Assert.AreEqual(true, isEqual);
        }
        #endregion
    }
}