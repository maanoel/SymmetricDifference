using System.Collections.Generic;
using System.Linq;

namespace SymmetricDifference
{
  public class SymmetricDifferenceCalculator
  {
    public int[] Sym(int[] valueOne, int[] valueTwo)
    {
      var difference = valueOne.Except(valueTwo).Concat(valueTwo.Except(valueOne));
      return difference.OrderBy(x => x).ToArray();
    }

    public int[] Sym(List<int[]> parameters)
    {
      int[] difference = null;

      for (int i = 0; i < parameters.Count() - 1; i++)
      {
        if (difference == null)
          difference = Sym(parameters[i], parameters[i + 1]);
        else
          difference = Sym(difference, parameters[i + 1]);
      }

      return difference;
    }
  }
}
