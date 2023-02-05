using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalc
{   
    class Triangle
    {
        public double a { private get; set; }

        public double b { private get; set; }

        public double c { private get; set; }

        public double al {private get; set; }

        


        public string resultSquareABC()
        {
            if (!(a>=b+c||b>=a+c||c>=a+b))
            {
                double p = (a + b + c) / 2;

                double sqr = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

                return Math.Round(sqr, 3).ToString();
            }
            else
            {
                return "Треугольник не существует";               
            }
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
