using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    public static class LinqExample
    {
        public static void Demo()
        {
            var intCollection = new List<int>() { 1, 6, 8, 23, -2 };
            var hasNegative = intCollection.Any(n => n < 0);
            var sort = intCollection.OrderByDescending(n => n);
            var where = intCollection.Where(x => x > 10 || (x / 2) > 20).OrderBy(x => x).GetEnumerator();



            var userCollection = new List<User>();
            userCollection.Add(new User(1, "Kiska"));
            userCollection.Add(new User(2, "Krasotka"));
            userCollection.Add(new User(15, "MegaProger"));

            var atIndexUser = userCollection.ElementAt(19);
            var whereUser = userCollection.Where(x => x.Name.Length > 5).ToList();
            var skipUser = userCollection.Skip(2);

            var myConcatREsult = userCollection.MyConcatMethod(whereUser).Except(skipUser).ToList();
        }

    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastVisit { get; set; }

        public User (int id, string name)
        {
            Id = id;
            Name = name;
            LastVisit = DateTime.Now;
        }

        public void Visit(DateTime dateTime)
        {
            LastVisit = dateTime;
        }

    }
}
