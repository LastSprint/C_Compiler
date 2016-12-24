/*

declare
  v_A int;
  v_A2 int;
  
  function f_B(p_B int)
  returns int
  is
    v_B int;

    procedure p_C
      v_C int;
    is
    begin
      v_A:=1;
      v_C:=1;
      v_B:=p_B+v_C;
    end;

  begin
    p_C;
    v_A:=v_A+3;
    return v_B*2;
  end;

begin
  v_A2:=read;
  if(f_B(3) > v_A2)
    write(100);
  else
    write(v_A);
end;

*/


using System;


public class Program
{
  class Inner
  {
    int v_A = 0;
    int v_A2 = 0;

    class f_B
    {
      Inner outer;
      int p_B;
      int v_B = 0;

      class p_C
      {
        f_B outer;
        int v_C = 0;

        public p_C(f_B outer) {
          this.outer = outer;
        }

        public void Execute() {
          outer.outer.v_A = 1;
          v_C = 1;
          outer.v_B = outer.p_B + v_C;
        }
      }

      public f_B(Inner outer) {
        this.outer = outer;
      }

      public int Execute(int p_B) {
        this.p_B = p_B;
        p_C p_C = new p_C(this);

        p_C.Execute();
        outer.v_A = outer.v_A + 3;
        return v_B * 2;
      }
    }

    public void Execute() {
      f_B f_B = new f_B(this);

      v_A2=int.Parse(Console.ReadLine());
      if(f_B.Execute(3) > v_A2)
        Console.WriteLine(100);
      else
        Console.WriteLine(v_A);
    }
  }

  public static void Main(string[] agrs) {
    Inner Inner = new Inner();
    Inner.Execute();
  }
}
