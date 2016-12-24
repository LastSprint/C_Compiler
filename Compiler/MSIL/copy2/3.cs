using System;

public class Program
{

  public static void Main() {
    int a, b, c;
    a = new Random().Next(2);
    b = new Random().Next(1) + 1;
    c = new Random().Next(1);

    if (a != 0)
		Console.WriteLine(b);
    else
		Console.WriteLine(c);

    if (a == 0)
		Console.WriteLine(b);
    else
		Console.WriteLine(c);
  }
}
