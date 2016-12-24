using System;

public class Simple
{
  public static int Sum(int a, int b) {
    int c;
    c=a+b;
    return c;
  }

  public int Test(int a) {
    return a;
  }  

  public static void Main() {
    int result=Sum(3, 5);
    Console.WriteLine(result);

    Simple s = new Simple();
    s.Test(5);
  }
}
