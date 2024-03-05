using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class MulticastDelegateExample
    {
        // Мультикаст делегат может ссылаться сразу на несколько методов
        // Поэтому он не должен возвращать какое-либо значение
        // И методы, на которые он ссылается, не должны
        // Поэтому здесь мы пишем void
        public delegate void showDelegate(int a, int b);

        // Метод с такой же сигнатурой, как у делегата
        // В отличие от примера в MathDelegate, он не возвращает результат в виде числа
        // А просто выводит значение в консоли
        public static void Add(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");

        // Аналогичный метод
        public static void Mul(int a, int b) => Console.WriteLine($"{a} * {b} = {a * b}");

        // Метод для демонстрации
        public static void Example(int a, int b)
        {
            // В переменную proc типа showDelegate записываем ссылку на метод Add
            showDelegate proc = Add;
            // Добавляем также ссылку на метод Mul
            proc += Mul;
            // А так можно удалить ссылку на метод Mul
            //proc -= Mul;
            // Передаем в proc аргументы a и b
            // Будут по очереди вызваны методы Add и Mul
            proc(a, b);
        }
    }
}
