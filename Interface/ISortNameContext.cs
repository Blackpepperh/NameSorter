using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NameSorter.Model;

namespace NameSorter.Interface
{
    public interface ISortNameContext
    {
        Person get();
        void add(Person person);


    }
}