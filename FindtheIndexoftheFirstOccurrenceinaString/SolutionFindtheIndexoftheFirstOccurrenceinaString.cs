namespace csharp_leetcode.FindtheIndexoftheFirstOccurrenceinaString
{
  public class SolutionFindtheIndexoftheFirstOccurrenceinaString
  {
    public int StrStr(string haystack, string needle)
    {
      if (needle.Length > haystack.Length)
      {
        return -1;
      }

      for (int i = 0; i < haystack.Length; i++)
      {
        int index = i;
        int startHay = i;
        int startNeedle = 0;

        while (startNeedle < needle.Length && startHay < haystack.Length)
        {
          if (haystack[startHay] != needle[startNeedle])
          {
            break;
          }
          startHay++;
          startNeedle++;
        }

        if (startNeedle == needle.Length)
        {
          return index;
        }

      }

      return -1;
    }
  }
}
