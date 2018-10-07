using System;
using System.Collections.Generic;
using System.Text;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/source/source_range.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2018, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    //import "dart:math" as math;

    /**
     * A source range defines a range of characters within source code.
     */
    public class SourceRange
    {
        /**
         * An empty source range (a range with offset `0` and length `0`).
         */
        public static SourceRange EMPTY = new SourceRange(0, 0);

        /**
         * The 0-based index of the first character of the source range.
         */
        public readonly int offset;

        /**
         * The number of characters in the source range.
         */
        public readonly int length;

        /**
         * Initialize a newly created source range using the given [offset] and
         * [length].
         */
        public SourceRange(int offset, int length)
        {
            this.offset = offset;
            this.length = length;
        }

        /**
         * Return the 0-based index of the character immediately after this source
         * range.
         */
        public int end => offset + length;


        public int hashCode => 31 * offset + length;


        public static bool operator ==(SourceRange first, SourceRange second)
        {
            return
                first.offset == second.offset &&
                first.length == second.length;
        }

        public static bool operator !=(SourceRange first, SourceRange second)
        {
            return !(first == second);
        }

        /**
         * Return `true` if [x] is in the interval `[offset, offset + length)`.
         */
        public bool contains(int x) => offset <= x && x < offset + length;

        /**
         * Return `true` if [x] is in the interval `(offset, offset + length)`.
         */
        public bool containsExclusive(int x) => offset < x && x < offset + length;

        /**
         * Return `true` if the [otherRange] covers this source range.
         */
        public bool coveredBy(SourceRange otherRange) => otherRange.covers(this);

        /**
         * Return `true` if this source range covers the [otherRange].
         */
        public bool covers(SourceRange otherRange) =>
            offset <= otherRange.offset && otherRange.end <= end;

        /**
         * Return `true` if this source range ends inside the [otherRange].
         */
        public bool endsIn(SourceRange otherRange)
        {
            int thisEnd = end;
            return otherRange.contains(thisEnd);
        }

        /**
         * Return a source range covering [delta] characters before the start of this
         * source range and [delta] characters after the end of this source range.
         */
        public SourceRange getExpanded(int delta) =>
            new SourceRange(offset - delta, delta + length + delta);

        /**
         * Return a source range with the same offset as this source range but whose
         * length is [delta] characters longer than this source range.
         */
        public SourceRange getMoveEnd(int delta) => new SourceRange(offset, length + delta);

        /**
         * Return a source range with the same length as this source range but whose
         * offset is [delta] characters after the offset of this source range.
         */
        public SourceRange getTranslated(int delta) =>
            new SourceRange(offset + delta, length);

        /**
         * Return the minimal source range that covers both this and the [otherRange].
         */
        public SourceRange getUnion(SourceRange otherRange)
        {
            int newOffset = Math.Min(offset, otherRange.offset);
            int newEnd =
                Math.Max(offset + length, otherRange.offset + otherRange.length);
            return new SourceRange(newOffset, newEnd - newOffset);
        }

        /**
         * Return `true` if this source range intersects the [otherRange].
         */
        public bool intersects(SourceRange otherRange)
        {
            if (otherRange == null)
            {
                return false;
            }
            if (end <= otherRange.offset)
            {
                return false;
            }
            if (offset >= otherRange.end)
            {
                return false;
            }
            return true;
        }

        /**
         * Return `true` if this source range starts in the [otherRange].
         */
        public bool startsIn(SourceRange otherRange) => otherRange.contains(offset);


        public String toString() => $"[offset={offset}, length={length}]";
    }
}
