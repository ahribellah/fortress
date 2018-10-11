(* THIS FILE WAS AUTOMATICALLY GENERATED BY
   com.sun.fortress.astgen.FortressAstGenerator FROM Fortress.ast *)

api FortressAst
import List.{...}
import FortressLibrary.{...} except ExtentRange

trait ASTNode extends Node  end
trait Applicable extends Info  end
trait Generic extends ASTNode  end
trait InAfterTypeChecking extends InOutPhases  end
trait InOutPhases extends Info  end
trait Info extends Node  end
trait Lhs extends Info  end
trait Node   end
trait ObjectConstructor extends Generic  end
trait OutAfterTypeChecking extends InOutPhases  end
trait TemplateGap extends Info  end
trait TypeOrPattern extends Info  end
trait TypeVariable extends Info  end
object APIName  extends Name
 getter asString():String
 end
trait ASTNodeInfo extends DataNode  end
trait AbbreviatedType extends BaseType  end
trait AbstractNode   end
trait AbstractObjectExpr extends Expr  end
object Accumulator  extends BigOpApp
 getter asString():String
 end
object AliasedAPIName  extends AbstractNode
 getter asString():String
 end
object AliasedSimpleName  extends AbstractNode
 getter asString():String
 end
object AmbiguousMultifixOpExpr  extends { Primary, OutAfterTypeChecking }
 getter asString():String
 end
object AndPredicateSymbol  extends SyntaxSymbol
 getter asString():String
 end
object AnonymousFnName  extends AnonymousName
 getter asString():String
 end
trait AnonymousName extends IdOrOpOrAnonymousName  end
object AnyCharacterSymbol  extends SpecialSymbol
 getter asString():String
 end
object AnyType  extends BaseType
 getter asString():String
 end
object Api  extends CompilationUnit
 getter asString():String
 end
object ArrayComprehension  extends BigOpApp
 getter asString():String
 end
object ArrayComprehensionClause  extends AbstractNode
 getter asString():String
 end
object ArrayElement  extends ArrayExpr
 getter asString():String
 end
object ArrayElements  extends ArrayExpr
 getter asString():String
 end
trait ArrayExpr extends Primary  end
object ArrayType  extends { AbbreviatedType, OutAfterTypeChecking }
 getter asString():String
 end
object ArrowCoercionInvocation  extends CoercionInvocation
 getter asString():String
 end
object ArrowType  extends Type
 getter asString():String
 end
object AsExpr  extends TypeAnnotatedExpr
 getter asString():String
 end
object AsIfExpr  extends TypeAnnotatedExpr
 getter asString():String
 end
object Assignment  extends Expr
 getter asString():String
 end
object AtomicExpr  extends Expr
 getter asString():String
 end
object BackspaceSymbol  extends SpecialSymbol
 getter asString():String
 end
trait BaseType extends Type  end
object BigFixity  extends Fixity
 getter asString():String
 end
trait BigOpApp extends Expr  end
trait Binding extends { AbstractNode, Lhs }  end
object Block  extends Expr
 getter asString():String
 end
object BoolArg  extends StaticArg
 getter asString():String
 end
object BoolBase  extends BoolExpr
 getter asString():String
 end
object BoolBinaryOp  extends BoolConstraint
 getter asString():String
 end
trait BoolConstraint extends BoolExpr  end
object BoolConstraintExpr  extends WhereConstraint
 getter asString():String
 end
trait BoolExpr extends StaticExpr  end
object BoolRef  extends BoolExpr
 getter asString():String
 end
object BoolUnaryOp  extends BoolConstraint
 getter asString():String
 end
object BooleanLiteralExpr  extends LiteralExpr
 getter asString():String
 end
object BottomType  extends BaseType
 getter asString():String
 end
trait BoundType extends Type  end
object BreaklineSymbol  extends SpecialSymbol
 getter asString():String
 end
object CarriageReturnSymbol  extends SpecialSymbol
 getter asString():String
 end
object CaseClause  extends AbstractNode
 getter asString():String
 end
object CaseExpr  extends Expr
 getter asString():String
 end
object CaseTransformer  extends Transformer
 getter asString():String
 end
object CaseTransformerClause  extends AbstractNode
 getter asString():String
 end
object Catch  extends AbstractNode
 getter asString():String
 end
object CatchClause  extends AbstractNode
 getter asString():String
 end
object ChainExpr  extends Primary
 getter asString():String
 end
object CharLiteralExpr  extends LiteralExpr
 getter asString():String
 end
object CharSymbol  extends CharacterSymbol
 getter asString():String
 end
