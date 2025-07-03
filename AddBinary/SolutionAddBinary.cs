using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.XPath;

namespace csharp_leetcode.AddBinary
{
  public class SolutionAddBinary
  {
    public string AddBinary(string a, string b)
    {
      StringBuilder response = new StringBuilder();

      int aLeng = a.Length - 1;
      int bLeng = b.Length - 1;
      int current = 0;

      while (aLeng >= 0 || bLeng >= 0 || current == 1)
      {
        int sum = 0;
        if (aLeng >= 0)
        {
          sum += int.Parse(a[aLeng].ToString());
        }
        if (bLeng >= 0)
        {
          sum += int.Parse(b[bLeng].ToString());

        }
        sum += current;

        switch (sum)
        {
          case 0:
            response.Insert(0, "0");
            current = 0;
            break;

          case 1:
            response.Insert(0, "1");
            current = 0;
            break;

          case 2:
            response.Insert(0, "0");
            current = 1;
            break;

          case 3:
            response.Insert(0, "1");
            current = 1;
            break;
        }
        aLeng--;
        bLeng--;
      }

      return response.ToString();
    }
  }
}
