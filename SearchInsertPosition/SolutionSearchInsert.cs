namespace csharp_leetcode.SearchInsertPosition
{
  public class SolutionSearchInsert
  {
    public int SearchInsert(int[] nums, int target)
    {
      bool exist = Array.Exists(nums, number => number == target);

      if (exist)
      {
        return Array.FindIndex(nums, number => number == target);
      }
      else
      {
        for (int i = 0; i < nums.Length; i++)
        {
          if (nums[i] > target)
          {
            return i;
          }
        }
      }

      return nums.Length;
    }
  }
}