object CharacterClassSymbol  extends SyntaxSymbol
 getter asString():String
 end
object CharacterInterval  extends CharacterSymbol
 getter asString():String
 end
trait CharacterSymbol extends SyntaxSymbol  end
trait CoercionInvocation extends Primary  end
trait CompilationUnit extends AbstractNode  end
object Component  extends CompilationUnit
 getter asString():String
 end
object CompoundAssignmentInfo  extends DataNode
 getter asString():String
 end
object ConstructorFnName  extends AnonymousName
 getter asString():String
 end
object Contract  extends AbstractNode
 getter asString():String
 end
trait DataNode extends InfoNode  end
trait Decl extends AbstractNode  end
trait DeclHeader extends GenericHeader  end
object DimArg  extends StaticArg
 getter asString():String
 end
object DimBase  extends DimExpr
 getter asString():String
 end
object DimBinaryOp  extends DimExpr
 getter asString():String
 end
object DimDecl  extends DimUnitDecl
 getter asString():String
 end
object DimExponent  extends DimExpr
 getter asString():String
 end
trait DimExpr extends Type  end
object DimRef  extends DimExpr
 getter asString():String
 end
object DimUnaryOp  extends DimExpr
 getter asString():String
 end
trait DimUnitDecl extends Decl  end
object Do  extends Expr
 getter asString():String
 end
object DummyExpr  extends Expr
 getter asString():String
 end
object Effect  extends AbstractNode
 getter asString():String
 end
object EnclosingFixity  extends Fixity
 getter asString():String
 end
object EnsuresClause  extends AbstractNode
 getter asString():String
 end
object Exit  extends Expr
 getter asString():String
 end
object ExponentiationMI  extends NonExprMI
 getter asString():String
 end
trait Expr   end
object ExprInfo  extends ParenthesizedInfo
 getter asString():String
 end
trait ExprMI extends MathItem  end
object ExtentRange  extends AbstractNode
 getter asString():String
 end
object FieldRef  extends { Primary, Lhs }
 getter asString():String
 end
object FixedPointType  extends Type
 getter asString():String
 end
trait Fixity extends InfoNode  end
object FloatLiteralExpr  extends NumberLiteralExpr
 getter asString():String
 end
object FnDecl  extends { Decl, Generic }
 getter asString():String
 end
object FnExpr  extends Expr
 getter asString():String
 end
object FnHeader  extends DeclHeader
 getter asString():String
 end
object FnRef  extends FunctionalRef
 getter asString():String
 end
object For  extends Expr
 getter asString():String
 end
object FormfeedSymbol  extends SpecialSymbol
 getter asString():String
 end
trait FunctionalRef extends Primary  end
object GeneratorClause  extends AbstractNode
 getter asString():String
 end
trait GenericHeader extends DataNode  end
object GrammarDecl  extends Decl
 getter asString():String
 end
trait GrammarMemberDecl extends Decl  end
object GroupSymbol  extends SyntaxSymbol
 getter asString():String
 end
object Id  extends IdOrOp
 getter asString():String
 end
trait IdOrOp extends IdOrOpOrAnonymousName  end
trait IdOrOpOrAnonymousName extends Name  end
object If  extends Expr
 getter asString():String
 end
object IfClause  extends AbstractNode
 getter asString():String
 end
trait Import extends AbstractNode  end
object ImportApi  extends Import
 getter asString():String
 end
object ImportNames  extends ImportedNames
 getter asString():String
 end
object ImportStar  extends ImportedNames
 getter asString():String
 end
trait ImportedNames extends Import  end
object InFixity  extends Fixity
 getter asString():String
 end
object Indices  extends AbstractNode
 getter asString():String
 end
trait InfoNode extends Info  end
object IntArg  extends StaticArg
 getter asString():String
 end
object IntBase  extends IntExpr
 getter asString():String
 end
object IntBinaryOp  extends IntExpr
 getter asString():String
 end
object IntConstraint  extends WhereConstraint
 getter asString():String
 end
trait IntExpr extends StaticExpr  end
object IntLiteralExpr  extends NumberLiteralExpr
 getter asString():String
 end
object IntRef  extends IntExpr
 getter asString():String
 end
object IntersectionType  extends BoundType
 getter asString():String
 end
object ItemSymbol  extends SyntaxSymbol
 getter asString():String
 end
object Juxt  extends { Primary, OutAfterTypeChecking }
 getter asString():String
 end
object KeywordExpr  extends AbstractNode
 getter asString():String
 end
object KeywordSymbol  extends SyntaxSymbol
 getter asString():String
 end
