using System;


namespace Zadachi
{
    internal class Program
    {
        struct Student
        {
            public string name;
            public string surname;
            public int id;
            public DateTime birthday;
            public char alcoCategory;
            public int Valco;

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: Вывести макс. и мин. каждого типа");
                Console.WriteLine($"byte - макс.: {byte.MaxValue},мин.: {byte.MinValue} \nsbyte - макс.: {sbyte.MaxValue}, мин.: {sbyte.MinValue} \n" +
                                  $"short - макс.: {short.MaxValue}, мин.: {short.MinValue} \nushort - макс.: {ushort.MaxValue}, мин.: {ushort.MinValue} \n" +
                                  $"int - макс.: {int.MaxValue}, мин.: {int.MinValue} \nuint - макс.: {uint.MaxValue}, мин.: {uint.MinValue} \n" +
                                  $"long - макс.: {long.MaxValue}, мин.: {long.MinValue} \nulong - макс.: {ulong.MaxValue}, мин.: {ulong.MinValue} \n" +
                                  $"float - макс.: {float.MaxValue}, мин.: {float.MinValue} \ndouble - макс.: {double.MaxValue}, мин.: {double.MinValue} \n" +
                                  $"decimal - макс.: {decimal.MaxValue}, мин.: {decimal.MinValue} \nchar - макс.: нет, мин.: нет \nbool - макс.: нет, мин.: нет \nstring - макс.: нет, мин.: нет \nobject - макс.: нет, мин.: нет");
            Console.WriteLine("Задание 2: Заполнить данные о пользователе");
                Console.Write("Введите имя(Д.п.): ");
                string Name = Console.ReadLine();
                Console.Write("Введите возраст : ");
                int Age = int.Parse(Console.ReadLine());
                Console.Write("Из какого вы города: ");
                string Sity = Console.ReadLine();
                Console.Write("Введите PIN-код: ");
                int PIN = int.Parse(Console.ReadLine());
                (string, int, string, int) person = (Name, Age, Sity, PIN);
                Console.WriteLine($"Пользователю {person.Item1} {person.Item2} лет, проживает в городе {person.Item3} имеет PIN-код {person.Item4}");
            Console.WriteLine("Задание 5: определить сколько бутылок нужно купить");
                double normPrice, salePrice, holidayPrice, itog, Bottles;
                Console.Write("Введите цену виски: ");
                normPrice = double.Parse(Console.ReadLine());
                Console.Write("Введите скидку в DutyFree: ");
                salePrice = double.Parse(Console.ReadLine());
                Console.Write("Введите стоимость отпуска: ");
                holidayPrice = double.Parse(Console.ReadLine());
                itog = normPrice * (salePrice / 100);
                Bottles =Math.Floor(holidayPrice/itog) ;
                Console.WriteLine($"Необходимо купить {Bottles} бутылок виски");
            Console.WriteLine("Задание 6: переписать диалог");
                Console.Write("Поздоровайтесь: ");
                Console.ReadLine();
                Console.Write("Как вас зовут: ");
                string Name1 = Console.ReadLine();
                Console.WriteLine($"Привет, {Name1}");
                Console.Write("Спросите о тайной комнате: ");
                Console.ReadLine();
                Console.WriteLine("Да");
                Console.Write("Спросите может ли рассказать: ");
                Console.ReadLine();
                Console.WriteLine("Нет");
                Console.WriteLine("Но могу показать");
                Console.ResetColor();
            Console.WriteLine("Задание 8: посчитать объем алкоголя у 5 студентов");
            double Vsego;
            double prAleksei, prPetya, prNikita, prEgor, prKamil;

            Student Aleksei= new Student();
            Aleksei.name = "Алексей";
            Aleksei.surname = "Шакиров";
            Aleksei.id = 41;
            DateTime AlekseiBirthday = new DateTime(2005, 05, 25);
            Aleksei.birthday = AlekseiBirthday;
            Aleksei.alcoCategory = 'a';
            Aleksei.Valco = 15;
            Student Nikita = new Student();
            Nikita.name = "Никита";
            Nikita.surname = "Луков";
            Nikita.id = 25;
            DateTime Nikitairthday = new DateTime(2004, 04, 13);
            Nikita.birthday = Nikitairthday;
            Nikita.alcoCategory = 'a';
            Nikita.Valco = 11;
            Student Petya = new Student();
            Petya.name = "Петя";
            Petya.surname = "Васильев";
            Petya.id = 11;
            DateTime PetyaBirthday = new DateTime(2003, 02, 29);
            Petya.birthday = PetyaBirthday;
            Petya.alcoCategory = 'b';
            Petya.Valco = 6;
            Student Egor = new Student();
            Egor.name = "Егор";
            Egor.surname = "Павлов";
            Egor.id = 47;
            DateTime EgorBirthday = new DateTime(2005, 12, 04);
            Egor.birthday = EgorBirthday;
            Egor.alcoCategory = 'c';
            Egor.Valco = 3;
            Student Kamil = new Student();
            Kamil.name = "Камиль";
            Kamil.surname = "Зарифуллин";
            Kamil.id = 78;
            DateTime KamilBirthday = new DateTime(2005, 12, 20);
            Kamil.birthday = KamilBirthday;
            Kamil.alcoCategory = 'd';
            Kamil.Valco = 0;
            Vsego = Kamil.Valco + Egor.Valco + Petya.Valco + Nikita.Valco + Aleksei.Valco;
            prAleksei = (Aleksei.Valco/Vsego)*100;
            prPetya = (Petya.Valco / Vsego) * 100;
            prNikita = (Nikita.Valco / Vsego) * 100;
            prEgor = (Egor.Valco / Vsego) * 100;
            prKamil= (Kamil.Valco / Vsego) * 100;
            Console.WriteLine($"Всего студенты выпили: {Vsego} литров. Алексей выпил {prAleksei}%, Никита выпил {prNikita}%, Петя выпил {prPetya}%, Егор выпил {prEgor}%, Камиль выпил {prKamil}%");




        }
    }
}
