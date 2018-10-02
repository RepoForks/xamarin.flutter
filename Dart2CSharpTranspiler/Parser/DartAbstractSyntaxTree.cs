using System;
using System.Collections.Generic;
using System.Text;

// https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/dart/ast/ast.dart

namespace Dart2CSharpTranspiler
{


    public class AdjacentStrings : StringLiteral
    {

        public NodeList<StringLiteral> strings { get; set; }



    }
    public class AnnotatedNode : AstNode
    {

        public Comment documentationComment { get; set; }

        public Token firstTokenAfterCommentAndMetadata { get; set; }

        public NodeList<Annotation> metadata { get; set; }

        public List<AstNode> sortedCommentAndAnnotations { get; set; }



    }
    public class Annotation : AstNode
    {

        public ArgumentList arguments { get; set; }

        public Token atSign { get; set; }

        public SimpleIdentifier constructorName { get; set; }

        public Element element { get; set; }

        public ElementAnnotation elementAnnotation { get; set; }

        public Identifier name { get; set; }

        public Token period { get; set; }



    }
    public class ArgumentList : AstNode
    {

        public NodeList<Expression> arguments { get; set; }

        public List<ParameterElement> correspondingPropagatedParameters { get; set; }

        public List<ParameterElement> correspondingStaticParameters { get; set; }

        public Token leftParenthesis { get; set; }

        public Token rightParenthesis { get; set; }



    }
    public class AsExpression : Expression
    {

        public Token asOperator { get; set; }

        public Expression expression { get; set; }

        public TypeAnnotation type { get; set; }



    }
    public class AssertInitializer : Assertion, ConstructorInitializer
    {



    }
    public class Assertion : AstNode
    {

        public Token assertKeyword { get; set; }

        public Token comma { get; set; }

        public Expression condition { get; set; }

        public Token leftParenthesis { get; set; }

        public Expression message { get; set; }

        public Token rightParenthesis { get; set; }



    }
    public class AssertStatement : Assertion, Statement
    {

        public Token semicolon { get; set; }



    }
    public class AssignmentExpression : Expression, MethodReferenceExpression
    {

        public Expression leftHandSide { get; set; }

        public Token @operator { get; set; }

        public Expression rightHandSide { get; set; }

    }

    public class AstNode : SyntacticEntity
    {

        public static Comparator<AstNode> LEXICAL_ORDER =
          (AstNode first, AstNode second) => first.offset - second.offset;

        public Token beginToken { get; set; }

        public Iterable<SyntacticEntity> childEntities { get; set; }

        public int? end { get; set; }

        public Token endToken { get; set; }

        public bool? isSynthetic { get; set; }

        public int? length { get; set; }

        public int? offset { get; set; }

        public AstNode parent { get; set; }

        public AstNode root { get; set; }

        public List<AstNode> EMPTY_LIST = new List<AstNode>();


        //public static - second.offset;

        public E accept<E>(AstVisitor<E> visitor)
        {
            return default(E);
        }

        public Token findPrevious(Token target)
        {
            return default(Token);
        }

        E getAncestor<E as AstNode>(Predicate<AstNode> predicate);

        public E getProperty<E>(string name)
        {
            return default(E);
        }

        public void setProperty(string name, object value)
        {
        }

        public string toSource()
        {
            return default(string);
        }

        public void visitChildren(AstVisitor visitor)
        {
        }



    }
    public class AstVisitor<R>
    {

        public R visitAdjacentStrings(AdjacentStrings node)
        {
            return default(R);
        }

        public R visitAnnotation(Annotation node)
        {
            return default(R);
        }

        public R visitArgumentList(ArgumentList node)
        {
            return default(R);
        }

        public R visitAsExpression(AsExpression node)
        {
            return default(R);
        }

        public R visitAssertInitializer(AssertInitializer node)
        {
            return default(R);
        }

        public R visitAssertStatement(AssertStatement assertStatement)
        {
            return default(R);
        }

        public R visitAssignmentExpression(AssignmentExpression node)
        {
            return default(R);
        }

        public R visitAwaitExpression(AwaitExpression node)
        {
            return default(R);
        }

        public R visitBinaryExpression(BinaryExpression node)
        {
            return default(R);
        }

        public R visitBlock(Block node)
        {
            return default(R);
        }

        public R visitBlockFunctionBody(BlockFunctionBody node)
        {
            return default(R);
        }

        public R visitBooleanLiteral(BooleanLiteral node)
        {
            return default(R);
        }

        public R visitBreakStatement(BreakStatement node)
        {
            return default(R);
        }

        public R visitCascadeExpression(CascadeExpression node)
        {
            return default(R);
        }

        public R visitCatchClause(CatchClause node)
        {
            return default(R);
        }

        public R visitClassDeclaration(ClassDeclaration node)
        {
            return default(R);
        }

        public R visitClassTypeAlias(ClassTypeAlias node)
        {
            return default(R);
        }

        public R visitComment(Comment node)
        {
            return default(R);
        }

        public R visitCommentReference(CommentReference node)
        {
            return default(R);
        }

        public R visitCompilationUnit(CompilationUnit node)
        {
            return default(R);
        }

        public R visitConditionalExpression(ConditionalExpression node)
        {
            return default(R);
        }

        public R visitConfiguration(Configuration node)
        {
            return default(R);
        }

        public R visitConstructorDeclaration(ConstructorDeclaration node)
        {
            return default(R);
        }

        public R visitConstructorFieldInitializer(ConstructorFieldInitializer node)
        {
            return default(R);
        }

        public R visitConstructorName(ConstructorName node)
        {
            return default(R);
        }

        public R visitContinueStatement(ContinueStatement node)
        {
            return default(R);
        }

        public R visitDeclaredIdentifier(DeclaredIdentifier node)
        {
            return default(R);
        }

        public R visitDefaultFormalParameter(DefaultFormalParameter node)
        {
            return default(R);
        }

        public R visitDoStatement(DoStatement node)
        {
            return default(R);
        }

        public R visitDottedName(DottedName node)
        {
            return default(R);
        }

