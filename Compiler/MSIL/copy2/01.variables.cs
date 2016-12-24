/*

declare
  C constant int  :=0;

  A int;
  B int;

  function F(P1 in int, P2 in out int, P3 out int) returns int
  is
    D int;
  begin
    D:=P1+P2;
    P3:=D;
    P2:=P1;

    return C;
  end;


begin
  B:=2;
  print F(1, B, A);
  print A;
  print B;
end;

*/


using System;


public class FL_Program
{
  public const int C = 0;

  public int A = 0;
  public int B = 0;


  public int F(int P1, ref int P2, out int P3) {
    int D = 0;
    D = P1 + P2;
    P3 = D;
    P2 = P1;

    return C;
  }


  public void FL_Main() {
    B = 2;
    Console.WriteLine(F(1, ref B, out A));
    Console.WriteLine(A);
    Console.WriteLine(B);
  }


  public static void Main(string[] args) {
    (new FL_Program()).FL_Main();
  }
}
