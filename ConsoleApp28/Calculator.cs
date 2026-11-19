using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    internal class Calculator
    {
        public double a { get; set; }
        public double b { get; set; }
        public void SetA()
        {
            Console.WriteLine("Enter a: ");
            a = double.Parse(Console.ReadLine());
        }
        public void SetB()
        {
            Console.WriteLine("Enter b: ");
            b = double.Parse(Console.ReadLine());
        }

        public string Addition()
        {
            return (a+b).ToString();
        }
        public string Subtraction()
        {
            return (a-b).ToString();
        }
        public string Multiply()
        {
            return (a * b).ToString();
        }
        public string Division()
        {
            if (b != 0)
            {
                return (a / b).ToString();
            }
            else
            {
                return "Error you cannot divide by 0 !!!";
            }
        }
        public string Percentege()
        {
            return ((a / 100) * b).ToString();
        }
        public string Degree()
        {
            if (b == 0)
            {
                return "1";
            }
            double temp = a;
            for (int i = 0; i < b; i++)
            {
                temp *= b;
            }
            return temp.ToString();
        }
    }
}
