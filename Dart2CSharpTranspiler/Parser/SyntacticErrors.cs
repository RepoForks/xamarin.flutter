using System;
using System.Collections.Generic;
using System.Text;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/dart/error/syntactic_errors.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2014, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    /**
     * The errors produced during syntactic analysis (scanning and parsing).
     */
    //    library analyzer.src.dart.error.syntactic_errors;

    //    import 'package:analyzer/error/error.dart';

    //export 'package:front_end/src/scanner/errors.dart' show ScannerErrorCode;

    //    part 'syntactic_errors.g.dart';

    /**
     * The error codes used for errors detected by the parser. The convention for
     * this class is for the name of the error code to indicate the problem that
     * caused the error to be generated and for the error message to explain what
     * is wrong and, when appropriate, how the problem can be corrected.
     */
    public class ParserErrorCode : ErrorCode
    {
        public static ParserErrorCode ABSTRACT_CLASS_MEMBER = new ParserErrorCode(
           "ABSTRACT_CLASS_MEMBER",
           "Members of classes can't be declared to be 'abstract'.",
           correction: "Try removing the keyword 'abstract'.");

        public static ParserErrorCode ABSTRACT_ENUM = new ParserErrorCode(
         "ABSTRACT_ENUM", "Enums can't be declared to be 'abstract'.",
           correction: "Try removing the keyword 'abstract'.");

        public static ParserErrorCode ABSTRACT_STATIC_METHOD = new ParserErrorCode(
         "ABSTRACT_STATIC_METHOD",
           "Static methods can't be declared to be 'abstract'.",
           correction: "Try removing the keyword 'abstract'.");

        public static ParserErrorCode ABSTRACT_TOP_LEVEL_FUNCTION =
      new ParserErrorCode("ABSTRACT_TOP_LEVEL_FUNCTION",
          "Top-level functions can't be declared to be 'abstract'.",
          correction: "Try removing the keyword 'abstract'.");

        public static ParserErrorCode ABSTRACT_TOP_LEVEL_VARIABLE =
      new ParserErrorCode("ABSTRACT_TOP_LEVEL_VARIABLE",
          "Top-level variables can't be declared to be 'abstract'.",
          correction: "Try removing the keyword 'abstract'.");

        public static ParserErrorCode ABSTRACT_TYPEDEF = new ParserErrorCode(
         "ABSTRACT_TYPEDEF", "Typedefs can't be declared to be 'abstract'.",
           correction: "Try removing the keyword 'abstract'.");

        /**
         * 16.32 Identifier Reference: It is a compile-time error if any of the
         * identifiers async, await, or yield is used as an identifier in a function
         * body marked with either async, async*, or sync*.
         */
        public static ParserErrorCode ASYNC_KEYWORD_USED_AS_IDENTIFIER =
         new ParserErrorCode(
             "ASYNC_KEYWORD_USED_AS_IDENTIFIER",
             "The keywords 'async', 'await', and 'yield' can't be used as " +
             "identifiers in an asynchronous or generator function.");

        public static ParserErrorCode BREAK_OUTSIDE_OF_LOOP = new ParserErrorCode(
         "BREAK_OUTSIDE_OF_LOOP",
           "A break statement can't be used outside of a loop or switch statement.",
           correction: "Try removing the break statement.");

        public static ParserErrorCode CATCH_SYNTAX = new ParserErrorCode(
         "CATCH_SYNTAX",
           "'catch' must be followed by '(identifier)' or '(identifier, identifier)'.",
           correction:
               "No types are needed, the first is given by 'on', the second is always 'StackTrace'.");

        public static ParserErrorCode CLASS_IN_CLASS = new ParserErrorCode(
         "CLASS_IN_CLASS", "Classes can't be declared inside other classes.",
           correction: "Try moving the class to the top-level.");

        public static ParserErrorCode COLON_IN_PLACE_OF_IN = new ParserErrorCode(
         "COLON_IN_PLACE_OF_IN", "For-in loops use 'in' rather than a colon.",
           correction: "Try replacing the colon with the keyword 'in'.");

        public static ParserErrorCode CONST_AFTER_FACTORY = new ParserErrorCode(
         "CONST_AFTER_FACTORY",
           "The modifier 'const' should be before the modifier 'factory'.",
           correction: "Try re-ordering the modifiers.");

        public static ParserErrorCode CONST_AND_COVARIANT = new ParserErrorCode(
         "CONST_AND_COVARIANT",
           "Members can't be declared to be both 'const' and 'covariant'.",
           correction: "Try removing either the 'const' or 'covariant' keyword.");

        public static ParserErrorCode CONST_AND_FINAL = new ParserErrorCode(
         "CONST_AND_FINAL",
           "Members can't be declared to be both 'const' and 'final'.",
           correction: "Try removing either the 'const' or 'final' keyword.");

        public static ParserErrorCode CONST_AND_VAR = new ParserErrorCode(
         'CONST_AND_VAR',
           "Members can't be declared to be both 'const' and 'var'.",
           correction: "Try removing either the 'const' or 'var' keyword.");

        public static ParserErrorCode CONST_CLASS = new ParserErrorCode(
         "CONST_CLASS", "Classes can't be declared to be 'const'.",
           correction:
               "Try removing the 'const' keyword. If you're trying to indicate that " +
               "instances of the class can be constants, place the 'const' keyword on " +
               "the class' constructor(s).");

        public static ParserErrorCode CONST_CONSTRUCTOR_WITH_BODY =
         new ParserErrorCode('CONST_CONSTRUCTOR_WITH_BODY',
             "Const constructors can't have a body.",
             correction: "Try removing either the 'const' keyword or the body.");

        public static ParserErrorCode CONST_ENUM = new ParserErrorCode(
         "CONST_ENUM", "Enums can't be declared to be 'const'.",
           correction: "Try removing the 'const' keyword.");

        public static ParserErrorCode CONST_FACTORY = new ParserErrorCode(
         "CONST_FACTORY",
           "Only redirecting factory constructors can be declared to be 'const'.",
           correction: "Try removing the 'const' keyword, or " +
               "replacing the body with '=' followed by a valid target.");

        public static ParserErrorCode CONST_METHOD = new ParserErrorCode(
         "CONST_METHOD",
           "Getters, setters and methods can't be declared to be 'const'.",
           correction: "Try removing the 'const' keyword.");

        public static ParserErrorCode CONST_TYPEDEF = new ParserErrorCode(
         "CONST_TYPEDEF", "Type aliases can't be declared to be 'const'.",
           correction: "Try removing the 'const' keyword.");

        public static ParserErrorCode CONSTRUCTOR_WITH_RETURN_TYPE =
      new ParserErrorCode("CONSTRUCTOR_WITH_RETURN_TYPE",
          "Constructors can't have a return type.",
          correction: "Try removing the return type.");

        public static ParserErrorCode CONTINUE_OUTSIDE_OF_LOOP =
           _CONTINUE_OUTSIDE_OF_LOOP;

        public static ParserErrorCode CONTINUE_WITHOUT_LABEL_IN_CASE = new ParserErrorCode(
         "CONTINUE_WITHOUT_LABEL_IN_CASE",
           "A continue statement in a switch statement must have a label as a target.",
           correction:
               "Try adding a label associated with one of the case clauses to the continue statement.");

        public static ParserErrorCode COVARIANT_AFTER_FINAL = new ParserErrorCode(
         "COVARIANT_AFTER_FINAL",
           "The modifier 'covariant' should be before the modifier 'final'.",
           correction: "Try re-ordering the modifiers.");

        public static ParserErrorCode COVARIANT_AFTER_VAR = _COVARIANT_AFTER_VAR;

        public static ParserErrorCode COVARIANT_AND_STATIC = new ParserErrorCode(
         "COVARIANT_AND_STATIC",
           "Members can't be declared to be both 'covariant' and 'static'.",
           correction: "Try removing either the 'covariant' or 'static' keyword.");

        public static ParserErrorCode COVARIANT_MEMBER = new ParserErrorCode(
         "COVARIANT_MEMBER",
           "Getters, setters and methods can't be declared to be 'covariant'.",
           correction: "Try removing the 'covariant' keyword.");

        public static ParserErrorCode COVARIANT_TOP_LEVEL_DECLARATION =
         new ParserErrorCode('COVARIANT_TOP_LEVEL_DECLARATION',
             "Top-level declarations can't be declared to be covariant.",
             correction: "Try removing the keyword 'covariant'.");

        public static ParserErrorCode COVARIANT_CONSTRUCTOR = new ParserErrorCode(
         "COVARIANT_CONSTRUCTOR",
           "A constructor can't be declared to be 'covariant'.",
           correction: "Try removing the keyword 'covariant'.");

        public static ParserErrorCode DEFERRED_AFTER_PREFIX = new ParserErrorCode(
         "DEFERRED_AFTER_PREFIX",
           "The deferred keyword should come"+
           " immediately before the prefix ('as' clause).",
           correction: "Try moving the deferred keyword before the prefix.");

        public static ParserErrorCode DEFAULT_VALUE_IN_FUNCTION_TYPE =
         new ParserErrorCode("DEFAULT_VALUE_IN_FUNCTION_TYPE",
             "Parameters in a function type cannot have default values",
             correction: "Try removing the default value.");

        public static ParserErrorCode DIRECTIVE_AFTER_DECLARATION =
         new ParserErrorCode("DIRECTIVE_AFTER_DECLARATION",
             "Directives must appear before any declarations.",
             correction: "Try moving the directive before any declarations.");

        /**
         * Parameters:
         * 0: the label that was duplicated
         */
        public static ParserErrorCode DUPLICATE_LABEL_IN_SWITCH_STATEMENT =
         new ParserErrorCode("DUPLICATE_LABEL_IN_SWITCH_STATEMENT",
             "The label '{0}' was already used in this switch statement.",
             correction: "Try choosing a different name for this label.");

        public static ParserErrorCode DUPLICATE_DEFERRED = new ParserErrorCode(
         "DUPLICATE_DEFERRED",
           "An import directive can only have one 'deferred' keyword.",
           correction: "Try removing all but one 'deferred' keyword.");

        /**
         * Parameters:
         * 0: the modifier that was duplicated
         */
        public static ParserErrorCode DUPLICATED_MODIFIER = new ParserErrorCode(
         "DUPLICATED_MODIFIER", "The modifier '{0}' was already specified.",
           correction: "Try removing all but one occurance of the modifier.");

        public static ParserErrorCode DUPLICATE_PREFIX = new ParserErrorCode(
        "DUPLICATE_PREFIX",
           "An import directive can only have one prefix ('as' clause).",
           correction: "Try removing all but one prefix.");

        public static ParserErrorCode EMPTY_ENUM_BODY = new ParserErrorCode(
         "EMPTY_ENUM_BODY", "An enum must declare at least one constant name.",
           correction: "Try declaring a constant.");

        public static ParserErrorCode ENUM_IN_CLASS = new ParserErrorCode(
         "ENUM_IN_CLASS", "Enums can't be declared inside classes.",
           correction: "Try moving the enum to the top-level.");

        public static ParserErrorCode EQUALITY_CANNOT_BE_EQUALITY_OPERAND =
           _EQUALITY_CANNOT_BE_EQUALITY_OPERAND;

        public static ParserErrorCode EXPECTED_CASE_OR_DEFAULT = new ParserErrorCode(
         "EXPECTED_CASE_OR_DEFAULT", "Expected 'case' or 'default'.",
           correction: "Try placing this code inside a case clause.");

        public static ParserErrorCode EXPECTED_CLASS_MEMBER = new ParserErrorCode(
         "EXPECTED_CLASS_MEMBER", "Expected a class member.",
           correction: "Try placing this code inside a class member.");

        public static ParserErrorCode EXPECTED_EXECUTABLE = new ParserErrorCode(
         "EXPECTED_EXECUTABLE",
           "Expected a method, getter, setter or operator declaration.",
           correction:
               "This appears to be incomplete code. Try removing it or completing it.");

        public static ParserErrorCode EXPECTED_LIST_OR_MAP_LITERAL = new ParserErrorCode(
         "EXPECTED_LIST_OR_MAP_LITERAL", "Expected a list or map literal.",
           correction:
               "Try inserting a list or map literal, or remove the type arguments.");

        public static ParserErrorCode EXPECTED_STRING_LITERAL = new ParserErrorCode(
         "EXPECTED_STRING_LITERAL", "Expected a string literal.");

        /**
         * Parameters:
         * 0: the token that was expected but not found
         */
        public static ParserErrorCode EXPECTED_TOKEN =
         new ParserErrorCode("EXPECTED_TOKEN", "Expected to find '{0}'.");

        public static ParserErrorCode EXPECTED_INSTEAD = _EXPECTED_INSTEAD;

        public static ParserErrorCode EXPECTED_TYPE_NAME =
         new ParserErrorCode("EXPECTED_TYPE_NAME", "Expected a type name.");

        public static ParserErrorCode EXPORT_DIRECTIVE_AFTER_PART_DIRECTIVE =
         new ParserErrorCode("EXPORT_DIRECTIVE_AFTER_PART_DIRECTIVE",
             "Export directives must preceed part directives.",
             correction:
                 "Try moving the export directives before the part directives.");

        public static ParserErrorCode EXTERNAL_AFTER_CONST = _EXTERNAL_AFTER_CONST;

        public static ParserErrorCode EXTERNAL_AFTER_FACTORY = _EXTERNAL_AFTER_FACTORY;

        public static ParserErrorCode EXTERNAL_AFTER_STATIC = _EXTERNAL_AFTER_STATIC;

        public static ParserErrorCode EXTERNAL_CLASS = _EXTERNAL_CLASS;

        public static ParserErrorCode EXTERNAL_CONSTRUCTOR_WITH_BODY =
         new ParserErrorCode("EXTERNAL_CONSTRUCTOR_WITH_BODY",
             "External constructors can't have a body.",
             correction: "Try removing the body of the constructor, or "+
                 "removing the keyword 'external'.");

        public static ParserErrorCode EXTERNAL_ENUM = _EXTERNAL_ENUM;

        public static ParserErrorCode EXTERNAL_FIELD = _EXTERNAL_FIELD;

        public static ParserErrorCode EXTERNAL_GETTER_WITH_BODY =
         new ParserErrorCode(
             "EXTERNAL_GETTER_WITH_BODY", "External getters can't have a body.",
             correction: "Try removing the body of the getter, or "+
                 "removing the keyword 'external'.");

        public static ParserErrorCode EXTERNAL_METHOD_WITH_BODY =
           _EXTERNAL_METHOD_WITH_BODY;

        public static ParserErrorCode EXTERNAL_OPERATOR_WITH_BODY =
         new ParserErrorCode("EXTERNAL_OPERATOR_WITH_BODY",
             "External operators can't have a body.",
             correction: "Try removing the body of the operator, or "+
                 "removing the keyword 'external'.");

        public static ParserErrorCode EXTERNAL_SETTER_WITH_BODY =
         new ParserErrorCode(
             "EXTERNAL_SETTER_WITH_BODY", "External setters can't have a body.",
             correction: "Try removing the body of the setter, or "+
                 "removing the keyword 'external'.");

        public static ParserErrorCode EXTERNAL_TYPEDEF = new ParserErrorCode(
         "EXTERNAL_TYPEDEF", "Typedefs can't be declared to be 'external'.",
           correction: "Try removing the keyword 'external'.");

        public static ParserErrorCode EXTRANEOUS_MODIFIER = new ParserErrorCode(
         "EXTRANEOUS_MODIFIER", "Can't have modifier '{0}' here.",
           correction: "Try removing '{0}'.");

        public static ParserErrorCode FACTORY_TOP_LEVEL_DECLARATION =
         new ParserErrorCode("FACTORY_TOP_LEVEL_DECLARATION",
             "Top-level declarations can't be declared to be 'factory'.",
             correction: "Try removing the keyword 'factory'.");

        public static ParserErrorCode FACTORY_WITH_INITIALIZERS = new ParserErrorCode(
         "FACTORY_WITH_INITIALIZERS",
           "A 'factory' constructor can't have initializers.",
           correction:
               "Try removing the 'factory' keyword to make this a generative constructor, or "+
               "removing the initializers.");

        public static ParserErrorCode FACTORY_WITHOUT_BODY = new ParserErrorCode(
         "FACTORY_WITHOUT_BODY",
           "A non-redirecting 'factory' constructor must have a body.",
           correction: "Try adding a body to the constructor.");

        public static ParserErrorCode FIELD_INITIALIZER_OUTSIDE_CONSTRUCTOR =
         new ParserErrorCode("FIELD_INITIALIZER_OUTSIDE_CONSTRUCTOR",
             "Field formal parameters can only be used in a constructor.",
             correction:
                 "Try replacing the field formal parameter with a normal parameter.");

        public static ParserErrorCode FINAL_AND_COVARIANT = new ParserErrorCode(
         "FINAL_AND_COVARIANT",
           "Members can't be declared to be both 'final' and 'covariant'.",
           correction: "Try removing either the 'final' or 'covariant' keyword.");

        public static ParserErrorCode FINAL_AND_VAR = new ParserErrorCode(
         "FINAL_AND_VAR",
           "Members can't be declared to be both 'final' and 'var'.",
           correction: "Try removing the keyword 'var'.");

        public static ParserErrorCode FINAL_CLASS = new ParserErrorCode(
         "FINAL_CLASS", "Classes can't be declared to be 'final'.",
           correction: "Try removing the keyword 'final'.");

        public static ParserErrorCode FINAL_CONSTRUCTOR = new ParserErrorCode(
         "FINAL_CONSTRUCTOR", "A constructor can't be declared to be 'final'.",
           correction: "Try removing the keyword 'final'.");

        public static ParserErrorCode FINAL_ENUM = new ParserErrorCode(
         "FINAL_ENUM", "Enums can't be declared to be 'final'.",
           correction: "Try removing the keyword 'final'.");

        public static ParserErrorCode FINAL_METHOD = new ParserErrorCode(
         "FINAL_METHOD",
           "Getters, setters and methods can't be declared to be 'final'.",
           correction: "Try removing the keyword 'final'.");

        public static ParserErrorCode FINAL_TYPEDEF = new ParserErrorCode(
         "FINAL_TYPEDEF", "Typedefs can't be declared to be 'final'.",
           correction: "Try removing the keyword 'final'.");

        public static ParserErrorCode FUNCTION_TYPED_PARAMETER_VAR = new ParserErrorCode(
         "FUNCTION_TYPED_PARAMETER_VAR",
           "Function-typed parameters can't specify 'const', 'final' or 'var' in place of a return type.",
           correction: "Try replacing the keyword with a return type.");

        public static ParserErrorCode GETTER_IN_FUNCTION = new ParserErrorCode(
         "GETTER_IN_FUNCTION",
           "Getters can't be defined within methods or functions.",
           correction: "Try moving the getter outside the method or function, or " +
               "converting the getter to a function.");

        public static ParserErrorCode GETTER_WITH_PARAMETERS = new ParserErrorCode(
         "GETTER_WITH_PARAMETERS",
           "Getters must be declared without a parameter list.",
           correction: "Try removing the parameter list, or " +
               "removing the keyword 'get' to define a method rather than a getter.");

        public static ParserErrorCode ILLEGAL_ASSIGNMENT_TO_NON_ASSIGNABLE =
           _ILLEGAL_ASSIGNMENT_TO_NON_ASSIGNABLE;

        public static ParserErrorCode IMPLEMENTS_BEFORE_EXTENDS =
           _IMPLEMENTS_BEFORE_EXTENDS;

        public static ParserErrorCode IMPLEMENTS_BEFORE_ON = _IMPLEMENTS_BEFORE_ON;

        public static ParserErrorCode IMPLEMENTS_BEFORE_WITH = _IMPLEMENTS_BEFORE_WITH;

        public static ParserErrorCode IMPORT_DIRECTIVE_AFTER_PART_DIRECTIVE =
           _IMPORT_DIRECTIVE_AFTER_PART_DIRECTIVE;

        public static ParserErrorCode INITIALIZED_VARIABLE_IN_FOR_EACH =
         new ParserErrorCode("INITIALIZED_VARIABLE_IN_FOR_EACH",
             "The loop variable in a for-each loop can't be initialized.",
             correction:
                 "Try removing the initializer, or using a different kind of loop.");

        public static ParserErrorCode INVALID_AWAIT_IN_FOR = _INVALID_AWAIT_IN_FOR;

        /**
         * Parameters:
         * 0: the invalid escape sequence
         */
        public static ParserErrorCode INVALID_CODE_POINT = new ParserErrorCode(
         "INVALID_CODE_POINT",
           "The escape sequence '{0}' isn't a valid code point.");

        public static ParserErrorCode INVALID_COMMENT_REFERENCE = new ParserErrorCode(
         "INVALID_COMMENT_REFERENCE",
           "Comment references should contain a possibly prefixed identifier and "+
           "can start with 'new', but shouldn't contain anything else.");

        public static ParserErrorCode INVALID_CONSTRUCTOR_NAME = new ParserErrorCode(
         "INVALID_CONSTRUCTOR_NAME",
           "The keyword '{0}' cannot be used to name a constructor.",
           correction: "Try giving the constructor a different name.");

        public static ParserErrorCode INVALID_GENERIC_FUNCTION_TYPE =
         new ParserErrorCode(
             "INVALID_GENERIC_FUNCTION_TYPE", "Invalid generic function type.",
             correction:
                 "Try using a generic function type (returnType 'Function(' parameters ')').");

        public static ParserErrorCode INVALID_HEX_ESCAPE = _INVALID_HEX_ESCAPE;

        public static ParserErrorCode INVALID_LITERAL_IN_CONFIGURATION =
         new ParserErrorCode("INVALID_LITERAL_IN_CONFIGURATION",
             "The literal in a configuration can't contain interpolation.",
             correction: "Try removing the interpolation expressions.");

        /**
         * Parameters:
         * 0: the operator that is invalid
         */
        public static ParserErrorCode INVALID_OPERATOR = _INVALID_OPERATOR;

        /**
         * Parameters:
         * 0: the operator being applied to 'super'
         */
        public static ParserErrorCode INVALID_OPERATOR_FOR_SUPER =
         new ParserErrorCode("INVALID_OPERATOR_FOR_SUPER",
             "The operator '{0}' can't be used with 'super'.");

        public static ParserErrorCode INVALID_STAR_AFTER_ASYNC = new ParserErrorCode(
         "INVALID_STAR_AFTER_ASYNC",
           "The modifier 'async*' isn't allowed for an expression function body.",
           correction: "Try converting the body to a block.");

        public static ParserErrorCode INVALID_SYNC = new ParserErrorCode(
         "INVALID_SYNC",
           "The modifier 'sync' isn't allowed for an expression function body.",
           correction: "Try converting the body to a block.");

        public static ParserErrorCode INVALID_UNICODE_ESCAPE = _INVALID_UNICODE_ESCAPE;

        public static ParserErrorCode LIBRARY_DIRECTIVE_NOT_FIRST =
           _LIBRARY_DIRECTIVE_NOT_FIRST;

        public static ParserErrorCode LOCAL_FUNCTION_DECLARATION_MODIFIER =
         new ParserErrorCode("LOCAL_FUNCTION_DECLARATION_MODIFIER",
             "Local function declarations can't specify any modifiers.",
             correction: "Try removing the modifier.");

        public static ParserErrorCode MISSING_ASSIGNABLE_SELECTOR =
           _MISSING_ASSIGNABLE_SELECTOR;

        public static ParserErrorCode MISSING_ASSIGNMENT_IN_INITIALIZER =
           _MISSING_ASSIGNMENT_IN_INITIALIZER;

        public static ParserErrorCode MISSING_CATCH_OR_FINALLY = new ParserErrorCode(
         "MISSING_CATCH_OR_FINALLY",
           "A try statement must have either a catch or finally clause.",
           correction: "Try adding either a catch or finally clause, or " +
               "remove the try statement.");

        /// TODO(danrubel): Consider splitting this into two separate error messages.
        public static ParserErrorCode MISSING_CLASS_BODY = new ParserErrorCode(
         "MISSING_CLASS_BODY",
           "A class or mixin definition must have a body, even if it is empty.",
           correction: "Try adding a body to your class or mixin.");

        public static ParserErrorCode MISSING_CLOSING_PARENTHESIS =
         new ParserErrorCode(
            "MISSING_CLOSING_PARENTHESIS", "The closing parenthesis is missing.",
             correction: "Try adding the closing parenthesis.");

        public static ParserErrorCode MISSING_CONST_FINAL_VAR_OR_TYPE =
           _MISSING_CONST_FINAL_VAR_OR_TYPE;

        public static ParserErrorCode MISSING_ENUM_BODY = new ParserErrorCode(
         "MISSING_ENUM_BODY",
           "An enum definition must have a body with at least one constant name.",
           correction: "Try adding a body and defining at least one constant.");

        public static ParserErrorCode MISSING_EXPRESSION_IN_INITIALIZER =
         new ParserErrorCode("MISSING_EXPRESSION_IN_INITIALIZER",
             "Expected an expression after the assignment operator.",
             correction: "Try adding the value to be assigned, or "+
                 "remove the assignment operator.");

        public static ParserErrorCode MISSING_EXPRESSION_IN_THROW =
           _MISSING_EXPRESSION_IN_THROW;

        public static ParserErrorCode MISSING_FUNCTION_BODY = new ParserErrorCode(
         "MISSING_FUNCTION_BODY", "A function body must be provided.",
           correction: "Try adding a function body.");

        public static ParserErrorCode MISSING_FUNCTION_KEYWORD = new ParserErrorCode(
         "MISSING_FUNCTION_KEYWORD",
           "Function types must have the keyword 'Function' before the parameter list.",
           correction: "Try adding the keyword 'Function'.");

        public static ParserErrorCode MISSING_FUNCTION_PARAMETERS =
         new ParserErrorCode("MISSING_FUNCTION_PARAMETERS",
             "Functions must have an explicit list of parameters.",
             correction: "Try adding a parameter list.");

        public static ParserErrorCode MISSING_GET = new ParserErrorCode(
         "MISSING_GET",
           "Getters must have the keyword 'get' before the getter name.",
           correction: "Try adding the keyword 'get'.");

        public static ParserErrorCode MISSING_IDENTIFIER =
         new ParserErrorCode("MISSING_IDENTIFIER", "Expected an identifier.");

        public static ParserErrorCode MISSING_INITIALIZER = _MISSING_INITIALIZER;

        public static ParserErrorCode MISSING_KEYWORD_OPERATOR =
           _MISSING_KEYWORD_OPERATOR;

        public static ParserErrorCode MISSING_METHOD_PARAMETERS =
         new ParserErrorCode("MISSING_METHOD_PARAMETERS",
             "Methods must have an explicit list of parameters.",
             correction: "Try adding a parameter list.");

        public static ParserErrorCode MISSING_NAME_FOR_NAMED_PARAMETER =
         new ParserErrorCode("MISSING_NAME_FOR_NAMED_PARAMETER",
             "Named parameters in a function type must have a name",
             correction:
                 "Try providing a name for the parameter or removing the curly braces.");

        public static ParserErrorCode MISSING_NAME_IN_LIBRARY_DIRECTIVE =
         new ParserErrorCode("MISSING_NAME_IN_LIBRARY_DIRECTIVE",
             "Library directives must include a library name.",
             correction:
                 "Try adding a library name after the keyword 'library', or "+
                 "remove the library directive if the library doesn't have any parts.");

        public static ParserErrorCode MISSING_NAME_IN_PART_OF_DIRECTIVE =
         new ParserErrorCode("MISSING_NAME_IN_PART_OF_DIRECTIVE",
             "Part-of directives must include a library name.",
             correction: "Try adding a library name after the 'of'.");

        public static ParserErrorCode MISSING_PREFIX_IN_DEFERRED_IMPORT =
           _MISSING_PREFIX_IN_DEFERRED_IMPORT;

        public static ParserErrorCode MISSING_STAR_AFTER_SYNC = new ParserErrorCode(
         "MISSING_STAR_AFTER_SYNC",
           "The modifier 'sync' must be followed by a star ('*').",
           correction: "Try removing the modifier, or add a star.");

        public static ParserErrorCode MISSING_STATEMENT = _MISSING_STATEMENT;

        /**
         * Parameters:
         * 0: the terminator that is missing
         */
        public static ParserErrorCode MISSING_TERMINATOR_FOR_PARAMETER_GROUP =
         new ParserErrorCode("MISSING_TERMINATOR_FOR_PARAMETER_GROUP",
             "There is no '{0}' to close the parameter group.",
             correction: "Try inserting a '{0}' at the end of the group.");

        public static ParserErrorCode MISSING_TYPEDEF_PARAMETERS =
         new ParserErrorCode("MISSING_TYPEDEF_PARAMETERS",
             "Typedefs must have an explicit list of parameters.",
             correction: "Try adding a parameter list.");

        public static ParserErrorCode MISSING_VARIABLE_IN_FOR_EACH = new ParserErrorCode(
         "MISSING_VARIABLE_IN_FOR_EACH",
           "A loop variable must be declared in a for-each loop before the 'in', but none was found.",
           correction: "Try declaring a loop variable.");

        public static ParserErrorCode MIXED_PARAMETER_GROUPS = new ParserErrorCode(
         "MIXED_PARAMETER_GROUPS",
           "Can't have both positional and named parameters in a single parameter list.",
           correction: "Try choosing a single style of optional parameters.");

        public static ParserErrorCode MULTIPLE_EXTENDS_CLAUSES =
           _MULTIPLE_EXTENDS_CLAUSES;

        public static ParserErrorCode MULTIPLE_IMPLEMENTS_CLAUSES = new ParserErrorCode(
         "MULTIPLE_IMPLEMENTS_CLAUSES",
           "Each class or mixin definition can have at most one implements clause.",
           correction:
               "Try combining all of the implements clauses into a single clause.");

        public static ParserErrorCode MULTIPLE_LIBRARY_DIRECTIVES =
           _MULTIPLE_LIBRARY_DIRECTIVES;

        public static ParserErrorCode MULTIPLE_NAMED_PARAMETER_GROUPS =
         new ParserErrorCode("MULTIPLE_NAMED_PARAMETER_GROUPS",
             "Can't have multiple groups of named parameters in a single parameter list.",
             correction: "Try combining all of the groups into a single group.");

        public static ParserErrorCode MULTIPLE_ON_CLAUSES = _MULTIPLE_ON_CLAUSES;

        public static ParserErrorCode MULTIPLE_PART_OF_DIRECTIVES =
           _MULTIPLE_PART_OF_DIRECTIVES;

        public static ParserErrorCode MULTIPLE_POSITIONAL_PARAMETER_GROUPS =
         new ParserErrorCode("MULTIPLE_POSITIONAL_PARAMETER_GROUPS",
             "Can't have multiple groups of positional parameters in a single parameter list.",
             correction: "Try combining all of the groups into a single group.");

        /**
         * Parameters:
         * 0: the number of variables being declared
         */
        public static ParserErrorCode MULTIPLE_VARIABLES_IN_FOR_EACH =
         new ParserErrorCode(
             "MULTIPLE_VARIABLES_IN_FOR_EACH",
             "A single loop variable must be declared in a for-each loop before "+
             "the 'in', but {0} were found.",
             correction:
                 "Try moving all but one of the declarations inside the loop body.");

        public static ParserErrorCode MULTIPLE_WITH_CLAUSES = _MULTIPLE_WITH_CLAUSES;

        public static ParserErrorCode NAMED_FUNCTION_EXPRESSION = new ParserErrorCode(
         "NAMED_FUNCTION_EXPRESSION", "Function expressions can't be named.",
           correction: "Try removing the name, or "+
               "moving the function expression to a function declaration statement.");

        public static ParserErrorCode NAMED_FUNCTION_TYPE = new ParserErrorCode(
         "NAMED_FUNCTION_TYPE", "Function types can't be named.",
           correction: "Try replacing the name with the keyword 'Function'.");

        public static ParserErrorCode NAMED_PARAMETER_OUTSIDE_GROUP =
         new ParserErrorCode("NAMED_PARAMETER_OUTSIDE_GROUP",
             "Named parameters must be enclosed in curly braces ('{' and '}').",
             correction: "Try surrounding the named parameters in curly braces.");

        public static ParserErrorCode NATIVE_CLAUSE_IN_NON_SDK_CODE =
         new ParserErrorCode(
             "NATIVE_CLAUSE_IN_NON_SDK_CODE",
             "Native clause can only be used in the SDK and code that is loaded " +
             "through native extensions.",
             correction: "Try removing the native clause.");

        public static ParserErrorCode NATIVE_FUNCTION_BODY_IN_NON_SDK_CODE =
         new ParserErrorCode(
             "NATIVE_FUNCTION_BODY_IN_NON_SDK_CODE",
             "Native functions can only be declared in the SDK and code that is " +
             "loaded through native extensions.",
             correction: "Try removing the word 'native'.");

        public static ParserErrorCode NATIVE_CLAUSE_SHOULD_BE_ANNOTATION =
           _NATIVE_CLAUSE_SHOULD_BE_ANNOTATION;

        public static ParserErrorCode NON_CONSTRUCTOR_FACTORY = new ParserErrorCode(
         "NON_CONSTRUCTOR_FACTORY",
           "Only a constructor can be declared to be a factory.",
           correction: "Try removing the keyword 'factory'.");

        public static ParserErrorCode NON_IDENTIFIER_LIBRARY_NAME =
         new ParserErrorCode("NON_IDENTIFIER_LIBRARY_NAME",
             "The name of a library must be an identifier.",
             correction: "Try using an identifier as the name of the library.");

        public static ParserErrorCode NON_PART_OF_DIRECTIVE_IN_PART =
         new ParserErrorCode("NON_PART_OF_DIRECTIVE_IN_PART",
             "The part-of directive must be the only directive in a part.",
             correction: "Try removing the other directives, or " +
                 "moving them to the library for which this is a part.");

        public static ParserErrorCode NON_STRING_LITERAL_AS_URI =
         new ParserErrorCode(
             "NON_STRING_LITERAL_AS_URI", "The URI must be a string literal.",
             correction:
                 "Try enclosing the URI in either single or double quotes.");

        /**
         * Parameters:
         * 0: the operator that the user is trying to define
         */
        public static ParserErrorCode NON_USER_DEFINABLE_OPERATOR =
         new ParserErrorCode("NON_USER_DEFINABLE_OPERATOR",
             "The operator '{0}' isn't user definable.");

        public static ParserErrorCode NORMAL_BEFORE_OPTIONAL_PARAMETERS =
         new ParserErrorCode("NORMAL_BEFORE_OPTIONAL_PARAMETERS",
             "Normal parameters must occur before optional parameters.",
             correction:
                 "Try moving all of the normal parameters before the optional parameters.");

        public static ParserErrorCode POSITIONAL_AFTER_NAMED_ARGUMENT =
         new ParserErrorCode("POSITIONAL_AFTER_NAMED_ARGUMENT",
             "Positional arguments must occur before named arguments.",
             correction:
                 "Try moving all of the positional arguments before the named arguments.");

        public static ParserErrorCode POSITIONAL_PARAMETER_OUTSIDE_GROUP =
         new ParserErrorCode("POSITIONAL_PARAMETER_OUTSIDE_GROUP",
             "Positional parameters must be enclosed in square brackets ('[' and ']').",
             correction:
                 "Try surrounding the positional parameters in square brackets.");

        public static ParserErrorCode PREFIX_AFTER_COMBINATOR =
           _PREFIX_AFTER_COMBINATOR;

        public static ParserErrorCode REDIRECTING_CONSTRUCTOR_WITH_BODY =
           _REDIRECTING_CONSTRUCTOR_WITH_BODY;

        public static ParserErrorCode REDIRECTION_IN_NON_FACTORY_CONSTRUCTOR =
           _REDIRECTION_IN_NON_FACTORY_CONSTRUCTOR;

        public static ParserErrorCode SETTER_IN_FUNCTION = new ParserErrorCode(
         "SETTER_IN_FUNCTION",
           "Setters can't be defined within methods or functions.",
           correction: "Try moving the setter outside the method or function.");

        public static ParserErrorCode STACK_OVERFLOW = new ParserErrorCode(
         "STACK_OVERFLOW",
           "The file has too many nested expressions or statements.",
           correction: "Try simplifying the code.");

        public static ParserErrorCode STATIC_AFTER_CONST = _STATIC_AFTER_CONST;

        public static ParserErrorCode STATIC_AFTER_FINAL = _STATIC_AFTER_FINAL;

        public static ParserErrorCode STATIC_AFTER_VAR = _STATIC_AFTER_VAR;

        public static ParserErrorCode STATIC_CONSTRUCTOR = _STATIC_CONSTRUCTOR;

        public static ParserErrorCode STATIC_GETTER_WITHOUT_BODY = new ParserErrorCode(
         "STATIC_GETTER_WITHOUT_BODY", "A 'static' getter must have a body.",
           correction:
               "Try adding a body to the getter, or removing the keyword 'static'.");

        public static ParserErrorCode STATIC_OPERATOR = _STATIC_OPERATOR;

        public static ParserErrorCode STATIC_SETTER_WITHOUT_BODY = new ParserErrorCode(
         "STATIC_SETTER_WITHOUT_BODY", "A 'static' setter must have a body.",
           correction:
               "Try adding a body to the setter, or removing the keyword 'static'.");

        public static ParserErrorCode STATIC_TOP_LEVEL_DECLARATION =
      new ParserErrorCode("STATIC_TOP_LEVEL_DECLARATION",
          "Top-level declarations can't be declared to be static.",
          correction: "Try removing the keyword 'static'.");

        public static ParserErrorCode SWITCH_HAS_CASE_AFTER_DEFAULT_CASE =
           _SWITCH_HAS_CASE_AFTER_DEFAULT_CASE;

        public static ParserErrorCode SWITCH_HAS_MULTIPLE_DEFAULT_CASES =
           _SWITCH_HAS_MULTIPLE_DEFAULT_CASES;

        public static ParserErrorCode TOP_LEVEL_OPERATOR = _TOP_LEVEL_OPERATOR;

        public static ParserErrorCode TYPE_ARGUMENTS_ON_TYPE_VARIABLE =
           _TYPE_ARGUMENTS_ON_TYPE_VARIABLE;

        public static ParserErrorCode TYPEDEF_IN_CLASS = _TYPEDEF_IN_CLASS;

        /**
         * Parameters:
         * 0: the starting character that was missing
         */
        public static ParserErrorCode UNEXPECTED_TERMINATOR_FOR_PARAMETER_GROUP =
         new ParserErrorCode("UNEXPECTED_TERMINATOR_FOR_PARAMETER_GROUP",
             "There is no '{0}' to open a parameter group.",
             correction: "Try inserting the '{0}' at the appropriate location.");

        /**
         * Parameters:
         * 0: the unexpected text that was found
         */
        public static ParserErrorCode UNEXPECTED_TOKEN = new ParserErrorCode(
         "UNEXPECTED_TOKEN", "Unexpected text '{0}'.",
           correction: "Try removing the text.");

        public static ParserErrorCode WITH_BEFORE_EXTENDS = _WITH_BEFORE_EXTENDS;

        public static ParserErrorCode WRONG_SEPARATOR_FOR_POSITIONAL_PARAMETER =
         new ParserErrorCode("WRONG_SEPARATOR_FOR_POSITIONAL_PARAMETER",
             "The default value of a positional parameter should be preceeded by '='.",
             correction: "Try replacing the ':' with '='.");

        /**
         * Parameters:
         * 0: the terminator that was expected
         * 1: the terminator that was found
         */
        public static ParserErrorCode WRONG_TERMINATOR_FOR_PARAMETER_GROUP =
         new ParserErrorCode("WRONG_TERMINATOR_FOR_PARAMETER_GROUP",
             "Expected '{0}' to close parameter group.",
             correction: "Try replacing '{0}' with '{1}'.");

        public static ParserErrorCode VAR_AND_TYPE = new ParserErrorCode(
         "VAR_AND_TYPE",
           "Variables can't be declared using both 'var' and a type name.",
           correction: "Try removing the keyword 'var'.");

        public static ParserErrorCode VAR_AS_TYPE_NAME = new ParserErrorCode(
         "VAR_AS_TYPE_NAME", "The keyword 'var' can't be used as a type name.",
           correction: "Try using 'dynamic' instead of 'var'.");

        public static ParserErrorCode VAR_CLASS = new ParserErrorCode(
         "VAR_CLASS", "Classes can't be declared to be 'var'.",
           correction: "Try removing the keyword 'var'.");

        public static ParserErrorCode VAR_ENUM = new ParserErrorCode(
         "VAR_ENUM", "Enums can't be declared to be 'var'.",
           correction: "Try removing the keyword 'var'.");

        public static ParserErrorCode VAR_RETURN_TYPE = _VAR_RETURN_TYPE;

        public static ParserErrorCode VAR_TYPEDEF = new ParserErrorCode(
         "VAR_TYPEDEF", "Typedefs can't be declared to be 'var'.",
           correction: "Try removing the keyword 'var', or " +
               "replacing it with the name of the return type.");

        /**
         * Initialize a newly created error code to have the given [name]. The message
         * associated with the error will be created from the given [message]
         * template. The correction associated with the error will be created from the
         * given [correction] template.
         */
        public ParserErrorCode(String name, String message, String correction = "")
            : base(name, message, correction: correction)
        {
        }

        public virtual ErrorSeverity errorSeverity => ErrorSeverity.ERROR;

        public virtual ErrorType type => ErrorType.SYNTACTIC_ERROR;
    }
}
