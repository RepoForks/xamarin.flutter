using System;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/dart/scanner/reader.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2014, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    //    library analyzer.src.dart.scanner.reader;

    //    import 'package:front_end/src/scanner/reader.dart';

    //export 'package:front_end/src/scanner/reader.dart'
    //    show CharacterReader, CharSequenceReader, SubSequenceReader;

    /**
     * A [CharacterReader] that reads a range of characters from another character
     * reader.
     */
    public class CharacterRangeReader : CharacterReader
    {
        /**
         * The reader from which the characters are actually being read.
         */
        public readonly CharacterReader baseReader;

        /**
         * The first character to be read.
         */
        public readonly int startIndex;

        /**
         * The last character to be read.
         */
        public readonly int endIndex;

        /**
         * Initialize a newly created reader to read the characters from the given
         * [baseReader] between the [startIndex] inclusive to [endIndex] exclusive.
         */
        public CharacterRangeReader(CharacterReader baseReader, int startIndex, int endIndex)
        {
            this.baseReader = baseReader;
            this.startIndex = startIndex;
            this.endIndex = endIndex;

            baseReader.offset = startIndex - 1;
        }

        public override int offset
        {
            get => baseReader.offset;
            set => baseReader.offset = value;
        }

        public override int advance()
        {
            if (baseReader.offset + 1 >= endIndex)
            {
                return -1;
            }
            return baseReader.advance();
        }


        public override String getContents() =>
      baseReader.getContents().Substring(startIndex, endIndex);


        public override String getString(int start, int endDelta) =>
      baseReader.getString(start, endDelta);


        public override int peek()
        {
            if (baseReader.offset + 1 >= endIndex)
            {
                return -1;
            }
            return baseReader.peek();
        }
    }



}

//https://github.com/dart-lang/sdk/blob/master/pkg/front_end/lib/src/scanner/reader.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2016, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    /**
     * An object used by the scanner to read the characters to be scanned.
     */
    public abstract class CharacterReader
    {
        /**
         * The current offset relative to the beginning of the source. Return the
         * initial offset if the scanner has not yet scanned the source code, and one
         * (1) past the end of the source code if the entire source code has been
         * scanned.
         */
        public abstract int offset { get; set; }

        /**
         * Set the current offset relative to the beginning of the source to the given
         * [offset]. The new offset must be between the initial offset and one (1)
         * past the end of the source code.
         */

        /**
         * Advance the current position and return the character at the new current
         * position.
         */
        public abstract int advance();

        /**
         * Return the source to be scanned.
         */
        public abstract String getContents();

        /**
         * Return the substring of the source code between the [start] offset and the
         * modified current position. The current position is modified by adding the
         * [endDelta], which is the number of characters after the current location to
         * be included in the string, or the number of characters before the current
         * location to be excluded if the offset is negative.
         */
        public abstract String getString(int start, int endDelta);

        /**
         * Return the character at the current position without changing the current
         * position.
         */
        public abstract int peek();
    }

    /**
     * A [CharacterReader] that reads characters from a character sequence.
     */
    public class CharSequenceReader : CharacterReader
    {
        /**
         * The sequence from which characters will be read.
         */
        readonly String _sequence;

        /**
         * The number of characters in the string.
         */
        int _stringLength;

        /**
         * The index, relative to the string, of the next character to be read.
         */
        int _charOffset;

        /**
         * Initialize a newly created reader to read the characters in the given
         * [_sequence].
         */
        public CharSequenceReader(String _sequence)
        {
            this._sequence = _sequence;
            this._stringLength = _sequence.Length;
            this._charOffset = 0;
        }


        public override int offset
        {
            get
            {
                return _charOffset - 1;
            }
            set
            {
                _charOffset = value + 1;
            }
        }

        public override int advance()
        {
            if (_charOffset >= _stringLength)
            {
                return -1;
            }
            return _sequence.codeUnitAt(_charOffset++);
        }


        public override String getContents() => _sequence;


        public override String getString(int start, int endDelta) => _sequence.Substring(start, _charOffset + endDelta);


        public override int peek()
        {
            if (_charOffset >= _stringLength)
            {
                return -1;
            }
            return _sequence.codeUnitAt(_charOffset);
        }
    }

    /**
     * A [CharacterReader] that reads characters from a character sequence, but adds
     * a delta when reporting the current character offset so that the character
     * sequence can be a subsequence from a larger sequence.
     */
    public class SubSequenceReader : CharSequenceReader
    {
        /**
         * The offset from the beginning of the file to the beginning of the source
         * being scanned.
         */
        public readonly int _offsetDelta;

        /**
         * Initialize a newly created reader to read the characters in the given
         * [sequence]. The [_offsetDelta] is the offset from the beginning of the file
         * to the beginning of the source being scanned
         */
        public SubSequenceReader(String sequence, int _offsetDelta) : base(sequence)
        {
            this._offsetDelta = _offsetDelta;
        }


        public int offset
        {
            get
            {
                return _offsetDelta + base.offset;
            }
            set
            {
                base.offset = value - _offsetDelta;
            }
        }

        public String getContents() => base.getContents();


        public String getString(int start, int endDelta) =>
       base.getString(start - _offsetDelta, endDelta);
    }
}