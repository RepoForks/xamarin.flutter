using System;
using System.Collections.Generic;

//https://github.com/dart-lang/sdk/blob/master/pkg/front_end/lib/src/base/errors.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2016, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    /// An error code associated with an [AnalysisError].
    ///
    /// Generally, messages should follow the [Guide for Writing
    /// Diagnostics](../fasta/diagnostics.md).
    public class ErrorCode
    {
        /**
         * The name of the error code.
         */
        public String name;

        /**
         * The template used to create the message to be displayed for this error. The
         * message should indicate what is wrong and why it is wrong.
         */
        public String message;

        /**
         * The template used to create the correction to be displayed for this error,
         * or `null` if there is no correction information for this error. The
         * correction should indicate how the user can fix the error.
         */
        public String correction;

        /**
         * Whether this error is caused by an unresolved identifier.
         */
        public bool isUnresolvedIdentifier;

        /**
         * Initialize a newly created error code to have the given [name]. The message
         * associated with the error will be created from the given [message]
         * template. The correction associated with the error will be created from the
         * given [correction] template.
         */
        public ErrorCode(String name, String message, String correction)
        {
            this.name = name;
            this.message = message;
            this.correction = correction;

            isUnresolvedIdentifier = false;
        }

        /**
         * Initialize a newly created error code to have the given [name]. The message
         * associated with the error will be created from the given [message]
         * template. The correction associated with the error will be created from the
         * given [correction] template.
         */
        public ErrorCode(String name, String message, String correction = "", bool isUnresolvedIdentifier = false)
        {
            this.name = name;
            this.message = message;
            this.correction = correction;
            this.isUnresolvedIdentifier = isUnresolvedIdentifier;
        }

        /**
         * The severity of the error.
         */
        public ErrorSeverity errorSeverity;

        /**
         * The type of the error.
         */
        public ErrorType type;

        /**
         * The unique name of this error code.
         */
        public virtual String uniqueName => "$runtimeType.$name";


        public virtual String toString() => uniqueName;
    }

    /**
     * The severity of an [ErrorCode].
     */
    public class ErrorSeverity : Comparable<ErrorSeverity>
    {
        /**
         * The severity representing a non-error. This is never used for any error
         * code, but is useful for clients.
         */
        public static ErrorSeverity NONE = new ErrorSeverity("NONE", 0, " ", "none");

        /**
         * The severity representing an informational level analysis issue.
         */
        public static ErrorSeverity INFO = new ErrorSeverity("INFO", 1, "I", "info");

        /**
         * The severity representing a warning. Warnings can become errors if the
         * `-Werror` command line flag is specified.
         */
        public static ErrorSeverity WARNING =
          new ErrorSeverity("WARNING", 2, "W", "warning");

        /**
         * The severity representing an error.
         */
        public static ErrorSeverity ERROR =
          new ErrorSeverity("ERROR", 3, "E", "error");

        public static List<ErrorSeverity> values = new List<ErrorSeverity> { NONE, INFO, WARNING, ERROR };

        /**
         * The name of this error code.
         */
        public readonly String name;

        /**
         * The ordinal value of the error code.
         */
        public readonly int ordinal;

        /**
         * The name of the severity used when producing machine output.
         */
        public readonly String machineCode;

        /**
         * The name of the severity used when producing readable output.
         */
        public readonly String displayName;

        /**
         * Initialize a newly created severity with the given names.
         */
        public ErrorSeverity(String name, int ordinal, String machineCode, String displayName)
        {
            this.name = name;
            this.ordinal = ordinal;
            this.machineCode = machineCode;
            this.displayName = displayName;
        }

        public int hashCode => ordinal;

        public virtual int compareTo(ErrorSeverity other) => ordinal - other.ordinal;

        /**
         * Return the severity constant that represents the greatest severity.
         */
        public ErrorSeverity max(ErrorSeverity severity) =>
            this.ordinal >= severity.ordinal ? this : severity;


        public virtual String toString() => name;
    }

    /**
     * The type of an [ErrorCode].
     */
    public class ErrorType : Comparable<ErrorType>
    {
        /**
         * Task (todo) comments in user code.
         */
        public static ErrorType TODO = new ErrorType("TODO", 0, ErrorSeverity.INFO);

        /**
         * Extra analysis run over the code to follow best practices, which are not in
         * the Dart Language Specification.
         */
        public static ErrorType HINT = new ErrorType("HINT", 1, ErrorSeverity.INFO);

        /**
         * Compile-time errors are errors that preclude execution. A compile time
         * error must be reported by a Dart compiler before the erroneous code is
         * executed.
         */
        public static ErrorType COMPILE_TIME_ERROR =
      new ErrorType("COMPILE_TIME_ERROR", 2, ErrorSeverity.ERROR);

        /**
         * Checked mode compile-time errors are errors that preclude execution in
         * checked mode.
         */
        public static ErrorType CHECKED_MODE_COMPILE_TIME_ERROR = new ErrorType(
      "CHECKED_MODE_COMPILE_TIME_ERROR", 3, ErrorSeverity.ERROR);

        /**
         * Static warnings are those warnings reported by the static checker. They
         * have no effect on execution. Static warnings must be provided by Dart
         * compilers used during development.
         */
        public static ErrorType STATIC_WARNING =
      new ErrorType("STATIC_WARNING", 4, ErrorSeverity.WARNING);

        /**
         * Many, but not all, static warnings relate to types, in which case they are
         * known as static type warnings.
         */
        public static ErrorType STATIC_TYPE_WARNING =
      new ErrorType("STATIC_TYPE_WARNING", 5, ErrorSeverity.WARNING);

        /**
         * Syntactic errors are errors produced as a result of input that does not
         * conform to the grammar.
         */
        public static ErrorType SYNTACTIC_ERROR =
      new ErrorType("SYNTACTIC_ERROR", 6, ErrorSeverity.ERROR);

        /**
         * Lint warnings describe style and best practice recommendations that can be
         * used to formalize a project's style guidelines.
         */
        public static ErrorType LINT = new ErrorType("LINT", 7, ErrorSeverity.INFO);

        public static List<ErrorType> values = new List<ErrorType> {
                              TODO,
                              HINT,
                              COMPILE_TIME_ERROR,
                              CHECKED_MODE_COMPILE_TIME_ERROR,
                              STATIC_WARNING,
                              STATIC_TYPE_WARNING,
                              SYNTACTIC_ERROR,
                              LINT
                            };

        /**
         * The name of this error type.
         */
        public readonly String name;

        /**
         * The ordinal value of the error type.
         */
        public readonly int ordinal;

        /**
         * The severity of this type of error.
         */
        public readonly ErrorSeverity severity;

        /**
         * Initialize a newly created error type to have the given [name] and
         * [severity].
         */
        public ErrorType(string name, int ordinal, ErrorSeverity severity)
        {
            this.name = name;
            this.ordinal = ordinal;
            this.severity = severity;
        }

        public String displayName => name.ToLower().Replace('_', ' ');

        public int hashCode => ordinal;

        public int compareTo(ErrorType other) => ordinal - other.ordinal;

        public virtual String toString() => name;
    }
}
