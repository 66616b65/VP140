using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public static class EventDemo
    {
        // Пример 1
        // Обработчик события
        static void FirstHandler()
        {
            Console.WriteLine("Произошло событие");
        }

        public static void FirstDemo()
        {
            // Создаем объект класса события
            MyEvent evt = new MyEvent();

            // Добавим метод Handler() в список обработчиков события
            evt.OnSomeEvent += FirstHandler;

            // Запустим событие
            // Здесь вызываются все методы, являющиеся обработчиками
            evt.SomeEvent();
        }


        // Пример 2
        // Обработчик события
        static void SecondHandler()
        {
            Console.WriteLine("Событие получил объект класса EventDemo");
        }

        public static void SecondDemo()
        {
            // Создаем объект класса события
            MyEvent evt = new MyEvent();

            // Создаем котёнка и щенка
            Cat kitty = new Cat();
            Dog puppy = new Dog();

            // Добавим обработчики
            evt.OnSomeEvent += SecondHandler;
            evt.OnSomeEvent += kitty.CatHandler;
            evt.OnSomeEvent += puppy.DogHandler;
            //evt.OnSomeEvent -= puppy.DogHandler;

            // Запустим событие
            // Здесь вызываются все методы, являющиеся обработчиками
            evt.SomeEvent();
        }

        // Пример 3
        public static void ThirdDemo()
        {
            // Создаем объект класса события
            MyEvent evt = new MyEvent();

            // Создаем лисичек
            Fox f1 = new Fox("Рыжуля");
            Fox f2 = new Fox("Пушистик");
            Fox f3 = new Fox("Ушастик");

            // Добавим обработчики
            evt.OnSomeEvent += f1.FoxHandler;
            evt.OnSomeEvent += f2.FoxHandler;
            evt.OnSomeEvent += f3.FoxHandler;

            // Запустим событие           
            evt.SomeEvent();
        }


        // Пример 4
        public static void FourthDemo()
        {
            // Создаем объект класса события
            MyEvent evt = new MyEvent();

            // Добавим обработчик
            evt.OnSomeEvent += Bird.BirdHandler;

            // Запустим событие           
            evt.SomeEvent();
        }

    }
}
