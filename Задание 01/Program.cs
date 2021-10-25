using System;

namespace Задание_01
{
    //1.Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
    //Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
    //Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
    //Создать  несколько экземпляров класса, параметризированного различными типам.
    //Заполнить его поля и вывести информацию об экземпляре класса на печать.

    public class Bank<T> //Объявляем параметризированный класс
    {
        public T AccountNumber { get; private set; } //Параматрезированный номер счёта
        public string NameOfUser { get; private set; }
        public double AccountBalance { get; private set; }
        //Прошу разъяснить: что имелось ввиду в качестве "закрытые поля"

        //Метод 1 заполняет данные в поля параметризированного класса
        public void dataFill(T _accountNumber, string _nameOfUser, double _accountBalance) 
        {
            AccountNumber = _accountNumber;
            NameOfUser = _nameOfUser;
            AccountBalance = _accountBalance;
        }

        public void dataDisplay() //Метод 2 выводит данные класса на консоль
        {
            Console.Write("{0,-15}", AccountNumber);
            Console.Write("{0,-25}", NameOfUser);
            Console.WriteLine("{0:F2} руб.", AccountBalance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank<string> bank01 = new Bank<string>(); //Экземпляр класса Bank параметризирорванный типом string    
            bank01.dataFill("010111", "Jhon Smith", 55010.15);

            Bank<string> bank02 = new Bank<string>(); //Экземпляр класса Bank параметризирорванный типом string 
            bank02.dataFill("А456BC0975", "Semen Petrov", 1650010.90);

            Bank<int> bank03 = new Bank<int>();  //Экземпляр класса Bank параметризирорванный типом int 
            bank03.dataFill(556618, "Vladislav Drozd", -35670.50);

            Bank<int> bank04 = new Bank<int>();  //Экземпляр класса Bank параметризирорванный типом int
            bank04.dataFill(556618, "Innocent Feigelman ", 451090.30);

            //Вызов методов dataDisplay для созданных ранее ранее экземпляров
            bank01.dataDisplay();
            bank02.dataDisplay();
            bank03.dataDisplay();
            bank04.dataDisplay();

            Console.ReadKey();
        }
    }
}
