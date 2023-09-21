using System;


namespace Tymakov3
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
            public int accountNumber;
            public string accountType;
            public double accountBalance;

        }
        enum Vuz
        {
            КГУ,
            КАИ,
            КХТИ
        }
        struct User
        {
            public string Name;
            public Vuz Vuz;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упр. 3.1: Вывести вид счета");
                AccountType tec = AccountType.Текущий;
                AccountType cber = AccountType.Сберегательный;
                Console.WriteLine($"Банк имеет {tec} счет и {cber} счет");
            Console.WriteLine("Упр. 3.2: Заполнить структуру и вывести");
                BankAccount accountname=new BankAccount();
                accountname.accountNumber = 52;
                accountname.accountType = "Текущий";
                accountname.accountBalance = 125372;
                Console.WriteLine($"Номер банковского счета: {accountname.accountNumber}\nТип банковского счета: {accountname.accountType}\nБаланс банковского счета: {accountname.accountBalance} " );
            Console.WriteLine("ДЗ 3.1: Заполнить структуру и вывести");
            User user = new User();
            user.Name = "Алексей";
            user.Vuz = Vuz.КГУ;
            Console.WriteLine($"Работник: {user.Name}\nНазвание вуза: {user.Vuz} ");
                


        }   
    }
}
