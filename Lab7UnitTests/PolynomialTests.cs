using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab7;
using NUnit.Framework;

namespace Lab7UnitTests
{
    class PolynomialTests
    {
        Polynomial p1;
        Polynomial p2;

        [SetUp]
        public void Setup()
        {
            p1 = new Polynomial(new double[] { 3, 2, 1 });
            p2 = new Polynomial(new double[] { 0, 2, 0, 4 });
        }
        #region + - *
        [Test]
        public void Poly_Plus_Poly_Retuns_Correct_Poly()
        {
            var result = p1 + p2;
            var equal = new Polynomial(new double[] { 3, 4, 1, 4 });
            Assert.AreEqual(equal.Coefficients, result.Coefficients);
            Assert.AreEqual(equal.Power, result.Power);
        }
        [Test]
        public void Poly_Minus_Poly_Retuns_Correct_Poly()
        {
            var result = p1 - p2;
            var equal = new Polynomial(new double[] { 3, 0, 1, -4 });
            Assert.AreEqual(equal.Coefficients, result.Coefficients);
            Assert.AreEqual(equal.Power, result.Power);
        }
        [Test]
        public void Poly_By_Poly_Retuns_Correct_Poly()
        {
            var result = p1 * p2;
            var equal = new Polynomial(new double[] { 0, 6, 4, 14, 8, 4 });
            Assert.AreEqual(equal.Coefficients, result.Coefficients);
            Assert.AreEqual(equal.Power, result.Power);
        }
        #endregion

        #region == !=
        [Test]
        public void Poly_Equals_To_Same_Poly_Returns_True()
        {
            var equal = new Polynomial(new double[] { 3, 2, 1 });
            bool isEqual = (p1 == equal);
            Assert.AreEqual(true, isEqual);
        }
        [Test]
        public void Poly_Equals_To_Not_Same_Poly_Returns_False()
        {
            bool isEqual = (p1 == p2);
            Assert.AreEqual(false, isEqual);
        }
        [Test]
        public void Poly_Equals_To_Not_A_Poly_Returns_False()
        {
            object vector = new Vector();
            bool isEqual = p1 == vector;
            Assert.AreEqual(false, isEqual);
        }

        [Test]
        public void Poly_Not_Equals_To_Same_Poly_Returns_False()
        {
            var equal = new Polynomial(new double[] { 3, 2, 1 });
            bool isEqual = (p1 != equal);
            Assert.AreEqual(false, isEqual);
        }
        [Test]
        public void Poly_Not_Equals_To_Not_Same_Poly_Returns_True()
        {
            bool isEqual = (p1 != p2);
            Assert.AreEqual(true, isEqual);
        }
        [Test]
        public void Poly_Not_Equals_To_Not_A_Poly_Returns_True()
        {
            object vector = new Vector();
            bool isEqual = p1 != vector;
            Assert.AreEqual(true, isEqual);
        }
        #endregion

        [Test]
        public void ToString_Returns_Correct_String()
        {
            string polyAsAtring = "1x^2 + 2x^1 + 3x^0 ";
            Assert.AreEqual(polyAsAtring, p1.ToString());
        }
    }
}
