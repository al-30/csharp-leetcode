using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace csharp_leetcode.TwoSum
{
  public class SolutionTwoSum
  {
    public int[] TwoSum(int[] nums, int target)
    {
      Dictionary<int, int> addonMap = new Dictionary<int, int>();
      addonMap[target - nums[0]] = 0;

      int[] result = new int[2];

      for (int i = 1; i < nums.Length; i++)
      {
        int currentNumber = nums[i];
        if (addonMap.ContainsKey(currentNumber))
        {
          result[0] = addonMap[currentNumber];
          result[1] = i;
          break;
        }
        else
        {
          addonMap[target - currentNumber] = i;
        }
      }

      return result;
    }
  }
}