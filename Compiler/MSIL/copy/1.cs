using System;
namespace Program {
  public class Program{
      public static void Main() {
          int[] a = new int[10];
          a[0] = 100;
          Test(a);
      }

      public static void Test(int[] a){
          a[0] = 100;
          Console.WriteLine(a[0]);
      }
  }
}