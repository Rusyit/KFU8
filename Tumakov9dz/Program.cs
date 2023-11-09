using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov9dz
{
    public enum AccType
    {
        Текущий,
        Сберегательный
    }

    class Program
    {
        static void Main()
        {
            // УПРАЖНЕНИЕ 9.1.
            Console.WriteLine("УПРАЖНЕНИЕ 9.1.\n");

            Bank1 BankAcc1 = new Bank1(100);
            Bank1 BankAcc2 = new Bank1(14, AccType.Текущий);

            Console.WriteLine($"{BankAcc1.BankAccType} №{BankAcc1.AccNum:D4}, баланс: {BankAcc1.AccBalance} рублей\n" +
                $"{BankAcc2.BankAccType} №{BankAcc2.AccNum:D4}, баланс: {BankAcc2.AccBalance} рублей");


            // УПРАЖНЕНИЕ 9.2.
            Console.WriteLine("\nУПРАЖНЕНИЕ 9.2.\n");

            try
            {
                Bank2 BankAcc3 = new Bank2(1, AccType.Сберегательный);
                Queue<BankTrans> transactionList;
                int count;

                Console.WriteLine("Введите сумму для пополнения: ");
                int a = int.Parse(Console.ReadLine());
                BankAcc3.PutMoney(a);

                Console.WriteLine("Введите сумму для снятия: ");
                int b = int.Parse(Console.ReadLine());
                BankAcc3.MoreMoney(b);

                transactionList = BankAcc3.TransList;
                count = transactionList.Count;

                for (int i = 0; i < count; i++)
                {
                    BankTrans trans = transactionList.Dequeue();
                    if (trans.AmountChange < 0)
                    {
                        Console.WriteLine($"Снятие: {trans.TransDate}, {trans.AmountChange} руб");
                    }
                    else
                    {
                        Console.WriteLine($"Пополнение: {trans.TransDate}, {trans.AmountChange} руб");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильный ввод. Вы ввели не число или ничего не ввели");
            }

            Console.WriteLine("УПРАЖНЕНИЕ 9.3.\n");

            Bank3 BankAcc4 = new Bank3(2, AccType.Текущий);

            try
            {
                Console.WriteLine("Введите сумму для пополнения: ");
                int c = int.Parse(Console.ReadLine());
                BankAcc4.PutMoney(c);
            }

            catch (FormatException)
            {
                Console.WriteLine("Неправильный ввод. Вы ввели не число или ничего не ввели");
            }
            BankAcc4.Dispose(BankAcc4);

            // Домашнее задание 9.1. 
            Console.WriteLine("\nДОМАШНЕЕ ЗАДАНИЕ 9.1.\n");

            Song Song1 = new Song("Цунами", "Нюша");
            Song Song2 = new Song("Выше", "Нюша", Song1);
            Song Song3 = new Song("Целуй", "Нюша", Song2);
            Song Song4 = new Song("Наедине", "Нюша", Song3);
            Song Song5 = new Song();

            Console.WriteLine($"Песни: {Song1.Title}, {Song2.Title}, {Song3.Title}, {Song4.Title}, {Song5.Title}");
        }
    }
}
