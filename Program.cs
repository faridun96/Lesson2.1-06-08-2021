using System;

namespace Lesson2App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первое число: ");
            int operand1 = Int32.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            int operand2 = Int32.Parse(Console.ReadLine());
            Console.Write("Введите знак арифметической операции (+,-,*,/): ");
            string sign = Console.ReadLine();
            switch (sign)
            {
                    case "+":
                        {
                            Console.WriteLine(operand1 + operand2);
                            break;
                        }
 
                    case "-":
                        {
                            Console.WriteLine(operand1 - operand2);
                            break;
                        }
 
                    case "*":
                        {
                            Console.WriteLine(operand1 * operand2);
                            break;
                        }
 
                    case "/":
                    {
                        try
                            {
                               Console.WriteLine(operand1 / operand2);
                            }
                        catch (DivideByZeroException) 
                              { Console.WriteLine("Ошибка! Разделить невозможно!"); }
                        break;
                    }
                    default:
                        {
                            Console.WriteLine("Вы ввели некорректный знак");
                            break;
                        }   
            }
        }
    }
}    