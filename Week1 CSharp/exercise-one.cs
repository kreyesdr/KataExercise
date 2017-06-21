// Write function avg which calculates average of numbers in given list.
using System.Linq

class AverageSolution
{
  public static double FindAverage(double[] array)
  {

    if (array.Length < 1) 
    {
      return 0;
    }
    else 
    {
      double total = array.Sum();
      double arrayLength = array.Length;
      double averageOperation = total / arrayLength

      return averageOperation
    }
  }
} 


// 1. read about collections array methods
// 2. why we link LinQ methods?

// Things to learn
// 1. Lean about ?: operator (https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator)
// 2. Learn about Array c# methods and how to access them
// 3. LinQ Methods (Enumerable Methods https://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods(v=vs.110).aspx)
