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
	ARR_DECL;
	ARR_CALL;
	IF = 'if';
	BODY;
	FOR='for';
	WHILE='while';
	DO='do';
	INC;
	DEC;
	METH_DECL;
	DECL_ARGS;
	RET_TYPE_SINGLE;
	RET_TYPE_ARR;
	RETURN = 'return';

	TINT= 'int';
	TFLOAT = 'float';
	TSTRING = 'string';
	TCHAR = 'char';
	TBOOL = 'bool';
	TVOID = 'void';
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

IS_LESS_OR_EQUAL	:	'<='
					;

IS_MORE_OR_EQUAL	:	'>='
					;

ID	:	('a'..'z'|'A'..'Z'|'_')+
	;


type :	TINT
		| TFLOAT
		| TSTRING
		| TCHAR
		| TBOOL
		| TVOID
	;

//--------------------Arrays-------------------------//

arrDecl		:	type ID'['mathExpr']' OP_END -> ^(ARR_DECL type ID mathExpr)
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
doLoop		:	DO '{'bodyExpr'}' WHILE '('mathExpr')' OP_END -> ^(DO bodyExpr mathExpr)
			;
//----------------------------Math-----------------------//
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
				|incSug
				|decSug
				|arrCall
			;
mathNeg		:	(INVERT^ mathGroup)
				|(mathGroup)
			;
mathConj	:	mathNeg(CONJ^ mathNeg)*
			;
mathDisj	:	mathConj(DISJ^ mathConj)*
			;
mathEq		:	mathDisj((IS_MORE|IS_LESS|IS_EQUALLY|IS_MORE_OR_EQUAL|IS_LESS_OR_EQUAL)^	mathDisj)*
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
methArgODecl	:	type ID -> ^(VAR_DECL type ID)
					|type'['']' ID -> ^(ARR_DECL type ID)
				;

methDeclArgs	:	methArgODecl(','!methArgODecl)*
				;
methDeclArgsW	:	methDeclArgs? -> ^(DECL_ARGS methDeclArgs?)
				;

methRetType	:	type	->^(RET_TYPE_SINGLE type)
				|type'['']' -> ^(RET_TYPE_ARR type)
			;
methDecl	:	methRetType ID '('methDeclArgsW')' '{'bodyExpr'}'  -> ^(METH_DECL methRetType ID methDeclArgsW bodyExpr)
			;
//-------------------Declarations--------------------//
moreVarDecl	:	ID(','! ID)+
			;
assW	:	ASS^ mathExpr ->^(ASS mathExpr)
		;
varDecl	:	type ID assW? OP_END -> ^(VAR_DECL type ID assW?)
			| type moreVarDecl OP_END -> ^(VAR_DECL type moreVarDecl)
		;

bodyExpr	:	bodyFExpr+ -> ^(BODY bodyFExpr+)
			;

mainBody	:	methDecl|arrDecl|varDecl
			;

program		:	mainBody+ ->^(BODY mainBody+)
			;
result: program EOF -> ^(PROGRAM program);
public execute:  result;