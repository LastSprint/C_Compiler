/*

declare
  A int;
  B int;
  C int;

begin
  A:=1;
  B:=2;

  C:=A+B;
  C:=A-B;
  C:=A*B;
  C:=A/B;

  C:=A=B;
  C:=A<>B;
  C:=A>B;
  C:=A<B;
  C:=A>=B;
  C:=A<=B;
end;

*/


using System;


public class FL_Program
{
  public int A = 0;
  public int B = 0;
  public int C = 0;


  public void FL_Main() {
    A=1;
    B=2;

    C=A+B;
    C=A-B;
    C=A*B;
    C=A/B;

    C=Convert.ToInt32(A==B);
    C=Convert.ToInt32(A!=B);
    C=Convert.ToInt32(A>B);
    C=Convert.ToInt32(A<B);
    C=Convert.ToInt32(A>=B);
    C=Convert.ToInt32(A<=B);
  }


  public static void Main(string[] args) {
    (new FL_Program()).FL_Main();
  }
}
