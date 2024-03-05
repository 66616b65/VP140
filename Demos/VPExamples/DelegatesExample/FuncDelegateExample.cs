using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class FuncDelegateExample
    {
        // Func делегат возвращает какое-то значение
        // Поэтому здесь методы будут возвращать целое число
        static int Add(int a, int b) => a + b;
        static int Mul(int a, int b) => a * b;

        // Метод, который принимает в качестве аргументов два целых числа и метод operation
        // Func<int, int, int> operation - некоторый метод operation принимает два аргумента типа int
        // Так как это Func, то тип возвращаемого значения указывается последним (в данном случае это тоже int)
        // Например, Func<int, char> принимает int и возвращает char
        // При этом в operation мы передаем только 2 значения
        static int FuncExample(int a, int b, Func<int, int, int> operation) => operation(a, b);

        public static void Example(int a, int b)
        {
            // Передаем аргументы a и b и метод Add
            // Здесь для наглядности добавим переменную result, в которую заносим результат FuncExample
            int result = FuncExample(a, b, Add);
            Console.WriteLine($"{a} + {b} = {result}");
            // Передаем аргументы a и b и метод Mul
            result = FuncExample(a, b, Mul);
            Console.WriteLine($"{a} * {b} = {result}");
        }
    }
}
