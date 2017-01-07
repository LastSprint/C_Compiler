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
.field private static int32 length
.field private static int32[] a
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
  .method public hidebysig static void  sort(	int32[] mas,
	int32 size
) cil managed
  {
.locals init (	 [0] int32 temp,
	 [1] int32 i,
	 [2] int32 j
)

IL_0:	ldc.i4	0
IL_1:	stloc	1
IL_2:	br	IL_46
IL_3:	ldloc	1
IL_4:	ldc.i4	1
IL_5:	add
IL_6:	stloc	2
IL_7:	br	IL_38
IL_8:	ldarg	0
IL_9:	ldloc	1
IL_10:	ldelem.i4
IL_11:	ldarg	0
IL_12:	ldloc	2
IL_13:	ldelem.i4
IL_14:	cgt
IL_15:		brfalse	IL_34
IL_16:	ldarg	0
IL_17:	ldloc	1
IL_18:	ldelem.i4
IL_19:	stloc	0
IL_23:	ldarg	0
IL_24:	ldloc	1
IL_25:	ldarg	0
IL_26:	ldloc	2
IL_27:	ldelem.i4
IL_28:	stelem.i4
IL_30:	ldarg	0
IL_31:	ldloc	2
IL_32:	ldloc	0
IL_33:	stelem.i4


IL_34:	ldloc	2
IL_35:	ldc.i4	1
IL_36:	add
IL_37:	stloc	2
IL_38:	ldloc	2
IL_39:	ldarg	1
IL_40:	clt
IL_41:		brtrue	IL_8
IL_42:	ldloc	1
IL_43:	ldc.i4	1
IL_44:	add
IL_45:	stloc	1
IL_46:	ldloc	1
IL_47:	ldarg	1
IL_48:	clt
IL_49:		brtrue	IL_3
IL_50:	ret

}
  .method public hidebysig static void  Main() cil managed
  {
    .entrypoint
    .language '{3F5162F8-07C6-11D3-9053-00C04FA302A1}', '{994B45C4-E6E9-11D2-903F-00C04FA302A1}', '{5A869D0B-6611-11D3-BD2A-0000F80849BD}'
.locals init (	 [0] int32 i
)
IL_0:	ldc.i4	5
IL_1:	newarr [mscorlib]System.Int32
IL_2:	stsfld	int32[] Program.Program::a	

IL_3:	ldc.i4	5
IL_4:	stsfld	int32 Program.Program::length
IL_5:	ldc.i4	0
IL_6:	stloc	0
IL_7:	br	IL_21
IL_11:	ldsfld	int32[] Program.Program::a
IL_12:	ldloc	0
IL_13:	ldsfld	int32 Program.Program::length
IL_14:	ldloc	0
IL_15:	sub
IL_16:	stelem.i4
IL_17:	ldloc	0
IL_18:	ldc.i4	1
IL_19:	add
IL_20:	stloc	0
IL_21:	ldloc	0
IL_22:	ldsfld	int32 Program.Program::length
IL_23:	clt
IL_24:		brtrue	IL_11
IL_25:	ldstr	"Input:"
IL_26:	call	void [mscorlib]System.Console::WriteLine(string)
IL_27:	ldsfld	int32[] Program.Program::a
IL_28:	ldsfld	int32 Program.Program::length
IL_29:	call	void Program.Program::printArr(int32[], int32)
IL_30:	call	void [mscorlib]System.Console::WriteLine()
IL_31:	ldsfld	int32[] Program.Program::a
IL_32:	ldsfld	int32 Program.Program::length
IL_33:	call	void Program.Program::sort(int32[], int32)
IL_34:	ldstr	"Output:"
IL_35:	call	void [mscorlib]System.Console::WriteLine(string)
IL_36:	ldsfld	int32[] Program.Program::a
IL_37:	ldsfld	int32 Program.Program::length
IL_38:	call	void Program.Program::printArr(int32[], int32)
IL_39:	call	string [mscorlib]System.Console::ReadLine()
IL_40:	ret

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

