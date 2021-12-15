using System;
using System.Collections.Generic;
using NameSorter.Interface;
using NameSorter.Model;

namespace NameSorter.Controller
{
    public class SortNameContext : ISortNameContext
    {
        List<Person> data = new List<Person>();
        public void add(Person person)
        {
          System.IO.File.WriteAllLines("sorted-names-list.txt", person.Name);
        }

        public Person get()
        {
            string[] data = System.IO.File.ReadAllLines("unsorted-names-list.txt");
            Person person = new Person(data);

            return person;
        }
    }

}