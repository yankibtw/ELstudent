using System;
using System.Threading;

namespace KFU_4th
{
    internal class Program
    {
        static void TypesOf()
        {
            Console.WriteLine("Задание 1\n");
            string msg = "{0,8} | {1,31} | {2}";
            Console.WriteLine(string.Format(msg, "Тип", "Максимальное значение", "Минимальное значение\n"));
            Console.WriteLine(string.Format(msg, "byte", byte.MaxValue, byte.MinValue));
            Console.WriteLine(string.Format(msg, "sbyte", sbyte.MaxValue, sbyte.MinValue));
            Console.WriteLine(string.Format(msg, "short", short.MaxValue, short.MinValue));
            Console.WriteLine(string.Format(msg, "ushort", ushort.MaxValue, ushort.MinValue));
            Console.WriteLine(string.Format(msg, "int", int.MaxValue, int.MinValue));
            Console.WriteLine(string.Format(msg, "uint", uint.MaxValue, uint.MinValue));
            Console.WriteLine(string.Format(msg, "long", long.MaxValue, long.MinValue));
            Console.WriteLine(string.Format(msg, "ulong", ulong.MaxValue, ulong.MinValue));
            Console.WriteLine(string.Format(msg, "float", float.MaxValue, float.MinValue));
            Console.WriteLine(string.Format(msg, "double", double.MaxValue, double.MinValue));
            Console.WriteLine(string.Format(msg, "decimal", decimal.MaxValue, decimal.MinValue));
            Console.WriteLine(string.Format(msg, "char", char.MaxValue, char.MinValue));
            Console.WriteLine(string.Format(msg, "string", "N/A", "N/A"));
            Console.WriteLine(string.Format(msg, "bool", "True", "False"));
            Console.WriteLine(string.Format(msg, "object", "N/A", "N/A"));
            Console.WriteLine(string.Format(msg, "dynamic", "N/A", "N/A\n"));
        }

        static bool IsLetters(string str)
        {
            foreach (char s in str)
            {
                if (!char.IsLetter(s))
                {
                    return false;
                }
            }
            return true;
        }

