namespace csharp_leetcode.LengthofLastWord
{
  public class SolutionLengthofLastWord
  {
    public int LengthOfLastWord(string s)
    {
      int index = s.Length - 1;

      int count = 0;

      while (s[index] == ' ')
      {
        index--;
      }

      while (index >= 0 && s[index] != ' ')
      {
        count++;
        index--;
      }

      return count;
    }
  }
}
