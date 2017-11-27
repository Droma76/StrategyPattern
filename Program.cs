using System.Collections.Generic;
using Strategy.SortingStrategies;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ISortingStrategy sortingStrategy = null;

            //Sorting the countyResidents
            List<string> countyResidents = new List<string> { "ad", "ac", "ax", "zw" };
            sortingStrategy = GetSortingOption(ObjectToSort.CountyResidents);
            sortingStrategy.Sort(countyResidents);

            //Sorting student numbers

            List<int> studentNumbers = new List<int> { 123, 678, 543, 189 };
            sortingStrategy = GetSortingOption(ObjectToSort.StudentNumber);
            sortingStrategy.Sort(studentNumbers);


            //Sorting railway passengers      
            List<string> railwayPassengers = new List<string> { "A21", "Z2", "F3", "G43" };
            sortingStrategy = GetSortingOption(ObjectToSort.RailwayPassengers);
            sortingStrategy.Sort(railwayPassengers);

        }

        private static ISortingStrategy GetSortingOption(ObjectToSort objectToSort)
        {
            ISortingStrategy sortingStrategy = null;

            switch (objectToSort)
            {
                case ObjectToSort.StudentNumber:
                    sortingStrategy = new MergeSort();
                    break;
                case ObjectToSort.RailwayPassengers:
                    sortingStrategy = new HeapSort();
                    break;
                case ObjectToSort.CountyResidents:
                    sortingStrategy = new QuickSort();
                    break;
                default:
                    break;
            }
            return sortingStrategy;
        }
    }
}