        static void UsersInfo()
        {
            Console.WriteLine("Задание 2\nВведите Ваше Имя, Город проживания, Возраст и PIN(все с новой строки)");
            string userName = Console.ReadLine(),
                   userTown = Console.ReadLine(),
                   userAge = Console.ReadLine(),
                   userPin = Console.ReadLine();
            uint userOutAge, userOutPin;
            if (!uint.TryParse(userAge, out userOutAge) & !uint.TryParse(userPin, out userOutPin))
            {
                Console.WriteLine("Введите корректный возраст или PIN\n");
            }
            else if ((userOutAge > 0 & userOutAge < 150) & IsLetters(userName) & IsLetters(userTown))
            {
                Console.WriteLine($"Ваше имя: {userName}\n" +
                $"Вы проживаете в городе: {userTown}\n" +
                $"Ваш возраст: {userOutAge}\n" +
                $"Ваш PIN-код: {userOutPin}\n");
            }
            else { Console.WriteLine("Введите корректные данные!"); }
        }
        static void NewString()
        {
            Console.WriteLine("Задание 3:\nВведите строку, состоящую из букв:");
            string input = Console.ReadLine();
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    if (char.IsUpper(input[i]))
                    { // input[i] == input.ToUpper()[i]
                        output += input.ToLower()[i];
                    }
                    else
                    {
                        output += input.ToUpper()[i];
                    }
                }
                else { Console.WriteLine("Введите строку, состоящую из букв!!!\n"); return; }
            }
            Console.WriteLine($"Полученная строка с измененными буквами: {output}\n");
        }

        static void AboutString()
        {
            Console.WriteLine("Задание 4:\nВведите строку и подстроку, чтобы узнать сколько их содержится в основной строке(с новой строки):");
            string inputString = Console.ReadLine();
            string inputSubstring = Console.ReadLine();
            int qty = 0;
            if (inputString.Length > 0 & inputSubstring.Length > 0)
            {
                for (int i = 0; i <= inputString.Length - inputSubstring.Length; i++)
                {
                    if (inputString.Substring(i, inputSubstring.Length) == inputSubstring)
                    {
                        qty++;
                    }
                }
                Console.WriteLine($"Количество подстрок в основной строке: {qty}\n");
            }
            else
            {
                Console.WriteLine($"Введите непустые строки\n");

            }
        }
        static void Botle()
        {
            Console.WriteLine("Задание 5\nВведите цену за виски, скидку в процентах(число) и цену отпуска(с новой строки)");
            string inputNormPrice = Console.ReadLine(),
                   inputSalePrice = Console.ReadLine(),
                   inputHolidayPrice = Console.ReadLine();
            int normPrice, salePrice, holidayPrice;
            if (!(int.TryParse(inputNormPrice, out normPrice) & int.TryParse(inputSalePrice, out salePrice) & int.TryParse(inputHolidayPrice, out holidayPrice)))
            {
                Console.WriteLine("Введите корректные данные!");
            }
            else if (salePrice >= 0 & salePrice <= 100)
            {
                Console.WriteLine($"Чтобы заработать на отпуск, Вам нужно продать {(int)(holidayPrice / (normPrice * ((double)salePrice / 100)))} бутылок!\n");
            }
            else
            {
                Console.WriteLine("Процент должен быть в диапазоне от 0 до 100!\n");
            }

        }
        static void Garry()
        {
            Console.WriteLine("Задание 6:\nКак Вас зовут?");
            Console.WriteLine($"Привет, {Console.ReadLine()}");
            string input = Console.ReadLine();
            if (input.ToLower() == "знаешь ли ты что-то о тайной комнате")
            {
                Console.WriteLine("Да");
                string anotherInput = Console.ReadLine();
                if (anotherInput.ToLower() == "можешь ли рассказать о ней")
                {
                    Console.WriteLine("Нет");
                    Thread.Sleep(5000);
                    Console.WriteLine("Но могу показать!");
                    Console.BackgroundColor = ConsoleColor.Red;
                }
            }
        }
        static void Code()
        {
            Console.WriteLine("Задание 7:\nВведите 12 цифр штрихкода EAN-13: ");
            string inputCode = Console.ReadLine();
            Random rnd = new Random();

            string GenerateRandomCode(Random random)
            {
                string randomCode = "";
                for (int i = 0; i < 12; i++)
                {
                    int digit = random.Next(10);
                    randomCode += digit;
                }

                return randomCode;
            }

            string SearchControlDigit(string input)
            {
                int sumEven = 0;
                int sumOdd = 0;

                for (int i = 0; i < 12; i++)
                {
                    int digit = int.Parse(input[i].ToString());

                    if (i % 2 == 0)
                        sumOdd += digit;
                    else
                        sumEven += digit;
                }
                int total = sumEven * 3 + sumOdd;
                int controlDigit = 0;
                if (total % 10 != 0)
                {
                    controlDigit = (((total / 10) + 1) * 10) - total;
                }

                return ($"{controlDigit}");

            }
            long exitCode;
            if (inputCode.Length != 12 || !long.TryParse(inputCode, out exitCode))
            {
                Console.WriteLine("Введены некорректные данные. Введите 12 цифр.");
            }
            else
            {
                Console.WriteLine($"Контрольная суммма для Вашего числа равна {SearchControlDigit(inputCode)}");
            }

            Console.WriteLine($"Контрольная суммма для Рандомного числа равна {SearchControlDigit(GenerateRandomCode(rnd))}\n");
        }
        struct Student
        {
            public string surname;
            public string name;
            public int ID;
            public string data;
            public char alcoCategory;
            public double alcoVolume;
        }
        static void StudetsInfo()
        {
            Console.WriteLine("Задание 8:");

            Student[] students = new Student[5];
            students[0] = new Student { surname = "Чернышев", name = "Михаил", ID = 1, data = "29.03.2005", alcoCategory = 'a', alcoVolume = 46 };
            students[1] = new Student { surname = "Зубов", name = "Марк", ID = 2, data = "23.07.2003", alcoCategory = 'b', alcoVolume = 18 };
            students[2] = new Student { surname = "Майоров", name = "Алексей", ID = 3, data = "12.11.2003", alcoCategory = 'c', alcoVolume = 4.9 };
            students[3] = new Student { surname = "Котов", name = "Артем", ID = 4, data = "03.09.2005", alcoCategory = 'd', alcoVolume = 0 };
            students[4] = new Student { surname = "Смирнов", name = "Арсений", ID = 5, data = "28.02.2002", alcoCategory = 'a', alcoVolume = 32.4 };

            double sumAlcoVolume = 0;
            foreach (Student student in students)
            {
                sumAlcoVolume += student.alcoVolume;
            }
            Console.WriteLine($"Общее количество алкоголя выпитого в год составляет {sumAlcoVolume} л.\n");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.surname} {student.name}: {student.alcoVolume} л в год ({(student.alcoVolume / sumAlcoVolume) * 100:F2}%)");
            }

        }
        static void Main(string[] args)
        {
            TypesOf();
            UsersInfo();
            NewString();
            AboutString();
            Botle();
            Garry();
            Code();
            StudetsInfo();
        }
    }
}
