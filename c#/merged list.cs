using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merged_list
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int> { 4, 5, 6 };

            List<int> mergedList = MergeLists(list1, list2);

            Console.WriteLine("Merged List: " + string.Join(", ", mergedList));
            Console.Read();
        }


        static List<int> MergeLists(List<int> list1, List<int> list2)
        {
            List<int> mergedList = new List<int>(list1);
            mergedList.AddRange(list2);
            return mergedList;

        }   
    }
}

