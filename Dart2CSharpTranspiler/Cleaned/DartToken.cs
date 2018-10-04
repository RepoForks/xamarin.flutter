// Copyright (c) 2016, the Dart project authors.  Please see the AUTHORS file
// for details. All rights reserved. Use of this source code is governed by a
// BSD-style license that can be found in the LICENSE file.


using System;
using System.Collections.Generic;
using static Dart2CSharpTranspiler.Global;
using static Dart2CSharpTranspiler.DartTokenConstants;
/**
* Defines the tokens that are produced by the scanner, used by the parser, and
* referenced from the [AST structure](ast.dart).
*/
namespace Dart2CSharpTranspiler
{

    public static class Global
    {
        public const int NO_PRECEDENCE = 0;
        public const int ASSIGNMENT_PRECEDENCE = 1;
        public const int CASCADE_PRECEDENCE = 2;
        public const int CONDITIONAL_PRECEDENCE = 3;
        public const int IF_NULL_PRECEDENCE = 4;
        public const int LOGICAL_OR_PRECEDENCE = 5;
        public const int LOGICAL_AND_PRECEDENCE = 6;
        public const int EQUALITY_PRECEDENCE = 7;
        public const int RELATIONAL_PRECEDENCE = 8;
        public const int BITWISE_OR_PRECEDENCE = 9;
        public const int BITWISE_XOR_PRECEDENCE = 10;
        public const int BITWISE_AND_PRECEDENCE = 11;
        public const int SHIFT_PRECEDENCE = 12;
        public const int ADDITIVE_PRECEDENCE = 13;
        public const int MULTIPLICATIVE_PRECEDENCE = 14;
        public const int PREFIX_PRECEDENCE = 15;
        public const int POSTFIX_PRECEDENCE = 16;
        public const int SELECTOR_PRECEDENCE = 17;
    }
    /**
     * The opening half of a grouping pair of tokens. This is used for curly
     * brackets ('{'), parentheses ('('), and square brackets ('[').
     */
    public class BeginToken : SimpleToken
    {
        /**
         * The token that corresponds to this token.
         */
        public Token endToken;

        /**
         * Initialize a newly created token to have the given [type] at the given
         * [offset].
         */
        public BeginToken(TokenType type, int offset, CommentToken precedingComment = null)
          : base(type, offset, precedingComment)
        {
            if (!(type == TokenType.LT ||
                type == TokenType.OPEN_CURLY_BRACKET ||
                type == TokenType.OPEN_PAREN ||
                type == TokenType.OPEN_SQUARE_BRACKET ||
                type == TokenType.STRING_INTERPOLATION_EXPRESSION))
                throw new Exception("Token type not valid");
        }

        public override Token endGroup { get; }

        public override Token copy() => new BeginToken(type, offset, (CommentToken)copyComments(precedingComments));


    }

    /**
     * A token representing a comment.
     */
    public class CommentToken : StringToken
    {
        /**
         * The token that contains this comment.
         */
        public SimpleToken parent;

        /**
         * Initialize a newly created token to represent a token of the given [type]
         * with the given [value] at the given [offset].
         */
        public CommentToken(TokenType type, String value, int offset)
          : base(type, value, offset)
        {

        }

        public override Token copy() => new CommentToken(type, _value, offset);

        /**
         * Remove this comment token from the list.
         *
         * This is used when we decide to interpret the comment as syntax.
         */
        public void remove()
        {
            if (previous != null)
            {
                previous.setNextWithoutSettingPrevious(next);
                if (next != null)
                    next.previous = previous;
            }
            else
            {
                parent.setPrecedingComment(next);
            }
        }
    }

    /**
     * A documentation comment token.
     */
    public class DocumentationCommentToken : CommentToken
    {
        /**
         * Initialize a newly created token to represent a token of the given [type]
         * with the given [value] at the given [offset].
         */
        public DocumentationCommentToken(TokenType type, String value, int offset)
           : base(type, value, offset) { }

        public override Token copy() => new DocumentationCommentToken(type, _value, offset);
    }

