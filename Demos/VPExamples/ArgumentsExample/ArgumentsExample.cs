using System;

namespace ArgumentsExample
{
    public class ArgumentsExample
    {
        static void RefExample(int[] arr)
        {
            arr[0] = 111;
            Console.WriteLine($"{arr[0]}");
            arr = new int[] { 23, 45, 67 };
        }

        static void RefExample(ref int[] arr)
        {
            arr[0] = 111;
            Console.WriteLine($"{arr[0]}");
            arr = new int[] { 23, 45, 67 };
        }

        static void RefValExample(int val)
        {
            val = 111;
            Console.WriteLine($"{val}");
            val = 10;
        }

        static void RefValExample(ref int val)
        {
            val = 111;
            Console.WriteLine($"{val}");
            val = 10;
        }

        static void OutExample(int[] arr)
        {
            arr = new int[] { 1, 3, 5 };
        }

        static void OutExample(out int[] arr)
        {
            arr = new int[] { 1, 3, 5 };
        }

        static void ParamsExample(string str, params int[] args)
        {
            foreach (var i in args)
            {

            }
        }

        public static void Demo()
        {
            var array = new int[] { 1, 2, 3 };
            Console.WriteLine($"{array[0]}");
            RefExample(array);
            Console.WriteLine($"{array[0]}");
            RefExample(ref array);
            Console.WriteLine($"{array[0]}");

            int a = 5;
            Console.WriteLine($"{a}");
            RefValExample(a);
            Console.WriteLine($"{a}");
            RefValExample(ref a);
            Console.WriteLine($"{a}");

            int[] newArray;
            //OutExample(newArray);
            OutExample(out newArray);

            ParamsExample("str", 1, 4, 5);
            ParamsExample("str", new int[] { 1, 5, 56 });
        }
    }
}
