using System;
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
  }
}
