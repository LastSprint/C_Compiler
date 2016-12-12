// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2016-12-13 00:01:55

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace Lang2
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class Lang2Lexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__48=48;
	public const int T__49=49;
	public const int T__50=50;
	public const int T__51=51;
	public const int T__52=52;
	public const int T__53=53;
	public const int T__54=54;
	public const int PROGRAM=4;
	public const int VAR_DECL=5;
	public const int METH_CALL=6;
	public const int CALL_ARGS=7;
	public const int ARR_DECL=8;
	public const int ARR_CALL=9;
	public const int IF=10;
	public const int BODY=11;
	public const int FOR=12;
	public const int WHILE=13;
	public const int DO=14;
	public const int INC=15;
	public const int DEC=16;
	public const int METH_DECL=17;
	public const int DECL_ARGS=18;
	public const int RET_TYPE_SINGLE=19;
	public const int RET_TYPE_ARR=20;
	public const int RETURN=21;
	public const int TINT=22;
	public const int TFLOAT=23;
	public const int TSTRING=24;
	public const int TCHAR=25;
	public const int TBOOL=26;
	public const int TVOID=27;
	public const int OP_END=28;
	public const int INT=29;
	public const int DOUBLE=30;
	public const int CHAR=31;
	public const int STRING=32;
	public const int WS=33;
	public const int ADD=34;
	public const int SUB=35;
	public const int MULT=36;
	public const int DIV=37;
	public const int ASS=38;
	public const int DISJ=39;
	public const int CONJ=40;
	public const int IS_MORE=41;
	public const int IS_LESS=42;
	public const int IS_EQUALLY=43;
	public const int INVERT=44;
	public const int IS_LESS_OR_EQUAL=45;
	public const int IS_MORE_OR_EQUAL=46;
	public const int ID=47;

    // delegates
    // delegators

	public Lang2Lexer()
	{
		OnCreated();
	}

	public Lang2Lexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public Lang2Lexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "Lang2.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 1);
		TraceIn("IF", 1);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// Lang2.g:9:4: ( 'if' )
			DebugEnterAlt(1);
			// Lang2.g:9:6: 'if'
			{
			DebugLocation(9, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 1);
			LeaveRule("IF", 1);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 2);
		TraceIn("FOR", 2);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// Lang2.g:10:5: ( 'for' )
			DebugEnterAlt(1);
			// Lang2.g:10:7: 'for'
			{
			DebugLocation(10, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 2);
			LeaveRule("FOR", 2);
			Leave_FOR();
		}
	}
	// $ANTLR end "FOR"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 3);
		TraceIn("WHILE", 3);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// Lang2.g:11:7: ( 'while' )
			DebugEnterAlt(1);
			// Lang2.g:11:9: 'while'
			{
			DebugLocation(11, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 3);
			LeaveRule("WHILE", 3);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 4);
		TraceIn("DO", 4);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// Lang2.g:12:4: ( 'do' )
			DebugEnterAlt(1);
			// Lang2.g:12:6: 'do'
			{
			DebugLocation(12, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 4);
			LeaveRule("DO", 4);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_RETURN();
	partial void Leave_RETURN();

	// $ANTLR start "RETURN"
	[GrammarRule("RETURN")]
	private void mRETURN()
	{
		Enter_RETURN();
		EnterRule("RETURN", 5);
		TraceIn("RETURN", 5);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// Lang2.g:13:8: ( 'return' )
			DebugEnterAlt(1);
			// Lang2.g:13:10: 'return'
			{
			DebugLocation(13, 10);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 5);
			LeaveRule("RETURN", 5);
			Leave_RETURN();
		}
	}
	// $ANTLR end "RETURN"

	partial void Enter_TINT();
	partial void Leave_TINT();

	// $ANTLR start "TINT"
	[GrammarRule("TINT")]
	private void mTINT()
	{
		Enter_TINT();
		EnterRule("TINT", 6);
		TraceIn("TINT", 6);
		try
		{
			int _type = TINT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:14:6: ( 'int' )
			DebugEnterAlt(1);
			// Lang2.g:14:8: 'int'
			{
			DebugLocation(14, 8);
			Match("int"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TINT", 6);
			LeaveRule("TINT", 6);
			Leave_TINT();
		}
	}
	// $ANTLR end "TINT"

	partial void Enter_TFLOAT();
	partial void Leave_TFLOAT();

	// $ANTLR start "TFLOAT"
	[GrammarRule("TFLOAT")]
	private void mTFLOAT()
	{
		Enter_TFLOAT();
		EnterRule("TFLOAT", 7);
		TraceIn("TFLOAT", 7);
		try
		{
			int _type = TFLOAT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:15:8: ( 'float' )
			DebugEnterAlt(1);
			// Lang2.g:15:10: 'float'
			{
			DebugLocation(15, 10);
			Match("float"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TFLOAT", 7);
			LeaveRule("TFLOAT", 7);
			Leave_TFLOAT();
		}
	}
	// $ANTLR end "TFLOAT"

	partial void Enter_TSTRING();
	partial void Leave_TSTRING();

	// $ANTLR start "TSTRING"
	[GrammarRule("TSTRING")]
	private void mTSTRING()
	{
		Enter_TSTRING();
		EnterRule("TSTRING", 8);
		TraceIn("TSTRING", 8);
		try
		{
			int _type = TSTRING;
			int _channel = DefaultTokenChannel;
			// Lang2.g:16:9: ( 'string' )
			DebugEnterAlt(1);
			// Lang2.g:16:11: 'string'
			{
			DebugLocation(16, 11);
			Match("string"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TSTRING", 8);
			LeaveRule("TSTRING", 8);
			Leave_TSTRING();
		}
	}
	// $ANTLR end "TSTRING"

	partial void Enter_TCHAR();
	partial void Leave_TCHAR();

	// $ANTLR start "TCHAR"
	[GrammarRule("TCHAR")]
	private void mTCHAR()
	{
		Enter_TCHAR();
		EnterRule("TCHAR", 9);
		TraceIn("TCHAR", 9);
		try
		{
			int _type = TCHAR;
			int _channel = DefaultTokenChannel;
			// Lang2.g:17:7: ( 'char' )
			DebugEnterAlt(1);
			// Lang2.g:17:9: 'char'
			{
			DebugLocation(17, 9);
			Match("char"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TCHAR", 9);
			LeaveRule("TCHAR", 9);
			Leave_TCHAR();
		}
	}
	// $ANTLR end "TCHAR"

	partial void Enter_TBOOL();
	partial void Leave_TBOOL();

	// $ANTLR start "TBOOL"
	[GrammarRule("TBOOL")]
	private void mTBOOL()
	{
		Enter_TBOOL();
		EnterRule("TBOOL", 10);
		TraceIn("TBOOL", 10);
		try
		{
			int _type = TBOOL;
			int _channel = DefaultTokenChannel;
			// Lang2.g:18:7: ( 'bool' )
			DebugEnterAlt(1);
			// Lang2.g:18:9: 'bool'
			{
			DebugLocation(18, 9);
			Match("bool"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TBOOL", 10);
			LeaveRule("TBOOL", 10);
			Leave_TBOOL();
		}
	}
	// $ANTLR end "TBOOL"

	partial void Enter_TVOID();
	partial void Leave_TVOID();

	// $ANTLR start "TVOID"
	[GrammarRule("TVOID")]
	private void mTVOID()
	{
		Enter_TVOID();
		EnterRule("TVOID", 11);
		TraceIn("TVOID", 11);
		try
		{
			int _type = TVOID;
			int _channel = DefaultTokenChannel;
			// Lang2.g:19:7: ( 'void' )
			DebugEnterAlt(1);
			// Lang2.g:19:9: 'void'
			{
			DebugLocation(19, 9);
			Match("void"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TVOID", 11);
			LeaveRule("TVOID", 11);
			Leave_TVOID();
		}
	}
	// $ANTLR end "TVOID"

	partial void Enter_T__48();
	partial void Leave_T__48();

	// $ANTLR start "T__48"
	[GrammarRule("T__48")]
	private void mT__48()
	{
		Enter_T__48();
		EnterRule("T__48", 12);
		TraceIn("T__48", 12);
		try
		{
			int _type = T__48;
			int _channel = DefaultTokenChannel;
			// Lang2.g:20:7: ( '[' )
			DebugEnterAlt(1);
			// Lang2.g:20:9: '['
			{
			DebugLocation(20, 9);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__48", 12);
			LeaveRule("T__48", 12);
			Leave_T__48();
		}
	}
	// $ANTLR end "T__48"

	partial void Enter_T__49();
	partial void Leave_T__49();

	// $ANTLR start "T__49"
	[GrammarRule("T__49")]
	private void mT__49()
	{
		Enter_T__49();
		EnterRule("T__49", 13);
		TraceIn("T__49", 13);
		try
		{
			int _type = T__49;
			int _channel = DefaultTokenChannel;
			// Lang2.g:21:7: ( ']' )
			DebugEnterAlt(1);
			// Lang2.g:21:9: ']'
			{
			DebugLocation(21, 9);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__49", 13);
			LeaveRule("T__49", 13);
			Leave_T__49();
		}
	}
	// $ANTLR end "T__49"

	partial void Enter_T__50();
	partial void Leave_T__50();

	// $ANTLR start "T__50"
	[GrammarRule("T__50")]
	private void mT__50()
	{
		Enter_T__50();
		EnterRule("T__50", 14);
		TraceIn("T__50", 14);
		try
		{
			int _type = T__50;
			int _channel = DefaultTokenChannel;
			// Lang2.g:22:7: ( '(' )
			DebugEnterAlt(1);
			// Lang2.g:22:9: '('
			{
			DebugLocation(22, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__50", 14);
			LeaveRule("T__50", 14);
			Leave_T__50();
		}
	}
	// $ANTLR end "T__50"

	partial void Enter_T__51();
	partial void Leave_T__51();

	// $ANTLR start "T__51"
	[GrammarRule("T__51")]
	private void mT__51()
	{
		Enter_T__51();
		EnterRule("T__51", 15);
		TraceIn("T__51", 15);
		try
		{
			int _type = T__51;
			int _channel = DefaultTokenChannel;
			// Lang2.g:23:7: ( ')' )
			DebugEnterAlt(1);
			// Lang2.g:23:9: ')'
			{
			DebugLocation(23, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__51", 15);
			LeaveRule("T__51", 15);
			Leave_T__51();
		}
	}
	// $ANTLR end "T__51"

	partial void Enter_T__52();
	partial void Leave_T__52();

	// $ANTLR start "T__52"
	[GrammarRule("T__52")]
	private void mT__52()
	{
		Enter_T__52();
		EnterRule("T__52", 16);
		TraceIn("T__52", 16);
		try
		{
			int _type = T__52;
			int _channel = DefaultTokenChannel;
			// Lang2.g:24:7: ( '{' )
			DebugEnterAlt(1);
			// Lang2.g:24:9: '{'
			{
			DebugLocation(24, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__52", 16);
			LeaveRule("T__52", 16);
			Leave_T__52();
		}
	}
	// $ANTLR end "T__52"

	partial void Enter_T__53();
	partial void Leave_T__53();

	// $ANTLR start "T__53"
	[GrammarRule("T__53")]
	private void mT__53()
	{
		Enter_T__53();
		EnterRule("T__53", 17);
		TraceIn("T__53", 17);
		try
		{
			int _type = T__53;
			int _channel = DefaultTokenChannel;
			// Lang2.g:25:7: ( '}' )
			DebugEnterAlt(1);
			// Lang2.g:25:9: '}'
			{
			DebugLocation(25, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__53", 17);
			LeaveRule("T__53", 17);
			Leave_T__53();
		}
	}
	// $ANTLR end "T__53"

	partial void Enter_T__54();
	partial void Leave_T__54();

	// $ANTLR start "T__54"
	[GrammarRule("T__54")]
	private void mT__54()
	{
		Enter_T__54();
		EnterRule("T__54", 18);
		TraceIn("T__54", 18);
		try
		{
			int _type = T__54;
			int _channel = DefaultTokenChannel;
			// Lang2.g:26:7: ( ',' )
			DebugEnterAlt(1);
			// Lang2.g:26:9: ','
			{
			DebugLocation(26, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__54", 18);
			LeaveRule("T__54", 18);
			Leave_T__54();
		}
	}
	// $ANTLR end "T__54"

	partial void Enter_OP_END();
	partial void Leave_OP_END();

	// $ANTLR start "OP_END"
	[GrammarRule("OP_END")]
	private void mOP_END()
	{
		Enter_OP_END();
		EnterRule("OP_END", 19);
		TraceIn("OP_END", 19);
		try
		{
			int _type = OP_END;
			int _channel = DefaultTokenChannel;
			// Lang2.g:44:8: ( ';' )
			DebugEnterAlt(1);
			// Lang2.g:44:10: ';'
			{
			DebugLocation(44, 10);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OP_END", 19);
			LeaveRule("OP_END", 19);
			Leave_OP_END();
		}
	}
	// $ANTLR end "OP_END"

	partial void Enter_INT();
	partial void Leave_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		Enter_INT();
		EnterRule("INT", 20);
		TraceIn("INT", 20);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:47:6: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// Lang2.g:47:8: ( '0' .. '9' )+
			{
			DebugLocation(47, 8);
			// Lang2.g:47:8: ( '0' .. '9' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='0' && LA1_0<='9')))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:47:9: '0' .. '9'
					{
					DebugLocation(47, 9);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 20);
			LeaveRule("INT", 20);
			Leave_INT();
		}
	}
	// $ANTLR end "INT"

	partial void Enter_DOUBLE();
	partial void Leave_DOUBLE();

	// $ANTLR start "DOUBLE"
	[GrammarRule("DOUBLE")]
	private void mDOUBLE()
	{
		Enter_DOUBLE();
		EnterRule("DOUBLE", 21);
		TraceIn("DOUBLE", 21);
		try
		{
			int _type = DOUBLE;
			int _channel = DefaultTokenChannel;
			// Lang2.g:49:8: ( INT ( '.' INT )? )
			DebugEnterAlt(1);
			// Lang2.g:49:10: INT ( '.' INT )?
			{
			DebugLocation(49, 10);
			mINT(); 
			DebugLocation(49, 13);
			// Lang2.g:49:13: ( '.' INT )?
			int alt2=2;
			try { DebugEnterSubRule(2);
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0=='.'))
			{
				alt2=1;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:49:14: '.' INT
				{
				DebugLocation(49, 14);
				Match('.'); 
				DebugLocation(49, 17);
				mINT(); 

				}
				break;

			}
			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOUBLE", 21);
			LeaveRule("DOUBLE", 21);
			Leave_DOUBLE();
		}
	}
	// $ANTLR end "DOUBLE"

	partial void Enter_CHAR();
	partial void Leave_CHAR();

	// $ANTLR start "CHAR"
	[GrammarRule("CHAR")]
	private void mCHAR()
	{
		Enter_CHAR();
		EnterRule("CHAR", 22);
		TraceIn("CHAR", 22);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// Lang2.g:52:6: ( '\\'' ( options {greedy=false; } : . ) '\\'' )
			DebugEnterAlt(1);
			// Lang2.g:52:8: '\\'' ( options {greedy=false; } : . ) '\\''
			{
			DebugLocation(52, 8);
			Match('\''); 
			DebugLocation(52, 13);
			// Lang2.g:52:13: ( options {greedy=false; } : . )
			DebugEnterAlt(1);
			// Lang2.g:52:41: .
			{
			DebugLocation(52, 41);
			MatchAny(); 

			}

			DebugLocation(52, 45);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 22);
			LeaveRule("CHAR", 22);
			Leave_CHAR();
		}
	}
	// $ANTLR end "CHAR"

	partial void Enter_STRING();
	partial void Leave_STRING();

	// $ANTLR start "STRING"
	[GrammarRule("STRING")]
	private void mSTRING()
	{
		Enter_STRING();
		EnterRule("STRING", 23);
		TraceIn("STRING", 23);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// Lang2.g:54:10: ( '\"' ( options {greedy=false; } : . )* '\"' )
			DebugEnterAlt(1);
			// Lang2.g:54:14: '\"' ( options {greedy=false; } : . )* '\"'
			{
			DebugLocation(54, 17);
			Match('\"'); 
			DebugLocation(54, 19);
			// Lang2.g:54:19: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if ((LA3_0=='\"'))
				{
					alt3=2;
				}
				else if (((LA3_0>='\u0000' && LA3_0<='!')||(LA3_0>='#' && LA3_0<='\uFFFF')))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:54:47: .
					{
					DebugLocation(54, 47);
					MatchAny(); 

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }

			DebugLocation(54, 55);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 23);
			LeaveRule("STRING", 23);
			Leave_STRING();
		}
	}
	// $ANTLR end "STRING"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 24);
		TraceIn("WS", 24);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// Lang2.g:56:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// Lang2.g:57:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(57, 3);
			// Lang2.g:57:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>='\t' && LA4_0<='\n')||(LA4_0>='\f' && LA4_0<='\r')||LA4_0==' '))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:
					{
					DebugLocation(57, 3);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt4 >= 1)
						goto loop4;

					EarlyExitException eee4 = new EarlyExitException( 4, input );
					DebugRecognitionException(eee4);
					throw eee4;
				}
				cnt4++;
			}
			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(57, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 24);
			LeaveRule("WS", 24);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 25);
		TraceIn("ADD", 25);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// Lang2.g:64:5: ( '+' )
			DebugEnterAlt(1);
			// Lang2.g:64:7: '+'
			{
			DebugLocation(64, 7);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 25);
			LeaveRule("ADD", 25);
			Leave_ADD();
		}
	}
	// $ANTLR end "ADD"

	partial void Enter_SUB();
	partial void Leave_SUB();

	// $ANTLR start "SUB"
	[GrammarRule("SUB")]
	private void mSUB()
	{
		Enter_SUB();
		EnterRule("SUB", 26);
		TraceIn("SUB", 26);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// Lang2.g:66:5: ( '-' )
			DebugEnterAlt(1);
			// Lang2.g:66:7: '-'
			{
			DebugLocation(66, 7);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 26);
			LeaveRule("SUB", 26);
			Leave_SUB();
		}
	}
	// $ANTLR end "SUB"

	partial void Enter_MULT();
	partial void Leave_MULT();

	// $ANTLR start "MULT"
	[GrammarRule("MULT")]
	private void mMULT()
	{
		Enter_MULT();
		EnterRule("MULT", 27);
		TraceIn("MULT", 27);
		try
		{
			int _type = MULT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:68:6: ( '*' )
			DebugEnterAlt(1);
			// Lang2.g:68:8: '*'
			{
			DebugLocation(68, 8);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MULT", 27);
			LeaveRule("MULT", 27);
			Leave_MULT();
		}
	}
	// $ANTLR end "MULT"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 28);
		TraceIn("DIV", 28);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// Lang2.g:70:5: ( '/' )
			DebugEnterAlt(1);
			// Lang2.g:70:7: '/'
			{
			DebugLocation(70, 7);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 28);
			LeaveRule("DIV", 28);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_ASS();
	partial void Leave_ASS();

	// $ANTLR start "ASS"
	[GrammarRule("ASS")]
	private void mASS()
	{
		Enter_ASS();
		EnterRule("ASS", 29);
		TraceIn("ASS", 29);
		try
		{
			int _type = ASS;
			int _channel = DefaultTokenChannel;
			// Lang2.g:72:5: ( '=' )
			DebugEnterAlt(1);
			// Lang2.g:72:7: '='
			{
			DebugLocation(72, 7);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASS", 29);
			LeaveRule("ASS", 29);
			Leave_ASS();
		}
	}
	// $ANTLR end "ASS"

	partial void Enter_DISJ();
	partial void Leave_DISJ();

	// $ANTLR start "DISJ"
	[GrammarRule("DISJ")]
	private void mDISJ()
	{
		Enter_DISJ();
		EnterRule("DISJ", 30);
		TraceIn("DISJ", 30);
		try
		{
			int _type = DISJ;
			int _channel = DefaultTokenChannel;
			// Lang2.g:75:2: ( '||' )
			DebugEnterAlt(1);
			// Lang2.g:75:4: '||'
			{
			DebugLocation(75, 4);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DISJ", 30);
			LeaveRule("DISJ", 30);
			Leave_DISJ();
		}
	}
	// $ANTLR end "DISJ"

	partial void Enter_CONJ();
	partial void Leave_CONJ();

	// $ANTLR start "CONJ"
	[GrammarRule("CONJ")]
	private void mCONJ()
	{
		Enter_CONJ();
		EnterRule("CONJ", 31);
		TraceIn("CONJ", 31);
		try
		{
			int _type = CONJ;
			int _channel = DefaultTokenChannel;
			// Lang2.g:78:2: ( '&&' )
			DebugEnterAlt(1);
			// Lang2.g:78:4: '&&'
			{
			DebugLocation(78, 4);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CONJ", 31);
			LeaveRule("CONJ", 31);
			Leave_CONJ();
		}
	}
	// $ANTLR end "CONJ"

	partial void Enter_IS_MORE();
	partial void Leave_IS_MORE();

	// $ANTLR start "IS_MORE"
	[GrammarRule("IS_MORE")]
	private void mIS_MORE()
	{
		Enter_IS_MORE();
		EnterRule("IS_MORE", 32);
		TraceIn("IS_MORE", 32);
		try
		{
			int _type = IS_MORE;
			int _channel = DefaultTokenChannel;
			// Lang2.g:81:9: ( '>' )
			DebugEnterAlt(1);
			// Lang2.g:81:11: '>'
			{
			DebugLocation(81, 11);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_MORE", 32);
			LeaveRule("IS_MORE", 32);
			Leave_IS_MORE();
		}
	}
	// $ANTLR end "IS_MORE"

	partial void Enter_IS_LESS();
	partial void Leave_IS_LESS();

	// $ANTLR start "IS_LESS"
	[GrammarRule("IS_LESS")]
	private void mIS_LESS()
	{
		Enter_IS_LESS();
		EnterRule("IS_LESS", 33);
		TraceIn("IS_LESS", 33);
		try
		{
			int _type = IS_LESS;
			int _channel = DefaultTokenChannel;
			// Lang2.g:84:9: ( '<' )
			DebugEnterAlt(1);
			// Lang2.g:84:11: '<'
			{
			DebugLocation(84, 11);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_LESS", 33);
			LeaveRule("IS_LESS", 33);
			Leave_IS_LESS();
		}
	}
	// $ANTLR end "IS_LESS"

	partial void Enter_IS_EQUALLY();
	partial void Leave_IS_EQUALLY();

	// $ANTLR start "IS_EQUALLY"
	[GrammarRule("IS_EQUALLY")]
	private void mIS_EQUALLY()
	{
		Enter_IS_EQUALLY();
		EnterRule("IS_EQUALLY", 34);
		TraceIn("IS_EQUALLY", 34);
		try
		{
			int _type = IS_EQUALLY;
			int _channel = DefaultTokenChannel;
			// Lang2.g:87:12: ( '==' )
			DebugEnterAlt(1);
			// Lang2.g:87:14: '=='
			{
			DebugLocation(87, 14);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_EQUALLY", 34);
			LeaveRule("IS_EQUALLY", 34);
			Leave_IS_EQUALLY();
		}
	}
	// $ANTLR end "IS_EQUALLY"

	partial void Enter_INVERT();
	partial void Leave_INVERT();

	// $ANTLR start "INVERT"
	[GrammarRule("INVERT")]
	private void mINVERT()
	{
		Enter_INVERT();
		EnterRule("INVERT", 35);
		TraceIn("INVERT", 35);
		try
		{
			int _type = INVERT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:90:8: ( '\\!' )
			DebugEnterAlt(1);
			// Lang2.g:90:10: '\\!'
			{
			DebugLocation(90, 10);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INVERT", 35);
			LeaveRule("INVERT", 35);
			Leave_INVERT();
		}
	}
	// $ANTLR end "INVERT"

	partial void Enter_IS_LESS_OR_EQUAL();
	partial void Leave_IS_LESS_OR_EQUAL();

	// $ANTLR start "IS_LESS_OR_EQUAL"
	[GrammarRule("IS_LESS_OR_EQUAL")]
	private void mIS_LESS_OR_EQUAL()
	{
		Enter_IS_LESS_OR_EQUAL();
		EnterRule("IS_LESS_OR_EQUAL", 36);
		TraceIn("IS_LESS_OR_EQUAL", 36);
		try
		{
			int _type = IS_LESS_OR_EQUAL;
			int _channel = DefaultTokenChannel;
			// Lang2.g:93:18: ( '<=' )
			DebugEnterAlt(1);
			// Lang2.g:93:20: '<='
			{
			DebugLocation(93, 20);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_LESS_OR_EQUAL", 36);
			LeaveRule("IS_LESS_OR_EQUAL", 36);
			Leave_IS_LESS_OR_EQUAL();
		}
	}
	// $ANTLR end "IS_LESS_OR_EQUAL"

	partial void Enter_IS_MORE_OR_EQUAL();
	partial void Leave_IS_MORE_OR_EQUAL();

	// $ANTLR start "IS_MORE_OR_EQUAL"
	[GrammarRule("IS_MORE_OR_EQUAL")]
	private void mIS_MORE_OR_EQUAL()
	{
		Enter_IS_MORE_OR_EQUAL();
		EnterRule("IS_MORE_OR_EQUAL", 37);
		TraceIn("IS_MORE_OR_EQUAL", 37);
		try
		{
			int _type = IS_MORE_OR_EQUAL;
			int _channel = DefaultTokenChannel;
			// Lang2.g:96:18: ( '>=' )
			DebugEnterAlt(1);
			// Lang2.g:96:20: '>='
			{
			DebugLocation(96, 20);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_MORE_OR_EQUAL", 37);
			LeaveRule("IS_MORE_OR_EQUAL", 37);
			Leave_IS_MORE_OR_EQUAL();
		}
	}
	// $ANTLR end "IS_MORE_OR_EQUAL"

	partial void Enter_ID();
	partial void Leave_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		Enter_ID();
		EnterRule("ID", 38);
		TraceIn("ID", 38);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// Lang2.g:99:4: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' )+ )
			DebugEnterAlt(1);
			// Lang2.g:99:6: ( 'a' .. 'z' | 'A' .. 'Z' | '_' )+
			{
			DebugLocation(99, 6);
			// Lang2.g:99:6: ( 'a' .. 'z' | 'A' .. 'Z' | '_' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='A' && LA5_0<='Z')||LA5_0=='_'||(LA5_0>='a' && LA5_0<='z')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:
					{
					DebugLocation(99, 6);
					if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt5 >= 1)
						goto loop5;

					EarlyExitException eee5 = new EarlyExitException( 5, input );
					DebugRecognitionException(eee5);
					throw eee5;
				}
				cnt5++;
			}
			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 38);
			LeaveRule("ID", 38);
			Leave_ID();
		}
	}
	// $ANTLR end "ID"

	public override void mTokens()
	{
		// Lang2.g:1:8: ( IF | FOR | WHILE | DO | RETURN | TINT | TFLOAT | TSTRING | TCHAR | TBOOL | TVOID | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | OP_END | INT | DOUBLE | CHAR | STRING | WS | ADD | SUB | MULT | DIV | ASS | DISJ | CONJ | IS_MORE | IS_LESS | IS_EQUALLY | INVERT | IS_LESS_OR_EQUAL | IS_MORE_OR_EQUAL | ID )
		int alt6=38;
		try { DebugEnterDecision(6, decisionCanBacktrack[6]);
		try
		{
			alt6 = dfa6.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(6); }
		switch (alt6)
		{
		case 1:
			DebugEnterAlt(1);
			// Lang2.g:1:10: IF
			{
			DebugLocation(1, 10);
			mIF(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// Lang2.g:1:13: FOR
			{
			DebugLocation(1, 13);
			mFOR(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// Lang2.g:1:17: WHILE
			{
			DebugLocation(1, 17);
			mWHILE(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// Lang2.g:1:23: DO
			{
			DebugLocation(1, 23);
			mDO(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// Lang2.g:1:26: RETURN
			{
			DebugLocation(1, 26);
			mRETURN(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// Lang2.g:1:33: TINT
			{
			DebugLocation(1, 33);
			mTINT(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// Lang2.g:1:38: TFLOAT
			{
			DebugLocation(1, 38);
			mTFLOAT(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// Lang2.g:1:45: TSTRING
			{
			DebugLocation(1, 45);
			mTSTRING(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// Lang2.g:1:53: TCHAR
			{
			DebugLocation(1, 53);
			mTCHAR(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// Lang2.g:1:59: TBOOL
			{
			DebugLocation(1, 59);
			mTBOOL(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// Lang2.g:1:65: TVOID
			{
			DebugLocation(1, 65);
			mTVOID(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// Lang2.g:1:71: T__48
			{
			DebugLocation(1, 71);
			mT__48(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// Lang2.g:1:77: T__49
			{
			DebugLocation(1, 77);
			mT__49(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// Lang2.g:1:83: T__50
			{
			DebugLocation(1, 83);
			mT__50(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// Lang2.g:1:89: T__51
			{
			DebugLocation(1, 89);
			mT__51(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// Lang2.g:1:95: T__52
			{
			DebugLocation(1, 95);
			mT__52(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// Lang2.g:1:101: T__53
			{
			DebugLocation(1, 101);
			mT__53(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// Lang2.g:1:107: T__54
			{
			DebugLocation(1, 107);
			mT__54(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// Lang2.g:1:113: OP_END
			{
			DebugLocation(1, 113);
			mOP_END(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// Lang2.g:1:120: INT
			{
			DebugLocation(1, 120);
			mINT(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// Lang2.g:1:124: DOUBLE
			{
			DebugLocation(1, 124);
			mDOUBLE(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// Lang2.g:1:131: CHAR
			{
			DebugLocation(1, 131);
			mCHAR(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// Lang2.g:1:136: STRING
			{
			DebugLocation(1, 136);
			mSTRING(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// Lang2.g:1:143: WS
			{
			DebugLocation(1, 143);
			mWS(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// Lang2.g:1:146: ADD
			{
			DebugLocation(1, 146);
			mADD(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// Lang2.g:1:150: SUB
			{
			DebugLocation(1, 150);
			mSUB(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// Lang2.g:1:154: MULT
			{
			DebugLocation(1, 154);
			mMULT(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// Lang2.g:1:159: DIV
			{
			DebugLocation(1, 159);
			mDIV(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// Lang2.g:1:163: ASS
			{
			DebugLocation(1, 163);
			mASS(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// Lang2.g:1:167: DISJ
			{
			DebugLocation(1, 167);
			mDISJ(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// Lang2.g:1:172: CONJ
			{
			DebugLocation(1, 172);
			mCONJ(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// Lang2.g:1:177: IS_MORE
			{
			DebugLocation(1, 177);
			mIS_MORE(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// Lang2.g:1:185: IS_LESS
			{
			DebugLocation(1, 185);
			mIS_LESS(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// Lang2.g:1:193: IS_EQUALLY
			{
			DebugLocation(1, 193);
			mIS_EQUALLY(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// Lang2.g:1:204: INVERT
			{
			DebugLocation(1, 204);
			mINVERT(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// Lang2.g:1:211: IS_LESS_OR_EQUAL
			{
			DebugLocation(1, 211);
			mIS_LESS_OR_EQUAL(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// Lang2.g:1:228: IS_MORE_OR_EQUAL
			{
			DebugLocation(1, 228);
			mIS_MORE_OR_EQUAL(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// Lang2.g:1:245: ID
			{
			DebugLocation(1, 245);
			mID(); 

			}
			break;

		}

	}


	#region DFA
	DFA6 dfa6;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa6 = new DFA6(this);
	}

	private class DFA6 : DFA
	{
		private const string DFA6_eotS =
			"\x1\xFFFF\x9\x20\x8\xFFFF\x1\x2C\x7\xFFFF\x1\x2F\x2\xFFFF\x1\x31\x1"+
			"\x33\x2\xFFFF\x1\x34\x4\x20\x1\x39\x5\x20\x9\xFFFF\x1\x3F\x1\x40\x2\x20"+
			"\x1\xFFFF\x5\x20\x2\xFFFF\x4\x20\x1\x4C\x1\x4D\x1\x4E\x1\x4F\x1\x50\x2"+
			"\x20\x5\xFFFF\x1\x53\x1\x54\x2\xFFFF";
		private const string DFA6_eofS =
			"\x55\xFFFF";
		private const string DFA6_minS =
			"\x1\x9\x1\x66\x1\x6C\x1\x68\x1\x6F\x1\x65\x1\x74\x1\x68\x2\x6F\x8\xFFFF"+
			"\x1\x2E\x7\xFFFF\x1\x3D\x2\xFFFF\x2\x3D\x2\xFFFF\x1\x41\x1\x74\x1\x72"+
			"\x1\x6F\x1\x69\x1\x41\x1\x74\x1\x72\x1\x61\x1\x6F\x1\x69\x9\xFFFF\x2"+
			"\x41\x1\x61\x1\x6C\x1\xFFFF\x1\x75\x1\x69\x1\x72\x1\x6C\x1\x64\x2\xFFFF"+
			"\x1\x74\x1\x65\x1\x72\x1\x6E\x5\x41\x1\x6E\x1\x67\x5\xFFFF\x2\x41\x2"+
			"\xFFFF";
		private const string DFA6_maxS =
			"\x1\x7D\x1\x6E\x1\x6F\x1\x68\x1\x6F\x1\x65\x1\x74\x1\x68\x2\x6F\x8\xFFFF"+
			"\x1\x39\x7\xFFFF\x1\x3D\x2\xFFFF\x2\x3D\x2\xFFFF\x1\x7A\x1\x74\x1\x72"+
			"\x1\x6F\x1\x69\x1\x7A\x1\x74\x1\x72\x1\x61\x1\x6F\x1\x69\x9\xFFFF\x2"+
			"\x7A\x1\x61\x1\x6C\x1\xFFFF\x1\x75\x1\x69\x1\x72\x1\x6C\x1\x64\x2\xFFFF"+
			"\x1\x74\x1\x65\x1\x72\x1\x6E\x5\x7A\x1\x6E\x1\x67\x5\xFFFF\x2\x7A\x2"+
			"\xFFFF";
		private const string DFA6_acceptS =
			"\xA\xFFFF\x1\xC\x1\xD\x1\xE\x1\xF\x1\x10\x1\x11\x1\x12\x1\x13\x1\xFFFF"+
			"\x1\x16\x1\x17\x1\x18\x1\x19\x1\x1A\x1\x1B\x1\x1C\x1\xFFFF\x1\x1E\x1"+
			"\x1F\x2\xFFFF\x1\x23\x1\x26\xB\xFFFF\x1\x14\x1\x15\x1\x22\x1\x1D\x1\x25"+
			"\x1\x20\x1\x24\x1\x21\x1\x1\x4\xFFFF\x1\x4\x5\xFFFF\x1\x6\x1\x2\xB\xFFFF"+
			"\x1\x9\x1\xA\x1\xB\x1\x7\x1\x3\x2\xFFFF\x1\x5\x1\x8";
		private const string DFA6_specialS =
			"\x55\xFFFF}>";
		private static readonly string[] DFA6_transitionS =
			{
				"\x2\x15\x1\xFFFF\x2\x15\x12\xFFFF\x1\x15\x1\x1F\x1\x14\x3\xFFFF\x1"+
				"\x1C\x1\x13\x1\xC\x1\xD\x1\x18\x1\x16\x1\x10\x1\x17\x1\xFFFF\x1\x19"+
				"\xA\x12\x1\xFFFF\x1\x11\x1\x1E\x1\x1A\x1\x1D\x2\xFFFF\x1A\x20\x1\xA"+
				"\x1\xFFFF\x1\xB\x1\xFFFF\x1\x20\x1\xFFFF\x1\x20\x1\x8\x1\x7\x1\x4\x1"+
				"\x20\x1\x2\x2\x20\x1\x1\x8\x20\x1\x5\x1\x6\x2\x20\x1\x9\x1\x3\x3\x20"+
				"\x1\xE\x1\x1B\x1\xF",
				"\x1\x21\x7\xFFFF\x1\x22",
				"\x1\x24\x2\xFFFF\x1\x23",
				"\x1\x25",
				"\x1\x26",
				"\x1\x27",
				"\x1\x28",
				"\x1\x29",
				"\x1\x2A",
				"\x1\x2B",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2D\x1\xFFFF\xA\x12",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2E",
				"",
				"",
				"\x1\x30",
				"\x1\x32",
				"",
				"",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x35",
				"\x1\x36",
				"\x1\x37",
				"\x1\x38",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x3A",
				"\x1\x3B",
				"\x1\x3C",
				"\x1\x3D",
				"\x1\x3E",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x41",
				"\x1\x42",
				"",
				"\x1\x43",
				"\x1\x44",
				"\x1\x45",
				"\x1\x46",
				"\x1\x47",
				"",
				"",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4B",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x51",
				"\x1\x52",
				"",
				"",
				"",
				"",
				"",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				""
			};

		private static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
		private static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
		private static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
		private static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
		private static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
		private static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
		private static readonly short[][] DFA6_transition;

		static DFA6()
		{
			int numStates = DFA6_transitionS.Length;
			DFA6_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA6_transition[i] = DFA.UnpackEncodedString(DFA6_transitionS[i]);
			}
		}

		public DFA6( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 6;
			this.eot = DFA6_eot;
			this.eof = DFA6_eof;
			this.min = DFA6_min;
			this.max = DFA6_max;
			this.accept = DFA6_accept;
			this.special = DFA6_special;
			this.transition = DFA6_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( IF | FOR | WHILE | DO | RETURN | TINT | TFLOAT | TSTRING | TCHAR | TBOOL | TVOID | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | OP_END | INT | DOUBLE | CHAR | STRING | WS | ADD | SUB | MULT | DIV | ASS | DISJ | CONJ | IS_MORE | IS_LESS | IS_EQUALLY | INVERT | IS_LESS_OR_EQUAL | IS_MORE_OR_EQUAL | ID );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace Lang2
