using SymmetricDifference;
using System;
using System.Linq;
using Xunit;

namespace TestProject
{
  public class UnitTest1
  {
    [Fact]
    public void Should_Return_345()
    {
      SymmetricDifferenceCalculator calculator = new SymmetricDifferenceCalculator();

      int[] valueOne = new int[] { 1, 2, 3 };
      int[] valueTwo = new int[] { 5, 2, 1, 4 };

      var difference = calculator.Sym(valueOne, valueTwo);
      int[] testedValue = new int[] { 3, 4, 5 };

      Assert.True(testedValue.SequenceEqual(difference));
    }

    [Fact]
    public void Should_Contain_Only_Three_Elements()
    {
      SymmetricDifferenceCalculator calculator = new SymmetricDifferenceCalculator();

      int[] valueOne = new int[] { 1, 2, 3 };
      int[] valueTwo = new int[] { 5, 2, 1, 4 };

      var difference = calculator.Sym(valueOne, valueTwo);
      int testedValue = difference.Count();

      Assert.True(testedValue == 3);
    }

    [Fact]
    public void Should_Return_345_When()
    {
      SymmetricDifferenceCalculator calculator = new SymmetricDifferenceCalculator();

      int[] valueOne = new int[] { 1, 2, 3, 3 };
      int[] valueTwo = new int[] { 5, 2, 1, 4 };

      var difference = calculator.Sym(valueOne, valueTwo);
      int[] testedValue = new int[] { 3, 4, 5 };

      Assert.True(testedValue.SequenceEqual(difference));
    }
  }
}
