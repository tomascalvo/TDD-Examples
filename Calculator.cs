using System;
using System.Collections.Generic;
using System.Text;

namespace xunitPractice
{
    class Calculator
    {
        public double Add(double addend1, double addend2)
        {
            double sum = addend1 + addend2;
            return sum;
        }
        public double Subtract(double minuend, double subtrahend)
        {
            double difference = minuend - subtrahend;
            return difference;
        }
        //public double Multiply(double factor1, double factor2)
        //{
        //    return product;
        //}
        //public double Divide(double dividend, double divisor)
        //{
        //    return quotient;
        //}
        //public double Exponentiate(double base, double exponent)
        //{
        //    return power;
        //}
        //public double CalculateAreaSquare(double length, double width)
        //{
        //    return area;
        //}
        //public double CalculateAreaTriangle(double length, double width)
        //{
        //    return area;
        //}
        //public double CalculateSurfaceAreaCube(double length, double width, double height)
        //{
        //    return surfaceArea;
        //}
    }
}
