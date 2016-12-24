using System;

namespace A {

public class A {
  private static int a = 100;

  public void test() {
    Console.WriteLine(a);
  }

  public static void Main() {
    (new A()).test();
  } 
}

}