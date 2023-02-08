using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17_СамРабота_Обобщенные_типы_Вариант_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> BA1 = new BankAccount<int>();
            BA1.Number = 7879;
            BA1.Balance = 74225.56;
            BA1.Name = "Иван Иванов";
            Console.WriteLine(BA1.GetInfo());

            BankAccount<string> BA2 = new BankAccount<string>();
            BA2.Number = "AT 009";
            BA2.Balance = 17200.77;
            BA2.Name = "Петр Петров";
            Console.WriteLine(BA2.GetInfo());

            BankAccount<double> BA3 = new BankAccount<double>();
            BA3.Number = 16.5;
            BA3.Balance = 11100.00;
            BA3.Name = "Герасим Герасимов";
            Console.WriteLine(BA3.GetInfo());

            Console.ReadKey();
        }
    }
}
