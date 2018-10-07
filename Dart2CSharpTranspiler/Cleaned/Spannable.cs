using System;

//https://github.com/dart-lang/sdk/blob/master/pkg/compiler/lib/src/diagnostics/spannable.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2011, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    //library dart2js.diagnostics.spannable;

    /**
     * Tagging interface for classes from which source spans can be generated.
     */
    // TODO(johnniwinther): Find a better name.
    // TODO(ahe): How about "Bolt"?
    public abstract class Spannable { }

    public class _SpannableSentinel : Spannable
    {
        public readonly String name;

        public _SpannableSentinel(String name)
        {
            this.name = name;
        }

        public String toString() => name;
    }

    public static partial class DartLibrary
    {
        /// Sentinel spannable used to mark that diagnostics should point to the
        /// current element. Note that the diagnostic reporting will fail if the current
        /// element is `null`.
        public static Spannable CURRENT_ELEMENT_SPANNABLE =
        new _SpannableSentinel("Current element");

        /// Sentinel spannable used to mark that there might be no location for the
        /// diagnostic. Use this only when it is not an error not to have a current
        /// element.
        public static Spannable NO_LOCATION_SPANNABLE = new _SpannableSentinel("No location");
    }

    public class SpannableAssertionFailure
    {
        public readonly Spannable node;
        public readonly String message;
        public SpannableAssertionFailure(Spannable node, String message)
        {
            this.node = node;
            this.message = message;
        }

        public String toString() => "Assertion failure" +
          $"{message}";
    }
}