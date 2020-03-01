using LinkedList;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person { Id = 1, Name = "Rijvy" };
            var person2 = new Person { Id = 2, Name = "Lal" };
            var person3 = new Person { Id = 3, Name = "Arko" };
            var person4 = new Person { Id = 4, Name = "Sifat" };
            var person5 = new Person { Id = 5, Name = "Kajol" };
            var person6 = new Person { Id = 6, Name = "Angon" };


            LinkedList<Person> person = new LinkedList<Person>();

            person.AddLast(person1);
            person.AddLast(person2);
            person.AddLast(person3);
            person.AddLast(person4);
            person.AddLast(person5);
            person.AddLast(person6);

            person.Reverse();

            Person[] people = person.ToArray();

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].Name);
            }

            Console.WriteLine(person.Contains(person1));

            Console.WriteLine(person.IndexOf(person1));

            person.DeleteFirst();

            Console.WriteLine(person.Contains(person1));
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
