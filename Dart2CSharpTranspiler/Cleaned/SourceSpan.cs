using System;
using System.Collections.Generic;
using System.Text;

//https://github.com/dart-lang/sdk/blob/master/pkg/compiler/lib/src/diagnostics/source_span.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2012, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    //library dart2js.diagnostics.source_span;

    //import 'spannable.dart' show Spannable;

    public class SourceSpan : Spannable
    {
        public readonly Uri uri;
        public readonly int begin;
        public readonly int end;

        public SourceSpan(Uri uri, int begin, int end)
        {
            this.uri = uri;
            this.begin = begin;
            this.end = end;
        }

        public int hashCode
        {
            get
            {
                return 13 * uri.GetHashCode() + 17 * begin.GetHashCode() + 19 * end.GetHashCode();
            }
        }

        //bool operator == (other) {
        //    if (identical(this, other)) return true;
        //    if (other is !SourceSpan) return false;
        //    return uri == other.uri && begin == other.begin && end == other.end;
        //}

        public String toString() => $"SourceSpan({uri}, {begin}, {end})";
    }
}
