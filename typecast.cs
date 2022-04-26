using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myInt = 9;
      double myDouble = myInt;  // Automatic casting: int to double

      Console.WriteLine(myInt);
      Console.WriteLine(myDouble);
    }
  }
}
