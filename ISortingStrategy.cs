using System.Collections.Generic;

namespace Strategy
{
    public interface ISortingStrategy
    {
        void Sort<T>(List<T> dataToBeSorted);
    }
}
