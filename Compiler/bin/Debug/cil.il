// Metadata version: v2.0.50727
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 2:0:0:0
}
.assembly '1'
{

  // --- ��������� ������������� ������� �������� �������������, �� ������� �������� �������������� � ����������� -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 03 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                                                                                                                                                                63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module '1.exe'
// MVID: {FA2EB12D-6EB8-496A-8ED5-78730BD1360D}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x01930000
.class public auto ansi beforefieldinit Program.Program
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Main() cil managed
  {
    .entrypoint
    .language '{3F5162F8-07C6-11D3-9053-00C04FA302A1}', '{994B45C4-E6E9-11D2-903F-00C04FA302A1}', '{5A869D0B-6611-11D3-BD2A-0000F80849BD}'
.locals init (	 [0] int32[] a,
	 [1] int32[] b
)
IL_0:	ldc.i4	5
IL_1:	newarr [mscorlib]System.Int32
IL_2:	stloc	0
IL_3:	ldc.i4	5
IL_4:	newarr [mscorlib]System.Int32
IL_5:	stloc	1
IL_7:	ldloc	0
IL_8:	ldc.i4	1
IL_9:	ldc.i4	5
IL_10:	stelem.i4
IL_14:	ldloc	0
IL_15:	stloc	0

IL_16:	ldloc	1
IL_17:	ldc.i4	1
IL_18:	ldelem.i4
IL_19:	call	void [mscorlib]System.Console::WriteLine(int32)
IL_20:	ret

}

.method public hidebysig specialname rtspecialname instance void 
          .ctor() cil managed
  {
    // ������ ����:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  }

}

