using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    //have to rename all of the fields so they are separate from the others
    class CalcView
    {
        private double num1;
        private double num2;
        private double addition;
        private double subtraction;
        private double multiplication;
        private double division;

        public CalcView()
        {
            Number1 = 0;
            Number2 = 0;
            Addition = 0;
            Subtraction = 0;
            Multiplication = 0;
            Division = 0;
            GetValues();
        }
        //keeps the items separate from the other pages
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
        public double Addition
        {
            get { return addition; }
            set { addition = value; }
        }
        public double Subtraction
        {
            get { return subtraction; }
            set { subtraction = value; }
        }
        public double Multiplication
        {
            get { return multiplication; }
            set { multiplication = value; }
        }
        public double Division
        {
            get { return division; }
            set { division = value; }
        }

           //gets the numbers from the user
        private void GetValues()
        {
            Console.WriteLine("Enter the value for Number 1");
            Number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for Number 2");
            Number2 = double.Parse(Console.ReadLine());
        }
        //gets the choice from the users
        public void GetMathOption()
        {
            Console.WriteLine("What math would you like to do?");
            Console.WriteLine("A: Addition");
            Console.WriteLine("S: Subtraction");
            Console.WriteLine("M: Multiplication");
            Console.WriteLine("D: Division");
            char selection = Convert.ToChar(Console.ReadLine());

            if (selection == 'A')
            {
                Console.WriteLine("The total is: {0} ", Addition);
                Console.ReadKey();
            }

            else if (selection == 'S')
            {
                Console.WriteLine("The total is: {0} ", Subtraction);
                Console.ReadKey();
            }
            else if (selection == 'M')
            {
                Console.WriteLine("The total is: {0} ", Multiplication);
                Console.ReadKey();
            }
            else if (selection == 'D')
            {
                Console.WriteLine("The total is: {0} ", Division);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please select a value from the section above");
            }
        }
    }
}
