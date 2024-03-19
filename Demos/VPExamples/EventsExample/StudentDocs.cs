using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class StudentDocs
    {
        public Student Student { get; private set; }
        public Dictionary<string, int> StudResults { get; private set; }

        EventHandler<StudentTestEventArgs> lambda;
        Student.StudentTestEvent method;



        public StudentDocs(string name, int group)
        {
            Student = new Student(name, group);
            StudResults = new Dictionary<string, int>();
            Subscribe();
        }

        void Subscribe()
        {
            //Подписка с использованием имени метода
            Student.OnSomeTest += ConsoleInform;
            Student.OnSomeTest += AddResultToDict;

            //Подписка с использованием лямбды
            //Здесь другое событие и другой делегат (просто для примера)
            //Student.OnTest += (object sender, StudentTestEventArgs results)
            //    => StudResults.Add(results.TestName, results.Score);

            //////но здесь не получится отписаться, поэтому используем переменную
            //////переменная объявлена выше
            //lambda = (object sender, StudentTestEventArgs results)
            //    => StudResults.Add(results.TestName, results.Score);
            //Student.OnTest += lambda;
            ////_student.OnTest -= lambda;

            ////Аналогично для анонимного метода
            //method = delegate (string testName, int score)
            //{
            //    Console.WriteLine($"Студент {_student.Name} сдал тест {testName} на {score}");

            //};
            //_student.OnSomeTest2 += method;
            //_student.OnSomeTest2 -= method;
        }

        public void AddTest(string name, int score)
        {
            Student.Test(name, score);
        }

        void ConsoleInform(object sender, StudentTestEventArgs results)
        {
            Console.WriteLine($"Студент {Student.Name} сдал тест {results.TestName} на {results.Score}");

        }

        void ConsoleInform(string testName, int score)
        {
            Console.WriteLine($"Студент {Student.Name} сдал тест {testName} на {score}");

        }

        void AddResultToDict(object sender, StudentTestEventArgs results)
        {
            StudResults.Add(results.TestName, results.Score);
        }

        void AddResultToDict(string testName, int score)
        {
            StudResults.Add(testName, score);
        }
    }
}
