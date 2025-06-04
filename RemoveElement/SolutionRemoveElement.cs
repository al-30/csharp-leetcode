using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_leetcode.RemoveElement
{
  public class SolutionRemoveElement
  {
    public int RemoveElement(int[] nums, int val)
    {
      int lastIndexValid = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] != val)
        {
          nums[lastIndexValid] = nums[i];
          lastIndexValid++;
        }
      }
      return lastIndexValid;

    }
  }
}