        public R visitDoubleLiteral(DoubleLiteral node)
        {
            return default(R);
        }

        public R visitEmptyFunctionBody(EmptyFunctionBody node)
        {
            return default(R);
        }

        public R visitEmptyStatement(EmptyStatement node)
        {
            return default(R);
        }

        public R visitEnumConstantDeclaration(EnumConstantDeclaration node)
        {
            return default(R);
        }

        public R visitEnumDeclaration(EnumDeclaration node)
        {
            return default(R);
        }

        public R visitExportDirective(ExportDirective node)
        {
            return default(R);
        }

        public R visitExpressionFunctionBody(ExpressionFunctionBody node)
        {
            return default(R);
        }

        public R visitExpressionStatement(ExpressionStatement node)
        {
            return default(R);
        }

        public R visitExtendsClause(ExtendsClause node)
        {
            return default(R);
        }

        public R visitFieldDeclaration(FieldDeclaration node)
        {
            return default(R);
        }

        public R visitFieldFormalParameter(FieldFormalParameter node)
        {
            return default(R);
        }

        public R visitForEachStatement(ForEachStatement node)
        {
            return default(R);
        }

        public R visitFormalParameterList(FormalParameterList node)
        {
            return default(R);
        }

        public R visitForStatement(ForStatement node)
        {
            return default(R);
        }

        public R visitFunctionDeclaration(FunctionDeclaration node)
        {
            return default(R);
        }

        public R visitFunctionDeclarationStatement(FunctionDeclarationStatement node)
        {
            return default(R);
        }

        public R visitFunctionExpression(FunctionExpression node)
        {
            return default(R);
        }

        public R visitFunctionExpressionInvocation(FunctionExpressionInvocation node)
        {
            return default(R);
        }

        public R visitFunctionTypeAlias(FunctionTypeAlias functionTypeAlias)
        {
            return default(R);
        }

        public R visitFunctionTypedFormalParameter(FunctionTypedFormalParameter node)
        {
            return default(R);
        }

        public R visitGenericFunctionType(GenericFunctionType node)
        {
            return default(R);
        }

        public R visitGenericTypeAlias(GenericTypeAlias node)
        {
            return default(R);
        }

        public R visitHideCombinator(HideCombinator node)
        {
            return default(R);
        }

        public R visitIfStatement(IfStatement node)
        {
            return default(R);
        }

        public R visitImplementsClause(ImplementsClause node)
        {
            return default(R);
        }

        public R visitImportDirective(ImportDirective node)
        {
            return default(R);
        }

        public R visitIndexExpression(IndexExpression node)
        {
            return default(R);
        }

        public R visitInstanceCreationExpression(InstanceCreationExpression node)
        {
            return default(R);
        }

        public R visitIntegerLiteral(IntegerLiteral node)
        {
            return default(R);
        }

        public R visitInterpolationExpression(InterpolationExpression node)
        {
            return default(R);
        }

        public R visitInterpolationString(InterpolationString node)
        {
            return default(R);
        }

        public R visitIsExpression(IsExpression node)
        {
            return default(R);
        }

        public R visitLabel(Label node)
        {
            return default(R);
        }

        public R visitLabeledStatement(LabeledStatement node)
        {
            return default(R);
        }

        public R visitLibraryDirective(LibraryDirective node)
        {
            return default(R);
        }

        public R visitLibraryIdentifier(LibraryIdentifier node)
        {
            return default(R);
        }

        public R visitListLiteral(ListLiteral node)
        {
            return default(R);
        }

        public R visitMapLiteral(MapLiteral node)
        {
            return default(R);
        }

        public R visitMapLiteralEntry(MapLiteralEntry node)
        {
            return default(R);
        }

        public R visitMethodDeclaration(MethodDeclaration node)
        {
            return default(R);
        }

        public R visitMethodInvocation(MethodInvocation node)
        {
            return default(R);
        }

        public R visitMixinDeclaration(MixinDeclaration node)
        {
            return default(R);
        }

        public R visitNamedExpression(NamedExpression node)
        {
            return default(R);
        }

        public R visitNativeClause(NativeClause node)
        {
            return default(R);
        }

        public R visitNativeFunctionBody(NativeFunctionBody node)
        {
            return default(R);
        }

        public R visitNullLiteral(NullLiteral node)
        {
            return default(R);
        }

        public R visitOnClause(OnClause node)
        {
            return default(R);
        }

        public R visitParenthesizedExpression(ParenthesizedExpression node)
        {
            return default(R);
        }

        public R visitPartDirective(PartDirective node)
        {
            return default(R);
        }

        public R visitPartOfDirective(PartOfDirective node)
        {
            return default(R);
        }

        public R visitPostfixExpression(PostfixExpression node)
        {
            return default(R);
        }

        public R visitPrefixedIdentifier(PrefixedIdentifier node)
        {
            return default(R);
        }

        public R visitPrefixExpression(PrefixExpression node)
        {
            return default(R);
        }

        public R visitPropertyAccess(PropertyAccess node)
        {
            return default(R);
        }

        public R visitRedirectingConstructorInvocation(RedirectingConstructorInvocation node)
        {
            return default(R);
        }

        public R visitRethrowExpression(RethrowExpression node)
        {
            return default(R);
        }

        public R visitReturnStatement(ReturnStatement node)
        {
            return default(R);
        }

        public R visitScriptTag(ScriptTag node)
        {
            return default(R);
        }

        public R visitShowCombinator(ShowCombinator node)
        {
            return default(R);
        }

        public R visitSimpleFormalParameter(SimpleFormalParameter node)
        {
            return default(R);
        }

        public R visitSimpleIdentifier(SimpleIdentifier node)
        {
            return default(R);
        }

        public R visitSimpleStringLiteral(SimpleStringLiteral node)
        {
            return default(R);
        }

        public R visitStringInterpolation(StringInterpolation node)
        {
            return default(R);
        }

        public R visitSuperConstructorInvocation(SuperConstructorInvocation node)
        {
            return default(R);
        }

