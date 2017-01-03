using System;
namespace Program {
  public class Program{
      public static void Main() {
          string t = System.IO.File.ReadAllText("t");
          Console.WriteLine(t);
      }

      public static void Test(int[] a){
          a[0] = 100;
          Console.WriteLine(a[0]);
      }
  }
}