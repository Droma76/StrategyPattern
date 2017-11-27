using System.Collections.Generic;

namespace Strategy.SortingStrategies
{
    public interface ISortingStrategy
    {
        void Sort<T>(List<T> dataToBeSorted);
    }
}