        public R visitSuperExpression(SuperExpression node)
        {
            return default(R);
        }

        public R visitSwitchCase(SwitchCase node)
        {
            return default(R);
        }

        public R visitSwitchDefault(SwitchDefault node)
        {
            return default(R);
        }

        public R visitSwitchStatement(SwitchStatement node)
        {
            return default(R);
        }

        public R visitSymbolLiteral(SymbolLiteral node)
        {
            return default(R);
        }

        public R visitThisExpression(ThisExpression node)
        {
            return default(R);
        }

        public R visitThrowExpression(ThrowExpression node)
        {
            return default(R);
        }

        public R visitTopLevelVariableDeclaration(TopLevelVariableDeclaration node)
        {
            return default(R);
        }

        public R visitTryStatement(TryStatement node)
        {
            return default(R);
        }

        public R visitTypeArgumentList(TypeArgumentList node)
        {
            return default(R);
        }

        public R visitTypeName(TypeName node)
        {
            return default(R);
        }

        public R visitTypeParameter(TypeParameter node)
        {
            return default(R);
        }

        public R visitTypeParameterList(TypeParameterList node)
        {
            return default(R);
        }

        public R visitVariableDeclaration(VariableDeclaration node)
        {
            return default(R);
        }

        public R visitVariableDeclarationList(VariableDeclarationList node)
        {
            return default(R);
        }

        public R visitVariableDeclarationStatement(VariableDeclarationStatement node)
        {
            return default(R);
        }

        public R visitWhileStatement(WhileStatement node)
        {
            return default(R);
        }

        public R visitWithClause(WithClause node)
        {
            return default(R);
        }

        public R visitYieldStatement(YieldStatement node)
        {
            return default(R);
        }



    }
    public class AwaitExpression : Expression
    {

        public Token awaitKeyword { get; set; }

        public Expression expression { get; set; }



    }
    public class BinaryExpression : Expression, MethodReferenceExpression
    {

        public Expression leftOperand { get; set; }

        public Token @operator { get; set; }

        public Expression rightOperand { get; set; }



    }
    public class Block : Statement
    {

        public Token leftBracket { get; set; }

        public Token rightBracket { get; set; }

        public NodeList<Statement> statements { get; set; }



    }
    public class BlockFunctionBody : FunctionBody
    {

        public Block block { get; set; }

        public Token keyword { get; set; }

        public Token star { get; set; }



    }
    public class BooleanLiteral : Literal
    {

        public Token literal { get; set; }

        public bool? value { get; set; }



    }
    public class BreakStatement : Statement
    {

        public Token breakKeyword { get; set; }

        public SimpleIdentifier label { get; set; }

        public Token semicolon { get; set; }

        public AstNode target { get; set; }



    }
    public class CascadeExpression : Expression
    {

        public NodeList<Expression> cascadeSections { get; set; }

        public Expression target { get; set; }



    }
    public class CatchClause : AstNode
    {

        public Block body { get; set; }

        public Token catchKeyword { get; set; }

        public Token comma { get; set; }

        public SimpleIdentifier exceptionParameter { get; set; }

        public TypeAnnotation exceptionType { get; set; }

        public Token leftParenthesis { get; set; }

        public Token onKeyword { get; set; }

        public Token rightParenthesis { get; set; }

        public SimpleIdentifier stackTraceParameter { get; set; }



    }
    public class ClassDeclaration : ClassOrMixinDeclaration
    {

        public Token abstractKeyword { get; set; }

        public Token classKeyword { get; set; }

        public ClassElement element { get; set; }

        public ExtendsClause extendsClause { get; set; }

        public ImplementsClause implementsClause { get; set; }

        public bool? isAbstract { get; set; }

        public Token leftBracket { get; set; }

        public NativeClause nativeClause { get; set; }

        public Token rightBracket { get; set; }

        public TypeParameterList typeParameters { get; set; }

        public WithClause withClause { get; set; }

        public ConstructorDeclaration getConstructor(string name)
        {
            return default(ConstructorDeclaration);
        }



    }
    public class ClassMember : Declaration
    {



    }
    public class ClassOrMixinDeclaration : NamedCompilationUnitMember
    {

        public ClassElement declaredElement { get; set; }

        public ImplementsClause implementsClause { get; set; }

        public Token leftBracket { get; set; }

        public NodeList<ClassMember> members { get; set; }

        public Token rightBracket { get; set; }

        public TypeParameterList typeParameters { get; set; }

        public VariableDeclaration getField(string name)
        {
            return default(VariableDeclaration);
        }

        public MethodDeclaration getMethod(string name)
        {
            return default(MethodDeclaration);
        }



    }
    public class ClassTypeAlias : TypeAlias
    {

        public Token abstractKeyword { get; set; }

        public Token equals { get; set; }

        public ImplementsClause implementsClause { get; set; }

        public bool? isAbstract { get; set; }

        public TypeName superclass { get; set; }

        public TypeParameterList typeParameters { get; set; }

        public WithClause withClause { get; set; }



    }
    public class Combinator : AstNode
    {

        public Token keyword { get; set; }



    }
    public class Comment : AstNode
    {

        public bool? isBlock { get; set; }

        public bool? isDocumentation { get; set; }

        public bool? isEndOfLine { get; set; }

        public NodeList<CommentReference> references { get; set; }

        public List<Token> tokens { get; set; }



    }
    public class CommentReference : AstNode
    {

        public Identifier identifier { get; set; }

        public Token newKeyword { get; set; }



    }
    public class CompilationUnit : AstNode
    {

        public Token beginToken { get; set; }

        public NodeList<CompilationUnitMember> declarations { get; set; }

        public CompilationUnitElement declaredElement { get; set; }

        public NodeList<Directive> directives { get; set; }

        public CompilationUnitElement element { get; set; }

        public Token endToken { get; set; }

        public LineInfo lineInfo { get; set; }

        public ScriptTag scriptTag { get; set; }

