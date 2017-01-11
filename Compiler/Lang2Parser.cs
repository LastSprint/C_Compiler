// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2017-01-11 01:58:19

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM", "VAR_DECL", "METH_CALL", "CALL_ARGS", "ARR_DECL", "ARR_CALL", "IF", "BODY", "FOR", "WHILE", "DO", "INC", "DEC", "METH_DECL", "DECL_ARGS", "RET_TYPE_SINGLE", "RET_TYPE_ARR", "RETURN", "TINT", "TFLOAT", "TSTRING", "TCHAR", "TBOOL", "TVOID", "ELSE", "OP_END", "INT", "DOUBLE", "CHAR", "STRING", "WS", "ADD", "SUB", "MULT", "DIV", "ASS", "DISJ", "CONJ", "IS_MORE", "IS_LESS", "IS_EQUALLY", "INVERT", "IS_LESS_OR_EQUAL", "IS_MORE_OR_EQUAL", "ID", "'['", "']'", "'{'", "'}'", "'('", "')'", "','"
	};
	public const int EOF=-1;
	public const int T__49=49;
	public const int T__50=50;
	public const int T__51=51;
	public const int T__52=52;
	public const int T__53=53;
	public const int T__54=54;
	public const int T__55=55;
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
	public const int ELSE=28;
	public const int OP_END=29;
	public const int INT=30;
	public const int DOUBLE=31;
	public const int CHAR=32;
	public const int STRING=33;
	public const int WS=34;
	public const int ADD=35;
	public const int SUB=36;
	public const int MULT=37;
	public const int DIV=38;
	public const int ASS=39;
	public const int DISJ=40;
	public const int CONJ=41;
	public const int IS_MORE=42;
	public const int IS_LESS=43;
	public const int IS_EQUALLY=44;
	public const int INVERT=45;
	public const int IS_LESS_OR_EQUAL=46;
	public const int IS_MORE_OR_EQUAL=47;
	public const int ID=48;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false
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
	public class type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type();
	partial void Leave_type();

	// $ANTLR start "type"
	// Lang2.g:104:1: type : ( TINT | TFLOAT | TSTRING | TCHAR | TBOOL | TVOID );
	[GrammarRule("type")]
	private Lang2Parser.type_return type()
	{
		Enter_type();
		EnterRule("type", 1);
		TraceIn("type", 1);
		Lang2Parser.type_return retval = new Lang2Parser.type_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set1=null;

		object set1_tree=null;

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(104, 1);
		try
		{
			// Lang2.g:104:6: ( TINT | TFLOAT | TSTRING | TCHAR | TBOOL | TVOID )
			DebugEnterAlt(1);
			// Lang2.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 6);
			set1=(IToken)input.LT(1);
			if ((input.LA(1)>=TINT && input.LA(1)<=TVOID))
			{
				input.Consume();
				adaptor.AddChild(root_0, (object)adaptor.Create(set1));
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
			TraceOut("type", 1);
			LeaveRule("type", 1);
			Leave_type();
		}
		DebugLocation(110, 1);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return retval;

	}
	// $ANTLR end "type"

	public class arrDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrDecl();
	partial void Leave_arrDecl();

	// $ANTLR start "arrDecl"
	// Lang2.g:114:1: arrDecl : type ID '[' mathExpr ']' OP_END -> ^( ARR_DECL type ID mathExpr ) ;
	[GrammarRule("arrDecl")]
	private Lang2Parser.arrDecl_return arrDecl()
	{
		Enter_arrDecl();
		EnterRule("arrDecl", 2);
		TraceIn("arrDecl", 2);
		Lang2Parser.arrDecl_return retval = new Lang2Parser.arrDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID3=null;
		IToken char_literal4=null;
		IToken char_literal6=null;
		IToken OP_END7=null;
		Lang2Parser.type_return type2 = default(Lang2Parser.type_return);
		Lang2Parser.mathExpr_return mathExpr5 = default(Lang2Parser.mathExpr_return);

		object ID3_tree=null;
		object char_literal4_tree=null;
		object char_literal6_tree=null;
		object OP_END7_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "arrDecl");
		DebugLocation(114, 3);
		try
		{
			// Lang2.g:114:10: ( type ID '[' mathExpr ']' OP_END -> ^( ARR_DECL type ID mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:114:12: type ID '[' mathExpr ']' OP_END
			{
			DebugLocation(114, 12);
			PushFollow(Follow._type_in_arrDecl539);
			type2=type();
			PopFollow();

			stream_type.Add(type2.Tree);
			DebugLocation(114, 17);
			ID3=(IToken)Match(input,ID,Follow._ID_in_arrDecl541);  
			stream_ID.Add(ID3);

			DebugLocation(114, 19);
			char_literal4=(IToken)Match(input,49,Follow._49_in_arrDecl542);  
			stream_49.Add(char_literal4);

			DebugLocation(114, 22);
			PushFollow(Follow._mathExpr_in_arrDecl543);
			mathExpr5=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr5.Tree);
			DebugLocation(114, 30);
			char_literal6=(IToken)Match(input,50,Follow._50_in_arrDecl544);  
			stream_50.Add(char_literal6);

			DebugLocation(114, 34);
			OP_END7=(IToken)Match(input,OP_END,Follow._OP_END_in_arrDecl546);  
			stream_OP_END.Add(OP_END7);



			{
			// AST REWRITE
			// elements: ID, type, mathExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 114:41: -> ^( ARR_DECL type ID mathExpr )
			{
				DebugLocation(114, 44);
				// Lang2.g:114:44: ^( ARR_DECL type ID mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(114, 46);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

				DebugLocation(114, 55);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(114, 60);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(114, 63);
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
			TraceOut("arrDecl", 2);
			LeaveRule("arrDecl", 2);
			Leave_arrDecl();
		}
		DebugLocation(115, 3);
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
	// Lang2.g:117:1: arrCall : ID '[' mathExpr ']' -> ^( ARR_CALL ID mathExpr ) ;
	[GrammarRule("arrCall")]
	private Lang2Parser.arrCall_return arrCall()
	{
		Enter_arrCall();
		EnterRule("arrCall", 3);
		TraceIn("arrCall", 3);
		Lang2Parser.arrCall_return retval = new Lang2Parser.arrCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID8=null;
		IToken char_literal9=null;
		IToken char_literal11=null;
		Lang2Parser.mathExpr_return mathExpr10 = default(Lang2Parser.mathExpr_return);

		object ID8_tree=null;
		object char_literal9_tree=null;
		object char_literal11_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		try { DebugEnterRule(GrammarFileName, "arrCall");
		DebugLocation(117, 3);
		try
		{
			// Lang2.g:117:10: ( ID '[' mathExpr ']' -> ^( ARR_CALL ID mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:117:12: ID '[' mathExpr ']'
			{
			DebugLocation(117, 12);
			ID8=(IToken)Match(input,ID,Follow._ID_in_arrCall571);  
			stream_ID.Add(ID8);

			DebugLocation(117, 14);
			char_literal9=(IToken)Match(input,49,Follow._49_in_arrCall572);  
			stream_49.Add(char_literal9);

			DebugLocation(117, 17);
			PushFollow(Follow._mathExpr_in_arrCall573);
			mathExpr10=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr10.Tree);
			DebugLocation(117, 25);
			char_literal11=(IToken)Match(input,50,Follow._50_in_arrCall574);  
			stream_50.Add(char_literal11);



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
			// 117:29: -> ^( ARR_CALL ID mathExpr )
			{
				DebugLocation(117, 32);
				// Lang2.g:117:32: ^( ARR_CALL ID mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(117, 34);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_CALL, "ARR_CALL"), root_1);

				DebugLocation(117, 43);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(117, 46);
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
			TraceOut("arrCall", 3);
			LeaveRule("arrCall", 3);
			Leave_arrCall();
		}
		DebugLocation(118, 3);
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
	// Lang2.g:121:1: bodyFExpr : ( varDecl | ID ASS mathExpr OP_END | methCall OP_END | arrDecl | ifExpr | forLoop | incSug OP_END | decSug OP_END | whileLoop | doLoop | arrCall ASS mathExpr OP_END | RETURN ( mathExpr )? OP_END );
	[GrammarRule("bodyFExpr")]
	private Lang2Parser.bodyFExpr_return bodyFExpr()
	{
		Enter_bodyFExpr();
		EnterRule("bodyFExpr", 4);
		TraceIn("bodyFExpr", 4);
		Lang2Parser.bodyFExpr_return retval = new Lang2Parser.bodyFExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID13=null;
		IToken ASS14=null;
		IToken OP_END16=null;
		IToken OP_END18=null;
		IToken OP_END23=null;
		IToken OP_END25=null;
		IToken ASS29=null;
		IToken OP_END31=null;
		IToken RETURN32=null;
		IToken OP_END34=null;
		Lang2Parser.varDecl_return varDecl12 = default(Lang2Parser.varDecl_return);
		Lang2Parser.mathExpr_return mathExpr15 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.methCall_return methCall17 = default(Lang2Parser.methCall_return);
		Lang2Parser.arrDecl_return arrDecl19 = default(Lang2Parser.arrDecl_return);
		Lang2Parser.ifExpr_return ifExpr20 = default(Lang2Parser.ifExpr_return);
		Lang2Parser.forLoop_return forLoop21 = default(Lang2Parser.forLoop_return);
		Lang2Parser.incSug_return incSug22 = default(Lang2Parser.incSug_return);
		Lang2Parser.decSug_return decSug24 = default(Lang2Parser.decSug_return);
		Lang2Parser.whileLoop_return whileLoop26 = default(Lang2Parser.whileLoop_return);
		Lang2Parser.doLoop_return doLoop27 = default(Lang2Parser.doLoop_return);
		Lang2Parser.arrCall_return arrCall28 = default(Lang2Parser.arrCall_return);
		Lang2Parser.mathExpr_return mathExpr30 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.mathExpr_return mathExpr33 = default(Lang2Parser.mathExpr_return);

		object ID13_tree=null;
		object ASS14_tree=null;
		object OP_END16_tree=null;
		object OP_END18_tree=null;
		object OP_END23_tree=null;
		object OP_END25_tree=null;
		object ASS29_tree=null;
		object OP_END31_tree=null;
		object RETURN32_tree=null;
		object OP_END34_tree=null;

		try { DebugEnterRule(GrammarFileName, "bodyFExpr");
		DebugLocation(121, 4);
		try
		{
			// Lang2.g:121:11: ( varDecl | ID ASS mathExpr OP_END | methCall OP_END | arrDecl | ifExpr | forLoop | incSug OP_END | decSug OP_END | whileLoop | doLoop | arrCall ASS mathExpr OP_END | RETURN ( mathExpr )? OP_END )
			int alt2=12;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			try
			{
				alt2 = dfa2.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:121:13: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(121, 13);
				PushFollow(Follow._varDecl_in_bodyFExpr597);
				varDecl12=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl12.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:122:6: ID ASS mathExpr OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(122, 6);
				ID13=(IToken)Match(input,ID,Follow._ID_in_bodyFExpr604); 
				ID13_tree = (object)adaptor.Create(ID13);
				adaptor.AddChild(root_0, ID13_tree);

				DebugLocation(122, 12);
				ASS14=(IToken)Match(input,ASS,Follow._ASS_in_bodyFExpr606); 
				ASS14_tree = (object)adaptor.Create(ASS14);
				root_0 = (object)adaptor.BecomeRoot(ASS14_tree, root_0);

				DebugLocation(122, 14);
				PushFollow(Follow._mathExpr_in_bodyFExpr609);
				mathExpr15=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr15.Tree);
				DebugLocation(122, 29);
				OP_END16=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr611); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:123:6: methCall OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(123, 6);
				PushFollow(Follow._methCall_in_bodyFExpr619);
				methCall17=methCall();
				PopFollow();

				adaptor.AddChild(root_0, methCall17.Tree);
				DebugLocation(123, 21);
				OP_END18=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr621); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Lang2.g:124:6: arrDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(124, 6);
				PushFollow(Follow._arrDecl_in_bodyFExpr629);
				arrDecl19=arrDecl();
				PopFollow();

				adaptor.AddChild(root_0, arrDecl19.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Lang2.g:125:6: ifExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(125, 6);
				PushFollow(Follow._ifExpr_in_bodyFExpr636);
				ifExpr20=ifExpr();
				PopFollow();

				adaptor.AddChild(root_0, ifExpr20.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Lang2.g:126:6: forLoop
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(126, 6);
				PushFollow(Follow._forLoop_in_bodyFExpr643);
				forLoop21=forLoop();
				PopFollow();

				adaptor.AddChild(root_0, forLoop21.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Lang2.g:127:6: incSug OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(127, 6);
				PushFollow(Follow._incSug_in_bodyFExpr650);
				incSug22=incSug();
				PopFollow();

				adaptor.AddChild(root_0, incSug22.Tree);
				DebugLocation(127, 19);
				OP_END23=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr652); 

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Lang2.g:128:6: decSug OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(128, 6);
				PushFollow(Follow._decSug_in_bodyFExpr660);
				decSug24=decSug();
				PopFollow();

				adaptor.AddChild(root_0, decSug24.Tree);
				DebugLocation(128, 19);
				OP_END25=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr662); 

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// Lang2.g:129:6: whileLoop
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(129, 6);
				PushFollow(Follow._whileLoop_in_bodyFExpr670);
				whileLoop26=whileLoop();
				PopFollow();

				adaptor.AddChild(root_0, whileLoop26.Tree);

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// Lang2.g:130:6: doLoop
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(130, 6);
				PushFollow(Follow._doLoop_in_bodyFExpr677);
				doLoop27=doLoop();
				PopFollow();

				adaptor.AddChild(root_0, doLoop27.Tree);

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// Lang2.g:131:6: arrCall ASS mathExpr OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(131, 6);
				PushFollow(Follow._arrCall_in_bodyFExpr684);
				arrCall28=arrCall();
				PopFollow();

				adaptor.AddChild(root_0, arrCall28.Tree);
				DebugLocation(131, 17);
				ASS29=(IToken)Match(input,ASS,Follow._ASS_in_bodyFExpr686); 
				ASS29_tree = (object)adaptor.Create(ASS29);
				root_0 = (object)adaptor.BecomeRoot(ASS29_tree, root_0);

				DebugLocation(131, 19);
				PushFollow(Follow._mathExpr_in_bodyFExpr689);
				mathExpr30=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr30.Tree);
				DebugLocation(131, 34);
				OP_END31=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr691); 

				}
				break;
			case 12:
				DebugEnterAlt(12);
				// Lang2.g:132:6: RETURN ( mathExpr )? OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(132, 12);
				RETURN32=(IToken)Match(input,RETURN,Follow._RETURN_in_bodyFExpr699); 
				RETURN32_tree = (object)adaptor.Create(RETURN32);
				root_0 = (object)adaptor.BecomeRoot(RETURN32_tree, root_0);

				DebugLocation(132, 14);
				// Lang2.g:132:14: ( mathExpr )?
				int alt1=2;
				try { DebugEnterSubRule(1);
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>=INT && LA1_0<=STRING)||LA1_0==INVERT||LA1_0==ID||LA1_0==53))
				{
					alt1=1;
				}
				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:132:14: mathExpr
					{
					DebugLocation(132, 14);
					PushFollow(Follow._mathExpr_in_bodyFExpr702);
					mathExpr33=mathExpr();
					PopFollow();

					adaptor.AddChild(root_0, mathExpr33.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(1); }

				DebugLocation(132, 30);
				OP_END34=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr705); 

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
			TraceOut("bodyFExpr", 4);
			LeaveRule("bodyFExpr", 4);
			Leave_bodyFExpr();
		}
		DebugLocation(133, 4);
		} finally { DebugExitRule(GrammarFileName, "bodyFExpr"); }
		return retval;

	}
	// $ANTLR end "bodyFExpr"

	public class elseExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_elseExpr();
	partial void Leave_elseExpr();

	// $ANTLR start "elseExpr"
	// Lang2.g:135:1: elseExpr : ELSE '{' bodyExpr '}' -> ^( ELSE bodyExpr ) ;
	[GrammarRule("elseExpr")]
	private Lang2Parser.elseExpr_return elseExpr()
	{
		Enter_elseExpr();
		EnterRule("elseExpr", 5);
		TraceIn("elseExpr", 5);
		Lang2Parser.elseExpr_return retval = new Lang2Parser.elseExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ELSE35=null;
		IToken char_literal36=null;
		IToken char_literal38=null;
		Lang2Parser.bodyExpr_return bodyExpr37 = default(Lang2Parser.bodyExpr_return);

		object ELSE35_tree=null;
		object char_literal36_tree=null;
		object char_literal38_tree=null;
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "elseExpr");
		DebugLocation(135, 2);
		try
		{
			// Lang2.g:135:9: ( ELSE '{' bodyExpr '}' -> ^( ELSE bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:135:11: ELSE '{' bodyExpr '}'
			{
			DebugLocation(135, 11);
			ELSE35=(IToken)Match(input,ELSE,Follow._ELSE_in_elseExpr718);  
			stream_ELSE.Add(ELSE35);

			DebugLocation(135, 16);
			char_literal36=(IToken)Match(input,51,Follow._51_in_elseExpr720);  
			stream_51.Add(char_literal36);

			DebugLocation(135, 19);
			PushFollow(Follow._bodyExpr_in_elseExpr721);
			bodyExpr37=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr37.Tree);
			DebugLocation(135, 27);
			char_literal38=(IToken)Match(input,52,Follow._52_in_elseExpr722);  
			stream_52.Add(char_literal38);



			{
			// AST REWRITE
			// elements: bodyExpr, ELSE
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 135:31: -> ^( ELSE bodyExpr )
			{
				DebugLocation(135, 34);
				// Lang2.g:135:34: ^( ELSE bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(135, 36);
				root_1 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_1);

				DebugLocation(135, 41);
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
			TraceOut("elseExpr", 5);
			LeaveRule("elseExpr", 5);
			Leave_elseExpr();
		}
		DebugLocation(136, 2);
		} finally { DebugExitRule(GrammarFileName, "elseExpr"); }
		return retval;

	}
	// $ANTLR end "elseExpr"

	public class ifExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_ifExpr();
	partial void Leave_ifExpr();

	// $ANTLR start "ifExpr"
	// Lang2.g:138:1: ifExpr : IF '(' mathExpr ')' '{' bodyExpr '}' ( elseExpr )? -> ^( IF mathExpr bodyExpr ( elseExpr )? ) ;
	[GrammarRule("ifExpr")]
	private Lang2Parser.ifExpr_return ifExpr()
	{
		Enter_ifExpr();
		EnterRule("ifExpr", 6);
		TraceIn("ifExpr", 6);
		Lang2Parser.ifExpr_return retval = new Lang2Parser.ifExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF39=null;
		IToken char_literal40=null;
		IToken char_literal42=null;
		IToken char_literal43=null;
		IToken char_literal45=null;
		Lang2Parser.mathExpr_return mathExpr41 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.bodyExpr_return bodyExpr44 = default(Lang2Parser.bodyExpr_return);
		Lang2Parser.elseExpr_return elseExpr46 = default(Lang2Parser.elseExpr_return);

		object IF39_tree=null;
		object char_literal40_tree=null;
		object char_literal42_tree=null;
		object char_literal43_tree=null;
		object char_literal45_tree=null;
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_54=new RewriteRuleITokenStream(adaptor,"token 54");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		RewriteRuleSubtreeStream stream_elseExpr=new RewriteRuleSubtreeStream(adaptor,"rule elseExpr");
		try { DebugEnterRule(GrammarFileName, "ifExpr");
		DebugLocation(138, 2);
		try
		{
			// Lang2.g:138:8: ( IF '(' mathExpr ')' '{' bodyExpr '}' ( elseExpr )? -> ^( IF mathExpr bodyExpr ( elseExpr )? ) )
			DebugEnterAlt(1);
			// Lang2.g:138:10: IF '(' mathExpr ')' '{' bodyExpr '}' ( elseExpr )?
			{
			DebugLocation(138, 10);
			IF39=(IToken)Match(input,IF,Follow._IF_in_ifExpr741);  
			stream_IF.Add(IF39);

			DebugLocation(138, 12);
			char_literal40=(IToken)Match(input,53,Follow._53_in_ifExpr742);  
			stream_53.Add(char_literal40);

			DebugLocation(138, 16);
			PushFollow(Follow._mathExpr_in_ifExpr744);
			mathExpr41=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr41.Tree);
			DebugLocation(138, 24);
			char_literal42=(IToken)Match(input,54,Follow._54_in_ifExpr745);  
			stream_54.Add(char_literal42);

			DebugLocation(138, 28);
			char_literal43=(IToken)Match(input,51,Follow._51_in_ifExpr747);  
			stream_51.Add(char_literal43);

			DebugLocation(138, 31);
			PushFollow(Follow._bodyExpr_in_ifExpr748);
			bodyExpr44=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr44.Tree);
			DebugLocation(138, 39);
			char_literal45=(IToken)Match(input,52,Follow._52_in_ifExpr749);  
			stream_52.Add(char_literal45);

			DebugLocation(138, 43);
			// Lang2.g:138:43: ( elseExpr )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0==ELSE))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:138:43: elseExpr
				{
				DebugLocation(138, 43);
				PushFollow(Follow._elseExpr_in_ifExpr751);
				elseExpr46=elseExpr();
				PopFollow();

				stream_elseExpr.Add(elseExpr46.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(3); }



			{
			// AST REWRITE
			// elements: mathExpr, elseExpr, IF, bodyExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 138:53: -> ^( IF mathExpr bodyExpr ( elseExpr )? )
			{
				DebugLocation(138, 56);
				// Lang2.g:138:56: ^( IF mathExpr bodyExpr ( elseExpr )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(138, 58);
				root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

				DebugLocation(138, 61);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(138, 70);
				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());
				DebugLocation(138, 79);
				// Lang2.g:138:79: ( elseExpr )?
				if ( stream_elseExpr.HasNext )
				{
					DebugLocation(138, 79);
					adaptor.AddChild(root_1, stream_elseExpr.NextTree());

				}
				stream_elseExpr.Reset();

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
			TraceOut("ifExpr", 6);
			LeaveRule("ifExpr", 6);
			Leave_ifExpr();
		}
		DebugLocation(139, 2);
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
	// Lang2.g:140:1: varFor : ( ID | varDecl );
	[GrammarRule("varFor")]
	private Lang2Parser.varFor_return varFor()
	{
		Enter_varFor();
		EnterRule("varFor", 7);
		TraceIn("varFor", 7);
		Lang2Parser.varFor_return retval = new Lang2Parser.varFor_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID47=null;
		Lang2Parser.varDecl_return varDecl48 = default(Lang2Parser.varDecl_return);

		object ID47_tree=null;

		try { DebugEnterRule(GrammarFileName, "varFor");
		DebugLocation(140, 2);
		try
		{
			// Lang2.g:140:8: ( ID | varDecl )
			int alt4=2;
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			int LA4_0 = input.LA(1);

			if ((LA4_0==ID))
			{
				alt4=1;
			}
			else if (((LA4_0>=TINT && LA4_0<=TVOID)))
			{
				alt4=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 4, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:140:10: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(140, 10);
				ID47=(IToken)Match(input,ID,Follow._ID_in_varFor775); 
				ID47_tree = (object)adaptor.Create(ID47);
				adaptor.AddChild(root_0, ID47_tree);


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:141:5: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(141, 5);
				PushFollow(Follow._varDecl_in_varFor781);
				varDecl48=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl48.Tree);

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
			TraceOut("varFor", 7);
			LeaveRule("varFor", 7);
			Leave_varFor();
		}
		DebugLocation(142, 2);
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
	// Lang2.g:143:1: iterFor : ( ID ASS mathExpr | mathExpr );
	[GrammarRule("iterFor")]
	private Lang2Parser.iterFor_return iterFor()
	{
		Enter_iterFor();
		EnterRule("iterFor", 8);
		TraceIn("iterFor", 8);
		Lang2Parser.iterFor_return retval = new Lang2Parser.iterFor_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID49=null;
		IToken ASS50=null;
		Lang2Parser.mathExpr_return mathExpr51 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.mathExpr_return mathExpr52 = default(Lang2Parser.mathExpr_return);

		object ID49_tree=null;
		object ASS50_tree=null;

		try { DebugEnterRule(GrammarFileName, "iterFor");
		DebugLocation(143, 2);
		try
		{
			// Lang2.g:143:9: ( ID ASS mathExpr | mathExpr )
			int alt5=2;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0==ID))
			{
				int LA5_1 = input.LA(2);

				if ((LA5_1==ASS))
				{
					alt5=1;
				}
				else if (((LA5_1>=ADD && LA5_1<=DIV)||(LA5_1>=DISJ && LA5_1<=IS_EQUALLY)||(LA5_1>=IS_LESS_OR_EQUAL && LA5_1<=IS_MORE_OR_EQUAL)||LA5_1==49||(LA5_1>=53 && LA5_1<=54)))
				{
					alt5=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 5, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if (((LA5_0>=INT && LA5_0<=STRING)||LA5_0==INVERT||LA5_0==53))
			{
				alt5=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:143:11: ID ASS mathExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(143, 11);
				ID49=(IToken)Match(input,ID,Follow._ID_in_iterFor791); 
				ID49_tree = (object)adaptor.Create(ID49);
				adaptor.AddChild(root_0, ID49_tree);

				DebugLocation(143, 17);
				ASS50=(IToken)Match(input,ASS,Follow._ASS_in_iterFor793); 
				ASS50_tree = (object)adaptor.Create(ASS50);
				root_0 = (object)adaptor.BecomeRoot(ASS50_tree, root_0);

				DebugLocation(143, 19);
				PushFollow(Follow._mathExpr_in_iterFor796);
				mathExpr51=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr51.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:144:5: mathExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(144, 5);
				PushFollow(Follow._mathExpr_in_iterFor802);
				mathExpr52=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr52.Tree);

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
			TraceOut("iterFor", 8);
			LeaveRule("iterFor", 8);
			Leave_iterFor();
		}
		DebugLocation(145, 2);
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
	// Lang2.g:146:1: forLoop : FOR '(' varFor ';' mathExpr ';' iterFor ')' '{' bodyExpr '}' -> ^( FOR varFor mathExpr iterFor bodyExpr ) ;
	[GrammarRule("forLoop")]
	private Lang2Parser.forLoop_return forLoop()
	{
		Enter_forLoop();
		EnterRule("forLoop", 9);
		TraceIn("forLoop", 9);
		Lang2Parser.forLoop_return retval = new Lang2Parser.forLoop_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FOR53=null;
		IToken char_literal54=null;
		IToken char_literal56=null;
		IToken char_literal58=null;
		IToken char_literal60=null;
		IToken char_literal61=null;
		IToken char_literal63=null;
		Lang2Parser.varFor_return varFor55 = default(Lang2Parser.varFor_return);
		Lang2Parser.mathExpr_return mathExpr57 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.iterFor_return iterFor59 = default(Lang2Parser.iterFor_return);
		Lang2Parser.bodyExpr_return bodyExpr62 = default(Lang2Parser.bodyExpr_return);

		object FOR53_tree=null;
		object char_literal54_tree=null;
		object char_literal56_tree=null;
		object char_literal58_tree=null;
		object char_literal60_tree=null;
		object char_literal61_tree=null;
		object char_literal63_tree=null;
		RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_54=new RewriteRuleITokenStream(adaptor,"token 54");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_iterFor=new RewriteRuleSubtreeStream(adaptor,"rule iterFor");
		RewriteRuleSubtreeStream stream_varFor=new RewriteRuleSubtreeStream(adaptor,"rule varFor");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "forLoop");
		DebugLocation(146, 2);
		try
		{
			// Lang2.g:146:9: ( FOR '(' varFor ';' mathExpr ';' iterFor ')' '{' bodyExpr '}' -> ^( FOR varFor mathExpr iterFor bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:146:11: FOR '(' varFor ';' mathExpr ';' iterFor ')' '{' bodyExpr '}'
			{
			DebugLocation(146, 11);
			FOR53=(IToken)Match(input,FOR,Follow._FOR_in_forLoop812);  
			stream_FOR.Add(FOR53);

			DebugLocation(146, 15);
			char_literal54=(IToken)Match(input,53,Follow._53_in_forLoop814);  
			stream_53.Add(char_literal54);

			DebugLocation(146, 19);
			PushFollow(Follow._varFor_in_forLoop816);
			varFor55=varFor();
			PopFollow();

			stream_varFor.Add(varFor55.Tree);
			DebugLocation(146, 26);
			char_literal56=(IToken)Match(input,OP_END,Follow._OP_END_in_forLoop818);  
			stream_OP_END.Add(char_literal56);

			DebugLocation(146, 30);
			PushFollow(Follow._mathExpr_in_forLoop820);
			mathExpr57=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr57.Tree);
			DebugLocation(146, 39);
			char_literal58=(IToken)Match(input,OP_END,Follow._OP_END_in_forLoop822);  
			stream_OP_END.Add(char_literal58);

			DebugLocation(146, 43);
			PushFollow(Follow._iterFor_in_forLoop824);
			iterFor59=iterFor();
			PopFollow();

			stream_iterFor.Add(iterFor59.Tree);
			DebugLocation(146, 51);
			char_literal60=(IToken)Match(input,54,Follow._54_in_forLoop826);  
			stream_54.Add(char_literal60);

			DebugLocation(146, 55);
			char_literal61=(IToken)Match(input,51,Follow._51_in_forLoop828);  
			stream_51.Add(char_literal61);

			DebugLocation(146, 58);
			PushFollow(Follow._bodyExpr_in_forLoop829);
			bodyExpr62=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr62.Tree);
			DebugLocation(146, 66);
			char_literal63=(IToken)Match(input,52,Follow._52_in_forLoop830);  
			stream_52.Add(char_literal63);



			{
			// AST REWRITE
			// elements: bodyExpr, FOR, mathExpr, varFor, iterFor
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 146:70: -> ^( FOR varFor mathExpr iterFor bodyExpr )
			{
				DebugLocation(146, 73);
				// Lang2.g:146:73: ^( FOR varFor mathExpr iterFor bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(146, 75);
				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

				DebugLocation(146, 79);
				adaptor.AddChild(root_1, stream_varFor.NextTree());
				DebugLocation(146, 86);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(146, 95);
				adaptor.AddChild(root_1, stream_iterFor.NextTree());
				DebugLocation(146, 103);
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
			TraceOut("forLoop", 9);
			LeaveRule("forLoop", 9);
			Leave_forLoop();
		}
		DebugLocation(147, 2);
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
	// Lang2.g:148:1: whileLoop : WHILE '(' mathExpr ')' '{' bodyExpr '}' -> ^( WHILE mathExpr bodyExpr ) ;
	[GrammarRule("whileLoop")]
	private Lang2Parser.whileLoop_return whileLoop()
	{
		Enter_whileLoop();
		EnterRule("whileLoop", 10);
		TraceIn("whileLoop", 10);
		Lang2Parser.whileLoop_return retval = new Lang2Parser.whileLoop_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE64=null;
		IToken char_literal65=null;
		IToken char_literal67=null;
		IToken char_literal68=null;
		IToken char_literal70=null;
		Lang2Parser.mathExpr_return mathExpr66 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.bodyExpr_return bodyExpr69 = default(Lang2Parser.bodyExpr_return);

		object WHILE64_tree=null;
		object char_literal65_tree=null;
		object char_literal67_tree=null;
		object char_literal68_tree=null;
		object char_literal70_tree=null;
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_54=new RewriteRuleITokenStream(adaptor,"token 54");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "whileLoop");
		DebugLocation(148, 3);
		try
		{
			// Lang2.g:148:11: ( WHILE '(' mathExpr ')' '{' bodyExpr '}' -> ^( WHILE mathExpr bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:148:13: WHILE '(' mathExpr ')' '{' bodyExpr '}'
			{
			DebugLocation(148, 13);
			WHILE64=(IToken)Match(input,WHILE,Follow._WHILE_in_whileLoop854);  
			stream_WHILE.Add(WHILE64);

			DebugLocation(148, 19);
			char_literal65=(IToken)Match(input,53,Follow._53_in_whileLoop856);  
			stream_53.Add(char_literal65);

			DebugLocation(148, 22);
			PushFollow(Follow._mathExpr_in_whileLoop857);
			mathExpr66=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr66.Tree);
			DebugLocation(148, 30);
			char_literal67=(IToken)Match(input,54,Follow._54_in_whileLoop858);  
			stream_54.Add(char_literal67);

			DebugLocation(148, 34);
			char_literal68=(IToken)Match(input,51,Follow._51_in_whileLoop860);  
			stream_51.Add(char_literal68);

			DebugLocation(148, 37);
			PushFollow(Follow._bodyExpr_in_whileLoop861);
			bodyExpr69=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr69.Tree);
			DebugLocation(148, 45);
			char_literal70=(IToken)Match(input,52,Follow._52_in_whileLoop862);  
			stream_52.Add(char_literal70);



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
			// 148:49: -> ^( WHILE mathExpr bodyExpr )
			{
				DebugLocation(148, 52);
				// Lang2.g:148:52: ^( WHILE mathExpr bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(148, 54);
				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

				DebugLocation(148, 60);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(148, 69);
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
			TraceOut("whileLoop", 10);
			LeaveRule("whileLoop", 10);
			Leave_whileLoop();
		}
		DebugLocation(149, 3);
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
	// Lang2.g:150:1: doLoop : DO '{' bodyExpr '}' WHILE '(' mathExpr ')' OP_END -> ^( DO bodyExpr mathExpr ) ;
	[GrammarRule("doLoop")]
	private Lang2Parser.doLoop_return doLoop()
	{
		Enter_doLoop();
		EnterRule("doLoop", 11);
		TraceIn("doLoop", 11);
		Lang2Parser.doLoop_return retval = new Lang2Parser.doLoop_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DO71=null;
		IToken char_literal72=null;
		IToken char_literal74=null;
		IToken WHILE75=null;
		IToken char_literal76=null;
		IToken char_literal78=null;
		IToken OP_END79=null;
		Lang2Parser.bodyExpr_return bodyExpr73 = default(Lang2Parser.bodyExpr_return);
		Lang2Parser.mathExpr_return mathExpr77 = default(Lang2Parser.mathExpr_return);

		object DO71_tree=null;
		object char_literal72_tree=null;
		object char_literal74_tree=null;
		object WHILE75_tree=null;
		object char_literal76_tree=null;
		object char_literal78_tree=null;
		object OP_END79_tree=null;
		RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_54=new RewriteRuleITokenStream(adaptor,"token 54");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "doLoop");
		DebugLocation(150, 3);
		try
		{
			// Lang2.g:150:9: ( DO '{' bodyExpr '}' WHILE '(' mathExpr ')' OP_END -> ^( DO bodyExpr mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:150:11: DO '{' bodyExpr '}' WHILE '(' mathExpr ')' OP_END
			{
			DebugLocation(150, 11);
			DO71=(IToken)Match(input,DO,Follow._DO_in_doLoop884);  
			stream_DO.Add(DO71);

			DebugLocation(150, 14);
			char_literal72=(IToken)Match(input,51,Follow._51_in_doLoop886);  
			stream_51.Add(char_literal72);

			DebugLocation(150, 17);
			PushFollow(Follow._bodyExpr_in_doLoop887);
			bodyExpr73=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr73.Tree);
			DebugLocation(150, 25);
			char_literal74=(IToken)Match(input,52,Follow._52_in_doLoop888);  
			stream_52.Add(char_literal74);

			DebugLocation(150, 29);
			WHILE75=(IToken)Match(input,WHILE,Follow._WHILE_in_doLoop890);  
			stream_WHILE.Add(WHILE75);

			DebugLocation(150, 35);
			char_literal76=(IToken)Match(input,53,Follow._53_in_doLoop892);  
			stream_53.Add(char_literal76);

			DebugLocation(150, 38);
			PushFollow(Follow._mathExpr_in_doLoop893);
			mathExpr77=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr77.Tree);
			DebugLocation(150, 46);
			char_literal78=(IToken)Match(input,54,Follow._54_in_doLoop894);  
			stream_54.Add(char_literal78);

			DebugLocation(150, 50);
			OP_END79=(IToken)Match(input,OP_END,Follow._OP_END_in_doLoop896);  
			stream_OP_END.Add(OP_END79);



			{
			// AST REWRITE
			// elements: bodyExpr, mathExpr, DO
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 150:57: -> ^( DO bodyExpr mathExpr )
			{
				DebugLocation(150, 60);
				// Lang2.g:150:60: ^( DO bodyExpr mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(150, 62);
				root_1 = (object)adaptor.BecomeRoot(stream_DO.NextNode(), root_1);

				DebugLocation(150, 65);
				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());
				DebugLocation(150, 74);
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
			TraceOut("doLoop", 11);
			LeaveRule("doLoop", 11);
			Leave_doLoop();
		}
		DebugLocation(151, 3);
		} finally { DebugExitRule(GrammarFileName, "doLoop"); }
		return retval;

	}
	// $ANTLR end "doLoop"

	public class literals_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_literals();
	partial void Leave_literals();

	// $ANTLR start "literals"
	// Lang2.g:153:1: literals : ( INT | STRING | CHAR | DOUBLE );
	[GrammarRule("literals")]
	private Lang2Parser.literals_return literals()
	{
		Enter_literals();
		EnterRule("literals", 12);
		TraceIn("literals", 12);
		Lang2Parser.literals_return retval = new Lang2Parser.literals_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set80=null;

		object set80_tree=null;

		try { DebugEnterRule(GrammarFileName, "literals");
		DebugLocation(153, 3);
		try
		{
			// Lang2.g:153:10: ( INT | STRING | CHAR | DOUBLE )
			DebugEnterAlt(1);
			// Lang2.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(153, 10);
			set80=(IToken)input.LT(1);
			if ((input.LA(1)>=INT && input.LA(1)<=STRING))
			{
				input.Consume();
				adaptor.AddChild(root_0, (object)adaptor.Create(set80));
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
			TraceOut("literals", 12);
			LeaveRule("literals", 12);
			Leave_literals();
		}
		DebugLocation(154, 3);
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
	// Lang2.g:155:1: incSug : ID ADD ADD -> ^( INC ID ) ;
	[GrammarRule("incSug")]
	private Lang2Parser.incSug_return incSug()
	{
		Enter_incSug();
		EnterRule("incSug", 13);
		TraceIn("incSug", 13);
		Lang2Parser.incSug_return retval = new Lang2Parser.incSug_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID81=null;
		IToken ADD82=null;
		IToken ADD83=null;

		object ID81_tree=null;
		object ADD82_tree=null;
		object ADD83_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ADD=new RewriteRuleITokenStream(adaptor,"token ADD");

		try { DebugEnterRule(GrammarFileName, "incSug");
		DebugLocation(155, 2);
		try
		{
			// Lang2.g:155:8: ( ID ADD ADD -> ^( INC ID ) )
			DebugEnterAlt(1);
			// Lang2.g:155:10: ID ADD ADD
			{
			DebugLocation(155, 10);
			ID81=(IToken)Match(input,ID,Follow._ID_in_incSug935);  
			stream_ID.Add(ID81);

			DebugLocation(155, 13);
			ADD82=(IToken)Match(input,ADD,Follow._ADD_in_incSug937);  
			stream_ADD.Add(ADD82);

			DebugLocation(155, 17);
			ADD83=(IToken)Match(input,ADD,Follow._ADD_in_incSug939);  
			stream_ADD.Add(ADD83);



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
			// 155:21: -> ^( INC ID )
			{
				DebugLocation(155, 24);
				// Lang2.g:155:24: ^( INC ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(155, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INC, "INC"), root_1);

				DebugLocation(155, 30);
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
			TraceOut("incSug", 13);
			LeaveRule("incSug", 13);
			Leave_incSug();
		}
		DebugLocation(156, 2);
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
	// Lang2.g:157:1: decSug : ID SUB SUB -> ^( DEC ID ) ;
	[GrammarRule("decSug")]
	private Lang2Parser.decSug_return decSug()
	{
		Enter_decSug();
		EnterRule("decSug", 14);
		TraceIn("decSug", 14);
		Lang2Parser.decSug_return retval = new Lang2Parser.decSug_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID84=null;
		IToken SUB85=null;
		IToken SUB86=null;

		object ID84_tree=null;
		object SUB85_tree=null;
		object SUB86_tree=null;
		RewriteRuleITokenStream stream_SUB=new RewriteRuleITokenStream(adaptor,"token SUB");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "decSug");
		DebugLocation(157, 2);
		try
		{
			// Lang2.g:157:8: ( ID SUB SUB -> ^( DEC ID ) )
			DebugEnterAlt(1);
			// Lang2.g:157:10: ID SUB SUB
			{
			DebugLocation(157, 10);
			ID84=(IToken)Match(input,ID,Follow._ID_in_decSug957);  
			stream_ID.Add(ID84);

			DebugLocation(157, 13);
			SUB85=(IToken)Match(input,SUB,Follow._SUB_in_decSug959);  
			stream_SUB.Add(SUB85);

			DebugLocation(157, 17);
			SUB86=(IToken)Match(input,SUB,Follow._SUB_in_decSug961);  
			stream_SUB.Add(SUB86);



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
			// 157:21: -> ^( DEC ID )
			{
				DebugLocation(157, 24);
				// Lang2.g:157:24: ^( DEC ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(157, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DEC, "DEC"), root_1);

				DebugLocation(157, 30);
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
			TraceOut("decSug", 14);
			LeaveRule("decSug", 14);
			Leave_decSug();
		}
		DebugLocation(158, 2);
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
	// Lang2.g:159:1: mathGroup : ( '(' mathExpr ')' | ID | methCall | literals | incSug | decSug | arrCall );
	[GrammarRule("mathGroup")]
	private Lang2Parser.mathGroup_return mathGroup()
	{
		Enter_mathGroup();
		EnterRule("mathGroup", 15);
		TraceIn("mathGroup", 15);
		Lang2Parser.mathGroup_return retval = new Lang2Parser.mathGroup_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal87=null;
		IToken char_literal89=null;
		IToken ID90=null;
		Lang2Parser.mathExpr_return mathExpr88 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.methCall_return methCall91 = default(Lang2Parser.methCall_return);
		Lang2Parser.literals_return literals92 = default(Lang2Parser.literals_return);
		Lang2Parser.incSug_return incSug93 = default(Lang2Parser.incSug_return);
		Lang2Parser.decSug_return decSug94 = default(Lang2Parser.decSug_return);
		Lang2Parser.arrCall_return arrCall95 = default(Lang2Parser.arrCall_return);

		object char_literal87_tree=null;
		object char_literal89_tree=null;
		object ID90_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathGroup");
		DebugLocation(159, 3);
		try
		{
			// Lang2.g:159:11: ( '(' mathExpr ')' | ID | methCall | literals | incSug | decSug | arrCall )
			int alt6=7;
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
				// Lang2.g:159:13: '(' mathExpr ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(159, 16);
				char_literal87=(IToken)Match(input,53,Follow._53_in_mathGroup979); 
				DebugLocation(159, 18);
				PushFollow(Follow._mathExpr_in_mathGroup982);
				mathExpr88=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr88.Tree);
				DebugLocation(159, 30);
				char_literal89=(IToken)Match(input,54,Follow._54_in_mathGroup984); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:160:6: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(160, 6);
				ID90=(IToken)Match(input,ID,Follow._ID_in_mathGroup992); 
				ID90_tree = (object)adaptor.Create(ID90);
				adaptor.AddChild(root_0, ID90_tree);


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:161:6: methCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(161, 6);
				PushFollow(Follow._methCall_in_mathGroup999);
				methCall91=methCall();
				PopFollow();

				adaptor.AddChild(root_0, methCall91.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Lang2.g:162:6: literals
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(162, 6);
				PushFollow(Follow._literals_in_mathGroup1006);
				literals92=literals();
				PopFollow();

				adaptor.AddChild(root_0, literals92.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Lang2.g:163:6: incSug
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(163, 6);
				PushFollow(Follow._incSug_in_mathGroup1013);
				incSug93=incSug();
				PopFollow();

				adaptor.AddChild(root_0, incSug93.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Lang2.g:164:6: decSug
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(164, 6);
				PushFollow(Follow._decSug_in_mathGroup1020);
				decSug94=decSug();
				PopFollow();

				adaptor.AddChild(root_0, decSug94.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Lang2.g:165:6: arrCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(165, 6);
				PushFollow(Follow._arrCall_in_mathGroup1027);
				arrCall95=arrCall();
				PopFollow();

				adaptor.AddChild(root_0, arrCall95.Tree);

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
			TraceOut("mathGroup", 15);
			LeaveRule("mathGroup", 15);
			Leave_mathGroup();
		}
		DebugLocation(166, 3);
		} finally { DebugExitRule(GrammarFileName, "mathGroup"); }
		return retval;

	}
	// $ANTLR end "mathGroup"

	public class mathMult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathMult();
	partial void Leave_mathMult();

	// $ANTLR start "mathMult"
	// Lang2.g:168:1: mathMult : mathGroup ( ( MULT | DIV ) mathGroup )* ;
	[GrammarRule("mathMult")]
	private Lang2Parser.mathMult_return mathMult()
	{
		Enter_mathMult();
		EnterRule("mathMult", 16);
		TraceIn("mathMult", 16);
		Lang2Parser.mathMult_return retval = new Lang2Parser.mathMult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set97=null;
		Lang2Parser.mathGroup_return mathGroup96 = default(Lang2Parser.mathGroup_return);
		Lang2Parser.mathGroup_return mathGroup98 = default(Lang2Parser.mathGroup_return);

		object set97_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathMult");
		DebugLocation(168, 3);
		try
		{
			// Lang2.g:168:10: ( mathGroup ( ( MULT | DIV ) mathGroup )* )
			DebugEnterAlt(1);
			// Lang2.g:168:12: mathGroup ( ( MULT | DIV ) mathGroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(168, 12);
			PushFollow(Follow._mathGroup_in_mathMult1042);
			mathGroup96=mathGroup();
			PopFollow();

			adaptor.AddChild(root_0, mathGroup96.Tree);
			DebugLocation(168, 21);
			// Lang2.g:168:21: ( ( MULT | DIV ) mathGroup )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if (((LA7_0>=MULT && LA7_0<=DIV)))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:168:22: ( MULT | DIV ) mathGroup
					{
					DebugLocation(168, 22);
					set97=(IToken)input.LT(1);
					set97=(IToken)input.LT(1);
					if ((input.LA(1)>=MULT && input.LA(1)<=DIV))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set97), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(168, 33);
					PushFollow(Follow._mathGroup_in_mathMult1050);
					mathGroup98=mathGroup();
					PopFollow();

					adaptor.AddChild(root_0, mathGroup98.Tree);

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }


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
			TraceOut("mathMult", 16);
			LeaveRule("mathMult", 16);
			Leave_mathMult();
		}
		DebugLocation(169, 3);
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
	// Lang2.g:170:1: mathAdd : mathMult ( ( ADD | SUB ) mathMult )* ;
	[GrammarRule("mathAdd")]
	private Lang2Parser.mathAdd_return mathAdd()
	{
		Enter_mathAdd();
		EnterRule("mathAdd", 17);
		TraceIn("mathAdd", 17);
		Lang2Parser.mathAdd_return retval = new Lang2Parser.mathAdd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set100=null;
		Lang2Parser.mathMult_return mathMult99 = default(Lang2Parser.mathMult_return);
		Lang2Parser.mathMult_return mathMult101 = default(Lang2Parser.mathMult_return);

		object set100_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathAdd");
		DebugLocation(170, 3);
		try
		{
			// Lang2.g:170:10: ( mathMult ( ( ADD | SUB ) mathMult )* )
			DebugEnterAlt(1);
			// Lang2.g:170:12: mathMult ( ( ADD | SUB ) mathMult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(170, 12);
			PushFollow(Follow._mathMult_in_mathAdd1064);
			mathMult99=mathMult();
			PopFollow();

			adaptor.AddChild(root_0, mathMult99.Tree);
			DebugLocation(170, 20);
			// Lang2.g:170:20: ( ( ADD | SUB ) mathMult )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if (((LA8_0>=ADD && LA8_0<=SUB)))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:170:21: ( ADD | SUB ) mathMult
					{
					DebugLocation(170, 21);
					set100=(IToken)input.LT(1);
					set100=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set100), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(170, 32);
					PushFollow(Follow._mathMult_in_mathAdd1073);
					mathMult101=mathMult();
					PopFollow();

					adaptor.AddChild(root_0, mathMult101.Tree);

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


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
			TraceOut("mathAdd", 17);
			LeaveRule("mathAdd", 17);
			Leave_mathAdd();
		}
		DebugLocation(171, 3);
		} finally { DebugExitRule(GrammarFileName, "mathAdd"); }
		return retval;

	}
	// $ANTLR end "mathAdd"

	public class mathConj_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathConj();
	partial void Leave_mathConj();

	// $ANTLR start "mathConj"
	// Lang2.g:173:1: mathConj : mathAdd ( CONJ mathAdd )* ;
	[GrammarRule("mathConj")]
	private Lang2Parser.mathConj_return mathConj()
	{
		Enter_mathConj();
		EnterRule("mathConj", 18);
		TraceIn("mathConj", 18);
		Lang2Parser.mathConj_return retval = new Lang2Parser.mathConj_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CONJ103=null;
		Lang2Parser.mathAdd_return mathAdd102 = default(Lang2Parser.mathAdd_return);
		Lang2Parser.mathAdd_return mathAdd104 = default(Lang2Parser.mathAdd_return);

		object CONJ103_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathConj");
		DebugLocation(173, 3);
		try
		{
			// Lang2.g:173:10: ( mathAdd ( CONJ mathAdd )* )
			DebugEnterAlt(1);
			// Lang2.g:173:12: mathAdd ( CONJ mathAdd )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(173, 12);
			PushFollow(Follow._mathAdd_in_mathConj1087);
			mathAdd102=mathAdd();
			PopFollow();

			adaptor.AddChild(root_0, mathAdd102.Tree);
			DebugLocation(173, 19);
			// Lang2.g:173:19: ( CONJ mathAdd )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if ((LA9_0==CONJ))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:173:20: CONJ mathAdd
					{
					DebugLocation(173, 24);
					CONJ103=(IToken)Match(input,CONJ,Follow._CONJ_in_mathConj1089); 
					CONJ103_tree = (object)adaptor.Create(CONJ103);
					root_0 = (object)adaptor.BecomeRoot(CONJ103_tree, root_0);

					DebugLocation(173, 26);
					PushFollow(Follow._mathAdd_in_mathConj1092);
					mathAdd104=mathAdd();
					PopFollow();

					adaptor.AddChild(root_0, mathAdd104.Tree);

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }


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
			TraceOut("mathConj", 18);
			LeaveRule("mathConj", 18);
			Leave_mathConj();
		}
		DebugLocation(174, 3);
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
	// Lang2.g:176:1: mathDisj : mathConj ( DISJ mathConj )* ;
	[GrammarRule("mathDisj")]
	private Lang2Parser.mathDisj_return mathDisj()
	{
		Enter_mathDisj();
		EnterRule("mathDisj", 19);
		TraceIn("mathDisj", 19);
		Lang2Parser.mathDisj_return retval = new Lang2Parser.mathDisj_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DISJ106=null;
		Lang2Parser.mathConj_return mathConj105 = default(Lang2Parser.mathConj_return);
		Lang2Parser.mathConj_return mathConj107 = default(Lang2Parser.mathConj_return);

		object DISJ106_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathDisj");
		DebugLocation(176, 3);
		try
		{
			// Lang2.g:176:10: ( mathConj ( DISJ mathConj )* )
			DebugEnterAlt(1);
			// Lang2.g:176:12: mathConj ( DISJ mathConj )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(176, 12);
			PushFollow(Follow._mathConj_in_mathDisj1106);
			mathConj105=mathConj();
			PopFollow();

			adaptor.AddChild(root_0, mathConj105.Tree);
			DebugLocation(176, 20);
			// Lang2.g:176:20: ( DISJ mathConj )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==DISJ))
				{
					alt10=1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:176:21: DISJ mathConj
					{
					DebugLocation(176, 25);
					DISJ106=(IToken)Match(input,DISJ,Follow._DISJ_in_mathDisj1108); 
					DISJ106_tree = (object)adaptor.Create(DISJ106);
					root_0 = (object)adaptor.BecomeRoot(DISJ106_tree, root_0);

					DebugLocation(176, 27);
					PushFollow(Follow._mathConj_in_mathDisj1111);
					mathConj107=mathConj();
					PopFollow();

					adaptor.AddChild(root_0, mathConj107.Tree);

					}
					break;

				default:
					goto loop10;
				}
			}

			loop10:
				;

			} finally { DebugExitSubRule(10); }


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
			TraceOut("mathDisj", 19);
			LeaveRule("mathDisj", 19);
			Leave_mathDisj();
		}
		DebugLocation(177, 3);
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
	// Lang2.g:179:1: mathEq : mathDisj ( ( IS_MORE | IS_LESS | IS_EQUALLY | IS_MORE_OR_EQUAL | IS_LESS_OR_EQUAL ) mathDisj )* ;
	[GrammarRule("mathEq")]
	private Lang2Parser.mathEq_return mathEq()
	{
		Enter_mathEq();
		EnterRule("mathEq", 20);
		TraceIn("mathEq", 20);
		Lang2Parser.mathEq_return retval = new Lang2Parser.mathEq_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set109=null;
		Lang2Parser.mathDisj_return mathDisj108 = default(Lang2Parser.mathDisj_return);
		Lang2Parser.mathDisj_return mathDisj110 = default(Lang2Parser.mathDisj_return);

		object set109_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathEq");
		DebugLocation(179, 3);
		try
		{
			// Lang2.g:179:9: ( mathDisj ( ( IS_MORE | IS_LESS | IS_EQUALLY | IS_MORE_OR_EQUAL | IS_LESS_OR_EQUAL ) mathDisj )* )
			DebugEnterAlt(1);
			// Lang2.g:179:11: mathDisj ( ( IS_MORE | IS_LESS | IS_EQUALLY | IS_MORE_OR_EQUAL | IS_LESS_OR_EQUAL ) mathDisj )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(179, 11);
			PushFollow(Follow._mathDisj_in_mathEq1126);
			mathDisj108=mathDisj();
			PopFollow();

			adaptor.AddChild(root_0, mathDisj108.Tree);
			DebugLocation(179, 19);
			// Lang2.g:179:19: ( ( IS_MORE | IS_LESS | IS_EQUALLY | IS_MORE_OR_EQUAL | IS_LESS_OR_EQUAL ) mathDisj )*
			try { DebugEnterSubRule(11);
			while (true)
			{
				int alt11=2;
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				int LA11_0 = input.LA(1);

				if (((LA11_0>=IS_MORE && LA11_0<=IS_EQUALLY)||(LA11_0>=IS_LESS_OR_EQUAL && LA11_0<=IS_MORE_OR_EQUAL)))
				{
					alt11=1;
				}


				} finally { DebugExitDecision(11); }
				switch ( alt11 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:179:20: ( IS_MORE | IS_LESS | IS_EQUALLY | IS_MORE_OR_EQUAL | IS_LESS_OR_EQUAL ) mathDisj
					{
					DebugLocation(179, 20);
					set109=(IToken)input.LT(1);
					set109=(IToken)input.LT(1);
					if ((input.LA(1)>=IS_MORE && input.LA(1)<=IS_EQUALLY)||(input.LA(1)>=IS_LESS_OR_EQUAL && input.LA(1)<=IS_MORE_OR_EQUAL))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set109), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(179, 84);
					PushFollow(Follow._mathDisj_in_mathEq1141);
					mathDisj110=mathDisj();
					PopFollow();

					adaptor.AddChild(root_0, mathDisj110.Tree);

					}
					break;

				default:
					goto loop11;
				}
			}

			loop11:
				;

			} finally { DebugExitSubRule(11); }


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
			TraceOut("mathEq", 20);
			LeaveRule("mathEq", 20);
			Leave_mathEq();
		}
		DebugLocation(180, 3);
		} finally { DebugExitRule(GrammarFileName, "mathEq"); }
		return retval;

	}
	// $ANTLR end "mathEq"

	public class mathNeg_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathNeg();
	partial void Leave_mathNeg();

	// $ANTLR start "mathNeg"
	// Lang2.g:182:1: mathNeg : ( ( INVERT mathEq ) | ( mathEq ) );
	[GrammarRule("mathNeg")]
	private Lang2Parser.mathNeg_return mathNeg()
	{
		Enter_mathNeg();
		EnterRule("mathNeg", 21);
		TraceIn("mathNeg", 21);
		Lang2Parser.mathNeg_return retval = new Lang2Parser.mathNeg_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken INVERT111=null;
		Lang2Parser.mathEq_return mathEq112 = default(Lang2Parser.mathEq_return);
		Lang2Parser.mathEq_return mathEq113 = default(Lang2Parser.mathEq_return);

		object INVERT111_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathNeg");
		DebugLocation(182, 3);
		try
		{
			// Lang2.g:182:10: ( ( INVERT mathEq ) | ( mathEq ) )
			int alt12=2;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if ((LA12_0==INVERT))
			{
				alt12=1;
			}
			else if (((LA12_0>=INT && LA12_0<=STRING)||LA12_0==ID||LA12_0==53))
			{
				alt12=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:182:12: ( INVERT mathEq )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(182, 12);
				// Lang2.g:182:12: ( INVERT mathEq )
				DebugEnterAlt(1);
				// Lang2.g:182:13: INVERT mathEq
				{
				DebugLocation(182, 19);
				INVERT111=(IToken)Match(input,INVERT,Follow._INVERT_in_mathNeg1157); 
				INVERT111_tree = (object)adaptor.Create(INVERT111);
				root_0 = (object)adaptor.BecomeRoot(INVERT111_tree, root_0);

				DebugLocation(182, 21);
				PushFollow(Follow._mathEq_in_mathNeg1160);
				mathEq112=mathEq();
				PopFollow();

				adaptor.AddChild(root_0, mathEq112.Tree);

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:183:6: ( mathEq )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(183, 6);
				// Lang2.g:183:6: ( mathEq )
				DebugEnterAlt(1);
				// Lang2.g:183:7: mathEq
				{
				DebugLocation(183, 7);
				PushFollow(Follow._mathEq_in_mathNeg1169);
				mathEq113=mathEq();
				PopFollow();

				adaptor.AddChild(root_0, mathEq113.Tree);

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
			TraceOut("mathNeg", 21);
			LeaveRule("mathNeg", 21);
			Leave_mathNeg();
		}
		DebugLocation(184, 3);
		} finally { DebugExitRule(GrammarFileName, "mathNeg"); }
		return retval;

	}
	// $ANTLR end "mathNeg"

	public class mathExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathExpr();
	partial void Leave_mathExpr();

	// $ANTLR start "mathExpr"
	// Lang2.g:186:1: mathExpr : mathNeg ;
	[GrammarRule("mathExpr")]
	private Lang2Parser.mathExpr_return mathExpr()
	{
		Enter_mathExpr();
		EnterRule("mathExpr", 22);
		TraceIn("mathExpr", 22);
		Lang2Parser.mathExpr_return retval = new Lang2Parser.mathExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.mathNeg_return mathNeg114 = default(Lang2Parser.mathNeg_return);


		try { DebugEnterRule(GrammarFileName, "mathExpr");
		DebugLocation(186, 3);
		try
		{
			// Lang2.g:186:10: ( mathNeg )
			DebugEnterAlt(1);
			// Lang2.g:186:12: mathNeg
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(186, 12);
			PushFollow(Follow._mathNeg_in_mathExpr1182);
			mathNeg114=mathNeg();
			PopFollow();

			adaptor.AddChild(root_0, mathNeg114.Tree);

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
			TraceOut("mathExpr", 22);
			LeaveRule("mathExpr", 22);
			Leave_mathExpr();
		}
		DebugLocation(187, 3);
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
	// Lang2.g:192:1: methArgs : mathExpr ( ',' mathExpr )* -> ^( CALL_ARGS mathExpr ( mathExpr )* ) ;
	[GrammarRule("methArgs")]
	private Lang2Parser.methArgs_return methArgs()
	{
		Enter_methArgs();
		EnterRule("methArgs", 23);
		TraceIn("methArgs", 23);
		Lang2Parser.methArgs_return retval = new Lang2Parser.methArgs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal116=null;
		Lang2Parser.mathExpr_return mathExpr115 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.mathExpr_return mathExpr117 = default(Lang2Parser.mathExpr_return);

		object char_literal116_tree=null;
		RewriteRuleITokenStream stream_55=new RewriteRuleITokenStream(adaptor,"token 55");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		try { DebugEnterRule(GrammarFileName, "methArgs");
		DebugLocation(192, 3);
		try
		{
			// Lang2.g:192:10: ( mathExpr ( ',' mathExpr )* -> ^( CALL_ARGS mathExpr ( mathExpr )* ) )
			DebugEnterAlt(1);
			// Lang2.g:192:12: mathExpr ( ',' mathExpr )*
			{
			DebugLocation(192, 12);
			PushFollow(Follow._mathExpr_in_methArgs1197);
			mathExpr115=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr115.Tree);
			DebugLocation(192, 21);
			// Lang2.g:192:21: ( ',' mathExpr )*
			try { DebugEnterSubRule(13);
			while (true)
			{
				int alt13=2;
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				int LA13_0 = input.LA(1);

				if ((LA13_0==55))
				{
					alt13=1;
				}


				} finally { DebugExitDecision(13); }
				switch ( alt13 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:192:22: ',' mathExpr
					{
					DebugLocation(192, 22);
					char_literal116=(IToken)Match(input,55,Follow._55_in_methArgs1200);  
					stream_55.Add(char_literal116);

					DebugLocation(192, 26);
					PushFollow(Follow._mathExpr_in_methArgs1202);
					mathExpr117=mathExpr();
					PopFollow();

					stream_mathExpr.Add(mathExpr117.Tree);

					}
					break;

				default:
					goto loop13;
				}
			}

			loop13:
				;

			} finally { DebugExitSubRule(13); }



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
			// 192:37: -> ^( CALL_ARGS mathExpr ( mathExpr )* )
			{
				DebugLocation(192, 40);
				// Lang2.g:192:40: ^( CALL_ARGS mathExpr ( mathExpr )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(192, 42);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL_ARGS, "CALL_ARGS"), root_1);

				DebugLocation(192, 52);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(192, 61);
				// Lang2.g:192:61: ( mathExpr )*
				while ( stream_mathExpr.HasNext )
				{
					DebugLocation(192, 61);
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
			TraceOut("methArgs", 23);
			LeaveRule("methArgs", 23);
			Leave_methArgs();
		}
		DebugLocation(193, 3);
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
	// Lang2.g:194:1: methCall : ID '(' ( methArgs )? ')' -> ^( METH_CALL ID ( methArgs )? ) ;
	[GrammarRule("methCall")]
	private Lang2Parser.methCall_return methCall()
	{
		Enter_methCall();
		EnterRule("methCall", 24);
		TraceIn("methCall", 24);
		Lang2Parser.methCall_return retval = new Lang2Parser.methCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID118=null;
		IToken char_literal119=null;
		IToken char_literal121=null;
		Lang2Parser.methArgs_return methArgs120 = default(Lang2Parser.methArgs_return);

		object ID118_tree=null;
		object char_literal119_tree=null;
		object char_literal121_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_54=new RewriteRuleITokenStream(adaptor,"token 54");
		RewriteRuleSubtreeStream stream_methArgs=new RewriteRuleSubtreeStream(adaptor,"rule methArgs");
		try { DebugEnterRule(GrammarFileName, "methCall");
		DebugLocation(194, 3);
		try
		{
			// Lang2.g:194:10: ( ID '(' ( methArgs )? ')' -> ^( METH_CALL ID ( methArgs )? ) )
			DebugEnterAlt(1);
			// Lang2.g:194:12: ID '(' ( methArgs )? ')'
			{
			DebugLocation(194, 12);
			ID118=(IToken)Match(input,ID,Follow._ID_in_methCall1227);  
			stream_ID.Add(ID118);

			DebugLocation(194, 14);
			char_literal119=(IToken)Match(input,53,Follow._53_in_methCall1228);  
			stream_53.Add(char_literal119);

			DebugLocation(194, 17);
			// Lang2.g:194:17: ( methArgs )?
			int alt14=2;
			try { DebugEnterSubRule(14);
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if (((LA14_0>=INT && LA14_0<=STRING)||LA14_0==INVERT||LA14_0==ID||LA14_0==53))
			{
				alt14=1;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:194:17: methArgs
				{
				DebugLocation(194, 17);
				PushFollow(Follow._methArgs_in_methCall1229);
				methArgs120=methArgs();
				PopFollow();

				stream_methArgs.Add(methArgs120.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(14); }

			DebugLocation(194, 26);
			char_literal121=(IToken)Match(input,54,Follow._54_in_methCall1231);  
			stream_54.Add(char_literal121);



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
			// 194:30: -> ^( METH_CALL ID ( methArgs )? )
			{
				DebugLocation(194, 33);
				// Lang2.g:194:33: ^( METH_CALL ID ( methArgs )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(194, 35);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METH_CALL, "METH_CALL"), root_1);

				DebugLocation(194, 45);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(194, 48);
				// Lang2.g:194:48: ( methArgs )?
				if ( stream_methArgs.HasNext )
				{
					DebugLocation(194, 48);
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
			TraceOut("methCall", 24);
			LeaveRule("methCall", 24);
			Leave_methCall();
		}
		DebugLocation(195, 3);
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
	// Lang2.g:196:1: methArgODecl : ( type ID -> ^( VAR_DECL type ID ) | type '[' ']' ID -> ^( ARR_DECL type ID ) );
	[GrammarRule("methArgODecl")]
	private Lang2Parser.methArgODecl_return methArgODecl()
	{
		Enter_methArgODecl();
		EnterRule("methArgODecl", 25);
		TraceIn("methArgODecl", 25);
		Lang2Parser.methArgODecl_return retval = new Lang2Parser.methArgODecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID123=null;
		IToken char_literal125=null;
		IToken char_literal126=null;
		IToken ID127=null;
		Lang2Parser.type_return type122 = default(Lang2Parser.type_return);
		Lang2Parser.type_return type124 = default(Lang2Parser.type_return);

		object ID123_tree=null;
		object char_literal125_tree=null;
		object char_literal126_tree=null;
		object ID127_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "methArgODecl");
		DebugLocation(196, 4);
		try
		{
			// Lang2.g:196:14: ( type ID -> ^( VAR_DECL type ID ) | type '[' ']' ID -> ^( ARR_DECL type ID ) )
			int alt15=2;
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if (((LA15_0>=TINT && LA15_0<=TVOID)))
			{
				int LA15_1 = input.LA(2);

				if ((LA15_1==ID))
				{
					alt15=1;
				}
				else if ((LA15_1==49))
				{
					alt15=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 15, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// Lang2.g:196:16: type ID
				{
				DebugLocation(196, 16);
				PushFollow(Follow._type_in_methArgODecl1253);
				type122=type();
				PopFollow();

				stream_type.Add(type122.Tree);
				DebugLocation(196, 21);
				ID123=(IToken)Match(input,ID,Follow._ID_in_methArgODecl1255);  
				stream_ID.Add(ID123);



				{
				// AST REWRITE
				// elements: type, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 196:24: -> ^( VAR_DECL type ID )
				{
					DebugLocation(196, 27);
					// Lang2.g:196:27: ^( VAR_DECL type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(196, 29);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

					DebugLocation(196, 38);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(196, 43);
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
				// Lang2.g:197:7: type '[' ']' ID
				{
				DebugLocation(197, 7);
				PushFollow(Follow._type_in_methArgODecl1273);
				type124=type();
				PopFollow();

				stream_type.Add(type124.Tree);
				DebugLocation(197, 11);
				char_literal125=(IToken)Match(input,49,Follow._49_in_methArgODecl1274);  
				stream_49.Add(char_literal125);

				DebugLocation(197, 14);
				char_literal126=(IToken)Match(input,50,Follow._50_in_methArgODecl1275);  
				stream_50.Add(char_literal126);

				DebugLocation(197, 18);
				ID127=(IToken)Match(input,ID,Follow._ID_in_methArgODecl1277);  
				stream_ID.Add(ID127);



				{
				// AST REWRITE
				// elements: ID, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 197:21: -> ^( ARR_DECL type ID )
				{
					DebugLocation(197, 24);
					// Lang2.g:197:24: ^( ARR_DECL type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(197, 26);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

					DebugLocation(197, 35);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(197, 40);
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
			TraceOut("methArgODecl", 25);
			LeaveRule("methArgODecl", 25);
			Leave_methArgODecl();
		}
		DebugLocation(198, 4);
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
	// Lang2.g:200:1: methDeclArgs : methArgODecl ( ',' methArgODecl )* ;
	[GrammarRule("methDeclArgs")]
	private Lang2Parser.methDeclArgs_return methDeclArgs()
	{
		Enter_methDeclArgs();
		EnterRule("methDeclArgs", 26);
		TraceIn("methDeclArgs", 26);
		Lang2Parser.methDeclArgs_return retval = new Lang2Parser.methDeclArgs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal129=null;
		Lang2Parser.methArgODecl_return methArgODecl128 = default(Lang2Parser.methArgODecl_return);
		Lang2Parser.methArgODecl_return methArgODecl130 = default(Lang2Parser.methArgODecl_return);

		object char_literal129_tree=null;

		try { DebugEnterRule(GrammarFileName, "methDeclArgs");
		DebugLocation(200, 4);
		try
		{
			// Lang2.g:200:14: ( methArgODecl ( ',' methArgODecl )* )
			DebugEnterAlt(1);
			// Lang2.g:200:16: methArgODecl ( ',' methArgODecl )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(200, 16);
			PushFollow(Follow._methArgODecl_in_methDeclArgs1300);
			methArgODecl128=methArgODecl();
			PopFollow();

			adaptor.AddChild(root_0, methArgODecl128.Tree);
			DebugLocation(200, 28);
			// Lang2.g:200:28: ( ',' methArgODecl )*
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0==55))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch ( alt16 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:200:29: ',' methArgODecl
					{
					DebugLocation(200, 32);
					char_literal129=(IToken)Match(input,55,Follow._55_in_methDeclArgs1302); 
					DebugLocation(200, 33);
					PushFollow(Follow._methArgODecl_in_methDeclArgs1304);
					methArgODecl130=methArgODecl();
					PopFollow();

					adaptor.AddChild(root_0, methArgODecl130.Tree);

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
			TraceOut("methDeclArgs", 26);
			LeaveRule("methDeclArgs", 26);
			Leave_methDeclArgs();
		}
		DebugLocation(201, 4);
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
	// Lang2.g:202:1: methDeclArgsW : ( methDeclArgs )? -> ^( DECL_ARGS ( methDeclArgs )? ) ;
	[GrammarRule("methDeclArgsW")]
	private Lang2Parser.methDeclArgsW_return methDeclArgsW()
	{
		Enter_methDeclArgsW();
		EnterRule("methDeclArgsW", 27);
		TraceIn("methDeclArgsW", 27);
		Lang2Parser.methDeclArgsW_return retval = new Lang2Parser.methDeclArgsW_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.methDeclArgs_return methDeclArgs131 = default(Lang2Parser.methDeclArgs_return);

		RewriteRuleSubtreeStream stream_methDeclArgs=new RewriteRuleSubtreeStream(adaptor,"rule methDeclArgs");
		try { DebugEnterRule(GrammarFileName, "methDeclArgsW");
		DebugLocation(202, 4);
		try
		{
			// Lang2.g:202:15: ( ( methDeclArgs )? -> ^( DECL_ARGS ( methDeclArgs )? ) )
			DebugEnterAlt(1);
			// Lang2.g:202:17: ( methDeclArgs )?
			{
			DebugLocation(202, 17);
			// Lang2.g:202:17: ( methDeclArgs )?
			int alt17=2;
			try { DebugEnterSubRule(17);
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if (((LA17_0>=TINT && LA17_0<=TVOID)))
			{
				alt17=1;
			}
			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:202:17: methDeclArgs
				{
				DebugLocation(202, 17);
				PushFollow(Follow._methDeclArgs_in_methDeclArgsW1318);
				methDeclArgs131=methDeclArgs();
				PopFollow();

				stream_methDeclArgs.Add(methDeclArgs131.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(17); }



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
			// 202:31: -> ^( DECL_ARGS ( methDeclArgs )? )
			{
				DebugLocation(202, 34);
				// Lang2.g:202:34: ^( DECL_ARGS ( methDeclArgs )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(202, 36);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECL_ARGS, "DECL_ARGS"), root_1);

				DebugLocation(202, 46);
				// Lang2.g:202:46: ( methDeclArgs )?
				if ( stream_methDeclArgs.HasNext )
				{
					DebugLocation(202, 46);
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
			TraceOut("methDeclArgsW", 27);
			LeaveRule("methDeclArgsW", 27);
			Leave_methDeclArgsW();
		}
		DebugLocation(203, 4);
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
	// Lang2.g:205:1: methRetType : ( type -> ^( RET_TYPE_SINGLE type ) | type '[' ']' -> ^( RET_TYPE_ARR type ) );
	[GrammarRule("methRetType")]
	private Lang2Parser.methRetType_return methRetType()
	{
		Enter_methRetType();
		EnterRule("methRetType", 28);
		TraceIn("methRetType", 28);
		Lang2Parser.methRetType_return retval = new Lang2Parser.methRetType_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal134=null;
		IToken char_literal135=null;
		Lang2Parser.type_return type132 = default(Lang2Parser.type_return);
		Lang2Parser.type_return type133 = default(Lang2Parser.type_return);

		object char_literal134_tree=null;
		object char_literal135_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "methRetType");
		DebugLocation(205, 3);
		try
		{
			// Lang2.g:205:13: ( type -> ^( RET_TYPE_SINGLE type ) | type '[' ']' -> ^( RET_TYPE_ARR type ) )
			int alt18=2;
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if (((LA18_0>=TINT && LA18_0<=TVOID)))
			{
				int LA18_1 = input.LA(2);

				if ((LA18_1==ID))
				{
					alt18=1;
				}
				else if ((LA18_1==49))
				{
					alt18=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 18, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 18, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:205:15: type
				{
				DebugLocation(205, 15);
				PushFollow(Follow._type_in_methRetType1341);
				type132=type();
				PopFollow();

				stream_type.Add(type132.Tree);


				{
				// AST REWRITE
				// elements: type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 205:20: -> ^( RET_TYPE_SINGLE type )
				{
					DebugLocation(205, 22);
					// Lang2.g:205:22: ^( RET_TYPE_SINGLE type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(205, 24);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RET_TYPE_SINGLE, "RET_TYPE_SINGLE"), root_1);

					DebugLocation(205, 40);
					adaptor.AddChild(root_1, stream_type.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:206:6: type '[' ']'
				{
				DebugLocation(206, 6);
				PushFollow(Follow._type_in_methRetType1355);
				type133=type();
				PopFollow();

				stream_type.Add(type133.Tree);
				DebugLocation(206, 10);
				char_literal134=(IToken)Match(input,49,Follow._49_in_methRetType1356);  
				stream_49.Add(char_literal134);

				DebugLocation(206, 13);
				char_literal135=(IToken)Match(input,50,Follow._50_in_methRetType1357);  
				stream_50.Add(char_literal135);



				{
				// AST REWRITE
				// elements: type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 206:17: -> ^( RET_TYPE_ARR type )
				{
					DebugLocation(206, 20);
					// Lang2.g:206:20: ^( RET_TYPE_ARR type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(206, 22);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RET_TYPE_ARR, "RET_TYPE_ARR"), root_1);

					DebugLocation(206, 35);
					adaptor.AddChild(root_1, stream_type.NextTree());

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
			TraceOut("methRetType", 28);
			LeaveRule("methRetType", 28);
			Leave_methRetType();
		}
		DebugLocation(207, 3);
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
	// Lang2.g:208:1: methDecl : methRetType ID '(' methDeclArgsW ')' '{' bodyExpr '}' -> ^( METH_DECL methRetType ID methDeclArgsW bodyExpr ) ;
	[GrammarRule("methDecl")]
	private Lang2Parser.methDecl_return methDecl()
	{
		Enter_methDecl();
		EnterRule("methDecl", 29);
		TraceIn("methDecl", 29);
		Lang2Parser.methDecl_return retval = new Lang2Parser.methDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID137=null;
		IToken char_literal138=null;
		IToken char_literal140=null;
		IToken char_literal141=null;
		IToken char_literal143=null;
		Lang2Parser.methRetType_return methRetType136 = default(Lang2Parser.methRetType_return);
		Lang2Parser.methDeclArgsW_return methDeclArgsW139 = default(Lang2Parser.methDeclArgsW_return);
		Lang2Parser.bodyExpr_return bodyExpr142 = default(Lang2Parser.bodyExpr_return);

		object ID137_tree=null;
		object char_literal138_tree=null;
		object char_literal140_tree=null;
		object char_literal141_tree=null;
		object char_literal143_tree=null;
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_54=new RewriteRuleITokenStream(adaptor,"token 54");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		RewriteRuleSubtreeStream stream_methDeclArgsW=new RewriteRuleSubtreeStream(adaptor,"rule methDeclArgsW");
		RewriteRuleSubtreeStream stream_methRetType=new RewriteRuleSubtreeStream(adaptor,"rule methRetType");
		try { DebugEnterRule(GrammarFileName, "methDecl");
		DebugLocation(208, 3);
		try
		{
			// Lang2.g:208:10: ( methRetType ID '(' methDeclArgsW ')' '{' bodyExpr '}' -> ^( METH_DECL methRetType ID methDeclArgsW bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:208:12: methRetType ID '(' methDeclArgsW ')' '{' bodyExpr '}'
			{
			DebugLocation(208, 12);
			PushFollow(Follow._methRetType_in_methDecl1376);
			methRetType136=methRetType();
			PopFollow();

			stream_methRetType.Add(methRetType136.Tree);
			DebugLocation(208, 24);
			ID137=(IToken)Match(input,ID,Follow._ID_in_methDecl1378);  
			stream_ID.Add(ID137);

			DebugLocation(208, 27);
			char_literal138=(IToken)Match(input,53,Follow._53_in_methDecl1380);  
			stream_53.Add(char_literal138);

			DebugLocation(208, 30);
			PushFollow(Follow._methDeclArgsW_in_methDecl1381);
			methDeclArgsW139=methDeclArgsW();
			PopFollow();

			stream_methDeclArgsW.Add(methDeclArgsW139.Tree);
			DebugLocation(208, 43);
			char_literal140=(IToken)Match(input,54,Follow._54_in_methDecl1382);  
			stream_54.Add(char_literal140);

			DebugLocation(208, 47);
			char_literal141=(IToken)Match(input,51,Follow._51_in_methDecl1384);  
			stream_51.Add(char_literal141);

			DebugLocation(208, 50);
			PushFollow(Follow._bodyExpr_in_methDecl1385);
			bodyExpr142=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr142.Tree);
			DebugLocation(208, 58);
			char_literal143=(IToken)Match(input,52,Follow._52_in_methDecl1386);  
			stream_52.Add(char_literal143);



			{
			// AST REWRITE
			// elements: bodyExpr, ID, methRetType, methDeclArgsW
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 208:63: -> ^( METH_DECL methRetType ID methDeclArgsW bodyExpr )
			{
				DebugLocation(208, 66);
				// Lang2.g:208:66: ^( METH_DECL methRetType ID methDeclArgsW bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(208, 68);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METH_DECL, "METH_DECL"), root_1);

				DebugLocation(208, 78);
				adaptor.AddChild(root_1, stream_methRetType.NextTree());
				DebugLocation(208, 90);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(208, 93);
				adaptor.AddChild(root_1, stream_methDeclArgsW.NextTree());
				DebugLocation(208, 107);
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
			TraceOut("methDecl", 29);
			LeaveRule("methDecl", 29);
			Leave_methDecl();
		}
		DebugLocation(209, 3);
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
	// Lang2.g:211:1: moreVarDecl : ID ( ',' ID )+ ;
	[GrammarRule("moreVarDecl")]
	private Lang2Parser.moreVarDecl_return moreVarDecl()
	{
		Enter_moreVarDecl();
		EnterRule("moreVarDecl", 30);
		TraceIn("moreVarDecl", 30);
		Lang2Parser.moreVarDecl_return retval = new Lang2Parser.moreVarDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID144=null;
		IToken char_literal145=null;
		IToken ID146=null;

		object ID144_tree=null;
		object char_literal145_tree=null;
		object ID146_tree=null;

		try { DebugEnterRule(GrammarFileName, "moreVarDecl");
		DebugLocation(211, 3);
		try
		{
			// Lang2.g:211:13: ( ID ( ',' ID )+ )
			DebugEnterAlt(1);
			// Lang2.g:211:15: ID ( ',' ID )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(211, 15);
			ID144=(IToken)Match(input,ID,Follow._ID_in_moreVarDecl1413); 
			ID144_tree = (object)adaptor.Create(ID144);
			adaptor.AddChild(root_0, ID144_tree);

			DebugLocation(211, 17);
			// Lang2.g:211:17: ( ',' ID )+
			int cnt19=0;
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==55))
				{
					alt19=1;
				}


				} finally { DebugExitDecision(19); }
				switch (alt19)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:211:18: ',' ID
					{
					DebugLocation(211, 21);
					char_literal145=(IToken)Match(input,55,Follow._55_in_moreVarDecl1415); 
					DebugLocation(211, 23);
					ID146=(IToken)Match(input,ID,Follow._ID_in_moreVarDecl1418); 
					ID146_tree = (object)adaptor.Create(ID146);
					adaptor.AddChild(root_0, ID146_tree);


					}
					break;

				default:
					if (cnt19 >= 1)
						goto loop19;

					EarlyExitException eee19 = new EarlyExitException( 19, input );
					DebugRecognitionException(eee19);
					throw eee19;
				}
				cnt19++;
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
			TraceOut("moreVarDecl", 30);
			LeaveRule("moreVarDecl", 30);
			Leave_moreVarDecl();
		}
		DebugLocation(212, 3);
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
	// Lang2.g:213:1: assW : ASS mathExpr -> ^( ASS mathExpr ) ;
	[GrammarRule("assW")]
	private Lang2Parser.assW_return assW()
	{
		Enter_assW();
		EnterRule("assW", 31);
		TraceIn("assW", 31);
		Lang2Parser.assW_return retval = new Lang2Parser.assW_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASS147=null;
		Lang2Parser.mathExpr_return mathExpr148 = default(Lang2Parser.mathExpr_return);

		object ASS147_tree=null;
		RewriteRuleITokenStream stream_ASS=new RewriteRuleITokenStream(adaptor,"token ASS");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		try { DebugEnterRule(GrammarFileName, "assW");
		DebugLocation(213, 2);
		try
		{
			// Lang2.g:213:6: ( ASS mathExpr -> ^( ASS mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:213:8: ASS mathExpr
			{
			DebugLocation(213, 11);
			ASS147=(IToken)Match(input,ASS,Follow._ASS_in_assW1431);  
			stream_ASS.Add(ASS147);

			DebugLocation(213, 13);
			PushFollow(Follow._mathExpr_in_assW1434);
			mathExpr148=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr148.Tree);


			{
			// AST REWRITE
			// elements: ASS, mathExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 213:22: -> ^( ASS mathExpr )
			{
				DebugLocation(213, 24);
				// Lang2.g:213:24: ^( ASS mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(213, 26);
				root_1 = (object)adaptor.BecomeRoot(stream_ASS.NextNode(), root_1);

				DebugLocation(213, 30);
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
			TraceOut("assW", 31);
			LeaveRule("assW", 31);
			Leave_assW();
		}
		DebugLocation(214, 2);
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
	// Lang2.g:215:1: varDecl : ( type ID ( assW )? OP_END -> ^( VAR_DECL type ID ( assW )? ) | type moreVarDecl OP_END -> ^( VAR_DECL type moreVarDecl ) );
	[GrammarRule("varDecl")]
	private Lang2Parser.varDecl_return varDecl()
	{
		Enter_varDecl();
		EnterRule("varDecl", 32);
		TraceIn("varDecl", 32);
		Lang2Parser.varDecl_return retval = new Lang2Parser.varDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID150=null;
		IToken OP_END152=null;
		IToken OP_END155=null;
		Lang2Parser.type_return type149 = default(Lang2Parser.type_return);
		Lang2Parser.assW_return assW151 = default(Lang2Parser.assW_return);
		Lang2Parser.type_return type153 = default(Lang2Parser.type_return);
		Lang2Parser.moreVarDecl_return moreVarDecl154 = default(Lang2Parser.moreVarDecl_return);

		object ID150_tree=null;
		object OP_END152_tree=null;
		object OP_END155_tree=null;
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_moreVarDecl=new RewriteRuleSubtreeStream(adaptor,"rule moreVarDecl");
		RewriteRuleSubtreeStream stream_assW=new RewriteRuleSubtreeStream(adaptor,"rule assW");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "varDecl");
		DebugLocation(215, 2);
		try
		{
			// Lang2.g:215:9: ( type ID ( assW )? OP_END -> ^( VAR_DECL type ID ( assW )? ) | type moreVarDecl OP_END -> ^( VAR_DECL type moreVarDecl ) )
			int alt21=2;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if (((LA21_0>=TINT && LA21_0<=TVOID)))
			{
				int LA21_1 = input.LA(2);

				if ((LA21_1==ID))
				{
					int LA21_2 = input.LA(3);

					if ((LA21_2==OP_END||LA21_2==ASS))
					{
						alt21=1;
					}
					else if ((LA21_2==55))
					{
						alt21=2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 21, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 21, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:215:11: type ID ( assW )? OP_END
				{
				DebugLocation(215, 11);
				PushFollow(Follow._type_in_varDecl1451);
				type149=type();
				PopFollow();

				stream_type.Add(type149.Tree);
				DebugLocation(215, 16);
				ID150=(IToken)Match(input,ID,Follow._ID_in_varDecl1453);  
				stream_ID.Add(ID150);

				DebugLocation(215, 19);
				// Lang2.g:215:19: ( assW )?
				int alt20=2;
				try { DebugEnterSubRule(20);
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==ASS))
				{
					alt20=1;
				}
				} finally { DebugExitDecision(20); }
				switch (alt20)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:215:19: assW
					{
					DebugLocation(215, 19);
					PushFollow(Follow._assW_in_varDecl1455);
					assW151=assW();
					PopFollow();

					stream_assW.Add(assW151.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(20); }

				DebugLocation(215, 25);
				OP_END152=(IToken)Match(input,OP_END,Follow._OP_END_in_varDecl1458);  
				stream_OP_END.Add(OP_END152);



				{
				// AST REWRITE
				// elements: type, assW, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 215:32: -> ^( VAR_DECL type ID ( assW )? )
				{
					DebugLocation(215, 35);
					// Lang2.g:215:35: ^( VAR_DECL type ID ( assW )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(215, 37);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

					DebugLocation(215, 46);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(215, 51);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(215, 54);
					// Lang2.g:215:54: ( assW )?
					if ( stream_assW.HasNext )
					{
						DebugLocation(215, 54);
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
				// Lang2.g:216:6: type moreVarDecl OP_END
				{
				DebugLocation(216, 6);
				PushFollow(Follow._type_in_varDecl1478);
				type153=type();
				PopFollow();

				stream_type.Add(type153.Tree);
				DebugLocation(216, 11);
				PushFollow(Follow._moreVarDecl_in_varDecl1480);
				moreVarDecl154=moreVarDecl();
				PopFollow();

				stream_moreVarDecl.Add(moreVarDecl154.Tree);
				DebugLocation(216, 23);
				OP_END155=(IToken)Match(input,OP_END,Follow._OP_END_in_varDecl1482);  
				stream_OP_END.Add(OP_END155);



				{
				// AST REWRITE
				// elements: type, moreVarDecl
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 216:30: -> ^( VAR_DECL type moreVarDecl )
				{
					DebugLocation(216, 33);
					// Lang2.g:216:33: ^( VAR_DECL type moreVarDecl )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(216, 35);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

					DebugLocation(216, 44);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(216, 49);
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
			TraceOut("varDecl", 32);
			LeaveRule("varDecl", 32);
			Leave_varDecl();
		}
		DebugLocation(217, 2);
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
	// Lang2.g:219:1: bodyExpr : ( bodyFExpr )+ -> ^( BODY ( bodyFExpr )+ ) ;
	[GrammarRule("bodyExpr")]
	private Lang2Parser.bodyExpr_return bodyExpr()
	{
		Enter_bodyExpr();
		EnterRule("bodyExpr", 33);
		TraceIn("bodyExpr", 33);
		Lang2Parser.bodyExpr_return retval = new Lang2Parser.bodyExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.bodyFExpr_return bodyFExpr156 = default(Lang2Parser.bodyFExpr_return);

		RewriteRuleSubtreeStream stream_bodyFExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyFExpr");
		try { DebugEnterRule(GrammarFileName, "bodyExpr");
		DebugLocation(219, 3);
		try
		{
			// Lang2.g:219:10: ( ( bodyFExpr )+ -> ^( BODY ( bodyFExpr )+ ) )
			DebugEnterAlt(1);
			// Lang2.g:219:12: ( bodyFExpr )+
			{
			DebugLocation(219, 12);
			// Lang2.g:219:12: ( bodyFExpr )+
			int cnt22=0;
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==IF||(LA22_0>=FOR && LA22_0<=DO)||(LA22_0>=RETURN && LA22_0<=TVOID)||LA22_0==ID))
				{
					alt22=1;
				}


				} finally { DebugExitDecision(22); }
				switch (alt22)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:219:12: bodyFExpr
					{
					DebugLocation(219, 12);
					PushFollow(Follow._bodyFExpr_in_bodyExpr1503);
					bodyFExpr156=bodyFExpr();
					PopFollow();

					stream_bodyFExpr.Add(bodyFExpr156.Tree);

					}
					break;

				default:
					if (cnt22 >= 1)
						goto loop22;

					EarlyExitException eee22 = new EarlyExitException( 22, input );
					DebugRecognitionException(eee22);
					throw eee22;
				}
				cnt22++;
			}
			loop22:
				;

			} finally { DebugExitSubRule(22); }



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
			// 219:23: -> ^( BODY ( bodyFExpr )+ )
			{
				DebugLocation(219, 26);
				// Lang2.g:219:26: ^( BODY ( bodyFExpr )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(219, 28);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY, "BODY"), root_1);

				DebugLocation(219, 33);
				if ( !(stream_bodyFExpr.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_bodyFExpr.HasNext )
				{
					DebugLocation(219, 33);
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
			TraceOut("bodyExpr", 33);
			LeaveRule("bodyExpr", 33);
			Leave_bodyExpr();
		}
		DebugLocation(220, 3);
		} finally { DebugExitRule(GrammarFileName, "bodyExpr"); }
		return retval;

	}
	// $ANTLR end "bodyExpr"

	public class mainBody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mainBody();
	partial void Leave_mainBody();

	// $ANTLR start "mainBody"
	// Lang2.g:222:1: mainBody : ( methDecl | arrDecl | varDecl );
	[GrammarRule("mainBody")]
	private Lang2Parser.mainBody_return mainBody()
	{
		Enter_mainBody();
		EnterRule("mainBody", 34);
		TraceIn("mainBody", 34);
		Lang2Parser.mainBody_return retval = new Lang2Parser.mainBody_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.methDecl_return methDecl157 = default(Lang2Parser.methDecl_return);
		Lang2Parser.arrDecl_return arrDecl158 = default(Lang2Parser.arrDecl_return);
		Lang2Parser.varDecl_return varDecl159 = default(Lang2Parser.varDecl_return);


		try { DebugEnterRule(GrammarFileName, "mainBody");
		DebugLocation(222, 3);
		try
		{
			// Lang2.g:222:10: ( methDecl | arrDecl | varDecl )
			int alt23=3;
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if (((LA23_0>=TINT && LA23_0<=TVOID)))
			{
				int LA23_1 = input.LA(2);

				if ((LA23_1==ID))
				{
					switch (input.LA(3))
					{
					case 53:
						{
						alt23=1;
						}
						break;
					case 49:
						{
						alt23=2;
						}
						break;
					case OP_END:
					case ASS:
					case 55:
						{
						alt23=3;
						}
						break;
					default:
						{
							NoViableAltException nvae = new NoViableAltException("", 23, 2, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}

				}
				else if ((LA23_1==49))
				{
					alt23=1;
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
				// Lang2.g:222:12: methDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(222, 12);
				PushFollow(Follow._methDecl_in_mainBody1525);
				methDecl157=methDecl();
				PopFollow();

				adaptor.AddChild(root_0, methDecl157.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:222:21: arrDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(222, 21);
				PushFollow(Follow._arrDecl_in_mainBody1527);
				arrDecl158=arrDecl();
				PopFollow();

				adaptor.AddChild(root_0, arrDecl158.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:222:29: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(222, 29);
				PushFollow(Follow._varDecl_in_mainBody1529);
				varDecl159=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl159.Tree);

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
			TraceOut("mainBody", 34);
			LeaveRule("mainBody", 34);
			Leave_mainBody();
		}
		DebugLocation(223, 3);
		} finally { DebugExitRule(GrammarFileName, "mainBody"); }
		return retval;

	}
	// $ANTLR end "mainBody"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// Lang2.g:225:1: program : ( mainBody )+ -> ^( BODY ( mainBody )+ ) ;
	[GrammarRule("program")]
	private Lang2Parser.program_return program()
	{
		Enter_program();
		EnterRule("program", 35);
		TraceIn("program", 35);
		Lang2Parser.program_return retval = new Lang2Parser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.mainBody_return mainBody160 = default(Lang2Parser.mainBody_return);

		RewriteRuleSubtreeStream stream_mainBody=new RewriteRuleSubtreeStream(adaptor,"rule mainBody");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(225, 3);
		try
		{
			// Lang2.g:225:10: ( ( mainBody )+ -> ^( BODY ( mainBody )+ ) )
			DebugEnterAlt(1);
			// Lang2.g:225:12: ( mainBody )+
			{
			DebugLocation(225, 12);
			// Lang2.g:225:12: ( mainBody )+
			int cnt24=0;
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if (((LA24_0>=TINT && LA24_0<=TVOID)))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch (alt24)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:225:12: mainBody
					{
					DebugLocation(225, 12);
					PushFollow(Follow._mainBody_in_program1542);
					mainBody160=mainBody();
					PopFollow();

					stream_mainBody.Add(mainBody160.Tree);

					}
					break;

				default:
					if (cnt24 >= 1)
						goto loop24;

					EarlyExitException eee24 = new EarlyExitException( 24, input );
					DebugRecognitionException(eee24);
					throw eee24;
				}
				cnt24++;
			}
			loop24:
				;

			} finally { DebugExitSubRule(24); }



			{
			// AST REWRITE
			// elements: mainBody
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 225:22: -> ^( BODY ( mainBody )+ )
			{
				DebugLocation(225, 24);
				// Lang2.g:225:24: ^( BODY ( mainBody )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(225, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY, "BODY"), root_1);

				DebugLocation(225, 31);
				if ( !(stream_mainBody.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_mainBody.HasNext )
				{
					DebugLocation(225, 31);
					adaptor.AddChild(root_1, stream_mainBody.NextTree());

				}
				stream_mainBody.Reset();

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
			TraceOut("program", 35);
			LeaveRule("program", 35);
			Leave_program();
		}
		DebugLocation(226, 3);
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
	// Lang2.g:227:1: result : program EOF -> ^( PROGRAM program ) ;
	[GrammarRule("result")]
	private Lang2Parser.result_return result()
	{
		Enter_result();
		EnterRule("result", 36);
		TraceIn("result", 36);
		Lang2Parser.result_return retval = new Lang2Parser.result_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF162=null;
		Lang2Parser.program_return program161 = default(Lang2Parser.program_return);

		object EOF162_tree=null;
		RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
		RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(227, 41);
		try
		{
			// Lang2.g:227:7: ( program EOF -> ^( PROGRAM program ) )
			DebugEnterAlt(1);
			// Lang2.g:227:9: program EOF
			{
			DebugLocation(227, 9);
			PushFollow(Follow._program_in_result1561);
			program161=program();
			PopFollow();

			stream_program.Add(program161.Tree);
			DebugLocation(227, 17);
			EOF162=(IToken)Match(input,EOF,Follow._EOF_in_result1563);  
			stream_EOF.Add(EOF162);



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
			// 227:21: -> ^( PROGRAM program )
			{
				DebugLocation(227, 24);
				// Lang2.g:227:24: ^( PROGRAM program )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(227, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(227, 34);
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
			TraceOut("result", 36);
			LeaveRule("result", 36);
			Leave_result();
		}
		DebugLocation(227, 41);
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
	// Lang2.g:228:8: public execute : result ;
	[GrammarRule("execute")]
	public Lang2Parser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 37);
		TraceIn("execute", 37);
		Lang2Parser.execute_return retval = new Lang2Parser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.result_return result163 = default(Lang2Parser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(228, 23);
		try
		{
			// Lang2.g:228:15: ( result )
			DebugEnterAlt(1);
			// Lang2.g:228:18: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(228, 18);
			PushFollow(Follow._result_in_execute1580);
			result163=result();
			PopFollow();

			adaptor.AddChild(root_0, result163.Tree);

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
			TraceOut("execute", 37);
			LeaveRule("execute", 37);
			Leave_execute();
		}
		DebugLocation(228, 23);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"
	#endregion Rules


	#region DFA
	DFA2 dfa2;
	DFA6 dfa6;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa2 = new DFA2( this );
		dfa6 = new DFA6( this );
	}

	private class DFA2 : DFA
	{
		private const string DFA2_eotS =
			"\x10\xFFFF";
		private const string DFA2_eofS =
			"\x10\xFFFF";
		private const string DFA2_minS =
			"\x1\xA\x1\x30\x1\x23\x5\xFFFF\x1\x1D\x7\xFFFF";
		private const string DFA2_maxS =
			"\x2\x30\x1\x35\x5\xFFFF\x1\x37\x7\xFFFF";
		private const string DFA2_acceptS =
			"\x3\xFFFF\x1\x5\x1\x6\x1\x9\x1\xA\x1\xC\x1\xFFFF\x1\x2\x1\x3\x1\x7\x1"+
			"\x8\x1\xB\x1\x4\x1\x1";
		private const string DFA2_specialS =
			"\x10\xFFFF}>";
		private static readonly string[] DFA2_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x4\x1\x5\x1\x6\x6\xFFFF\x1\x7\x6\x1\x14\xFFFF\x1"+
				"\x2",
				"\x1\x8",
				"\x1\xB\x1\xC\x2\xFFFF\x1\x9\x9\xFFFF\x1\xD\x3\xFFFF\x1\xA",
				"",
				"",
				"",
				"",
				"",
				"\x1\xF\x9\xFFFF\x1\xF\x9\xFFFF\x1\xE\x5\xFFFF\x1\xF",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
		private static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
		private static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
		private static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
		private static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
		private static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
		private static readonly short[][] DFA2_transition;

		static DFA2()
		{
			int numStates = DFA2_transitionS.Length;
			DFA2_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA2_transition[i] = DFA.UnpackEncodedString(DFA2_transitionS[i]);
			}
		}

		public DFA2( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 2;
			this.eot = DFA2_eot;
			this.eof = DFA2_eof;
			this.min = DFA2_min;
			this.max = DFA2_max;
			this.accept = DFA2_accept;
			this.special = DFA2_special;
			this.transition = DFA2_transition;
		}

		public override string Description { get { return "121:1: bodyFExpr : ( varDecl | ID ASS mathExpr OP_END | methCall OP_END | arrDecl | ifExpr | forLoop | incSug OP_END | decSug OP_END | whileLoop | doLoop | arrCall ASS mathExpr OP_END | RETURN ( mathExpr )? OP_END );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA6 : DFA
	{
		private const string DFA6_eotS =
			"\xB\xFFFF";
		private const string DFA6_eofS =
			"\xB\xFFFF";
		private const string DFA6_minS =
			"\x1\x1E\x1\xFFFF\x1\x1D\x2\xFFFF\x2\x1E\x4\xFFFF";
		private const string DFA6_maxS =
			"\x1\x35\x1\xFFFF\x1\x37\x2\xFFFF\x2\x35\x4\xFFFF";
		private const string DFA6_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x4\x1\x3\x2\xFFFF\x1\x7\x1\x2\x1\x5\x1\x6";
		private const string DFA6_specialS =
			"\xB\xFFFF}>";
		private static readonly string[] DFA6_transitionS =
			{
				"\x4\x3\xE\xFFFF\x1\x2\x4\xFFFF\x1\x1",
				"",
				"\x1\x8\x5\xFFFF\x1\x5\x1\x6\x2\x8\x1\xFFFF\x5\x8\x1\xFFFF\x2\x8\x1"+
				"\xFFFF\x1\x7\x1\x8\x2\xFFFF\x1\x4\x2\x8",
				"",
				"",
				"\x4\x8\x1\xFFFF\x1\x9\xC\xFFFF\x1\x8\x4\xFFFF\x1\x8",
				"\x4\x8\x2\xFFFF\x1\xA\xB\xFFFF\x1\x8\x4\xFFFF\x1\x8",
				"",
				"",
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

		public override string Description { get { return "159:1: mathGroup : ( '(' mathExpr ')' | ID | methCall | literals | incSug | decSug | arrCall );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _set_in_type0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_arrDecl539 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _ID_in_arrDecl541 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_arrDecl542 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_arrDecl543 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_arrDecl544 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_arrDecl546 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrCall571 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_arrCall572 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_arrCall573 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_arrCall574 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_bodyFExpr597 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_bodyFExpr604 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ASS_in_bodyFExpr606 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_bodyFExpr609 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr611 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methCall_in_bodyFExpr619 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr621 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrDecl_in_bodyFExpr629 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifExpr_in_bodyFExpr636 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forLoop_in_bodyFExpr643 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _incSug_in_bodyFExpr650 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr652 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decSug_in_bodyFExpr660 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr662 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whileLoop_in_bodyFExpr670 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _doLoop_in_bodyFExpr677 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrCall_in_bodyFExpr684 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ASS_in_bodyFExpr686 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_bodyFExpr689 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr691 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_bodyFExpr699 = new BitSet(new ulong[]{0x212003E0000000UL});
		public static readonly BitSet _mathExpr_in_bodyFExpr702 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr705 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_elseExpr718 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_elseExpr720 = new BitSet(new ulong[]{0x212003CFE07400UL});
		public static readonly BitSet _bodyExpr_in_elseExpr721 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_elseExpr722 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifExpr741 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_ifExpr742 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_ifExpr744 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_ifExpr745 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_ifExpr747 = new BitSet(new ulong[]{0x212003CFE07400UL});
		public static readonly BitSet _bodyExpr_in_ifExpr748 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_ifExpr749 = new BitSet(new ulong[]{0x10000002UL});
		public static readonly BitSet _elseExpr_in_ifExpr751 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_varFor775 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_varFor781 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_iterFor791 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ASS_in_iterFor793 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_iterFor796 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathExpr_in_iterFor802 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forLoop812 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_forLoop814 = new BitSet(new ulong[]{0x100000FC00000UL});
		public static readonly BitSet _varFor_in_forLoop816 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_forLoop818 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_forLoop820 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_forLoop822 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _iterFor_in_forLoop824 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_forLoop826 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_forLoop828 = new BitSet(new ulong[]{0x212003CFE07400UL});
		public static readonly BitSet _bodyExpr_in_forLoop829 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_forLoop830 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_whileLoop854 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_whileLoop856 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_whileLoop857 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_whileLoop858 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_whileLoop860 = new BitSet(new ulong[]{0x212003CFE07400UL});
		public static readonly BitSet _bodyExpr_in_whileLoop861 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_whileLoop862 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_doLoop884 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_doLoop886 = new BitSet(new ulong[]{0x212003CFE07400UL});
		public static readonly BitSet _bodyExpr_in_doLoop887 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_doLoop888 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _WHILE_in_doLoop890 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_doLoop892 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_doLoop893 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_doLoop894 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_doLoop896 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_literals0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_incSug935 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ADD_in_incSug937 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ADD_in_incSug939 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_decSug957 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _SUB_in_decSug959 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _SUB_in_decSug961 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _53_in_mathGroup979 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_mathGroup982 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_mathGroup984 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_mathGroup992 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methCall_in_mathGroup999 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _literals_in_mathGroup1006 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _incSug_in_mathGroup1013 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decSug_in_mathGroup1020 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrCall_in_mathGroup1027 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathGroup_in_mathMult1042 = new BitSet(new ulong[]{0x6000000002UL});
		public static readonly BitSet _set_in_mathMult1044 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathGroup_in_mathMult1050 = new BitSet(new ulong[]{0x6000000002UL});
		public static readonly BitSet _mathMult_in_mathAdd1064 = new BitSet(new ulong[]{0x1800000002UL});
		public static readonly BitSet _set_in_mathAdd1066 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathMult_in_mathAdd1073 = new BitSet(new ulong[]{0x1800000002UL});
		public static readonly BitSet _mathAdd_in_mathConj1087 = new BitSet(new ulong[]{0x20000000002UL});
		public static readonly BitSet _CONJ_in_mathConj1089 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathAdd_in_mathConj1092 = new BitSet(new ulong[]{0x20000000002UL});
		public static readonly BitSet _mathConj_in_mathDisj1106 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _DISJ_in_mathDisj1108 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathConj_in_mathDisj1111 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _mathDisj_in_mathEq1126 = new BitSet(new ulong[]{0xDC0000000002UL});
		public static readonly BitSet _set_in_mathEq1128 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathDisj_in_mathEq1141 = new BitSet(new ulong[]{0xDC0000000002UL});
		public static readonly BitSet _INVERT_in_mathNeg1157 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathEq_in_mathNeg1160 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathEq_in_mathNeg1169 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathNeg_in_mathExpr1182 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathExpr_in_methArgs1197 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _55_in_methArgs1200 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_methArgs1202 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _ID_in_methCall1227 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_methCall1228 = new BitSet(new ulong[]{0x612003C0000000UL});
		public static readonly BitSet _methArgs_in_methCall1229 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_methCall1231 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_methArgODecl1253 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _ID_in_methArgODecl1255 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_methArgODecl1273 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_methArgODecl1274 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_methArgODecl1275 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _ID_in_methArgODecl1277 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methArgODecl_in_methDeclArgs1300 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _55_in_methDeclArgs1302 = new BitSet(new ulong[]{0xFC00000UL});
		public static readonly BitSet _methArgODecl_in_methDeclArgs1304 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _methDeclArgs_in_methDeclArgsW1318 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_methRetType1341 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_methRetType1355 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_methRetType1356 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_methRetType1357 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methRetType_in_methDecl1376 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _ID_in_methDecl1378 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_methDecl1380 = new BitSet(new ulong[]{0x4000000FC00000UL});
		public static readonly BitSet _methDeclArgsW_in_methDecl1381 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_methDecl1382 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_methDecl1384 = new BitSet(new ulong[]{0x212003CFE07400UL});
		public static readonly BitSet _bodyExpr_in_methDecl1385 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_methDecl1386 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_moreVarDecl1413 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_moreVarDecl1415 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _ID_in_moreVarDecl1418 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _ASS_in_assW1431 = new BitSet(new ulong[]{0x212003C0000000UL});
		public static readonly BitSet _mathExpr_in_assW1434 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_varDecl1451 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _ID_in_varDecl1453 = new BitSet(new ulong[]{0x8020000000UL});
		public static readonly BitSet _assW_in_varDecl1455 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_varDecl1458 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_varDecl1478 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _moreVarDecl_in_varDecl1480 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OP_END_in_varDecl1482 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bodyFExpr_in_bodyExpr1503 = new BitSet(new ulong[]{0x212003CFE07402UL});
		public static readonly BitSet _methDecl_in_mainBody1525 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrDecl_in_mainBody1527 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_mainBody1529 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mainBody_in_program1542 = new BitSet(new ulong[]{0xFC00002UL});
		public static readonly BitSet _program_in_result1561 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result1563 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute1580 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace Lang2
