using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Routines
{
    class Program
    {

        static void Main(string[] args)
        {
            int iMenuSelection = 0;

            Console.WriteLine(iMenuSelection);
            Console.WriteLine("Options:");
            Console.WriteLine("1) Bubble Sort");
            Console.WriteLine("2) TBD");
            Console.WriteLine("3) TBD");
            Console.WriteLine("4) TBD");
            Console.WriteLine("5) TBD");

            iMenuSelection = int.Parse(Console.ReadLine());

            switch(iMenuSelection)
            {
                case 1:
                    BubbleSort();
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }

        static void BubbleSort()
        {

            int[] iNumberList = new int[10];
            int temp = 0;

            Console.WriteLine("Enter Bubble Sort Routine:");
            Console.WriteLine("Gathering List...");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter value for list item number: " + i);
                iNumberList[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Display Captured Numbers...");
            foreach (int i in iNumberList)
                Console.WriteLine(i);
            Console.WriteLine("Sorting Array...");

            for (int write  = 0; write < iNumberList.Length - 1; write++)
            {
                for (int sort = 0; sort < iNumberList.Length - 1; sort++)
                {
                    if (iNumberList[sort] > iNumberList[sort +1])
                    {
                        temp = iNumberList[sort + 1];
                        iNumberList[sort + 1] = iNumberList[sort];
                        iNumberList[sort] = temp;
                    }
                }
            }

            //Array.Sort(iNumberList);

            Console.WriteLine("Display Sorted Numbers...");
            foreach (int i in iNumberList)
                Console.WriteLine(i);
                       
        }

    }
}
