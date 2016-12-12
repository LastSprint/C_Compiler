// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2016-12-13 00:01:55

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM", "VAR_DECL", "METH_CALL", "CALL_ARGS", "ARR_DECL", "ARR_CALL", "IF", "BODY", "FOR", "WHILE", "DO", "INC", "DEC", "METH_DECL", "DECL_ARGS", "RET_TYPE_SINGLE", "RET_TYPE_ARR", "RETURN", "TINT", "TFLOAT", "TSTRING", "TCHAR", "TBOOL", "TVOID", "OP_END", "INT", "DOUBLE", "CHAR", "STRING", "WS", "ADD", "SUB", "MULT", "DIV", "ASS", "DISJ", "CONJ", "IS_MORE", "IS_LESS", "IS_EQUALLY", "INVERT", "IS_LESS_OR_EQUAL", "IS_MORE_OR_EQUAL", "ID", "'['", "']'", "'('", "')'", "'{'", "'}'", "','"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false
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
	// Lang2.g:103:1: type : ( TINT | TFLOAT | TSTRING | TCHAR | TBOOL | TVOID );
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
		DebugLocation(103, 1);
		try
		{
			// Lang2.g:103:6: ( TINT | TFLOAT | TSTRING | TCHAR | TBOOL | TVOID )
			DebugEnterAlt(1);
			// Lang2.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 6);
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
		DebugLocation(109, 1);
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
	// Lang2.g:113:1: arrDecl : type ID '[' mathExpr ']' OP_END -> ^( ARR_DECL type ID mathExpr ) ;
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
		RewriteRuleITokenStream stream_48=new RewriteRuleITokenStream(adaptor,"token 48");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "arrDecl");
		DebugLocation(113, 3);
		try
		{
			// Lang2.g:113:10: ( type ID '[' mathExpr ']' OP_END -> ^( ARR_DECL type ID mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:113:12: type ID '[' mathExpr ']' OP_END
			{
			DebugLocation(113, 12);
			PushFollow(Follow._type_in_arrDecl531);
			type2=type();
			PopFollow();

			stream_type.Add(type2.Tree);
			DebugLocation(113, 17);
			ID3=(IToken)Match(input,ID,Follow._ID_in_arrDecl533);  
			stream_ID.Add(ID3);

			DebugLocation(113, 19);
			char_literal4=(IToken)Match(input,48,Follow._48_in_arrDecl534);  
			stream_48.Add(char_literal4);

			DebugLocation(113, 22);
			PushFollow(Follow._mathExpr_in_arrDecl535);
			mathExpr5=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr5.Tree);
			DebugLocation(113, 30);
			char_literal6=(IToken)Match(input,49,Follow._49_in_arrDecl536);  
			stream_49.Add(char_literal6);

			DebugLocation(113, 34);
			OP_END7=(IToken)Match(input,OP_END,Follow._OP_END_in_arrDecl538);  
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
			// 113:41: -> ^( ARR_DECL type ID mathExpr )
			{
				DebugLocation(113, 44);
				// Lang2.g:113:44: ^( ARR_DECL type ID mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(113, 46);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

				DebugLocation(113, 55);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(113, 60);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(113, 63);
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
		DebugLocation(114, 3);
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
	// Lang2.g:116:1: arrCall : ID '[' mathExpr ']' -> ^( ARR_CALL ID mathExpr ) ;
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
		RewriteRuleITokenStream stream_48=new RewriteRuleITokenStream(adaptor,"token 48");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		try { DebugEnterRule(GrammarFileName, "arrCall");
		DebugLocation(116, 3);
		try
		{
			// Lang2.g:116:10: ( ID '[' mathExpr ']' -> ^( ARR_CALL ID mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:116:12: ID '[' mathExpr ']'
			{
			DebugLocation(116, 12);
			ID8=(IToken)Match(input,ID,Follow._ID_in_arrCall563);  
			stream_ID.Add(ID8);

			DebugLocation(116, 14);
			char_literal9=(IToken)Match(input,48,Follow._48_in_arrCall564);  
			stream_48.Add(char_literal9);

			DebugLocation(116, 17);
			PushFollow(Follow._mathExpr_in_arrCall565);
			mathExpr10=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr10.Tree);
			DebugLocation(116, 25);
			char_literal11=(IToken)Match(input,49,Follow._49_in_arrCall566);  
			stream_49.Add(char_literal11);



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
			// 116:29: -> ^( ARR_CALL ID mathExpr )
			{
				DebugLocation(116, 32);
				// Lang2.g:116:32: ^( ARR_CALL ID mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(116, 34);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_CALL, "ARR_CALL"), root_1);

				DebugLocation(116, 43);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(116, 46);
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
		DebugLocation(117, 3);
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
	// Lang2.g:120:1: bodyFExpr : ( varDecl | ID ASS mathExpr OP_END | methCall OP_END | arrDecl | ifExpr | forLoop | incSug OP_END | decSug OP_END | whileLoop | doLoop | arrCall ASS mathExpr OP_END | RETURN ( mathExpr )? OP_END );
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
		DebugLocation(120, 4);
		try
		{
			// Lang2.g:120:11: ( varDecl | ID ASS mathExpr OP_END | methCall OP_END | arrDecl | ifExpr | forLoop | incSug OP_END | decSug OP_END | whileLoop | doLoop | arrCall ASS mathExpr OP_END | RETURN ( mathExpr )? OP_END )
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
				// Lang2.g:120:13: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(120, 13);
				PushFollow(Follow._varDecl_in_bodyFExpr589);
				varDecl12=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl12.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:121:6: ID ASS mathExpr OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(121, 6);
				ID13=(IToken)Match(input,ID,Follow._ID_in_bodyFExpr596); 
				ID13_tree = (object)adaptor.Create(ID13);
				adaptor.AddChild(root_0, ID13_tree);

				DebugLocation(121, 12);
				ASS14=(IToken)Match(input,ASS,Follow._ASS_in_bodyFExpr598); 
				ASS14_tree = (object)adaptor.Create(ASS14);
				root_0 = (object)adaptor.BecomeRoot(ASS14_tree, root_0);

				DebugLocation(121, 14);
				PushFollow(Follow._mathExpr_in_bodyFExpr601);
				mathExpr15=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr15.Tree);
				DebugLocation(121, 29);
				OP_END16=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr603); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:122:6: methCall OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(122, 6);
				PushFollow(Follow._methCall_in_bodyFExpr611);
				methCall17=methCall();
				PopFollow();

				adaptor.AddChild(root_0, methCall17.Tree);
				DebugLocation(122, 21);
				OP_END18=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr613); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Lang2.g:123:6: arrDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(123, 6);
				PushFollow(Follow._arrDecl_in_bodyFExpr621);
				arrDecl19=arrDecl();
				PopFollow();

				adaptor.AddChild(root_0, arrDecl19.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Lang2.g:124:6: ifExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(124, 6);
				PushFollow(Follow._ifExpr_in_bodyFExpr628);
				ifExpr20=ifExpr();
				PopFollow();

				adaptor.AddChild(root_0, ifExpr20.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Lang2.g:125:6: forLoop
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(125, 6);
				PushFollow(Follow._forLoop_in_bodyFExpr635);
				forLoop21=forLoop();
				PopFollow();

				adaptor.AddChild(root_0, forLoop21.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Lang2.g:126:6: incSug OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(126, 6);
				PushFollow(Follow._incSug_in_bodyFExpr642);
				incSug22=incSug();
				PopFollow();

				adaptor.AddChild(root_0, incSug22.Tree);
				DebugLocation(126, 19);
				OP_END23=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr644); 

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Lang2.g:127:6: decSug OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(127, 6);
				PushFollow(Follow._decSug_in_bodyFExpr652);
				decSug24=decSug();
				PopFollow();

				adaptor.AddChild(root_0, decSug24.Tree);
				DebugLocation(127, 19);
				OP_END25=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr654); 

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// Lang2.g:128:6: whileLoop
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(128, 6);
				PushFollow(Follow._whileLoop_in_bodyFExpr662);
				whileLoop26=whileLoop();
				PopFollow();

				adaptor.AddChild(root_0, whileLoop26.Tree);

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// Lang2.g:129:6: doLoop
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(129, 6);
				PushFollow(Follow._doLoop_in_bodyFExpr669);
				doLoop27=doLoop();
				PopFollow();

				adaptor.AddChild(root_0, doLoop27.Tree);

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// Lang2.g:130:6: arrCall ASS mathExpr OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(130, 6);
				PushFollow(Follow._arrCall_in_bodyFExpr676);
				arrCall28=arrCall();
				PopFollow();

				adaptor.AddChild(root_0, arrCall28.Tree);
				DebugLocation(130, 17);
				ASS29=(IToken)Match(input,ASS,Follow._ASS_in_bodyFExpr678); 
				ASS29_tree = (object)adaptor.Create(ASS29);
				root_0 = (object)adaptor.BecomeRoot(ASS29_tree, root_0);

				DebugLocation(130, 19);
				PushFollow(Follow._mathExpr_in_bodyFExpr681);
				mathExpr30=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr30.Tree);
				DebugLocation(130, 34);
				OP_END31=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr683); 

				}
				break;
			case 12:
				DebugEnterAlt(12);
				// Lang2.g:131:6: RETURN ( mathExpr )? OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(131, 12);
				RETURN32=(IToken)Match(input,RETURN,Follow._RETURN_in_bodyFExpr691); 
				RETURN32_tree = (object)adaptor.Create(RETURN32);
				root_0 = (object)adaptor.BecomeRoot(RETURN32_tree, root_0);

				DebugLocation(131, 14);
				// Lang2.g:131:14: ( mathExpr )?
				int alt1=2;
				try { DebugEnterSubRule(1);
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>=INT && LA1_0<=STRING)||LA1_0==INVERT||LA1_0==ID||LA1_0==50))
				{
					alt1=1;
				}
				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:131:14: mathExpr
					{
					DebugLocation(131, 14);
					PushFollow(Follow._mathExpr_in_bodyFExpr694);
					mathExpr33=mathExpr();
					PopFollow();

					adaptor.AddChild(root_0, mathExpr33.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(1); }

				DebugLocation(131, 30);
				OP_END34=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyFExpr697); 

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
		DebugLocation(132, 4);
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
	// Lang2.g:134:1: ifExpr : IF '(' mathExpr ')' '{' bodyExpr '}' -> ^( IF mathExpr bodyExpr ) ;
	[GrammarRule("ifExpr")]
	private Lang2Parser.ifExpr_return ifExpr()
	{
		Enter_ifExpr();
		EnterRule("ifExpr", 5);
		TraceIn("ifExpr", 5);
		Lang2Parser.ifExpr_return retval = new Lang2Parser.ifExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF35=null;
		IToken char_literal36=null;
		IToken char_literal38=null;
		IToken char_literal39=null;
		IToken char_literal41=null;
		Lang2Parser.mathExpr_return mathExpr37 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.bodyExpr_return bodyExpr40 = default(Lang2Parser.bodyExpr_return);

		object IF35_tree=null;
		object char_literal36_tree=null;
		object char_literal38_tree=null;
		object char_literal39_tree=null;
		object char_literal41_tree=null;
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "ifExpr");
		DebugLocation(134, 2);
		try
		{
			// Lang2.g:134:8: ( IF '(' mathExpr ')' '{' bodyExpr '}' -> ^( IF mathExpr bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:134:10: IF '(' mathExpr ')' '{' bodyExpr '}'
			{
			DebugLocation(134, 10);
			IF35=(IToken)Match(input,IF,Follow._IF_in_ifExpr711);  
			stream_IF.Add(IF35);

			DebugLocation(134, 12);
			char_literal36=(IToken)Match(input,50,Follow._50_in_ifExpr712);  
			stream_50.Add(char_literal36);

			DebugLocation(134, 16);
			PushFollow(Follow._mathExpr_in_ifExpr714);
			mathExpr37=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr37.Tree);
			DebugLocation(134, 24);
			char_literal38=(IToken)Match(input,51,Follow._51_in_ifExpr715);  
			stream_51.Add(char_literal38);

			DebugLocation(134, 28);
			char_literal39=(IToken)Match(input,52,Follow._52_in_ifExpr717);  
			stream_52.Add(char_literal39);

			DebugLocation(134, 31);
			PushFollow(Follow._bodyExpr_in_ifExpr718);
			bodyExpr40=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr40.Tree);
			DebugLocation(134, 39);
			char_literal41=(IToken)Match(input,53,Follow._53_in_ifExpr719);  
			stream_53.Add(char_literal41);



			{
			// AST REWRITE
			// elements: bodyExpr, IF, mathExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 134:43: -> ^( IF mathExpr bodyExpr )
			{
				DebugLocation(134, 46);
				// Lang2.g:134:46: ^( IF mathExpr bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(134, 48);
				root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

				DebugLocation(134, 51);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(134, 60);
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
			TraceOut("ifExpr", 5);
			LeaveRule("ifExpr", 5);
			Leave_ifExpr();
		}
		DebugLocation(135, 2);
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
	// Lang2.g:136:1: varFor : ( ID | varDecl );
	[GrammarRule("varFor")]
	private Lang2Parser.varFor_return varFor()
	{
		Enter_varFor();
		EnterRule("varFor", 6);
		TraceIn("varFor", 6);
		Lang2Parser.varFor_return retval = new Lang2Parser.varFor_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID42=null;
		Lang2Parser.varDecl_return varDecl43 = default(Lang2Parser.varDecl_return);

		object ID42_tree=null;

		try { DebugEnterRule(GrammarFileName, "varFor");
		DebugLocation(136, 2);
		try
		{
			// Lang2.g:136:8: ( ID | varDecl )
			int alt3=2;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0==ID))
			{
				alt3=1;
			}
			else if (((LA3_0>=TINT && LA3_0<=TVOID)))
			{
				alt3=2;
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
				// Lang2.g:136:10: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(136, 10);
				ID42=(IToken)Match(input,ID,Follow._ID_in_varFor740); 
				ID42_tree = (object)adaptor.Create(ID42);
				adaptor.AddChild(root_0, ID42_tree);


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:137:5: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(137, 5);
				PushFollow(Follow._varDecl_in_varFor746);
				varDecl43=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl43.Tree);

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
			TraceOut("varFor", 6);
			LeaveRule("varFor", 6);
			Leave_varFor();
		}
		DebugLocation(138, 2);
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
	// Lang2.g:139:1: iterFor : ( ID ASS mathExpr | mathExpr );
	[GrammarRule("iterFor")]
	private Lang2Parser.iterFor_return iterFor()
	{
		Enter_iterFor();
		EnterRule("iterFor", 7);
		TraceIn("iterFor", 7);
		Lang2Parser.iterFor_return retval = new Lang2Parser.iterFor_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID44=null;
		IToken ASS45=null;
		Lang2Parser.mathExpr_return mathExpr46 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.mathExpr_return mathExpr47 = default(Lang2Parser.mathExpr_return);

		object ID44_tree=null;
		object ASS45_tree=null;

		try { DebugEnterRule(GrammarFileName, "iterFor");
		DebugLocation(139, 2);
		try
		{
			// Lang2.g:139:9: ( ID ASS mathExpr | mathExpr )
			int alt4=2;
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			int LA4_0 = input.LA(1);

			if ((LA4_0==ID))
			{
				int LA4_1 = input.LA(2);

				if ((LA4_1==ASS))
				{
					alt4=1;
				}
				else if (((LA4_1>=ADD && LA4_1<=DIV)||(LA4_1>=DISJ && LA4_1<=IS_EQUALLY)||(LA4_1>=IS_LESS_OR_EQUAL && LA4_1<=IS_MORE_OR_EQUAL)||LA4_1==48||(LA4_1>=50 && LA4_1<=51)))
				{
					alt4=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 4, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if (((LA4_0>=INT && LA4_0<=STRING)||LA4_0==INVERT||LA4_0==50))
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
				// Lang2.g:139:11: ID ASS mathExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(139, 11);
				ID44=(IToken)Match(input,ID,Follow._ID_in_iterFor756); 
				ID44_tree = (object)adaptor.Create(ID44);
				adaptor.AddChild(root_0, ID44_tree);

				DebugLocation(139, 17);
				ASS45=(IToken)Match(input,ASS,Follow._ASS_in_iterFor758); 
				ASS45_tree = (object)adaptor.Create(ASS45);
				root_0 = (object)adaptor.BecomeRoot(ASS45_tree, root_0);

				DebugLocation(139, 19);
				PushFollow(Follow._mathExpr_in_iterFor761);
				mathExpr46=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr46.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:140:5: mathExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(140, 5);
				PushFollow(Follow._mathExpr_in_iterFor767);
				mathExpr47=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr47.Tree);

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
			TraceOut("iterFor", 7);
			LeaveRule("iterFor", 7);
			Leave_iterFor();
		}
		DebugLocation(141, 2);
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
	// Lang2.g:142:1: forLoop : FOR '(' varFor ';' mathExpr ';' iterFor ')' '{' bodyExpr '}' -> ^( FOR varFor mathExpr iterFor bodyExpr ) ;
	[GrammarRule("forLoop")]
	private Lang2Parser.forLoop_return forLoop()
	{
		Enter_forLoop();
		EnterRule("forLoop", 8);
		TraceIn("forLoop", 8);
		Lang2Parser.forLoop_return retval = new Lang2Parser.forLoop_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FOR48=null;
		IToken char_literal49=null;
		IToken char_literal51=null;
		IToken char_literal53=null;
		IToken char_literal55=null;
		IToken char_literal56=null;
		IToken char_literal58=null;
		Lang2Parser.varFor_return varFor50 = default(Lang2Parser.varFor_return);
		Lang2Parser.mathExpr_return mathExpr52 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.iterFor_return iterFor54 = default(Lang2Parser.iterFor_return);
		Lang2Parser.bodyExpr_return bodyExpr57 = default(Lang2Parser.bodyExpr_return);

		object FOR48_tree=null;
		object char_literal49_tree=null;
		object char_literal51_tree=null;
		object char_literal53_tree=null;
		object char_literal55_tree=null;
		object char_literal56_tree=null;
		object char_literal58_tree=null;
		RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_iterFor=new RewriteRuleSubtreeStream(adaptor,"rule iterFor");
		RewriteRuleSubtreeStream stream_varFor=new RewriteRuleSubtreeStream(adaptor,"rule varFor");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "forLoop");
		DebugLocation(142, 2);
		try
		{
			// Lang2.g:142:9: ( FOR '(' varFor ';' mathExpr ';' iterFor ')' '{' bodyExpr '}' -> ^( FOR varFor mathExpr iterFor bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:142:11: FOR '(' varFor ';' mathExpr ';' iterFor ')' '{' bodyExpr '}'
			{
			DebugLocation(142, 11);
			FOR48=(IToken)Match(input,FOR,Follow._FOR_in_forLoop777);  
			stream_FOR.Add(FOR48);

			DebugLocation(142, 15);
			char_literal49=(IToken)Match(input,50,Follow._50_in_forLoop779);  
			stream_50.Add(char_literal49);

			DebugLocation(142, 19);
			PushFollow(Follow._varFor_in_forLoop781);
			varFor50=varFor();
			PopFollow();

			stream_varFor.Add(varFor50.Tree);
			DebugLocation(142, 26);
			char_literal51=(IToken)Match(input,OP_END,Follow._OP_END_in_forLoop783);  
			stream_OP_END.Add(char_literal51);

			DebugLocation(142, 30);
			PushFollow(Follow._mathExpr_in_forLoop785);
			mathExpr52=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr52.Tree);
			DebugLocation(142, 39);
			char_literal53=(IToken)Match(input,OP_END,Follow._OP_END_in_forLoop787);  
			stream_OP_END.Add(char_literal53);

			DebugLocation(142, 43);
			PushFollow(Follow._iterFor_in_forLoop789);
			iterFor54=iterFor();
			PopFollow();

			stream_iterFor.Add(iterFor54.Tree);
			DebugLocation(142, 51);
			char_literal55=(IToken)Match(input,51,Follow._51_in_forLoop791);  
			stream_51.Add(char_literal55);

			DebugLocation(142, 55);
			char_literal56=(IToken)Match(input,52,Follow._52_in_forLoop793);  
			stream_52.Add(char_literal56);

			DebugLocation(142, 58);
			PushFollow(Follow._bodyExpr_in_forLoop794);
			bodyExpr57=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr57.Tree);
			DebugLocation(142, 66);
			char_literal58=(IToken)Match(input,53,Follow._53_in_forLoop795);  
			stream_53.Add(char_literal58);



			{
			// AST REWRITE
			// elements: varFor, bodyExpr, iterFor, mathExpr, FOR
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 142:70: -> ^( FOR varFor mathExpr iterFor bodyExpr )
			{
				DebugLocation(142, 73);
				// Lang2.g:142:73: ^( FOR varFor mathExpr iterFor bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(142, 75);
				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

				DebugLocation(142, 79);
				adaptor.AddChild(root_1, stream_varFor.NextTree());
				DebugLocation(142, 86);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(142, 95);
				adaptor.AddChild(root_1, stream_iterFor.NextTree());
				DebugLocation(142, 103);
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
			TraceOut("forLoop", 8);
			LeaveRule("forLoop", 8);
			Leave_forLoop();
		}
		DebugLocation(143, 2);
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
	// Lang2.g:144:1: whileLoop : WHILE '(' mathExpr ')' '{' bodyExpr '}' -> ^( WHILE mathExpr bodyExpr ) ;
	[GrammarRule("whileLoop")]
	private Lang2Parser.whileLoop_return whileLoop()
	{
		Enter_whileLoop();
		EnterRule("whileLoop", 9);
		TraceIn("whileLoop", 9);
		Lang2Parser.whileLoop_return retval = new Lang2Parser.whileLoop_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE59=null;
		IToken char_literal60=null;
		IToken char_literal62=null;
		IToken char_literal63=null;
		IToken char_literal65=null;
		Lang2Parser.mathExpr_return mathExpr61 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.bodyExpr_return bodyExpr64 = default(Lang2Parser.bodyExpr_return);

		object WHILE59_tree=null;
		object char_literal60_tree=null;
		object char_literal62_tree=null;
		object char_literal63_tree=null;
		object char_literal65_tree=null;
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "whileLoop");
		DebugLocation(144, 3);
		try
		{
			// Lang2.g:144:11: ( WHILE '(' mathExpr ')' '{' bodyExpr '}' -> ^( WHILE mathExpr bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:144:13: WHILE '(' mathExpr ')' '{' bodyExpr '}'
			{
			DebugLocation(144, 13);
			WHILE59=(IToken)Match(input,WHILE,Follow._WHILE_in_whileLoop819);  
			stream_WHILE.Add(WHILE59);

			DebugLocation(144, 19);
			char_literal60=(IToken)Match(input,50,Follow._50_in_whileLoop821);  
			stream_50.Add(char_literal60);

			DebugLocation(144, 22);
			PushFollow(Follow._mathExpr_in_whileLoop822);
			mathExpr61=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr61.Tree);
			DebugLocation(144, 30);
			char_literal62=(IToken)Match(input,51,Follow._51_in_whileLoop823);  
			stream_51.Add(char_literal62);

			DebugLocation(144, 34);
			char_literal63=(IToken)Match(input,52,Follow._52_in_whileLoop825);  
			stream_52.Add(char_literal63);

			DebugLocation(144, 37);
			PushFollow(Follow._bodyExpr_in_whileLoop826);
			bodyExpr64=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr64.Tree);
			DebugLocation(144, 45);
			char_literal65=(IToken)Match(input,53,Follow._53_in_whileLoop827);  
			stream_53.Add(char_literal65);



			{
			// AST REWRITE
			// elements: bodyExpr, WHILE, mathExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 144:49: -> ^( WHILE mathExpr bodyExpr )
			{
				DebugLocation(144, 52);
				// Lang2.g:144:52: ^( WHILE mathExpr bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(144, 54);
				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

				DebugLocation(144, 60);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(144, 69);
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
			TraceOut("whileLoop", 9);
			LeaveRule("whileLoop", 9);
			Leave_whileLoop();
		}
		DebugLocation(145, 3);
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
	// Lang2.g:146:1: doLoop : DO '{' bodyExpr '}' '(' mathExpr ')' OP_END -> ^( DO bodyExpr mathExpr ) ;
	[GrammarRule("doLoop")]
	private Lang2Parser.doLoop_return doLoop()
	{
		Enter_doLoop();
		EnterRule("doLoop", 10);
		TraceIn("doLoop", 10);
		Lang2Parser.doLoop_return retval = new Lang2Parser.doLoop_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DO66=null;
		IToken char_literal67=null;
		IToken char_literal69=null;
		IToken char_literal70=null;
		IToken char_literal72=null;
		IToken OP_END73=null;
		Lang2Parser.bodyExpr_return bodyExpr68 = default(Lang2Parser.bodyExpr_return);
		Lang2Parser.mathExpr_return mathExpr71 = default(Lang2Parser.mathExpr_return);

		object DO66_tree=null;
		object char_literal67_tree=null;
		object char_literal69_tree=null;
		object char_literal70_tree=null;
		object char_literal72_tree=null;
		object OP_END73_tree=null;
		RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		try { DebugEnterRule(GrammarFileName, "doLoop");
		DebugLocation(146, 3);
		try
		{
			// Lang2.g:146:9: ( DO '{' bodyExpr '}' '(' mathExpr ')' OP_END -> ^( DO bodyExpr mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:146:11: DO '{' bodyExpr '}' '(' mathExpr ')' OP_END
			{
			DebugLocation(146, 11);
			DO66=(IToken)Match(input,DO,Follow._DO_in_doLoop849);  
			stream_DO.Add(DO66);

			DebugLocation(146, 14);
			char_literal67=(IToken)Match(input,52,Follow._52_in_doLoop851);  
			stream_52.Add(char_literal67);

			DebugLocation(146, 17);
			PushFollow(Follow._bodyExpr_in_doLoop852);
			bodyExpr68=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr68.Tree);
			DebugLocation(146, 25);
			char_literal69=(IToken)Match(input,53,Follow._53_in_doLoop853);  
			stream_53.Add(char_literal69);

			DebugLocation(146, 29);
			char_literal70=(IToken)Match(input,50,Follow._50_in_doLoop855);  
			stream_50.Add(char_literal70);

			DebugLocation(146, 32);
			PushFollow(Follow._mathExpr_in_doLoop856);
			mathExpr71=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr71.Tree);
			DebugLocation(146, 40);
			char_literal72=(IToken)Match(input,51,Follow._51_in_doLoop857);  
			stream_51.Add(char_literal72);

			DebugLocation(146, 44);
			OP_END73=(IToken)Match(input,OP_END,Follow._OP_END_in_doLoop859);  
			stream_OP_END.Add(OP_END73);



			{
			// AST REWRITE
			// elements: mathExpr, bodyExpr, DO
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 146:51: -> ^( DO bodyExpr mathExpr )
			{
				DebugLocation(146, 54);
				// Lang2.g:146:54: ^( DO bodyExpr mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(146, 56);
				root_1 = (object)adaptor.BecomeRoot(stream_DO.NextNode(), root_1);

				DebugLocation(146, 59);
				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());
				DebugLocation(146, 68);
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
			TraceOut("doLoop", 10);
			LeaveRule("doLoop", 10);
			Leave_doLoop();
		}
		DebugLocation(147, 3);
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
	// Lang2.g:149:1: literals : ( INT | STRING | CHAR | DOUBLE );
	[GrammarRule("literals")]
	private Lang2Parser.literals_return literals()
	{
		Enter_literals();
		EnterRule("literals", 11);
		TraceIn("literals", 11);
		Lang2Parser.literals_return retval = new Lang2Parser.literals_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set74=null;

		object set74_tree=null;

		try { DebugEnterRule(GrammarFileName, "literals");
		DebugLocation(149, 3);
		try
		{
			// Lang2.g:149:10: ( INT | STRING | CHAR | DOUBLE )
			DebugEnterAlt(1);
			// Lang2.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(149, 10);
			set74=(IToken)input.LT(1);
			if ((input.LA(1)>=INT && input.LA(1)<=STRING))
			{
				input.Consume();
				adaptor.AddChild(root_0, (object)adaptor.Create(set74));
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
			TraceOut("literals", 11);
			LeaveRule("literals", 11);
			Leave_literals();
		}
		DebugLocation(150, 3);
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
	// Lang2.g:151:1: incSug : ID ADD ADD -> ^( INC ID ) ;
	[GrammarRule("incSug")]
	private Lang2Parser.incSug_return incSug()
	{
		Enter_incSug();
		EnterRule("incSug", 12);
		TraceIn("incSug", 12);
		Lang2Parser.incSug_return retval = new Lang2Parser.incSug_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID75=null;
		IToken ADD76=null;
		IToken ADD77=null;

		object ID75_tree=null;
		object ADD76_tree=null;
		object ADD77_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ADD=new RewriteRuleITokenStream(adaptor,"token ADD");

		try { DebugEnterRule(GrammarFileName, "incSug");
		DebugLocation(151, 2);
		try
		{
			// Lang2.g:151:8: ( ID ADD ADD -> ^( INC ID ) )
			DebugEnterAlt(1);
			// Lang2.g:151:10: ID ADD ADD
			{
			DebugLocation(151, 10);
			ID75=(IToken)Match(input,ID,Follow._ID_in_incSug898);  
			stream_ID.Add(ID75);

			DebugLocation(151, 13);
			ADD76=(IToken)Match(input,ADD,Follow._ADD_in_incSug900);  
			stream_ADD.Add(ADD76);

			DebugLocation(151, 17);
			ADD77=(IToken)Match(input,ADD,Follow._ADD_in_incSug902);  
			stream_ADD.Add(ADD77);



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
			// 151:21: -> ^( INC ID )
			{
				DebugLocation(151, 24);
				// Lang2.g:151:24: ^( INC ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(151, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INC, "INC"), root_1);

				DebugLocation(151, 30);
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
			TraceOut("incSug", 12);
			LeaveRule("incSug", 12);
			Leave_incSug();
		}
		DebugLocation(152, 2);
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
	// Lang2.g:153:1: decSug : ID SUB SUB -> ^( DEC ID ) ;
	[GrammarRule("decSug")]
	private Lang2Parser.decSug_return decSug()
	{
		Enter_decSug();
		EnterRule("decSug", 13);
		TraceIn("decSug", 13);
		Lang2Parser.decSug_return retval = new Lang2Parser.decSug_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID78=null;
		IToken SUB79=null;
		IToken SUB80=null;

		object ID78_tree=null;
		object SUB79_tree=null;
		object SUB80_tree=null;
		RewriteRuleITokenStream stream_SUB=new RewriteRuleITokenStream(adaptor,"token SUB");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "decSug");
		DebugLocation(153, 2);
		try
		{
			// Lang2.g:153:8: ( ID SUB SUB -> ^( DEC ID ) )
			DebugEnterAlt(1);
			// Lang2.g:153:10: ID SUB SUB
			{
			DebugLocation(153, 10);
			ID78=(IToken)Match(input,ID,Follow._ID_in_decSug920);  
			stream_ID.Add(ID78);

			DebugLocation(153, 13);
			SUB79=(IToken)Match(input,SUB,Follow._SUB_in_decSug922);  
			stream_SUB.Add(SUB79);

			DebugLocation(153, 17);
			SUB80=(IToken)Match(input,SUB,Follow._SUB_in_decSug924);  
			stream_SUB.Add(SUB80);



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
			// 153:21: -> ^( DEC ID )
			{
				DebugLocation(153, 24);
				// Lang2.g:153:24: ^( DEC ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(153, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DEC, "DEC"), root_1);

				DebugLocation(153, 30);
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
			TraceOut("decSug", 13);
			LeaveRule("decSug", 13);
			Leave_decSug();
		}
		DebugLocation(154, 2);
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
	// Lang2.g:155:1: mathGroup : ( '(' mathExpr ')' | ID | methCall | literals | incSug | decSug | arrCall );
	[GrammarRule("mathGroup")]
	private Lang2Parser.mathGroup_return mathGroup()
	{
		Enter_mathGroup();
		EnterRule("mathGroup", 14);
		TraceIn("mathGroup", 14);
		Lang2Parser.mathGroup_return retval = new Lang2Parser.mathGroup_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal81=null;
		IToken char_literal83=null;
		IToken ID84=null;
		Lang2Parser.mathExpr_return mathExpr82 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.methCall_return methCall85 = default(Lang2Parser.methCall_return);
		Lang2Parser.literals_return literals86 = default(Lang2Parser.literals_return);
		Lang2Parser.incSug_return incSug87 = default(Lang2Parser.incSug_return);
		Lang2Parser.decSug_return decSug88 = default(Lang2Parser.decSug_return);
		Lang2Parser.arrCall_return arrCall89 = default(Lang2Parser.arrCall_return);

		object char_literal81_tree=null;
		object char_literal83_tree=null;
		object ID84_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathGroup");
		DebugLocation(155, 3);
		try
		{
			// Lang2.g:155:11: ( '(' mathExpr ')' | ID | methCall | literals | incSug | decSug | arrCall )
			int alt5=7;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			try
			{
				alt5 = dfa5.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:155:13: '(' mathExpr ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(155, 16);
				char_literal81=(IToken)Match(input,50,Follow._50_in_mathGroup942); 
				DebugLocation(155, 18);
				PushFollow(Follow._mathExpr_in_mathGroup945);
				mathExpr82=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr82.Tree);
				DebugLocation(155, 30);
				char_literal83=(IToken)Match(input,51,Follow._51_in_mathGroup947); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:156:6: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(156, 6);
				ID84=(IToken)Match(input,ID,Follow._ID_in_mathGroup955); 
				ID84_tree = (object)adaptor.Create(ID84);
				adaptor.AddChild(root_0, ID84_tree);


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:157:6: methCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(157, 6);
				PushFollow(Follow._methCall_in_mathGroup962);
				methCall85=methCall();
				PopFollow();

				adaptor.AddChild(root_0, methCall85.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Lang2.g:158:6: literals
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(158, 6);
				PushFollow(Follow._literals_in_mathGroup969);
				literals86=literals();
				PopFollow();

				adaptor.AddChild(root_0, literals86.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Lang2.g:159:6: incSug
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(159, 6);
				PushFollow(Follow._incSug_in_mathGroup976);
				incSug87=incSug();
				PopFollow();

				adaptor.AddChild(root_0, incSug87.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Lang2.g:160:6: decSug
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(160, 6);
				PushFollow(Follow._decSug_in_mathGroup983);
				decSug88=decSug();
				PopFollow();

				adaptor.AddChild(root_0, decSug88.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Lang2.g:161:6: arrCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(161, 6);
				PushFollow(Follow._arrCall_in_mathGroup990);
				arrCall89=arrCall();
				PopFollow();

				adaptor.AddChild(root_0, arrCall89.Tree);

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
			TraceOut("mathGroup", 14);
			LeaveRule("mathGroup", 14);
			Leave_mathGroup();
		}
		DebugLocation(162, 3);
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
	// Lang2.g:163:1: mathNeg : ( ( INVERT mathGroup ) | ( mathGroup ) );
	[GrammarRule("mathNeg")]
	private Lang2Parser.mathNeg_return mathNeg()
	{
		Enter_mathNeg();
		EnterRule("mathNeg", 15);
		TraceIn("mathNeg", 15);
		Lang2Parser.mathNeg_return retval = new Lang2Parser.mathNeg_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken INVERT90=null;
		Lang2Parser.mathGroup_return mathGroup91 = default(Lang2Parser.mathGroup_return);
		Lang2Parser.mathGroup_return mathGroup92 = default(Lang2Parser.mathGroup_return);

		object INVERT90_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathNeg");
		DebugLocation(163, 3);
		try
		{
			// Lang2.g:163:10: ( ( INVERT mathGroup ) | ( mathGroup ) )
			int alt6=2;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0==INVERT))
			{
				alt6=1;
			}
			else if (((LA6_0>=INT && LA6_0<=STRING)||LA6_0==ID||LA6_0==50))
			{
				alt6=2;
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
				// Lang2.g:163:12: ( INVERT mathGroup )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(163, 12);
				// Lang2.g:163:12: ( INVERT mathGroup )
				DebugEnterAlt(1);
				// Lang2.g:163:13: INVERT mathGroup
				{
				DebugLocation(163, 19);
				INVERT90=(IToken)Match(input,INVERT,Follow._INVERT_in_mathNeg1003); 
				INVERT90_tree = (object)adaptor.Create(INVERT90);
				root_0 = (object)adaptor.BecomeRoot(INVERT90_tree, root_0);

				DebugLocation(163, 21);
				PushFollow(Follow._mathGroup_in_mathNeg1006);
				mathGroup91=mathGroup();
				PopFollow();

				adaptor.AddChild(root_0, mathGroup91.Tree);

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:164:6: ( mathGroup )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(164, 6);
				// Lang2.g:164:6: ( mathGroup )
				DebugEnterAlt(1);
				// Lang2.g:164:7: mathGroup
				{
				DebugLocation(164, 7);
				PushFollow(Follow._mathGroup_in_mathNeg1015);
				mathGroup92=mathGroup();
				PopFollow();

				adaptor.AddChild(root_0, mathGroup92.Tree);

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
			TraceOut("mathNeg", 15);
			LeaveRule("mathNeg", 15);
			Leave_mathNeg();
		}
		DebugLocation(165, 3);
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
	// Lang2.g:166:1: mathConj : mathNeg ( CONJ mathNeg )* ;
	[GrammarRule("mathConj")]
	private Lang2Parser.mathConj_return mathConj()
	{
		Enter_mathConj();
		EnterRule("mathConj", 16);
		TraceIn("mathConj", 16);
		Lang2Parser.mathConj_return retval = new Lang2Parser.mathConj_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CONJ94=null;
		Lang2Parser.mathNeg_return mathNeg93 = default(Lang2Parser.mathNeg_return);
		Lang2Parser.mathNeg_return mathNeg95 = default(Lang2Parser.mathNeg_return);

		object CONJ94_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathConj");
		DebugLocation(166, 3);
		try
		{
			// Lang2.g:166:10: ( mathNeg ( CONJ mathNeg )* )
			DebugEnterAlt(1);
			// Lang2.g:166:12: mathNeg ( CONJ mathNeg )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(166, 12);
			PushFollow(Follow._mathNeg_in_mathConj1027);
			mathNeg93=mathNeg();
			PopFollow();

			adaptor.AddChild(root_0, mathNeg93.Tree);
			DebugLocation(166, 19);
			// Lang2.g:166:19: ( CONJ mathNeg )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0==CONJ))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:166:20: CONJ mathNeg
					{
					DebugLocation(166, 24);
					CONJ94=(IToken)Match(input,CONJ,Follow._CONJ_in_mathConj1029); 
					CONJ94_tree = (object)adaptor.Create(CONJ94);
					root_0 = (object)adaptor.BecomeRoot(CONJ94_tree, root_0);

					DebugLocation(166, 26);
					PushFollow(Follow._mathNeg_in_mathConj1032);
					mathNeg95=mathNeg();
					PopFollow();

					adaptor.AddChild(root_0, mathNeg95.Tree);

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
			TraceOut("mathConj", 16);
			LeaveRule("mathConj", 16);
			Leave_mathConj();
		}
		DebugLocation(167, 3);
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
	// Lang2.g:168:1: mathDisj : mathConj ( DISJ mathConj )* ;
	[GrammarRule("mathDisj")]
	private Lang2Parser.mathDisj_return mathDisj()
	{
		Enter_mathDisj();
		EnterRule("mathDisj", 17);
		TraceIn("mathDisj", 17);
		Lang2Parser.mathDisj_return retval = new Lang2Parser.mathDisj_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DISJ97=null;
		Lang2Parser.mathConj_return mathConj96 = default(Lang2Parser.mathConj_return);
		Lang2Parser.mathConj_return mathConj98 = default(Lang2Parser.mathConj_return);

		object DISJ97_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathDisj");
		DebugLocation(168, 3);
		try
		{
			// Lang2.g:168:10: ( mathConj ( DISJ mathConj )* )
			DebugEnterAlt(1);
			// Lang2.g:168:12: mathConj ( DISJ mathConj )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(168, 12);
			PushFollow(Follow._mathConj_in_mathDisj1045);
			mathConj96=mathConj();
			PopFollow();

			adaptor.AddChild(root_0, mathConj96.Tree);
			DebugLocation(168, 20);
			// Lang2.g:168:20: ( DISJ mathConj )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0==DISJ))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:168:21: DISJ mathConj
					{
					DebugLocation(168, 25);
					DISJ97=(IToken)Match(input,DISJ,Follow._DISJ_in_mathDisj1047); 
					DISJ97_tree = (object)adaptor.Create(DISJ97);
					root_0 = (object)adaptor.BecomeRoot(DISJ97_tree, root_0);

					DebugLocation(168, 27);
					PushFollow(Follow._mathConj_in_mathDisj1050);
					mathConj98=mathConj();
					PopFollow();

					adaptor.AddChild(root_0, mathConj98.Tree);

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
			TraceOut("mathDisj", 17);
			LeaveRule("mathDisj", 17);
			Leave_mathDisj();
		}
		DebugLocation(169, 3);
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
	// Lang2.g:170:1: mathEq : mathDisj ( ( IS_MORE | IS_LESS | IS_EQUALLY | IS_MORE_OR_EQUAL | IS_LESS_OR_EQUAL ) mathDisj )* ;
	[GrammarRule("mathEq")]
	private Lang2Parser.mathEq_return mathEq()
	{
		Enter_mathEq();
		EnterRule("mathEq", 18);
		TraceIn("mathEq", 18);
		Lang2Parser.mathEq_return retval = new Lang2Parser.mathEq_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set100=null;
		Lang2Parser.mathDisj_return mathDisj99 = default(Lang2Parser.mathDisj_return);
		Lang2Parser.mathDisj_return mathDisj101 = default(Lang2Parser.mathDisj_return);

		object set100_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathEq");
		DebugLocation(170, 3);
		try
		{
			// Lang2.g:170:9: ( mathDisj ( ( IS_MORE | IS_LESS | IS_EQUALLY | IS_MORE_OR_EQUAL | IS_LESS_OR_EQUAL ) mathDisj )* )
			DebugEnterAlt(1);
			// Lang2.g:170:11: mathDisj ( ( IS_MORE | IS_LESS | IS_EQUALLY | IS_MORE_OR_EQUAL | IS_LESS_OR_EQUAL ) mathDisj )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(170, 11);
			PushFollow(Follow._mathDisj_in_mathEq1064);
			mathDisj99=mathDisj();
			PopFollow();

			adaptor.AddChild(root_0, mathDisj99.Tree);
			DebugLocation(170, 19);
			// Lang2.g:170:19: ( ( IS_MORE | IS_LESS | IS_EQUALLY | IS_MORE_OR_EQUAL | IS_LESS_OR_EQUAL ) mathDisj )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if (((LA9_0>=IS_MORE && LA9_0<=IS_EQUALLY)||(LA9_0>=IS_LESS_OR_EQUAL && LA9_0<=IS_MORE_OR_EQUAL)))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:170:20: ( IS_MORE | IS_LESS | IS_EQUALLY | IS_MORE_OR_EQUAL | IS_LESS_OR_EQUAL ) mathDisj
					{
					DebugLocation(170, 20);
					set100=(IToken)input.LT(1);
					set100=(IToken)input.LT(1);
					if ((input.LA(1)>=IS_MORE && input.LA(1)<=IS_EQUALLY)||(input.LA(1)>=IS_LESS_OR_EQUAL && input.LA(1)<=IS_MORE_OR_EQUAL))
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

					DebugLocation(170, 84);
					PushFollow(Follow._mathDisj_in_mathEq1079);
					mathDisj101=mathDisj();
					PopFollow();

					adaptor.AddChild(root_0, mathDisj101.Tree);

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
			TraceOut("mathEq", 18);
			LeaveRule("mathEq", 18);
			Leave_mathEq();
		}
		DebugLocation(171, 3);
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
	// Lang2.g:172:1: mathMult : mathEq ( ( MULT | DIV ) mathEq )* ;
	[GrammarRule("mathMult")]
	private Lang2Parser.mathMult_return mathMult()
	{
		Enter_mathMult();
		EnterRule("mathMult", 19);
		TraceIn("mathMult", 19);
		Lang2Parser.mathMult_return retval = new Lang2Parser.mathMult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set103=null;
		Lang2Parser.mathEq_return mathEq102 = default(Lang2Parser.mathEq_return);
		Lang2Parser.mathEq_return mathEq104 = default(Lang2Parser.mathEq_return);

		object set103_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathMult");
		DebugLocation(172, 3);
		try
		{
			// Lang2.g:172:10: ( mathEq ( ( MULT | DIV ) mathEq )* )
			DebugEnterAlt(1);
			// Lang2.g:172:12: mathEq ( ( MULT | DIV ) mathEq )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(172, 12);
			PushFollow(Follow._mathEq_in_mathMult1092);
			mathEq102=mathEq();
			PopFollow();

			adaptor.AddChild(root_0, mathEq102.Tree);
			DebugLocation(172, 18);
			// Lang2.g:172:18: ( ( MULT | DIV ) mathEq )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if (((LA10_0>=MULT && LA10_0<=DIV)))
				{
					alt10=1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:172:19: ( MULT | DIV ) mathEq
					{
					DebugLocation(172, 19);
					set103=(IToken)input.LT(1);
					set103=(IToken)input.LT(1);
					if ((input.LA(1)>=MULT && input.LA(1)<=DIV))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set103), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(172, 30);
					PushFollow(Follow._mathEq_in_mathMult1100);
					mathEq104=mathEq();
					PopFollow();

					adaptor.AddChild(root_0, mathEq104.Tree);

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
			TraceOut("mathMult", 19);
			LeaveRule("mathMult", 19);
			Leave_mathMult();
		}
		DebugLocation(173, 3);
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
	// Lang2.g:174:1: mathAdd : mathMult ( ( ADD | SUB ) mathMult )* ;
	[GrammarRule("mathAdd")]
	private Lang2Parser.mathAdd_return mathAdd()
	{
		Enter_mathAdd();
		EnterRule("mathAdd", 20);
		TraceIn("mathAdd", 20);
		Lang2Parser.mathAdd_return retval = new Lang2Parser.mathAdd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set106=null;
		Lang2Parser.mathMult_return mathMult105 = default(Lang2Parser.mathMult_return);
		Lang2Parser.mathMult_return mathMult107 = default(Lang2Parser.mathMult_return);

		object set106_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathAdd");
		DebugLocation(174, 3);
		try
		{
			// Lang2.g:174:10: ( mathMult ( ( ADD | SUB ) mathMult )* )
			DebugEnterAlt(1);
			// Lang2.g:174:12: mathMult ( ( ADD | SUB ) mathMult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(174, 12);
			PushFollow(Follow._mathMult_in_mathAdd1114);
			mathMult105=mathMult();
			PopFollow();

			adaptor.AddChild(root_0, mathMult105.Tree);
			DebugLocation(174, 20);
			// Lang2.g:174:20: ( ( ADD | SUB ) mathMult )*
			try { DebugEnterSubRule(11);
			while (true)
			{
				int alt11=2;
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				int LA11_0 = input.LA(1);

				if (((LA11_0>=ADD && LA11_0<=SUB)))
				{
					alt11=1;
				}


				} finally { DebugExitDecision(11); }
				switch ( alt11 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:174:21: ( ADD | SUB ) mathMult
					{
					DebugLocation(174, 21);
					set106=(IToken)input.LT(1);
					set106=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set106), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(174, 32);
					PushFollow(Follow._mathMult_in_mathAdd1123);
					mathMult107=mathMult();
					PopFollow();

					adaptor.AddChild(root_0, mathMult107.Tree);

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
			TraceOut("mathAdd", 20);
			LeaveRule("mathAdd", 20);
			Leave_mathAdd();
		}
		DebugLocation(175, 3);
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
	// Lang2.g:176:1: mathExpr : mathAdd ;
	[GrammarRule("mathExpr")]
	private Lang2Parser.mathExpr_return mathExpr()
	{
		Enter_mathExpr();
		EnterRule("mathExpr", 21);
		TraceIn("mathExpr", 21);
		Lang2Parser.mathExpr_return retval = new Lang2Parser.mathExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.mathAdd_return mathAdd108 = default(Lang2Parser.mathAdd_return);


		try { DebugEnterRule(GrammarFileName, "mathExpr");
		DebugLocation(176, 3);
		try
		{
			// Lang2.g:176:10: ( mathAdd )
			DebugEnterAlt(1);
			// Lang2.g:176:12: mathAdd
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(176, 12);
			PushFollow(Follow._mathAdd_in_mathExpr1136);
			mathAdd108=mathAdd();
			PopFollow();

			adaptor.AddChild(root_0, mathAdd108.Tree);

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
			TraceOut("mathExpr", 21);
			LeaveRule("mathExpr", 21);
			Leave_mathExpr();
		}
		DebugLocation(177, 3);
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
	// Lang2.g:181:1: methArgs : mathExpr ( ',' mathExpr )* -> ^( CALL_ARGS mathExpr ( mathExpr )* ) ;
	[GrammarRule("methArgs")]
	private Lang2Parser.methArgs_return methArgs()
	{
		Enter_methArgs();
		EnterRule("methArgs", 22);
		TraceIn("methArgs", 22);
		Lang2Parser.methArgs_return retval = new Lang2Parser.methArgs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal110=null;
		Lang2Parser.mathExpr_return mathExpr109 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.mathExpr_return mathExpr111 = default(Lang2Parser.mathExpr_return);

		object char_literal110_tree=null;
		RewriteRuleITokenStream stream_54=new RewriteRuleITokenStream(adaptor,"token 54");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		try { DebugEnterRule(GrammarFileName, "methArgs");
		DebugLocation(181, 3);
		try
		{
			// Lang2.g:181:10: ( mathExpr ( ',' mathExpr )* -> ^( CALL_ARGS mathExpr ( mathExpr )* ) )
			DebugEnterAlt(1);
			// Lang2.g:181:12: mathExpr ( ',' mathExpr )*
			{
			DebugLocation(181, 12);
			PushFollow(Follow._mathExpr_in_methArgs1150);
			mathExpr109=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr109.Tree);
			DebugLocation(181, 21);
			// Lang2.g:181:21: ( ',' mathExpr )*
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0==54))
				{
					alt12=1;
				}


				} finally { DebugExitDecision(12); }
				switch ( alt12 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:181:22: ',' mathExpr
					{
					DebugLocation(181, 22);
					char_literal110=(IToken)Match(input,54,Follow._54_in_methArgs1153);  
					stream_54.Add(char_literal110);

					DebugLocation(181, 26);
					PushFollow(Follow._mathExpr_in_methArgs1155);
					mathExpr111=mathExpr();
					PopFollow();

					stream_mathExpr.Add(mathExpr111.Tree);

					}
					break;

				default:
					goto loop12;
				}
			}

			loop12:
				;

			} finally { DebugExitSubRule(12); }



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
			// 181:37: -> ^( CALL_ARGS mathExpr ( mathExpr )* )
			{
				DebugLocation(181, 40);
				// Lang2.g:181:40: ^( CALL_ARGS mathExpr ( mathExpr )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(181, 42);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL_ARGS, "CALL_ARGS"), root_1);

				DebugLocation(181, 52);
				adaptor.AddChild(root_1, stream_mathExpr.NextTree());
				DebugLocation(181, 61);
				// Lang2.g:181:61: ( mathExpr )*
				while ( stream_mathExpr.HasNext )
				{
					DebugLocation(181, 61);
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
			TraceOut("methArgs", 22);
			LeaveRule("methArgs", 22);
			Leave_methArgs();
		}
		DebugLocation(182, 3);
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
	// Lang2.g:183:1: methCall : ID '(' ( methArgs )? ')' -> ^( METH_CALL ID ( methArgs )? ) ;
	[GrammarRule("methCall")]
	private Lang2Parser.methCall_return methCall()
	{
		Enter_methCall();
		EnterRule("methCall", 23);
		TraceIn("methCall", 23);
		Lang2Parser.methCall_return retval = new Lang2Parser.methCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID112=null;
		IToken char_literal113=null;
		IToken char_literal115=null;
		Lang2Parser.methArgs_return methArgs114 = default(Lang2Parser.methArgs_return);

		object ID112_tree=null;
		object char_literal113_tree=null;
		object char_literal115_tree=null;
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_methArgs=new RewriteRuleSubtreeStream(adaptor,"rule methArgs");
		try { DebugEnterRule(GrammarFileName, "methCall");
		DebugLocation(183, 3);
		try
		{
			// Lang2.g:183:10: ( ID '(' ( methArgs )? ')' -> ^( METH_CALL ID ( methArgs )? ) )
			DebugEnterAlt(1);
			// Lang2.g:183:12: ID '(' ( methArgs )? ')'
			{
			DebugLocation(183, 12);
			ID112=(IToken)Match(input,ID,Follow._ID_in_methCall1180);  
			stream_ID.Add(ID112);

			DebugLocation(183, 14);
			char_literal113=(IToken)Match(input,50,Follow._50_in_methCall1181);  
			stream_50.Add(char_literal113);

			DebugLocation(183, 17);
			// Lang2.g:183:17: ( methArgs )?
			int alt13=2;
			try { DebugEnterSubRule(13);
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if (((LA13_0>=INT && LA13_0<=STRING)||LA13_0==INVERT||LA13_0==ID||LA13_0==50))
			{
				alt13=1;
			}
			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:183:17: methArgs
				{
				DebugLocation(183, 17);
				PushFollow(Follow._methArgs_in_methCall1182);
				methArgs114=methArgs();
				PopFollow();

				stream_methArgs.Add(methArgs114.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(13); }

			DebugLocation(183, 26);
			char_literal115=(IToken)Match(input,51,Follow._51_in_methCall1184);  
			stream_51.Add(char_literal115);



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
			// 183:30: -> ^( METH_CALL ID ( methArgs )? )
			{
				DebugLocation(183, 33);
				// Lang2.g:183:33: ^( METH_CALL ID ( methArgs )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(183, 35);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METH_CALL, "METH_CALL"), root_1);

				DebugLocation(183, 45);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(183, 48);
				// Lang2.g:183:48: ( methArgs )?
				if ( stream_methArgs.HasNext )
				{
					DebugLocation(183, 48);
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
			TraceOut("methCall", 23);
			LeaveRule("methCall", 23);
			Leave_methCall();
		}
		DebugLocation(184, 3);
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
	// Lang2.g:185:1: methArgODecl : ( type ID -> ^( VAR_DECL type ID ) | type '[' ']' ID -> ^( ARR_DECL type ID ) );
	[GrammarRule("methArgODecl")]
	private Lang2Parser.methArgODecl_return methArgODecl()
	{
		Enter_methArgODecl();
		EnterRule("methArgODecl", 24);
		TraceIn("methArgODecl", 24);
		Lang2Parser.methArgODecl_return retval = new Lang2Parser.methArgODecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID117=null;
		IToken char_literal119=null;
		IToken char_literal120=null;
		IToken ID121=null;
		Lang2Parser.type_return type116 = default(Lang2Parser.type_return);
		Lang2Parser.type_return type118 = default(Lang2Parser.type_return);

		object ID117_tree=null;
		object char_literal119_tree=null;
		object char_literal120_tree=null;
		object ID121_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_48=new RewriteRuleITokenStream(adaptor,"token 48");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "methArgODecl");
		DebugLocation(185, 4);
		try
		{
			// Lang2.g:185:14: ( type ID -> ^( VAR_DECL type ID ) | type '[' ']' ID -> ^( ARR_DECL type ID ) )
			int alt14=2;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if (((LA14_0>=TINT && LA14_0<=TVOID)))
			{
				int LA14_1 = input.LA(2);

				if ((LA14_1==ID))
				{
					alt14=1;
				}
				else if ((LA14_1==48))
				{
					alt14=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 14, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:185:16: type ID
				{
				DebugLocation(185, 16);
				PushFollow(Follow._type_in_methArgODecl1206);
				type116=type();
				PopFollow();

				stream_type.Add(type116.Tree);
				DebugLocation(185, 21);
				ID117=(IToken)Match(input,ID,Follow._ID_in_methArgODecl1208);  
				stream_ID.Add(ID117);



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
				// 185:24: -> ^( VAR_DECL type ID )
				{
					DebugLocation(185, 27);
					// Lang2.g:185:27: ^( VAR_DECL type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(185, 29);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

					DebugLocation(185, 38);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(185, 43);
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
				// Lang2.g:186:7: type '[' ']' ID
				{
				DebugLocation(186, 7);
				PushFollow(Follow._type_in_methArgODecl1226);
				type118=type();
				PopFollow();

				stream_type.Add(type118.Tree);
				DebugLocation(186, 11);
				char_literal119=(IToken)Match(input,48,Follow._48_in_methArgODecl1227);  
				stream_48.Add(char_literal119);

				DebugLocation(186, 14);
				char_literal120=(IToken)Match(input,49,Follow._49_in_methArgODecl1228);  
				stream_49.Add(char_literal120);

				DebugLocation(186, 18);
				ID121=(IToken)Match(input,ID,Follow._ID_in_methArgODecl1230);  
				stream_ID.Add(ID121);



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
				// 186:21: -> ^( ARR_DECL type ID )
				{
					DebugLocation(186, 24);
					// Lang2.g:186:24: ^( ARR_DECL type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(186, 26);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

					DebugLocation(186, 35);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(186, 40);
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
			TraceOut("methArgODecl", 24);
			LeaveRule("methArgODecl", 24);
			Leave_methArgODecl();
		}
		DebugLocation(187, 4);
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
	// Lang2.g:189:1: methDeclArgs : methArgODecl ( ',' methArgODecl )* ;
	[GrammarRule("methDeclArgs")]
	private Lang2Parser.methDeclArgs_return methDeclArgs()
	{
		Enter_methDeclArgs();
		EnterRule("methDeclArgs", 25);
		TraceIn("methDeclArgs", 25);
		Lang2Parser.methDeclArgs_return retval = new Lang2Parser.methDeclArgs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal123=null;
		Lang2Parser.methArgODecl_return methArgODecl122 = default(Lang2Parser.methArgODecl_return);
		Lang2Parser.methArgODecl_return methArgODecl124 = default(Lang2Parser.methArgODecl_return);

		object char_literal123_tree=null;

		try { DebugEnterRule(GrammarFileName, "methDeclArgs");
		DebugLocation(189, 4);
		try
		{
			// Lang2.g:189:14: ( methArgODecl ( ',' methArgODecl )* )
			DebugEnterAlt(1);
			// Lang2.g:189:16: methArgODecl ( ',' methArgODecl )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(189, 16);
			PushFollow(Follow._methArgODecl_in_methDeclArgs1253);
			methArgODecl122=methArgODecl();
			PopFollow();

			adaptor.AddChild(root_0, methArgODecl122.Tree);
			DebugLocation(189, 28);
			// Lang2.g:189:28: ( ',' methArgODecl )*
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==54))
				{
					alt15=1;
				}


				} finally { DebugExitDecision(15); }
				switch ( alt15 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:189:29: ',' methArgODecl
					{
					DebugLocation(189, 32);
					char_literal123=(IToken)Match(input,54,Follow._54_in_methDeclArgs1255); 
					DebugLocation(189, 33);
					PushFollow(Follow._methArgODecl_in_methDeclArgs1257);
					methArgODecl124=methArgODecl();
					PopFollow();

					adaptor.AddChild(root_0, methArgODecl124.Tree);

					}
					break;

				default:
					goto loop15;
				}
			}

			loop15:
				;

			} finally { DebugExitSubRule(15); }


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
			TraceOut("methDeclArgs", 25);
			LeaveRule("methDeclArgs", 25);
			Leave_methDeclArgs();
		}
		DebugLocation(190, 4);
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
	// Lang2.g:191:1: methDeclArgsW : ( methDeclArgs )? -> ^( DECL_ARGS ( methDeclArgs )? ) ;
	[GrammarRule("methDeclArgsW")]
	private Lang2Parser.methDeclArgsW_return methDeclArgsW()
	{
		Enter_methDeclArgsW();
		EnterRule("methDeclArgsW", 26);
		TraceIn("methDeclArgsW", 26);
		Lang2Parser.methDeclArgsW_return retval = new Lang2Parser.methDeclArgsW_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.methDeclArgs_return methDeclArgs125 = default(Lang2Parser.methDeclArgs_return);

		RewriteRuleSubtreeStream stream_methDeclArgs=new RewriteRuleSubtreeStream(adaptor,"rule methDeclArgs");
		try { DebugEnterRule(GrammarFileName, "methDeclArgsW");
		DebugLocation(191, 4);
		try
		{
			// Lang2.g:191:15: ( ( methDeclArgs )? -> ^( DECL_ARGS ( methDeclArgs )? ) )
			DebugEnterAlt(1);
			// Lang2.g:191:17: ( methDeclArgs )?
			{
			DebugLocation(191, 17);
			// Lang2.g:191:17: ( methDeclArgs )?
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if (((LA16_0>=TINT && LA16_0<=TVOID)))
			{
				alt16=1;
			}
			} finally { DebugExitDecision(16); }
			switch (alt16)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:191:17: methDeclArgs
				{
				DebugLocation(191, 17);
				PushFollow(Follow._methDeclArgs_in_methDeclArgsW1271);
				methDeclArgs125=methDeclArgs();
				PopFollow();

				stream_methDeclArgs.Add(methDeclArgs125.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(16); }



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
			// 191:31: -> ^( DECL_ARGS ( methDeclArgs )? )
			{
				DebugLocation(191, 34);
				// Lang2.g:191:34: ^( DECL_ARGS ( methDeclArgs )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(191, 36);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECL_ARGS, "DECL_ARGS"), root_1);

				DebugLocation(191, 46);
				// Lang2.g:191:46: ( methDeclArgs )?
				if ( stream_methDeclArgs.HasNext )
				{
					DebugLocation(191, 46);
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
			TraceOut("methDeclArgsW", 26);
			LeaveRule("methDeclArgsW", 26);
			Leave_methDeclArgsW();
		}
		DebugLocation(192, 4);
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
	// Lang2.g:194:1: methRetType : ( type -> ^( RET_TYPE_SINGLE type ) | type '[' ']' -> ^( RET_TYPE_ARR type ) );
	[GrammarRule("methRetType")]
	private Lang2Parser.methRetType_return methRetType()
	{
		Enter_methRetType();
		EnterRule("methRetType", 27);
		TraceIn("methRetType", 27);
		Lang2Parser.methRetType_return retval = new Lang2Parser.methRetType_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal128=null;
		IToken char_literal129=null;
		Lang2Parser.type_return type126 = default(Lang2Parser.type_return);
		Lang2Parser.type_return type127 = default(Lang2Parser.type_return);

		object char_literal128_tree=null;
		object char_literal129_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_48=new RewriteRuleITokenStream(adaptor,"token 48");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "methRetType");
		DebugLocation(194, 3);
		try
		{
			// Lang2.g:194:13: ( type -> ^( RET_TYPE_SINGLE type ) | type '[' ']' -> ^( RET_TYPE_ARR type ) )
			int alt17=2;
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if (((LA17_0>=TINT && LA17_0<=TVOID)))
			{
				int LA17_1 = input.LA(2);

				if ((LA17_1==ID))
				{
					alt17=1;
				}
				else if ((LA17_1==48))
				{
					alt17=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 17, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 17, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:194:15: type
				{
				DebugLocation(194, 15);
				PushFollow(Follow._type_in_methRetType1294);
				type126=type();
				PopFollow();

				stream_type.Add(type126.Tree);


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
				// 194:20: -> ^( RET_TYPE_SINGLE type )
				{
					DebugLocation(194, 22);
					// Lang2.g:194:22: ^( RET_TYPE_SINGLE type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(194, 24);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RET_TYPE_SINGLE, "RET_TYPE_SINGLE"), root_1);

					DebugLocation(194, 40);
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
				// Lang2.g:195:6: type '[' ']'
				{
				DebugLocation(195, 6);
				PushFollow(Follow._type_in_methRetType1308);
				type127=type();
				PopFollow();

				stream_type.Add(type127.Tree);
				DebugLocation(195, 10);
				char_literal128=(IToken)Match(input,48,Follow._48_in_methRetType1309);  
				stream_48.Add(char_literal128);

				DebugLocation(195, 13);
				char_literal129=(IToken)Match(input,49,Follow._49_in_methRetType1310);  
				stream_49.Add(char_literal129);



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
				// 195:17: -> ^( RET_TYPE_ARR type )
				{
					DebugLocation(195, 20);
					// Lang2.g:195:20: ^( RET_TYPE_ARR type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(195, 22);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RET_TYPE_ARR, "RET_TYPE_ARR"), root_1);

					DebugLocation(195, 35);
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
			TraceOut("methRetType", 27);
			LeaveRule("methRetType", 27);
			Leave_methRetType();
		}
		DebugLocation(196, 3);
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
	// Lang2.g:197:1: methDecl : methRetType ID '(' methDeclArgsW ')' '{' bodyExpr '}' -> ^( METH_DECL methRetType ID methDeclArgsW bodyExpr ) ;
	[GrammarRule("methDecl")]
	private Lang2Parser.methDecl_return methDecl()
	{
		Enter_methDecl();
		EnterRule("methDecl", 28);
		TraceIn("methDecl", 28);
		Lang2Parser.methDecl_return retval = new Lang2Parser.methDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID131=null;
		IToken char_literal132=null;
		IToken char_literal134=null;
		IToken char_literal135=null;
		IToken char_literal137=null;
		Lang2Parser.methRetType_return methRetType130 = default(Lang2Parser.methRetType_return);
		Lang2Parser.methDeclArgsW_return methDeclArgsW133 = default(Lang2Parser.methDeclArgsW_return);
		Lang2Parser.bodyExpr_return bodyExpr136 = default(Lang2Parser.bodyExpr_return);

		object ID131_tree=null;
		object char_literal132_tree=null;
		object char_literal134_tree=null;
		object char_literal135_tree=null;
		object char_literal137_tree=null;
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
		RewriteRuleSubtreeStream stream_methDeclArgsW=new RewriteRuleSubtreeStream(adaptor,"rule methDeclArgsW");
		RewriteRuleSubtreeStream stream_methRetType=new RewriteRuleSubtreeStream(adaptor,"rule methRetType");
		try { DebugEnterRule(GrammarFileName, "methDecl");
		DebugLocation(197, 3);
		try
		{
			// Lang2.g:197:10: ( methRetType ID '(' methDeclArgsW ')' '{' bodyExpr '}' -> ^( METH_DECL methRetType ID methDeclArgsW bodyExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:197:12: methRetType ID '(' methDeclArgsW ')' '{' bodyExpr '}'
			{
			DebugLocation(197, 12);
			PushFollow(Follow._methRetType_in_methDecl1329);
			methRetType130=methRetType();
			PopFollow();

			stream_methRetType.Add(methRetType130.Tree);
			DebugLocation(197, 24);
			ID131=(IToken)Match(input,ID,Follow._ID_in_methDecl1331);  
			stream_ID.Add(ID131);

			DebugLocation(197, 27);
			char_literal132=(IToken)Match(input,50,Follow._50_in_methDecl1333);  
			stream_50.Add(char_literal132);

			DebugLocation(197, 30);
			PushFollow(Follow._methDeclArgsW_in_methDecl1334);
			methDeclArgsW133=methDeclArgsW();
			PopFollow();

			stream_methDeclArgsW.Add(methDeclArgsW133.Tree);
			DebugLocation(197, 43);
			char_literal134=(IToken)Match(input,51,Follow._51_in_methDecl1335);  
			stream_51.Add(char_literal134);

			DebugLocation(197, 47);
			char_literal135=(IToken)Match(input,52,Follow._52_in_methDecl1337);  
			stream_52.Add(char_literal135);

			DebugLocation(197, 50);
			PushFollow(Follow._bodyExpr_in_methDecl1338);
			bodyExpr136=bodyExpr();
			PopFollow();

			stream_bodyExpr.Add(bodyExpr136.Tree);
			DebugLocation(197, 58);
			char_literal137=(IToken)Match(input,53,Follow._53_in_methDecl1339);  
			stream_53.Add(char_literal137);



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
			// 197:63: -> ^( METH_DECL methRetType ID methDeclArgsW bodyExpr )
			{
				DebugLocation(197, 66);
				// Lang2.g:197:66: ^( METH_DECL methRetType ID methDeclArgsW bodyExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(197, 68);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METH_DECL, "METH_DECL"), root_1);

				DebugLocation(197, 78);
				adaptor.AddChild(root_1, stream_methRetType.NextTree());
				DebugLocation(197, 90);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(197, 93);
				adaptor.AddChild(root_1, stream_methDeclArgsW.NextTree());
				DebugLocation(197, 107);
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
			TraceOut("methDecl", 28);
			LeaveRule("methDecl", 28);
			Leave_methDecl();
		}
		DebugLocation(198, 3);
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
	// Lang2.g:200:1: moreVarDecl : ID ( ',' ID )+ ;
	[GrammarRule("moreVarDecl")]
	private Lang2Parser.moreVarDecl_return moreVarDecl()
	{
		Enter_moreVarDecl();
		EnterRule("moreVarDecl", 29);
		TraceIn("moreVarDecl", 29);
		Lang2Parser.moreVarDecl_return retval = new Lang2Parser.moreVarDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID138=null;
		IToken char_literal139=null;
		IToken ID140=null;

		object ID138_tree=null;
		object char_literal139_tree=null;
		object ID140_tree=null;

		try { DebugEnterRule(GrammarFileName, "moreVarDecl");
		DebugLocation(200, 3);
		try
		{
			// Lang2.g:200:13: ( ID ( ',' ID )+ )
			DebugEnterAlt(1);
			// Lang2.g:200:15: ID ( ',' ID )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(200, 15);
			ID138=(IToken)Match(input,ID,Follow._ID_in_moreVarDecl1366); 
			ID138_tree = (object)adaptor.Create(ID138);
			adaptor.AddChild(root_0, ID138_tree);

			DebugLocation(200, 17);
			// Lang2.g:200:17: ( ',' ID )+
			int cnt18=0;
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=2;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if ((LA18_0==54))
				{
					alt18=1;
				}


				} finally { DebugExitDecision(18); }
				switch (alt18)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:200:18: ',' ID
					{
					DebugLocation(200, 21);
					char_literal139=(IToken)Match(input,54,Follow._54_in_moreVarDecl1368); 
					DebugLocation(200, 23);
					ID140=(IToken)Match(input,ID,Follow._ID_in_moreVarDecl1371); 
					ID140_tree = (object)adaptor.Create(ID140);
					adaptor.AddChild(root_0, ID140_tree);


					}
					break;

				default:
					if (cnt18 >= 1)
						goto loop18;

					EarlyExitException eee18 = new EarlyExitException( 18, input );
					DebugRecognitionException(eee18);
					throw eee18;
				}
				cnt18++;
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
			TraceOut("moreVarDecl", 29);
			LeaveRule("moreVarDecl", 29);
			Leave_moreVarDecl();
		}
		DebugLocation(201, 3);
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
	// Lang2.g:202:1: assW : ASS mathExpr -> ^( ASS mathExpr ) ;
	[GrammarRule("assW")]
	private Lang2Parser.assW_return assW()
	{
		Enter_assW();
		EnterRule("assW", 30);
		TraceIn("assW", 30);
		Lang2Parser.assW_return retval = new Lang2Parser.assW_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASS141=null;
		Lang2Parser.mathExpr_return mathExpr142 = default(Lang2Parser.mathExpr_return);

		object ASS141_tree=null;
		RewriteRuleITokenStream stream_ASS=new RewriteRuleITokenStream(adaptor,"token ASS");
		RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
		try { DebugEnterRule(GrammarFileName, "assW");
		DebugLocation(202, 2);
		try
		{
			// Lang2.g:202:6: ( ASS mathExpr -> ^( ASS mathExpr ) )
			DebugEnterAlt(1);
			// Lang2.g:202:8: ASS mathExpr
			{
			DebugLocation(202, 11);
			ASS141=(IToken)Match(input,ASS,Follow._ASS_in_assW1384);  
			stream_ASS.Add(ASS141);

			DebugLocation(202, 13);
			PushFollow(Follow._mathExpr_in_assW1387);
			mathExpr142=mathExpr();
			PopFollow();

			stream_mathExpr.Add(mathExpr142.Tree);


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
			// 202:22: -> ^( ASS mathExpr )
			{
				DebugLocation(202, 24);
				// Lang2.g:202:24: ^( ASS mathExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(202, 26);
				root_1 = (object)adaptor.BecomeRoot(stream_ASS.NextNode(), root_1);

				DebugLocation(202, 30);
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
			TraceOut("assW", 30);
			LeaveRule("assW", 30);
			Leave_assW();
		}
		DebugLocation(203, 2);
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
	// Lang2.g:204:1: varDecl : ( type ID ( assW )? OP_END -> ^( VAR_DECL type ID ( assW )? ) | type moreVarDecl OP_END -> ^( VAR_DECL type moreVarDecl ) );
	[GrammarRule("varDecl")]
	private Lang2Parser.varDecl_return varDecl()
	{
		Enter_varDecl();
		EnterRule("varDecl", 31);
		TraceIn("varDecl", 31);
		Lang2Parser.varDecl_return retval = new Lang2Parser.varDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID144=null;
		IToken OP_END146=null;
		IToken OP_END149=null;
		Lang2Parser.type_return type143 = default(Lang2Parser.type_return);
		Lang2Parser.assW_return assW145 = default(Lang2Parser.assW_return);
		Lang2Parser.type_return type147 = default(Lang2Parser.type_return);
		Lang2Parser.moreVarDecl_return moreVarDecl148 = default(Lang2Parser.moreVarDecl_return);

		object ID144_tree=null;
		object OP_END146_tree=null;
		object OP_END149_tree=null;
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_moreVarDecl=new RewriteRuleSubtreeStream(adaptor,"rule moreVarDecl");
		RewriteRuleSubtreeStream stream_assW=new RewriteRuleSubtreeStream(adaptor,"rule assW");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "varDecl");
		DebugLocation(204, 2);
		try
		{
			// Lang2.g:204:9: ( type ID ( assW )? OP_END -> ^( VAR_DECL type ID ( assW )? ) | type moreVarDecl OP_END -> ^( VAR_DECL type moreVarDecl ) )
			int alt20=2;
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if (((LA20_0>=TINT && LA20_0<=TVOID)))
			{
				int LA20_1 = input.LA(2);

				if ((LA20_1==ID))
				{
					int LA20_2 = input.LA(3);

					if ((LA20_2==OP_END||LA20_2==ASS))
					{
						alt20=1;
					}
					else if ((LA20_2==54))
					{
						alt20=2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 20, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 20, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 20, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:204:11: type ID ( assW )? OP_END
				{
				DebugLocation(204, 11);
				PushFollow(Follow._type_in_varDecl1404);
				type143=type();
				PopFollow();

				stream_type.Add(type143.Tree);
				DebugLocation(204, 16);
				ID144=(IToken)Match(input,ID,Follow._ID_in_varDecl1406);  
				stream_ID.Add(ID144);

				DebugLocation(204, 19);
				// Lang2.g:204:19: ( assW )?
				int alt19=2;
				try { DebugEnterSubRule(19);
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==ASS))
				{
					alt19=1;
				}
				} finally { DebugExitDecision(19); }
				switch (alt19)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:204:19: assW
					{
					DebugLocation(204, 19);
					PushFollow(Follow._assW_in_varDecl1408);
					assW145=assW();
					PopFollow();

					stream_assW.Add(assW145.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(19); }

				DebugLocation(204, 25);
				OP_END146=(IToken)Match(input,OP_END,Follow._OP_END_in_varDecl1411);  
				stream_OP_END.Add(OP_END146);



				{
				// AST REWRITE
				// elements: ID, type, assW
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 204:32: -> ^( VAR_DECL type ID ( assW )? )
				{
					DebugLocation(204, 35);
					// Lang2.g:204:35: ^( VAR_DECL type ID ( assW )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(204, 37);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

					DebugLocation(204, 46);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(204, 51);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(204, 54);
					// Lang2.g:204:54: ( assW )?
					if ( stream_assW.HasNext )
					{
						DebugLocation(204, 54);
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
				// Lang2.g:205:6: type moreVarDecl OP_END
				{
				DebugLocation(205, 6);
				PushFollow(Follow._type_in_varDecl1431);
				type147=type();
				PopFollow();

				stream_type.Add(type147.Tree);
				DebugLocation(205, 11);
				PushFollow(Follow._moreVarDecl_in_varDecl1433);
				moreVarDecl148=moreVarDecl();
				PopFollow();

				stream_moreVarDecl.Add(moreVarDecl148.Tree);
				DebugLocation(205, 23);
				OP_END149=(IToken)Match(input,OP_END,Follow._OP_END_in_varDecl1435);  
				stream_OP_END.Add(OP_END149);



				{
				// AST REWRITE
				// elements: moreVarDecl, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 205:30: -> ^( VAR_DECL type moreVarDecl )
				{
					DebugLocation(205, 33);
					// Lang2.g:205:33: ^( VAR_DECL type moreVarDecl )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(205, 35);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

					DebugLocation(205, 44);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(205, 49);
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
			TraceOut("varDecl", 31);
			LeaveRule("varDecl", 31);
			Leave_varDecl();
		}
		DebugLocation(206, 2);
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
	// Lang2.g:208:1: bodyExpr : ( bodyFExpr )+ -> ^( BODY ( bodyFExpr )+ ) ;
	[GrammarRule("bodyExpr")]
	private Lang2Parser.bodyExpr_return bodyExpr()
	{
		Enter_bodyExpr();
		EnterRule("bodyExpr", 32);
		TraceIn("bodyExpr", 32);
		Lang2Parser.bodyExpr_return retval = new Lang2Parser.bodyExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.bodyFExpr_return bodyFExpr150 = default(Lang2Parser.bodyFExpr_return);

		RewriteRuleSubtreeStream stream_bodyFExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyFExpr");
		try { DebugEnterRule(GrammarFileName, "bodyExpr");
		DebugLocation(208, 3);
		try
		{
			// Lang2.g:208:10: ( ( bodyFExpr )+ -> ^( BODY ( bodyFExpr )+ ) )
			DebugEnterAlt(1);
			// Lang2.g:208:12: ( bodyFExpr )+
			{
			DebugLocation(208, 12);
			// Lang2.g:208:12: ( bodyFExpr )+
			int cnt21=0;
			try { DebugEnterSubRule(21);
			while (true)
			{
				int alt21=2;
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if ((LA21_0==IF||(LA21_0>=FOR && LA21_0<=DO)||(LA21_0>=RETURN && LA21_0<=TVOID)||LA21_0==ID))
				{
					alt21=1;
				}


				} finally { DebugExitDecision(21); }
				switch (alt21)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:208:12: bodyFExpr
					{
					DebugLocation(208, 12);
					PushFollow(Follow._bodyFExpr_in_bodyExpr1456);
					bodyFExpr150=bodyFExpr();
					PopFollow();

					stream_bodyFExpr.Add(bodyFExpr150.Tree);

					}
					break;

				default:
					if (cnt21 >= 1)
						goto loop21;

					EarlyExitException eee21 = new EarlyExitException( 21, input );
					DebugRecognitionException(eee21);
					throw eee21;
				}
				cnt21++;
			}
			loop21:
				;

			} finally { DebugExitSubRule(21); }



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
			// 208:23: -> ^( BODY ( bodyFExpr )+ )
			{
				DebugLocation(208, 26);
				// Lang2.g:208:26: ^( BODY ( bodyFExpr )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(208, 28);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY, "BODY"), root_1);

				DebugLocation(208, 33);
				if ( !(stream_bodyFExpr.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_bodyFExpr.HasNext )
				{
					DebugLocation(208, 33);
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
			TraceOut("bodyExpr", 32);
			LeaveRule("bodyExpr", 32);
			Leave_bodyExpr();
		}
		DebugLocation(209, 3);
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
	// Lang2.g:211:1: mainBody : ( methDecl | arrDecl | varDecl );
	[GrammarRule("mainBody")]
	private Lang2Parser.mainBody_return mainBody()
	{
		Enter_mainBody();
		EnterRule("mainBody", 33);
		TraceIn("mainBody", 33);
		Lang2Parser.mainBody_return retval = new Lang2Parser.mainBody_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.methDecl_return methDecl151 = default(Lang2Parser.methDecl_return);
		Lang2Parser.arrDecl_return arrDecl152 = default(Lang2Parser.arrDecl_return);
		Lang2Parser.varDecl_return varDecl153 = default(Lang2Parser.varDecl_return);


		try { DebugEnterRule(GrammarFileName, "mainBody");
		DebugLocation(211, 3);
		try
		{
			// Lang2.g:211:10: ( methDecl | arrDecl | varDecl )
			int alt22=3;
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if (((LA22_0>=TINT && LA22_0<=TVOID)))
			{
				int LA22_1 = input.LA(2);

				if ((LA22_1==ID))
				{
					switch (input.LA(3))
					{
					case 50:
						{
						alt22=1;
						}
						break;
					case 48:
						{
						alt22=2;
						}
						break;
					case OP_END:
					case ASS:
					case 54:
						{
						alt22=3;
						}
						break;
					default:
						{
							NoViableAltException nvae = new NoViableAltException("", 22, 2, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}

				}
				else if ((LA22_1==48))
				{
					alt22=1;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 22, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 22, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:211:12: methDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(211, 12);
				PushFollow(Follow._methDecl_in_mainBody1478);
				methDecl151=methDecl();
				PopFollow();

				adaptor.AddChild(root_0, methDecl151.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:211:21: arrDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(211, 21);
				PushFollow(Follow._arrDecl_in_mainBody1480);
				arrDecl152=arrDecl();
				PopFollow();

				adaptor.AddChild(root_0, arrDecl152.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:211:29: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(211, 29);
				PushFollow(Follow._varDecl_in_mainBody1482);
				varDecl153=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl153.Tree);

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
			TraceOut("mainBody", 33);
			LeaveRule("mainBody", 33);
			Leave_mainBody();
		}
		DebugLocation(212, 3);
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
	// Lang2.g:214:1: program : ( mainBody )+ -> ^( BODY ( mainBody )+ ) ;
	[GrammarRule("program")]
	private Lang2Parser.program_return program()
	{
		Enter_program();
		EnterRule("program", 34);
		TraceIn("program", 34);
		Lang2Parser.program_return retval = new Lang2Parser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.mainBody_return mainBody154 = default(Lang2Parser.mainBody_return);

		RewriteRuleSubtreeStream stream_mainBody=new RewriteRuleSubtreeStream(adaptor,"rule mainBody");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(214, 3);
		try
		{
			// Lang2.g:214:10: ( ( mainBody )+ -> ^( BODY ( mainBody )+ ) )
			DebugEnterAlt(1);
			// Lang2.g:214:12: ( mainBody )+
			{
			DebugLocation(214, 12);
			// Lang2.g:214:12: ( mainBody )+
			int cnt23=0;
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if (((LA23_0>=TINT && LA23_0<=TVOID)))
				{
					alt23=1;
				}


				} finally { DebugExitDecision(23); }
				switch (alt23)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:214:12: mainBody
					{
					DebugLocation(214, 12);
					PushFollow(Follow._mainBody_in_program1495);
					mainBody154=mainBody();
					PopFollow();

					stream_mainBody.Add(mainBody154.Tree);

					}
					break;

				default:
					if (cnt23 >= 1)
						goto loop23;

					EarlyExitException eee23 = new EarlyExitException( 23, input );
					DebugRecognitionException(eee23);
					throw eee23;
				}
				cnt23++;
			}
			loop23:
				;

			} finally { DebugExitSubRule(23); }



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
			// 214:22: -> ^( BODY ( mainBody )+ )
			{
				DebugLocation(214, 24);
				// Lang2.g:214:24: ^( BODY ( mainBody )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(214, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY, "BODY"), root_1);

				DebugLocation(214, 31);
				if ( !(stream_mainBody.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_mainBody.HasNext )
				{
					DebugLocation(214, 31);
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
			TraceOut("program", 34);
			LeaveRule("program", 34);
			Leave_program();
		}
		DebugLocation(215, 3);
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
	// Lang2.g:216:1: result : program EOF -> ^( PROGRAM program ) ;
	[GrammarRule("result")]
	private Lang2Parser.result_return result()
	{
		Enter_result();
		EnterRule("result", 35);
		TraceIn("result", 35);
		Lang2Parser.result_return retval = new Lang2Parser.result_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF156=null;
		Lang2Parser.program_return program155 = default(Lang2Parser.program_return);

		object EOF156_tree=null;
		RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
		RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(216, 41);
		try
		{
			// Lang2.g:216:7: ( program EOF -> ^( PROGRAM program ) )
			DebugEnterAlt(1);
			// Lang2.g:216:9: program EOF
			{
			DebugLocation(216, 9);
			PushFollow(Follow._program_in_result1514);
			program155=program();
			PopFollow();

			stream_program.Add(program155.Tree);
			DebugLocation(216, 17);
			EOF156=(IToken)Match(input,EOF,Follow._EOF_in_result1516);  
			stream_EOF.Add(EOF156);



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
			// 216:21: -> ^( PROGRAM program )
			{
				DebugLocation(216, 24);
				// Lang2.g:216:24: ^( PROGRAM program )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(216, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(216, 34);
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
			TraceOut("result", 35);
			LeaveRule("result", 35);
			Leave_result();
		}
		DebugLocation(216, 41);
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
	// Lang2.g:217:8: public execute : result ;
	[GrammarRule("execute")]
	public Lang2Parser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 36);
		TraceIn("execute", 36);
		Lang2Parser.execute_return retval = new Lang2Parser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.result_return result157 = default(Lang2Parser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(217, 23);
		try
		{
			// Lang2.g:217:15: ( result )
			DebugEnterAlt(1);
			// Lang2.g:217:18: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(217, 18);
			PushFollow(Follow._result_in_execute1533);
			result157=result();
			PopFollow();

			adaptor.AddChild(root_0, result157.Tree);

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
			TraceOut("execute", 36);
			LeaveRule("execute", 36);
			Leave_execute();
		}
		DebugLocation(217, 23);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"
	#endregion Rules


	#region DFA
	DFA2 dfa2;
	DFA5 dfa5;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa2 = new DFA2( this );
		dfa5 = new DFA5( this );
	}

	private class DFA2 : DFA
	{
		private const string DFA2_eotS =
			"\x10\xFFFF";
		private const string DFA2_eofS =
			"\x10\xFFFF";
		private const string DFA2_minS =
			"\x1\xA\x1\x2F\x1\x22\x5\xFFFF\x1\x1C\x7\xFFFF";
		private const string DFA2_maxS =
			"\x2\x2F\x1\x32\x5\xFFFF\x1\x36\x7\xFFFF";
		private const string DFA2_acceptS =
			"\x3\xFFFF\x1\x5\x1\x6\x1\x9\x1\xA\x1\xC\x1\xFFFF\x1\x2\x1\x3\x1\x7\x1"+
			"\x8\x1\xB\x1\x4\x1\x1";
		private const string DFA2_specialS =
			"\x10\xFFFF}>";
		private static readonly string[] DFA2_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x4\x1\x5\x1\x6\x6\xFFFF\x1\x7\x6\x1\x13\xFFFF\x1"+
				"\x2",
				"\x1\x8",
				"\x1\xB\x1\xC\x2\xFFFF\x1\x9\x9\xFFFF\x1\xD\x1\xFFFF\x1\xA",
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

		public override string Description { get { return "120:1: bodyFExpr : ( varDecl | ID ASS mathExpr OP_END | methCall OP_END | arrDecl | ifExpr | forLoop | incSug OP_END | decSug OP_END | whileLoop | doLoop | arrCall ASS mathExpr OP_END | RETURN ( mathExpr )? OP_END );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA5 : DFA
	{
		private const string DFA5_eotS =
			"\xB\xFFFF";
		private const string DFA5_eofS =
			"\xB\xFFFF";
		private const string DFA5_minS =
			"\x1\x1D\x1\xFFFF\x1\x1C\x2\xFFFF\x2\x1D\x4\xFFFF";
		private const string DFA5_maxS =
			"\x1\x32\x1\xFFFF\x1\x36\x2\xFFFF\x2\x32\x4\xFFFF";
		private const string DFA5_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x4\x1\x3\x2\xFFFF\x1\x7\x1\x2\x1\x5\x1\x6";
		private const string DFA5_specialS =
			"\xB\xFFFF}>";
		private static readonly string[] DFA5_transitionS =
			{
				"\x4\x3\xE\xFFFF\x1\x2\x2\xFFFF\x1\x1",
				"",
				"\x1\x8\x5\xFFFF\x1\x5\x1\x6\x2\x8\x1\xFFFF\x5\x8\x1\xFFFF\x2\x8\x1"+
				"\xFFFF\x1\x7\x1\x8\x1\x4\x1\x8\x2\xFFFF\x1\x8",
				"",
				"",
				"\x4\x8\x1\xFFFF\x1\x9\x9\xFFFF\x1\x8\x2\xFFFF\x1\x8\x2\xFFFF\x1\x8",
				"\x4\x8\x2\xFFFF\x1\xA\x8\xFFFF\x1\x8\x2\xFFFF\x1\x8\x2\xFFFF\x1\x8",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
		private static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
		private static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
		private static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
		private static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
		private static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
		private static readonly short[][] DFA5_transition;

		static DFA5()
		{
			int numStates = DFA5_transitionS.Length;
			DFA5_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA5_transition[i] = DFA.UnpackEncodedString(DFA5_transitionS[i]);
			}
		}

		public DFA5( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 5;
			this.eot = DFA5_eot;
			this.eof = DFA5_eof;
			this.min = DFA5_min;
			this.max = DFA5_max;
			this.accept = DFA5_accept;
			this.special = DFA5_special;
			this.transition = DFA5_transition;
		}

		public override string Description { get { return "155:1: mathGroup : ( '(' mathExpr ')' | ID | methCall | literals | incSug | decSug | arrCall );"; } }

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
		public static readonly BitSet _type_in_arrDecl531 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _ID_in_arrDecl533 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_arrDecl534 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_arrDecl535 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_arrDecl536 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_arrDecl538 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrCall563 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_arrCall564 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_arrCall565 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_arrCall566 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_bodyFExpr589 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_bodyFExpr596 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _ASS_in_bodyFExpr598 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_bodyFExpr601 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr603 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methCall_in_bodyFExpr611 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr613 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrDecl_in_bodyFExpr621 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifExpr_in_bodyFExpr628 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forLoop_in_bodyFExpr635 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _incSug_in_bodyFExpr642 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr644 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decSug_in_bodyFExpr652 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr654 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whileLoop_in_bodyFExpr662 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _doLoop_in_bodyFExpr669 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrCall_in_bodyFExpr676 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _ASS_in_bodyFExpr678 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_bodyFExpr681 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr683 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_bodyFExpr691 = new BitSet(new ulong[]{0x49001F0000000UL});
		public static readonly BitSet _mathExpr_in_bodyFExpr694 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_bodyFExpr697 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifExpr711 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_ifExpr712 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_ifExpr714 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_ifExpr715 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_ifExpr717 = new BitSet(new ulong[]{0x49001EFE07400UL});
		public static readonly BitSet _bodyExpr_in_ifExpr718 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_ifExpr719 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_varFor740 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_varFor746 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_iterFor756 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _ASS_in_iterFor758 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_iterFor761 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathExpr_in_iterFor767 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forLoop777 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_forLoop779 = new BitSet(new ulong[]{0x80000FC00000UL});
		public static readonly BitSet _varFor_in_forLoop781 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_forLoop783 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_forLoop785 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_forLoop787 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _iterFor_in_forLoop789 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_forLoop791 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_forLoop793 = new BitSet(new ulong[]{0x49001EFE07400UL});
		public static readonly BitSet _bodyExpr_in_forLoop794 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_forLoop795 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_whileLoop819 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_whileLoop821 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_whileLoop822 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_whileLoop823 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_whileLoop825 = new BitSet(new ulong[]{0x49001EFE07400UL});
		public static readonly BitSet _bodyExpr_in_whileLoop826 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_whileLoop827 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_doLoop849 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_doLoop851 = new BitSet(new ulong[]{0x49001EFE07400UL});
		public static readonly BitSet _bodyExpr_in_doLoop852 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_doLoop853 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_doLoop855 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_doLoop856 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_doLoop857 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_doLoop859 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_literals0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_incSug898 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ADD_in_incSug900 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ADD_in_incSug902 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_decSug920 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _SUB_in_decSug922 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _SUB_in_decSug924 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _50_in_mathGroup942 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_mathGroup945 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_mathGroup947 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_mathGroup955 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methCall_in_mathGroup962 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _literals_in_mathGroup969 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _incSug_in_mathGroup976 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decSug_in_mathGroup983 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrCall_in_mathGroup990 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INVERT_in_mathNeg1003 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathGroup_in_mathNeg1006 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathGroup_in_mathNeg1015 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathNeg_in_mathConj1027 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _CONJ_in_mathConj1029 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathNeg_in_mathConj1032 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _mathConj_in_mathDisj1045 = new BitSet(new ulong[]{0x8000000002UL});
		public static readonly BitSet _DISJ_in_mathDisj1047 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathConj_in_mathDisj1050 = new BitSet(new ulong[]{0x8000000002UL});
		public static readonly BitSet _mathDisj_in_mathEq1064 = new BitSet(new ulong[]{0x6E0000000002UL});
		public static readonly BitSet _set_in_mathEq1066 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathDisj_in_mathEq1079 = new BitSet(new ulong[]{0x6E0000000002UL});
		public static readonly BitSet _mathEq_in_mathMult1092 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _set_in_mathMult1094 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathEq_in_mathMult1100 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _mathMult_in_mathAdd1114 = new BitSet(new ulong[]{0xC00000002UL});
		public static readonly BitSet _set_in_mathAdd1116 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathMult_in_mathAdd1123 = new BitSet(new ulong[]{0xC00000002UL});
		public static readonly BitSet _mathAdd_in_mathExpr1136 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathExpr_in_methArgs1150 = new BitSet(new ulong[]{0x40000000000002UL});
		public static readonly BitSet _54_in_methArgs1153 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_methArgs1155 = new BitSet(new ulong[]{0x40000000000002UL});
		public static readonly BitSet _ID_in_methCall1180 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_methCall1181 = new BitSet(new ulong[]{0xC9001E0000000UL});
		public static readonly BitSet _methArgs_in_methCall1182 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_methCall1184 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_methArgODecl1206 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _ID_in_methArgODecl1208 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_methArgODecl1226 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_methArgODecl1227 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_methArgODecl1228 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _ID_in_methArgODecl1230 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methArgODecl_in_methDeclArgs1253 = new BitSet(new ulong[]{0x40000000000002UL});
		public static readonly BitSet _54_in_methDeclArgs1255 = new BitSet(new ulong[]{0xFC00000UL});
		public static readonly BitSet _methArgODecl_in_methDeclArgs1257 = new BitSet(new ulong[]{0x40000000000002UL});
		public static readonly BitSet _methDeclArgs_in_methDeclArgsW1271 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_methRetType1294 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_methRetType1308 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_methRetType1309 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_methRetType1310 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methRetType_in_methDecl1329 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _ID_in_methDecl1331 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_methDecl1333 = new BitSet(new ulong[]{0x800000FC00000UL});
		public static readonly BitSet _methDeclArgsW_in_methDecl1334 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_methDecl1335 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_methDecl1337 = new BitSet(new ulong[]{0x49001EFE07400UL});
		public static readonly BitSet _bodyExpr_in_methDecl1338 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_methDecl1339 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_moreVarDecl1366 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_moreVarDecl1368 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _ID_in_moreVarDecl1371 = new BitSet(new ulong[]{0x40000000000002UL});
		public static readonly BitSet _ASS_in_assW1384 = new BitSet(new ulong[]{0x49001E0000000UL});
		public static readonly BitSet _mathExpr_in_assW1387 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_varDecl1404 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _ID_in_varDecl1406 = new BitSet(new ulong[]{0x4010000000UL});
		public static readonly BitSet _assW_in_varDecl1408 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_varDecl1411 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_varDecl1431 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _moreVarDecl_in_varDecl1433 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _OP_END_in_varDecl1435 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bodyFExpr_in_bodyExpr1456 = new BitSet(new ulong[]{0x49001EFE07402UL});
		public static readonly BitSet _methDecl_in_mainBody1478 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrDecl_in_mainBody1480 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_mainBody1482 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mainBody_in_program1495 = new BitSet(new ulong[]{0xFC00002UL});
		public static readonly BitSet _program_in_result1514 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result1516 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute1533 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace Lang2
