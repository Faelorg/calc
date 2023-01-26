using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalc
{   
    class Triangle
    {
        private double a { get; set; }

        private double b { get; set; }

        private double c { get; set; }

        private double al { get; set; }

        private bool razn { get; set; }
        public Triangle(double a, double b, double al)
        {
            this.a = a;

            this.b = b;

            this.al = al;
        }

        public Triangle(double a, double b, double c, int? o)
        {
            if (a>b+c || b>a+c || c>a+b)
            {
                throw new Exception("Такого треугольника не существует");
            }
            if (a==b & b==c & a==c)
            {
                razn = false;
            }
            else
            {
                razn = true;
            }

            this.a = a;

            this.b = b;

            this.c = c;
        }

        public double resultSquareABC()
        {
            double square;
            if (razn)
            {
                double p = (a + b + c) / 2;

                square = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            }
            else
            {
                square = (Math.Sqrt(3) * a * a) / 4;
            }
            throw new Exception();
            return square;
        }



        //Две стороны и угол между  ними
        private double RadtoDeg(double rad)
        {
            return rad * 180 / Math.PI;
        }
        public double resultSquareAB()
        {
            double square = 0.5 * a * b * Math.Sin(RadtoDeg(al));

            return Math.Round(square, 2);
        }

    }
}
