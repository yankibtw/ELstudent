using System;

namespace KFU_2nd
{
    internal class Program
    {
        static void SendYourName()
        {
            Console.WriteLine("Упражнение 2.1\nВведите свое имя: ");
            Console.WriteLine($"Здравствуй, {Console.ReadLine()}!!!\n");
        }
        static void SendValues()
        {
            Console.WriteLine("Упражнение 2.2\nВведите два числа, результат деления которых Вам нужно узнать: ");
            string firstNumber = Console.ReadLine(),
                   secondNumber = Console.ReadLine();
            decimal firstValue, secondValue;
            if (!decimal.TryParse(firstNumber, out firstValue) || (!decimal.TryParse(secondNumber, out secondValue)))
            {
                Console.WriteLine("Пожалуйста, введите корректные данные!!!");
            }
            else
            {
                try
                {
                    Console.WriteLine($"Результат деления второго числа на первое: {secondValue / firstValue}\n");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("На ноль делить нельзя!!!\n");
                }
            }
        }
        static void NewChar()
        {
            Console.WriteLine("Домашнее задание 2.1\nВведите букву: ");
            char value = Console.ReadKey().KeyChar;
            if (char.IsLetter(value))
            {
                if (value != 'z' & value != 'Z' & value != 'я' & value != 'Я')
                {
                    Console.WriteLine($"\nСледующая буква по алфавиту: {(char)(value + 1)}\n");
                }
                else if (char.IsLower(value))
                {
                    Console.WriteLine("\nСледующая буква в Алфавите: а");
                }
                else
                {
                    Console.WriteLine("\nСледующая буква в Алфавите: А");
                }
            }
            else
            {
                Console.WriteLine("Введите букву!!!");
            }
        }
        static void Roots()
        {
            Console.WriteLine("Домашнее задание 2.2:\nВведите коэффициенты квадратного уравнения(Каждое с новой строки):");
            double a = double.Parse(Console.ReadLine()),
                   b = double.Parse(Console.ReadLine()),
                   c = double.Parse(Console.ReadLine());
            double discriminant = (b * b - 4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("Квадратное уравнение с данными коэффициентами корней не имеет!\n");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine($"Квадратное уравнение с данными коэффициентами имеет 1 корень = {(-b + Math.Sqrt(discriminant)) / (2 * a)}!\n");
            }
            else
            {
                Console.WriteLine($"Квадратное уравнение с данными коэффициентами имеет 2 кореня = {(-b + Math.Sqrt(discriminant)) / (2 * a)}, {(-b - Math.Sqrt(discriminant)) / (2 * a)}!\n");
            }
        }

        static void Main(string[] args)
        {
            SendYourName();
            SendValues();
            NewChar();
            Roots();
        }
    }
}
