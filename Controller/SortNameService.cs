using System;
using System.Collections.Generic;
using System.Linq;
using NameSorter.Interface;
using NameSorter.Model;

namespace NameSorter.Controller
{
    public class SortNameService : ISortNameService
    {
        private SortNameContext context;

        public SortNameService(SortNameContext context)
        {
            this.context = context;
        }


        public void getPerson()
        {
            Person person = context.get();
            List<KeyValuePair<string, string>> listName = new List<KeyValuePair<string, string>>();

            foreach (var item in person.Name)
            {
                string[] devidedName = item.Split(" ");
                listName.Add(new KeyValuePair<string, string>(devidedName[devidedName.Length - 1], item));
            }

            addSortedPersonName(listName);
            getSortedPersonName(listName);
        }

        public void getSortedPersonName(List<KeyValuePair<string, string>> listName){
            foreach (var item in listName.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Value);
            }
        }

        public void addSortedPersonName(List<KeyValuePair<string, string>> listName)
        {
            string[] data = listName.OrderBy(x => x.Key).Select(x => x.Value).ToArray();
            Person person = new Person(data);
            context.add(person);

        }


    }
}