    /**
     * The keywords in the Dart programming language.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public class Keyword : TokenType
    {
        public static Keyword ABSTRACT = new Keyword("abstract", "ABSTRACT", isBuiltIn: true, isModifier: true);

        public static Keyword AS = new Keyword("as", "AS", precedence: RELATIONAL_PRECEDENCE, isBuiltIn: true);

        public static Keyword ASSERT = new Keyword("assert", "ASSERT");

        public static Keyword ASYNC = new Keyword("async", "ASYNC", isPseudo: true);

        public static Keyword AWAIT = new Keyword("await", "AWAIT", isPseudo: true);

        public static Keyword BREAK = new Keyword("break", "BREAK");

        public static Keyword CASE = new Keyword("case", "CASE");

        public static Keyword CATCH = new Keyword("catch", "CATCH");

        public static Keyword CLASS = new Keyword("class", "CLASS", isTopLevelKeyword: true);

        public static Keyword CONST = new Keyword("const", "CONST", isModifier: true);

        public static Keyword CONTINUE = new Keyword("continue", "CONTINUE");

        public static Keyword COVARIANT = new Keyword("covariant", "COVARIANT", isBuiltIn: true, isModifier: true);

        public static Keyword DEFAULT = new Keyword("default", "DEFAULT");

        public static Keyword DEFERRED =
          new Keyword("deferred", "DEFERRED", isBuiltIn: true);

        public static Keyword DO = new Keyword("do", "DO");

        public static Keyword DYNAMIC =
          new Keyword("dynamic", "DYNAMIC", isBuiltIn: true);

        public static Keyword ELSE = new Keyword("else", "ELSE");

        public static Keyword ENUM =
          new Keyword("enum", "ENUM", isTopLevelKeyword: true);

        public static Keyword EXPORT = new Keyword("export", "EXPORT",
            isBuiltIn: true, isTopLevelKeyword: true);

        public static Keyword EXTENDS = new Keyword("extends", "EXTENDS");

        public static Keyword EXTERNAL =
          new Keyword("external", "EXTERNAL", isBuiltIn: true, isModifier: true);

        public static Keyword FACTORY =
          new Keyword("factory", "FACTORY", isBuiltIn: true);

        public static Keyword FALSE = new Keyword("false", "FALSE");

        public static Keyword FINAL = new Keyword("final", "FINAL", isModifier: true);

        public static Keyword FINALLY = new Keyword("finally", "FINALLY");

        public static Keyword FOR = new Keyword("for", "FOR");

        public static Keyword FUNCTION = new Keyword("Function", "FUNCTION", isPseudo: true);

        public static Keyword GET = new Keyword("get", "GET", isBuiltIn: true);

        public static Keyword HIDE = new Keyword("hide", "HIDE", isPseudo: true);

        public static Keyword IF = new Keyword("if", "IF");

        public static Keyword IMPLEMENTS = new Keyword("implements", "IMPLEMENTS", isBuiltIn: true);

        public static Keyword IMPORT = new Keyword("import", "IMPORT", isBuiltIn: true, isTopLevelKeyword: true);

        public static Keyword IN = new Keyword("in", "IN");

        public static Keyword INTERFACE = new Keyword("interface", "INTERFACE", isBuiltIn: true);

        public static Keyword IS = new Keyword("is", "IS", precedence: RELATIONAL_PRECEDENCE);

        public static Keyword LIBRARY = new Keyword("library", "LIBRARY", isBuiltIn: true, isTopLevelKeyword: true);

        public static Keyword MIXIN = new Keyword("mixin", "MIXIN", isBuiltIn: true, isTopLevelKeyword: true);

        public static Keyword NATIVE = new Keyword("native", "NATIVE", isPseudo: true);

        public static Keyword NEW = new Keyword("new", "NEW");

        public static Keyword NULL = new Keyword("null", "NULL");

        public static Keyword OF = new Keyword("of", "OF", isPseudo: true);

        public static Keyword ON = new Keyword("on", "ON", isPseudo: true);

        public static Keyword OPERATOR = new Keyword("operator", "OPERATOR", isBuiltIn: true);

        public static Keyword PART = new Keyword("part", "PART", isBuiltIn: true, isTopLevelKeyword: true);

        public static Keyword PATCH = new Keyword("patch", "PATCH", isPseudo: true);

        public static Keyword RETHROW = new Keyword("rethrow", "RETHROW");

        public static Keyword RETURN = new Keyword("return", "RETURN");

        public static Keyword SET = new Keyword("set", "SET", isBuiltIn: true);

        public static Keyword SHOW = new Keyword("show", "SHOW", isPseudo: true);

        public static Keyword SOURCE = new Keyword("source", "SOURCE", isPseudo: true);

        public static Keyword STATIC = new Keyword("static", "STATIC", isBuiltIn: true, isModifier: true);

        public static Keyword SUPER = new Keyword("super", "SUPER");

        public static Keyword SWITCH = new Keyword("switch", "SWITCH");

        public static Keyword SYNC = new Keyword("sync", "SYNC", isPseudo: true);

        public static Keyword THIS = new Keyword("this", "THIS");

        public static Keyword THROW = new Keyword("throw", "THROW");

        public static Keyword TRUE = new Keyword("true", "TRUE");

        public static Keyword TRY = new Keyword("try", "TRY");

        public static Keyword TYPEDEF = new Keyword("typedef", "TYPEDEF", isBuiltIn: true, isTopLevelKeyword: true);

        public static Keyword VAR = new Keyword("var", "VAR", isModifier: true);

        public static Keyword VOID = new Keyword("void", "VOID");

        public static Keyword WHILE = new Keyword("while", "WHILE");

        public static Keyword WITH = new Keyword("with", "WITH");

        public static Keyword YIELD = new Keyword("yield", "YIELD", isPseudo: true);

        public static List<Keyword> values = new List<Keyword>{
          ABSTRACT,
          AS,
          ASSERT,
          ASYNC,
          AWAIT,
          BREAK,
          CASE,
          CATCH,
          CLASS,
          CONST,
          CONTINUE,
          COVARIANT,
          DEFAULT,
          DEFERRED,
          DO,
          DYNAMIC,
          ELSE,
          ENUM,
          EXPORT,
          EXTENDS,
          EXTERNAL,
          FACTORY,
          FALSE,
          FINAL,
          FINALLY,
          FOR,
          FUNCTION,
          GET,
          HIDE,
          IF,
          IMPLEMENTS,
          IMPORT,
          IN,
          INTERFACE,
          IS,
          LIBRARY,
          MIXIN,
          NATIVE,
          NEW,
          NULL,
          OF,
          ON,
          OPERATOR,
          PART,
          PATCH,
          RETHROW,
          RETURN,
          SET,
          SHOW,
          SOURCE,
          STATIC,
          SUPER,
          SWITCH,
          SYNC,
          THIS,
          THROW,
          TRUE,
          TRY,
          TYPEDEF,
          VAR,
          VOID,
          WHILE,
          WITH,
          YIELD,
        };

        /**
         * A table mapping the lexemes of keywords to the corresponding keyword.
         */
        public static readonly Dictionary<String, Keyword> keywords = _createKeywordMap();

        /**
         * A flag indicating whether the keyword is "built-in" identifier.
         */
        public readonly bool isBuiltIn;

        public readonly bool isPseudo;

        /**
         * Initialize a newly created keyword.
         */
        public Keyword(String lexeme,
                       String name,
                       bool isBuiltIn = false,
                       bool isModifier = false,
                       bool isPseudo = false,
                       bool isTopLevelKeyword = false,
                       int precedence = NO_PRECEDENCE)
              : base(lexeme, name, precedence, KEYWORD_TOKEN,
                    isModifier: isModifier, isTopLevelKeyword: isTopLevelKeyword)
        {

        }

        public bool isBuiltInOrPseudo => isBuiltIn || isPseudo;

        /**
         * A flag indicating whether the keyword is "built-in" identifier.
         * This method exists for backward compatibility and will be removed.
         * Use [isBuiltIn] instead.
         */
        [Obsolete]
        public bool isPseudoKeyword => isBuiltIn; // TODO (danrubel): remove this

        /**
         * The name of the keyword type.
         */
        public String name => lexeme.ToUpper();

        /**
         * The lexeme for the keyword.
         *
         * Deprecated - use [lexeme] instead.
         */
        [Obsolete]
        public String syntax => lexeme;

        public String toString() => name;

