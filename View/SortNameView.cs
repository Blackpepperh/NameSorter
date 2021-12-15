using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NameSorter.Controller;

namespace NameSorter.View
{
    public class SortNameView
    {

        private SortNameService sortNameSvc;

        public SortNameView(SortNameService sortNameSvc)
        {
            this.sortNameSvc = sortNameSvc;
        }

        public void showNameSorter(){
            sortNameSvc.getPerson();
        }
    }
}