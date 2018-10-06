using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/dart/error/todo_codes.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2014, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    //library analyzer.src.dart.error.todo_codes;

    //import 'package:analyzer/error/error.dart';

    /**
     * The error code indicating a marker in code for work that needs to be finished
     * or revisited.
     */
    public class TodoCode : ErrorCode
    {
        /**
         * The single enum of TodoCode.
         */
        public static TodoCode TODO = new TodoCode("TODO");

        /**
         * This matches the two common Dart task styles
         *
         * * TODO:
         * * TODO(username):
         *
         * As well as
         * * TODO
         *
         * But not
         * * todo
         * * TODOS
         */
        public static Regex TODO_REGEX = new Regex(@"([\\s/\\*])((TODO[^\\w\\d][^\\r\\n]*)|(TODO:?\$))");

        /**
         * Initialize a newly created error code to have the given [name].
         */
        public TodoCode(String name) : base(name, "{0}") { }

        public ErrorSeverity errorSeverity => ErrorSeverity.INFO;

        public ErrorType type => ErrorType.TODO;
    }
}
