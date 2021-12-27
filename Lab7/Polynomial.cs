using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Polynomial
    {
        private double[] _Coefficients;
        private int _Power;
        public int Power
        {
            get
            {
                return _Power;
            }
        }
        public double[] Coefficients
        {
            get
            {
                return _Coefficients;
            }
        }

        public Polynomial(double[] coefficients)
        {
            _Coefficients = coefficients;
            _Power = _Coefficients.Length - 1;
        }

        public Polynomial(int power, double[] coefficients)
        {
            _Power = power;
            if (power < coefficients.Length - 1)
            {
                throw new ArgumentException();
            }
            _Coefficients = new double[power + 1];
            for(int i = 0; i < coefficients.Length; i++)
            {
                _Coefficients[i] = coefficients[i];
            }
        }
        public double this[int index]
        {
            get
            {
                if (index < 0 || index > this.Power)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return Coefficients[index];
            }
            set
            {
                if (index < 0 || index > this.Power)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Coefficients[index] = value;
            }
        }

        #region + - *
        static public Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            if (p1.Power > p2.Power)
            {
                p2 = new Polynomial(p1.Power, p2.Coefficients);
            }
            else
            {
                p1 = new Polynomial(p2.Power, p1.Coefficients);
            }
            int power = p1.Power;
            double[] result = new double[power + 1];
            for (int i = 0; i <= power; i++)
            {
                result[i] = p1[i] + p2[i];
            }
            return new Polynomial(result);
        }
        static public Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            if (p1.Power > p2.Power)
            {
                p2 = new Polynomial(p1.Power, p2.Coefficients);
            }
            else
            {
                p1 = new Polynomial(p2.Power, p1.Coefficients);
            }
            int power = p1.Power;
            double[] result = new double[power + 1];
            for (int i = 0; i <= power; i++)
            {
                result[i] = p1[i] - p2[i];
            }
            return new Polynomial(result);
        }
        static public Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            int power = p1.Power + p2.Power;
            double[] result = new double[power + 1];
            for(int i = 0; i <= p1.Power; i++)
            {
                for(int j = 0; j <= p2.Power; j++)
                {
                    int k = i + j;
                    result[k] += p1[i] * p2[j];
                }
            }
            return new Polynomial(result);
        }
        #endregion

        #region == !=
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Polynomial poly = (Polynomial)obj;
            if (this.Power != poly.Power)
            {
                return false;
            }
            for(int i = 0; i <= Power; i++)
            {
                if (this[i] != poly[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator ==(Polynomial p1, Polynomial p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Polynomial p1, Polynomial p2)
        {
            return !p1.Equals(p2);
        }

        #endregion
        public override string ToString()
        {
            string polynomial = "";
            for (int i = this.Power; i >= 0 ; i--)
            {
                if (i == this.Power || this[i] < 0)
                {
                    polynomial += this[i] + "x^" + i + " ";
                }
                else
                {
                    polynomial += "+ " + this[i] + "x^" + i + " ";
                }
            }
            return polynomial;
        }
    }
}
