using System;
using System.Collections;

namespace ExceptionsExample
{
    public class Example
    {
        static int Divide(int x, int y)
        {

            if (y == 0)
            {
                // Создаем локальную переменную для получения
                // свойства HelpLink
                Exception exception = new Exception();
                exception.HelpLink = "http://rsreu.ru/";
                // Вставка специальных дополнительных данных
                // имеющих отношение к ошибке
                exception.Data.Add("Время возникновения: ", DateTime.Now);
                exception.Data.Add("Причина: ", "Делитель равен 0");
                throw exception;
            }
            return x / y;
        }

        public static void Exception()
        {
            try
            {
                Console.Write("Введите целое число x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите целое число y: ");
                int y = int.Parse(Console.ReadLine());

                int result = Divide(x, y);

                Console.WriteLine($"Результат: {result}");
            }
            // Обрабатываем исключение возникающее при делении на ноль
            //catch (DivideByZeroException)
            catch (DivideByZeroException ex)
            {
                //Console.WriteLine("Деление на 0!");
                Console.WriteLine($"Ошибка: {ex.Message}");
                //Exception();
            }
            // Обрабатываем исключение при неккоректном вводе числа в консоль
            //catch (FormatException)
            catch (FormatException ex)
            {
                Console.WriteLine("Это не целое число!");
                Console.WriteLine($"Ошибка: {ex.Message}");
                //Exception();
            }
            // Блок finally
            finally
            {
                Console.WriteLine("Надеюсь, вам понравилось");
                //Exception();
            }
        }

        public static void Demo()
        {
            try
            {
                Console.Write("Введите целое число x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите целое число y: ");
                int y = int.Parse(Console.ReadLine());

                int result = Divide(x, y);
                Console.WriteLine($"Результат: {result}");
            }
            // Обрабатываем общее исключение
            catch (Exception ex)
            {
                Console.WriteLine("Исключение!!!");
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Вывод стека: {ex.StackTrace}");
                Console.WriteLine($"Подробности на сайте: {ex.HelpLink}");
                if (ex.Data != null)
                {
                    Console.WriteLine("Сведения:");
                    foreach (DictionaryEntry d in ex.Data)
                        Console.WriteLine($"-> {d.Key} {d.Value}");
                }
                //Demo();
            }
        }


        static int SpecialDivide(int x, int y)
        {
            if (y == 0)
            {
                SpecialException exc = new SpecialException("Ошибка: деление на 0");
                exc.HelpLink = "http://rsreu.ru/";
                throw exc;
            }
            return x / y;
        }

        public static void SpecialDemo()
        {
            try
            {
                SpecialDivide(5, 0);
            }
            // Обрабатываем общее исключение
            catch (SpecialException ex)
            {
                Console.WriteLine("Возникла ошибка");
                Console.WriteLine($"Сообщение: {ex.Message}");
                Console.WriteLine($"Сайт радика {ex.HelpLink}");
            }
        }
    }
}