        /**
         * Create a table mapping the lexemes of keywords to the corresponding keyword
         * and return the table that was created.
         */
        static Dictionary<String, Keyword> _createKeywordMap()
        {
            Dictionary<String, Keyword> result =
                new Dictionary<String, Keyword>();
            foreach (Keyword keyword in values)
            {
                result[keyword.lexeme] = keyword;
            }
            return result;
        }
    }

    /**
     * A token representing a keyword in the language.
     */
    public class KeywordToken : SimpleToken
    {
        public Keyword keyword;

        /**
         * Initialize a newly created token to represent the given [keyword] at the
         * given [offset].
         */
        public KeywordToken(Keyword keyword, int offset, CommentToken precedingComment = null)
          : base(keyword, offset, precedingComment)
        {
            this.keyword = keyword;
        }

        public override Token copy() =>
            new KeywordToken(keyword, offset, (CommentToken)copyComments(precedingComments));

        public override bool isIdentifier => keyword.isPseudo || keyword.isBuiltIn;

        public override bool isKeyword => true;

        public override bool isKeywordOrIdentifier => true;

        public override Object value() => keyword;
    }

    /**
     * A token that was scanned from the input. Each token knows which tokens
     * precede and follow it, acting as a link in a doubly linked list of tokens.
     */
    public class SimpleToken : Token
    {
        /**
         * The type of the token.
         */
        public override TokenType type { get; }

        /**
         * The offset from the beginning of the file to the first character in the
         * token.
         */
        public override int offset { get; } = 0;

        /**
         * The previous token in the token stream.
         */
        public override Token previous { get; set; }

        public override Token next { get; set; }

        /**
         * Initialize a newly created token to have the given [type] and [offset].
         */
        public SimpleToken(TokenType type, int offset, Token precedingComment = null)
        {
            this.type = type;
            this.offset = offset;
            _setCommentParent(_precedingComment);
        }

        public override int charCount => length;

        public override int charOffset => offset;

        public override int charEnd => end;

        public override int end => offset + length;

        public override Token endGroup => null;

        public override bool isEof => type == TokenType.EOF;

        public override bool isIdentifier => false;

        public override bool isKeyword => false;

        public override bool isKeywordOrIdentifier => isIdentifier;

        public override bool isModifier => type.isModifier;

        public override bool isOperator => type.isOperator;

        public override bool isSynthetic => length == 0;

        public override bool isTopLevelKeyword => type.isTopLevelKeyword;

        public override bool isUserDefinableOperator => type.isUserDefinableOperator;

        public override Keyword keyword => null;

        public override int kind => type.kind;

        public override int length => lexeme.Length;

        public override String lexeme => type.lexeme;

        /**
           * The first comment in the list of comments that precede this token.
           */
        private Token _precedingComment;
        public override Token precedingComments
        {
            get => _precedingComment;
        }

        public void setPrecedingComment(Token token)
        {
            _precedingComment = token;
        }

        public override String stringValue => type.stringValue;

        public override Token beforeSynthetic
        {
            get => null;
            set
            {
                _precedingComment = value;
                _setCommentParent(_precedingComment);
            }
        }


        public override Token copy() =>
          new SimpleToken(type, offset, copyComments(precedingComments));

        public override Token copyComments(Token token)
        {
            if (token == null)
            {
                return null;
            }
            Token head = token.copy();
            Token tail = head;
            token = token.next;
            while (token != null)
            {
                tail = tail.setNext(token.copy());
                token = token.next;
            }
            return head;
        }

        public override bool matchesAny(List<TokenType> types)
        {
            foreach (TokenType type in types)
            {
                if (this.type == type)
                {
                    return true;
                }
            }
            return false;
        }

        public override Token setNext(Token token)
        {
            next = token;
            token.previous = this;
            token.beforeSynthetic = this;
            return token;
        }

        public override Token setNextWithoutSettingPrevious(Token token)
        {
            next = token;
            return token;
        }

        public override String toString() => lexeme;

        public override Object value() => lexeme;

        /**
         * Sets the `parent` property to `this` for the given [comment] and all the
         * next tokens.
         */
        public void _setCommentParent(Token comment)
        {
            while (comment != null)
            {
                (comment as CommentToken).parent = this;
                comment = comment.next;
            }
        }
    }

    /**
     * A token whose value is independent of it's type.
     */
    public class StringToken : SimpleToken
    {
        /**
         * The lexeme represented by this token.
         */
        public String _value;

        /**
         * Initialize a newly created token to represent a token of the given [type]
         * with the given [value] at the given [offset].
         */
        public StringToken(TokenType type, String value, int offset, CommentToken precedingComment = null)
          : base(type, offset, precedingComment)
        {
            this._value = StringUtilities.intern(value);
        }

        public override bool isIdentifier => kind == IDENTIFIER_TOKEN;

        public override String lexeme => _value;

        public override Token copy() =>
           new StringToken(type, _value, offset, (CommentToken)copyComments(precedingComments));

        public String value() => _value;
    }

    /**
     * A synthetic begin token.
     */
    public class SyntheticBeginToken : BeginToken
    {
        /**
         * Initialize a newly created token to have the given [type] at the given
         * [offset].
         */
        public SyntheticBeginToken(TokenType type, int offset,
           CommentToken precedingComment = null)
           : base(type, offset, precedingComment) { }

        public override Token copy() =>
            new SyntheticBeginToken(type, offset, (CommentToken)copyComments(precedingComments));

        public override bool isSynthetic => true;

        public override int length => 0;
    }

    /**
     * A synthetic keyword token.
     */
    public class SyntheticKeywordToken : KeywordToken
    {
        /**
         * Initialize a newly created token to represent the given [keyword] at the
         * given [offset].
         */
        public SyntheticKeywordToken(Keyword keyword, int offset) : base(keyword, offset) { }

        public override int length => 0;

        public override Token copy() => new SyntheticKeywordToken(keyword, offset);
    }

    /**
     * A token whose value is independent of it's type.
     */
    public class SyntheticStringToken : StringToken
    {
        readonly int _length;

        /**
         * Initialize a newly created token to represent a token of the given [type]
         * with the given [value] at the given [offset]. If the [length] is
         * not specified, then it defaults to the length of [value].
         */
        public SyntheticStringToken(TokenType type, String value, int offset, int _length = 0)
          : base(type, value, offset)
        {
            this._length = _length;
        }

        public override bool isSynthetic => true;

        public override int length => _length;

        public override Token copy() => new SyntheticStringToken(type, _value, offset, _length);
    }

    /**
     * A synthetic token.
     */
    public class SyntheticToken : SimpleToken
    {
        public SyntheticToken(TokenType type, int offset) : base(type, offset) { }

        public override bool isSynthetic => true;

        public override int length => 0;

        public override Token copy() => new SyntheticToken(type, offset);
    }

    /**
     * A token that was scanned from the input. Each token knows which tokens
     * precede and follow it, acting as a link in a doubly linked list of tokens.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    abstract public class Token : SyntacticEntity
    {
        /**
         * Initialize a newly created token to have the given [type] and [offset].
         */
        public static Token Token_(TokenType type, int offset, CommentToken preceedingComment = null)
        {
            return new SimpleToken(type, offset, preceedingComment);
        }

        /**
         * Initialize a newly created end-of-file token to have the given [offset].
         */
        public static Token Token_eof(int offset, CommentToken precedingComments = null)
        {
            Token eof = new SimpleToken(TokenType.EOF, offset, precedingComments);
            // EOF points to itself so there's always infinite look-ahead.
            eof.previous = eof;
            eof.next = eof;
            return eof;
        }

        /**
         * The number of characters parsed by this token.
         */
        public abstract int charCount { get; }

        /**
         * The character offset of the start of this token within the source text.
         */
        public abstract int charOffset { get; }

        /**
         * The character offset of the end of this token within the source text.
         */
        public abstract int charEnd { get; }

        /**
         * The token before this synthetic token,
         * or `null` if this is not a synthetic `)`, `]`, `}`, or `>` token.
         */
        public abstract Token beforeSynthetic { get; set; }

        /**
         * The token that corresponds to this token, or `null` if this token is not
         * the first of a pair of matching tokens (such as parentheses).
         */
        public abstract Token endGroup { get; }

        /**
         * Return `true` if this token represents an end of file.
         */
        public abstract bool isEof { get; }

        /**
         * True if this token is an identifier. Some keywords allowed as identifiers,
         * see implementation in [KeywordToken].
         */
        public abstract bool isIdentifier { get; }

        /**
         * True if this token is a keyword. Some keywords allowed as identifiers,
         * see implementation in [KeywordToken].
         */
        public abstract bool isKeyword { get; }

        /**
         * True if this token is a keyword or an identifier.
         */
        public abstract bool isKeywordOrIdentifier { get; }

        /**
         * Return `true` if this token is a modifier such as `abstract` or `const`.
         */
        public abstract bool isModifier { get; }

        /**
         * Return `true` if this token represents an operator.
         */
        public abstract bool isOperator { get; }

        /**
         * Return `true` if this token is a synthetic token. A synthetic token is a
         * token that was introduced by the parser in order to recover from an error
         * in the code.
         */
        public abstract bool isSynthetic { get; }

        /**
         * Return `true` if this token is a keyword starting a top level declaration
         * such as `class`, `enum`, `import`, etc.
         */
        public abstract bool isTopLevelKeyword { get; }

        /**
         * Return `true` if this token represents an operator that can be defined by
         * users.
         */
        public abstract bool isUserDefinableOperator { get; }

        /**
         * Return the keyword, if a keyword token, or `null` otherwise.
         */
        public abstract Keyword keyword { get; }

        /**
         * The kind enum of this token as determined by its [type].
         */
        public abstract int kind { get; }


        /**
         * Return the lexeme that represents this token.
         *
         * For [StringToken]s the [lexeme] includes the quotes, explicit escapes, etc.
         */
        public abstract String lexeme { get; }

        /**
         * Return the next token in the token stream.
         */
        public abstract Token next { get; set; }


        /**
         * Return the first comment in the list of comments that precede this token,
         * or `null` if there are no comments preceding this token. Additional
         * comments can be reached by following the token stream using [next] until
         * `null` is returned.
         *
         * For example, if the original contents were `/ one  / two 
            id`, then
        * the first preceding comment token will have a lexeme of `/* one ` and
        * the next comment token will have a lexeme of `/* two `.
           */
        public abstract Token precedingComments { get; }

        /**
         * Return the previous token in the token stream.
         */
        public abstract Token previous { get; set; }

        /**
         * For symbol and keyword tokens, returns the string value represented by this
         * token. For [StringToken]s this method returns [:null:].
         *
         * For [SymbolToken]s and [KeywordToken]s, the string value is a compile-time
         * constant originating in the [TokenType] or in the [Keyword] instance.
         * This allows testing for keywords and symbols using [:identical:], e.g.,
         * [:identical('class', token.value):].
         *
         * Note that returning [:null:] for string tokens is important to identify
         * symbols and keywords, we cannot use [lexeme] instead. The string literal
         *   "$a($b"
         * produces ..., SymbolToken($), StringToken(a), StringToken((), ...
         *
         * After parsing the identifier 'a', the parser tests for a function
         * declaration using [:identical(next.stringValue, '('):], which (rightfully)
         * returns false because stringValue returns [:null:].
         */
        public abstract String stringValue { get; }

        /**
         * Return the type of the token.
         */
        public abstract TokenType type { get; }

        /**
         * Return a newly created token that is a copy of this tokens
         * including any [preceedingComment] tokens,
         * but that is not a part of any token stream.
         */
        public abstract Token copy();

        /**
         * Copy a linked list of comment tokens identical to the given comment tokens.
         */
        public abstract Token copyComments(Token token);

        /**
         * Return `true` if this token has any one of the given [types].
         */
        public abstract bool matchesAny(List<TokenType> types);

        /**
         * Set the next token in the token stream to the given [token]. This has the
         * side-effect of setting this token to be the previous token for the given
         * token. Return the token that was passed in.
         */
        public abstract Token setNext(Token token);

        /**
         * Set the next token in the token stream to the given token without changing
         * which token is the previous token for the given token. Return the token
         * that was passed in.
         */
        public abstract Token setNextWithoutSettingPrevious(Token token);

        /**
         * Returns a textual representation of this token to be used for debugging
         * purposes. The resulting string might contain information about the
         * structure of the token, for example 'StringToken(foo)' for the identifier
         * token 'foo'.
         *
         * Use [lexeme] for the text actually parsed by the token.
         */
        public abstract String toString();

        /**
         * Return the value of this token. For keyword tokens, this is the keyword
         * associated with the token, for other tokens it is the lexeme associated
         * with the token.
         */
        public abstract Object value();

        /**
         * Compare the given [tokens] to find the token that appears first in the
         * source being parsed. That is, return the left-most of all of the tokens.
         * The list must be non-`null`, but the elements of the list are allowed to be
         * `null`. Return the token with the smallest offset, or `null` if the list is
         * empty or if all of the elements of the list are `null`.
         */
        public static Token lexicallyFirst(List<Token> tokens)
        {
            Token first = null;
            int offset = -1;
            int length = tokens.Count;
            for (int i = 0; i < length; i++)
            {
                Token token = tokens[i];
                if (token != null && (offset < 0 || token.offset < offset))
                {
                    first = token;
                    offset = token.offset;
                }
            }
            return first;
        }
    }

    /**
     * The classes (or groups) of tokens with a similar use.
     */
    public class TokenClass
    {
        /**
         * A value used to indicate that the token type is not part of any specific
         * public class of token.
         */
        public static TokenClass NO_CLASS = new TokenClass("NO_CLASS");

        /**
         * A value used to indicate that the token type is an additive operator.
         */
        public static TokenClass ADDITIVE_OPERATOR =
          new TokenClass("ADDITIVE_OPERATOR", 13);

        /**
         * A value used to indicate that the token type is an assignment operator.
         */
        public static TokenClass ASSIGNMENT_OPERATOR =
          new TokenClass("ASSIGNMENT_OPERATOR", 1);

        /**
         * A value used to indicate that the token type is a bitwise-and operator.
         */
        public static TokenClass BITWISE_AND_OPERATOR =
          new TokenClass("BITWISE_AND_OPERATOR", 11);

        /**
         * A value used to indicate that the token type is a bitwise-or operator.
         */
        public static TokenClass BITWISE_OR_OPERATOR =
          new TokenClass("BITWISE_OR_OPERATOR", 9);

        /**
         * A value used to indicate that the token type is a bitwise-xor operator.
         */
        public static TokenClass BITWISE_XOR_OPERATOR =
          new TokenClass("BITWISE_XOR_OPERATOR", 10);

        /**
         * A value used to indicate that the token type is a cascade operator.
         */
        public static TokenClass CASCADE_OPERATOR =
          new TokenClass("CASCADE_OPERATOR", 2);

        /**
         * A value used to indicate that the token type is a conditional operator.
         */
        public static TokenClass CONDITIONAL_OPERATOR =
          new TokenClass("CONDITIONAL_OPERATOR", 3);

        /**
         * A value used to indicate that the token type is an equality operator.
         */
        public static TokenClass EQUALITY_OPERATOR =
          new TokenClass("EQUALITY_OPERATOR", 7);

        /**
         * A value used to indicate that the token type is an if-null operator.
         */
        public static TokenClass IF_NULL_OPERATOR =
          new TokenClass("IF_NULL_OPERATOR", 4);

        /**
         * A value used to indicate that the token type is a logical-and operator.
         */
        public static TokenClass LOGICAL_AND_OPERATOR =
          new TokenClass("LOGICAL_AND_OPERATOR", 6);

        /**
         * A value used to indicate that the token type is a logical-or operator.
         */
        public static TokenClass LOGICAL_OR_OPERATOR =
          new TokenClass("LOGICAL_OR_OPERATOR", 5);

        /**
         * A value used to indicate that the token type is a multiplicative operator.
         */
        public static TokenClass MULTIPLICATIVE_OPERATOR =
          new TokenClass("MULTIPLICATIVE_OPERATOR", 14);

        /**
         * A value used to indicate that the token type is a relational operator.
         */
        public static TokenClass RELATIONAL_OPERATOR =
          new TokenClass("RELATIONAL_OPERATOR", 8);

        /**
         * A value used to indicate that the token type is a shift operator.
         */
        public static TokenClass SHIFT_OPERATOR =
          new TokenClass("SHIFT_OPERATOR", 12);

        /**
         * A value used to indicate that the token type is a unary operator.
         */
        public static TokenClass UNARY_POSTFIX_OPERATOR =
          new TokenClass("UNARY_POSTFIX_OPERATOR", 16);

        /**
         * A value used to indicate that the token type is a unary operator.
         */
        public static TokenClass UNARY_PREFIX_OPERATOR =
          new TokenClass("UNARY_PREFIX_OPERATOR", 15);

        /**
         * The name of the token class.
         */
        readonly String name;

        /**
         * The precedence of tokens of this class, or `0` if the such tokens do not
         * represent an operator.
         */
        readonly int precedence;

        /**
         * Initialize a newly created public class of tokens to have the given [name] and
         * [precedence].
         */
        public TokenClass(String name, int precedence = 0)
        {
            this.name = name;
            this.precedence = precedence;
        }

        String toString() => name;
    }

    /**
     * The types of tokens that can be returned by the scanner.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public class TokenType
    {
        /**
         * The type of the token that marks the start or end of the input.
         */
        public static TokenType EOF =
          new TokenType("", "EOF", NO_PRECEDENCE, EOF_TOKEN);

        public static TokenType DOUBLE = new TokenType(
      "double", "DOUBLE", NO_PRECEDENCE, DOUBLE_TOKEN,
            stringValue: null);

        public static TokenType HEXADECIMAL = new TokenType(
      "hexadecimal", "HEXADECIMAL", NO_PRECEDENCE, HEXADECIMAL_TOKEN,
            stringValue: null);

        public static TokenType IDENTIFIER = new TokenType(
      "identifier", "STRING_INT", NO_PRECEDENCE, IDENTIFIER_TOKEN,
            stringValue: null);

        public static TokenType INT = new TokenType(
      "int", "INT", NO_PRECEDENCE, INT_TOKEN,
            stringValue: null);

        public static TokenType MULTI_LINE_COMMENT = new TokenType(
      "comment", "MULTI_LINE_COMMENT", NO_PRECEDENCE, COMMENT_TOKEN,
            stringValue: null);

        public static TokenType SCRIPT_TAG =
          new TokenType("script", "SCRIPT_TAG", NO_PRECEDENCE, SCRIPT_TOKEN);

        public static TokenType SINGLE_LINE_COMMENT = new TokenType(
      "comment", "SINGLE_LINE_COMMENT", NO_PRECEDENCE, COMMENT_TOKEN,
            stringValue: null);

        public static TokenType STRING = new TokenType(
      "string", "STRING", NO_PRECEDENCE, STRING_TOKEN,
            stringValue: null);

        public static TokenType AMPERSAND = new TokenType(
      "&", "AMPERSAND", BITWISE_AND_PRECEDENCE, AMPERSAND_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType AMPERSAND_AMPERSAND = new TokenType("&&",
            "AMPERSAND_AMPERSAND", LOGICAL_AND_PRECEDENCE, AMPERSAND_AMPERSAND_TOKEN,
            isOperator: true);

        // This is not yet part of the language and not supported by fasta
        public static TokenType AMPERSAND_AMPERSAND_EQ = new TokenType(
      "&&=",
            "AMPERSAND_AMPERSAND_EQ",
            ASSIGNMENT_PRECEDENCE,
            AMPERSAND_AMPERSAND_EQ_TOKEN,
            isOperator: true);

        public static TokenType AMPERSAND_EQ = new TokenType(
      "&=", "AMPERSAND_EQ", ASSIGNMENT_PRECEDENCE, AMPERSAND_EQ_TOKEN,
            isOperator: true);

        public static TokenType AT =
          new TokenType("@", "AT", NO_PRECEDENCE, AT_TOKEN);

        public static TokenType BANG = new TokenType(
      "!", "BANG", PREFIX_PRECEDENCE, BANG_TOKEN,
            isOperator: true);

        public static TokenType BANG_EQ = new TokenType(
      "!=", "BANG_EQ", EQUALITY_PRECEDENCE, BANG_EQ_TOKEN,
            isOperator: true);

        public static TokenType BANG_EQ_EQ = new TokenType(
      "!==", "BANG_EQ_EQ", EQUALITY_PRECEDENCE, BANG_EQ_EQ_TOKEN);

        public static TokenType BAR = new TokenType(
      "|", "BAR", BITWISE_OR_PRECEDENCE, BAR_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType BAR_BAR = new TokenType(
      "||", "BAR_BAR", LOGICAL_OR_PRECEDENCE, BAR_BAR_TOKEN,
            isOperator: true);

        // This is not yet part of the language and not supported by fasta
        public static TokenType BAR_BAR_EQ = new TokenType(
      "||=", "BAR_BAR_EQ", ASSIGNMENT_PRECEDENCE, BAR_BAR_EQ_TOKEN,
            isOperator: true);

        public static TokenType BAR_EQ = new TokenType(
      "|=", "BAR_EQ", ASSIGNMENT_PRECEDENCE, BAR_EQ_TOKEN,
            isOperator: true);

        public static TokenType COLON =
          new TokenType(":", "COLON", NO_PRECEDENCE, COLON_TOKEN);

        public static TokenType COMMA =
          new TokenType(",", "COMMA", NO_PRECEDENCE, COMMA_TOKEN);

        public static TokenType CARET = new TokenType(
      "^", "CARET", BITWISE_XOR_PRECEDENCE, CARET_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType CARET_EQ = new TokenType(
      "^=", "CARET_EQ", ASSIGNMENT_PRECEDENCE, CARET_EQ_TOKEN,
            isOperator: true);

        public static TokenType CLOSE_CURLY_BRACKET = new TokenType(
      "}", "CLOSE_CURLY_BRACKET", NO_PRECEDENCE, CLOSE_CURLY_BRACKET_TOKEN);

        public static TokenType CLOSE_PAREN =
          new TokenType(")", "CLOSE_PAREN", NO_PRECEDENCE, CLOSE_PAREN_TOKEN);

        public static TokenType CLOSE_SQUARE_BRACKET = new TokenType(
      "]", "CLOSE_SQUARE_BRACKET", NO_PRECEDENCE, CLOSE_SQUARE_BRACKET_TOKEN);

        public static TokenType EQ = new TokenType(
      "=", "EQ", ASSIGNMENT_PRECEDENCE, EQ_TOKEN,
            isOperator: true);

        public static TokenType EQ_EQ = new TokenType(
      "==", "EQ_EQ", EQUALITY_PRECEDENCE, EQ_EQ_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        /// The `===` operator is not supported in the Dart language
        /// but is parsed as such by the scanner to support better recovery
        /// when a JavaScript code snippet is pasted into a Dart file.
        public static TokenType EQ_EQ_EQ =
          new TokenType("===", "EQ_EQ_EQ", EQUALITY_PRECEDENCE, EQ_EQ_EQ_TOKEN);

        public static TokenType FUNCTION =
          new TokenType("=>", "FUNCTION", NO_PRECEDENCE, FUNCTION_TOKEN);

        public static TokenType GT = new TokenType(
      ">", "GT", RELATIONAL_PRECEDENCE, GT_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType GT_EQ = new TokenType(
      ">=", "GT_EQ", RELATIONAL_PRECEDENCE, GT_EQ_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType GT_GT = new TokenType(
      ">>", "GT_GT", SHIFT_PRECEDENCE, GT_GT_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType GT_GT_EQ = new TokenType(
      ">>=", "GT_GT_EQ", ASSIGNMENT_PRECEDENCE, GT_GT_EQ_TOKEN,
            isOperator: true);

        public static TokenType HASH =
          new TokenType("#", "HASH", NO_PRECEDENCE, HASH_TOKEN);

        public static TokenType INDEX = new TokenType(
      "[]", "INDEX", SELECTOR_PRECEDENCE, INDEX_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType INDEX_EQ = new TokenType(
      "[]=", "INDEX_EQ", NO_PRECEDENCE, INDEX_EQ_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType LT = new TokenType(
      "<", "LT", RELATIONAL_PRECEDENCE, LT_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType LT_EQ = new TokenType(
      "<=", "LT_EQ", RELATIONAL_PRECEDENCE, LT_EQ_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType LT_LT = new TokenType(
      "<<", "LT_LT", SHIFT_PRECEDENCE, LT_LT_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType LT_LT_EQ = new TokenType(
      "<<=", "LT_LT_EQ", ASSIGNMENT_PRECEDENCE, LT_LT_EQ_TOKEN,
            isOperator: true);

        public static TokenType MINUS = new TokenType(
      "-", "MINUS", ADDITIVE_PRECEDENCE, MINUS_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType MINUS_EQ = new TokenType(
      "-=", "MINUS_EQ", ASSIGNMENT_PRECEDENCE, MINUS_EQ_TOKEN,
            isOperator: true);

        public static TokenType MINUS_MINUS = new TokenType(
      "--", "MINUS_MINUS", POSTFIX_PRECEDENCE, MINUS_MINUS_TOKEN,
            isOperator: true);

        public static TokenType OPEN_CURLY_BRACKET = new TokenType(
      "{", "OPEN_CURLY_BRACKET", NO_PRECEDENCE, OPEN_CURLY_BRACKET_TOKEN);

        public static TokenType OPEN_PAREN =
          new TokenType("(", "OPEN_PAREN", SELECTOR_PRECEDENCE, OPEN_PAREN_TOKEN);

        public static TokenType OPEN_SQUARE_BRACKET = new TokenType("[",
            "OPEN_SQUARE_BRACKET", SELECTOR_PRECEDENCE, OPEN_SQUARE_BRACKET_TOKEN);

        public static TokenType PERCENT = new TokenType(
      "%", "PERCENT", MULTIPLICATIVE_PRECEDENCE, PERCENT_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType PERCENT_EQ = new TokenType(
      "%=", "PERCENT_EQ", ASSIGNMENT_PRECEDENCE, PERCENT_EQ_TOKEN,
            isOperator: true);

        public static TokenType PERIOD =
          new TokenType(".", "PERIOD", SELECTOR_PRECEDENCE, PERIOD_TOKEN);

        public static TokenType PERIOD_PERIOD = new TokenType(
      "..", "PERIOD_PERIOD", CASCADE_PRECEDENCE, PERIOD_PERIOD_TOKEN,
            isOperator: true);

        public static TokenType PLUS = new TokenType(
      "+", "PLUS", ADDITIVE_PRECEDENCE, PLUS_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType PLUS_EQ = new TokenType(
      "+=", "PLUS_EQ", ASSIGNMENT_PRECEDENCE, PLUS_EQ_TOKEN,
            isOperator: true);

        public static TokenType PLUS_PLUS = new TokenType(
      "++", "PLUS_PLUS", POSTFIX_PRECEDENCE, PLUS_PLUS_TOKEN,
            isOperator: true);

        public static TokenType QUESTION = new TokenType(
      "?", "QUESTION", CONDITIONAL_PRECEDENCE, QUESTION_TOKEN,
            isOperator: true);

        public static TokenType QUESTION_PERIOD = new TokenType(
      "?.", "QUESTION_PERIOD", SELECTOR_PRECEDENCE, QUESTION_PERIOD_TOKEN,
            isOperator: true);

        public static TokenType QUESTION_QUESTION = new TokenType(
      "??", "QUESTION_QUESTION", IF_NULL_PRECEDENCE, QUESTION_QUESTION_TOKEN,
            isOperator: true);

        public static TokenType QUESTION_QUESTION_EQ = new TokenType("??=",
            "QUESTION_QUESTION_EQ", ASSIGNMENT_PRECEDENCE, QUESTION_QUESTION_EQ_TOKEN,
            isOperator: true);

        public static TokenType SEMICOLON =
          new TokenType(";", "SEMICOLON", NO_PRECEDENCE, SEMICOLON_TOKEN);

        public static TokenType SLASH = new TokenType(
      "/", "SLASH", MULTIPLICATIVE_PRECEDENCE, SLASH_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType SLASH_EQ = new TokenType(
      "/=", "SLASH_EQ", ASSIGNMENT_PRECEDENCE, SLASH_EQ_TOKEN,
            isOperator: true);

        public static TokenType STAR = new TokenType(
      "*", "STAR", MULTIPLICATIVE_PRECEDENCE, STAR_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType STAR_EQ = new TokenType(
      "*=", "STAR_EQ", ASSIGNMENT_PRECEDENCE, STAR_EQ_TOKEN,
            isOperator: true);

        public static TokenType STRING_INTERPOLATION_EXPRESSION = new TokenType(
      "${",
            "STRING_INTERPOLATION_EXPRESSION",
            NO_PRECEDENCE,
            STRING_INTERPOLATION_TOKEN);

        public static TokenType STRING_INTERPOLATION_IDENTIFIER = new TokenType(
      "$",
            "STRING_INTERPOLATION_IDENTIFIER",
            NO_PRECEDENCE,
            STRING_INTERPOLATION_IDENTIFIER_TOKEN);

        public static TokenType TILDE = new TokenType(
      "~", "TILDE", PREFIX_PRECEDENCE, TILDE_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType TILDE_SLASH = new TokenType(
      "~/", "TILDE_SLASH", MULTIPLICATIVE_PRECEDENCE, TILDE_SLASH_TOKEN,
            isOperator: true, isUserDefinableOperator: true);

        public static TokenType TILDE_SLASH_EQ = new TokenType(
      "~/=", "TILDE_SLASH_EQ", ASSIGNMENT_PRECEDENCE, TILDE_SLASH_EQ_TOKEN,
            isOperator: true);

        public static TokenType BACKPING =
          new TokenType("`", "BACKPING", NO_PRECEDENCE, BACKPING_TOKEN);

        public static TokenType BACKSLASH =
          new TokenType("\\", "BACKSLASH", NO_PRECEDENCE, BACKSLASH_TOKEN);

        public static TokenType PERIOD_PERIOD_PERIOD = new TokenType(
      "...", "PERIOD_PERIOD_PERIOD", NO_PRECEDENCE, PERIOD_PERIOD_PERIOD_TOKEN);

        public static TokenType AS = Keyword.AS;

        public static TokenType IS = Keyword.IS;

        /**
         * Token type used by error tokens.
         */
        public static TokenType BAD_INPUT = new TokenType(
      "malformed input", "BAD_INPUT", NO_PRECEDENCE, BAD_INPUT_TOKEN,
            stringValue: null);

        /**
         * Token type used by synthetic tokens that are created during parser
         * recovery (non-analyzer use case).
         */
        public static TokenType RECOVERY = new TokenType(
      "recovery", "RECOVERY", NO_PRECEDENCE, RECOVERY_TOKEN,
            stringValue: null);

        // TODO(danrubel): "all" is misleading
        // because this list does not include all TokenType instances.
        public static List<TokenType> all = new List<TokenType> {
                                  TokenType.EOF,
                                  TokenType.DOUBLE,
                                  TokenType.HEXADECIMAL,
                                  TokenType.IDENTIFIER,
                                  TokenType.INT,
                                  TokenType.MULTI_LINE_COMMENT,
                                  TokenType.SCRIPT_TAG,
                                  TokenType.SINGLE_LINE_COMMENT,
                                  TokenType.STRING,
                                  TokenType.AMPERSAND,
                                  TokenType.AMPERSAND_AMPERSAND,
                                  TokenType.AMPERSAND_EQ,
                                  TokenType.AT,
                                  TokenType.BANG,
                                  TokenType.BANG_EQ,
                                  TokenType.BAR,
                                  TokenType.BAR_BAR,
                                  TokenType.BAR_EQ,
                                  TokenType.COLON,
                                  TokenType.COMMA,
                                  TokenType.CARET,
                                  TokenType.CARET_EQ,
                                  TokenType.CLOSE_CURLY_BRACKET,
                                  TokenType.CLOSE_PAREN,
                                  TokenType.CLOSE_SQUARE_BRACKET,
                                  TokenType.EQ,
                                  TokenType.EQ_EQ,
                                  TokenType.FUNCTION,
                                  TokenType.GT,
                                  TokenType.GT_EQ,
                                  TokenType.GT_GT,
                                  TokenType.GT_GT_EQ,
                                  TokenType.HASH,
                                  TokenType.INDEX,
                                  TokenType.INDEX_EQ,
                                  TokenType.LT,
                                  TokenType.LT_EQ,
                                  TokenType.LT_LT,
                                  TokenType.LT_LT_EQ,
                                  TokenType.MINUS,
                                  TokenType.MINUS_EQ,
                                  TokenType.MINUS_MINUS,
                                  TokenType.OPEN_CURLY_BRACKET,
                                  TokenType.OPEN_PAREN,
                                  TokenType.OPEN_SQUARE_BRACKET,
                                  TokenType.PERCENT,
                                  TokenType.PERCENT_EQ,
                                  TokenType.PERIOD,
                                  TokenType.PERIOD_PERIOD,
                                  TokenType.PLUS,
                                  TokenType.PLUS_EQ,
                                  TokenType.PLUS_PLUS,
                                  TokenType.QUESTION,
                                  TokenType.QUESTION_PERIOD,
                                  TokenType.QUESTION_QUESTION,
                                  TokenType.QUESTION_QUESTION_EQ,
                                  TokenType.SEMICOLON,
                                  TokenType.SLASH,
                                  TokenType.SLASH_EQ,
                                  TokenType.STAR,
                                  TokenType.STAR_EQ,
                                  TokenType.STRING_INTERPOLATION_EXPRESSION,
                                  TokenType.STRING_INTERPOLATION_IDENTIFIER,
                                  TokenType.TILDE,
                                  TokenType.TILDE_SLASH,
                                  TokenType.TILDE_SLASH_EQ,
                                  TokenType.BACKPING,
                                  TokenType.BACKSLASH,
                                  TokenType.PERIOD_PERIOD_PERIOD };

        // TODO(danrubel): Should these be added to the "all" list?
        //TokenType.IS,
        //TokenType.AS,

        // These are not yet part of the language and not supported by fasta
        //TokenType.AMPERSAND_AMPERSAND_EQ,
        //TokenType.BAR_BAR_EQ,

        // Supported by fasta but not part of the language
        //TokenType.BANG_EQ_EQ,
        //TokenType.EQ_EQ_EQ,

        // Used by synthetic tokens generated during recovery
        //TokenType.BAD_INPUT,
        //TokenType.RECOVERY,

        public readonly int kind;

        /**
         * `true` if this token type represents a modifier
         * such as `abstract` or `const`.
         */
        public readonly bool isModifier;

        /**
         * `true` if this token type represents an operator.
         */
        public readonly bool isOperator;

        /**
         * `true` if this token type represents a keyword starting a top level
         * declaration such as `class`, `enum`, `import`, etc.
         */
        public readonly bool isTopLevelKeyword;

        /**
         * `true` if this token type represents an operator
         * that can be defined by users.
         */
        public readonly bool isUserDefinableOperator;

        /**
         * The lexeme that defines this type of token,
         * or `null` if there is more than one possible lexeme for this type of token.
         */
        public readonly String lexeme;

        /**
         * The name of the token type.
         */
        public readonly String name;

        /**
         * The precedence of this type of token,
         * or `0` if the token does not represent an operator.
         */
        public readonly int precedence;

        /**
         * See [Token.stringValue] for an explanation.
         */
        public readonly String stringValue;

        public TokenType(String lexeme,
                         String name,
                         int precedence,
                         int kind,
                         bool isModifier = false,
                         bool isOperator = false,
                         bool isTopLevelKeyword = false,
                         bool isUserDefinableOperator = false,
                         String stringValue = "unspecified")
        {
            this.lexeme = lexeme;
            this.name = name;
            this.precedence = precedence;
            this.kind = kind;
            this.isModifier = isModifier;
            this.isOperator = isOperator;
            this.isTopLevelKeyword = isTopLevelKeyword;
            this.isUserDefinableOperator = isUserDefinableOperator;

            this.stringValue = stringValue == "unspecified" ? lexeme : stringValue;
        }


        /**
         * Return `true` if this type of token represents an additive operator.
         */
        public bool isAdditiveOperator => precedence == ADDITIVE_PRECEDENCE;

        /**
         * Return `true` if this type of token represents an assignment operator.
         */
        public bool isAssignmentOperator => precedence == ASSIGNMENT_PRECEDENCE;

        /**
         * Return `true` if this type of token represents an associative operator. An
         * associative operator is an operator for which the following equality is
         * true: `(a * b) * c == a * (b * c)`. In other words, if the result of
         * applying the operator to multiple operands does not depend on the order in
         * which those applications occur.
         *
         * Note: This method considers the logical-and and logical-or operators to be
         * associative, even though the order in which the application of those
         * operators can have an effect because evaluation of the right-hand operand
         * is conditional.
         */
        public bool sAssociativeOperator =>
                      this == TokenType.AMPERSAND ||
                      this == TokenType.AMPERSAND_AMPERSAND ||
                      this == TokenType.BAR ||
                      this == TokenType.BAR_BAR ||
                      this == TokenType.CARET ||
                      this == TokenType.PLUS ||
                      this == TokenType.STAR;

        /**
         * A flag indicating whether the keyword is a "built-in" identifier.
         */
        public bool isBuiltIn => false;

        /**
         * Return `true` if this type of token represents an equality operator.
         */
        public bool isEqualityOperator =>
        this == TokenType.BANG_EQ || this == TokenType.EQ_EQ;

        /**
         * Return `true` if this type of token represents an increment operator.
         */
        public bool isIncrementOperator =>
                        this == TokenType.PLUS_PLUS || this == TokenType.MINUS_MINUS;

        /**
         * Return `true` if this type of token is a keyword.
         */
        public bool isKeyword => kind == KEYWORD_TOKEN;

        /**
         * A flag indicating whether the keyword can be used as an identifier
         * in some situations.
         */
        public bool isPseudo => false;

        /**
         * Return `true` if this type of token represents a multiplicative operator.
         */
        public bool isMultiplicativeOperator => precedence == MULTIPLICATIVE_PRECEDENCE;

        /**
         * Return `true` if this type of token represents a relational operator.
         */
        public bool isRelationalOperator =>
            this == TokenType.LT ||
            this == TokenType.LT_EQ ||
            this == TokenType.GT ||
            this == TokenType.GT_EQ;

        /**
         * Return `true` if this type of token represents a shift operator.
         */
        public bool isShiftOperator => precedence == SHIFT_PRECEDENCE;

        /**
         * Return `true` if this type of token represents a unary postfix operator.
         */
        public bool isUnaryPostfixOperator => precedence == POSTFIX_PRECEDENCE;

        /**
         * Return `true` if this type of token represents a unary prefix operator.
         */
        public bool isUnaryPrefixOperator =>
                      precedence == PREFIX_PRECEDENCE ||
                      this == TokenType.MINUS ||
                      this == TokenType.PLUS_PLUS ||
                      this == TokenType.MINUS_MINUS;

        /**
         * Return `true` if this type of token represents a selector operator
         * (starting token of a selector).
         */
        public bool isSelectorOperator => precedence == SELECTOR_PRECEDENCE;

        public String toString() => name;

        /**
         * Use [lexeme] instead of this method
         */
        public String value => lexeme;
    }
}