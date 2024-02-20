using System;
using System.Text;
using System.Collections.Generic;
using OOPExample;
using DelegatesExample;
using ExceptionsExample;
using ArgumentsExample;
using EventsExample;
using FileSystemExample;
using System.IO;

namespace ExampleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance();
            //StringFormat();
            //StringIntern();
            //Delegates();
            //Exceptions();
            //Arguments();
            //Events();
            //FileSystem();

            //byte[] arr = new byte[10];
            //var fs = new FileStream(@"D:/User/Source/NewDir/file.txt", FileMode.OpenOrCreate);
            //fs = null;
            //var fs2 = new FileStream(@"D:/User/Source/NewDir/file.txt", FileMode.OpenOrCreate);
            //fs2.Read(arr);

            //Console.WriteLine(GC.GetTotalMemory(false));
            //var c1 = "123";
            //var c2 = "457";
            //Console.WriteLine(GC.GetTotalMemory(false));
            //GC.Collect();

            //Console.WriteLine(GC.GetTotalMemory(false));
        }

        static void Inheritance()
        {
            var list = new List<Figure>();
            list.Add(new Round("Round", 2));
            list.Add(new Quadrate("Quadrate", 4));

            foreach (var i in list)
            {
                Console.WriteLine(i.ToString());
            }
        }

        static void StringFormat()
        {
            string item = "Табурет";
            int price = 1000;

            //Форматирование строк
            string result = string.Format("Товар {0} стоимостью {1}", item, price);
            Console.WriteLine(result);

            //Форматирование целых чисел
            result = string.Format("Товар {0} стоимостью {1:d}", item, price);
            Console.WriteLine(result);
            result = string.Format("Товар {0} стоимостью {1:d6}", item, price);
            Console.WriteLine(result);

            double price2 = 999.99;

            //Форматирование дробных чисел
            result = string.Format("Товар {0} стоимостью {1:f}", item, price);
            Console.WriteLine(result);
            result = string.Format("Товар {0} стоимостью {1:f1}", item, price2);
            Console.WriteLine(result);
            result = string.Format("Товар {0} стоимостью {1:f4}", item, price2);
            Console.WriteLine(result);

            //Форматирование денежных значений
            result = string.Format("Товар {0} стоимостью {1:c0}", item, price2);
            Console.WriteLine(result);
            result = string.Format("Товар {0} стоимостью {1:c2}", item, price2);
            Console.WriteLine(result);

            //Форматирование процентов
            var percent = 1 - price / price2;
            result = string.Format("Товар {0} подешевел на {1:p2} процентов", item, percent);
            Console.WriteLine(result);

            //Кастомный формат
            long phone = 88005553535;
            result = string.Format("{0:# (###) ###-##-##} проще позвонить, чем у кого-то занимать", phone);
            Console.WriteLine(result);

            //Аналогично для всех способов форматирования
            result = phone.ToString("# (###) ###-##-## проще позвонить, чем у кого-то занимать");
            Console.WriteLine(result);
            //Или даже так
            Console.WriteLine("{0:# (###) ###-##-##} проще позвонить, чем у кого-то занимать", phone);

            //Удобнее использовать интерполяцию строк
            result = string.Format($"Товар {item} стоимостью {price}");
            Console.WriteLine(result);

            Console.WriteLine($"Товар {item} подешевел на {1 - price / price2:p2} процентов");

            Console.WriteLine($"{phone:# (###) ###-##-##} проще позвонить, чем у кого-то занимать");
        }

        static void StringIntern()
        {
            string s1 = "str";
            string s2 = new StringBuilder().Append("s").Append("tr").ToString();
            string s3 = String.Intern(s2);
            string s4 = "st" + "r";
            //s4 = s1;
            //s3 = String.Intern("123");

            Console.WriteLine($"s1 = {s1}");
            Console.WriteLine($"s2 = {s2}");
            Console.WriteLine($"s3 = {s3}");
            Console.WriteLine($"s4 = {s4}");

            Console.WriteLine($"s2 has the same reference as s1: {(Object)s2 == (Object)s1}");
            Console.WriteLine($"s3 has the same reference as s1: {(Object)s3 == (Object)s1}");
            Console.WriteLine($"s3 has the same reference as s2: {(Object)s3 == (Object)s2}");
            Console.WriteLine($"s4 has the same reference as s1: {(Object)s4 == (Object)s1}");
            Console.WriteLine($"s4 has the same reference as s3: {(Object)s4 == (Object)s3}");
        }

        static void Delegates()
        {
            //DelegateExample.Example(10, 5);

            //MulticastDelegateExample.Example(10, 5);

            //ActionDelegateExample.Example(10, 5);

            FuncDelegateExample.Example(10, 5);
        }

        static void Exceptions()
        {
            //Example.Exception();
            //Example.Demo();
            Example.SpecialDemo();
        }

        static void Arguments()
        {
            ArgumentsExample.ArgumentsExample.Demo();
        }

        static void Events()
        {
            //EventDemo.FirstDemo();
            //EventDemo.SecondDemo();
            //EventDemo.ThirdDemo();
            //EventDemo.FourthDemo();

            var dianovDocs = new StudentDocs("Дианов", 140);
            dianovDocs.AddTest("Физкультура", 99);
            dianovDocs.AddTest("СиАКОД", 10);
            //Попробуем вызвать метод у самого объекта напрямую
            //Для этого сделали его public
            dianovDocs._student.Test("Базы данных", 100);

            foreach (var item in dianovDocs._studResults)
            {
                Console.WriteLine(item);
            }
        }

        static void FileSystem()
        {
            //FSExample.DrivesDemo();
            //FSExample.EnvironmentDemo();
            //FSExample.DirectoryDemo();
            //FSExample.DirectoryInfoDemo();
            //FSExample.FileDemo();
            //FSExample.FileInfoDemo();
            //FSExample.FileStreamDemo();
            //FSExample.StreamReaderDemo();
            //FSExample.StreamWriterDemo();
            //FSExample.BinaryWriterDemo();
            //FSExample.BinaryReaderDemo();
        }

    }
}
