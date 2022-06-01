using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    class CalcModel
    {
        private double num1;
        private double num2;

        public CalcModel()
        {
            Number1 = 0;
            Number2 = 0;
        }
        public CalcModel(double num1, double num2)
        {
            Number1 = num1;
            Number2 = num2;
        }
        public double Number1 
        {
           get { return num1; }
           set { num1 = value; }
        }
        public double Number2
        {
            get { return num2; }
            set { num2 = value; }
        }

        //these are all of the values that we are going to be finding
        public double Addition()
        { 
            return num1 + num2;
        }
        public double Subtraction()
        {
            return num1 - num2;
        }
        public double Multiplication()
        {
            return num1 * num2;
        }
        public double Division()
            {
            return num1 / num2;
        }
     }
}