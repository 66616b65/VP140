using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class ActionDelegateExample
    {
        // Action делегат не возвращает какое-либо значение
        // Поэтому снова делаем два метода, которые выводят результат в консоли
        static void Add(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
        static void Mul(int a, int b) => Console.WriteLine($"{a} * {b} = {a * b}");

        // Метод, который принимает в качестве аргументов два целых числа и метод operation
        // Action<int, int> operation - некоторый метод operation принимает два аргумента типа int
        // Так как это Action, то тип возвращаемого значения void
        static void ActionExample(int a, int b, Action<int, int> operation)
        {
            // Вызываем делегат operation с аргументами a и b
            operation(a, b);
        }
        // Или можно записать так с помощью лямбда-выражения
        //  => operation(a, b);

        // Пример для демонстрации
        public static void Example(int a, int b)
        {
            // Передаем аргументы a и b и метод Add
            ActionExample(a, b, Add);
            // Передаем аргументы a и b и метод Mul
            ActionExample(a, b, Mul);
        }
    }
}