        public List<AstNode> sortedDirectivesAndDeclarations { get; set; }



    }
    public class CompilationUnitMember : Declaration
    {



    }
    public class ConditionalExpression : Expression
    {

        public Token colon { get; set; }

        public Expression condition { get; set; }

        public Expression elseExpression { get; set; }

        public Token question { get; set; }

        public Expression thenExpression { get; set; }



    }
    public class Configuration : AstNode
    {

        public Token equalToken { get; set; }

        public Token ifKeyword { get; set; }

        public Token leftParenthesis { get; set; }

        public StringLiteral libraryUri { get; set; }

        public DottedName name { get; set; }

        public Token rightParenthesis { get; set; }

        public StringLiteral uri { get; set; }

        public Source uriSource { get; set; }

        public StringLiteral value { get; set; }



    }
    public class ConstructorDeclaration : ClassMember
    {

        public FunctionBody body { get; set; }

        public Token constKeyword { get; set; }

        public ConstructorElement declaredElement { get; set; }

        public ConstructorElement element { get; set; }

        public Token externalKeyword { get; set; }

        public Token factoryKeyword { get; set; }

        public NodeList<ConstructorInitializer> initializers { get; set; }

        public SimpleIdentifier name { get; set; }

        public FormalParameterList parameters { get; set; }

        public Token period { get; set; }

        public ConstructorName redirectedConstructor { get; set; }

        public Identifier returnType { get; set; }

        public Token separator { get; set; }



    }
    public class ConstructorFieldInitializer : ConstructorInitializer
    {

        public Token equals { get; set; }

        public Expression expression { get; set; }

        public SimpleIdentifier fieldName { get; set; }

        public Token period { get; set; }

        public Token thisKeyword { get; set; }



    }
    public class ConstructorInitializer : AstNode
    {



    }
    public class ConstructorName : AstNode, ConstructorReferenceNode
    {

        public SimpleIdentifier name { get; set; }

        public Token period { get; set; }

        public TypeName type { get; set; }



    }
    public class ConstructorReferenceNode
    {

        public ConstructorElement staticElement { get; set; }



    }
    public class ContinueStatement : Statement
    {

        public Token continueKeyword { get; set; }

        public SimpleIdentifier label { get; set; }

        public Token semicolon { get; set; }

        public AstNode target { get; set; }



    }
    public class Declaration : AnnotatedNode
    {

        public Element declaredElement { get; set; }

        public Element element { get; set; }



    }
    public class DeclaredIdentifier : Declaration
    {

        public LocalVariableElement declaredElement { get; set; }

        public LocalVariableElement element { get; set; }

        public SimpleIdentifier identifier { get; set; }

        public bool? isConst { get; set; }

        public bool? isFinal { get; set; }

        public Token keyword { get; set; }

        public TypeAnnotation type { get; set; }



    }
    public class DefaultFormalParameter : FormalParameter
    {

        public Expression defaultValue { get; set; }

        public ParameterKind kind { get; set; }

        public NormalFormalParameter parameter { get; set; }

        public Token separator { get; set; }



    }
    public class Directive : AnnotatedNode
    {

        public Element element { get; set; }

        public Token keyword { get; set; }



    }
    public class DoStatement : Statement
    {

        public Statement body { get; set; }

        public Expression condition { get; set; }

        public Token doKeyword { get; set; }

        public Token leftParenthesis { get; set; }

        public Token rightParenthesis { get; set; }

        public Token semicolon { get; set; }

        public Token whileKeyword { get; set; }



    }
    public class DottedName : AstNode
    {

        public NodeList<SimpleIdentifier> components { get; set; }



    }
    public class DoubleLiteral : Literal
    {

        public Token literal { get; set; }

        public double? value { get; set; }



    }
    public class EmptyFunctionBody : FunctionBody
    {

        public Token semicolon { get; set; }



    }
    public class EmptyStatement : Statement
    {

        public Token semicolon { get; set; }



    }
    public class EnumConstantDeclaration : Declaration
    {

        public SimpleIdentifier name { get; set; }



    }
    public class EnumDeclaration : NamedCompilationUnitMember
    {

        public NodeList<EnumConstantDeclaration> constants { get; set; }

        public ClassElement declaredElement { get; set; }

        public ClassElement element { get; set; }

        public Token enumKeyword { get; set; }

        public Token leftBracket { get; set; }

        public Token rightBracket { get; set; }



    }
    public class ExportDirective : NamespaceDirective
    {



    }
    public class Expression : AstNode
    {

        public ParameterElement bestParameterElement { get; set; }

        public DartType bestType { get; set; }

        public bool? isAssignable { get; set; }

        public int? precedence { get; set; }

        public ParameterElement propagatedParameterElement { get; set; }

        public DartType propagatedType { get; set; }

        public ParameterElement staticParameterElement { get; set; }

        public DartType staticType { get; set; }

        public Expression unParenthesized { get; set; }

        public List<Expression> EMPTY_LIST = new new List<Expression>();


		

}
    public class ExpressionFunctionBody : FunctionBody
    {

        public Expression expression { get; set; }

        public Token functionDefinition { get; set; }

        public Token keyword { get; set; }

        public Token semicolon { get; set; }



    }
    public class ExpressionStatement : Statement
    {

        public Expression expression { get; set; }

        public Token semicolon { get; set; }



    }
    public class ExtendsClause : AstNode
    {

        public Token extendsKeyword { get; set; }

        public TypeName superclass { get; set; }



    }
    public class FieldDeclaration : ClassMember
    {

        public Token covariantKeyword { get; set; }

        public VariableDeclarationList fields { get; set; }

        public bool? isStatic { get; set; }

        public Token semicolon { get; set; }

        public Token staticKeyword { get; set; }



    }
    public class FieldFormalParameter : NormalFormalParameter
    {

        public Token keyword { get; set; }

        public FormalParameterList parameters { get; set; }

        public Token period { get; set; }

        public Token thisKeyword { get; set; }

        public TypeAnnotation type { get; set; }

        public TypeParameterList typeParameters { get; set; }



    }
    public class ForEachStatement : Statement
    {