object KeywordType  extends AbstractNode
 getter asString():String
 end
object KindBool  extends StaticParamKind
 getter asString():String
 end
object KindDim  extends StaticParamKind
 getter asString():String
 end
object KindInt  extends StaticParamKind
 getter asString():String
 end
object KindNat  extends StaticParamKind
 getter asString():String
 end
object KindOp  extends StaticParamKind
 getter asString():String
 end
object KindType  extends StaticParamKind
 getter asString():String
 end
object KindUnit  extends StaticParamKind
 getter asString():String
 end
object LValue  extends Binding
 getter asString():String
 end
object Label  extends Expr
 getter asString():String
 end
object LabelType  extends Type
 getter asString():String
 end
trait LetExpr extends Expr  end
object LetFn  extends LetExpr
 getter asString():String
 end
object Level  extends InfoNode
 getter asString():String
 end
object Link  extends AbstractNode
 getter asString():String
 end
trait LiteralExpr extends Primary  end
object LocalVarDecl  extends LetExpr
 getter asString():String
 end
trait MathItem extends { AbstractNode, OutAfterTypeChecking }  end
object MathPrimary  extends { Primary, OutAfterTypeChecking }
 getter asString():String
 end
object MatrixType  extends { AbbreviatedType, OutAfterTypeChecking }
 getter asString():String
 end
object MethodInfo  extends DataNode
 getter asString():String
 end
object MethodInvocation  extends Primary
 getter asString():String
 end
object MultiFixity  extends Fixity
 getter asString():String
 end
trait Name extends AbstractNode  end
object NamedOp  extends Op
 getter asString():String
 end
object NamedTransformerDef  extends TransformerDecl
 getter asString():String
 end
trait NamedType extends BaseType  end
object NestedPattern  extends PatternBinding
 getter asString():String
 end
object NewlineSymbol  extends SpecialSymbol
 getter asString():String
 end
object NoFixity  extends Fixity
 getter asString():String
 end
object NoWhitespaceSymbol  extends SyntaxSymbol
 getter asString():String
 end
object NodeTransformer  extends Transformer
 getter asString():String
 end
trait NonExprMI extends MathItem  end
object NonParenthesisDelimitedMI  extends ExprMI
 getter asString():String
 end
trait NonterminalDecl extends GrammarMemberDecl  end
object NonterminalDef  extends NonterminalDecl
 getter asString():String
 end
object NonterminalExtensionDef  extends NonterminalDecl
 getter asString():String
 end
object NonterminalHeader  extends AbstractNode
 getter asString():String
 end
object NonterminalParameter  extends AbstractNode
 getter asString():String
 end
object NonterminalSymbol  extends SyntaxSymbol
 getter asString():String
 end
object NotPredicateSymbol  extends SyntaxSymbol
 getter asString():String
 end
trait NumberLiteralExpr extends LiteralExpr  end
object ObjectDecl  extends { TraitObjectDecl, ObjectConstructor }
 getter asString():String
 end
object ObjectExpr  extends AbstractObjectExpr
 getter asString():String
 end
object ObjectExprType  extends SelfType
 getter asString():String
 end
trait Op extends IdOrOp  end
object OpArg  extends StaticArg
 getter asString():String
 end
object OpExpr  extends Primary
 getter asString():String
 end
object OpRef  extends FunctionalRef
 getter asString():String
 end
object OptionalSymbol  extends SyntaxSymbol
 getter asString():String
 end
object Overloading  extends AbstractNode
 getter asString():String
 end
object Param  extends Binding
 getter asString():String
 end
object ParenthesisDelimitedMI  extends ExprMI
 getter asString():String
 end
trait ParenthesizedInfo extends ASTNodeInfo  end
object Pattern  extends { AbstractNode, TypeOrPattern }
 getter asString():String
 end
object PatternArgs  extends AbstractNode
 getter asString():String
 end
trait PatternBinding extends AbstractNode  end
object PlainPattern  extends PatternBinding
 getter asString():String
 end
object PostFixity  extends Fixity
 getter asString():String
 end
object PreFixity  extends Fixity
 getter asString():String
 end
object PreTransformerDef  extends TransformerDecl
 getter asString():String
 end
object PrefixedSymbol  extends SyntaxSymbol
 getter asString():String
 end
trait Primary extends SimpleExpr  end
object PropertyDecl  extends Decl
 getter asString():String
 end
object RepeatOneOrMoreSymbol  extends SyntaxSymbol
 getter asString():String
 end
object RepeatSymbol  extends SyntaxSymbol
 getter asString():String
 end
