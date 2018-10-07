using System;
using System.Collections.Generic;

// https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/analyzer.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2013, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    public class Analyzer
    {

        //import 'dart:io';

        //import 'package:analyzer/dart/ast/ast.dart';
        //import 'package:analyzer/error/error.dart';
        //import 'package:analyzer/error/listener.dart';
        //import 'package:analyzer/file_system/physical_file_system.dart';
        //import 'package:analyzer/src/dart/scanner/reader.dart';
        //import 'package:analyzer/src/dart/scanner/scanner.dart';
        //import 'package:analyzer/src/error.dart';
        //import 'package:analyzer/src/file_system/file_system.dart';
        //import 'package:analyzer/src/generated/parser.dart';
        //import 'package:analyzer/src/generated/source_io.dart';
        //import 'package:analyzer/src/string_source.dart';
        //import 'package:path/path.dart' as pathos;

        //export 'package:analyzer/dart/ast/ast.dart';
        //export 'package:analyzer/dart/ast/visitor.dart';
        //export 'package:analyzer/error/error.dart';
        //export 'package:analyzer/error/listener.dart';
        //export 'package:analyzer/src/dart/ast/utilities.dart';
        //export 'package:analyzer/src/error.dart';
        //export 'package:analyzer/src/error/codes.dart';
        //export 'package:analyzer/src/generated/utilities_dart.dart';

        /// Parses a string of Dart code into an AST.
        ///
        /// If [name] is passed, it's used in error messages as the name of the code
        /// being parsed.
        ///
        /// Throws an [AnalyzerErrorGroup] if any errors occurred, unless
        /// [suppressErrors] is `true`, in which case any errors are discarded.
        ///
        /// If [parseFunctionBodies] is [false] then only function signatures will be
        /// parsed.
        public CompilationUnit parseCompilationUnit(String contents,
                                             String name = "",
                                             bool suppressErrors = false,
                                             bool parseFunctionBodies = true)
        {
            Source source = new StringSource(contents, name);
            return _parseSource(contents, source,
                suppressErrors: suppressErrors, parseFunctionBodies: parseFunctionBodies);
        }

        private CompilationUnit _parseSource(String contents,
                                             Source source,
                                             bool suppressErrors = false,
                                             bool parseFunctionBodies = true)
        {
            var reader = new CharSequenceReader(contents);
            var errorCollector = new _ErrorCollector();
            var scanner = new Scanner(source, reader, errorCollector);
            var token = scanner.tokenize();
            var parser = new Parser(source, errorCollector)
            {
                parseFunctionBodies = parseFunctionBodies
            };
            var unit = parser.parseCompilationUnit(token);
            unit.lineInfo = new LineInfo(scanner.lineStarts);

            if (errorCollector.hasErrors && !suppressErrors) throw errorCollector.group;

            return unit;
        }
    }

    /// A simple error listener that collects errors into an [AnalyzerErrorGroup].
    public class _ErrorCollector : AnalysisErrorListener
    {
        readonly List<AnalysisError> _errors = new List<AnalysisError> { };

        public _ErrorCollector() { }

        /// The group of errors collected.
        public AnalyzerErrorGroup group =>
        new AnalyzerErrorGroup(_errors);

        /// Whether any errors where collected.
        public bool hasErrors => _errors.Count != 0;

        public override void onError(AnalysisError error) => _errors.Add(error);
    }
}
