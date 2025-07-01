namespace csharp_leetcode.ValidParentheses
{
  public class SolutionValidParentheses
  {
    public bool IsValid(string s)
    {
      List<char> openParentheses = new List<char>();

      for (int i = 0; i < s.Length; i++)
      {
        if (s[i] == '(' || s[i] == '[' || s[i] == '{')
        {
          openParentheses.Add(s[i]);
        }
        else
        {
          if (openParentheses.Count <= 0)
          {
            return false;
          }

          int lastIindex = openParentheses.Count - 1;
          char lastChar = openParentheses[lastIindex];

          switch (s[i])
          {
            case ')':
              if (lastChar == '(')
              {
                openParentheses.RemoveAt(lastIindex);
              }
              else
              {
                return false;
              }
              break;

            case ']':
              if (lastChar == '[')
              {
                openParentheses.RemoveAt(lastIindex);
              }
              else
              {
                return false;
              }
              break;

            case '}':
              if (lastChar == '{')
              {
                openParentheses.RemoveAt(lastIindex);
              }
              else
              {
                return false;
              }
              break;

            default: return false;
          }
        }
      }

      return openParentheses.Count <= 0;
    }
  }
}
