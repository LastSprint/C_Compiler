grammar Lang2;
/* solomatin.cs.vsu.ru@gmail.com */

options{
	language=CSharp3;
	output=AST;
}

tokens{
	PROGRAM;
	VAR_DECL;
	METH_CALL;
	CALL_ARGS;
	NEW = 'new';
	NEW_CLASS;
	NEW_ARR;
	ARR_DECL;
	ARR_CALL;
	IF = 'if';
	BODY;
	FOR='for';
	WHILE='while';
	DO='do';
	INC;
	DEC;
	CLASS = 'class';
	STRUCT = 'struct';
	METH_DECL;
	DECL_ARGS;
	TO = '->';
	RET_TYPE_SINGLE;
	RET_TYPE_ARR;
	RETURN = 'return';
}

@header{
	using System;
}

@lexer::namespace{Lang2}
@parser::namespace{Lang2}

OP_END	:	';'
	;

INT		:	('0'..'9')+
		;
DOUBLE	:	INT('.'INT)?
		;

CHAR	:	'\'' ( options {greedy=false;} : . ) '\''
		;
STRING			:   '"'! ( options {greedy=false;} : . )* '"'!
				; 
WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;

//--------------------------Operator tokens----------------------------------//
ADD	:	'+'
	;
SUB	:	'-'
	;
MULT	:	'*'
	;
DIV	:	'/'
	;
ASS	:	'='
	;
DISJ
	:	'||'
	;
CONJ
	:	'&&'
	;

IS_MORE	: '>'
	;

IS_LESS	:	'<'
		 ;

IS_EQUALLY	:	'=='
	;

INVERT	:	'\!'
	;

ID	:	('a'..'z'|'A'..'Z'|'_')+
	;
//--------------------Class AND STRUCT--------------------------//
classDecl	:	CLASS ID '{'bodyCExprW'}' -> ^(CLASS ID bodyCExprW)
			;

structDecl	:	STRUCT ID '{'bodySExprW'}' -> ^(STRUCT ID bodySExprW)
			;

bodyCExpr	:	varDecl
				|arrDecl
				|structDecl
				|classDecl
				|methDecl
			;
bodyCExprW	:	bodyCExpr+	-> ^(BODY bodyCExpr+)
			;
bodySExpr	:	varDecl
				|arrDecl
				|methDecl
			;
bodySExprW	:	bodySExpr+	-> ^(BODY bodySExpr+)
			;			
toObjExpr	:	ID TO^ 
				(ID
				|methCall
				|arrCall)
			;
//--------------------Arrays-------------------------//

arrDecl		:	ID ID'['']' assW? OP_END-> ^(ARR_DECL ID ID assW?)
			;

arrCall		:	ID'['mathExpr']' -> ^(ARR_CALL ID mathExpr)
			;

//--------------------Expresions---------------------//
bodyFExpr	:	varDecl
				|ID ASS^ mathExpr OP_END!
				|methCall OP_END!
				|arrDecl
				|ifExpr
				|forLoop
				|incSug OP_END!
				|decSug OP_END!
				|whileLoop
				|doLoop
				|arrCall ASS^ mathExpr OP_END!
				|toObjExpr OP_END!
				|RETURN^ mathExpr? OP_END!
				;
//-------------------IF AND LOOPS---------------------------//
ifExpr	:	IF'(' mathExpr')' '{'bodyExpr'}' -> ^(IF mathExpr bodyExpr )
		;
varFor	:	ID
			|varDecl
		;
iterFor	:	ID ASS^ mathExpr
			|mathExpr
		;
forLoop	:	FOR '(' varFor ';' mathExpr ';' iterFor ')' '{'bodyExpr'}' -> ^(FOR varFor mathExpr iterFor bodyExpr)
		;
whileLoop	:	WHILE '('mathExpr')' '{'bodyExpr'}' -> ^(WHILE mathExpr bodyExpr)
			;
doLoop		:	DO '{'bodyExpr'}' '('mathExpr')' OP_END -> ^(DO bodyExpr mathExpr)
			;
//----------------------------Math-----------------------//
newOp		:	NEW ID '('methArgs?')' -> ^(NEW_CLASS ID methArgs?)
				|NEW ID '[' mathExpr']' ->^(NEW_ARR ID mathExpr)
			;
literals	:	INT|STRING|CHAR|DOUBLE
			;
incSug	:	ID ADD ADD -> ^(INC ID)
		;
decSug	:	ID SUB SUB -> ^(DEC ID)
		;
mathGroup	:	'('! mathExpr ')'!
				|ID
				|methCall
				|literals
				|newOp
				|incSug
				|decSug
				|arrCall
				|toObjExpr
			;
mathNeg		:	(INVERT^ mathGroup)
				|(mathGroup)
			;
mathConj	:	mathNeg(CONJ^ mathNeg)*
			;
mathDisj	:	mathConj(DISJ^ mathConj)*
			;
mathEq		:	mathDisj((IS_MORE|IS_LESS|IS_EQUALLY)^	mathDisj)*
			;
mathMult	:	mathEq((MULT|DIV)^mathEq)*
			;
mathAdd		:	mathMult((ADD|SUB)^ mathMult)*
			;
mathExpr	:	mathAdd
			;
//--------------------------Bool----------------------//

//-------------------------Methods---------------------//
methArgs	:	mathExpr (',' mathExpr)*	->	^(CALL_ARGS mathExpr mathExpr* )
			;
methCall	:	ID'('methArgs?')' -> ^(METH_CALL ID methArgs?)
			;
methArgODecl	:	ID ID -> ^(VAR_DECL ID ID)
					|ID'['']' ID -> ^(ARR_DECL ID ID)
				;

methDeclArgs	:	methArgODecl(','!methArgODecl)*
				;
methDeclArgsW	:	methDeclArgs? -> ^(DECL_ARGS methDeclArgs?)
				;

methRetType	:	ID	->^(RET_TYPE_SINGLE ID)
				|ID'['']' -> ^(RET_TYPE_ARR ID)
			;
methDecl	:	methRetType ID '('methDeclArgsW')' '{'bodyExpr'}'  -> ^(METH_DECL methRetType ID methDeclArgsW bodyExpr)
			;
//-------------------Declarations--------------------//
moreVarDecl	:	ID(','! ID)+
			;
assW	:	ASS^ mathExpr ->^(ASS mathExpr)
		;
varDecl	:	ID ID assW? OP_END -> ^(VAR_DECL ID ID assW?)
			| ID moreVarDecl OP_END -> ^(VAR_DECL ID moreVarDecl)
		;

bodyExpr	:	bodyFExpr+ -> ^(BODY bodyFExpr+)
			;	
program		:	classDecl+ ->^(BODY classDecl+)
			;
result: program EOF -> ^(PROGRAM program);
public execute:  result;