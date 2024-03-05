using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsExample
{
    public class Example
    {
        void EnumeratorExample()
        {
            var menu = new Menu();
            foreach(var bun in menu.GetTastyBuns("изюм"))
            {

            }
        }
    }

    public class Menu : IEnumerable
    {
        string[] buns = { "С повидлом", "С сыром", "С изюмом", "С маком"};
        //public IEnumerator GetEnumerator() => buns.GetEnumerator();

        public IEnumerator GetEnumerator() => new MenuEnumerator(buns);

        //public IEnumerator<string> GetEnumerator()
        //{
        //    for (int i = 0; i < buns.Length; i++)
        //    {
        //        yield return buns[i];
        //    }
        //    var j = 1;
        //    yield return "str";
        //    j = 2;
        //    yield return j.ToString();
        //}

        public IEnumerable<string> GetTastyBuns(string taste)
        {
            for (int i = 0; i < buns.Length; i++)
            {
                if (buns[i] == taste)
                {
                    yield break;
                }
                else
                {
                    yield return buns[i];
                }
            }
        }
    }

    public class MenuEnumerator : IEnumerator
    {
        string[] buns;
        int position = -1;

        public MenuEnumerator(string[] buns) => this.buns = buns;

        public object Current
        {
            get
            {
                if (position == -1 || position >= buns.Length)
                {
                    throw new ArgumentException();
                }

                return buns[position];
            }
        }

        public bool MoveNext()
        {
            if (position < buns.Length - 1)
            {
                position++;
                return true;
            }
            //else
                return false;
        }

        public void Reset() => position = -1;
    }
}
