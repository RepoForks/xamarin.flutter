using System;
using System.Collections.Generic;
using System.Text;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/summary/base.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2014, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    /**
     * Base functionality which code generated summary classes are built upon.
     */
    //library analyzer.src.summary.base;

    /**
     * Annotation used in the summary IDL to indicate the id of a field.  The set
     * of ids used by a class must cover the contiguous range from 0 to N-1, where
     * N is the number of fields.
     *
     * In order to preserve forwards and backwards compatibility, id numbers must
     * be stable between releases.  So when new fields are added they should take
     * the next available id without renumbering other fields.
     */
    public class Id
    {
        public readonly int value;

        public Id(int value) => this.value = value;
    }

    /**
     * Instances of this class represent data that has been read from a summary.
     */
    public abstract class SummaryClass
    {
        /**
         * Translate the data in this class into a JSON map, whose keys are the names
         * of fields and whose values are the data stored in those fields,
         * recursively converted into JSON.
         *
         * Fields containing their default value are elided.
         *
         * Intended for testing and debugging only.
         */
        public abstract Dictionary<String, Object> toJson();

        /**
         * Translate the data in this class into a map whose keys are the names of
         * fields and whose values are the data stored in those fields.
         *
         * Intended for testing and debugging only.
         */
        public abstract Dictionary<String, Object> toMap();
    }

    /**
     * Annotation used in the summary IDL to indicate that a summary class can be
     * the top level object in an encoded summary.
     */
    public class TopLevel
    {
        /**
         * If non-null, identifier that will be stored in bytes 4-7 of the file,
         * prior all other file data.  Must be exactly 4 Latin1 characters.
         */
        public readonly String fileIdentifier;

        public TopLevel(String fileIdentifier) => this.fileIdentifier = fileIdentifier;
    }
}
