using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/dart/analysis/declared_variables.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2014, the Dart project authors. Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    //import 'package:analyzer/dart/constant/value.dart';
    //import 'package:analyzer/src/dart/constant/value.dart';
    //import 'package:analyzer/src/generated/resolver.dart' show TypeProvider;

    /**
     * An object used to provide access to the values of variables that have been
     * defined on the command line using the `-D` option.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public class DeclaredVariables
    {
        /**
         * A table mapping the names of declared variables to their values.
         */
        public Dictionary<String, String> _declaredVariables = new Dictionary<String, String> { };

        /**
         * Initialize a newly created set of declared variables in which there are no
         * variables.
         */
        public DeclaredVariables() { }

        /**
         * Initialize a newly created set of declared variables to define variables
         * whose names are the keys in the give [variableMap] and whose values are the
         * corresponding values from the map.
         */
        public void fromMap(Dictionary<String, String> variableMap)
        {
            foreach (var item in variableMap)
                _declaredVariables.Add(item.Key, item.Value);
        }

        /**
         * Return the names of the variables for which a value has been defined.
         */
        public List<String> variableNames => _declaredVariables.Keys.ToList();

        /**
         * Add all variables of [other] to this object.
         */
        [Obsolete]
        void addAll(DeclaredVariables other)
        {
            foreach (var item in other._declaredVariables)
                _declaredVariables.Add(item.Key, item.Value);
        }

        /**
         * Define a variable with the given [name] to have the given [value].
         */
        [Obsolete]
        public void define(String name, String value)
        {
            _declaredVariables[name] = value;
        }

        /**
         * Return the raw string value of the variable with the given [name],
         * or `null` of the variable is not defined.
         */
        public String get(String name) => _declaredVariables[name];

        /**
         * Return the value of the variable with the given [name] interpreted as a
         * 'boolean' value. If the variable is not defined (or [name] is `null`), a
         * DartObject representing "unknown" is returned. If the value cannot be
         * parsed as a boolean, a DartObject representing 'null' is returned. The
         * [typeProvider] is the type provider used to find the type 'bool'.
         */
        public DartObject getBool(TypeProvider typeProvider, String name)
        {
            String value = _declaredVariables[name];
            if (value == null)
            {
                return new DartObjectImpl(typeProvider.boolType, BoolState.UNKNOWN_VALUE);
            }
            if (value == "true")
            {
                return new DartObjectImpl(typeProvider.boolType, BoolState.TRUE_STATE);
            }
            else if (value == "false")
            {
                return new DartObjectImpl(typeProvider.boolType, BoolState.FALSE_STATE);
            }
            return new DartObjectImpl(typeProvider.nullType, NullState.NULL_STATE);
        }

        /**
         * Return the value of the variable with the given [name] interpreted as an
         * integer value. If the variable is not defined (or [name] is `null`), a
         * DartObject representing "unknown" is returned. If the value cannot be
         * parsed as an integer, a DartObject representing 'null' is returned.
         */
        public DartObject getInt(TypeProvider typeProvider, String name)
        {
            String value = _declaredVariables[name];
            if (value == null)
            {
                return new DartObjectImpl(typeProvider.intType, IntState.UNKNOWN_VALUE);
            }
            int bigInteger;
            try
            {
                bigInteger = int.Parse(value);
            }
            catch (FormatException)
            {
                return new DartObjectImpl(typeProvider.nullType, NullState.NULL_STATE);
            }
            return new DartObjectImpl(typeProvider.intType, new IntState(bigInteger));
        }

        /**
         * Return the value of the variable with the given [name] interpreted as a
         * String value, or `null` if the variable is not defined. Return the value of
         * the variable with the given name interpreted as a String value. If the
         * variable is not defined (or [name] is `null`), a DartObject representing
         * "unknown" is returned. The [typeProvider] is the type provider used to find
         * the type 'String'.
         */
        public DartObject getString(TypeProvider typeProvider, String name)
        {
            String value = _declaredVariables[name];
            if (value == null)
            {
                return new DartObjectImpl(
                    typeProvider.stringType, StringState.UNKNOWN_VALUE);
            }
            return new DartObjectImpl(typeProvider.stringType, new StringState(value));
        }
    }
}