        public Token awaitKeyword { get; set; }

        public Statement body { get; set; }

        public Token forKeyword { get; set; }

        public SimpleIdentifier identifier { get; set; }

        public Token inKeyword { get; set; }

        public Expression iterable { get; set; }

        public Token leftParenthesis { get; set; }

        public DeclaredIdentifier loopVariable { get; set; }

        public Token rightParenthesis { get; set; }



    }
    public class FormalParameter : AstNode
    {

        public Token covariantKeyword { get; set; }

        public ParameterElement declaredElement { get; set; }

        public ParameterElement element { get; set; }

        public SimpleIdentifier identifier { get; set; }

        public bool? isConst { get; set; }

        public bool? isFinal { get; set; }

        public bool? isNamed { get; set; }

        public bool? isOptional { get; set; }

        public bool? isOptionalPositional { get; set; }

        public bool? isPositional { get; set; }

        public bool? isRequired { get; set; }

        public ParameterKind kind { get; set; }

        public NodeList<Annotation> metadata { get; set; }



    }
    public class FormalParameterList : AstNode
    {

        public Token leftDelimiter { get; set; }

        public Token leftParenthesis { get; set; }

        public List<ParameterElement> parameterElements { get; set; }

        public NodeList<FormalParameter> parameters { get; set; }

        public Token rightDelimiter { get; set; }

        public Token rightParenthesis { get; set; }



    }
    public class ForStatement : Statement
    {

        public Statement body { get; set; }

        public Expression condition { get; set; }

        public Token forKeyword { get; set; }

        public Expression initialization { get; set; }

        public Token leftParenthesis { get; set; }

        public Token leftSeparator { get; set; }

        public Token rightParenthesis { get; set; }

        public Token rightSeparator { get; set; }

        public NodeList<Expression> updaters { get; set; }

        public VariableDeclarationList variables { get; set; }



    }
    public class FunctionBody : AstNode
    {

        public bool? isAsynchronous { get; set; }

        public bool? isGenerator { get; set; }

        public bool? isSynchronous { get; set; }

        public Token keyword { get; set; }

        public Token star { get; set; }

        public bool? isPotentiallyMutatedInClosure(VariableElement variable)
        {
            return default(bool?);
        }

        public bool? isPotentiallyMutatedInScope(VariableElement variable)
        {
            return default(bool?);
        }



    }
    public class FunctionDeclaration : NamedCompilationUnitMember
    {

        public ExecutableElement declaredElement { get; set; }

        public ExecutableElement element { get; set; }

        public Token externalKeyword { get; set; }

        public FunctionExpression functionExpression { get; set; }

        public bool? isGetter { get; set; }

        public bool? isSetter { get; set; }

        public Token propertyKeyword { get; set; }

        public TypeAnnotation returnType { get; set; }



    }
    public class FunctionDeclarationStatement : Statement
    {

        public FunctionDeclaration functionDeclaration { get; set; }



    }
    public class FunctionExpression : Expression
    {

        public FunctionBody body { get; set; }

        public ExecutableElement declaredElement { get; set; }

        public ExecutableElement element { get; set; }

        public FormalParameterList parameters { get; set; }

        public TypeParameterList typeParameters { get; set; }



    }
    public class FunctionExpressionInvocation : InvocationExpression
    {

        public ArgumentList argumentList { get; set; }

        public ExecutableElement bestElement { get; set; }

        public Expression function { get; set; }

        public ExecutableElement propagatedElement { get; set; }

        public ExecutableElement staticElement { get; set; }

        public TypeArgumentList typeArguments { get; set; }



    }
    public class FunctionTypeAlias : TypeAlias
    {

        public FormalParameterList parameters { get; set; }

        public TypeAnnotation returnType { get; set; }

        public TypeParameterList typeParameters { get; set; }



    }
    public class FunctionTypedFormalParameter : NormalFormalParameter
    {

        public FormalParameterList parameters { get; set; }

        public Token question { get; set; }

        public TypeAnnotation returnType { get; set; }

        public TypeParameterList typeParameters { get; set; }



    }
    public class GenericFunctionType : TypeAnnotation
    {

        public Token functionKeyword { get; set; }

        public FormalParameterList parameters { get; set; }

        public TypeAnnotation returnType { get; set; }

        public TypeParameterList typeParameters { get; set; }



    }
    public class GenericTypeAlias : TypeAlias
    {

        public Token equals { get; set; }

        public GenericFunctionType functionType { get; set; }

        public TypeParameterList typeParameters { get; set; }



    }
    public class HideCombinator : Combinator
    {

        public NodeList<SimpleIdentifier> hiddenNames { get; set; }



    }
    public class Identifier : Expression
    {

        public Element bestElement { get; set; }

        public string name { get; set; }

        public Element propagatedElement { get; set; }

        public Element staticElement { get; set; }

        public bool? isPrivateName(string name)
        {
            return default(bool?);
        }



    }
    public class IfStatement : Statement
    {

        public Expression condition { get; set; }

        public Token elseKeyword { get; set; }

        public Statement elseStatement { get; set; }

        public Token ifKeyword { get; set; }

        public Token leftParenthesis { get; set; }

        public Token rightParenthesis { get; set; }

        public Statement thenStatement { get; set; }



    }
    public class ImplementsClause : AstNode
    {

        public Token implementsKeyword { get; set; }

        public NodeList<TypeName> interfaces { get; set; }



    }
    public class ImportDirective : NamespaceDirective
    {

        public Token asKeyword { get; set; }

        public Token deferredKeyword { get; set; }

        public SimpleIdentifier prefix { get; set; }

