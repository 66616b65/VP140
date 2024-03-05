using System;

namespace DelegatesExample
{
    public class AnonymousFuncExample
    {
        delegate int Operation(int x, int y);
        delegate int UnaryOperation(int x);
        delegate int MethodWithoutArguments();

        void LambdaExample()
        {
            Operation sum = (x, y) => x + y;
            int result = sum(5, 10);

            //C# v.10
            //var mul = (int x, int y) => x * y;

            Operation comp = (x, y) =>
            {
                if (x > y) return 1;
                else if (x == y) return 0;
                else return -1;
            };

            UnaryOperation square = x => x * x;
            MethodWithoutArguments getYear = () => DateTime.Now.Year;
        }

        void AnonymousMethodExample()
        {
            Operation sum = delegate (int x, int y) { return x + y; };
            UnaryOperation square = delegate (int x) { return x * x; };
            MethodWithoutArguments getYear = delegate () { return DateTime.Now.Year; };
        }
    }
}
