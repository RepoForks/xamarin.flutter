using System;
using System.Collections.Generic;
using static Dart2CSharpTranspiler.Parser.TokenConstants;

//https://github.com/dart-lang/sdk/blob/master/pkg/front_end/lib/src/fasta/scanner/token.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2011, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    //    library fasta.scanner.token;

    //    import '../../scanner/token.dart' as analyzer;
    //import '../../scanner/token.dart' show Token, TokenType;

    //    import 'token_constants.dart' show IDENTIFIER_TOKEN;

    //    import 'string_canonicalizer.dart';

    /**
     * A String-valued token. Represents identifiers, string literals,
     * number literals, comments, and error tokens, using the corresponding
     * precedence info.
     */
    public class StringToken : Dart2CSharpTranspiler.StringToken
    {
        /**
         * The length threshold above which substring tokens are computed lazily.
         *
         * For string tokens that are substrings of the program source, the actual
         * substring extraction is performed lazily. This is beneficial because
         * not all scanned code are actually used. For unused parts, the substrings
         * are never computed and allocated.
         */
        public const int LAZY_THRESHOLD = 4;

        /* String | LazySubtring */
        String valueOrLazySubstring;

        /**
         * Creates a non-lazy string token. If [canonicalize] is true, the string
         * is canonicalized before the token is created.
         */
        //  StringToken.fromString(TokenType type, String value, int charOffset,
        //    { bool canonicalize: false, analyzer.CommentToken precedingComments})
        //: valueOrLazySubstring =
        //      canonicalizedString(value, 0, value.length, canonicalize),
        //  super(type, charOffset, precedingComments);

        /**
         * Creates a lazy string token. If [canonicalize] is true, the string
         * is canonicalized before the token is created.
         */
        //    StringToken.fromSubstring(
        //        TokenType type, String data, int start, int end, int charOffset,
        //      { bool canonicalize: false, analyzer.CommentToken precedingComments})
        //      : super(type, charOffset, precedingComments)
        //{
        //    int length = end - start;
        //    if (length <= LAZY_THRESHOLD)
        //    {
        //        valueOrLazySubstring =
        //            canonicalizedString(data, start, end, canonicalize);
        //    }
        //    else
        //    {
        //        valueOrLazySubstring =
        //            new _LazySubstring(data, start, length, canonicalize);
        //    }
        //}

        /**
         * Creates a lazy string token. If [asciiOnly] is false, the byte array
         * is passed through a UTF-8 decoder.
         */
        //StringToken.fromUtf8Bytes(TokenType type, List<int> data, int start, int end,
        //    bool asciiOnly, int charOffset,
        //      { analyzer.CommentToken precedingComments})
        //      : super(type, charOffset, precedingComments)
        //{
        //    int length = end - start;
        //    if (length <= LAZY_THRESHOLD)
        //    {
        //        valueOrLazySubstring = decodeUtf8(data, start, end, asciiOnly);
        //    }
        //    else
        //    {
        //        valueOrLazySubstring = new _LazySubstring(data, start, length, asciiOnly);
        //    }
        //}

        public StringToken(TokenType type, 
                           string valueOrLazySubstring,
                           int charOffset,
                           Dart2CSharpTranspiler.CommentToken precedingComments = null)
              : base(type, valueOrLazySubstring, charOffset, precedingComments)
        {
            this.valueOrLazySubstring = valueOrLazySubstring;
        }

        //@override
        //String get lexeme {
        //    if (valueOrLazySubstring is String)
        //    {
        //        return valueOrLazySubstring;
        //    }
        //    else
        //    {
        //        assert(valueOrLazySubstring is _LazySubstring);
        //        var data = valueOrLazySubstring.data;
        //        int start = valueOrLazySubstring.start;
        //        int end = start + valueOrLazySubstring.length;
        //        if (data is String)
        //        {
        //            valueOrLazySubstring = canonicalizedString(
        //                data, start, end, valueOrLazySubstring.boolValue);
        //        }
        //        else
        //        {
        //            valueOrLazySubstring =
        //                decodeUtf8(data, start, end, valueOrLazySubstring.boolValue);
        //        }
        //        return valueOrLazySubstring;
        //    }
        //}

        public bool isIdentifier => kind == IDENTIFIER_TOKEN;

        public virtual String toString() => lexeme;

        public static readonly StringCanonicalizer canonicalizer = new StringCanonicalizer();

        //static String canonicalizedString(
        //    String s, int start, int end, bool canonicalize)
        //{
        //    if (!canonicalize) return s;
        //    return canonicalizer.canonicalize(s, start, end, false);
        //}

        //static String decodeUtf8(List<int> data, int start, int end, bool asciiOnly)
        //{
        //    return canonicalizer.canonicalize(data, start, end, asciiOnly);
        //}

        public virtual Token copy() => new StringToken(
            type, valueOrLazySubstring, charOffset, (Dart2CSharpTranspiler.CommentToken)copyComments(precedingComments));


        public virtual String value() => lexeme;
    }

    /**
     * A String-valued token that does not exist in the original source.
     */
    //public class SyntheticStringToken : Dart2CSharpTranspiler.SyntheticStringToken
    //{
        //SyntheticStringToken(TokenType type, String value, int offset,
        //  [analyzer.CommentToken precedingComments])
        //  : super._(type, value, offset, precedingComments);


        //public int length => 0;

        //public virtual Token copy() => new SyntheticStringToken(
        //    type, valueOrLazySubstring, offset, copyComments(precedingComments));
   //}

    //public class CommentToken : Dart2CSharpTranspiler.CommentToken
    //{

    //    public Dart2CSharpTranspiler.SimpleToken parent;

        /**
         * Creates a lazy comment token. If [canonicalize] is true, the string
         * is canonicalized before the token is created.
         */
        //  CommentToken.fromSubstring(
        //    TokenType type, String data, int start, int end, int charOffset,
        //    { bool canonicalize: false})
        //: super.fromSubstring(type, data, start, end, charOffset,
        //      canonicalize: canonicalize);

        /**
         * Creates a non-lazy comment token.
         */
        //CommentToken.fromString(TokenType type, String lexeme, int charOffset)
        //  : super.fromString(type, lexeme, charOffset);

        /**
         * Creates a lazy string token. If [asciiOnly] is false, the byte array
         * is passed through a UTF-8 decoder.
         */
        //CommentToken.fromUtf8Bytes(TokenType type, List<int> data, int start, int end,
        //  bool asciiOnly, int charOffset)
        //  : super.fromUtf8Bytes(type, data, start, end, asciiOnly, charOffset);

        //CommentToken._(TokenType type, valueOrLazySubstring, int charOffset)
        //  : super._(type, valueOrLazySubstring, charOffset);

        //      @override
        //    CommentToken copy() =>
        //        new CommentToken._(type, valueOrLazySubstring, charOffset);

        //      @override
        //void remove()
        //      {
        //          if (previous != null)
        //          {
        //              previous.setNextWithoutSettingPrevious(next);
        //              next?.previous = previous;
        //          }
        //          else
        //          {
        //              assert(parent.precedingComments == this);
        //              parent.precedingComments = next as CommentToken;
        //          }
        //      }
    //}

    //public class DartDocToken : Dart2CSharpTranspiler.DocumentationCommentToken
    //{
        /**
         * Creates a lazy comment token. If [canonicalize] is true, the string
         * is canonicalized before the token is created.
         */
        //  DartDocToken.fromSubstring(
        //TokenType type, String data, int start, int end, int charOffset,
        //{ bool canonicalize: false})
        //: super.fromSubstring(type, data, start, end, charOffset,
        //      canonicalize: canonicalize);

        /**
         * Creates a lazy string token. If [asciiOnly] is false, the byte array
         * is passed through a UTF-8 decoder.
         */
        //  DartDocToken.fromUtf8Bytes(TokenType type, List<int> data, int start, int end,
        //bool asciiOnly, int charOffset)
        //: super.fromUtf8Bytes(type, data, start, end, asciiOnly, charOffset);

        //  DartDocToken._(TokenType type, valueOrLazySubstring, int charOffset)
        //: super._(type, valueOrLazySubstring, charOffset);


        //public virtual DartDocToken copy() =>
        //    new DartDocToken._(type, valueOrLazySubstring, charOffset);
    //}

    /**
     * This class represents the necessary information to compute a substring
     * lazily. The substring can either originate from a string or from
     * a [:List<int>:] of UTF-8 bytes.
     */
    public abstract class _LazySubstring
    {
        /** The original data, either a string or a List<int> */
        //      get data;

        //      int get start;
        //int get length;

        /**
         * If this substring is based on a String, the [boolValue] indicates whether
         * the resulting substring should be canonicalized.
         *
         * For substrings based on a byte array, the [boolValue] is true if the
         * array only holds ASCII characters. The resulting substring will be
         * canonicalized after decoding.
         */
        //bool get boolValue;

        //_LazySubstring.internal ();

        //factory _LazySubstring(data, int start, int length, bool b)
        //      {
        //          // See comment on [CompactLazySubstring].
        //          if (start < 0x100000 && length < 0x200)
        //          {
        //              int fields = (start << 9);
        //              fields = fields | length;
        //              fields = fields << 1;
        //              if (b) fields |= 1;
        //              return new _CompactLazySubstring(data, fields);
        //          }
        //          else
        //          {
        //              return new _FullLazySubstring(data, start, length, b);
        //          }
        //      }
        //  }

        /**
         * This class encodes [start], [length] and [boolValue] in a single
         * 30 bit integer. It uses 20 bits for [start], which covers source files
         * of 1MB. [length] has 9 bits, which covers 512 characters.
         *
         * The file html_dart2js.dart is currently around 1MB.
         */
        public class _CompactLazySubstring : _LazySubstring
        {
            //  final data;
            //  final int fields;

            //  _CompactLazySubstring(this.data, this.fields) : super.internal ();

            //int start => fields >> 10;
            //int length => (fields >> 1) & 0x1ff;
            //bool boolValue => (fields & 1) == 1;
        }

        public class _FullLazySubstring : _LazySubstring
        {
            //final data;
            //final int start;
            //final int length;
            //final bool boolValue;
            //    _FullLazySubstring(this.data, this.start, this.length, this.boolValue)
            //      : super.internal ();
            //}

            //bool isUserDefinableOperator(String value)
            //{
            //    return isBinaryOperator(value) ||
            //        isMinusOperator(value) ||
            //        isTernaryOperator(value) ||
            //        isUnaryOperator(value);
            //}

            //bool isUnaryOperator(String value) => identical(value, "~");

            bool identical(string first, string second) => first == second;

            public bool isBinaryOperator(String value)
            {
                return identical(value, "==") ||
                    identical(value, "[]") ||
                    identical(value, "*") ||
                    identical(value, "/") ||
                    identical(value, "%") ||
                    identical(value, "~/") ||
                    identical(value, "+") ||
                    identical(value, "<<") ||
                    identical(value, ">>") ||
                    identical(value, ">=") ||
                    identical(value, ">") ||
                    identical(value, "<=") ||
                    identical(value, "<") ||
                    identical(value, "&") ||
                    identical(value, "^") ||
                    identical(value, "|");
            }

            bool isTernaryOperator(String value) => identical(value, "[]=");

            bool isMinusOperator(String value) => identical(value, "-");
        }
    }
}