        public static Comparator<ImportDirective> COMPARATOR(ImportDirective import1, ImportDirective import2)
        {
            StringLiteral uri1 = import1.uri;
            StringLiteral uri2 = import2.uri;
            string uriStr1 = uri1.stringValue;
            string uriStr2 = uri2.stringValue;
            if (uriStr1 != null || uriStr2 != null)
            {
                if (uriStr1 == null)
                {
                    return -1;
                }
                else if (uriStr2 == null)
                {
                    return 1;
                }
                else
                {
                    int? compare = uriStr1.compareTo(uriStr2);
                    if (compare != 0)
                    {
                        return compare;
                    }
                }
            }
            SimpleIdentifier prefix1 = import1.prefix;
            SimpleIdentifier prefix2 = import2.prefix;
            string prefixStr1 = prefix1?.name;
            string prefixStr2 = prefix2?.name;
            if (prefixStr1 != null || prefixStr2 != null)
            {
                if (prefixStr1 == null)
                {
                    return -1;
                }
                else if (prefixStr2 == null)
                {
                    return 1;
                }
                else
                {
                    int? compare = prefixStr1.compareTo(prefixStr2);
                    if (compare != 0)
                    {
                        return compare;
                    }
                }
            }
            NodeList<Combinator> combinators1 = import1.combinators;
            List<string> allHides1 = new List<string>();
            List<string> allShows1 = new List<string>();
            int? length1 = combinators1.Count;
            foreach (int? i = 0;
            i < length1;
            i++) {
                Combinator combinator = combinators1[i];
                if (combinator is HideCombinator)
                {
                    NodeList<SimpleIdentifier> hides = combinator.hiddenNames;
                    int? hideLength = hides.Count;
                    foreach (int? j = 0;
                    j < hideLength;
                    j++) {
                        SimpleIdentifier simpleIdentifier = hides[j];
                        allHides1.add(simpleIdentifier.name);
                    }
                }
                else
                {
                    NodeList<SimpleIdentifier> shows = (combinator as ShowCombinator).shownNames;
                    int? showLength = shows.Count;
                    foreach (int? j = 0;
                    j < showLength;
                    j++) {
                        SimpleIdentifier simpleIdentifier = shows[j];
                        allShows1.add(simpleIdentifier.name);
                    }
                }
            }
            NodeList<Combinator> combinators2 = import2.combinators;
            List<string> allHides2 = new List<string>();
            List<string> allShows2 = new List<string>();
            int? length2 = combinators2.Count;
            foreach (int? i = 0;
            i < length2;
            i++) {
                Combinator combinator = combinators2[i];
                if (combinator is HideCombinator)
                {
                    NodeList<SimpleIdentifier> hides = combinator.hiddenNames;
                    int? hideLength = hides.Count;
                    foreach (int? j = 0;
                    j < hideLength;
                    j++) {
                        SimpleIdentifier simpleIdentifier = hides[j];
                        allHides2.add(simpleIdentifier.name);
                    }
                }
                else
                {
                    NodeList<SimpleIdentifier> shows = (combinator as ShowCombinator).shownNames;
                    int? showLength = shows.Count;
                    foreach (int? j = 0;
                    j < showLength;
                    j++) {
                        SimpleIdentifier simpleIdentifier = shows[j];
                        allShows2.add(simpleIdentifier.name);
                    }
                }
            }
            if (allHides1.Count != allHides2.Count)
            {
                return allHides1.Count - allHides2.Count;
            }
            if (allShows1.Count != allShows2.Count)
            {
                return allShows1.Count - allShows2.Count;
            }
            if (!allHides1.toSet().containsAll(allHides2))
            {
                return -1;
            }
            if (!allShows1.toSet().containsAll(allShows2))
            {
                return -1;
            }
            return 0;
        }

    }

    public class IndexExpression : Expression, MethodReferenceExpression
    {

        public AuxiliaryElements auxiliaryElements { get; set; }

        public Expression index { get; set; }

        public bool? isCascaded { get; set; }

        public Token leftBracket { get; set; }

        public Token period { get; set; }

        public Expression realTarget { get; set; }

        public Token rightBracket { get; set; }

        public Expression target { get; set; }

        public bool? inGetterContext()
        {
            return default(bool?);
        }

        public bool? inSetterContext()
        {
            return default(bool?);
        }



    }
    public class InstanceCreationExpression : Expression, ConstructorReferenceNode
    {

        public ArgumentList argumentList { get; set; }

        public ConstructorName constructorName { get; set; }

        public bool? isConst { get; set; }

        public Token keyword { get; set; }



    }
    public class IntegerLiteral : Literal
    {

        public Token literal { get; set; }

        public int? value { get; set; }



    }
    public class InterpolationElement : AstNode
    {



    }
    public class InterpolationExpression : InterpolationElement
    {

        public Expression expression { get; set; }

        public Token leftBracket { get; set; }

        public Token rightBracket { get; set; }



    }
    public class InterpolationString : InterpolationElement
    {

        public Token contents { get; set; }

        public int? contentsEnd { get; set; }

        public int? contentsOffset { get; set; }

        public string value { get; set; }



    }
    public class InvocationExpression : Expression
    {

        public ArgumentList argumentList { get; set; }

        public Expression function { get; set; }

        public DartType propagatedInvokeType { get; set; }

        public DartType staticInvokeType { get; set; }

        public TypeArgumentList typeArguments { get; set; }



    }
    public class IsExpression : Expression
    {

        public Expression expression { get; set; }

        public Token isOperator { get; set; }

        public Token notOperator { get; set; }

        public TypeAnnotation type { get; set; }



    }
    public class Label : AstNode
    {

        public Token colon { get; set; }

        public SimpleIdentifier label { get; set; }



    }
    public class LabeledStatement : Statement
    {

        public NodeList<Label> labels { get; set; }

        public Statement statement { get; set; }



    }
    public class LibraryDirective : Directive
    {

        public Token libraryKeyword { get; set; }

        public LibraryIdentifier name { get; set; }

        public Token semicolon { get; set; }



    }
    public class LibraryIdentifier : Identifier
    {

        public NodeList<SimpleIdentifier> components { get; set; }



    }
    public class ListLiteral : TypedLiteral
    {

        public NodeList<Expression> elements { get; set; }

        public Token leftBracket { get; set; }

        public Token rightBracket { get; set; }



    }
    public class Literal : Expression
    {



    }
    public class MapLiteral : TypedLiteral
    {

