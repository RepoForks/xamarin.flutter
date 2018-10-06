using System;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/html/error/html_codes.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2014, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    //library analyzer.src.html.error.lint_codes;

    //import 'package:analyzer/error/error.dart';

    /**
     * The error codes used for errors in HTML files. The convention for this
     * class is for the name of the error code to indicate the problem that caused
     * the error to be generated and for the error message to explain what is wrong
     * and, when appropriate, how the problem can be corrected.
     */
    public class HtmlErrorCode : ErrorCode
    {
        /**
         * An error code indicating that there is a syntactic error in the file.
         *
         * Parameters:
         * 0: the error message from the parse error
         */
        public static HtmlErrorCode PARSE_ERROR =
            new HtmlErrorCode("PARSE_ERROR", "{0}");

        /**
         * Initialize a newly created error code to have the given [name]. The message
         * associated with the error will be created from the given [message]
         * template. The correction associated with the error will be created from the
         * given [correction] template.
         */
        public HtmlErrorCode(String name, String message, String correction = "")
      : base(name, message, correction: correction) { }


        public ErrorSeverity errorSeverity => ErrorSeverity.ERROR;
        public ErrorType type => ErrorType.COMPILE_TIME_ERROR;
    }

    /**
     * The error codes used for warnings in HTML files. The convention for this
     * class is for the name of the error code to indicate the problem that caused
     * the error to be generated and for the error message to explain what is wrong
     * and, when appropriate, how the problem can be corrected.
     */
    public class HtmlWarningCode : ErrorCode
    {
        /**
         * An error code indicating that the value of the 'src' attribute of a Dart
         * script tag is not a valid URI.
         *
         * Parameters:
         * 0: the URI that is invalid
         */
        public static HtmlWarningCode INVALID_URI =
            new HtmlWarningCode("INVALID_URI", "Invalid URI syntax: '{0}'.");

        /**
         * An error code indicating that the value of the 'src' attribute of a Dart
         * script tag references a file that does not exist.
         *
         * Parameters:
         * 0: the URI pointing to a non-existent file
         */
        public static HtmlWarningCode URI_DOES_NOT_EXIST = new HtmlWarningCode(
          "URI_DOES_NOT_EXIST", "Target of URI doesn't exist: '{0}'.");

        /**
         * Initialize a newly created error code to have the given [name]. The message
         * associated with the error will be created from the given [message]
         * template. The correction associated with the error will be created from the
         * given [correction] template.
         */
        public HtmlWarningCode(String name, String message, String correction = "")
          : base(name, message, correction: correction) { }


        public ErrorSeverity errorSeverity => ErrorSeverity.WARNING;

        public ErrorType type => ErrorType.STATIC_WARNING;
    }
}