using System;

namespace KFU_3rd
{
    internal class Program
    {
        enum AccountType
        {
            Текущий,
            Сберегательный
        }
        struct BankAccount
        {
            public uint AccountID;
            public AccountType AccountTypeOf;
            public decimal AccountBalance;
        }
        struct User
        {
            public string Name;
            public Vuz Vuz;
        }
        enum Vuz
        {
            КГУ,
            КАИ,
            КХТИ
        }
        static void Type()
        {
            Console.WriteLine("Упражнение 3.1: ");
            AccountType account = AccountType.Текущий;
            Console.WriteLine($"Ваш тип банковского счета: {account}\n");
        }
        static void Bank()
        {
            Console.WriteLine("Упражнение 3.2: ");
            BankAccount user = new BankAccount();
            user.AccountID = 123;
            user.AccountTypeOf = AccountType.Текущий;
            user.AccountBalance = 5000;

            Console.WriteLine($"Номер Вашего банковского счета: {user.AccountID}\n" +
                $"Тип Вашего банковского счета: {user.AccountTypeOf}\n" +
                $"Баланс Вашего банковского счета: {user.AccountBalance}\n");
        }
        static void UserInfo()
        {
            Console.WriteLine("Домашнее задание 3.1: ");
            User user = new User();
            user.Name = "Александр";
            user.Vuz = Vuz.КАИ;

            Console.WriteLine($"Работник ВУЗа: {user.Name}\n" +
                $"Название ВУЗа: {user.Vuz}");
        }
        static void Main(string[] args)
        {
            Type();
            Bank();
            UserInfo();
        }
    }
}