        public NodeList<MapLiteralEntry> entries { get; set; }

        public Token leftBracket { get; set; }

        public Token rightBracket { get; set; }



    }
    public class MapLiteralEntry : AstNode
    {

        public Expression key { get; set; }

        public Token separator { get; set; }

        public Expression value { get; set; }



    }
    public class MethodDeclaration : ClassMember
    {

        public FunctionBody body { get; set; }

        public ExecutableElement declaredElement { get; set; }

        public ExecutableElement element { get; set; }

        public Token externalKeyword { get; set; }

        public bool? isAbstract { get; set; }

        public bool? isGetter { get; set; }

        public bool? isOperator { get; set; }

        public bool? isSetter { get; set; }

        public bool? isStatic { get; set; }

        public Token modifierKeyword { get; set; }

        public SimpleIdentifier name { get; set; }

        public Token operatorKeyword { get; set; }

        public FormalParameterList parameters { get; set; }

        public Token propertyKeyword { get; set; }

        public TypeAnnotation returnType { get; set; }

        public TypeParameterList typeParameters { get; set; }



    }
    public class MethodInvocation : InvocationExpression
    {

        public ArgumentList argumentList { get; set; }

        public bool? isCascaded { get; set; }

        public SimpleIdentifier methodName { get; set; }

        public Token @operator { get; set; }

        public Expression realTarget { get; set; }

        public Expression target { get; set; }

        public TypeArgumentList typeArguments { get; set; }



    }
    public class MethodReferenceExpression
    {

        public MethodElement bestElement { get; set; }

        public MethodElement propagatedElement { get; set; }

        public MethodElement staticElement { get; set; }



    }
    public class MixinDeclaration : ClassOrMixinDeclaration
    {

        public Token mixinKeyword { get; set; }

        public OnClause onClause { get; set; }



    }
    public class NamedCompilationUnitMember : CompilationUnitMember
    {

        public SimpleIdentifier name { get; set; }



    }
    public class NamedExpression : Expression
    {

        public ParameterElement element { get; set; }

        public Expression expression { get; set; }

        public Label name { get; set; }



    }
    public class NamedType : TypeAnnotation
    {

        public bool? isDeferred { get; set; }

        public Identifier name { get; set; }

        public Token question { get; set; }

        public DartType type { get; set; }

        public TypeArgumentList typeArguments { get; set; }



    }
    public class NamespaceDirective : UriBasedDirective
    {

        public NodeList<Combinator> combinators { get; set; }

        public NodeList<Configuration> configurations { get; set; }

        public Token keyword { get; set; }

        public Source selectedSource { get; set; }

        public string selectedUriContent { get; set; }

        public Token semicolon { get; set; }



    }
    public class NativeClause : AstNode
    {

        public StringLiteral name { get; set; }

        public Token nativeKeyword { get; set; }



    }
    public class NativeFunctionBody : FunctionBody
    {

        public Token nativeKeyword { get; set; }

        public Token semicolon { get; set; }

        public StringLiteral stringLiteral { get; set; }



    }
    public class NodeList<E> : List<E> where E : AstNode
    {

        public Token beginToken { get; set; }

        public Token endToken { get; set; }

        public AstNode owner { get; set; }

        public operator [] (int? index)
        {
            return default(operator);
        }

        public E node);

