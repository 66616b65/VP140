using System;

namespace GenericsExample
{
    public class Node<T> where T : IComparable<T>
    {
        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public T Data { get; set; }

        public int CompareTo(Node<T> other)
        {
            return default(int);
        }

    }

    public class Tree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public void Add(T element) { }

        public void Remove(T element) { }

    }

    public class User<T, K>
    {
        public T Id { get; private set; }
        public string Login { get; private set; }
        public K Password { get; set; }

        public User() { }

        public User(T id, string login, K password)
        {
            Id = id;
            Login = login;
            Password = password;
        }
    }

    public class Item<T>
    {
        public string Name { get; set; }
        public T Parameters { get; set; }
    }

    //1st case
    class Furniture<T> : Item<T> { }
    
    //2nd case
    class Furniture : Item<int[]> { }

    //3rd case
    class Food<T> : Item<int[]> { }

    //4th case
    class Food<T, K> : Item<T> { }

    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class Food : Item
    {
        public int Weight { get; set; }
    }

    public class Shop<TItem> where TItem : Item { }

    public class Busket<T> where T : class, new() { }

    public class Example
    {
        void TreeExample()
        {
            var tree = new Tree<int>(); //Int32
            tree.Add(25); //Int32
            //tree.Add("123"); //string
            tree.Add(Convert.ToInt32(new object())); //object
            tree.Add((Int16)17); //Int16
        }

        void UserExample()
        {
            var user1 = new User<int, string>(1930, "superproger", "qwerty");
            var user2 = new User<int[], char>();
        }

        void ItemExample()
        {
            var table = new Item<int[]>()
            { 
                Name = "Table", 
                Parameters = new int[] { 30, 65, 70 }
            };

            var chair = new Item<string>()
            {
                Name = "Chair",
                Parameters = "Brown"
            };
        }
    }

    public interface IItem<in T> { }

    public interface IFood<out T> { }

    public interface IFurniture<T> { }
}
