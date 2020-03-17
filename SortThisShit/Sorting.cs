using System.Collections.Generic;

namespace SortThisShit
{
    public class Sorting
    {
        
        // Takes List and checks if sorted
        public static bool IsSorted(List<int> randList)
        {
            for (var i = 0; i < randList.Count - 1; i++)
                if (randList[i] >= randList[i + 1])
                    return false;

            return true;
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}