        public NotValidReturnType accept(AstVisitor visitor)
        {
            return default(NotValidReturnType);
        }



    }
    public class NormalFormalParameter : FormalParameter
    {

        public Token covariantKeyword { get; set; }

        public Comment documentationComment { get; set; }

        public SimpleIdentifier identifier { get; set; }

        public List<Annotation> metadata { get; set; }

        public List<AstNode> sortedCommentAndAnnotations { get; set; }



    }
    public class NullLiteral : Literal
    {

        public Token literal { get; set; }



    }
    public class OnClause : AstNode
    {

        public Token onKeyword { get; set; }

        public NodeList<TypeName> superclassConstraints { get; set; }



    }
    public class ParenthesizedExpression : Expression
    {

        public Expression expression { get; set; }

        public Token leftParenthesis { get; set; }

        public Token rightParenthesis { get; set; }



    }
    public class PartDirective : UriBasedDirective
    {

        public Token partKeyword { get; set; }

        public Token semicolon { get; set; }



    }
    public class PartOfDirective : Directive
    {

        public LibraryIdentifier libraryName { get; set; }

        public Token ofKeyword { get; set; }

        public Token partKeyword { get; set; }

        public Token semicolon { get; set; }

        public StringLiteral uri { get; set; }



    }
    public class PostfixExpression : Expression, MethodReferenceExpression
    {

        public Expression operand { get; set; }

        public Token @operator { get; set; }



    }
    public class PrefixedIdentifier : Identifier
    {

        public SimpleIdentifier identifier { get; set; }

        public bool? isDeferred { get; set; }

        public Token period { get; set; }

        public SimpleIdentifier prefix { get; set; }



    }
    public class PrefixExpression : Expression, MethodReferenceExpression
    {

        public Expression operand { get; set; }

        public Token @operator { get; set; }



    }
    public class PropertyAccess : Expression
    {

        public bool? isCascaded { get; set; }

        public Token @operator { get; set; }

        public SimpleIdentifier propertyName { get; set; }

        public Expression realTarget { get; set; }

        public Expression target { get; set; }



    }
    public class RedirectingConstructorInvocation : ConstructorInitializer, ConstructorReferenceNode
    {

        public ArgumentList argumentList { get; set; }

        public SimpleIdentifier constructorName { get; set; }

        public Token period { get; set; }

        public Token thisKeyword { get; set; }



    }
    public class RethrowExpression : Expression
    {

        public Token rethrowKeyword { get; set; }



    }
    public class ReturnStatement : Statement
    {

        public Expression expression { get; set; }

        public Token returnKeyword { get; set; }

        public Token semicolon { get; set; }



    }
    public class ScriptTag : AstNode
    {

        public Token scriptTag { get; set; }



    }
    public class ShowCombinator : Combinator
    {

        public NodeList<SimpleIdentifier> shownNames { get; set; }



    }
    public class SimpleFormalParameter : NormalFormalParameter
    {

        public Token keyword { get; set; }

        public TypeAnnotation type { get; set; }



    }
    public class SimpleIdentifier : Identifier
    {

        public AuxiliaryElements auxiliaryElements { get; set; }

        public bool? isQualified { get; set; }

        public Element propagatedElement { get; set; }

        public Element staticElement { get; set; }

        public Token token { get; set; }

        public bool? inDeclarationContext()
        {
            return default(bool?);
        }

        public bool? inGetterContext()
        {
            return default(bool?);
        }

        public bool? inSetterContext()
        {
            return default(bool?);
        }



    }
    public class SimpleStringLiteral : SingleStringLiteral
    {

        public Token literal { get; set; }

        public string value { get; set; }



    }
    public class SingleStringLiteral : StringLiteral
    {

        public int? contentsEnd { get; set; }

        public int? contentsOffset { get; set; }

        public bool? isMultiline { get; set; }

        public bool? isRaw { get; set; }

        public bool? isSingleQuoted { get; set; }



    }
    public class Statement : AstNode
    {

        public Statement unlabeled { get; set; }



    }
    public class StringInterpolation : SingleStringLiteral
    {

        public NodeList<InterpolationElement> elements { get; set; }



    }
    public class StringLiteral : Literal
    {

        public string stringValue { get; set; }


    }
    public class SuperConstructorInvocation : ConstructorInitializer, ConstructorReferenceNode
    {

        public ArgumentList argumentList { get; set; }

        public SimpleIdentifier constructorName { get; set; }

        public Token period { get; set; }

        public Token superKeyword { get; set; }


    }
    public class SuperExpression : Expression
    {

        public Token superKeyword { get; set; }


    }
    public class SwitchCase : SwitchMember
    {

        public Expression expression { get; set; }


    }
    public class SwitchDefault : SwitchMember
    {


    }
    public class SwitchMember : AstNode
    {

        public Token colon { get; set; }

        public Token keyword { get; set; }

        public NodeList<Label> labels { get; set; }

        public NodeList<Statement> statements { get; set; }


    }
    public class SwitchStatement : Statement
    {

        public Expression expression { get; set; }

        public Token leftBracket { get; set; }

        public Token leftParenthesis { get; set; }

        public NodeList<SwitchMember> members { get; set; }

        public Token rightBracket { get; set; }

        public Token rightParenthesis { get; set; }

        public Token switchKeyword { get; set; }


    }
    public class SymbolLiteral : Literal
    {

        public List<Token> components { get; set; }

        public Token poundSign { get; set; }


    }
    public class ThisExpression : Expression
    {

        public Token thisKeyword { get; set; }


    }
    public class ThrowExpression : Expression
    {

        public Expression expression { get; set; }

        public Token throwKeyword { get; set; }


    }
    public class TopLevelVariableDeclaration : CompilationUnitMember
    {

        public Token semicolon { get; set; }

        public VariableDeclarationList variables { get; set; }


    }
    public class TryStatement : Statement
    {

        public Block body { get; set; }

        public NodeList<CatchClause> catchClauses { get; set; }

        public Block finallyBlock { get; set; }

        public Token finallyKeyword { get; set; }

        public Token tryKeyword { get; set; }


    }
    public class TypeAlias : NamedCompilationUnitMember
    {

        public Token semicolon { get; set; }

        public Token typedefKeyword { get; set; }


    }
    public class TypeAnnotation : AstNode
    {

        public DartType type { get; set; }



    }
    public class TypeArgumentList : AstNode
    {

        public NodeList<TypeAnnotation> arguments { get; set; }

        public Token leftBracket { get; set; }

        public Token rightBracket { get; set; }



    }
    public class TypedLiteral : Literal
    {

        public Token constKeyword { get; set; }

        public bool? isConst { get; set; }

        public TypeArgumentList typeArguments { get; set; }


    }
    public class TypeName : NamedType
    {


    }
    public class TypeParameter : Declaration
    {

        public TypeAnnotation bound { get; set; }

        public Token extendsKeyword { get; set; }

        public SimpleIdentifier name { get; set; }



    }
    public class TypeParameterList : AstNode
    {

        public Token leftBracket { get; set; }

        public Token rightBracket { get; set; }

        public NodeList<TypeParameter> typeParameters { get; set; }


    }
    public class UriBasedDirective : Directive
    {

        public Source source { get; set; }

        public StringLiteral uri { get; set; }

        public string uriContent { get; set; }

        public Element uriElement { get; set; }

        public Source uriSource { get; set; }


    }
    public class VariableDeclaration : Declaration
    {

        public VariableElement declaredElement { get; set; }

        public VariableElement element { get; set; }

        public Token equals { get; set; }

        public Expression initializer { get; set; }

        public bool? isConst { get; set; }

        public bool? isFinal { get; set; }

        public SimpleIdentifier name { get; set; }


    }
    public class VariableDeclarationList : AnnotatedNode
    {

        public bool? isConst { get; set; }

        public bool? isFinal { get; set; }

        public Token keyword { get; set; }

        public TypeAnnotation type { get; set; }

        public NodeList<VariableDeclaration> variables { get; set; }


    }
    public class VariableDeclarationStatement : Statement
    {

        public Token semicolon { get; set; }

        public VariableDeclarationList variables { get; set; }


    }
    public class WhileStatement : Statement
    {

        public Statement body { get; set; }

        public Expression condition { get; set; }

        public Token leftParenthesis { get; set; }

        public Token rightParenthesis { get; set; }

        public Token whileKeyword { get; set; }


    }
    public class WithClause : AstNode
    {

        public NodeList<TypeName> mixinTypes { get; set; }

        public Token withKeyword { get; set; }


    }
    public class YieldStatement : Statement
    {

        public Expression expression { get; set; }

        public Token semicolon { get; set; }

        public Token star { get; set; }

        public Token yieldKeyword { get; set; }

    }
}