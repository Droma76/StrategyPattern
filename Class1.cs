using System;

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

    public enum ObjectToSort
    {
        StudentNumber,
        RailwayPassengers,
        CountyResidents
    }

    public interface ISortingStrategy
    {
        void Sort<T>(List<T> dataToBeSorted);
    }

    public class QuickSort : ISortingStrategy
    {
        #region ISortingStrategy Members
        public void Sort<T>(List<T> dataToBeSorted)
        {
            //Logic for quick sort
        }
        #endregion
    }

    public class MergeSort : ISortingStrategy
    {
        #region ISortingStrategy Members
        public void Sort<T>(List<T> dataToBeSorted)
        {
            //Logic for Merge sort
        }
        #endregion
    }

    public class HeapSort : ISortingStrategy
    {
        #region ISortingStrategy Members
        public void Sort<T>(List<T> dataToBeSorted)
        {
            //Logic for Heap sort
        }
        #endregion
    }
}
