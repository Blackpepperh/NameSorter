using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameSorter.Model
{
    public class Person
    {
        public string[] Name {
            set;
            get;
        }

        public Person(string[] name){
            this.Name = name;
        }

        


    }
}