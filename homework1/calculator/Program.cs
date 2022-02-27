using System;

namespace homework1
{
    class calculator
    {
        static void Main(string[] args)
        {

            Console.WriteLine("input number1");
            string numb1 = Console.ReadLine();
            double num1 = double.Parse(numb1);

            Console.WriteLine("input number2");
            string numb2 = Console.ReadLine();
            double num2 = double.Parse(numb2);

            Console.WriteLine("operation");
            string op = Console.ReadLine();

            Console.WriteLine(calculate(op, num1, num2));

            static double calculate(string op, double num1, double num2)
            {
                double res = 0;
                switch (op)
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        res = num1 / num2;
                        break;
                }
                return res;
            }
        }
    }
}
