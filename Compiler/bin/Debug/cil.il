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
  .method public hidebysig static void  printArr(	int32[] a,
	int32 arrLength
) cil managed
  {
.locals init (	 [0] int32 i
)

IL_0:	ldc.i4	0
IL_1:	stloc	0
IL_2:	br	IL_11
IL_3:	ldarg	0
IL_4:	ldloc	0
IL_5:	ldelem.i4
IL_6:	call	void [mscorlib]System.Console::WriteLine(int32)
IL_7:	ldloc	0
IL_8:	ldc.i4	1
IL_9:	add
IL_10:	stloc	0
IL_11:	ldloc	0
IL_12:	ldarg	1
IL_13:	clt
IL_14:		brtrue	IL_3
IL_15:	ret

}
  .method public hidebysig static int32  max(	int32[] a,
	int32 arrLength
) cil managed
  {
.locals init (	 [0] int32 max,
	 [1] int32 memMax,
	 [2] int32 i
)

IL_0:	ldc.i4	-100000
IL_1:	stloc	0
IL_2:	ldc.i4	0
IL_3:	stloc	2
IL_4:	br	IL_21
IL_5:	ldarg	0
IL_6:	ldloc	2
IL_7:	ldelem.i4
IL_8:	ldloc	0
IL_9:	cgt
IL_10:		brfalse	IL_17
IL_11:	ldarg	0
IL_12:	ldloc	2
IL_13:	ldelem.i4
IL_14:	stloc	1
IL_15:	ldloc	1
IL_16:	stloc	0


IL_17:	ldloc	2
IL_18:	ldc.i4	1
IL_19:	add
IL_20:	stloc	2
IL_21:	ldloc	2
IL_22:	ldarg	1
IL_23:	clt
IL_24:		brtrue	IL_5
IL_25:	ldloc	1
IL_26:	ret

}
  .method public hidebysig static int32  min(	int32[] a,
	int32 arrLength
) cil managed
  {
.locals init (	 [0] int32 min,
	 [1] int32 memMin,
	 [2] int32 i
)

IL_0:	ldc.i4	100000
IL_1:	stloc	0
IL_2:	ldc.i4	0
IL_3:	stloc	2
IL_4:	br	IL_21
IL_5:	ldarg	0
IL_6:	ldloc	2
IL_7:	ldelem.i4
IL_8:	ldloc	0
IL_9:	clt
IL_10:		brfalse	IL_17
IL_11:	ldarg	0
IL_12:	ldloc	2
IL_13:	ldelem.i4
IL_14:	stloc	1
IL_15:	ldloc	1
IL_16:	stloc	0


IL_17:	ldloc	2
IL_18:	ldc.i4	1
IL_19:	add
IL_20:	stloc	2
IL_21:	ldloc	2
IL_22:	ldarg	1
IL_23:	clt
IL_24:		brtrue	IL_5
IL_25:	ldloc	1
IL_26:	ret

}
  .method public hidebysig static void  Main() cil managed
  {
    .entrypoint
    .language '{3F5162F8-07C6-11D3-9053-00C04FA302A1}', '{994B45C4-E6E9-11D2-903F-00C04FA302A1}', '{5A869D0B-6611-11D3-BD2A-0000F80849BD}'
.locals init (	 [0] int32 length,
	 [1] int32[] a,
	 [2] int32 i
)

IL_0:	ldc.i4	5
IL_1:	stloc	0
IL_2:	ldloc	0
IL_3:	newarr [mscorlib]System.Int32
IL_4:	stloc	1
IL_5:	ldc.i4	0
IL_6:	stloc	2
IL_7:	br	IL_21
IL_11:	ldloc	1
IL_12:	ldloc	2
IL_13:	ldloc	0
IL_14:	ldloc	2
IL_15:	sub
IL_16:	stelem.i4
IL_17:	ldloc	2
IL_18:	ldc.i4	1
IL_19:	add
IL_20:	stloc	2
IL_21:	ldloc	2
IL_22:	ldloc	0
IL_23:	clt
IL_24:		brtrue	IL_11
IL_25:	ldstr	"Input:"
IL_26:	call	void [mscorlib]System.Console::WriteLine(string)
IL_27:	ldloc	1
IL_28:	ldloc	0
IL_29:	call	void Program.Program::printArr(int32[], int32)
IL_30:	call	void [mscorlib]System.Console::WriteLine()
IL_31:	ldstr	"Min: "
IL_32:	ldloc	1
IL_33:	ldloc	0
IL_34:	call	int32 Program.Program::min(int32[], int32)
IL_35:	call	string [mscorlib]System.Convert::ToString(int32)
IL_36:	call	string [mscorlib]System.String::Concat(string, string)
IL_37:	call	void [mscorlib]System.Console::WriteLine(string)
IL_38:	ldstr	"Max: "
IL_39:	ldloc	1
IL_40:	ldloc	0
IL_41:	call	int32 Program.Program::max(int32[], int32)
IL_42:	call	string [mscorlib]System.Convert::ToString(int32)
IL_43:	call	string [mscorlib]System.String::Concat(string, string)
IL_44:	call	void [mscorlib]System.Console::WriteLine(string)
IL_45:	call	string [mscorlib]System.Console::ReadLine()
IL_46:	ret

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