trait SelfType extends BaseType  end
trait SimpleExpr extends Expr  end
object SpanInfo  extends ASTNodeInfo
 getter asString():String
 end
object Spawn  extends Expr
 getter asString():String
 end
trait SpecialSymbol extends SyntaxSymbol  end
trait StaticArg   end
trait StaticExpr extends AbstractNode  end
object StaticParam  extends AbstractNode
 getter asString():String
 end
trait StaticParamKind extends InfoNode  end
object StringLiteralExpr  extends LiteralExpr
 getter asString():String
 end
object SubscriptExpr  extends { SimpleExpr, Lhs }
 getter asString():String
 end
object SubscriptingMI  extends NonExprMI
 getter asString():String
 end
object SuperSyntaxDef  extends SyntaxDecl
 getter asString():String
 end
trait SyntaxDecl extends AbstractNode  end
object SyntaxDef  extends SyntaxDecl
 getter asString():String
 end
trait SyntaxSymbol extends AbstractNode  end
object TabSymbol  extends SpecialSymbol
 getter asString():String
 end
object TaggedDimType  extends AbbreviatedType
 getter asString():String
 end
object TaggedUnitType  extends AbbreviatedType
 getter asString():String
 end
object TestDecl  extends Decl
 getter asString():String
 end
object Throw  extends Expr
 getter asString():String
 end
object TokenSymbol  extends SyntaxSymbol
 getter asString():String
 end
object TraitCoercionInvocation  extends CoercionInvocation
 getter asString():String
 end
object TraitDecl  extends TraitObjectDecl
 getter asString():String
 end
trait TraitObjectDecl extends { Decl, Generic }  end
object TraitSelfType  extends SelfType
 getter asString():String
 end
object TraitType  extends NamedType
 getter asString():String
 end
object TraitTypeHeader  extends DeclHeader
 getter asString():String
 end
object TraitTypeWhere  extends AbstractNode
 getter asString():String
 end
trait Transformer extends AbstractNode  end
trait TransformerDecl extends AbstractNode  end
object Try  extends Expr
 getter asString():String
 end
object TryAtomicExpr  extends Expr
 getter asString():String
 end
object TupleCoercionInvocation  extends CoercionInvocation
 getter asString():String
 end
object TupleExpr  extends Expr
 getter asString():String
 end
object TupleType  extends Type
 getter asString():String
 end
trait Type   end
object TypeAlias  extends Decl
 getter asString():String
 end
trait TypeAnnotatedExpr extends Expr  end
object TypeArg  extends StaticArg
 getter asString():String
 end
object TypeInfo  extends ParenthesizedInfo
 getter asString():String
 end
object TypePattern  extends PatternBinding
 getter asString():String
 end
object Typecase  extends Expr
 getter asString():String
 end
object TypecaseClause  extends AbstractNode
 getter asString():String
 end
object UnionCoercionInvocation  extends CoercionInvocation
 getter asString():String
 end
object UnionType  extends BoundType
 getter asString():String
 end
object UnitArg  extends StaticArg
 getter asString():String
 end
object UnitBinaryOp  extends UnitExpr
 getter asString():String
 end
object UnitConstraint  extends WhereConstraint
 getter asString():String
 end
object UnitDecl  extends DimUnitDecl
 getter asString():String
 end
trait UnitExpr extends StaticExpr  end
object UnitRef  extends UnitExpr
 getter asString():String
 end
object UnknownFixity  extends Fixity
 getter asString():String
 end
object UnknownType  extends BaseType
 getter asString():String
 end
object UnparsedTransformer  extends Transformer
 getter asString():String
 end
object VarDecl  extends Decl
 getter asString():String
 end
object VarRef  extends { Primary, Lhs }
 getter asString():String
 end
object VarType  extends { NamedType, TypeVariable }
 getter asString():String
 end
object VoidLiteralExpr  extends LiteralExpr
 getter asString():String
 end
object WhereBinding  extends AbstractNode
 getter asString():String
 end
object WhereClause  extends AbstractNode
 getter asString():String
 end
object WhereCoerces  extends WhereConstraint
 getter asString():String
 end
trait WhereConstraint extends AbstractNode  end
object WhereEquals  extends WhereConstraint
 getter asString():String
 end
object WhereExtends  extends WhereConstraint
 getter asString():String
 end
object WhereTypeAlias  extends WhereConstraint
 getter asString():String
 end
object While  extends Expr
 getter asString():String
 end
object WhitespaceSymbol  extends SpecialSymbol
 getter asString():String
 end

end
