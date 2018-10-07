using System;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/string_source.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2013, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    //library analyzer.src.string_source;

    //import 'package:analyzer/src/generated/engine.dart' show TimestampedData;
    //import 'package:analyzer/src/generated/source.dart';

    /**
     * An implementation of [Source] that's based on an in-memory Dart string.
     */
    public class StringSource : Source
    {
        /**
         * The content of the source.
         */
        readonly String _contents;


        public readonly String fullName;


        public readonly Uri uri;


        public readonly int modificationStamp;

        public StringSource(String _contents, String fullName)
        {
            this._contents = _contents;
            this.fullName = fullName;
            uri = fullName == null ? null : new Uri(fullName);
            modificationStamp = (int)DateTime.Now.ToUniversalTime().Subtract(
                                new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                                ).TotalMilliseconds;
        }

        public TimestampedData<String> contents => new TimestampedData<string>(modificationStamp, _contents);


        public String encoding => uri.ToString();


        public int hashCode => _contents.GetHashCode() ^ fullName.GetHashCode();


        public bool isInSystemLibrary => false;


        public String shortName => fullName;


        public UriKind uriKind => UriKind.Absolute;

        /**
         * Return `true` if the given [object] is a string source that is equal to
         * this source.
         */
        public static bool operator ==(StringSource first, StringSource second)
        {
            return 
                first._contents == second._contents &&
                first.fullName == second.fullName;
        }

        public static bool operator !=(StringSource first, StringSource second)
        {
            return !(first == second);
        }


        public override bool exists() => true;

        public String toString() => $"StringSource ({fullName})";

    }
}
