using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class SearchAlr
    {
        static void Main(string[] args)
        {
            SearchAlr obj = new SearchAlr();
            int[] search_list = new int[] { 1, 3, 8, 18, 88, 99, 2, 55, 34, 44 };

            int target, resultLinear, resultBinary;

            Console.WriteLine("Enter the Target");
            target = Int32.Parse(Console.ReadLine());
            resultLinear = obj.Linear_search(search_list, target);

            if (resultLinear != -1)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("NOT Found");
            }


            resultBinary = obj.Binary_search((search_list), target);
            if (resultBinary != -1)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("NOT Found");
            }
        }


        int Linear_search(int[] list,int target)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == target)
                    return i;
            }
            return -1;
        }


        int Binary_search(int[] givenlist, int Target)
        {
            Array.Sort(givenlist);
            int first = 0;
            int last = givenlist.Length - 1;
            int middle = first;

            while (first < last)
            {
                middle = (first + last) / 2;

                if (Target == givenlist[middle])
                    return middle;
                else if (Target < givenlist[middle])
                    last = middle - 1;
                else
                    first = middle + 1;
            }
            return -1;

        }
    }
}
