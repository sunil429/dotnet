using System;

namespace DelegateDemoMastek
{
    delegate int CalculatorDelegate(int first, int second);
    class Program
    {
        // 2
        static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
        static int MultiplyNumbers(int number1, int number2)
        {
            return number1 * number2;
        }
        static int MinusNumbers(int number1, int number2)
        {
            return number1 - number2;
        }
        static int DivideNumbers(int number1, int number2)
        {
            return number1 / number2;
        }
        static void Main(string[] args)
        {
            // 3 delegate instance - points to a method 
            // CalculatorDelegate demo1 = new CalculatorDelegate(AddNumbers);
            CalculatorDelegate demo1 = AddNumbers;
           
            // invoke delegate
            int result = demo1(4, 6);
            Console.WriteLine("Addition :" + result);

            

            CalculatorDelegate demo3 = (a, b) => a + b;
            result = demo3(2, 4);
            Console.WriteLine("Addition :" + result);

            CalculatorDelegate demo6 = (a, b) => a * b;
            result = demo6(9, 6);
            Console.WriteLine("Multiply:" + result);

            CalculatorDelegate demo7= (a, b) => a - b;
            result = demo7(7, 4);
            Console.WriteLine("Minus :" + result);

            CalculatorDelegate demo8 = (a, b) => a / b;
            result = demo8(6, 4);
            Console.WriteLine("Division:" + result);


        }
    }
}
