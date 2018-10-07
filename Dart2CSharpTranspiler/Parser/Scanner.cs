using System;
using System.Collections.Generic;

// https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/dart/scanner/scanner.dart

namespace Dart2CSharpTranspiler.Parser
{
    //library analyzer.src.dart.scanner.scanner;

    //import 'package:analyzer/error/error.dart';
    //import 'package:analyzer/error/listener.dart';
    //import 'package:analyzer/src/dart/error/syntactic_errors.dart';
    //import 'package:analyzer/src/dart/scanner/reader.dart';
    //import 'package:analyzer/src/generated/source.dart';
    //import 'package:front_end/src/fasta/scanner.dart' as fasta;
    //import 'package:front_end/src/scanner/errors.dart' show translateErrorToken;
    //import 'package:front_end/src/scanner/token.dart' show Token, TokenType;

    //export 'package:analyzer/src/dart/error/syntactic_errors.dart';

    /**
     * The class `Scanner` implements a scanner for Dart code.
     *
     * The lexical structure of Dart is ambiguous without knowledge of the context
     * in which a token is being scanned. For example, without context we cannot
     * determine whether source of the form "<<" should be scanned as a single
     * left-shift operator or as two left angle brackets. This scanner does not have
     * any context, so it always resolves such conflicts by scanning the longest
     * possible token.
     */
    public class Scanner
    {
        public readonly Source source;

        /**
         * The text to be scanned.
         */
        readonly String _contents;

        /**
         * The offset of the first character from the reader.
         */
        readonly int _readerOffset;

        /**
         * The error listener that will be informed of any errors that are found
         * during the scan.
         */
        readonly AnalysisErrorListener _errorListener;

        /**
         * The flag specifying whether documentation comments should be parsed.
         */
        bool _preserveComments = true;

        public readonly List<int> lineStarts = new List<int> { };

        public Token firstToken;

        public bool scanLazyAssignmentOperators = false;

        /**
         * Initialize a newly created scanner to scan characters from the given
         * [source]. The given character [reader] will be used to read the characters
         * in the source. The given [_errorListener] will be informed of any errors
         * that are found.
         */
        public Scanner(Source source,
                       CharacterReader reader,
                       AnalysisErrorListener errorListener)
        {
            this.source = source;
            this._contents = reader.getContents();
            this._readerOffset = reader.offset;
            this._errorListener = errorListener;
        }

        public Scanner(Source source,
                             AnalysisErrorListener errorListener,
                             String contents = "",
                             int offset = -1)
        {
            this.source = source;
            this._contents = contents ?? source.contents.data;
            this._readerOffset = offset;
            this._errorListener = errorListener;
        }

        public Scanner(Source source, string _contents, int _readerOffset, AnalysisErrorListener _errorListener)
        {
            this.source = source;
            this._contents = _contents;
            this._readerOffset = _readerOffset;
            this._errorListener = _errorListener;

            lineStarts.Add(0);
        }

        public void preserveComments(bool preserveComments)
        {
            this._preserveComments = preserveComments;
        }

        public void reportError(
            ScannerErrorCode errorCode, int offset, List<Object> arguments)
        {
            _errorListener
                .onError(new AnalysisError(source, offset, 1, errorCode, arguments));
        }

        public void setSourceStart(int line, int column)
        {
            int offset = _readerOffset;
            if (line < 1 || column < 1 || offset < 0 || (line + column - 2) >= offset)
            {
                return;
            }
            lineStarts.RemoveAt(0);
            for (int i = 2; i < line; i++)
            {
                lineStarts.Add(1);
            }
            lineStarts.Add(offset - column + 1);
        }

        public Token tokenize()
        {
            FastaScannerResult result = fasta.scanString(_contents,
                includeComments: _preserveComments,
                scanLazyAssignmentOperators: scanLazyAssignmentOperators);

            // fasta pretends there is an additional line at EOF
            result.lineStarts.Remove(result.lineStarts.Count - 1);

            // for compatibility, there is already a first entry in lineStarts
            result.lineStarts.RemoveAt(0);

            lineStarts.AddRange(result.lineStarts);
            Token token = result.tokens;
            // The default recovery strategy used by scanString
            // places all error tokens at the head of the stream.
            while (token.type == TokenType.BAD_INPUT)
            {
                translateErrorToken(token, reportError);
                token = token.next;
            }
            firstToken = token;
            // Update all token offsets based upon the reader's starting offset
            if (_readerOffset != -1)
            {
                int delta = _readerOffset + 1;
                do
                {
                    token.offset += delta;
                    token = token.next;
                } while (!token.isEof);
            }
            return firstToken;
        }
    }


    // https://github.com/dart-lang/sdk/blob/master/pkg/front_end/lib/src/fasta/scanner.dart



    //public const int unicodeReplacementCharacter = unicodeReplacementCharacterRune;

    public delegate Token Recover(List<int> bytes, Token tokens, List<int> lineStarts);

    public abstract class FastaScanner
    {
        /// Returns true if an error occured during [tokenize].
        public abstract bool hasErrors { get; }

        public abstract List<int> lineStarts { get; }

        public abstract Token tokenize();
    }

    public class FastaScannerResult
    {
        public readonly Token tokens;
        public readonly List<int> lineStarts;
        public readonly bool hasErrors;

        public FastaScannerResult(Token tokens, List<int> lineStarts, bool hasErrors)
        {
            this.tokens = tokens;
            this.lineStarts = lineStarts;
            this.hasErrors = hasErrors;
        }
    }

    /// Scan/tokenize the given UTF8 [bytes].
    /// If [recover] is null, then the [defaultRecoveryStrategy] is used.
    public ScannerResult scan(List<int> bytes,
         bool includeComments = false, Recover recover = null)
    {
        if (bytes.last != 0)
        {
            throw new ArgumentException("[bytes]: the last byte must be null.");
        }
        Scanner scanner =
            new Utf8BytesScanner(bytes, includeComments: includeComments);
        return _tokenizeAndRecover(scanner, recover, bytes: bytes);
    }

    /// Scan/tokenize the given [source].
    /// If [recover] is null, then the [defaultRecoveryStrategy] is used.
    public ScannerResult scanString(String source,
        bool includeComments = false,
    bool scanLazyAssignmentOperators = false,
    Recover recover = null)
    {
        //assert(source != null, "source must not be null");
        StringScanner scanner =
            new StringScanner(source, includeComments: includeComments);
        return _tokenizeAndRecover(scanner, recover, source: source);
    }

    public ScannerResult _tokenizeAndRecover(Scanner scanner, Recover recover,
       List<int> bytes = null, String source = "")
    {
        Token tokens = scanner.tokenize();
        if (scanner.hasErrors)
        {
            if (bytes == null) bytes = utf8.encode(source);
            recover ??= defaultRecoveryStrategy;
            tokens = recover(bytes, tokens, scanner.lineStarts);
        }
        return new ScannerResult(tokens, scanner.lineStarts, scanner.hasErrors);
    }
}