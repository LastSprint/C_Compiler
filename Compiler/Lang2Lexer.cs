// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2016-12-05 10:22:18

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
	public const int T__46=46;
	public const int T__47=47;
	public const int T__48=48;
	public const int T__49=49;
	public const int T__50=50;
	public const int T__51=51;
	public const int T__52=52;
	public const int PROGRAM=4;
	public const int VAR_DECL=5;
	public const int METH_CALL=6;
	public const int CALL_ARGS=7;
	public const int NEW=8;
	public const int NEW_CLASS=9;
	public const int NEW_ARR=10;
	public const int ARR_DECL=11;
	public const int ARR_CALL=12;
	public const int IF=13;
	public const int BODY=14;
	public const int FOR=15;
	public const int WHILE=16;
	public const int DO=17;
	public const int INC=18;
	public const int DEC=19;
	public const int CLASS=20;
	public const int STRUCT=21;
	public const int METH_DECL=22;
	public const int DECL_ARGS=23;
	public const int TO=24;
	public const int RET_TYPE_SINGLE=25;
	public const int RET_TYPE_ARR=26;
	public const int RETURN=27;
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
	public const int ID=45;

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

	partial void Enter_NEW();
	partial void Leave_NEW();

	// $ANTLR start "NEW"
	[GrammarRule("NEW")]
	private void mNEW()
	{
		Enter_NEW();
		EnterRule("NEW", 1);
		TraceIn("NEW", 1);
		try
		{
			int _type = NEW;
			int _channel = DefaultTokenChannel;
			// Lang2.g:9:5: ( 'new' )
			DebugEnterAlt(1);
			// Lang2.g:9:7: 'new'
			{
			DebugLocation(9, 7);
			Match("new"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEW", 1);
			LeaveRule("NEW", 1);
			Leave_NEW();
		}
	}
	// $ANTLR end "NEW"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 2);
		TraceIn("IF", 2);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// Lang2.g:10:4: ( 'if' )
			DebugEnterAlt(1);
			// Lang2.g:10:6: 'if'
			{
			DebugLocation(10, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 2);
			LeaveRule("IF", 2);
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
		EnterRule("FOR", 3);
		TraceIn("FOR", 3);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// Lang2.g:11:5: ( 'for' )
			DebugEnterAlt(1);
			// Lang2.g:11:7: 'for'
			{
			DebugLocation(11, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 3);
			LeaveRule("FOR", 3);
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
		EnterRule("WHILE", 4);
		TraceIn("WHILE", 4);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// Lang2.g:12:7: ( 'while' )
			DebugEnterAlt(1);
			// Lang2.g:12:9: 'while'
			{
			DebugLocation(12, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 4);
			LeaveRule("WHILE", 4);
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
		EnterRule("DO", 5);
		TraceIn("DO", 5);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// Lang2.g:13:4: ( 'do' )
			DebugEnterAlt(1);
			// Lang2.g:13:6: 'do'
			{
			DebugLocation(13, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 5);
			LeaveRule("DO", 5);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_CLASS();
	partial void Leave_CLASS();

	// $ANTLR start "CLASS"
	[GrammarRule("CLASS")]
	private void mCLASS()
	{
		Enter_CLASS();
		EnterRule("CLASS", 6);
		TraceIn("CLASS", 6);
		try
		{
			int _type = CLASS;
			int _channel = DefaultTokenChannel;
			// Lang2.g:14:7: ( 'class' )
			DebugEnterAlt(1);
			// Lang2.g:14:9: 'class'
			{
			DebugLocation(14, 9);
			Match("class"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CLASS", 6);
			LeaveRule("CLASS", 6);
			Leave_CLASS();
		}
	}
	// $ANTLR end "CLASS"

	partial void Enter_STRUCT();
	partial void Leave_STRUCT();

	// $ANTLR start "STRUCT"
	[GrammarRule("STRUCT")]
	private void mSTRUCT()
	{
		Enter_STRUCT();
		EnterRule("STRUCT", 7);
		TraceIn("STRUCT", 7);
		try
		{
			int _type = STRUCT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:15:8: ( 'struct' )
			DebugEnterAlt(1);
			// Lang2.g:15:10: 'struct'
			{
			DebugLocation(15, 10);
			Match("struct"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRUCT", 7);
			LeaveRule("STRUCT", 7);
			Leave_STRUCT();
		}
	}
	// $ANTLR end "STRUCT"

	partial void Enter_TO();
	partial void Leave_TO();

	// $ANTLR start "TO"
	[GrammarRule("TO")]
	private void mTO()
	{
		Enter_TO();
		EnterRule("TO", 8);
		TraceIn("TO", 8);
		try
		{
			int _type = TO;
			int _channel = DefaultTokenChannel;
			// Lang2.g:16:4: ( '->' )
			DebugEnterAlt(1);
			// Lang2.g:16:6: '->'
			{
			DebugLocation(16, 6);
			Match("->"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TO", 8);
			LeaveRule("TO", 8);
			Leave_TO();
		}
	}
	// $ANTLR end "TO"

	partial void Enter_RETURN();
	partial void Leave_RETURN();

	// $ANTLR start "RETURN"
	[GrammarRule("RETURN")]
	private void mRETURN()
	{
		Enter_RETURN();
		EnterRule("RETURN", 9);
		TraceIn("RETURN", 9);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// Lang2.g:17:8: ( 'return' )
			DebugEnterAlt(1);
			// Lang2.g:17:10: 'return'
			{
			DebugLocation(17, 10);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 9);
			LeaveRule("RETURN", 9);
			Leave_RETURN();
		}
	}
	// $ANTLR end "RETURN"

	partial void Enter_T__46();
	partial void Leave_T__46();

	// $ANTLR start "T__46"
	[GrammarRule("T__46")]
	private void mT__46()
	{
		Enter_T__46();
		EnterRule("T__46", 10);
		TraceIn("T__46", 10);
		try
		{
			int _type = T__46;
			int _channel = DefaultTokenChannel;
			// Lang2.g:18:7: ( '{' )
			DebugEnterAlt(1);
			// Lang2.g:18:9: '{'
			{
			DebugLocation(18, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__46", 10);
			LeaveRule("T__46", 10);
			Leave_T__46();
		}
	}
	// $ANTLR end "T__46"

	partial void Enter_T__47();
	partial void Leave_T__47();

	// $ANTLR start "T__47"
	[GrammarRule("T__47")]
	private void mT__47()
	{
		Enter_T__47();
		EnterRule("T__47", 11);
		TraceIn("T__47", 11);
		try
		{
			int _type = T__47;
			int _channel = DefaultTokenChannel;
			// Lang2.g:19:7: ( '}' )
			DebugEnterAlt(1);
			// Lang2.g:19:9: '}'
			{
			DebugLocation(19, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__47", 11);
			LeaveRule("T__47", 11);
			Leave_T__47();
		}
	}
	// $ANTLR end "T__47"

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
			// Lang2.g:24:7: ( ',' )
			DebugEnterAlt(1);
			// Lang2.g:24:9: ','
			{
			DebugLocation(24, 9);
			Match(','); 

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

	partial void Enter_OP_END();
	partial void Leave_OP_END();

	// $ANTLR start "OP_END"
	[GrammarRule("OP_END")]
	private void mOP_END()
	{
		Enter_OP_END();
		EnterRule("OP_END", 17);
		TraceIn("OP_END", 17);
		try
		{
			int _type = OP_END;
			int _channel = DefaultTokenChannel;
			// Lang2.g:43:8: ( ';' )
			DebugEnterAlt(1);
			// Lang2.g:43:10: ';'
			{
			DebugLocation(43, 10);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OP_END", 17);
			LeaveRule("OP_END", 17);
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
		EnterRule("INT", 18);
		TraceIn("INT", 18);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:46:6: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// Lang2.g:46:8: ( '0' .. '9' )+
			{
			DebugLocation(46, 8);
			// Lang2.g:46:8: ( '0' .. '9' )+
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
					// Lang2.g:46:9: '0' .. '9'
					{
					DebugLocation(46, 9);
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
			TraceOut("INT", 18);
			LeaveRule("INT", 18);
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
		EnterRule("DOUBLE", 19);
		TraceIn("DOUBLE", 19);
		try
		{
			int _type = DOUBLE;
			int _channel = DefaultTokenChannel;
			// Lang2.g:48:8: ( INT ( '.' INT )? )
			DebugEnterAlt(1);
			// Lang2.g:48:10: INT ( '.' INT )?
			{
			DebugLocation(48, 10);
			mINT(); 
			DebugLocation(48, 13);
			// Lang2.g:48:13: ( '.' INT )?
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
				// Lang2.g:48:14: '.' INT
				{
				DebugLocation(48, 14);
				Match('.'); 
				DebugLocation(48, 17);
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
			TraceOut("DOUBLE", 19);
			LeaveRule("DOUBLE", 19);
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
		EnterRule("CHAR", 20);
		TraceIn("CHAR", 20);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// Lang2.g:51:6: ( '\\'' ( options {greedy=false; } : . ) '\\'' )
			DebugEnterAlt(1);
			// Lang2.g:51:8: '\\'' ( options {greedy=false; } : . ) '\\''
			{
			DebugLocation(51, 8);
			Match('\''); 
			DebugLocation(51, 13);
			// Lang2.g:51:13: ( options {greedy=false; } : . )
			DebugEnterAlt(1);
			// Lang2.g:51:41: .
			{
			DebugLocation(51, 41);
			MatchAny(); 

			}

			DebugLocation(51, 45);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 20);
			LeaveRule("CHAR", 20);
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
		EnterRule("STRING", 21);
		TraceIn("STRING", 21);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// Lang2.g:53:10: ( '\"' ( options {greedy=false; } : . )* '\"' )
			DebugEnterAlt(1);
			// Lang2.g:53:14: '\"' ( options {greedy=false; } : . )* '\"'
			{
			DebugLocation(53, 17);
			Match('\"'); 
			DebugLocation(53, 19);
			// Lang2.g:53:19: ( options {greedy=false; } : . )*
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
					// Lang2.g:53:47: .
					{
					DebugLocation(53, 47);
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

			DebugLocation(53, 55);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 21);
			LeaveRule("STRING", 21);
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
		EnterRule("WS", 22);
		TraceIn("WS", 22);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// Lang2.g:55:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// Lang2.g:56:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(56, 3);
			// Lang2.g:56:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
					DebugLocation(56, 3);
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

			DebugLocation(56, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 22);
			LeaveRule("WS", 22);
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
		EnterRule("ADD", 23);
		TraceIn("ADD", 23);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// Lang2.g:62:5: ( '+' )
			DebugEnterAlt(1);
			// Lang2.g:62:7: '+'
			{
			DebugLocation(62, 7);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 23);
			LeaveRule("ADD", 23);
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
		EnterRule("SUB", 24);
		TraceIn("SUB", 24);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// Lang2.g:64:5: ( '-' )
			DebugEnterAlt(1);
			// Lang2.g:64:7: '-'
			{
			DebugLocation(64, 7);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 24);
			LeaveRule("SUB", 24);
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
		EnterRule("MULT", 25);
		TraceIn("MULT", 25);
		try
		{
			int _type = MULT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:66:6: ( '*' )
			DebugEnterAlt(1);
			// Lang2.g:66:8: '*'
			{
			DebugLocation(66, 8);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MULT", 25);
			LeaveRule("MULT", 25);
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
		EnterRule("DIV", 26);
		TraceIn("DIV", 26);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// Lang2.g:68:5: ( '/' )
			DebugEnterAlt(1);
			// Lang2.g:68:7: '/'
			{
			DebugLocation(68, 7);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 26);
			LeaveRule("DIV", 26);
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
		EnterRule("ASS", 27);
		TraceIn("ASS", 27);
		try
		{
			int _type = ASS;
			int _channel = DefaultTokenChannel;
			// Lang2.g:70:5: ( '=' )
			DebugEnterAlt(1);
			// Lang2.g:70:7: '='
			{
			DebugLocation(70, 7);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASS", 27);
			LeaveRule("ASS", 27);
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
		EnterRule("DISJ", 28);
		TraceIn("DISJ", 28);
		try
		{
			int _type = DISJ;
			int _channel = DefaultTokenChannel;
			// Lang2.g:73:2: ( '||' )
			DebugEnterAlt(1);
			// Lang2.g:73:4: '||'
			{
			DebugLocation(73, 4);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DISJ", 28);
			LeaveRule("DISJ", 28);
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
		EnterRule("CONJ", 29);
		TraceIn("CONJ", 29);
		try
		{
			int _type = CONJ;
			int _channel = DefaultTokenChannel;
			// Lang2.g:76:2: ( '&&' )
			DebugEnterAlt(1);
			// Lang2.g:76:4: '&&'
			{
			DebugLocation(76, 4);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CONJ", 29);
			LeaveRule("CONJ", 29);
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
		EnterRule("IS_MORE", 30);
		TraceIn("IS_MORE", 30);
		try
		{
			int _type = IS_MORE;
			int _channel = DefaultTokenChannel;
			// Lang2.g:79:9: ( '>' )
			DebugEnterAlt(1);
			// Lang2.g:79:11: '>'
			{
			DebugLocation(79, 11);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_MORE", 30);
			LeaveRule("IS_MORE", 30);
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
		EnterRule("IS_LESS", 31);
		TraceIn("IS_LESS", 31);
		try
		{
			int _type = IS_LESS;
			int _channel = DefaultTokenChannel;
			// Lang2.g:82:9: ( '<' )
			DebugEnterAlt(1);
			// Lang2.g:82:11: '<'
			{
			DebugLocation(82, 11);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_LESS", 31);
			LeaveRule("IS_LESS", 31);
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
		EnterRule("IS_EQUALLY", 32);
		TraceIn("IS_EQUALLY", 32);
		try
		{
			int _type = IS_EQUALLY;
			int _channel = DefaultTokenChannel;
			// Lang2.g:85:12: ( '==' )
			DebugEnterAlt(1);
			// Lang2.g:85:14: '=='
			{
			DebugLocation(85, 14);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_EQUALLY", 32);
			LeaveRule("IS_EQUALLY", 32);
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
		EnterRule("INVERT", 33);
		TraceIn("INVERT", 33);
		try
		{
			int _type = INVERT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:88:8: ( '\\!' )
			DebugEnterAlt(1);
			// Lang2.g:88:10: '\\!'
			{
			DebugLocation(88, 10);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INVERT", 33);
			LeaveRule("INVERT", 33);
			Leave_INVERT();
		}
	}
	// $ANTLR end "INVERT"

	partial void Enter_ID();
	partial void Leave_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		Enter_ID();
		EnterRule("ID", 34);
		TraceIn("ID", 34);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// Lang2.g:91:4: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' )+ )
			DebugEnterAlt(1);
			// Lang2.g:91:6: ( 'a' .. 'z' | 'A' .. 'Z' | '_' )+
			{
			DebugLocation(91, 6);
			// Lang2.g:91:6: ( 'a' .. 'z' | 'A' .. 'Z' | '_' )+
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
					DebugLocation(91, 6);
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
			TraceOut("ID", 34);
			LeaveRule("ID", 34);
			Leave_ID();
		}
	}
	// $ANTLR end "ID"

	public override void mTokens()
	{
		// Lang2.g:1:8: ( NEW | IF | FOR | WHILE | DO | CLASS | STRUCT | TO | RETURN | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | OP_END | INT | DOUBLE | CHAR | STRING | WS | ADD | SUB | MULT | DIV | ASS | DISJ | CONJ | IS_MORE | IS_LESS | IS_EQUALLY | INVERT | ID )
		int alt6=34;
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
			// Lang2.g:1:10: NEW
			{
			DebugLocation(1, 10);
			mNEW(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// Lang2.g:1:14: IF
			{
			DebugLocation(1, 14);
			mIF(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// Lang2.g:1:17: FOR
			{
			DebugLocation(1, 17);
			mFOR(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// Lang2.g:1:21: WHILE
			{
			DebugLocation(1, 21);
			mWHILE(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// Lang2.g:1:27: DO
			{
			DebugLocation(1, 27);
			mDO(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// Lang2.g:1:30: CLASS
			{
			DebugLocation(1, 30);
			mCLASS(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// Lang2.g:1:36: STRUCT
			{
			DebugLocation(1, 36);
			mSTRUCT(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// Lang2.g:1:43: TO
			{
			DebugLocation(1, 43);
			mTO(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// Lang2.g:1:46: RETURN
			{
			DebugLocation(1, 46);
			mRETURN(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// Lang2.g:1:53: T__46
			{
			DebugLocation(1, 53);
			mT__46(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// Lang2.g:1:59: T__47
			{
			DebugLocation(1, 59);
			mT__47(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// Lang2.g:1:65: T__48
			{
			DebugLocation(1, 65);
			mT__48(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// Lang2.g:1:71: T__49
			{
			DebugLocation(1, 71);
			mT__49(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// Lang2.g:1:77: T__50
			{
			DebugLocation(1, 77);
			mT__50(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// Lang2.g:1:83: T__51
			{
			DebugLocation(1, 83);
			mT__51(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// Lang2.g:1:89: T__52
			{
			DebugLocation(1, 89);
			mT__52(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// Lang2.g:1:95: OP_END
			{
			DebugLocation(1, 95);
			mOP_END(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// Lang2.g:1:102: INT
			{
			DebugLocation(1, 102);
			mINT(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// Lang2.g:1:106: DOUBLE
			{
			DebugLocation(1, 106);
			mDOUBLE(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// Lang2.g:1:113: CHAR
			{
			DebugLocation(1, 113);
			mCHAR(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// Lang2.g:1:118: STRING
			{
			DebugLocation(1, 118);
			mSTRING(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// Lang2.g:1:125: WS
			{
			DebugLocation(1, 125);
			mWS(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// Lang2.g:1:128: ADD
			{
			DebugLocation(1, 128);
			mADD(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// Lang2.g:1:132: SUB
			{
			DebugLocation(1, 132);
			mSUB(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// Lang2.g:1:136: MULT
			{
			DebugLocation(1, 136);
			mMULT(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// Lang2.g:1:141: DIV
			{
			DebugLocation(1, 141);
			mDIV(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// Lang2.g:1:145: ASS
			{
			DebugLocation(1, 145);
			mASS(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// Lang2.g:1:149: DISJ
			{
			DebugLocation(1, 149);
			mDISJ(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// Lang2.g:1:154: CONJ
			{
			DebugLocation(1, 154);
			mCONJ(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// Lang2.g:1:159: IS_MORE
			{
			DebugLocation(1, 159);
			mIS_MORE(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// Lang2.g:1:167: IS_LESS
			{
			DebugLocation(1, 167);
			mIS_LESS(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// Lang2.g:1:175: IS_EQUALLY
			{
			DebugLocation(1, 175);
			mIS_EQUALLY(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// Lang2.g:1:186: INVERT
			{
			DebugLocation(1, 186);
			mINVERT(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// Lang2.g:1:193: ID
			{
			DebugLocation(1, 193);
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
			"\x1\xFFFF\x7\x1F\x1\x28\x1\x1F\x8\xFFFF\x1\x2A\x6\xFFFF\x1\x2D\x6\xFFFF"+
			"\x1\x1F\x1\x2F\x2\x1F\x1\x32\x2\x1F\x2\xFFFF\x1\x1F\x4\xFFFF\x1\x36\x1"+
			"\xFFFF\x1\x37\x1\x1F\x1\xFFFF\x3\x1F\x2\xFFFF\x4\x1F\x1\x40\x1\x41\x2"+
			"\x1F\x2\xFFFF\x1\x44\x1\x45\x2\xFFFF";
		private const string DFA6_eofS =
			"\x46\xFFFF";
		private const string DFA6_minS =
			"\x1\x9\x1\x65\x1\x66\x1\x6F\x1\x68\x1\x6F\x1\x6C\x1\x74\x1\x3E\x1\x65"+
			"\x8\xFFFF\x1\x2E\x6\xFFFF\x1\x3D\x6\xFFFF\x1\x77\x1\x41\x1\x72\x1\x69"+
			"\x1\x41\x1\x61\x1\x72\x2\xFFFF\x1\x74\x4\xFFFF\x1\x41\x1\xFFFF\x1\x41"+
			"\x1\x6C\x1\xFFFF\x1\x73\x2\x75\x2\xFFFF\x1\x65\x1\x73\x1\x63\x1\x72\x2"+
			"\x41\x1\x74\x1\x6E\x2\xFFFF\x2\x41\x2\xFFFF";
		private const string DFA6_maxS =
			"\x1\x7D\x1\x65\x1\x66\x1\x6F\x1\x68\x1\x6F\x1\x6C\x1\x74\x1\x3E\x1\x65"+
			"\x8\xFFFF\x1\x39\x6\xFFFF\x1\x3D\x6\xFFFF\x1\x77\x1\x7A\x1\x72\x1\x69"+
			"\x1\x7A\x1\x61\x1\x72\x2\xFFFF\x1\x74\x4\xFFFF\x1\x7A\x1\xFFFF\x1\x7A"+
			"\x1\x6C\x1\xFFFF\x1\x73\x2\x75\x2\xFFFF\x1\x65\x1\x73\x1\x63\x1\x72\x2"+
			"\x7A\x1\x74\x1\x6E\x2\xFFFF\x2\x7A\x2\xFFFF";
		private const string DFA6_acceptS =
			"\xA\xFFFF\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x1\xF\x1\x10\x1\x11\x1\xFFFF"+
			"\x1\x14\x1\x15\x1\x16\x1\x17\x1\x19\x1\x1A\x1\xFFFF\x1\x1C\x1\x1D\x1"+
			"\x1E\x1\x1F\x1\x21\x1\x22\x7\xFFFF\x1\x8\x1\x18\x1\xFFFF\x1\x12\x1\x13"+
			"\x1\x20\x1\x1B\x1\xFFFF\x1\x2\x2\xFFFF\x1\x5\x3\xFFFF\x1\x1\x1\x3\x8"+
			"\xFFFF\x1\x4\x1\x6\x2\xFFFF\x1\x7\x1\x9";
		private const string DFA6_specialS =
			"\x46\xFFFF}>";
		private static readonly string[] DFA6_transitionS =
			{
				"\x2\x15\x1\xFFFF\x2\x15\x12\xFFFF\x1\x15\x1\x1E\x1\x14\x3\xFFFF\x1"+
				"\x1B\x1\x13\x1\xE\x1\xF\x1\x17\x1\x16\x1\x10\x1\x8\x1\xFFFF\x1\x18\xA"+
				"\x12\x1\xFFFF\x1\x11\x1\x1D\x1\x19\x1\x1C\x2\xFFFF\x1A\x1F\x1\xC\x1"+
				"\xFFFF\x1\xD\x1\xFFFF\x1\x1F\x1\xFFFF\x2\x1F\x1\x6\x1\x5\x1\x1F\x1\x3"+
				"\x2\x1F\x1\x2\x4\x1F\x1\x1\x3\x1F\x1\x9\x1\x7\x3\x1F\x1\x4\x3\x1F\x1"+
				"\xA\x1\x1A\x1\xB",
				"\x1\x20",
				"\x1\x21",
				"\x1\x22",
				"\x1\x23",
				"\x1\x24",
				"\x1\x25",
				"\x1\x26",
				"\x1\x27",
				"\x1\x29",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2B\x1\xFFFF\xA\x12",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2C",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2E",
				"\x1A\x1F\x4\xFFFF\x1\x1F\x1\xFFFF\x1A\x1F",
				"\x1\x30",
				"\x1\x31",
				"\x1A\x1F\x4\xFFFF\x1\x1F\x1\xFFFF\x1A\x1F",
				"\x1\x33",
				"\x1\x34",
				"",
				"",
				"\x1\x35",
				"",
				"",
				"",
				"",
				"\x1A\x1F\x4\xFFFF\x1\x1F\x1\xFFFF\x1A\x1F",
				"",
				"\x1A\x1F\x4\xFFFF\x1\x1F\x1\xFFFF\x1A\x1F",
				"\x1\x38",
				"",
				"\x1\x39",
				"\x1\x3A",
				"\x1\x3B",
				"",
				"",
				"\x1\x3C",
				"\x1\x3D",
				"\x1\x3E",
				"\x1\x3F",
				"\x1A\x1F\x4\xFFFF\x1\x1F\x1\xFFFF\x1A\x1F",
				"\x1A\x1F\x4\xFFFF\x1\x1F\x1\xFFFF\x1A\x1F",
				"\x1\x42",
				"\x1\x43",
				"",
				"",
				"\x1A\x1F\x4\xFFFF\x1\x1F\x1\xFFFF\x1A\x1F",
				"\x1A\x1F\x4\xFFFF\x1\x1F\x1\xFFFF\x1A\x1F",
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

		public override string Description { get { return "1:1: Tokens : ( NEW | IF | FOR | WHILE | DO | CLASS | STRUCT | TO | RETURN | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | OP_END | INT | DOUBLE | CHAR | STRING | WS | ADD | SUB | MULT | DIV | ASS | DISJ | CONJ | IS_MORE | IS_LESS | IS_EQUALLY | INVERT | ID );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace Lang2
