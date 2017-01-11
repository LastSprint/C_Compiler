using System;
namespace Program {
  public class Program{
      public static void Main() {
          string t = "str";
          string t1 = "str2";

          if(t == t1){
              Console.WriteLine("sdf");
          }
      }

      public static void Test(int[] a){
          a[0] = 100;
          Console.WriteLine(a[0]);
      }
  }
}