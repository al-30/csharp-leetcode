using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_leetcode.RemoveDuplicatesFromSortedArray
{
  public class SolutionRemoveDuplicates
  {
    public int RemoveDuplicates(int[] nums)
    {
      int uniquesNumbers = nums.Length;
      int last = 0;

      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] != nums[last])
        {
          nums[++last] = nums[i];
        }
        else
        {
          uniquesNumbers--;
        }


      }
      return uniquesNumbers;
    }
  }
}
