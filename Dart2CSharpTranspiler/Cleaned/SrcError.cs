using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using static Dart2CSharpTranspiler.Parser.DartLibrary;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/error.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2013, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.
    //    library analyzer.src.error;

    //    import 'dart:collection';

    //import 'package:analyzer/error/error.dart';

    /// A wrapper around [AnalysisError] that provides a more user-friendly string
    /// representation.
    public class AnalyzerError : Exception
    {
        public readonly AnalysisError error;

        public AnalyzerError(AnalysisError error)
        {
            this.error = error;
        }

        public String message => toString();

        public String toString()
        {
            var builder = new StringBuffer();

            // Print a less friendly string representation to ensure that
            // error.source.contents is not executed, as .contents it isn't async
            String sourceName = error.source.shortName;
            if (sourceName == null)
                sourceName = "<unknown source>";
            builder.write("Error in $sourceName: ${error.message}");

            //    var content = error.source.contents.data;
            //    var beforeError = content.substring(0, error.offset);
            //    var lineNumber = "\n".allMatches(beforeError).length + 1;
            //    builder.writeln("Error on line $lineNumber of ${error.source.fullName}: "
            //        "${error.message}");

            //    var errorLineIndex = beforeError.lastIndexOf("\n") + 1;
            //    var errorEndOfLineIndex = content.indexOf("\n", error.offset);
            //    if (errorEndOfLineIndex == -1) errorEndOfLineIndex = content.length;
            //    var errorLine = content.substring(
            //        errorLineIndex, errorEndOfLineIndex);
            //    var errorColumn = error.offset - errorLineIndex;
            //    var errorLength = error.length;
            //
            //    // Ensure that the error line we display isn't too long.
            //    if (errorLine.length > _MAX_ERROR_LINE_LENGTH) {
            //      var leftLength = errorColumn;
            //      var rightLength = errorLine.length - leftLength;
            //      if (leftLength > _MAX_ERROR_LINE_LENGTH ~/ 2 &&
            //          rightLength > _MAX_ERROR_LINE_LENGTH ~/ 2) {
            //        errorLine = "..." + errorLine.substring(
            //            errorColumn - _MAX_ERROR_LINE_LENGTH ~/ 2 + 3,
            //            errorColumn + _MAX_ERROR_LINE_LENGTH ~/ 2 - 3)
            //            + "...";
            //        errorColumn = _MAX_ERROR_LINE_LENGTH ~/ 2;
            //      } else if (rightLength > _MAX_ERROR_LINE_LENGTH ~/ 2) {
            //        errorLine = errorLine.substring(0, _MAX_ERROR_LINE_LENGTH - 3) + "...";
            //      } else {
            //        assert(leftLength > _MAX_ERROR_LINE_LENGTH ~/ 2);
            //        errorColumn -= errorLine.length - _MAX_ERROR_LINE_LENGTH;
            //        errorLine = "..." + errorLine.substring(
            //            errorLine.length - _MAX_ERROR_LINE_LENGTH + 3, errorLine.length);
            //      }
            //      errorLength = math.min(errorLength, _MAX_ERROR_LINE_LENGTH - errorColumn);
            //    }
            //    builder.writeln(errorLine);
            //
            //    for (var i = 0; i < errorColumn; i++) builder.write(" ");
            //    for (var i = 0; i < errorLength; i++) builder.write("^");
            builder.writeln();

            return builder.toString();
        }
    }

    /// An error class that collects multiple [AnalyzerError]s that are emitted
    /// during a single analysis.
    public class AnalyzerErrorGroup : Exception
    {
        public readonly List<AnalyzerError> _errors;
        public AnalyzerErrorGroup(List<AnalyzerError> errors)
        => _errors = errors.ToList();

        /// Creates an [AnalyzerErrorGroup] from a list of lower-level
        /// [AnalysisError]s.
        public AnalyzerErrorGroup(List<AnalysisError> errors)
            => _errors = errors.Select(e => new AnalyzerError(e)).ToList();

        /// The errors in this collection.
        public List<AnalyzerError> errors =>
            new ReadOnlyCollection<AnalyzerError>(_errors).ToList();

        public String message => toString();

        public String toString() => string.Join('\n', errors);
    }
}
