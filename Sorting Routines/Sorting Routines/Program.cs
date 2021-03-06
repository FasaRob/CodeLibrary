﻿using System;
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
            int iTempValue = 0;

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
            for (int iListPlacement = 0; iListPlacement < iNumberList.Length - 1; iListPlacement++)
            {
                for (int iSubListPlacement = 0; iSubListPlacement < iNumberList.Length - 1; iSubListPlacement++)
                {
                    if (iNumberList[iSubListPlacement] > iNumberList[iSubListPlacement + 1])
                    {
                        iTempValue = iNumberList[iSubListPlacement + 1];
                        iNumberList[iSubListPlacement + 1] = iNumberList[iSubListPlacement];
                        iNumberList[iSubListPlacement] = iTempValue;
                    }
                }
            }

            Console.WriteLine("Display Sorted Numbers...");
            foreach (int i in iNumberList)
                Console.WriteLine(i);
                       
        }

    }
}
