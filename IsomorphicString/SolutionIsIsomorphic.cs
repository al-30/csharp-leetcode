using System.Security.Cryptography.X509Certificates;

namespace csharp_leetcode.IsomorphicString
{
  public class SolutionIsIsomorphic
  {
    public bool IsIsomorphic(string s, string t)
    {
      Dictionary<char, char> map = new Dictionary<char, char>();
      for (int i = 0; i < s.Length; i++)
      {
        if (map.ContainsKey(s[i]))
        {
          if (map[s[i]] == t[i])
          {
            continue;
          }
          else
          {
            return false;
          }
        }

        if (map.ContainsValue(t[i]))
        {
          return false;
        }
        map.Add(s[i], t[i]);
      }
      return true;
    }
  }
}
