namespace csharp_leetcode.LongestCommonPrefix
{
  public class SolutionLongestCommonPrefix
  {
    public string LongestCommonPrefix(string[] strs)
    {
      Array.Sort(strs, (a, b) => a.Length.CompareTo(b.Length));
     
      string result = "";
      string firstWord = strs[0];

      for (int i = 0; i < firstWord.Length; i++)
      {
        for (int j = 1; j < strs.Length; j++)
        {
          if (strs[j][i] != firstWord[i])
          {
            return result;
          }
        }
        result += firstWord[i];
      }
      return result;
    }
  }
}
