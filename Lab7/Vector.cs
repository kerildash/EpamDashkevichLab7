using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Vector
    {
        private double[] _Entries = new double[3];
        public double this[int index]
        {
            get
            {
                if (index < 0 || index > 2){
                    throw new ArgumentOutOfRangeException();
                }
                return _Entries[index];
            }
            set
            {
                if (index < 0 || index > 2)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _Entries[index] = value;
            }
        }

        public Vector()
        {
            for (int i = 0; i < 3; i++)
            {
                _Entries[i] = 0;
            }
        }
        public Vector(double x1, double x2, double x3)
        {
            _Entries[0] = x1;
            _Entries[1] = x2;
            _Entries[2] = x3;
        }
        public Vector(double[] v)
        {
            if (v.Length != 3)
            {
                throw new ArgumentException();
            }
            _Entries = v;
        }

        #region 2 vectors
        public static Vector operator +(Vector a, Vector b)
        {
            Vector sum = new Vector();
            for (int i = 0; i < 3; i++)
            {
                sum[i] = a[i] + b[i];
            }
            return sum;
        }
        public static Vector operator -(Vector a, Vector b)
        {
            Vector diff = new Vector();
            for (int i = 0; i < 3; i++)
            {
                diff[i] = a[i] - b[i];
            }
            return diff;
        }
        //scalar product
        public static double operator *(Vector a, Vector b)
        {
            double prod = 0;
            for (int i = 0; i < 3; i++)
            {
                prod += a[i] * b[i];
            }
            return prod;
        }
        #endregion

        #region scalar and vector
        public static Vector operator *(double a, Vector b)
        {
            Vector prod = new Vector();
            for (int i = 0; i < 3; i++)
            {
                prod[i] = a * b[i];
            }
            return prod;
        }
        
        public static Vector operator *(Vector a, double b)
        {
            Vector prod = new Vector();
            for (int i = 0; i < 3; i++)
            {
                prod[i] = a[i] * b;
            }
            return prod;
        }
        #endregion
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Vector vector = (Vector)obj;
            for (int i = 0; i <= 2; i++)
            {
                if (this[i] != vector[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return (v1.Equals(v2));
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return (!v1.Equals(v2));
        }


        public override string ToString()
        {
            return $"{{ {this[0]}, {this[1]}, {this[2]} }}";
        }
    }
}
