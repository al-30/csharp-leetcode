using System.Globalization;
using System.Numerics;
using System.Xml.XPath;

namespace csharp_leetcode.PlusOne
{
  public class SolutionPlusOne
  {
    public int[] PlusOne(int[] digits)
    {
      int plusOne = 0;

      for (int i = digits.Length - 1; i >= 0; i--)
      {
        if (digits[i] + 1 == 10)
        {
          digits[i] = 0;
          plusOne = 1;
        }
        else
        {
          digits[i] += 1;
          return digits;
        }
      }

      if (plusOne == 1)
      {
        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        Array.Copy(digits, 0, result, 1, digits.Length);
        return result;
      }
      return digits;
    }
  }
}
