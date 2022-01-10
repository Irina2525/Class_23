using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Class_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            Console.ReadKey();

        }

        static void Factorial(int n) //  void- метод сразу будет выводить
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                Thread.Sleep(10); // ставим задержку на 10 млсек 
            }
            Console.WriteLine("Факториал числа {0}! = {1}", n, f);

        }

        // метод кт будет  вызывать метод асинхронным
        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n)); // метод вызывает Fact(n), Run- на выходе получаем горячую задачу т.е. запущенную 
        }


    }
}
