using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class DelegateExample
    {
        // Создаем делегат, который принимает 2 целых числа и возвращает целое число
        delegate int MathDelegate(int a, int b);

        // Создаем метод с аналогичной сигнатурой
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Ещё один метод (запись упрощена с помощью лямбда-выражения)
        static int Mul(int x, int y) => x * y;

        // И ещё один
        static int Div(int x, int y) => x / y;

        // Метод Example вызывается из класса Program, передаем два любых целых числа
        // Нужен просто для демонстрации работы делегатов, чтоб не писать весь код в Program
        public static void Example(int a, int b)
        {
            // Можно объявить переменную типа делегата MathDelegate
            // И передать ей ссылку на метод Add
            MathDelegate func1 = new MathDelegate(Add);


            // Здесь то же самое, но запись проще
            // Переменная func ссылается на метод Add
            MathDelegate func = Add;
            // С помощью func(a, b) мы передали в метод Add аргументы a и b
            // А результат вывели в консоли
            Console.WriteLine($"{a} + {b} = {func(a, b)}");

            // Здесь мы перезаписали func, теперь она ссылается на метод Mul
            func = Mul;
            Console.WriteLine($"{a} * {b} = {func(a, b)}");

            // А здесь на метод Div
            func = Div;
            Console.WriteLine($"{a} : {b} = {func(a, b)}");
        }
    }
}
