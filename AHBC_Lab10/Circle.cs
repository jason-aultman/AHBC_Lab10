using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace AHBC_Lab10
{
    class Circle
    {
        public static int count;
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
            count++;
        }
        public double CalculateCircumference()
        {
            
            return Math.PI*2*Radius;
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            return Math.PI*(Radius*Radius);
        }
        public string CalculateFormattedArea()
        {

            return FormatNumber(CalculateArea());
        }
        private string FormatNumber(double x)
        {
            //oops, holdover  from Java 6, C# makes this much easier...
            //var formattedNumber = (Math.Round(x * 100)/100).ToString();
            var formattedNumber = Math.Round(x, 2, MidpointRounding.AwayFromZero).ToString();
            return formattedNumber;
        }

    }
}
