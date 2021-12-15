using NameSorter.Controller;
using NameSorter.View;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {

            // string filename = "unsorted-names-list.txt";
            //     sortName(filename);
            SortNameContext context = new SortNameContext();
            SortNameService sortNameSvc = new SortNameService(context);
            SortNameView view = new SortNameView(sortNameSvc);

            view.showNameSorter();

            // getSortedNameTest();


        }

        // static void getSortedNameTest()
        // {
        //     // string fileName = "unsorted-names-list.txt";
        //     SortNameContext context = new SortNameContext();
        //     SortNameService sortNameSvc = new SortNameService(context);
        //     sortNameSvc.getPerson();
        // }


        // static void sortName(string filename){

        //     string[] tempFile = System.IO.File.ReadAllLines(filename);
        //     // SortedDictionary<string, string> dictionaryOfName = new SortedDictionary<string, string>();
        //     List<KeyValuePair<string, string>> listOfName = new List<KeyValuePair<string, string>>();

        //     foreach (var item in tempFile)
        //     {
        //         string[] devidedName = item.Split(" ");
        //         listOfName.Add(new KeyValuePair<string, string>(devidedName[devidedName.Length - 1], item));

        //     }

        //    foreach (var name in listOfName.OrderBy(x=> x.Key))
        //    {
        //        Console.WriteLine(name.Value);
        //    } 
        // }
    }
}
