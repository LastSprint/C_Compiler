// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2016-12-05 10:22:18

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


	using System;


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace Lang2
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class Lang2Parser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM", "VAR_DECL", "METH_CALL", "CALL_ARGS", "NEW", "NEW_CLASS", "NEW_ARR", "ARR_DECL", "ARR_CALL", "IF", "BODY", "FOR", "WHILE", "DO", "INC", "DEC", "CLASS", "STRUCT", "METH_DECL", "DECL_ARGS", "TO", "RET_TYPE_SINGLE", "RET_TYPE_ARR", "RETURN", "OP_END", "INT", "DOUBLE", "CHAR", "STRING", "WS", "ADD", "SUB", "MULT", "DIV", "ASS", "DISJ", "CONJ", "IS_MORE", "IS_LESS", "IS_EQUALLY", "INVERT", "ID", "'{'", "'}'", "'['", "']'", "'('", "')'", "','"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public Lang2Parser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public Lang2Parser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return Lang2Parser.tokenNames; } }
	public override string GrammarFileName { get { return "Lang2.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class classDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_classDecl();
	partial void Leave_classDecl();

	// $ANTLR start "classDecl"
	// Lang2.g:94:1: classDecl : CLASS ID '{' bodyCExprW '}' -> ^( CLASS ID bodyCExprW ) ;
	[GrammarRule("classDecl")]
	private Lang2Parser.classDecl_return classDecl()
	{
		Enter_classDecl();
		EnterRule("classDecl", 1);
		TraceIn("classDecl", 1);
		Lang2Parser.classDecl_return retval = new Lang2Parser.classDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CLASS1=null;
		IToken ID2=null;
		IToken char_literal3=null;
		IToken char_literal5=null;
		Lang2Parser.bodyCExprW_return bodyCExprW4 = default(Lang2Parser.bodyCExprW_return);

		object CLASS1_tree=null;
		object ID2_tree=null;
		object char_literal3_tree=null;
		object char_literal5_tree=null;
		RewriteRuleITokenStream stream_CLASS=new RewriteRuleITokenStream(adaptor,"token CLASS");
		RewriteRuleITokenStream stream_47=new RewriteRuleITokenStream(adaptor,"token 47");
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_bodyCExprW=new RewriteRuleSubtreeStream(adaptor,"rule bodyCExprW");
		try { DebugEnterRule(GrammarFileName, "classDecl");
		DebugLocation(94, 3);
		try
		{
			// Lang2.g:94:11: ( CLASS ID '{' bodyCExprW '}' -> ^( CLASS ID bodyCExprW ) )
			DebugEnterAlt(1);
			// Lang2.g:94:13: CLASS ID '{' bodyCExprW '}'
			{
			DebugLocation(94, 13);
			CLASS1=(IToken)Match(input,CLASS,Follow._CLASS_in_classDecl450);  
			stream_CLASS.Add(CLASS1);

			DebugLocation(94, 19);
			ID2=(IToken)Match(input,ID,Follow._ID_in_classDecl452);  
			stream_ID.Add(ID2);

			DebugLocation(94, 22);
			char_literal3=(IToken)Match(input,46,Follow._46_in_classDecl454);  
			stream_46.Add(char_literal3);

			DebugLocation(94, 25);
			PushFollow(Follow._bodyCExprW_in_classDecl455);
			bodyCExprW4=bodyCExprW();
			PopFollow();

			stream_bodyCExprW.Add(bodyCExprW4.Tree);
			DebugLocation(94, 35);
			char_literal5=(IToken)Match(input,47,Follow._47_in_classDecl456);  
			stream_47.Add(char_literal5);



			{
			// AST REWRITE
			// elements: ID, bodyCExprW, CLASS
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 94:39: -> ^( CLASS ID bodyCExprW )
			{
				DebugLocation(94, 42);
				// Lang2.g:94:42: ^( CLASS ID bodyCExprW )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(94, 44);
				root_1 = (object)adaptor.BecomeRoot(stream_CLASS.NextNode(), root_1);

				DebugLocation(94, 50);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(94, 53);
				adaptor.AddChild(root_1, stream_bodyCExprW.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("classDecl", 1);
			LeaveRule("classDecl", 1);
			Leave_classDecl();
		}
		DebugLocation(95, 3);
		} finally { DebugExitRule(GrammarFileName, "classDecl"); }
		return retval;

	}
	// $ANTLR end "classDecl"

	public class structDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_structDecl();
	partial void Leave_structDecl();

	// $ANTLR start "structDecl"
	// Lang2.g:97:1: structDecl : STRUCT ID '{' bodySExprW '}' -> ^( STRUCT ID bodySExprW ) ;
	[GrammarRule("structDecl")]
	private Lang2Parser.structDecl_return structDecl()
	{
		Enter_structDecl();
		EnterRule("structDecl", 2);
		TraceIn("structDecl", 2);
		Lang2Parser.structDecl_return retval = new Lang2Parser.structDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken STRUCT6=null;
		IToken ID7=null;
		IToken char_literal8=null;
		IToken char_literal10=null;
		Lang2Parser.bodySExprW_return bodySExprW9 = default(Lang2Parser.bodySExprW_return);

		object STRUCT6_tree=null;
		object ID7_tree=null;
		object char_literal8_tree=null;
		object char_literal10_tree=null;
		RewriteRuleITokenStream stream_STRUCT=new RewriteRuleITokenStream(adaptor,"token STRUCT");
		RewriteRuleITokenStream stream_47=new RewriteRuleITokenStream(adaptor,"token 47");
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_bodySExprW=new RewriteRuleSubtreeStream(adaptor,"rule bodySExprW");
		try { DebugEnterRule(GrammarFileName, "structDecl");
		DebugLocation(97, 3);
		try
		{
			// Lang2.g:97:12: ( STRUCT ID '{' bodySExprW '}' -> ^( STRUCT ID bodySExprW ) )
			DebugEnterAlt(1);
			// Lang2.g:97:14: STRUCT ID '{' bodySExprW '}'
			{
			DebugLocation(97, 14);
			STRUCT6=(IToken)Match(input,STRUCT,Follow._STRUCT_in_structDecl478);  
			stream_STRUCT.Add(STRUCT6);

			DebugLocation(97, 21);
			ID7=(IToken)Match(input,ID,Follow._ID_in_structDecl480);  
			stream_ID.Add(ID7);

			DebugLocation(97, 24);
			char_literal8=(IToken)Match(input,46,Follow._46_in_structDecl482);  
			stream_46.Add(char_literal8);

			DebugLocation(97, 27);
			PushFollow(Follow._bodySExprW_in_structDecl483);
			bodySExprW9=bodySExprW();
			PopFollow();

			stream_bodySExprW.Add(bodySExprW9.Tree);
			DebugLocation(97, 37);
			char_literal10=(IToken)Match(input,47,Follow._47_in_structDecl484);  
			stream_47.Add(char_literal10);



			{
			// AST REWRITE
			// elements: bodySExprW, STRUCT, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 97:41: -> ^( STRUCT ID bodySExprW )
			{
				DebugLocation(97, 44);
				// Lang2.g:97:44: ^( STRUCT ID bodySExprW )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(97, 46);
				root_1 = (object)adaptor.BecomeRoot(stream_STRUCT.NextNode(), root_1);

				DebugLocation(97, 53);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(97, 56);
				adaptor.AddChild(root_1, stream_bodySExprW.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("structDecl", 2);
			LeaveRule("structDecl", 2);
			Leave_structDecl();
		}
		DebugLocation(98, 3);
		} finally { DebugExitRule(GrammarFileName, "structDecl"); }
		return retval;

	}
	// $ANTLR end "structDecl"

	public class bodyCExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bodyCExpr();
	partial void Leave_bodyCExpr();

	// $ANTLR start "bodyCExpr"
	// Lang2.g:100:1: bodyCExpr : ( varDecl | arrDecl | structDecl | classDecl | methDecl );
	[GrammarRule("bodyCExpr")]
	private Lang2Parser.bodyCExpr_return bodyCExpr()
	{
		Enter_bodyCExpr();
		EnterRule("bodyCExpr", 3);
		TraceIn("bodyCExpr", 3);
		Lang2Parser.bodyCExpr_return retval = new Lang2Parser.bodyCExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.varDecl_return varDecl11 = default(Lang2Parser.varDecl_return);
		Lang2Parser.arrDecl_return arrDecl12 = default(Lang2Parser.arrDecl_return);
		Lang2Parser.structDecl_return structDecl13 = default(Lang2Parser.structDecl_return);
		Lang2Parser.classDecl_return classDecl14 = default(Lang2Parser.classDecl_return);
		Lang2Parser.methDecl_return methDecl15 = default(Lang2Parser.methDecl_return);


		try { DebugEnterRule(GrammarFileName, "bodyCExpr");
		DebugLocation(100, 3);
		try
		{
			// Lang2.g:100:11: ( varDecl | arrDecl | structDecl | classDecl | methDecl )
			int alt1=5;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case ID:
				{
				int LA1_1 = input.LA(2);

				if ((LA1_1==ID))
				{
					switch (input.LA(3))
					{
					case 48:
						{
						alt1=2;
						}
						break;
					case 50:
						{
						alt1=5;
						}
						break;
					case OP_END:
					case ASS:
					case 52:
						{
						alt1=1;
						}
						break;
					default:
						{
							NoViableAltException nvae = new NoViableAltException("", 1, 4, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}

				}
				else if ((LA1_1==48))
				{
					alt1=5;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 1, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case STRUCT:
				{
				alt1=3;
				}
				break;
			case CLASS:
				{
				alt1=4;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:100:13: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(100, 13);
				PushFollow(Follow._varDecl_in_bodyCExpr506);
				varDecl11=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl11.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:101:6: arrDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(101, 6);
				PushFollow(Follow._arrDecl_in_bodyCExpr513);
				arrDecl12=arrDecl();
				PopFollow();

				adaptor.AddChild(root_0, arrDecl12.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:102:6: structDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(102, 6);
				PushFollow(Follow._structDecl_in_bodyCExpr520);
				structDecl13=structDecl();
				PopFollow();

				adaptor.AddChild(root_0, structDecl13.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Lang2.g:103:6: classDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(103, 6);
				PushFollow(Follow._classDecl_in_bodyCExpr527);
				classDecl14=classDecl();
				PopFollow();

				adaptor.AddChild(root_0, classDecl14.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Lang2.g:104:6: methDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(104, 6);
				PushFollow(Follow._methDecl_in_bodyCExpr534);
				methDecl15=methDecl();
				PopFollow();

				adaptor.AddChild(root_0, methDecl15.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bodyCExpr", 3);
			LeaveRule("bodyCExpr", 3);
			Leave_bodyCExpr();
		}
		DebugLocation(105, 3);
		} finally { DebugExitRule(GrammarFileName, "bodyCExpr"); }
		return retval;

	}
	// $ANTLR end "bodyCExpr"

	public class bodyCExprW_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bodyCExprW();
	partial void Leave_bodyCExprW();

	// $ANTLR start "bodyCExprW"
	// Lang2.g:106:1: bodyCExprW : ( bodyCExpr )+ -> ^( BODY ( bodyCExpr )+ ) ;
	[GrammarRule("bodyCExprW")]
	private Lang2Parser.bodyCExprW_return bodyCExprW()
	{
		Enter_bodyCExprW();
		EnterRule("bodyCExprW", 4);
		TraceIn("bodyCExprW", 4);
		Lang2Parser.bodyCExprW_return retval = new Lang2Parser.bodyCExprW_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.bodyCExpr_return bodyCExpr16 = default(Lang2Parser.bodyCExpr_return);

		RewriteRuleSubtreeStream stream_bodyCExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyCExpr");
		try { DebugEnterRule(GrammarFileName, "bodyCExprW");
		DebugLocation(106, 3);
		try
		{
			// Lang2.g:106:12: ( ( bodyCExpr )+ -> ^( BODY ( bodyCExpr )+ ) )
			DebugEnterAlt(1);
			// Lang2.g:106:14: ( bodyCExpr )+
			{
			DebugLocation(106, 14);
			// Lang2.g:106:14: ( bodyCExpr )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>=CLASS && LA2_0<=STRUCT)||LA2_0==ID))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:106:14: bodyCExpr
					{
					DebugLocation(106, 14);
					PushFollow(Follow._bodyCExpr_in_bodyCExprW545);
					bodyCExpr16=bodyCExpr();
					PopFollow();

					stream_bodyCExpr.Add(bodyCExpr16.Tree);

					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }



			{
			// AST REWRITE
			// elements: bodyCExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 106:25: -> ^( BODY ( bodyCExpr )+ )
			{
				DebugLocation(106, 28);
				// Lang2.g:106:28: ^( BODY ( bodyCExpr )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(106, 30);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY, "BODY"), root_1);

				DebugLocation(106, 35);
				if ( !(stream_bodyCExpr.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_bodyCExpr.HasNext )
				{
					DebugLocation(106, 35);
					adaptor.AddChild(root_1, stream_bodyCExpr.NextTree());

				}
				stream_bodyCExpr.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bodyCExprW", 4);
			LeaveRule("bodyCExprW", 4);
			Leave_bodyCExprW();
		}
		DebugLocation(107, 3);
		} finally { DebugExitRule(GrammarFileName, "bodyCExprW"); }
		return retval;

	}
	// $ANTLR end "bodyCExprW"

	public class bodySExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bodySExpr();
	partial void Leave_bodySExpr();

	// $ANTLR start "bodySExpr"
	// Lang2.g:108:1: bodySExpr : ( varDecl | arrDecl | methDecl );
	[GrammarRule("bodySExpr")]
	private Lang2Parser.bodySExpr_return bodySExpr()
	{
		Enter_bodySExpr();
		EnterRule("bodySExpr", 5);
		TraceIn("bodySExpr", 5);
		Lang2Parser.bodySExpr_return retval = new Lang2Parser.bodySExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.varDecl_return varDecl17 = default(Lang2Parser.varDecl_return);
		Lang2Parser.arrDecl_return arrDecl18 = default(Lang2Parser.arrDecl_return);
		Lang2Parser.methDecl_return methDecl19 = default(Lang2Parser.methDecl_return);


		try { DebugEnterRule(GrammarFileName, "bodySExpr");
		DebugLocation(108, 3);
		try
		{
			// Lang2.g:108:11: ( varDecl | arrDecl | methDecl )
			int alt3=3;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0==ID))
			{
				int LA3_1 = input.LA(2);

				if ((LA3_1==ID))
				{
					switch (input.LA(3))
					{
					case 48:
						{
						alt3=2;
						}
						break;
					case 50:
						{
						alt3=3;
						}
						break;
					case OP_END:
					case ASS:
					case 52:
						{
						alt3=1;
						}
						break;
					default:
						{
							NoViableAltException nvae = new NoViableAltException("", 3, 2, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}

				}
				else if ((LA3_1==48))
				{
					alt3=3;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 3, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 3, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:108:13: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(108, 13);
				PushFollow(Follow._varDecl_in_bodySExpr566);
				varDecl17=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl17.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:109:6: arrDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(109, 6);
				PushFollow(Follow._arrDecl_in_bodySExpr573);
				arrDecl18=arrDecl();
				PopFollow();

				adaptor.AddChild(root_0, arrDecl18.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:110:6: methDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(110, 6);
				PushFollow(Follow._methDecl_in_bodySExpr580);
				methDecl19=methDecl();
				PopFollow();

				adaptor.AddChild(root_0, methDecl19.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bodySExpr", 5);
			LeaveRule("bodySExpr", 5);
			Leave_bodySExpr();
		}
		DebugLocation(111, 3);
		} finally { DebugExitRule(GrammarFileName, "bodySExpr"); }
		return retval;

	}
	// $ANTLR end "bodySExpr"

	public class bodySExprW_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bodySExprW();
	partial void Leave_bodySExprW();

	// $ANTLR start "bodySExprW"
	// Lang2.g:112:1: bodySExprW : ( bodySExpr )+ -> ^( BODY ( bodySExpr )+ ) ;
	[GrammarRule("bodySExprW")]
	private Lang2Parser.bodySExprW_return bodySExprW()
	{
		Enter_bodySExprW();
		EnterRule("bodySExprW", 6);
		TraceIn("bodySExprW", 6);
		Lang2Parser.bodySExprW_return retval = new Lang2Parser.bodySExprW_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.bodySExpr_return bodySExpr20 = default(Lang2Parser.bodySExpr_return);

		RewriteRuleSubtreeStream stream_bodySExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodySExpr");
		try { DebugEnterRule(GrammarFileName, "bodySExprW");
		DebugLocation(112, 3);
		try
		{
			// Lang2.g:112:12: ( ( bodySExpr )+ -> ^( BODY ( bodySExpr )+ ) )
			DebugEnterAlt(1);
			// Lang2.g:112:14: ( bodySExpr )+
			{
			DebugLocation(112, 14);
			// Lang2.g:112:14: ( bodySExpr )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0==ID))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:112:14: bodySExpr
					{
					DebugLocation(112, 14);
					PushFollow(Follow._bodySExpr_in_bodySExprW591);
					bodySExpr20=bodySExpr();
					PopFollow();

					stream_bodySExpr.Add(bodySExpr20.Tree);

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



			{
			// AST REWRITE
			// elements: bodySExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 112:25: -> ^( BODY ( bodySExpr )+ )
			{
				DebugLocation(112, 28);
				// Lang2.g:112:28: ^( BODY ( bodySExpr )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(112, 30);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY, "BODY"), root_1);

				DebugLocation(112, 35);
				if ( !(stream_bodySExpr.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_bodySExpr.HasNext )
				{
					DebugLocation(112, 35);
					adaptor.AddChild(root_1, stream_bodySExpr.NextTree());

				}
				stream_bodySExpr.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bodySExprW", 6);
			LeaveRule("bodySExprW", 6);
			Leave_bodySExprW();
		}
		DebugLocation(113, 3);
		} finally { DebugExitRule(GrammarFileName, "bodySExprW"); }
		return retval;

	}
	// $ANTLR end "bodySExprW"

	public class toObjExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_toObjExpr();
	partial void Leave_toObjExpr();

	// $ANTLR start "toObjExpr"
	// Lang2.g:114:1: toObjExpr : ID TO ( ID ( assW )? | methCall | arrCall ) ;
	[GrammarRule("toObjExpr")]
	private Lang2Parser.toObjExpr_return toObjExpr()
	{
		Enter_toObjExpr();
		EnterRule("toObjExpr", 7);
		TraceIn("toObjExpr", 7);
		Lang2Parser.toObjExpr_return retval = new Lang2Parser.toObjExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID21=null;
		IToken TO22=null;
		IToken ID23=null;
		Lang2Parser.assW_return assW24 = default(Lang2Parser.assW_return);
		Lang2Parser.methCall_return methCall25 = default(Lang2Parser.methCall_return);
		Lang2Parser.arrCall_return arrCall26 = default(Lang2Parser.arrCall_return);

		object ID21_tree=null;
		object TO22_tree=null;
		object ID23_tree=null;

		try { DebugEnterRule(GrammarFileName, "toObjExpr");
		DebugLocation(114, 3);
		try
		{
			// Lang2.g:114:11: ( ID TO ( ID ( assW )? | methCall | arrCall ) )
			DebugEnterAlt(1);
			// Lang2.g:114:13: ID TO ( ID ( assW )? | methCall | arrCall )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(114, 13);
			ID21=(IToken)Match(input,ID,Follow._ID_in_toObjExpr615); 
			ID21_tree = (object)adaptor.Create(ID21);
			adaptor.AddChild(root_0, ID21_tree);

			DebugLocation(114, 18);
			TO22=(IToken)Match(input,TO,Follow._TO_in_toObjExpr617); 
			TO22_tree = (object)adaptor.Create(TO22);
			root_0 = (object)adaptor.BecomeRoot(TO22_tree, root_0);

			DebugLocation(115, 5);
			// Lang2.g:115:5: ( ID ( assW )? | methCall | arrCall )
			int alt6=3;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0==ID))
			{
				switch (input.LA(2))
				{
				case 50:
					{
					alt6=2;
					}
					break;
				case 48:
					{
					alt6=3;
					}
					break;
				case OP_END:
				case ADD:
				case SUB:
				case MULT:
				case DIV:
				case ASS:
				case DISJ:
				case CONJ:
				case IS_MORE:
				case IS_LESS:
				case IS_EQUALLY:
				case 49:
				case 51:
				case 52:
					{
					alt6=1;
					}
					break;
				default:
					{
						NoViableAltException nvae = new NoViableAltException("", 6, 1, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 6, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:115:6: ID ( assW )?
				{
				DebugLocation(115, 6);
				ID23=(IToken)Match(input,ID,Follow._ID_in_toObjExpr626); 
				ID23_tree = (object)adaptor.Create(ID23);
				adaptor.AddChild(root_0, ID23_tree);

				DebugLocation(115, 9);
				// Lang2.g:115:9: ( assW )?
				int alt5=2;
				try { DebugEnterSubRule(5);
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if ((LA5_0==ASS))
				{
					alt5=1;
				}
				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:115:9: assW
					{
					DebugLocation(115, 9);
					PushFollow(Follow._assW_in_toObjExpr628);
					assW24=assW();
					PopFollow();

					adaptor.AddChild(root_0, assW24.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(5); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:116:6: methCall
				{
				DebugLocation(116, 6);
				PushFollow(Follow._methCall_in_toObjExpr636);
				methCall25=methCall();
				PopFollow();

				adaptor.AddChild(root_0, methCall25.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:117:6: arrCall
				{
				DebugLocation(117, 6);
				PushFollow(Follow._arrCall_in_toObjExpr643);
				arrCall26=arrCall();
				PopFollow();

				adaptor.AddChild(root_0, arrCall26.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(6); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("toObjExpr", 7);
			LeaveRule("toObjExpr", 7);
			Leave_toObjExpr();
		}
		DebugLocation(118, 3);
		} finally { DebugExitRule(GrammarFileName, "toObjExpr"); }
		return retval;

	}
	// $ANTLR end "toObjExpr"

	public class arrDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrDecl();
	partial void Leave_arrDecl();

	// $ANTLR start "arrDecl"
	// Lang2.g:121:1: arrDecl : ID ID '[' ']' ( assW )? OP_END -> ^( ARR_DECL ID ID ( assW )? ) ;
	[GrammarRule("arrDecl")]
	private Lang2Parser.arrDecl_return arrDecl()
	{
		Enter_arrDecl();
		EnterRule("arrDecl", 8);
		TraceIn("arrDecl", 8);
		Lang2Parser.arrDecl_return retval = new Lang2Parser.arrDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID27=null;
		IToken ID28=null;
		IToken char_literal29=null;
		IToken char_literal30=null;
		IToken OP_END32=null;
		Lang2Parser.assW_return assW31 = default(Lang2Parser.assW_return);

		object ID27_tree=null;
		object ID28_tree=null;
		object char_literal29_tree=null;
		object char_literal30_tree=null;
		object OP_END32_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_48=new RewriteRuleITokenStream(adaptor,"token 48");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_assW=new RewriteRuleSubtreeStream(adaptor,"rule assW");
		try { DebugEnterRule(GrammarFileName, "arrDecl");
		DebugLocation(121, 3);
		try
		{
			// Lang2.g:121:10: ( ID ID '[' ']' ( assW )? OP_END -> ^( ARR_DECL ID ID ( assW )? ) )
			DebugEnterAlt(1);
			// Lang2.g:121:12: ID ID '[' ']' ( assW )? OP_END
			{
			DebugLocation(121, 12);
			ID27=(IToken)Match(input,ID,Follow._ID_in_arrDecl658);  
			stream_ID.Add(ID27);

			DebugLocation(121, 15);
			ID28=(IToken)Match(input,ID,Follow._ID_in_arrDecl660);  
			stream_ID.Add(ID28);

			DebugLocation(121, 17);
			char_literal29=(IToken)Match(input,48,Follow._48_in_arrDecl661);  
			stream_48.Add(char_literal29);

			DebugLocation(121, 20);
			char_literal30=(IToken)Match(input,49,Follow._49_in_arrDecl662);  
			stream_49.Add(char_literal30);

			DebugLocation(121, 24);
			// Lang2.g:121:24: ( assW )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0==ASS))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:121:24: assW
				{
				DebugLocation(121, 24);
				PushFollow(Follow._assW_in_arrDecl664);
				assW31=assW();
				PopFollow();

				stream_assW.Add(assW31.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(7); }

			DebugLocation(121, 30);
			OP_END32=(IToken)Match(input,OP_END,Follow._OP_END_in_arrDecl667);  
			stream_OP_END.Add(OP_END32);



			{
			// AST REWRITE
			// elements: ID, assW, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 121:36: -> ^( ARR_DECL ID ID ( assW )? )
			{
				DebugLocation(121, 39);
				// Lang2.g:121:39: ^( ARR_DECL ID ID ( assW )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(121, 41);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

				DebugLocation(121, 50);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(121, 53);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(121, 56);
				// Lang2.g:121:56: ( assW )?
				if ( stream_assW.HasNext )
				{
					DebugLocation(121, 56);
					adaptor.AddChild(root_1, stream_assW.NextTree());

				}
				stream_assW.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arrDecl", 8);
			LeaveRule("arrDecl", 8);
			Leave_arrDecl();
		}
		DebugLocation(122, 3);
		} finally { DebugExitRule(GrammarFileName, "arrDecl"); }
		return retval;

	}
	// $ANTLR end "arrDecl"

	public class arrCall_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrCall();
	partial void Leave_arrCall();

	// $ANTLR start "arrCall"
	// Lang2.g:124:1: arrCall : ID '[' mathExpr ']' -> ^( ARR_CALL ID mathExpr ) ;
	[GrammarRule("arrCall")]
	private Lang2Parser.arrCall_return arrCall()
	{
		Enter_arrCall();
		EnterRule("arrCall", 9);
		TraceIn("arrCall", 9);
		Lang2Parser.arrCall_return retval = new Lang2Parser.arrCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID33=null;
		IToken char_literal34=null;
		IToken char_literal36=null;
		Lang2Parser.mathExpr_return mathExpr35 = default(Lang2Parser.mathExpr_return);

		object ID33_tree=null;
		object char_literal34_tree=null;
		object char_literal36_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_48=new RewriteRuleITokenStream(adaptor,"token 48");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		try { DebugEnterRule(GrammarFileName, "arrCall");
		DebugLocation(124, 3);
		try
		{
			// Lang2.g:124:10: ( ID '[' mathExpr ']' -> ^( ARR_CALL ID mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:124:12: ID '[' mathExpr ']'
			{
			DebugLocation(124, 12);
			ID33=(IToken)Match(input,ID,Follow._ID_in_arrCall692);  
			stream_ID.Add(ID33);

			DebugLocation(124, 14);
			char_literal34=(IToken)Match(input,48,Follow._48_in_arrCall693);  
			stream_48.Add(char_literal34);

			DebugLocation(124, 17);
			PushFollow(Follow._mathExpr_in_arrCall694);
			mathExpr35=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr35.Tree);
			DebugLocation(124, 25);
			char_literal36=(IToken)Match(input,49,Follow._49_in_arrCall695);  
			stream_49.Add(char_literal36);



			{
			// AST REWRITE
			// elements: ID, mathExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 124:29: -> ^( ARR_CALL ID mathExpr )
			{
				DebugLocation(124, 32);
				// Lang2.g:124:32: ^( ARR_CALL ID mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(124, 34);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_CALL, "ARR_CALL"), root_1);

				DebugLocation(124, 43);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(124, 46);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arrCall", 9);
			LeaveRule("arrCall", 9);
			Leave_arrCall();
		}
		DebugLocation(125, 3);
		} finally { DebugExitRule(GrammarFileName, "arrCall"); }
		return retval;

	}
	// $ANTLR end "arrCall"

	public class bodyFExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bodyFExpr();
	partial void Leave_bodyFExpr();

	// $ANTLR start "bodyFExpr"
	// Lang2.g:128:1: bodyFExpr : ( varDecl | ID ASS mathExpr OP_END | methCall OP_END | arrDecl | ifExpr | forLoop | incSug OP_END | decSug OP_END | whileLoop | doLoop | arrCall ASS mathExpr OP_END | toObjExpr OP_END | RETURN ( mathExpr )? OP_END );
	[GrammarRule("bodyFExpr")]
	private Lang2Parser.bodyFExpr_return bodyFExpr()
	{
		Enter_bodyFExpr();
		EnterRule("bodyFExpr", 10);
		TraceIn("bodyFExpr", 10);
		Lang2Parser.bodyFExpr_return retval = new Lang2Parser.bodyFExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID38=null;
		IToken ASS39=null;
		IToken OP_END41=null;
		IToken OP_END43=null;
		IToken OP_END48=null;
		IToken OP_END50=null;
		IToken ASS54=null;
		IToken OP_END56=null;
		IToken OP_END58=null;
		IToken RETURN59=null;
		IToken OP_END61=null;
		Lang2Parser.varDecl_return varDecl37 = default(Lang2Parser.varDecl_return);
		Lang2Parser.mathExpr_return mathExpr40 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.methCall_return methCall42 = default(Lang2Parser.methCall_return);
		Lang2Parser.arrDecl_return arrDecl44 = default(Lang2Parser.arrDecl_return);
		Lang2Parser.ifExpr_return ifExpr45 = default(Lang2Parser.ifExpr_return);
		Lang2Parser.forLoop_return forLoop46 = default(Lang2Parser.forLoop_return);
		Lang2Parser.incSug_return incSug47 = default(Lang2Parser.incSug_return);
		Lang2Parser.decSug_return decSug49 = default(Lang2Parser.decSug_return);
		Lang2Parser.whileLoop_return whileLoop51 = default(Lang2Parser.whileLoop_return);
		Lang2Parser.doLoop_return doLoop52 = default(Lang2Parser.doLoop_return);
		Lang2Parser.arrCall_return arrCall53 = default(Lang2Parser.arrCall_return);
		Lang2Parser.mathExpr_return mathExpr55 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.toObjExpr_return toObjExpr57 = default(Lang2Parser.toObjExpr_return);
		Lang2Parser.mathExpr_return mathExpr60 = default(Lang2Parser.mathExpr_return);

		object ID38_tree=null;
		object ASS39_tree=null;
		object OP_END41_tree=null;
		object OP_END43_tree=null;
		object OP_END48_tree=null;
		object OP_END50_tree=null;
		object ASS54_tree=null;
		object OP_END56_tree=null;
		object OP_END58_tree=null;
		object RETURN59_tree=null;
		object OP_END61_tree=null;

		try { DebugEnterRule(GrammarFileName, "bodyFExpr");
		DebugLocation(128, 4);
		try
		{
			// Lang2.g:128:11: ( varDecl | ID ASS mathExpr OP_END | methCall OP_END | arrDecl | ifExpr | forLoop | incSug OP_END | decSug OP_END | whileLoop | doLoop | arrCall ASS mathExpr OP_END | toObjExpr OP_END | RETURN ( mathExpr )? OP_END )
			int alt9=13;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			try
			{
				alt9 = dfa9.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:128:13: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(128, 13);
				PushFollow(Follow._varDecl_in_bodyFExpr718);
				varDecl37=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl37.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:129:6: ID ASS mathExpr OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(129, 6);
				ID38=(IToken)Match(input,ID,Follow._ID_in_bodyFExpr725); 
				ID38_tree = (object)adaptor.Create(ID38);
				adaptor.AddChild(root_0, ID38_tree);

				DebugLocation(129, 12);
				ASS39=(IToken)Match(input,ASS,Follow._ASS_in_bodyFExpr727); 
				ASS39_tree = (object)adaptor.Create(ASS39);
				root_0 = (object)adaptor.BecomeRoot(ASS39_tree, root_0);

				DebugLocation(129, 14);
				PushFollow(Follow._mathExpr_in_bodyFExpr730);
				mathExpr40=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr40.Tree);
				DebugLocation(129, 29);
				OP_END41=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr732); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:130:6: methCall OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(130, 6);
				PushFollow(Follow._methCall_in_bodyFExpr740);
				methCall42=methCall();
				PopFollow();

				adaptor.AddChild(root_0, methCall42.Tree);
				DebugLocation(130, 21);
				OP_END43=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr742); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Lang2.g:131:6: arrDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(131, 6);
				PushFollow(Follow._arrDecl_in_bodyFExpr750);
				arrDecl44=arrDecl();
				PopFollow();

				adaptor.AddChild(root_0, arrDecl44.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Lang2.g:132:6: ifExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(132, 6);
				PushFollow(Follow._ifExpr_in_bodyFExpr757);
				ifExpr45=ifExpr();
				PopFollow();

				adaptor.AddChild(root_0, ifExpr45.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Lang2.g:133:6: forLoop
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(133, 6);
				PushFollow(Follow._forLoop_in_bodyFExpr764);
				forLoop46=forLoop();
				PopFollow();

				adaptor.AddChild(root_0, forLoop46.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Lang2.g:134:6: incSug OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(134, 6);
				PushFollow(Follow._incSug_in_bodyFExpr771);
				incSug47=incSug();
				PopFollow();

				adaptor.AddChild(root_0, incSug47.Tree);
				DebugLocation(134, 19);
				OP_END48=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr773); 

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Lang2.g:135:6: decSug OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(135, 6);
				PushFollow(Follow._decSug_in_bodyFExpr781);
				decSug49=decSug();
				PopFollow();

				adaptor.AddChild(root_0, decSug49.Tree);
				DebugLocation(135, 19);
				OP_END50=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr783); 

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// Lang2.g:136:6: whileLoop
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(136, 6);
				PushFollow(Follow._whileLoop_in_bodyFExpr791);
				whileLoop51=whileLoop();
				PopFollow();

				adaptor.AddChild(root_0, whileLoop51.Tree);

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// Lang2.g:137:6: doLoop
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(137, 6);
				PushFollow(Follow._doLoop_in_bodyFExpr798);
				doLoop52=doLoop();
				PopFollow();

				adaptor.AddChild(root_0, doLoop52.Tree);

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// Lang2.g:138:6: arrCall ASS mathExpr OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(138, 6);
				PushFollow(Follow._arrCall_in_bodyFExpr805);
				arrCall53=arrCall();
				PopFollow();

				adaptor.AddChild(root_0, arrCall53.Tree);
				DebugLocation(138, 17);
				ASS54=(IToken)Match(input,ASS,Follow._ASS_in_bodyFExpr807); 
				ASS54_tree = (object)adaptor.Create(ASS54);
				root_0 = (object)adaptor.BecomeRoot(ASS54_tree, root_0);

				DebugLocation(138, 19);
				PushFollow(Follow._mathExpr_in_bodyFExpr810);
				mathExpr55=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr55.Tree);
				DebugLocation(138, 34);
				OP_END56=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr812); 

				}
				break;
			case 12:
				DebugEnterAlt(12);
				// Lang2.g:139:6: toObjExpr OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(139, 6);
				PushFollow(Follow._toObjExpr_in_bodyFExpr820);
				toObjExpr57=toObjExpr();
				PopFollow();

				adaptor.AddChild(root_0, toObjExpr57.Tree);
				DebugLocation(139, 22);
				OP_END58=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr822); 

				}
				break;
			case 13:
				DebugEnterAlt(13);
				// Lang2.g:140:6: RETURN ( mathExpr )? OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(140, 12);
				RETURN59=(IToken)Match(input,RETURN,Follow._RETURN_in_bodyFExpr830); 
				RETURN59_tree = (object)adaptor.Create(RETURN59);
				root_0 = (object)adaptor.BecomeRoot(RETURN59_tree, root_0);

				DebugLocation(140, 14);
				// Lang2.g:140:14: ( mathExpr )?
				int alt8=2;
				try { DebugEnterSubRule(8);
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0==NEW||(LA8_0>=INT && LA8_0<=STRING)||(LA8_0>=INVERT && LA8_0<=ID)||LA8_0==50))
				{
					alt8=1;
				}
				} finally { DebugExitDecision(8); }
				switch (alt8)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:140:14: mathExpr
					{
					DebugLocation(140, 14);
					PushFollow(Follow._mathExpr_in_bodyFExpr833);
					mathExpr60=mathExpr();
					PopFollow();

					adaptor.AddChild(root_0, mathExpr60.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(8); }

				DebugLocation(140, 30);
				OP_END61=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr836); 

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bodyFExpr", 10);
			LeaveRule("bodyFExpr", 10);
			Leave_bodyFExpr();
		}
		DebugLocation(141, 4);
		} finally { DebugExitRule(GrammarFileName, "bodyFExpr"); }
		return retval;

	}
	// $ANTLR end "bodyFExpr"

	public class ifExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_ifExpr();
	partial void Leave_ifExpr();

	// $ANTLR start "ifExpr"
	// Lang2.g:143:1: ifExpr : IF '(' mathExpr ')' '{' bodyExpr '}' -> ^( IF mathExpr bodyExpr ) ;
	[GrammarRule("ifExpr")]
	private Lang2Parser.ifExpr_return ifExpr()
	{
		Enter_ifExpr();
		EnterRule("ifExpr", 11);
		TraceIn("ifExpr", 11);
		Lang2Parser.ifExpr_return retval = new Lang2Parser.ifExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF62=null;
		IToken char_literal63=null;
		IToken char_literal65=null;
		IToken char_literal66=null;
		IToken char_literal68=null;
		Lang2Parser.mathExpr_return mathExpr64 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.bodyExpr_return bodyExpr67 = default(Lang2Parser.bodyExpr_return);

		object IF62_tree=null;
		object char_literal63_tree=null;
		object char_literal65_tree=null;
		object char_literal66_tree=null;
		object char_literal68_tree=null;
		RewriteRuleITokenStream stream_47=new RewriteRuleITokenStream(adaptor,"token 47");
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "ifExpr");
		DebugLocation(143, 2);
		try
		{
			// Lang2.g:143:8: ( IF '(' mathExpr ')' '{' bodyExpr '}' -> ^( IF mathExpr bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:143:10: IF '(' mathExpr ')' '{' bodyExpr '}'
			{
			DebugLocation(143, 10);
			IF62=(IToken)Match(input,IF,Follow._IF_in_ifExpr850);  
			stream_IF.Add(IF62);

			DebugLocation(143, 12);
			char_literal63=(IToken)Match(input,50,Follow._50_in_ifExpr851);  
			stream_50.Add(char_literal63);

			DebugLocation(143, 16);
			PushFollow(Follow._mathExpr_in_ifExpr853);
			mathExpr64=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr64.Tree);
			DebugLocation(143, 24);
			char_literal65=(IToken)Match(input,51,Follow._51_in_ifExpr854);  
			stream_51.Add(char_literal65);

			DebugLocation(143, 28);
			char_literal66=(IToken)Match(input,46,Follow._46_in_ifExpr856);  
			stream_46.Add(char_literal66);

			DebugLocation(143, 31);
			PushFollow(Follow._bodyExpr_in_ifExpr857);
			bodyExpr67=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr67.Tree);
			DebugLocation(143, 39);
			char_literal68=(IToken)Match(input,47,Follow._47_in_ifExpr858);  
			stream_47.Add(char_literal68);



			{
			// AST REWRITE
			// elements: bodyExpr, mathExpr, IF
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 143:43: -> ^( IF mathExpr bodyExpr )
			{
				DebugLocation(143, 46);
				// Lang2.g:143:46: ^( IF mathExpr bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(143, 48);
				root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

				DebugLocation(143, 51);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(143, 60);
				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ifExpr", 11);
			LeaveRule("ifExpr", 11);
			Leave_ifExpr();
		}
		DebugLocation(144, 2);
		} finally { DebugExitRule(GrammarFileName, "ifExpr"); }
		return retval;

	}
	// $ANTLR end "ifExpr"

	public class varFor_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_varFor();
	partial void Leave_varFor();

	// $ANTLR start "varFor"
	// Lang2.g:145:1: varFor : ( ID | varDecl );
	[GrammarRule("varFor")]
	private Lang2Parser.varFor_return varFor()
	{
		Enter_varFor();
		EnterRule("varFor", 12);
		TraceIn("varFor", 12);
		Lang2Parser.varFor_return retval = new Lang2Parser.varFor_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID69=null;
		Lang2Parser.varDecl_return varDecl70 = default(Lang2Parser.varDecl_return);

		object ID69_tree=null;

		try { DebugEnterRule(GrammarFileName, "varFor");
		DebugLocation(145, 2);
		try
		{
			// Lang2.g:145:8: ( ID | varDecl )
			int alt10=2;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==ID))
			{
				int LA10_1 = input.LA(2);

				if ((LA10_1==ID))
				{
					alt10=2;
				}
				else if ((LA10_1==OP_END))
				{
					alt10=1;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 10, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:145:10: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(145, 10);
				ID69=(IToken)Match(input,ID,Follow._ID_in_varFor879); 
				ID69_tree = (object)adaptor.Create(ID69);
				adaptor.AddChild(root_0, ID69_tree);


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:146:5: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(146, 5);
				PushFollow(Follow._varDecl_in_varFor885);
				varDecl70=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl70.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("varFor", 12);
			LeaveRule("varFor", 12);
			Leave_varFor();
		}
		DebugLocation(147, 2);
		} finally { DebugExitRule(GrammarFileName, "varFor"); }
		return retval;

	}
	// $ANTLR end "varFor"

	public class iterFor_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_iterFor();
	partial void Leave_iterFor();

	// $ANTLR start "iterFor"
	// Lang2.g:148:1: iterFor : ( ID ASS mathExpr | mathExpr );
	[GrammarRule("iterFor")]
	private Lang2Parser.iterFor_return iterFor()
	{
		Enter_iterFor();
		EnterRule("iterFor", 13);
		TraceIn("iterFor", 13);
		Lang2Parser.iterFor_return retval = new Lang2Parser.iterFor_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID71=null;
		IToken ASS72=null;
		Lang2Parser.mathExpr_return mathExpr73 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.mathExpr_return mathExpr74 = default(Lang2Parser.mathExpr_return);

		object ID71_tree=null;
		object ASS72_tree=null;

		try { DebugEnterRule(GrammarFileName, "iterFor");
		DebugLocation(148, 2);
		try
		{
			// Lang2.g:148:9: ( ID ASS mathExpr | mathExpr )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==ID))
			{
				int LA11_1 = input.LA(2);

				if ((LA11_1==ASS))
				{
					alt11=1;
				}
				else if ((LA11_1==TO||(LA11_1>=ADD && LA11_1<=DIV)||(LA11_1>=DISJ && LA11_1<=IS_EQUALLY)||LA11_1==48||(LA11_1>=50 && LA11_1<=51)))
				{
					alt11=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 11, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA11_0==NEW||(LA11_0>=INT && LA11_0<=STRING)||LA11_0==INVERT||LA11_0==50))
			{
				alt11=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:148:11: ID ASS mathExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(148, 11);
				ID71=(IToken)Match(input,ID,Follow._ID_in_iterFor895); 
				ID71_tree = (object)adaptor.Create(ID71);
				adaptor.AddChild(root_0, ID71_tree);

				DebugLocation(148, 17);
				ASS72=(IToken)Match(input,ASS,Follow._ASS_in_iterFor897); 
				ASS72_tree = (object)adaptor.Create(ASS72);
				root_0 = (object)adaptor.BecomeRoot(ASS72_tree, root_0);

				DebugLocation(148, 19);
				PushFollow(Follow._mathExpr_in_iterFor900);
				mathExpr73=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr73.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:149:5: mathExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(149, 5);
				PushFollow(Follow._mathExpr_in_iterFor906);
				mathExpr74=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr74.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("iterFor", 13);
			LeaveRule("iterFor", 13);
			Leave_iterFor();
		}
		DebugLocation(150, 2);
		} finally { DebugExitRule(GrammarFileName, "iterFor"); }
		return retval;

	}
	// $ANTLR end "iterFor"

	public class forLoop_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_forLoop();
	partial void Leave_forLoop();

	// $ANTLR start "forLoop"
	// Lang2.g:151:1: forLoop : FOR '(' varFor ';' mathExpr ';' iterFor ')' '{' bodyExpr '}' -> ^( FOR varFor mathExpr iterFor bodyExpr ) ;
	[GrammarRule("forLoop")]
	private Lang2Parser.forLoop_return forLoop()
	{
		Enter_forLoop();
		EnterRule("forLoop", 14);
		TraceIn("forLoop", 14);
		Lang2Parser.forLoop_return retval = new Lang2Parser.forLoop_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FOR75=null;
		IToken char_literal76=null;
		IToken char_literal78=null;
		IToken char_literal80=null;
		IToken char_literal82=null;
		IToken char_literal83=null;
		IToken char_literal85=null;
		Lang2Parser.varFor_return varFor77 = default(Lang2Parser.varFor_return);
		Lang2Parser.mathExpr_return mathExpr79 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.iterFor_return iterFor81 = default(Lang2Parser.iterFor_return);
		Lang2Parser.bodyExpr_return bodyExpr84 = default(Lang2Parser.bodyExpr_return);

		object FOR75_tree=null;
		object char_literal76_tree=null;
		object char_literal78_tree=null;
		object char_literal80_tree=null;
		object char_literal82_tree=null;
		object char_literal83_tree=null;
		object char_literal85_tree=null;
		RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
		RewriteRuleITokenStream stream_47=new RewriteRuleITokenStream(adaptor,"token 47");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_iterFor=new RewriteRuleSubtreeStream(adaptor,"rule iterFor");
		RewriteRuleSubtreeStream stream_varFor=new RewriteRuleSubtreeStream(adaptor,"rule varFor");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "forLoop");
		DebugLocation(151, 2);
		try
		{
			// Lang2.g:151:9: ( FOR '(' varFor ';' mathExpr ';' iterFor ')' '{' bodyExpr '}' -> ^( FOR varFor mathExpr iterFor bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:151:11: FOR '(' varFor ';' mathExpr ';' iterFor ')' '{' bodyExpr '}'
			{
			DebugLocation(151, 11);
			FOR75=(IToken)Match(input,FOR,Follow._FOR_in_forLoop916);  
			stream_FOR.Add(FOR75);

			DebugLocation(151, 15);
			char_literal76=(IToken)Match(input,50,Follow._50_in_forLoop918);  
			stream_50.Add(char_literal76);

			DebugLocation(151, 19);
			PushFollow(Follow._varFor_in_forLoop920);
			varFor77=varFor();
			PopFollow();

			stream_varFor.Add(varFor77.Tree);
			DebugLocation(151, 26);
			char_literal78=(IToken)Match(input,OP_END,Follow._OP_END_in_forLoop922);  
			stream_OP_END.Add(char_literal78);

			DebugLocation(151, 30);
			PushFollow(Follow._mathExpr_in_forLoop924);
			mathExpr79=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr79.Tree);
			DebugLocation(151, 39);
			char_literal80=(IToken)Match(input,OP_END,Follow._OP_END_in_forLoop926);  
			stream_OP_END.Add(char_literal80);

			DebugLocation(151, 43);
			PushFollow(Follow._iterFor_in_forLoop928);
			iterFor81=iterFor();
			PopFollow();

			stream_iterFor.Add(iterFor81.Tree);
			DebugLocation(151, 51);
			char_literal82=(IToken)Match(input,51,Follow._51_in_forLoop930);  
			stream_51.Add(char_literal82);

			DebugLocation(151, 55);
			char_literal83=(IToken)Match(input,46,Follow._46_in_forLoop932);  
			stream_46.Add(char_literal83);

			DebugLocation(151, 58);
			PushFollow(Follow._bodyExpr_in_forLoop933);
			bodyExpr84=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr84.Tree);
			DebugLocation(151, 66);
			char_literal85=(IToken)Match(input,47,Follow._47_in_forLoop934);  
			stream_47.Add(char_literal85);



			{
			// AST REWRITE
			// elements: iterFor, FOR, varFor, bodyExpr, mathExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 151:70: -> ^( FOR varFor mathExpr iterFor bodyExpr )
			{
				DebugLocation(151, 73);
				// Lang2.g:151:73: ^( FOR varFor mathExpr iterFor bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(151, 75);
				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

				DebugLocation(151, 79);
				adaptor.AddChild(root_1, stream_varFor.NextTree());
				DebugLocation(151, 86);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(151, 95);
				adaptor.AddChild(root_1, stream_iterFor.NextTree());
				DebugLocation(151, 103);
				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("forLoop", 14);
			LeaveRule("forLoop", 14);
			Leave_forLoop();
		}
		DebugLocation(152, 2);
		} finally { DebugExitRule(GrammarFileName, "forLoop"); }
		return retval;

	}
	// $ANTLR end "forLoop"

	public class whileLoop_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_whileLoop();
	partial void Leave_whileLoop();

	// $ANTLR start "whileLoop"
	// Lang2.g:153:1: whileLoop : WHILE '(' mathExpr ')' '{' bodyExpr '}' -> ^( WHILE mathExpr bodyExpr ) ;
	[GrammarRule("whileLoop")]
	private Lang2Parser.whileLoop_return whileLoop()
	{
		Enter_whileLoop();
		EnterRule("whileLoop", 15);
		TraceIn("whileLoop", 15);
		Lang2Parser.whileLoop_return retval = new Lang2Parser.whileLoop_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE86=null;
		IToken char_literal87=null;
		IToken char_literal89=null;
		IToken char_literal90=null;
		IToken char_literal92=null;
		Lang2Parser.mathExpr_return mathExpr88 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.bodyExpr_return bodyExpr91 = default(Lang2Parser.bodyExpr_return);

		object WHILE86_tree=null;
		object char_literal87_tree=null;
		object char_literal89_tree=null;
		object char_literal90_tree=null;
		object char_literal92_tree=null;
		RewriteRuleITokenStream stream_47=new RewriteRuleITokenStream(adaptor,"token 47");
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "whileLoop");
		DebugLocation(153, 3);
		try
		{
			// Lang2.g:153:11: ( WHILE '(' mathExpr ')' '{' bodyExpr '}' -> ^( WHILE mathExpr bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:153:13: WHILE '(' mathExpr ')' '{' bodyExpr '}'
			{
			DebugLocation(153, 13);
			WHILE86=(IToken)Match(input,WHILE,Follow._WHILE_in_whileLoop958);  
			stream_WHILE.Add(WHILE86);

			DebugLocation(153, 19);
			char_literal87=(IToken)Match(input,50,Follow._50_in_whileLoop960);  
			stream_50.Add(char_literal87);

			DebugLocation(153, 22);
			PushFollow(Follow._mathExpr_in_whileLoop961);
			mathExpr88=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr88.Tree);
			DebugLocation(153, 30);
			char_literal89=(IToken)Match(input,51,Follow._51_in_whileLoop962);  
			stream_51.Add(char_literal89);

			DebugLocation(153, 34);
			char_literal90=(IToken)Match(input,46,Follow._46_in_whileLoop964);  
			stream_46.Add(char_literal90);

			DebugLocation(153, 37);
			PushFollow(Follow._bodyExpr_in_whileLoop965);
			bodyExpr91=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr91.Tree);
			DebugLocation(153, 45);
			char_literal92=(IToken)Match(input,47,Follow._47_in_whileLoop966);  
			stream_47.Add(char_literal92);



			{
			// AST REWRITE
			// elements: WHILE, bodyExpr, mathExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 153:49: -> ^( WHILE mathExpr bodyExpr )
			{
				DebugLocation(153, 52);
				// Lang2.g:153:52: ^( WHILE mathExpr bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(153, 54);
				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

				DebugLocation(153, 60);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(153, 69);
				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("whileLoop", 15);
			LeaveRule("whileLoop", 15);
			Leave_whileLoop();
		}
		DebugLocation(154, 3);
		} finally { DebugExitRule(GrammarFileName, "whileLoop"); }
		return retval;

	}
	// $ANTLR end "whileLoop"

	public class doLoop_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_doLoop();
	partial void Leave_doLoop();

	// $ANTLR start "doLoop"
	// Lang2.g:155:1: doLoop : DO '{' bodyExpr '}' '(' mathExpr ')' OP_END -> ^( DO bodyExpr mathExpr ) ;
	[GrammarRule("doLoop")]
	private Lang2Parser.doLoop_return doLoop()
	{
		Enter_doLoop();
		EnterRule("doLoop", 16);
		TraceIn("doLoop", 16);
		Lang2Parser.doLoop_return retval = new Lang2Parser.doLoop_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DO93=null;
		IToken char_literal94=null;
		IToken char_literal96=null;
		IToken char_literal97=null;
		IToken char_literal99=null;
		IToken OP_END100=null;
		Lang2Parser.bodyExpr_return bodyExpr95 = default(Lang2Parser.bodyExpr_return);
		Lang2Parser.mathExpr_return mathExpr98 = default(Lang2Parser.mathExpr_return);

		object DO93_tree=null;
		object char_literal94_tree=null;
		object char_literal96_tree=null;
		object char_literal97_tree=null;
		object char_literal99_tree=null;
		object OP_END100_tree=null;
		RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_47=new RewriteRuleITokenStream(adaptor,"token 47");
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "doLoop");
		DebugLocation(155, 3);
		try
		{
			// Lang2.g:155:9: ( DO '{' bodyExpr '}' '(' mathExpr ')' OP_END -> ^( DO bodyExpr mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:155:11: DO '{' bodyExpr '}' '(' mathExpr ')' OP_END
			{
			DebugLocation(155, 11);
			DO93=(IToken)Match(input,DO,Follow._DO_in_doLoop988);  
			stream_DO.Add(DO93);

			DebugLocation(155, 14);
			char_literal94=(IToken)Match(input,46,Follow._46_in_doLoop990);  
			stream_46.Add(char_literal94);

			DebugLocation(155, 17);
			PushFollow(Follow._bodyExpr_in_doLoop991);
			bodyExpr95=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr95.Tree);
			DebugLocation(155, 25);
			char_literal96=(IToken)Match(input,47,Follow._47_in_doLoop992);  
			stream_47.Add(char_literal96);

			DebugLocation(155, 29);
			char_literal97=(IToken)Match(input,50,Follow._50_in_doLoop994);  
			stream_50.Add(char_literal97);

			DebugLocation(155, 32);
			PushFollow(Follow._mathExpr_in_doLoop995);
			mathExpr98=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr98.Tree);
			DebugLocation(155, 40);
			char_literal99=(IToken)Match(input,51,Follow._51_in_doLoop996);  
			stream_51.Add(char_literal99);

			DebugLocation(155, 44);
			OP_END100=(IToken)Match(input,OP_END,Follow._OP_END_in_doLoop998);  
			stream_OP_END.Add(OP_END100);



			{
			// AST REWRITE
			// elements: bodyExpr, DO, mathExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 155:51: -> ^( DO bodyExpr mathExpr )
			{
				DebugLocation(155, 54);
				// Lang2.g:155:54: ^( DO bodyExpr mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(155, 56);
				root_1 = (object)adaptor.BecomeRoot(stream_DO.NextNode(), root_1);

				DebugLocation(155, 59);
				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());
				DebugLocation(155, 68);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("doLoop", 16);
			LeaveRule("doLoop", 16);
			Leave_doLoop();
		}
		DebugLocation(156, 3);
		} finally { DebugExitRule(GrammarFileName, "doLoop"); }
		return retval;

	}
	// $ANTLR end "doLoop"

	public class newOp_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_newOp();
	partial void Leave_newOp();

	// $ANTLR start "newOp"
	// Lang2.g:158:1: newOp : ( NEW ID '(' ( methArgs )? ')' -> ^( NEW_CLASS ID ( methArgs )? ) | NEW ID '[' mathExpr ']' -> ^( NEW_ARR ID mathExpr ) );
	[GrammarRule("newOp")]
	private Lang2Parser.newOp_return newOp()
	{
		Enter_newOp();
		EnterRule("newOp", 17);
		TraceIn("newOp", 17);
		Lang2Parser.newOp_return retval = new Lang2Parser.newOp_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken NEW101=null;
		IToken ID102=null;
		IToken char_literal103=null;
		IToken char_literal105=null;
		IToken NEW106=null;
		IToken ID107=null;
		IToken char_literal108=null;
		IToken char_literal110=null;
		Lang2Parser.methArgs_return methArgs104 = default(Lang2Parser.methArgs_return);
		Lang2Parser.mathExpr_return mathExpr109 = default(Lang2Parser.mathExpr_return);

		object NEW101_tree=null;
		object ID102_tree=null;
		object char_literal103_tree=null;
		object char_literal105_tree=null;
		object NEW106_tree=null;
		object ID107_tree=null;
		object char_literal108_tree=null;
		object char_literal110_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_NEW=new RewriteRuleITokenStream(adaptor,"token NEW");
		RewriteRuleITokenStream stream_48=new RewriteRuleITokenStream(adaptor,"token 48");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_methArgs=new RewriteRuleSubtreeStream(adaptor,"rule methArgs");
		try { DebugEnterRule(GrammarFileName, "newOp");
		DebugLocation(158, 3);
		try
		{
			// Lang2.g:158:8: ( NEW ID '(' ( methArgs )? ')' -> ^( NEW_CLASS ID ( methArgs )? ) | NEW ID '[' mathExpr ']' -> ^( NEW_ARR ID mathExpr ) )
			int alt13=2;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==NEW))
			{
				int LA13_1 = input.LA(2);

				if ((LA13_1==ID))
				{
					int LA13_2 = input.LA(3);

					if ((LA13_2==50))
					{
						alt13=1;
					}
					else if ((LA13_2==48))
					{
						alt13=2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 13, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 13, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:158:10: NEW ID '(' ( methArgs )? ')'
				{
				DebugLocation(158, 10);
				NEW101=(IToken)Match(input,NEW,Follow._NEW_in_newOp1021);  
				stream_NEW.Add(NEW101);

				DebugLocation(158, 14);
				ID102=(IToken)Match(input,ID,Follow._ID_in_newOp1023);  
				stream_ID.Add(ID102);

				DebugLocation(158, 17);
				char_literal103=(IToken)Match(input,50,Follow._50_in_newOp1025);  
				stream_50.Add(char_literal103);

				DebugLocation(158, 20);
				// Lang2.g:158:20: ( methArgs )?
				int alt12=2;
				try { DebugEnterSubRule(12);
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0==NEW||(LA12_0>=INT && LA12_0<=STRING)||(LA12_0>=INVERT && LA12_0<=ID)||LA12_0==50))
				{
					alt12=1;
				}
				} finally { DebugExitDecision(12); }
				switch (alt12)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:158:20: methArgs
					{
					DebugLocation(158, 20);
					PushFollow(Follow._methArgs_in_newOp1026);
					methArgs104=methArgs();
					PopFollow();

					stream_methArgs.Add(methArgs104.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(12); }

				DebugLocation(158, 29);
				char_literal105=(IToken)Match(input,51,Follow._51_in_newOp1028);  
				stream_51.Add(char_literal105);



				{
				// AST REWRITE
				// elements: methArgs, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 158:33: -> ^( NEW_CLASS ID ( methArgs )? )
				{
					DebugLocation(158, 36);
					// Lang2.g:158:36: ^( NEW_CLASS ID ( methArgs )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(158, 38);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEW_CLASS, "NEW_CLASS"), root_1);

					DebugLocation(158, 48);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(158, 51);
					// Lang2.g:158:51: ( methArgs )?
					if ( stream_methArgs.HasNext )
					{
						DebugLocation(158, 51);
						adaptor.AddChild(root_1, stream_methArgs.NextTree());

					}
					stream_methArgs.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:159:6: NEW ID '[' mathExpr ']'
				{
				DebugLocation(159, 6);
				NEW106=(IToken)Match(input,NEW,Follow._NEW_in_newOp1046);  
				stream_NEW.Add(NEW106);

				DebugLocation(159, 10);
				ID107=(IToken)Match(input,ID,Follow._ID_in_newOp1048);  
				stream_ID.Add(ID107);

				DebugLocation(159, 13);
				char_literal108=(IToken)Match(input,48,Follow._48_in_newOp1050);  
				stream_48.Add(char_literal108);

				DebugLocation(159, 17);
				PushFollow(Follow._mathExpr_in_newOp1052);
				mathExpr109=mathExpr();
				PopFollow();

				stream_mathExpr.Add(mathExpr109.Tree);
				DebugLocation(159, 25);
				char_literal110=(IToken)Match(input,49,Follow._49_in_newOp1053);  
				stream_49.Add(char_literal110);



				{
				// AST REWRITE
				// elements: ID, mathExpr
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 159:29: -> ^( NEW_ARR ID mathExpr )
				{
					DebugLocation(159, 31);
					// Lang2.g:159:31: ^( NEW_ARR ID mathExpr )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(159, 33);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEW_ARR, "NEW_ARR"), root_1);

					DebugLocation(159, 41);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(159, 44);
					adaptor.AddChild(root_1, stream_mathExpr.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("newOp", 17);
			LeaveRule("newOp", 17);
			Leave_newOp();
		}
		DebugLocation(160, 3);
		} finally { DebugExitRule(GrammarFileName, "newOp"); }
		return retval;

	}
	// $ANTLR end "newOp"

	public class literals_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_literals();
	partial void Leave_literals();

	// $ANTLR start "literals"
	// Lang2.g:161:1: literals : ( INT | STRING | CHAR | DOUBLE );
	[GrammarRule("literals")]
	private Lang2Parser.literals_return literals()
	{
		Enter_literals();
		EnterRule("literals", 18);
		TraceIn("literals", 18);
		Lang2Parser.literals_return retval = new Lang2Parser.literals_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set111=null;

		object set111_tree=null;

		try { DebugEnterRule(GrammarFileName, "literals");
		DebugLocation(161, 3);
		try
		{
			// Lang2.g:161:10: ( INT | STRING | CHAR | DOUBLE )
			DebugEnterAlt(1);
			// Lang2.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(161, 10);
			set111=(IToken)input.LT(1);
			if ((input.LA(1)>=INT && input.LA(1)<=STRING))
			{
				input.Consume();
				adaptor.AddChild(root_0, (object)adaptor.Create(set111));
				state.errorRecovery=false;
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("literals", 18);
			LeaveRule("literals", 18);
			Leave_literals();
		}
		DebugLocation(162, 3);
		} finally { DebugExitRule(GrammarFileName, "literals"); }
		return retval;

	}
	// $ANTLR end "literals"

	public class incSug_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_incSug();
	partial void Leave_incSug();

	// $ANTLR start "incSug"
	// Lang2.g:163:1: incSug : ID ADD ADD -> ^( INC ID ) ;
	[GrammarRule("incSug")]
	private Lang2Parser.incSug_return incSug()
	{
		Enter_incSug();
		EnterRule("incSug", 19);
		TraceIn("incSug", 19);
		Lang2Parser.incSug_return retval = new Lang2Parser.incSug_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID112=null;
		IToken ADD113=null;
		IToken ADD114=null;

		object ID112_tree=null;
		object ADD113_tree=null;
		object ADD114_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ADD=new RewriteRuleITokenStream(adaptor,"token ADD");

		try { DebugEnterRule(GrammarFileName, "incSug");
		DebugLocation(163, 2);
		try
		{
			// Lang2.g:163:8: ( ID ADD ADD -> ^( INC ID ) )
			DebugEnterAlt(1);
			// Lang2.g:163:10: ID ADD ADD
			{
			DebugLocation(163, 10);
			ID112=(IToken)Match(input,ID,Follow._ID_in_incSug1090);  
			stream_ID.Add(ID112);

			DebugLocation(163, 13);
			ADD113=(IToken)Match(input,ADD,Follow._ADD_in_incSug1092);  
			stream_ADD.Add(ADD113);

			DebugLocation(163, 17);
			ADD114=(IToken)Match(input,ADD,Follow._ADD_in_incSug1094);  
			stream_ADD.Add(ADD114);



			{
			// AST REWRITE
			// elements: ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 163:21: -> ^( INC ID )
			{
				DebugLocation(163, 24);
				// Lang2.g:163:24: ^( INC ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(163, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INC, "INC"), root_1);

				DebugLocation(163, 30);
				adaptor.AddChild(root_1, stream_ID.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("incSug", 19);
			LeaveRule("incSug", 19);
			Leave_incSug();
		}
		DebugLocation(164, 2);
		} finally { DebugExitRule(GrammarFileName, "incSug"); }
		return retval;

	}
	// $ANTLR end "incSug"

	public class decSug_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_decSug();
	partial void Leave_decSug();

	// $ANTLR start "decSug"
	// Lang2.g:165:1: decSug : ID SUB SUB -> ^( DEC ID ) ;
	[GrammarRule("decSug")]
	private Lang2Parser.decSug_return decSug()
	{
		Enter_decSug();
		EnterRule("decSug", 20);
		TraceIn("decSug", 20);
		Lang2Parser.decSug_return retval = new Lang2Parser.decSug_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID115=null;
		IToken SUB116=null;
		IToken SUB117=null;

		object ID115_tree=null;
		object SUB116_tree=null;
		object SUB117_tree=null;
		RewriteRuleITokenStream stream_SUB=new RewriteRuleITokenStream(adaptor,"token SUB");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "decSug");
		DebugLocation(165, 2);
		try
		{
			// Lang2.g:165:8: ( ID SUB SUB -> ^( DEC ID ) )
			DebugEnterAlt(1);
			// Lang2.g:165:10: ID SUB SUB
			{
			DebugLocation(165, 10);
			ID115=(IToken)Match(input,ID,Follow._ID_in_decSug1112);  
			stream_ID.Add(ID115);

			DebugLocation(165, 13);
			SUB116=(IToken)Match(input,SUB,Follow._SUB_in_decSug1114);  
			stream_SUB.Add(SUB116);

			DebugLocation(165, 17);
			SUB117=(IToken)Match(input,SUB,Follow._SUB_in_decSug1116);  
			stream_SUB.Add(SUB117);



			{
			// AST REWRITE
			// elements: ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 165:21: -> ^( DEC ID )
			{
				DebugLocation(165, 24);
				// Lang2.g:165:24: ^( DEC ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(165, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DEC, "DEC"), root_1);

				DebugLocation(165, 30);
				adaptor.AddChild(root_1, stream_ID.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("decSug", 20);
			LeaveRule("decSug", 20);
			Leave_decSug();
		}
		DebugLocation(166, 2);
		} finally { DebugExitRule(GrammarFileName, "decSug"); }
		return retval;

	}
	// $ANTLR end "decSug"

	public class mathGroup_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathGroup();
	partial void Leave_mathGroup();

	// $ANTLR start "mathGroup"
	// Lang2.g:167:1: mathGroup : ( '(' mathExpr ')' | ID | methCall | literals | newOp | incSug | decSug | arrCall | toObjExpr );
	[GrammarRule("mathGroup")]
	private Lang2Parser.mathGroup_return mathGroup()
	{
		Enter_mathGroup();
		EnterRule("mathGroup", 21);
		TraceIn("mathGroup", 21);
		Lang2Parser.mathGroup_return retval = new Lang2Parser.mathGroup_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal118=null;
		IToken char_literal120=null;
		IToken ID121=null;
		Lang2Parser.mathExpr_return mathExpr119 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.methCall_return methCall122 = default(Lang2Parser.methCall_return);
		Lang2Parser.literals_return literals123 = default(Lang2Parser.literals_return);
		Lang2Parser.newOp_return newOp124 = default(Lang2Parser.newOp_return);
		Lang2Parser.incSug_return incSug125 = default(Lang2Parser.incSug_return);
		Lang2Parser.decSug_return decSug126 = default(Lang2Parser.decSug_return);
		Lang2Parser.arrCall_return arrCall127 = default(Lang2Parser.arrCall_return);
		Lang2Parser.toObjExpr_return toObjExpr128 = default(Lang2Parser.toObjExpr_return);

		object char_literal118_tree=null;
		object char_literal120_tree=null;
		object ID121_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathGroup");
		DebugLocation(167, 3);
		try
		{
			// Lang2.g:167:11: ( '(' mathExpr ')' | ID | methCall | literals | newOp | incSug | decSug | arrCall | toObjExpr )
			int alt14=9;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			try
			{
				alt14 = dfa14.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:167:13: '(' mathExpr ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(167, 16);
				char_literal118=(IToken)Match(input,50,Follow._50_in_mathGroup1134); 
				DebugLocation(167, 18);
				PushFollow(Follow._mathExpr_in_mathGroup1137);
				mathExpr119=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr119.Tree);
				DebugLocation(167, 30);
				char_literal120=(IToken)Match(input,51,Follow._51_in_mathGroup1139); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:168:6: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(168, 6);
				ID121=(IToken)Match(input,ID,Follow._ID_in_mathGroup1147); 
				ID121_tree = (object)adaptor.Create(ID121);
				adaptor.AddChild(root_0, ID121_tree);


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:169:6: methCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(169, 6);
				PushFollow(Follow._methCall_in_mathGroup1154);
				methCall122=methCall();
				PopFollow();

				adaptor.AddChild(root_0, methCall122.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Lang2.g:170:6: literals
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(170, 6);
				PushFollow(Follow._literals_in_mathGroup1161);
				literals123=literals();
				PopFollow();

				adaptor.AddChild(root_0, literals123.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Lang2.g:171:6: newOp
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(171, 6);
				PushFollow(Follow._newOp_in_mathGroup1168);
				newOp124=newOp();
				PopFollow();

				adaptor.AddChild(root_0, newOp124.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Lang2.g:172:6: incSug
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(172, 6);
				PushFollow(Follow._incSug_in_mathGroup1175);
				incSug125=incSug();
				PopFollow();

				adaptor.AddChild(root_0, incSug125.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Lang2.g:173:6: decSug
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(173, 6);
				PushFollow(Follow._decSug_in_mathGroup1182);
				decSug126=decSug();
				PopFollow();

				adaptor.AddChild(root_0, decSug126.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Lang2.g:174:6: arrCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(174, 6);
				PushFollow(Follow._arrCall_in_mathGroup1189);
				arrCall127=arrCall();
				PopFollow();

				adaptor.AddChild(root_0, arrCall127.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// Lang2.g:175:6: toObjExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(175, 6);
				PushFollow(Follow._toObjExpr_in_mathGroup1196);
				toObjExpr128=toObjExpr();
				PopFollow();

				adaptor.AddChild(root_0, toObjExpr128.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathGroup", 21);
			LeaveRule("mathGroup", 21);
			Leave_mathGroup();
		}
		DebugLocation(176, 3);
		} finally { DebugExitRule(GrammarFileName, "mathGroup"); }
		return retval;

	}
	// $ANTLR end "mathGroup"

	public class mathNeg_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathNeg();
	partial void Leave_mathNeg();

	// $ANTLR start "mathNeg"
	// Lang2.g:177:1: mathNeg : ( ( INVERT mathGroup ) | ( mathGroup ) );
	[GrammarRule("mathNeg")]
	private Lang2Parser.mathNeg_return mathNeg()
	{
		Enter_mathNeg();
		EnterRule("mathNeg", 22);
		TraceIn("mathNeg", 22);
		Lang2Parser.mathNeg_return retval = new Lang2Parser.mathNeg_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken INVERT129=null;
		Lang2Parser.mathGroup_return mathGroup130 = default(Lang2Parser.mathGroup_return);
		Lang2Parser.mathGroup_return mathGroup131 = default(Lang2Parser.mathGroup_return);

		object INVERT129_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathNeg");
		DebugLocation(177, 3);
		try
		{
			// Lang2.g:177:10: ( ( INVERT mathGroup ) | ( mathGroup ) )
			int alt15=2;
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if ((LA15_0==INVERT))
			{
				alt15=1;
			}
			else if ((LA15_0==NEW||(LA15_0>=INT && LA15_0<=STRING)||LA15_0==ID||LA15_0==50))
			{
				alt15=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 15, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:177:12: ( INVERT mathGroup )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(177, 12);
				// Lang2.g:177:12: ( INVERT mathGroup )
				DebugEnterAlt(1);
				// Lang2.g:177:13: INVERT mathGroup
				{
				DebugLocation(177, 19);
				INVERT129=(IToken)Match(input,INVERT,Follow._INVERT_in_mathNeg1209); 
				INVERT129_tree = (object)adaptor.Create(INVERT129);
				root_0 = (object)adaptor.BecomeRoot(INVERT129_tree, root_0);

				DebugLocation(177, 21);
				PushFollow(Follow._mathGroup_in_mathNeg1212);
				mathGroup130=mathGroup();
				PopFollow();

				adaptor.AddChild(root_0, mathGroup130.Tree);

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:178:6: ( mathGroup )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(178, 6);
				// Lang2.g:178:6: ( mathGroup )
				DebugEnterAlt(1);
				// Lang2.g:178:7: mathGroup
				{
				DebugLocation(178, 7);
				PushFollow(Follow._mathGroup_in_mathNeg1221);
				mathGroup131=mathGroup();
				PopFollow();

				adaptor.AddChild(root_0, mathGroup131.Tree);

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathNeg", 22);
			LeaveRule("mathNeg", 22);
			Leave_mathNeg();
		}
		DebugLocation(179, 3);
		} finally { DebugExitRule(GrammarFileName, "mathNeg"); }
		return retval;

	}
	// $ANTLR end "mathNeg"

	public class mathConj_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathConj();
	partial void Leave_mathConj();

	// $ANTLR start "mathConj"
	// Lang2.g:180:1: mathConj : mathNeg ( CONJ mathNeg )* ;
	[GrammarRule("mathConj")]
	private Lang2Parser.mathConj_return mathConj()
	{
		Enter_mathConj();
		EnterRule("mathConj", 23);
		TraceIn("mathConj", 23);
		Lang2Parser.mathConj_return retval = new Lang2Parser.mathConj_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CONJ133=null;
		Lang2Parser.mathNeg_return mathNeg132 = default(Lang2Parser.mathNeg_return);
		Lang2Parser.mathNeg_return mathNeg134 = default(Lang2Parser.mathNeg_return);

		object CONJ133_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathConj");
		DebugLocation(180, 3);
		try
		{
			// Lang2.g:180:10: ( mathNeg ( CONJ mathNeg )* )
			DebugEnterAlt(1);
			// Lang2.g:180:12: mathNeg ( CONJ mathNeg )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(180, 12);
			PushFollow(Follow._mathNeg_in_mathConj1233);
			mathNeg132=mathNeg();
			PopFollow();

			adaptor.AddChild(root_0, mathNeg132.Tree);
			DebugLocation(180, 19);
			// Lang2.g:180:19: ( CONJ mathNeg )*
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0==CONJ))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch ( alt16 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:180:20: CONJ mathNeg
					{
					DebugLocation(180, 24);
					CONJ133=(IToken)Match(input,CONJ,Follow._CONJ_in_mathConj1235); 
					CONJ133_tree = (object)adaptor.Create(CONJ133);
					root_0 = (object)adaptor.BecomeRoot(CONJ133_tree, root_0);

					DebugLocation(180, 26);
					PushFollow(Follow._mathNeg_in_mathConj1238);
					mathNeg134=mathNeg();
					PopFollow();

					adaptor.AddChild(root_0, mathNeg134.Tree);

					}
					break;

				default:
					goto loop16;
				}
			}

			loop16:
				;

			} finally { DebugExitSubRule(16); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathConj", 23);
			LeaveRule("mathConj", 23);
			Leave_mathConj();
		}
		DebugLocation(181, 3);
		} finally { DebugExitRule(GrammarFileName, "mathConj"); }
		return retval;

	}
	// $ANTLR end "mathConj"

	public class mathDisj_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathDisj();
	partial void Leave_mathDisj();

	// $ANTLR start "mathDisj"
	// Lang2.g:182:1: mathDisj : mathConj ( DISJ mathConj )* ;
	[GrammarRule("mathDisj")]
	private Lang2Parser.mathDisj_return mathDisj()
	{
		Enter_mathDisj();
		EnterRule("mathDisj", 24);
		TraceIn("mathDisj", 24);
		Lang2Parser.mathDisj_return retval = new Lang2Parser.mathDisj_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DISJ136=null;
		Lang2Parser.mathConj_return mathConj135 = default(Lang2Parser.mathConj_return);
		Lang2Parser.mathConj_return mathConj137 = default(Lang2Parser.mathConj_return);

		object DISJ136_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathDisj");
		DebugLocation(182, 3);
		try
		{
			// Lang2.g:182:10: ( mathConj ( DISJ mathConj )* )
			DebugEnterAlt(1);
			// Lang2.g:182:12: mathConj ( DISJ mathConj )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(182, 12);
			PushFollow(Follow._mathConj_in_mathDisj1251);
			mathConj135=mathConj();
			PopFollow();

			adaptor.AddChild(root_0, mathConj135.Tree);
			DebugLocation(182, 20);
			// Lang2.g:182:20: ( DISJ mathConj )*
			try { DebugEnterSubRule(17);
			while (true)
			{
				int alt17=2;
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				int LA17_0 = input.LA(1);

				if ((LA17_0==DISJ))
				{
					alt17=1;
				}


				} finally { DebugExitDecision(17); }
				switch ( alt17 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:182:21: DISJ mathConj
					{
					DebugLocation(182, 25);
					DISJ136=(IToken)Match(input,DISJ,Follow._DISJ_in_mathDisj1253); 
					DISJ136_tree = (object)adaptor.Create(DISJ136);
					root_0 = (object)adaptor.BecomeRoot(DISJ136_tree, root_0);

					DebugLocation(182, 27);
					PushFollow(Follow._mathConj_in_mathDisj1256);
					mathConj137=mathConj();
					PopFollow();

					adaptor.AddChild(root_0, mathConj137.Tree);

					}
					break;

				default:
					goto loop17;
				}
			}

			loop17:
				;

			} finally { DebugExitSubRule(17); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathDisj", 24);
			LeaveRule("mathDisj", 24);
			Leave_mathDisj();
		}
		DebugLocation(183, 3);
		} finally { DebugExitRule(GrammarFileName, "mathDisj"); }
		return retval;

	}
	// $ANTLR end "mathDisj"

	public class mathEq_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathEq();
	partial void Leave_mathEq();

	// $ANTLR start "mathEq"
	// Lang2.g:184:1: mathEq : mathDisj ( ( IS_MORE | IS_LESS | IS_EQUALLY ) mathDisj )* ;
	[GrammarRule("mathEq")]
	private Lang2Parser.mathEq_return mathEq()
	{
		Enter_mathEq();
		EnterRule("mathEq", 25);
		TraceIn("mathEq", 25);
		Lang2Parser.mathEq_return retval = new Lang2Parser.mathEq_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set139=null;
		Lang2Parser.mathDisj_return mathDisj138 = default(Lang2Parser.mathDisj_return);
		Lang2Parser.mathDisj_return mathDisj140 = default(Lang2Parser.mathDisj_return);

		object set139_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathEq");
		DebugLocation(184, 3);
		try
		{
			// Lang2.g:184:9: ( mathDisj ( ( IS_MORE | IS_LESS | IS_EQUALLY ) mathDisj )* )
			DebugEnterAlt(1);
			// Lang2.g:184:11: mathDisj ( ( IS_MORE | IS_LESS | IS_EQUALLY ) mathDisj )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(184, 11);
			PushFollow(Follow._mathDisj_in_mathEq1270);
			mathDisj138=mathDisj();
			PopFollow();

			adaptor.AddChild(root_0, mathDisj138.Tree);
			DebugLocation(184, 19);
			// Lang2.g:184:19: ( ( IS_MORE | IS_LESS | IS_EQUALLY ) mathDisj )*
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=2;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if (((LA18_0>=IS_MORE && LA18_0<=IS_EQUALLY)))
				{
					alt18=1;
				}


				} finally { DebugExitDecision(18); }
				switch ( alt18 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:184:20: ( IS_MORE | IS_LESS | IS_EQUALLY ) mathDisj
					{
					DebugLocation(184, 20);
					set139=(IToken)input.LT(1);
					set139=(IToken)input.LT(1);
					if ((input.LA(1)>=IS_MORE && input.LA(1)<=IS_EQUALLY))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set139), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(184, 50);
					PushFollow(Follow._mathDisj_in_mathEq1281);
					mathDisj140=mathDisj();
					PopFollow();

					adaptor.AddChild(root_0, mathDisj140.Tree);

					}
					break;

				default:
					goto loop18;
				}
			}

			loop18:
				;

			} finally { DebugExitSubRule(18); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathEq", 25);
			LeaveRule("mathEq", 25);
			Leave_mathEq();
		}
		DebugLocation(185, 3);
		} finally { DebugExitRule(GrammarFileName, "mathEq"); }
		return retval;

	}
	// $ANTLR end "mathEq"

	public class mathMult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathMult();
	partial void Leave_mathMult();

	// $ANTLR start "mathMult"
	// Lang2.g:186:1: mathMult : mathEq ( ( MULT | DIV ) mathEq )* ;
	[GrammarRule("mathMult")]
	private Lang2Parser.mathMult_return mathMult()
	{
		Enter_mathMult();
		EnterRule("mathMult", 26);
		TraceIn("mathMult", 26);
		Lang2Parser.mathMult_return retval = new Lang2Parser.mathMult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set142=null;
		Lang2Parser.mathEq_return mathEq141 = default(Lang2Parser.mathEq_return);
		Lang2Parser.mathEq_return mathEq143 = default(Lang2Parser.mathEq_return);

		object set142_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathMult");
		DebugLocation(186, 3);
		try
		{
			// Lang2.g:186:10: ( mathEq ( ( MULT | DIV ) mathEq )* )
			DebugEnterAlt(1);
			// Lang2.g:186:12: mathEq ( ( MULT | DIV ) mathEq )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(186, 12);
			PushFollow(Follow._mathEq_in_mathMult1294);
			mathEq141=mathEq();
			PopFollow();

			adaptor.AddChild(root_0, mathEq141.Tree);
			DebugLocation(186, 18);
			// Lang2.g:186:18: ( ( MULT | DIV ) mathEq )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if (((LA19_0>=MULT && LA19_0<=DIV)))
				{
					alt19=1;
				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:186:19: ( MULT | DIV ) mathEq
					{
					DebugLocation(186, 19);
					set142=(IToken)input.LT(1);
					set142=(IToken)input.LT(1);
					if ((input.LA(1)>=MULT && input.LA(1)<=DIV))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set142), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(186, 30);
					PushFollow(Follow._mathEq_in_mathMult1302);
					mathEq143=mathEq();
					PopFollow();

					adaptor.AddChild(root_0, mathEq143.Tree);

					}
					break;

				default:
					goto loop19;
				}
			}

			loop19:
				;

			} finally { DebugExitSubRule(19); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathMult", 26);
			LeaveRule("mathMult", 26);
			Leave_mathMult();
		}
		DebugLocation(187, 3);
		} finally { DebugExitRule(GrammarFileName, "mathMult"); }
		return retval;

	}
	// $ANTLR end "mathMult"

	public class mathAdd_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathAdd();
	partial void Leave_mathAdd();

	// $ANTLR start "mathAdd"
	// Lang2.g:188:1: mathAdd : mathMult ( ( ADD | SUB ) mathMult )* ;
	[GrammarRule("mathAdd")]
	private Lang2Parser.mathAdd_return mathAdd()
	{
		Enter_mathAdd();
		EnterRule("mathAdd", 27);
		TraceIn("mathAdd", 27);
		Lang2Parser.mathAdd_return retval = new Lang2Parser.mathAdd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set145=null;
		Lang2Parser.mathMult_return mathMult144 = default(Lang2Parser.mathMult_return);
		Lang2Parser.mathMult_return mathMult146 = default(Lang2Parser.mathMult_return);

		object set145_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathAdd");
		DebugLocation(188, 3);
		try
		{
			// Lang2.g:188:10: ( mathMult ( ( ADD | SUB ) mathMult )* )
			DebugEnterAlt(1);
			// Lang2.g:188:12: mathMult ( ( ADD | SUB ) mathMult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(188, 12);
			PushFollow(Follow._mathMult_in_mathAdd1316);
			mathMult144=mathMult();
			PopFollow();

			adaptor.AddChild(root_0, mathMult144.Tree);
			DebugLocation(188, 20);
			// Lang2.g:188:20: ( ( ADD | SUB ) mathMult )*
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if (((LA20_0>=ADD && LA20_0<=SUB)))
				{
					alt20=1;
				}


				} finally { DebugExitDecision(20); }
				switch ( alt20 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:188:21: ( ADD | SUB ) mathMult
					{
					DebugLocation(188, 21);
					set145=(IToken)input.LT(1);
					set145=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set145), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(188, 32);
					PushFollow(Follow._mathMult_in_mathAdd1325);
					mathMult146=mathMult();
					PopFollow();

					adaptor.AddChild(root_0, mathMult146.Tree);

					}
					break;

				default:
					goto loop20;
				}
			}

			loop20:
				;

			} finally { DebugExitSubRule(20); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathAdd", 27);
			LeaveRule("mathAdd", 27);
			Leave_mathAdd();
		}
		DebugLocation(189, 3);
		} finally { DebugExitRule(GrammarFileName, "mathAdd"); }
		return retval;

	}
	// $ANTLR end "mathAdd"

	public class mathExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathExpr();
	partial void Leave_mathExpr();

	// $ANTLR start "mathExpr"
	// Lang2.g:190:1: mathExpr : mathAdd ;
	[GrammarRule("mathExpr")]
	private Lang2Parser.mathExpr_return mathExpr()
	{
		Enter_mathExpr();
		EnterRule("mathExpr", 28);
		TraceIn("mathExpr", 28);
		Lang2Parser.mathExpr_return retval = new Lang2Parser.mathExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.mathAdd_return mathAdd147 = default(Lang2Parser.mathAdd_return);


		try { DebugEnterRule(GrammarFileName, "mathExpr");
		DebugLocation(190, 3);
		try
		{
			// Lang2.g:190:10: ( mathAdd )
			DebugEnterAlt(1);
			// Lang2.g:190:12: mathAdd
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(190, 12);
			PushFollow(Follow._mathAdd_in_mathExpr1338);
			mathAdd147=mathAdd();
			PopFollow();

			adaptor.AddChild(root_0, mathAdd147.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathExpr", 28);
			LeaveRule("mathExpr", 28);
			Leave_mathExpr();
		}
		DebugLocation(191, 3);
		} finally { DebugExitRule(GrammarFileName, "mathExpr"); }
		return retval;

	}
	// $ANTLR end "mathExpr"

	public class methArgs_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methArgs();
	partial void Leave_methArgs();

	// $ANTLR start "methArgs"
	// Lang2.g:195:1: methArgs : mathExpr ( ',' mathExpr )* -> ^( CALL_ARGS mathExpr ( mathExpr )* ) ;
	[GrammarRule("methArgs")]
	private Lang2Parser.methArgs_return methArgs()
	{
		Enter_methArgs();
		EnterRule("methArgs", 29);
		TraceIn("methArgs", 29);
		Lang2Parser.methArgs_return retval = new Lang2Parser.methArgs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal149=null;
		Lang2Parser.mathExpr_return mathExpr148 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.mathExpr_return mathExpr150 = default(Lang2Parser.mathExpr_return);

		object char_literal149_tree=null;
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		try { DebugEnterRule(GrammarFileName, "methArgs");
		DebugLocation(195, 3);
		try
		{
			// Lang2.g:195:10: ( mathExpr ( ',' mathExpr )* -> ^( CALL_ARGS mathExpr ( mathExpr )* ) )
			DebugEnterAlt(1);
			// Lang2.g:195:12: mathExpr ( ',' mathExpr )*
			{
			DebugLocation(195, 12);
			PushFollow(Follow._mathExpr_in_methArgs1352);
			mathExpr148=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr148.Tree);
			DebugLocation(195, 21);
			// Lang2.g:195:21: ( ',' mathExpr )*
			try { DebugEnterSubRule(21);
			while (true)
			{
				int alt21=2;
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if ((LA21_0==52))
				{
					alt21=1;
				}


				} finally { DebugExitDecision(21); }
				switch ( alt21 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:195:22: ',' mathExpr
					{
					DebugLocation(195, 22);
					char_literal149=(IToken)Match(input,52,Follow._52_in_methArgs1355);  
					stream_52.Add(char_literal149);

					DebugLocation(195, 26);
					PushFollow(Follow._mathExpr_in_methArgs1357);
					mathExpr150=mathExpr();
					PopFollow();

					stream_mathExpr.Add(mathExpr150.Tree);

					}
					break;

				default:
					goto loop21;
				}
			}

			loop21:
				;

			} finally { DebugExitSubRule(21); }



			{
			// AST REWRITE
			// elements: mathExpr, mathExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 195:37: -> ^( CALL_ARGS mathExpr ( mathExpr )* )
			{
				DebugLocation(195, 40);
				// Lang2.g:195:40: ^( CALL_ARGS mathExpr ( mathExpr )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(195, 42);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL_ARGS, "CALL_ARGS"), root_1);

				DebugLocation(195, 52);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(195, 61);
				// Lang2.g:195:61: ( mathExpr )*
				while ( stream_mathExpr.HasNext )
				{
					DebugLocation(195, 61);
					adaptor.AddChild(root_1, stream_mathExpr.NextTree());

				}
				stream_mathExpr.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methArgs", 29);
			LeaveRule("methArgs", 29);
			Leave_methArgs();
		}
		DebugLocation(196, 3);
		} finally { DebugExitRule(GrammarFileName, "methArgs"); }
		return retval;

	}
	// $ANTLR end "methArgs"

	public class methCall_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methCall();
	partial void Leave_methCall();

	// $ANTLR start "methCall"
	// Lang2.g:197:1: methCall : ID '(' ( methArgs )? ')' -> ^( METH_CALL ID ( methArgs )? ) ;
	[GrammarRule("methCall")]
	private Lang2Parser.methCall_return methCall()
	{
		Enter_methCall();
		EnterRule("methCall", 30);
		TraceIn("methCall", 30);
		Lang2Parser.methCall_return retval = new Lang2Parser.methCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID151=null;
		IToken char_literal152=null;
		IToken char_literal154=null;
		Lang2Parser.methArgs_return methArgs153 = default(Lang2Parser.methArgs_return);

		object ID151_tree=null;
		object char_literal152_tree=null;
		object char_literal154_tree=null;
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_methArgs=new RewriteRuleSubtreeStream(adaptor,"rule methArgs");
		try { DebugEnterRule(GrammarFileName, "methCall");
		DebugLocation(197, 3);
		try
		{
			// Lang2.g:197:10: ( ID '(' ( methArgs )? ')' -> ^( METH_CALL ID ( methArgs )? ) )
			DebugEnterAlt(1);
			// Lang2.g:197:12: ID '(' ( methArgs )? ')'
			{
			DebugLocation(197, 12);
			ID151=(IToken)Match(input,ID,Follow._ID_in_methCall1382);  
			stream_ID.Add(ID151);

			DebugLocation(197, 14);
			char_literal152=(IToken)Match(input,50,Follow._50_in_methCall1383);  
			stream_50.Add(char_literal152);

			DebugLocation(197, 17);
			// Lang2.g:197:17: ( methArgs )?
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if ((LA22_0==NEW||(LA22_0>=INT && LA22_0<=STRING)||(LA22_0>=INVERT && LA22_0<=ID)||LA22_0==50))
			{
				alt22=1;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:197:17: methArgs
				{
				DebugLocation(197, 17);
				PushFollow(Follow._methArgs_in_methCall1384);
				methArgs153=methArgs();
				PopFollow();

				stream_methArgs.Add(methArgs153.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(22); }

			DebugLocation(197, 26);
			char_literal154=(IToken)Match(input,51,Follow._51_in_methCall1386);  
			stream_51.Add(char_literal154);



			{
			// AST REWRITE
			// elements: ID, methArgs
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 197:30: -> ^( METH_CALL ID ( methArgs )? )
			{
				DebugLocation(197, 33);
				// Lang2.g:197:33: ^( METH_CALL ID ( methArgs )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(197, 35);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METH_CALL, "METH_CALL"), root_1);

				DebugLocation(197, 45);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(197, 48);
				// Lang2.g:197:48: ( methArgs )?
				if ( stream_methArgs.HasNext )
				{
					DebugLocation(197, 48);
					adaptor.AddChild(root_1, stream_methArgs.NextTree());

				}
				stream_methArgs.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methCall", 30);
			LeaveRule("methCall", 30);
			Leave_methCall();
		}
		DebugLocation(198, 3);
		} finally { DebugExitRule(GrammarFileName, "methCall"); }
		return retval;

	}
	// $ANTLR end "methCall"

	public class methArgODecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methArgODecl();
	partial void Leave_methArgODecl();

	// $ANTLR start "methArgODecl"
	// Lang2.g:199:1: methArgODecl : ( ID ID -> ^( VAR_DECL ID ID ) | ID '[' ']' ID -> ^( ARR_DECL ID ID ) );
	[GrammarRule("methArgODecl")]
	private Lang2Parser.methArgODecl_return methArgODecl()
	{
		Enter_methArgODecl();
		EnterRule("methArgODecl", 31);
		TraceIn("methArgODecl", 31);
		Lang2Parser.methArgODecl_return retval = new Lang2Parser.methArgODecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID155=null;
		IToken ID156=null;
		IToken ID157=null;
		IToken char_literal158=null;
		IToken char_literal159=null;
		IToken ID160=null;

		object ID155_tree=null;
		object ID156_tree=null;
		object ID157_tree=null;
		object char_literal158_tree=null;
		object char_literal159_tree=null;
		object ID160_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_48=new RewriteRuleITokenStream(adaptor,"token 48");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "methArgODecl");
		DebugLocation(199, 4);
		try
		{
			// Lang2.g:199:14: ( ID ID -> ^( VAR_DECL ID ID ) | ID '[' ']' ID -> ^( ARR_DECL ID ID ) )
			int alt23=2;
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if ((LA23_0==ID))
			{
				int LA23_1 = input.LA(2);

				if ((LA23_1==ID))
				{
					alt23=1;
				}
				else if ((LA23_1==48))
				{
					alt23=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 23, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:199:16: ID ID
				{
				DebugLocation(199, 16);
				ID155=(IToken)Match(input,ID,Follow._ID_in_methArgODecl1408);  
				stream_ID.Add(ID155);

				DebugLocation(199, 19);
				ID156=(IToken)Match(input,ID,Follow._ID_in_methArgODecl1410);  
				stream_ID.Add(ID156);



				{
				// AST REWRITE
				// elements: ID, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 199:22: -> ^( VAR_DECL ID ID )
				{
					DebugLocation(199, 25);
					// Lang2.g:199:25: ^( VAR_DECL ID ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(199, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

					DebugLocation(199, 36);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(199, 39);
					adaptor.AddChild(root_1, stream_ID.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:200:7: ID '[' ']' ID
				{
				DebugLocation(200, 7);
				ID157=(IToken)Match(input,ID,Follow._ID_in_methArgODecl1428);  
				stream_ID.Add(ID157);

				DebugLocation(200, 9);
				char_literal158=(IToken)Match(input,48,Follow._48_in_methArgODecl1429);  
				stream_48.Add(char_literal158);

				DebugLocation(200, 12);
				char_literal159=(IToken)Match(input,49,Follow._49_in_methArgODecl1430);  
				stream_49.Add(char_literal159);

				DebugLocation(200, 16);
				ID160=(IToken)Match(input,ID,Follow._ID_in_methArgODecl1432);  
				stream_ID.Add(ID160);



				{
				// AST REWRITE
				// elements: ID, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 200:19: -> ^( ARR_DECL ID ID )
				{
					DebugLocation(200, 22);
					// Lang2.g:200:22: ^( ARR_DECL ID ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(200, 24);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

					DebugLocation(200, 33);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(200, 36);
					adaptor.AddChild(root_1, stream_ID.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methArgODecl", 31);
			LeaveRule("methArgODecl", 31);
			Leave_methArgODecl();
		}
		DebugLocation(201, 4);
		} finally { DebugExitRule(GrammarFileName, "methArgODecl"); }
		return retval;

	}
	// $ANTLR end "methArgODecl"

	public class methDeclArgs_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methDeclArgs();
	partial void Leave_methDeclArgs();

	// $ANTLR start "methDeclArgs"
	// Lang2.g:203:1: methDeclArgs : methArgODecl ( ',' methArgODecl )* ;
	[GrammarRule("methDeclArgs")]
	private Lang2Parser.methDeclArgs_return methDeclArgs()
	{
		Enter_methDeclArgs();
		EnterRule("methDeclArgs", 32);
		TraceIn("methDeclArgs", 32);
		Lang2Parser.methDeclArgs_return retval = new Lang2Parser.methDeclArgs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal162=null;
		Lang2Parser.methArgODecl_return methArgODecl161 = default(Lang2Parser.methArgODecl_return);
		Lang2Parser.methArgODecl_return methArgODecl163 = default(Lang2Parser.methArgODecl_return);

		object char_literal162_tree=null;

		try { DebugEnterRule(GrammarFileName, "methDeclArgs");
		DebugLocation(203, 4);
		try
		{
			// Lang2.g:203:14: ( methArgODecl ( ',' methArgODecl )* )
			DebugEnterAlt(1);
			// Lang2.g:203:16: methArgODecl ( ',' methArgODecl )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(203, 16);
			PushFollow(Follow._methArgODecl_in_methDeclArgs1455);
			methArgODecl161=methArgODecl();
			PopFollow();

			adaptor.AddChild(root_0, methArgODecl161.Tree);
			DebugLocation(203, 28);
			// Lang2.g:203:28: ( ',' methArgODecl )*
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==52))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch ( alt24 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:203:29: ',' methArgODecl
					{
					DebugLocation(203, 32);
					char_literal162=(IToken)Match(input,52,Follow._52_in_methDeclArgs1457); 
					DebugLocation(203, 33);
					PushFollow(Follow._methArgODecl_in_methDeclArgs1459);
					methArgODecl163=methArgODecl();
					PopFollow();

					adaptor.AddChild(root_0, methArgODecl163.Tree);

					}
					break;

				default:
					goto loop24;
				}
			}

			loop24:
				;

			} finally { DebugExitSubRule(24); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methDeclArgs", 32);
			LeaveRule("methDeclArgs", 32);
			Leave_methDeclArgs();
		}
		DebugLocation(204, 4);
		} finally { DebugExitRule(GrammarFileName, "methDeclArgs"); }
		return retval;

	}
	// $ANTLR end "methDeclArgs"

	public class methDeclArgsW_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methDeclArgsW();
	partial void Leave_methDeclArgsW();

	// $ANTLR start "methDeclArgsW"
	// Lang2.g:205:1: methDeclArgsW : ( methDeclArgs )? -> ^( DECL_ARGS ( methDeclArgs )? ) ;
	[GrammarRule("methDeclArgsW")]
	private Lang2Parser.methDeclArgsW_return methDeclArgsW()
	{
		Enter_methDeclArgsW();
		EnterRule("methDeclArgsW", 33);
		TraceIn("methDeclArgsW", 33);
		Lang2Parser.methDeclArgsW_return retval = new Lang2Parser.methDeclArgsW_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.methDeclArgs_return methDeclArgs164 = default(Lang2Parser.methDeclArgs_return);

		RewriteRuleSubtreeStream stream_methDeclArgs=new RewriteRuleSubtreeStream(adaptor,"rule methDeclArgs");
		try { DebugEnterRule(GrammarFileName, "methDeclArgsW");
		DebugLocation(205, 4);
		try
		{
			// Lang2.g:205:15: ( ( methDeclArgs )? -> ^( DECL_ARGS ( methDeclArgs )? ) )
			DebugEnterAlt(1);
			// Lang2.g:205:17: ( methDeclArgs )?
			{
			DebugLocation(205, 17);
			// Lang2.g:205:17: ( methDeclArgs )?
			int alt25=2;
			try { DebugEnterSubRule(25);
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			int LA25_0 = input.LA(1);

			if ((LA25_0==ID))
			{
				alt25=1;
			}
			} finally { DebugExitDecision(25); }
			switch (alt25)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:205:17: methDeclArgs
				{
				DebugLocation(205, 17);
				PushFollow(Follow._methDeclArgs_in_methDeclArgsW1473);
				methDeclArgs164=methDeclArgs();
				PopFollow();

				stream_methDeclArgs.Add(methDeclArgs164.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(25); }



			{
			// AST REWRITE
			// elements: methDeclArgs
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 205:31: -> ^( DECL_ARGS ( methDeclArgs )? )
			{
				DebugLocation(205, 34);
				// Lang2.g:205:34: ^( DECL_ARGS ( methDeclArgs )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(205, 36);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECL_ARGS, "DECL_ARGS"), root_1);

				DebugLocation(205, 46);
				// Lang2.g:205:46: ( methDeclArgs )?
				if ( stream_methDeclArgs.HasNext )
				{
					DebugLocation(205, 46);
					adaptor.AddChild(root_1, stream_methDeclArgs.NextTree());

				}
				stream_methDeclArgs.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methDeclArgsW", 33);
			LeaveRule("methDeclArgsW", 33);
			Leave_methDeclArgsW();
		}
		DebugLocation(206, 4);
		} finally { DebugExitRule(GrammarFileName, "methDeclArgsW"); }
		return retval;

	}
	// $ANTLR end "methDeclArgsW"

	public class methRetType_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methRetType();
	partial void Leave_methRetType();

	// $ANTLR start "methRetType"
	// Lang2.g:208:1: methRetType : ( ID -> ^( RET_TYPE_SINGLE ID ) | ID '[' ']' -> ^( RET_TYPE_ARR ID ) );
	[GrammarRule("methRetType")]
	private Lang2Parser.methRetType_return methRetType()
	{
		Enter_methRetType();
		EnterRule("methRetType", 34);
		TraceIn("methRetType", 34);
		Lang2Parser.methRetType_return retval = new Lang2Parser.methRetType_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID165=null;
		IToken ID166=null;
		IToken char_literal167=null;
		IToken char_literal168=null;

		object ID165_tree=null;
		object ID166_tree=null;
		object char_literal167_tree=null;
		object char_literal168_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_48=new RewriteRuleITokenStream(adaptor,"token 48");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "methRetType");
		DebugLocation(208, 3);
		try
		{
			// Lang2.g:208:13: ( ID -> ^( RET_TYPE_SINGLE ID ) | ID '[' ']' -> ^( RET_TYPE_ARR ID ) )
			int alt26=2;
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			int LA26_0 = input.LA(1);

			if ((LA26_0==ID))
			{
				int LA26_1 = input.LA(2);

				if ((LA26_1==48))
				{
					alt26=2;
				}
				else if ((LA26_1==ID))
				{
					alt26=1;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 26, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 26, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(26); }
			switch (alt26)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:208:15: ID
				{
				DebugLocation(208, 15);
				ID165=(IToken)Match(input,ID,Follow._ID_in_methRetType1496);  
				stream_ID.Add(ID165);



				{
				// AST REWRITE
				// elements: ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 208:18: -> ^( RET_TYPE_SINGLE ID )
				{
					DebugLocation(208, 20);
					// Lang2.g:208:20: ^( RET_TYPE_SINGLE ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(208, 22);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RET_TYPE_SINGLE, "RET_TYPE_SINGLE"), root_1);

					DebugLocation(208, 38);
					adaptor.AddChild(root_1, stream_ID.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:209:6: ID '[' ']'
				{
				DebugLocation(209, 6);
				ID166=(IToken)Match(input,ID,Follow._ID_in_methRetType1510);  
				stream_ID.Add(ID166);

				DebugLocation(209, 8);
				char_literal167=(IToken)Match(input,48,Follow._48_in_methRetType1511);  
				stream_48.Add(char_literal167);

				DebugLocation(209, 11);
				char_literal168=(IToken)Match(input,49,Follow._49_in_methRetType1512);  
				stream_49.Add(char_literal168);



				{
				// AST REWRITE
				// elements: ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 209:15: -> ^( RET_TYPE_ARR ID )
				{
					DebugLocation(209, 18);
					// Lang2.g:209:18: ^( RET_TYPE_ARR ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(209, 20);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RET_TYPE_ARR, "RET_TYPE_ARR"), root_1);

					DebugLocation(209, 33);
					adaptor.AddChild(root_1, stream_ID.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methRetType", 34);
			LeaveRule("methRetType", 34);
			Leave_methRetType();
		}
		DebugLocation(210, 3);
		} finally { DebugExitRule(GrammarFileName, "methRetType"); }
		return retval;

	}
	// $ANTLR end "methRetType"

	public class methDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methDecl();
	partial void Leave_methDecl();

	// $ANTLR start "methDecl"
	// Lang2.g:211:1: methDecl : methRetType ID '(' methDeclArgsW ')' '{' bodyExpr '}' -> ^( METH_DECL methRetType ID methDeclArgsW bodyExpr ) ;
	[GrammarRule("methDecl")]
	private Lang2Parser.methDecl_return methDecl()
	{
		Enter_methDecl();
		EnterRule("methDecl", 35);
		TraceIn("methDecl", 35);
		Lang2Parser.methDecl_return retval = new Lang2Parser.methDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID170=null;
		IToken char_literal171=null;
		IToken char_literal173=null;
		IToken char_literal174=null;
		IToken char_literal176=null;
		Lang2Parser.methRetType_return methRetType169 = default(Lang2Parser.methRetType_return);
		Lang2Parser.methDeclArgsW_return methDeclArgsW172 = default(Lang2Parser.methDeclArgsW_return);
		Lang2Parser.bodyExpr_return bodyExpr175 = default(Lang2Parser.bodyExpr_return);

		object ID170_tree=null;
		object char_literal171_tree=null;
		object char_literal173_tree=null;
		object char_literal174_tree=null;
		object char_literal176_tree=null;
		RewriteRuleITokenStream stream_47=new RewriteRuleITokenStream(adaptor,"token 47");
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		RewriteRuleSubtreeStream stream_methDeclArgsW=new RewriteRuleSubtreeStream(adaptor,"rule methDeclArgsW");
		RewriteRuleSubtreeStream stream_methRetType=new RewriteRuleSubtreeStream(adaptor,"rule methRetType");
		try { DebugEnterRule(GrammarFileName, "methDecl");
		DebugLocation(211, 3);
		try
		{
			// Lang2.g:211:10: ( methRetType ID '(' methDeclArgsW ')' '{' bodyExpr '}' -> ^( METH_DECL methRetType ID methDeclArgsW bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:211:12: methRetType ID '(' methDeclArgsW ')' '{' bodyExpr '}'
			{
			DebugLocation(211, 12);
			PushFollow(Follow._methRetType_in_methDecl1531);
			methRetType169=methRetType();
			PopFollow();

			stream_methRetType.Add(methRetType169.Tree);
			DebugLocation(211, 24);
			ID170=(IToken)Match(input,ID,Follow._ID_in_methDecl1533);  
			stream_ID.Add(ID170);

			DebugLocation(211, 27);
			char_literal171=(IToken)Match(input,50,Follow._50_in_methDecl1535);  
			stream_50.Add(char_literal171);

			DebugLocation(211, 30);
			PushFollow(Follow._methDeclArgsW_in_methDecl1536);
			methDeclArgsW172=methDeclArgsW();
			PopFollow();

			stream_methDeclArgsW.Add(methDeclArgsW172.Tree);
			DebugLocation(211, 43);
			char_literal173=(IToken)Match(input,51,Follow._51_in_methDecl1537);  
			stream_51.Add(char_literal173);

			DebugLocation(211, 47);
			char_literal174=(IToken)Match(input,46,Follow._46_in_methDecl1539);  
			stream_46.Add(char_literal174);

			DebugLocation(211, 50);
			PushFollow(Follow._bodyExpr_in_methDecl1540);
			bodyExpr175=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr175.Tree);
			DebugLocation(211, 58);
			char_literal176=(IToken)Match(input,47,Follow._47_in_methDecl1541);  
			stream_47.Add(char_literal176);



			{
			// AST REWRITE
			// elements: methDeclArgsW, ID, bodyExpr, methRetType
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 211:63: -> ^( METH_DECL methRetType ID methDeclArgsW bodyExpr )
			{
				DebugLocation(211, 66);
				// Lang2.g:211:66: ^( METH_DECL methRetType ID methDeclArgsW bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(211, 68);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METH_DECL, "METH_DECL"), root_1);

				DebugLocation(211, 78);
				adaptor.AddChild(root_1, stream_methRetType.NextTree());
				DebugLocation(211, 90);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(211, 93);
				adaptor.AddChild(root_1, stream_methDeclArgsW.NextTree());
				DebugLocation(211, 107);
				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methDecl", 35);
			LeaveRule("methDecl", 35);
			Leave_methDecl();
		}
		DebugLocation(212, 3);
		} finally { DebugExitRule(GrammarFileName, "methDecl"); }
		return retval;

	}
	// $ANTLR end "methDecl"

	public class moreVarDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_moreVarDecl();
	partial void Leave_moreVarDecl();

	// $ANTLR start "moreVarDecl"
	// Lang2.g:214:1: moreVarDecl : ID ( ',' ID )+ ;
	[GrammarRule("moreVarDecl")]
	private Lang2Parser.moreVarDecl_return moreVarDecl()
	{
		Enter_moreVarDecl();
		EnterRule("moreVarDecl", 36);
		TraceIn("moreVarDecl", 36);
		Lang2Parser.moreVarDecl_return retval = new Lang2Parser.moreVarDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID177=null;
		IToken char_literal178=null;
		IToken ID179=null;

		object ID177_tree=null;
		object char_literal178_tree=null;
		object ID179_tree=null;

		try { DebugEnterRule(GrammarFileName, "moreVarDecl");
		DebugLocation(214, 3);
		try
		{
			// Lang2.g:214:13: ( ID ( ',' ID )+ )
			DebugEnterAlt(1);
			// Lang2.g:214:15: ID ( ',' ID )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(214, 15);
			ID177=(IToken)Match(input,ID,Follow._ID_in_moreVarDecl1568); 
			ID177_tree = (object)adaptor.Create(ID177);
			adaptor.AddChild(root_0, ID177_tree);

			DebugLocation(214, 17);
			// Lang2.g:214:17: ( ',' ID )+
			int cnt27=0;
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==52))
				{
					alt27=1;
				}


				} finally { DebugExitDecision(27); }
				switch (alt27)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:214:18: ',' ID
					{
					DebugLocation(214, 21);
					char_literal178=(IToken)Match(input,52,Follow._52_in_moreVarDecl1570); 
					DebugLocation(214, 23);
					ID179=(IToken)Match(input,ID,Follow._ID_in_moreVarDecl1573); 
					ID179_tree = (object)adaptor.Create(ID179);
					adaptor.AddChild(root_0, ID179_tree);


					}
					break;

				default:
					if (cnt27 >= 1)
						goto loop27;

					EarlyExitException eee27 = new EarlyExitException( 27, input );
					DebugRecognitionException(eee27);
					throw eee27;
				}
				cnt27++;
			}
			loop27:
				;

			} finally { DebugExitSubRule(27); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("moreVarDecl", 36);
			LeaveRule("moreVarDecl", 36);
			Leave_moreVarDecl();
		}
		DebugLocation(215, 3);
		} finally { DebugExitRule(GrammarFileName, "moreVarDecl"); }
		return retval;

	}
	// $ANTLR end "moreVarDecl"

	public class assW_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assW();
	partial void Leave_assW();

	// $ANTLR start "assW"
	// Lang2.g:216:1: assW : ASS mathExpr -> ^( ASS mathExpr ) ;
	[GrammarRule("assW")]
	private Lang2Parser.assW_return assW()
	{
		Enter_assW();
		EnterRule("assW", 37);
		TraceIn("assW", 37);
		Lang2Parser.assW_return retval = new Lang2Parser.assW_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASS180=null;
		Lang2Parser.mathExpr_return mathExpr181 = default(Lang2Parser.mathExpr_return);

		object ASS180_tree=null;
		RewriteRuleITokenStream stream_ASS=new RewriteRuleITokenStream(adaptor,"token ASS");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		try { DebugEnterRule(GrammarFileName, "assW");
		DebugLocation(216, 2);
		try
		{
			// Lang2.g:216:6: ( ASS mathExpr -> ^( ASS mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:216:8: ASS mathExpr
			{
			DebugLocation(216, 11);
			ASS180=(IToken)Match(input,ASS,Follow._ASS_in_assW1586);  
			stream_ASS.Add(ASS180);

			DebugLocation(216, 13);
			PushFollow(Follow._mathExpr_in_assW1589);
			mathExpr181=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr181.Tree);


			{
			// AST REWRITE
			// elements: mathExpr, ASS
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 216:22: -> ^( ASS mathExpr )
			{
				DebugLocation(216, 24);
				// Lang2.g:216:24: ^( ASS mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(216, 26);
				root_1 = (object)adaptor.BecomeRoot(stream_ASS.NextNode(), root_1);

				DebugLocation(216, 30);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assW", 37);
			LeaveRule("assW", 37);
			Leave_assW();
		}
		DebugLocation(217, 2);
		} finally { DebugExitRule(GrammarFileName, "assW"); }
		return retval;

	}
	// $ANTLR end "assW"

	public class varDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_varDecl();
	partial void Leave_varDecl();

	// $ANTLR start "varDecl"
	// Lang2.g:218:1: varDecl : ( ID ID ( assW )? OP_END -> ^( VAR_DECL ID ID ( assW )? ) | ID moreVarDecl OP_END -> ^( VAR_DECL ID moreVarDecl ) );
	[GrammarRule("varDecl")]
	private Lang2Parser.varDecl_return varDecl()
	{
		Enter_varDecl();
		EnterRule("varDecl", 38);
		TraceIn("varDecl", 38);
		Lang2Parser.varDecl_return retval = new Lang2Parser.varDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID182=null;
		IToken ID183=null;
		IToken OP_END185=null;
		IToken ID186=null;
		IToken OP_END188=null;
		Lang2Parser.assW_return assW184 = default(Lang2Parser.assW_return);
		Lang2Parser.moreVarDecl_return moreVarDecl187 = default(Lang2Parser.moreVarDecl_return);

		object ID182_tree=null;
		object ID183_tree=null;
		object OP_END185_tree=null;
		object ID186_tree=null;
		object OP_END188_tree=null;
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_moreVarDecl=new RewriteRuleSubtreeStream(adaptor,"rule moreVarDecl");
		RewriteRuleSubtreeStream stream_assW=new RewriteRuleSubtreeStream(adaptor,"rule assW");
		try { DebugEnterRule(GrammarFileName, "varDecl");
		DebugLocation(218, 2);
		try
		{
			// Lang2.g:218:9: ( ID ID ( assW )? OP_END -> ^( VAR_DECL ID ID ( assW )? ) | ID moreVarDecl OP_END -> ^( VAR_DECL ID moreVarDecl ) )
			int alt29=2;
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==ID))
			{
				int LA29_1 = input.LA(2);

				if ((LA29_1==ID))
				{
					int LA29_2 = input.LA(3);

					if ((LA29_2==OP_END||LA29_2==ASS))
					{
						alt29=1;
					}
					else if ((LA29_2==52))
					{
						alt29=2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 29, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 29, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 29, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(29); }
			switch (alt29)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:218:11: ID ID ( assW )? OP_END
				{
				DebugLocation(218, 11);
				ID182=(IToken)Match(input,ID,Follow._ID_in_varDecl1606);  
				stream_ID.Add(ID182);

				DebugLocation(218, 14);
				ID183=(IToken)Match(input,ID,Follow._ID_in_varDecl1608);  
				stream_ID.Add(ID183);

				DebugLocation(218, 17);
				// Lang2.g:218:17: ( assW )?
				int alt28=2;
				try { DebugEnterSubRule(28);
				try { DebugEnterDecision(28, decisionCanBacktrack[28]);
				int LA28_0 = input.LA(1);

				if ((LA28_0==ASS))
				{
					alt28=1;
				}
				} finally { DebugExitDecision(28); }
				switch (alt28)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:218:17: assW
					{
					DebugLocation(218, 17);
					PushFollow(Follow._assW_in_varDecl1610);
					assW184=assW();
					PopFollow();

					stream_assW.Add(assW184.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(28); }

				DebugLocation(218, 23);
				OP_END185=(IToken)Match(input,OP_END,Follow._OP_END_in_varDecl1613);  
				stream_OP_END.Add(OP_END185);



				{
				// AST REWRITE
				// elements: ID, ID, assW
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 218:30: -> ^( VAR_DECL ID ID ( assW )? )
				{
					DebugLocation(218, 33);
					// Lang2.g:218:33: ^( VAR_DECL ID ID ( assW )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(218, 35);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

					DebugLocation(218, 44);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(218, 47);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(218, 50);
					// Lang2.g:218:50: ( assW )?
					if ( stream_assW.HasNext )
					{
						DebugLocation(218, 50);
						adaptor.AddChild(root_1, stream_assW.NextTree());

					}
					stream_assW.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:219:6: ID moreVarDecl OP_END
				{
				DebugLocation(219, 6);
				ID186=(IToken)Match(input,ID,Follow._ID_in_varDecl1633);  
				stream_ID.Add(ID186);

				DebugLocation(219, 9);
				PushFollow(Follow._moreVarDecl_in_varDecl1635);
				moreVarDecl187=moreVarDecl();
				PopFollow();

				stream_moreVarDecl.Add(moreVarDecl187.Tree);
				DebugLocation(219, 21);
				OP_END188=(IToken)Match(input,OP_END,Follow._OP_END_in_varDecl1637);  
				stream_OP_END.Add(OP_END188);



				{
				// AST REWRITE
				// elements: moreVarDecl, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 219:28: -> ^( VAR_DECL ID moreVarDecl )
				{
					DebugLocation(219, 31);
					// Lang2.g:219:31: ^( VAR_DECL ID moreVarDecl )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(219, 33);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

					DebugLocation(219, 42);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(219, 45);
					adaptor.AddChild(root_1, stream_moreVarDecl.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("varDecl", 38);
			LeaveRule("varDecl", 38);
			Leave_varDecl();
		}
		DebugLocation(220, 2);
		} finally { DebugExitRule(GrammarFileName, "varDecl"); }
		return retval;

	}
	// $ANTLR end "varDecl"

	public class bodyExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bodyExpr();
	partial void Leave_bodyExpr();

	// $ANTLR start "bodyExpr"
	// Lang2.g:222:1: bodyExpr : ( bodyFExpr )+ -> ^( BODY ( bodyFExpr )+ ) ;
	[GrammarRule("bodyExpr")]
	private Lang2Parser.bodyExpr_return bodyExpr()
	{
		Enter_bodyExpr();
		EnterRule("bodyExpr", 39);
		TraceIn("bodyExpr", 39);
		Lang2Parser.bodyExpr_return retval = new Lang2Parser.bodyExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.bodyFExpr_return bodyFExpr189 = default(Lang2Parser.bodyFExpr_return);

		RewriteRuleSubtreeStream stream_bodyFExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyFExpr");
		try { DebugEnterRule(GrammarFileName, "bodyExpr");
		DebugLocation(222, 3);
		try
		{
			// Lang2.g:222:10: ( ( bodyFExpr )+ -> ^( BODY ( bodyFExpr )+ ) )
			DebugEnterAlt(1);
			// Lang2.g:222:12: ( bodyFExpr )+
			{
			DebugLocation(222, 12);
			// Lang2.g:222:12: ( bodyFExpr )+
			int cnt30=0;
			try { DebugEnterSubRule(30);
			while (true)
			{
				int alt30=2;
				try { DebugEnterDecision(30, decisionCanBacktrack[30]);
				int LA30_0 = input.LA(1);

				if ((LA30_0==IF||(LA30_0>=FOR && LA30_0<=DO)||LA30_0==RETURN||LA30_0==ID))
				{
					alt30=1;
				}


				} finally { DebugExitDecision(30); }
				switch (alt30)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:222:12: bodyFExpr
					{
					DebugLocation(222, 12);
					PushFollow(Follow._bodyFExpr_in_bodyExpr1658);
					bodyFExpr189=bodyFExpr();
					PopFollow();

					stream_bodyFExpr.Add(bodyFExpr189.Tree);

					}
					break;

				default:
					if (cnt30 >= 1)
						goto loop30;

					EarlyExitException eee30 = new EarlyExitException( 30, input );
					DebugRecognitionException(eee30);
					throw eee30;
				}
				cnt30++;
			}
			loop30:
				;

			} finally { DebugExitSubRule(30); }



			{
			// AST REWRITE
			// elements: bodyFExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 222:23: -> ^( BODY ( bodyFExpr )+ )
			{
				DebugLocation(222, 26);
				// Lang2.g:222:26: ^( BODY ( bodyFExpr )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(222, 28);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY, "BODY"), root_1);

				DebugLocation(222, 33);
				if ( !(stream_bodyFExpr.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_bodyFExpr.HasNext )
				{
					DebugLocation(222, 33);
					adaptor.AddChild(root_1, stream_bodyFExpr.NextTree());

				}
				stream_bodyFExpr.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bodyExpr", 39);
			LeaveRule("bodyExpr", 39);
			Leave_bodyExpr();
		}
		DebugLocation(223, 3);
		} finally { DebugExitRule(GrammarFileName, "bodyExpr"); }
		return retval;

	}
	// $ANTLR end "bodyExpr"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// Lang2.g:224:1: program : ( classDecl )+ -> ^( BODY ( classDecl )+ ) ;
	[GrammarRule("program")]
	private Lang2Parser.program_return program()
	{
		Enter_program();
		EnterRule("program", 40);
		TraceIn("program", 40);
		Lang2Parser.program_return retval = new Lang2Parser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.classDecl_return classDecl190 = default(Lang2Parser.classDecl_return);

		RewriteRuleSubtreeStream stream_classDecl=new RewriteRuleSubtreeStream(adaptor,"rule classDecl");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(224, 3);
		try
		{
			// Lang2.g:224:10: ( ( classDecl )+ -> ^( BODY ( classDecl )+ ) )
			DebugEnterAlt(1);
			// Lang2.g:224:12: ( classDecl )+
			{
			DebugLocation(224, 12);
			// Lang2.g:224:12: ( classDecl )+
			int cnt31=0;
			try { DebugEnterSubRule(31);
			while (true)
			{
				int alt31=2;
				try { DebugEnterDecision(31, decisionCanBacktrack[31]);
				int LA31_0 = input.LA(1);

				if ((LA31_0==CLASS))
				{
					alt31=1;
				}


				} finally { DebugExitDecision(31); }
				switch (alt31)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:224:12: classDecl
					{
					DebugLocation(224, 12);
					PushFollow(Follow._classDecl_in_program1681);
					classDecl190=classDecl();
					PopFollow();

					stream_classDecl.Add(classDecl190.Tree);

					}
					break;

				default:
					if (cnt31 >= 1)
						goto loop31;

					EarlyExitException eee31 = new EarlyExitException( 31, input );
					DebugRecognitionException(eee31);
					throw eee31;
				}
				cnt31++;
			}
			loop31:
				;

			} finally { DebugExitSubRule(31); }



			{
			// AST REWRITE
			// elements: classDecl
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 224:23: -> ^( BODY ( classDecl )+ )
			{
				DebugLocation(224, 25);
				// Lang2.g:224:25: ^( BODY ( classDecl )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(224, 27);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY, "BODY"), root_1);

				DebugLocation(224, 32);
				if ( !(stream_classDecl.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_classDecl.HasNext )
				{
					DebugLocation(224, 32);
					adaptor.AddChild(root_1, stream_classDecl.NextTree());

				}
				stream_classDecl.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 40);
			LeaveRule("program", 40);
			Leave_program();
		}
		DebugLocation(225, 3);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class result_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_result();
	partial void Leave_result();

	// $ANTLR start "result"
	// Lang2.g:226:1: result : program EOF -> ^( PROGRAM program ) ;
	[GrammarRule("result")]
	private Lang2Parser.result_return result()
	{
		Enter_result();
		EnterRule("result", 41);
		TraceIn("result", 41);
		Lang2Parser.result_return retval = new Lang2Parser.result_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF192=null;
		Lang2Parser.program_return program191 = default(Lang2Parser.program_return);

		object EOF192_tree=null;
		RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
		RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(226, 41);
		try
		{
			// Lang2.g:226:7: ( program EOF -> ^( PROGRAM program ) )
			DebugEnterAlt(1);
			// Lang2.g:226:9: program EOF
			{
			DebugLocation(226, 9);
			PushFollow(Follow._program_in_result1700);
			program191=program();
			PopFollow();

			stream_program.Add(program191.Tree);
			DebugLocation(226, 17);
			EOF192=(IToken)Match(input,EOF,Follow._EOF_in_result1702);  
			stream_EOF.Add(EOF192);



			{
			// AST REWRITE
			// elements: program
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 226:21: -> ^( PROGRAM program )
			{
				DebugLocation(226, 24);
				// Lang2.g:226:24: ^( PROGRAM program )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(226, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(226, 34);
				adaptor.AddChild(root_1, stream_program.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("result", 41);
			LeaveRule("result", 41);
			Leave_result();
		}
		DebugLocation(226, 41);
		} finally { DebugExitRule(GrammarFileName, "result"); }
		return retval;

	}
	// $ANTLR end "result"

	public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execute();
	partial void Leave_execute();

	// $ANTLR start "execute"
	// Lang2.g:227:8: public execute : result ;
	[GrammarRule("execute")]
	public Lang2Parser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 42);
		TraceIn("execute", 42);
		Lang2Parser.execute_return retval = new Lang2Parser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.result_return result193 = default(Lang2Parser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(227, 23);
		try
		{
			// Lang2.g:227:15: ( result )
			DebugEnterAlt(1);
			// Lang2.g:227:18: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(227, 18);
			PushFollow(Follow._result_in_execute1719);
			result193=result();
			PopFollow();

			adaptor.AddChild(root_0, result193.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execute", 42);
			LeaveRule("execute", 42);
			Leave_execute();
		}
		DebugLocation(227, 23);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"
	#endregion Rules


	#region DFA
	DFA9 dfa9;
	DFA14 dfa14;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa9 = new DFA9( this );
		dfa14 = new DFA14( this );
	}

	private class DFA9 : DFA
	{
		private const string DFA9_eotS =
			"\x10\xFFFF";
		private const string DFA9_eofS =
			"\x10\xFFFF";
		private const string DFA9_minS =
			"\x1\xD\x1\x18\x5\xFFFF\x1\x1C\x8\xFFFF";
		private const string DFA9_maxS =
			"\x1\x2D\x1\x32\x5\xFFFF\x1\x34\x8\xFFFF";
		private const string DFA9_acceptS =
			"\x2\xFFFF\x1\x5\x1\x6\x1\x9\x1\xA\x1\xD\x1\xFFFF\x1\x2\x1\x3\x1\x7\x1"+
			"\x8\x1\xB\x1\xC\x1\x4\x1\x1";
		private const string DFA9_specialS =
			"\x10\xFFFF}>";
		private static readonly string[] DFA9_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x3\x1\x4\x1\x5\x9\xFFFF\x1\x6\x11\xFFFF\x1\x1",
				"\x1\xD\x9\xFFFF\x1\xA\x1\xB\x2\xFFFF\x1\x8\x6\xFFFF\x1\x7\x2\xFFFF"+
				"\x1\xC\x1\xFFFF\x1\x9",
				"",
				"",
				"",
				"",
				"",
				"\x1\xF\x9\xFFFF\x1\xF\x9\xFFFF\x1\xE\x3\xFFFF\x1\xF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
		private static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
		private static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
		private static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
		private static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
		private static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
		private static readonly short[][] DFA9_transition;

		static DFA9()
		{
			int numStates = DFA9_transitionS.Length;
			DFA9_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA9_transition[i] = DFA.UnpackEncodedString(DFA9_transitionS[i]);
			}
		}

		public DFA9( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 9;
			this.eot = DFA9_eot;
			this.eof = DFA9_eof;
			this.min = DFA9_min;
			this.max = DFA9_max;
			this.accept = DFA9_accept;
			this.special = DFA9_special;
			this.transition = DFA9_transition;
		}

		public override string Description { get { return "128:1: bodyFExpr : ( varDecl | ID ASS mathExpr OP_END | methCall OP_END | arrDecl | ifExpr | forLoop | incSug OP_END | decSug OP_END | whileLoop | doLoop | arrCall ASS mathExpr OP_END | toObjExpr OP_END | RETURN ( mathExpr )? OP_END );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA14 : DFA
	{
		private const string DFA14_eotS =
			"\xD\xFFFF";
		private const string DFA14_eofS =
			"\xD\xFFFF";
		private const string DFA14_minS =
			"\x1\x8\x1\xFFFF\x1\x18\x3\xFFFF\x2\x8\x5\xFFFF";
		private const string DFA14_maxS =
			"\x1\x32\x1\xFFFF\x1\x34\x3\xFFFF\x2\x32\x5\xFFFF";
		private const string DFA14_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x4\x1\x5\x1\x3\x2\xFFFF\x1\x8\x1\x9\x1\x2"+
			"\x1\x6\x1\x7";
		private const string DFA14_specialS =
			"\xD\xFFFF}>";
		private static readonly string[] DFA14_transitionS =
			{
				"\x1\x4\x14\xFFFF\x4\x3\xC\xFFFF\x1\x2\x4\xFFFF\x1\x1",
				"",
				"\x1\x9\x3\xFFFF\x1\xA\x5\xFFFF\x1\x6\x1\x7\x2\xA\x1\xFFFF\x5\xA\x4"+
				"\xFFFF\x1\x8\x1\xA\x1\x5\x2\xA",
				"",
				"",
				"",
				"\x1\xA\x14\xFFFF\x4\xA\x1\xFFFF\x1\xB\x9\xFFFF\x2\xA\x4\xFFFF\x1\xA",
				"\x1\xA\x14\xFFFF\x4\xA\x2\xFFFF\x1\xC\x8\xFFFF\x2\xA\x4\xFFFF\x1\xA",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
		private static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
		private static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
		private static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
		private static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
		private static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
		private static readonly short[][] DFA14_transition;

		static DFA14()
		{
			int numStates = DFA14_transitionS.Length;
			DFA14_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA14_transition[i] = DFA.UnpackEncodedString(DFA14_transitionS[i]);
			}
		}

		public DFA14( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 14;
			this.eot = DFA14_eot;
			this.eof = DFA14_eof;
			this.min = DFA14_min;
			this.max = DFA14_max;
			this.accept = DFA14_accept;
			this.special = DFA14_special;
			this.transition = DFA14_transition;
		}

		public override string Description { get { return "167:1: mathGroup : ( '(' mathExpr ')' | ID | methCall | literals | newOp | incSug | decSug | arrCall | toObjExpr );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _CLASS_in_classDecl450 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_classDecl452 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_classDecl454 = new BitSet(new ulong[]{0x200000300000UL});
		public static readonly BitSet _bodyCExprW_in_classDecl455 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_classDecl456 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STRUCT_in_structDecl478 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_structDecl480 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_structDecl482 = new BitSet(new ulong[]{0x200000300000UL});
		public static readonly BitSet _bodySExprW_in_structDecl483 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_structDecl484 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_bodyCExpr506 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrDecl_in_bodyCExpr513 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _structDecl_in_bodyCExpr520 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classDecl_in_bodyCExpr527 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methDecl_in_bodyCExpr534 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bodyCExpr_in_bodyCExprW545 = new BitSet(new ulong[]{0x200000300002UL});
		public static readonly BitSet _varDecl_in_bodySExpr566 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrDecl_in_bodySExpr573 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methDecl_in_bodySExpr580 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bodySExpr_in_bodySExprW591 = new BitSet(new ulong[]{0x200000300002UL});
		public static readonly BitSet _ID_in_toObjExpr615 = new BitSet(new ulong[]{0x1000000UL});
		public static readonly BitSet _TO_in_toObjExpr617 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_toObjExpr626 = new BitSet(new ulong[]{0x4000000002UL});
		public static readonly BitSet _assW_in_toObjExpr628 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methCall_in_toObjExpr636 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrCall_in_toObjExpr643 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrDecl658 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_arrDecl660 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_arrDecl661 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_arrDecl662 = new BitSet(new ulong[]{0x4010000000UL});
		public static readonly BitSet _assW_in_arrDecl664 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_arrDecl667 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrCall692 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_arrCall693 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_arrCall694 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_arrCall695 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_bodyFExpr718 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_bodyFExpr725 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _ASS_in_bodyFExpr727 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_bodyFExpr730 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr732 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methCall_in_bodyFExpr740 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr742 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrDecl_in_bodyFExpr750 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifExpr_in_bodyFExpr757 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forLoop_in_bodyFExpr764 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _incSug_in_bodyFExpr771 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr773 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decSug_in_bodyFExpr781 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr783 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whileLoop_in_bodyFExpr791 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _doLoop_in_bodyFExpr798 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrCall_in_bodyFExpr805 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _ASS_in_bodyFExpr807 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_bodyFExpr810 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr812 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _toObjExpr_in_bodyFExpr820 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr822 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_bodyFExpr830 = new BitSet(new ulong[]{0x43001F0000100UL});
		public static readonly BitSet _mathExpr_in_bodyFExpr833 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr836 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifExpr850 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_ifExpr851 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_ifExpr853 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_ifExpr854 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_ifExpr856 = new BitSet(new ulong[]{0x43001E803A100UL});
		public static readonly BitSet _bodyExpr_in_ifExpr857 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_ifExpr858 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_varFor879 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_varFor885 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_iterFor895 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _ASS_in_iterFor897 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_iterFor900 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathExpr_in_iterFor906 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forLoop916 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_forLoop918 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _varFor_in_forLoop920 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_forLoop922 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_forLoop924 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_forLoop926 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _iterFor_in_forLoop928 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_forLoop930 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_forLoop932 = new BitSet(new ulong[]{0x43001E803A100UL});
		public static readonly BitSet _bodyExpr_in_forLoop933 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_forLoop934 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_whileLoop958 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_whileLoop960 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_whileLoop961 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_whileLoop962 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_whileLoop964 = new BitSet(new ulong[]{0x43001E803A100UL});
		public static readonly BitSet _bodyExpr_in_whileLoop965 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_whileLoop966 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_doLoop988 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_doLoop990 = new BitSet(new ulong[]{0x43001E803A100UL});
		public static readonly BitSet _bodyExpr_in_doLoop991 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_doLoop992 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_doLoop994 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_doLoop995 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_doLoop996 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_doLoop998 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NEW_in_newOp1021 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_newOp1023 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_newOp1025 = new BitSet(new ulong[]{0xC3001E0000100UL});
		public static readonly BitSet _methArgs_in_newOp1026 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_newOp1028 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NEW_in_newOp1046 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_newOp1048 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_newOp1050 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_newOp1052 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_newOp1053 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_literals0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_incSug1090 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ADD_in_incSug1092 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ADD_in_incSug1094 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_decSug1112 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _SUB_in_decSug1114 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _SUB_in_decSug1116 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _50_in_mathGroup1134 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_mathGroup1137 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_mathGroup1139 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_mathGroup1147 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methCall_in_mathGroup1154 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _literals_in_mathGroup1161 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newOp_in_mathGroup1168 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _incSug_in_mathGroup1175 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decSug_in_mathGroup1182 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrCall_in_mathGroup1189 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _toObjExpr_in_mathGroup1196 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INVERT_in_mathNeg1209 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathGroup_in_mathNeg1212 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathGroup_in_mathNeg1221 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathNeg_in_mathConj1233 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _CONJ_in_mathConj1235 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathNeg_in_mathConj1238 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _mathConj_in_mathDisj1251 = new BitSet(new ulong[]{0x8000000002UL});
		public static readonly BitSet _DISJ_in_mathDisj1253 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathConj_in_mathDisj1256 = new BitSet(new ulong[]{0x8000000002UL});
		public static readonly BitSet _mathDisj_in_mathEq1270 = new BitSet(new ulong[]{0xE0000000002UL});
		public static readonly BitSet _set_in_mathEq1272 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathDisj_in_mathEq1281 = new BitSet(new ulong[]{0xE0000000002UL});
		public static readonly BitSet _mathEq_in_mathMult1294 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _set_in_mathMult1296 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathEq_in_mathMult1302 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _mathMult_in_mathAdd1316 = new BitSet(new ulong[]{0xC00000002UL});
		public static readonly BitSet _set_in_mathAdd1318 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathMult_in_mathAdd1325 = new BitSet(new ulong[]{0xC00000002UL});
		public static readonly BitSet _mathAdd_in_mathExpr1338 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathExpr_in_methArgs1352 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _52_in_methArgs1355 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_methArgs1357 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _ID_in_methCall1382 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_methCall1383 = new BitSet(new ulong[]{0xC3001E0000100UL});
		public static readonly BitSet _methArgs_in_methCall1384 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_methCall1386 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_methArgODecl1408 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_methArgODecl1410 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_methArgODecl1428 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_methArgODecl1429 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_methArgODecl1430 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_methArgODecl1432 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methArgODecl_in_methDeclArgs1455 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _52_in_methDeclArgs1457 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _methArgODecl_in_methDeclArgs1459 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _methDeclArgs_in_methDeclArgsW1473 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_methRetType1496 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_methRetType1510 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_methRetType1511 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_methRetType1512 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methRetType_in_methDecl1531 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_methDecl1533 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_methDecl1535 = new BitSet(new ulong[]{0x8200000000000UL});
		public static readonly BitSet _methDeclArgsW_in_methDecl1536 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_methDecl1537 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_methDecl1539 = new BitSet(new ulong[]{0x43001E803A100UL});
		public static readonly BitSet _bodyExpr_in_methDecl1540 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_methDecl1541 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_moreVarDecl1568 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_moreVarDecl1570 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_moreVarDecl1573 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _ASS_in_assW1586 = new BitSet(new ulong[]{0x43001E0000100UL});
		public static readonly BitSet _mathExpr_in_assW1589 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_varDecl1606 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ID_in_varDecl1608 = new BitSet(new ulong[]{0x4010000000UL});
		public static readonly BitSet _assW_in_varDecl1610 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_varDecl1613 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_varDecl1633 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _moreVarDecl_in_varDecl1635 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_varDecl1637 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bodyFExpr_in_bodyExpr1658 = new BitSet(new ulong[]{0x43001E803A102UL});
		public static readonly BitSet _classDecl_in_program1681 = new BitSet(new ulong[]{0x100002UL});
		public static readonly BitSet _program_in_result1700 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result1702 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute1719 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace Lang2
