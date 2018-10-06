using Dart2CSharpTranspiler.Parser;
using System;
using System.Collections.Generic;
using System.Text;
using static Dart2CSharpTranspiler.Parser.DartLibrary;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/dart/constant/value.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2014, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    /**
     * The implementation of the class [DartObject].
     */
    //    library analyzer.src.dart.constant.value;

    //    import 'dart:collection';

    //import 'package:analyzer/dart/constant/value.dart';
    //import 'package:analyzer/dart/element/element.dart';
    //import 'package:analyzer/dart/element/type.dart';
    //import 'package:analyzer/error/error.dart';
    //import 'package:analyzer/src/error/codes.dart';
    //import 'package:analyzer/src/generated/resolver.dart' show TypeProvider;
    //    import 'package:analyzer/src/generated/utilities_general.dart';

    /**
     * The state of an object representing a boolean value.
     */
    public class BoolState : InstanceState
    {
        /**
         * An instance representing the boolean value 'false'.
         */
        public static BoolState FALSE_STATE = new BoolState(false);

        /**
         * An instance representing the boolean value 'true'.
         */
        public static BoolState TRUE_STATE = new BoolState(true);

        /**
         * A state that can be used to represent a boolean whose value is not known.
         */
        public static BoolState UNKNOWN_VALUE = new BoolState(null);

        /**
         * The value of this instance.
         */
        public readonly bool? value;

        /**
         * Initialize a newly created state to represent the given [value].
         */
        public BoolState(bool? value)
        {
            this.value = value;
        }


        public int hashCode => value == null ? 0 : (value.Value ? 2 : 3);


        public bool isBool => true;


        public bool isBoolNumStringOrNull => true;


        public bool isUnknown => value == null;


        public String typeName => "bool";


        //bool operator ==(Object object) =>
        //    object is BoolState && identical(value, object.value);


        public BoolState convertToBool() => this;


        public StringState convertToString()
        {
            if (value == null)
            {
                return StringState.UNKNOWN_VALUE;
            }
            return new StringState(value.Value ? "true" : "false");
        }


        public BoolState equalEqual(InstanceState rightOperand)
        {
            //assertBoolNumStringOrNull(rightOperand);
            return isIdentical(rightOperand);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is BoolState)
            {
                bool rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return BoolState.from(identical(value, rightValue));
            }
            else if (rightOperand is DynamicState)
            {
                return UNKNOWN_VALUE;
            }
            return FALSE_STATE;
        }


        public BoolState logicalAnd(InstanceState rightOperandComputer)
        {
            if (value == false)
            {
                return FALSE_STATE;
            }
            InstanceState rightOperand = rightOperandComputer;
            assertBool(rightOperand);
            return value == null ? UNKNOWN_VALUE : rightOperand.convertToBool();
        }


        public BoolState logicalNot()
        {
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            return value.Value ? FALSE_STATE : TRUE_STATE;
        }


        public BoolState logicalOr(InstanceState rightOperandComputer)
        {
            if (value == true)
            {
                return TRUE_STATE;
            }
            InstanceState rightOperand = rightOperandComputer;
            assertBool(rightOperand);
            return value == null ? UNKNOWN_VALUE : rightOperand.convertToBool();
        }


        public String toString() => value == null ? "-unknown-" : (value.Value ? "true" : "false");

        /**
         * Return the boolean state representing the given boolean [value].
         */
        public static BoolState from(bool value) =>
            value ? BoolState.TRUE_STATE : BoolState.FALSE_STATE;
    }

    /**
     * Information about a const constructor invocation.
     */
    public class ConstructorInvocation
    {
        /**
         * The constructor that was called.
         */
        public readonly ConstructorElement constructor;

        /**
         * The positional arguments passed to the constructor.
         */
        public readonly List<DartObjectImpl> positionalArguments;

        /**
         * The named arguments passed to the constructor.
         */
        public readonly Dictionary<String, DartObjectImpl> namedArguments;

        public ConstructorInvocation(
            ConstructorElement constructor, List<DartObjectImpl> positionalArguments, Dictionary<String, DartObjectImpl> namedArguments)
        {
            this.constructor = constructor;
            this.positionalArguments = positionalArguments;
            this.namedArguments = namedArguments;
        }
    }

    /**
     * A representation of an instance of a Dart class.
     */
    public class DartObjectImpl : DartObject
    {
        /**
         * An empty list of objects.
         */
        [Obsolete]
        public static List<DartObjectImpl> EMPTY_LIST = new List<DartObjectImpl>[];


        public readonly ParameterizedType type;

        /**
         * The state of the object.
         */
        readonly InstanceState _state;

        /**
         * Initialize a newly created object to have the given [type] and [_state].
         */
        public DartObjectImpl(ParameterizedType type, InstanceState state)
        {
            this.type = type;
            this._state = state;
        }

        /**
         * Create an object to represent an unknown value.
         */
        public DartObjectImpl validWithUnknownValue(ParameterizedType type)
        {
            if (type.element.library.isDartCore)
            {
                String typeName = type.name;
                if (typeName == "bool")
                {
                    return new DartObjectImpl(type, BoolState.UNKNOWN_VALUE);
                }
                else if (typeName == "double")
                {
                    return new DartObjectImpl(type, DoubleState.UNKNOWN_VALUE);
                }
                else if (typeName == "int")
                {
                    return new DartObjectImpl(type, IntState.UNKNOWN_VALUE);
                }
                else if (typeName == "String")
                {
                    return new DartObjectImpl(type, StringState.UNKNOWN_VALUE);
                }
            }
            return new DartObjectImpl(type, GenericState.UNKNOWN_VALUE);
        }

        public Dictionary<String, DartObjectImpl> fields => _state.fields;


        public int hashCode => JenkinsSmiHash.hash2(type.hashCode, _state.hashCode);


        public bool hasKnownValue => !_state.isUnknown;

        /**
         * Return `true` if this object represents an object whose type is 'bool'.
         */
        public bool isBool => _state.isBool;

        /**
         * Return `true` if this object represents an object whose type is either
         * 'bool', 'num', 'String', or 'Null'.
         */
        public bool isBoolNumStringOrNull => _state.isBoolNumStringOrNull;


        public bool isNull => _state is NullState;

        /**
         * Return `true` if this object represents an unknown value.
         */
        public bool isUnknown => _state.isUnknown;

        /**
         * Return `true` if this object represents an instance of a user-defined
         * class.
         */
        public bool isUserDefinedObject => _state is GenericState;


        //bool operator ==(Object object)
        //  {
        //      if (object is DartObjectImpl)
        //      {
        //          return type == object.type && _state == object._state;
        //      }
        //      return false;
        //  }

        /**
         * Return the result of invoking the '+' operator on this object with the
         * given [rightOperand]. The [typeProvider] is the type provider used to find
         * known types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl add(TypeProvider typeProvider, DartObjectImpl rightOperand)
        {
            InstanceState result = _state.add(rightOperand._state);
            if (result is IntState)
            {
                return new DartObjectImpl(typeProvider.intType, result);
            }
            else if (result is DoubleState)
            {
                return new DartObjectImpl(typeProvider.doubleType, result);
            }
            else if (result is NumState)
            {
                return new DartObjectImpl(typeProvider.numType, result);
            }
            else if (result is StringState)
            {
                return new DartObjectImpl(typeProvider.stringType, result);
            }
            // We should never get here.
            throw new Exception("add returned a ${result.runtimeType}");
        }

        /**
         * Return the result of invoking the '&' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl bitAnd(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(
            typeProvider.intType, _state.bitAnd(rightOperand._state));

        /**
         * Return the result of invoking the '~' operator on this object. The
         * [typeProvider] is the type provider used to find known types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl bitNot(TypeProvider typeProvider) =>
        new DartObjectImpl(typeProvider.intType, _state.bitNot());

        /**
         * Return the result of invoking the '|' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl bitOr(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(
            typeProvider.intType, _state.bitOr(rightOperand._state));

        /**
         * Return the result of invoking the '^' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl bitXor(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(
            typeProvider.intType, _state.bitXor(rightOperand._state));

        /**
         * Return the result of invoking the ' ' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl concatenate(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(
            typeProvider.stringType, _state.concatenate(rightOperand._state));

        /**
         * Return the result of applying boolean conversion to this object. The
         * [typeProvider] is the type provider used to find known types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl convertToBool(TypeProvider typeProvider)
        {
            InterfaceType boolType = typeProvider.boolType;
            if (identical(type, boolType))
            {
                return this;
            }
            return new DartObjectImpl(boolType, _state.convertToBool());
        }

        /**
         * Return the result of invoking the '/' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for
         * an object of this kind.
         */
        public DartObjectImpl divide(
        TypeProvider typeProvider, DartObjectImpl rightOperand)
        {
            InstanceState result = _state.divide(rightOperand._state);
            if (result is IntState)
            {
                return new DartObjectImpl(typeProvider.intType, result);
            }
            else if (result is DoubleState)
            {
                return new DartObjectImpl(typeProvider.doubleType, result);
            }
            else if (result is NumState)
            {
                return new DartObjectImpl(typeProvider.numType, result);
            }
            // We should never get here.
            throw new Exception("divide returned a ${result.runtimeType}");
        }

        /**
         * Return the result of invoking the '==' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl equalEqual(
        TypeProvider typeProvider, DartObjectImpl rightOperand)
        {
            if (isNull || rightOperand.isNull)
            {
                return new DartObjectImpl(
                    typeProvider.boolType,
                    isNull && rightOperand.isNull
                        ? BoolState.TRUE_STATE
                        : BoolState.FALSE_STATE);
            }
            if (isBoolNumStringOrNull)
            {
                return new DartObjectImpl(
                    typeProvider.boolType, _state.equalEqual(rightOperand._state));
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_TYPE_BOOL_NUM_STRING);
        }


        public DartObject getField(String name)
        {
            InstanceState state = _state;
            if (state is GenericState)
            {
                return state.fields[name];
            }
            return null;
        }

        /// Gets the constructor that was called to create this value, if this is a
        /// const constructor invocation. Otherwise returns null.
        public ConstructorInvocation getInvocation()
        {
            InstanceState state = _state;
            if (state is GenericState)
            {
                return state.invocation;
            }
            return null;
        }

        /**
         * Return the result of invoking the '&gt;' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl greaterThan(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(
            typeProvider.boolType, _state.greaterThan(rightOperand._state));

        /**
         * Return the result of invoking the '&gt;=' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl greaterThanOrEqual(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(typeProvider.boolType,
            _state.greaterThanOrEqual(rightOperand._state));

        /**
         * Return the result of invoking the '~/' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl integerDivide(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(
            typeProvider.intType, _state.integerDivide(rightOperand._state));

        /**
         * Return the result of invoking the identical function on this object with
         * the [rightOperand]. The [typeProvider] is the type provider used to find
         * known types.
         */
        public DartObjectImpl isIdentical(
        TypeProvider typeProvider, DartObjectImpl rightOperand)
        {
            return new DartObjectImpl(
                typeProvider.boolType, _state.isIdentical(rightOperand._state));
        }

        /**
         * Return the result of invoking the '&lt;' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl lessThan(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(
            typeProvider.boolType, _state.lessThan(rightOperand._state));

        /**
         * Return the result of invoking the '&lt;=' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl lessThanOrEqual(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(
            typeProvider.boolType, _state.lessThanOrEqual(rightOperand._state));

        /**
         * Return the result of invoking the '&&' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl logicalAnd(
            TypeProvider typeProvider, DartObjectImpl rightOperandComputer()) =>
        new DartObjectImpl(typeProvider.boolType,
            _state.logicalAnd(() => rightOperandComputer()?._state));

        /**
         * Return the result of invoking the '!' operator on this object. The
         * [typeProvider] is the type provider used to find known types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl logicalNot(TypeProvider typeProvider) =>
        new DartObjectImpl(typeProvider.boolType, _state.logicalNot());

        /**
         * Return the result of invoking the '||' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl logicalOr(
            TypeProvider typeProvider, DartObjectImpl rightOperandComputer()) =>
        new DartObjectImpl(typeProvider.boolType,
            _state.logicalOr(() => rightOperandComputer()?._state));

        /**
         * Return the result of invoking the '-' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl minus(TypeProvider typeProvider, DartObjectImpl rightOperand)
        {
            InstanceState result = _state.minus(rightOperand._state);
            if (result is IntState)
            {
                return new DartObjectImpl(typeProvider.intType, result);
            }
            else if (result is DoubleState)
            {
                return new DartObjectImpl(typeProvider.doubleType, result);
            }
            else if (result is NumState)
            {
                return new DartObjectImpl(typeProvider.numType, result);
            }
            // We should never get here.
            throw new Exception("minus returned a ${result.runtimeType}");
        }

        /**
         * Return the result of invoking the '-' operator on this object. The
         * [typeProvider] is the type provider used to find known types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl negated(TypeProvider typeProvider)
        {
            InstanceState result = _state.negated();
            if (result is IntState)
            {
                return new DartObjectImpl(typeProvider.intType, result);
            }
            else if (result is DoubleState)
            {
                return new DartObjectImpl(typeProvider.doubleType, result);
            }
            else if (result is NumState)
            {
                return new DartObjectImpl(typeProvider.numType, result);
            }
            // We should never get here.
            throw new Exception("negated returned a ${result.runtimeType}");
        }

        /**
         * Return the result of invoking the '!=' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl notEqual(
        TypeProvider typeProvider, DartObjectImpl rightOperand)
        {
            return equalEqual(typeProvider, rightOperand).logicalNot(typeProvider);
        }

        /**
         * Return the result of converting this object to a 'String'. The
         * [typeProvider] is the type provider used to find known types.
         *
         * Throws an [EvaluationException] if the object cannot be converted to a
         * 'String'.
         */
        public DartObjectImpl performToString(TypeProvider typeProvider)
        {
            InterfaceType stringType = typeProvider.stringType;
            if (identical(type, stringType))
            {
                return this;
            }
            return new DartObjectImpl(stringType, _state.convertToString());
        }

        /**
         * Return the result of invoking the '%' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl remainder(
        TypeProvider typeProvider, DartObjectImpl rightOperand)
        {
            InstanceState result = _state.remainder(rightOperand._state);
            if (result is IntState)
            {
                return new DartObjectImpl(typeProvider.intType, result);
            }
            else if (result is DoubleState)
            {
                return new DartObjectImpl(typeProvider.doubleType, result);
            }
            else if (result is NumState)
            {
                return new DartObjectImpl(typeProvider.numType, result);
            }
            // We should never get here.
            throw new Exception("remainder returned a ${result.runtimeType}");
        }

        /**
         * Return the result of invoking the '&lt;&lt;' operator on this object with
         * the [rightOperand]. The [typeProvider] is the type provider used to find
         * known types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl shiftLeft(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(
            typeProvider.intType, _state.shiftLeft(rightOperand._state));

        /**
         * Return the result of invoking the '&gt;&gt;' operator on this object with
         * the [rightOperand]. The [typeProvider] is the type provider used to find
         * known types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl shiftRight(
            TypeProvider typeProvider, DartObjectImpl rightOperand) =>
        new DartObjectImpl(
            typeProvider.intType, _state.shiftRight(rightOperand._state));

        /**
         * Return the result of invoking the 'length' getter on this object. The
         * [typeProvider] is the type provider used to find known types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl stringLength(TypeProvider typeProvider) =>
        new DartObjectImpl(typeProvider.intType, _state.stringLength());

        /**
         * Return the result of invoking the '*' operator on this object with the
         * [rightOperand]. The [typeProvider] is the type provider used to find known
         * types.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public DartObjectImpl times(TypeProvider typeProvider, DartObjectImpl rightOperand)
        {
            InstanceState result = _state.times(rightOperand._state);
            if (result is IntState)
            {
                return new DartObjectImpl(typeProvider.intType, result);
            }
            else if (result is DoubleState)
            {
                return new DartObjectImpl(typeProvider.doubleType, result);
            }
            else if (result is NumState)
            {
                return new DartObjectImpl(typeProvider.numType, result);
            }
            // We should never get here.
            throw new Exception("times returned a ${result.runtimeType}");
        }


        public bool? toBoolValue()
        {
            InstanceState state = _state;
            if (state is BoolState boolState)
            {
                return boolState.value;
            }
            return null;
        }


        public double? toDoubleValue()
        {
            InstanceState state = _state;
            if (state is DoubleState dState)
            {
                return dState.value;
            }
            return null;
        }

        /**
         * If this constant represents a library function or static method, returns
         * it, otherwise returns `null`.
         */
        public ExecutableElement toFunctionValue()
        {
            InstanceState state = _state;
            return state is FunctionState ? state._element : null;
        }


        public int? toIntValue()
        {
            InstanceState state = _state;
            if (state is IntState iState)
            {
                return iState.value;
            }
            return null;
        }


        public List<DartObject> toListValue()
        {
            InstanceState state = _state;
            if (state is ListState lState)
            {
                return lState._elements;
            }
            return null;
        }


        public Dictionary<DartObject, DartObject> toMapValue()
        {
            InstanceState state = _state;
            if (state is MapState)
            {
                return state._entries;
            }
            return null;
        }


        public String toString() => "${type.displayName} ($_state)";


        public String toStringValue()
        {
            InstanceState state = _state;
            if (state is StringState)
            {
                return state.value;
            }
            return null;
        }


        public String toSymbolValue()
        {
            InstanceState state = _state;
            if (state is SymbolState)
            {
                return state.value;
            }
            return null;
        }


        public DartType toTypeValue()
        {
            InstanceState state = _state;
            if (state is TypeState)
            {
                return state._type;
            }
            return null;
        }
    }

    /**
     * The state of an object representing a double.
     */
    public class DoubleState : NumState
    {
        /**
         * A state that can be used to represent a double whose value is not known.
         */
        public static DoubleState UNKNOWN_VALUE = new DoubleState(null);

        /**
         * The value of this instance.
         */
        public readonly double value;

        /**
         * Initialize a newly created state to represent a double with the given
         * [value].
         */
        public DoubleState(this.value);


        public int get hashCode => value == null ? 0 : value.hashCode;

  
  public bool get isBoolNumStringOrNull => true;

  
  public bool get isUnknown => value == null;

  
  public String get typeName => "double";


  //bool operator ==(Object object) =>
  //    object is DoubleState && (value == object.value);


public NumState add(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new DoubleState(value + rightValue.toDouble());
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new DoubleState(value + rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public StringState convertToString()
        {
            if (value == null)
            {
                return StringState.UNKNOWN_VALUE;
            }
            return new StringState(value.toString());
        }


        public NumState divide(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new DoubleState(value / rightValue.toDouble());
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new DoubleState(value / rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return isIdentical(rightOperand);
        }


        public BoolState greaterThan(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value > rightValue.toDouble());
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value > rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public BoolState greaterThanOrEqual(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value >= rightValue.toDouble());
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value >= rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public IntState integerDivide(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return IntState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return IntState.UNKNOWN_VALUE;
                }
                double result = value / rightValue.toDouble();
                return new IntState(result.toInt());
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return IntState.UNKNOWN_VALUE;
                }
                double result = value / rightValue;
                return new IntState(result.toInt());
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return IntState.UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value == rightValue);
            }
            else if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value == rightValue.toDouble());
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            return BoolState.FALSE_STATE;
        }


        public BoolState lessThan(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value < rightValue.toDouble());
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value < rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public BoolState lessThanOrEqual(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value <= rightValue.toDouble());
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value <= rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public NumState minus(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new DoubleState(value - rightValue.toDouble());
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new DoubleState(value - rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public NumState negated()
        {
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            return new DoubleState(-(value));
        }


        public NumState remainder(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new DoubleState(value % rightValue.toDouble());
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new DoubleState(value % rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public NumState times(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new DoubleState(value * rightValue.toDouble());
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new DoubleState(value * rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public String toString() => value == null ? "-unknown-" : value.toString();
    }

    /**
     * The state of an object representing a Dart object for which there is no type
     * information.
     */
    public class DynamicState : InstanceState
    {
        /**
         * The unique instance of this class.
         */
        public static DynamicState DYNAMIC_STATE = new DynamicState();


        public bool get isBool => true;

  
  public bool get isBoolNumStringOrNull => true;

  
  public String get typeName => "dynamic";


public NumState add(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return _unknownNum(rightOperand);
        }


        public IntState bitAnd(InstanceState rightOperand)
        {
            assertIntOrNull(rightOperand);
            return IntState.UNKNOWN_VALUE;
        }


        public IntState bitNot() => IntState.UNKNOWN_VALUE;


        IntState bitOr(InstanceState rightOperand)
        {
            assertIntOrNull(rightOperand);
            return IntState.UNKNOWN_VALUE;
        }


        IntState bitXor(InstanceState rightOperand)
        {
            assertIntOrNull(rightOperand);
            return IntState.UNKNOWN_VALUE;
        }


        StringState concatenate(InstanceState rightOperand)
        {
            assertString(rightOperand);
            return StringState.UNKNOWN_VALUE;
        }


        BoolState convertToBool() => BoolState.UNKNOWN_VALUE;


        StringState convertToString() => StringState.UNKNOWN_VALUE;


        NumState divide(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return _unknownNum(rightOperand);
        }


        BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return BoolState.UNKNOWN_VALUE;
        }


        BoolState greaterThan(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return BoolState.UNKNOWN_VALUE;
        }


        BoolState greaterThanOrEqual(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return BoolState.UNKNOWN_VALUE;
        }


        IntState integerDivide(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return IntState.UNKNOWN_VALUE;
        }


        BoolState isIdentical(InstanceState rightOperand)
        {
            return BoolState.UNKNOWN_VALUE;
        }


        BoolState lessThan(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return BoolState.UNKNOWN_VALUE;
        }


        BoolState lessThanOrEqual(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return BoolState.UNKNOWN_VALUE;
        }


        BoolState logicalAnd(InstanceState rightOperandComputer())
        {
            assertBool(rightOperandComputer());
            return BoolState.UNKNOWN_VALUE;
        }


        BoolState logicalNot() => BoolState.UNKNOWN_VALUE;


        BoolState logicalOr(InstanceState rightOperandComputer())
        {
            InstanceState rightOperand = rightOperandComputer();
            assertBool(rightOperand);
            return rightOperand.convertToBool();
        }


        NumState minus(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return _unknownNum(rightOperand);
        }


        NumState negated() => NumState.UNKNOWN_VALUE;


        NumState remainder(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return _unknownNum(rightOperand);
        }


        IntState shiftLeft(InstanceState rightOperand)
        {
            assertIntOrNull(rightOperand);
            return IntState.UNKNOWN_VALUE;
        }


        IntState shiftRight(InstanceState rightOperand)
        {
            assertIntOrNull(rightOperand);
            return IntState.UNKNOWN_VALUE;
        }


        NumState times(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return _unknownNum(rightOperand);
        }

        /**
         * Return an object representing an unknown numeric value whose type is based
         * on the type of the [rightOperand].
         */
        NumState _unknownNum(InstanceState rightOperand)
        {
            if (rightOperand is IntState)
            {
                return IntState.UNKNOWN_VALUE;
            }
            else if (rightOperand is DoubleState)
            {
                return DoubleState.UNKNOWN_VALUE;
            }
            return NumState.UNKNOWN_VALUE;
        }
    }

    /**
     * Exception that would be thrown during the evaluation of Dart code.
     */
    public class EvaluationException
    {
        /**
         * The error code associated with the exception.
         */
        public readonly ErrorCode errorCode;

        /**
         * Initialize a newly created exception to have the given [errorCode].
         */
        public EvaluationException(ErrorCode errorCode)
        {
            this.errorCode = errorCode;
        }
    }

    /**
     * The state of an object representing a function.
     */
    public class FunctionState : InstanceState
    {
        /**
         * The element representing the function being modeled.
         */
        readonly ExecutableElement _element;

        /**
         * Initialize a newly created state to represent the function with the given
         * [element].
         */
        public FunctionState(ExecutableElement _element)
        {
            this._element = _element;
        }


        public int hashCode => _element == null ? 0 : _element.hashCode;


        public String typeName => "Function";


        //  bool operator == (Object object) =>
        //object is FunctionState && (_element == object._element);


        public StringState convertToString()
        {
            if (_element == null)
            {
                return StringState.UNKNOWN_VALUE;
            }
            return new StringState(_element.name);
        }


        public BoolState equalEqual(InstanceState rightOperand)
        {
            return isIdentical(rightOperand);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (_element == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is FunctionState)
            {
                ExecutableElement rightElement = rightOperand._element;
                if (rightElement == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(_element == rightElement);
            }
            else if (rightOperand is DynamicState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            return BoolState.FALSE_STATE;
        }


        public String toString() => _element == null ? "-unknown-" : _element.name;
    }

    /**
     * The state of an object representing a Dart object for which there is no more
     * specific state.
     */
    public class GenericState : InstanceState
    {
        /**
         * Pseudo-field that we use to represent fields in the superclass.
         */
        static String SUPERCLASS_FIELD = "(super)";

        /**
         * A state that can be used to represent an object whose state is not known.
         */
        static GenericState UNKNOWN_VALUE =
            new GenericState(new Dictionary<String, DartObjectImpl>());

        /**
         * The values of the fields of this instance.
         */
        readonly Dictionary<String, DartObjectImpl> _fieldMap;

        /**
         * Information about the constructor invoked to generate this instance.
         */
        readonly ConstructorInvocation invocation;

        /**
         * Initialize a newly created state to represent a newly created object. The
         * [fieldMap] contains the values of the fields of the instance.
         */
        public GenericState(Dictionary<String, DartObjectImpl> _fieldMap, ConstructorInvocation invocation = null)
        {
            this._fieldMap = _fieldMap;
            this.invocation = invocation;
        }


        public Dictionary<String, DartObjectImpl> fields => _fieldMap;


        public int hashCode
        {
            get
            {
                int hashCode = 0;
                foreach (DartObjectImpl value in _fieldMap.values)
                {
                    hashCode += value.hashCode;
                }
                return hashCode;
            }
        }


        public bool isUnknown => identical(this, UNKNOWN_VALUE);


        public String typeName => "user defined type";


        //bool operator ==(Object object)
        //      {
        //          if (object is GenericState)
        //          {
        //              HashSet<String> otherFields =
        //                  new HashSet<String>.from(object._fieldMap.keys.toSet());
        //    for (String fieldName in _fieldMap.keys.toSet())
        //              {
        //                  if (_fieldMap[fieldName] != object._fieldMap[fieldName])
        //                  {
        //                      return false;
        //                  }
        //                  otherFields.remove(fieldName);
        //              }
        //    for (String fieldName in otherFields)
        //              {
        //                  if (object._fieldMap[fieldName] != _fieldMap[fieldName])
        //                  {
        //                      return false;
        //                  }
        //              }
        //              return true;
        //          }
        //          return false;
        //      }


        public StringState convertToString() => StringState.UNKNOWN_VALUE;


        public BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return isIdentical(rightOperand);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (rightOperand is DynamicState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            return BoolState.from(this == rightOperand);
        }


        public String toString()
        {
            StringBuffer buffer = new StringBuffer();
            List<String> fieldNames = _fieldMap.Keys.toList();
            fieldNames.sort();
            bool first = true;
            foreach (String fieldName in fieldNames)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    buffer.write("; ");
                }
                buffer.write(fieldName);
                buffer.write(" = ");
                buffer.write(_fieldMap[fieldName]);
            }
            return buffer.toString();
        }
    }

    /**
     * The state of an object representing a Dart object.
     */
    public abstract class InstanceState
    {
        /**
         * If this represents a generic dart object, return a map from its field names
         * to their values. Otherwise return null.
         */
        public Dictionary<String, DartObjectImpl> fields => null;

        /**
         * Return `true` if this object represents an object whose type is 'bool'.
         */
        public bool isBool => false;

        /**
         * Return `true` if this object represents an object whose type is either
         * 'bool', 'num', 'String', or 'Null'.
         */
        public bool isBoolNumStringOrNull => false;

        /**
         * Return `true` if this object represents an unknown value.
         */
        public bool isUnknown => false;

        /**
         * Return the name of the type of this value.
         */
        public abstract String typeName { get; }

        /**
         * Return the result of invoking the '+' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public InstanceState add(InstanceState rightOperand)
        {
            if (this is StringState && rightOperand is StringState)
            {
                return concatenate(rightOperand);
            }
            assertNumOrNull(this);
            assertNumOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Throw an exception if the given [state] does not represent a boolean value.
         */
        public void assertBool(InstanceState state)
        {
            if (!(state is BoolState || state is DynamicState))
            {
                throw new EvaluationException(CompileTimeErrorCode.CONST_EVAL_TYPE_BOOL);
            }
        }

        /**
         * Throw an exception if the given [state] does not represent a boolean,
         * numeric, string or null value.
         */
        public void assertBoolNumStringOrNull(InstanceState state)
        {
            if (!(state is BoolState ||
                state is DoubleState ||
                state is IntState ||
                state is NumState ||
                state is StringState ||
                state is NullState ||
                state is DynamicState))
            {
                throw new EvaluationException(
                    CompileTimeErrorCode.CONST_EVAL_TYPE_BOOL_NUM_STRING);
            }
        }

        /**
         * Throw an exception if the given [state] does not represent an integer or
         * null value.
         */
        public void assertIntOrNull(InstanceState state)
        {
            if (!(state is IntState ||
                state is NumState ||
                state is NullState ||
                state is DynamicState))
            {
                throw new EvaluationException(CompileTimeErrorCode.CONST_EVAL_TYPE_INT);
            }
        }

        /**
         * Throw an exception if the given [state] does not represent a boolean,
         * numeric, string or null value.
         */
        public void assertNumOrNull(InstanceState state)
        {
            if (!(state is DoubleState ||
                state is IntState ||
                state is NumState ||
                state is NullState ||
                state is DynamicState))
            {
                throw new EvaluationException(CompileTimeErrorCode.CONST_EVAL_TYPE_NUM);
            }
        }

        /**
         * Throw an exception if the given [state] does not represent a String value.
         */
        public void assertString(InstanceState state)
        {
            if (!(state is StringState || state is DynamicState))
            {
                throw new EvaluationException(CompileTimeErrorCode.CONST_EVAL_TYPE_BOOL);
            }
        }

        /**
         * Return the result of invoking the '&' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public IntState bitAnd(InstanceState rightOperand)
        {
            assertIntOrNull(this);
            assertIntOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '~' operator on this object.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public IntState bitNot()
        {
            assertIntOrNull(this);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '|' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public IntState bitOr(InstanceState rightOperand)
        {
            assertIntOrNull(this);
            assertIntOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '^' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public IntState bitXor(InstanceState rightOperand)
        {
            assertIntOrNull(this);
            assertIntOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the ' ' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public StringState concatenate(InstanceState rightOperand)
        {
            assertString(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of applying boolean conversion to this object.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public BoolState convertToBool() => BoolState.FALSE_STATE;

        /**
         * Return the result of converting this object to a String.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public abstract StringState convertToString();

        /**
         * Return the result of invoking the '/' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public NumState divide(InstanceState rightOperand)
        {
            assertNumOrNull(this);
            assertNumOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '==' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public abstract BoolState equalEqual(InstanceState rightOperand);

        /**
         * Return the result of invoking the '&gt;' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public BoolState greaterThan(InstanceState rightOperand)
        {
            assertNumOrNull(this);
            assertNumOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '&gt;=' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public BoolState greaterThanOrEqual(InstanceState rightOperand)
        {
            assertNumOrNull(this);
            assertNumOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '~/' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public IntState integerDivide(InstanceState rightOperand)
        {
            assertNumOrNull(this);
            assertNumOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the identical function on this object with
         * the [rightOperand].
         */
        public abstract BoolState isIdentical(InstanceState rightOperand);

        /**
         * Return the result of invoking the '&lt;' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public BoolState lessThan(InstanceState rightOperand)
        {
            assertNumOrNull(this);
            assertNumOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '&lt;=' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public BoolState lessThanOrEqual(InstanceState rightOperand)
        {
            assertNumOrNull(this);
            assertNumOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '&&' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public BoolState logicalAnd(InstanceState rightOperandComputer())
        {
            assertBool(this);
            if (convertToBool() == BoolState.FALSE_STATE)
            {
                return this;
            }
            InstanceState rightOperand = rightOperandComputer();
            assertBool(rightOperand);
            return rightOperand.convertToBool();
        }

        /**
         * Return the result of invoking the '!' operator on this object.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public BoolState logicalNot()
        {
            assertBool(this);
            return BoolState.TRUE_STATE;
        }

        /**
         * Return the result of invoking the '||' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public BoolState logicalOr(InstanceState rightOperandComputer())
        {
            assertBool(this);
            if (convertToBool() == BoolState.TRUE_STATE)
            {
                return this;
            }
            InstanceState rightOperand = rightOperandComputer();
            assertBool(rightOperand);
            return rightOperand.convertToBool();
        }

        /**
         * Return the result of invoking the '-' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public NumState minus(InstanceState rightOperand)
        {
            assertNumOrNull(this);
            assertNumOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '-' operator on this object.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public NumState negated()
        {
            assertNumOrNull(this);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '%' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public NumState remainder(InstanceState rightOperand)
        {
            assertNumOrNull(this);
            assertNumOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '&lt;&lt;' operator on this object with
         * the [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public IntState shiftLeft(InstanceState rightOperand)
        {
            assertIntOrNull(this);
            assertIntOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '&gt;&gt;' operator on this object with
         * the [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public IntState shiftRight(InstanceState rightOperand)
        {
            assertIntOrNull(this);
            assertIntOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the 'length' getter on this object.
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public IntState stringLength()
        {
            assertString(this);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }

        /**
         * Return the result of invoking the '*' operator on this object with the
         * [rightOperand].
         *
         * Throws an [EvaluationException] if the operator is not appropriate for an
         * object of this kind.
         */
        public NumState times(InstanceState rightOperand)
        {
            assertNumOrNull(this);
            assertNumOrNull(rightOperand);
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }
    }

    /**
     * The state of an object representing an int.
     */
    public class IntState : NumState
    {
        /**
         * A state that can be used to represent an int whose value is not known.
         */
        public static IntState UNKNOWN_VALUE = new IntState(null);

        /**
         * The value of this instance.
         */
        public readonly int value;

        /**
         * Initialize a newly created state to represent an int with the given
         * [value].
         */
        public IntState(int value)
        {
            this.value = value;
        }


        public int hashCode => value == null ? 0 : value.hashCode;


        public bool isBoolNumStringOrNull => true;


        public bool isUnknown => value == null;


        public String typeName => "int";


        //bool operator ==(Object object) =>
        //    object is IntState && (value == object.value);


        public NumState add(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                if (rightOperand is DoubleState)
                {
                    return DoubleState.UNKNOWN_VALUE;
                }
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new IntState(value + rightValue);
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return DoubleState.UNKNOWN_VALUE;
                }
                return new DoubleState(value.toDouble() + rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public IntState bitAnd(InstanceState rightOperand)
        {
            assertIntOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new IntState(value & rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public IntState bitNot()
        {
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            return new IntState(~value);
        }


        public IntState bitOr(InstanceState rightOperand)
        {
            assertIntOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new IntState(value | rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public IntState bitXor(InstanceState rightOperand)
        {
            assertIntOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new IntState(value ^ rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public StringState convertToString()
        {
            if (value == null)
            {
                return StringState.UNKNOWN_VALUE;
            }
            return new StringState(value.toString());
        }


        public NumState divide(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return DoubleState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return DoubleState.UNKNOWN_VALUE;
                }
                else
                {
                    return new DoubleState(value.toDouble() / rightValue.toDouble());
                }
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return DoubleState.UNKNOWN_VALUE;
                }
                return new DoubleState(value.toDouble() / rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return DoubleState.UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return isIdentical(rightOperand);
        }


        public BoolState greaterThan(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value.compareTo(rightValue) > 0);
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value.toDouble() > rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public BoolState greaterThanOrEqual(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value.compareTo(rightValue) >= 0);
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value.toDouble() >= rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public IntState integerDivide(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                else if (rightValue == 0)
                {
                    throw new EvaluationException(
                        CompileTimeErrorCode.CONST_EVAL_THROWS_IDBZE);
                }
                return new IntState(value ~/ rightValue);
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                double result = value.toDouble() / rightValue;
                return new IntState(result.toInt());
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value == rightValue);
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(rightValue == value.toDouble());
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            return BoolState.FALSE_STATE;
        }


        public BoolState lessThan(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value.compareTo(rightValue) < 0);
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value.toDouble() < rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public BoolState lessThanOrEqual(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value.compareTo(rightValue) <= 0);
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value.toDouble() <= rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public NumState minus(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                if (rightOperand is DoubleState)
                {
                    return DoubleState.UNKNOWN_VALUE;
                }
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new IntState(value - rightValue);
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return DoubleState.UNKNOWN_VALUE;
                }
                return new DoubleState(value.toDouble() - rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public NumState negated()
        {
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            return new IntState(-value);
        }


        public NumState remainder(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                if (rightOperand is DoubleState)
                {
                    return DoubleState.UNKNOWN_VALUE;
                }
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                if (rightValue != 0)
                {
                    return new IntState(value % rightValue);
                }
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return DoubleState.UNKNOWN_VALUE;
                }
                return new DoubleState(value.toDouble() % rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public IntState shiftLeft(InstanceState rightOperand)
        {
            assertIntOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                else if (rightValue.bitLength > 31)
                {
                    return UNKNOWN_VALUE;
                }
                if (rightValue >= 0)
                {
                    return new IntState(value << rightValue);
                }
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public IntState shiftRight(InstanceState rightOperand)
        {
            assertIntOrNull(rightOperand);
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                else if (rightValue.bitLength > 31)
                {
                    return UNKNOWN_VALUE;
                }
                if (rightValue >= 0)
                {
                    return new IntState(value >> rightValue);
                }
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public NumState times(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (value == null)
            {
                if (rightOperand is DoubleState)
                {
                    return DoubleState.UNKNOWN_VALUE;
                }
                return UNKNOWN_VALUE;
            }
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new IntState(value * rightValue);
            }
            else if (rightOperand is DoubleState)
            {
                double rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return DoubleState.UNKNOWN_VALUE;
                }
                return new DoubleState(value.toDouble() * rightValue);
            }
            else if (rightOperand is DynamicState || rightOperand is NumState)
            {
                return UNKNOWN_VALUE;
            }
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public String toString() => value == null ? "-unknown-" : value.toString();
    }

    /**
     * The state of an object representing a list.
     */
    public class ListState : InstanceState
    {
        /**
         * The elements of the list.
         */
        public readonly List<DartObjectImpl> _elements;

        /**
         * Initialize a newly created state to represent a list with the given
         * [elements].
         */
        public ListState(List<DartObjectImpl> _elements)
        {
            this._elements = _elements;
        }


        public int hashCode
        {
            get
            {
                int value = 0;
                int count = _elements.Count;
                for (int i = 0; i < count; i++)
                {
                    value = (value << 3) ^ _elements[i].hashCode;
                }
                return value;
            }
        }


        public String typeName => "List";


        //bool operator == (Object object) {
        //    if (object is ListState)
        //    {
        //        List<DartObjectImpl> otherElements = object._elements;
        //        int count = _elements.length;
        //        if (otherElements.length != count)
        //        {
        //            return false;
        //        }
        //        else if (count == 0)
        //        {
        //            return true;
        //        }
        //        for (int i = 0; i < count; i++)
        //        {
        //            if (_elements[i] != otherElements[i])
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //    return false;
        //}


        public StringState convertToString() => StringState.UNKNOWN_VALUE;


        public BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return isIdentical(rightOperand);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (rightOperand is DynamicState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            return BoolState.from(this == rightOperand);
        }


        public String toString()
        {
            StringBuffer buffer = new StringBuffer();
            buffer.write('[');
            bool first = true;
            _elements.forEach((DartObjectImpl element) =>
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    buffer.write(", ");
                }
                buffer.write(element);
            });
            buffer.write(']');
            return buffer.toString();
        }
    }

    /**
     * The state of an object representing a map.
     */
    public class MapState : InstanceState
    {
        /**
         * The entries in the map.
         */
        public readonly Dictionary<DartObjectImpl, DartObjectImpl> _entries;

        /**
         * Initialize a newly created state to represent a map with the given
         * [entries].
         */
        public MapState(Dictionary<DartObjectImpl, DartObjectImpl> _entries)
        {
            this._entries = _entries;
        }


        public int hashCode
        {
            get
            {
                int value = 0;
                foreach (DartObjectImpl key in _entries.Keys.toSet())
                {
                    value = (value << 3) ^ key.hashCode;
                }
                return value;
            }
        }


        public String typeName => "Map";


        //    bool operator ==(Object object)
        //{
        //    if (object is MapState)
        //    {
        //        Dictionary<DartObjectImpl, DartObjectImpl> otherElements = object._entries;
        //        int count = _entries.length;
        //        if (otherElements.length != count)
        //        {
        //            return false;
        //        }
        //        else if (count == 0)
        //        {
        //            return true;
        //        }
        //      for (DartObjectImpl key in _entries.keys)
        //        {
        //            DartObjectImpl value = _entries[key];
        //            DartObjectImpl otherValue = otherElements[key];
        //            if (value != otherValue)
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //    return false;
        //}


        public StringState convertToString() => StringState.UNKNOWN_VALUE;


        public BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return isIdentical(rightOperand);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (rightOperand is DynamicState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            return BoolState.from(this == rightOperand);
        }


        public String toString()
        {
            StringBuffer buffer = new StringBuffer();
            buffer.write('{');
            bool first = true;
            _entries.forEach((DartObjectImpl key, DartObjectImpl value) {
                if (first)
                {
                    first = false;
                }
                else
                {
                    buffer.write(', ');
                }
                buffer.write(key);
                buffer.write(' = ');
                buffer.write(value);
            });
            buffer.write('}');
            return buffer.toString();
        }
    }

    /**
     * The state of an object representing the value 'null'.
     */
    public class NullState : InstanceState
    {
        /**
         * An instance representing the boolean value 'null'.
         */
        public static NullState NULL_STATE = new NullState();


        public int hashCode => 0;


        public bool isBoolNumStringOrNull => true;


        public String typeName => "Null";


        // bool operator ==(Object object) => object is NullState;


        public BoolState convertToBool()
        {
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public StringState convertToString() => new StringState("null");


        public BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return isIdentical(rightOperand);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (rightOperand is DynamicState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            return BoolState.from(rightOperand is NullState);
        }


        public BoolState logicalNot()
        {
            throw new EvaluationException(
                CompileTimeErrorCode.CONST_EVAL_THROWS_EXCEPTION);
        }


        public String toString() => "null";
    }

    /**
     * The state of an object representing a number of an unknown type (a 'num').
     */
    public class NumState : InstanceState
    {
        /**
         * A state that can be used to represent a number whose value is not known.
         */
        public static NumState UNKNOWN_VALUE = new NumState();


        public int hashCode => 7;


        public bool isBoolNumStringOrNull => true;


        public bool isUnknown => identical(this, UNKNOWN_VALUE);


        public String typeName => "num";


        //public static bool operator ==(Object @object, Object @object1) => @object is NumState;

        //  public static bool operator !=(Object @object, Object @object1) => @object is NumState;


        public NumState add(InstanceState rightOperand)
        {
            //assertNumOrNull(rightOperand);
            return UNKNOWN_VALUE;
        }


        public StringState convertToString() => StringState.UNKNOWN_VALUE;


        public NumState divide(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return DoubleState.UNKNOWN_VALUE;
        }


        public BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return BoolState.UNKNOWN_VALUE;
        }


        public BoolState greaterThan(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return BoolState.UNKNOWN_VALUE;
        }


        public BoolState greaterThanOrEqual(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return BoolState.UNKNOWN_VALUE;
        }


        public IntState integerDivide(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            if (rightOperand is IntState)
            {
                int rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return IntState.UNKNOWN_VALUE;
                }
                else if (rightValue == 0)
                {
                    throw new EvaluationException(
                        CompileTimeErrorCode.CONST_EVAL_THROWS_IDBZE);
                }
            }
            else if (rightOperand is DynamicState)
            {
                return IntState.UNKNOWN_VALUE;
            }
            return IntState.UNKNOWN_VALUE;
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            return BoolState.UNKNOWN_VALUE;
        }


        public BoolState lessThan(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return BoolState.UNKNOWN_VALUE;
        }


        public BoolState lessThanOrEqual(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return BoolState.UNKNOWN_VALUE;
        }


        public NumState minus(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return UNKNOWN_VALUE;
        }


        public NumState negated() => UNKNOWN_VALUE;


        public NumState remainder(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return UNKNOWN_VALUE;
        }


        NumState times(InstanceState rightOperand)
        {
            assertNumOrNull(rightOperand);
            return UNKNOWN_VALUE;
        }


        public String toString() => "-unknown-";
    }

    /**
     * The state of an object representing a string.
     */
    public class StringState : InstanceState
    {
        /**
         * A state that can be used to represent a double whose value is not known.
         */
        public static StringState UNKNOWN_VALUE = new StringState(null);

        /**
         * The value of this instance.
         */
        public readonly String value;

        /**
         * Initialize a newly created state to represent the given [value].
         */
        public StringState(String value)
        {
            this.value = value;
        }


        public int hashCode => value == null ? 0 : value.hashCode;


        public bool isBoolNumStringOrNull => true;


        public bool isUnknown => value == null;


        public String typeName => "String";


        //bool operator ==(Object object) =>
        //    object is StringState && (value == object.value);


        public StringState concatenate(InstanceState rightOperand)
        {
            if (value == null)
            {
                return UNKNOWN_VALUE;
            }
            if (rightOperand is StringState)
            {
                String rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return UNKNOWN_VALUE;
                }
                return new StringState("$value$rightValue");
            }
            else if (rightOperand is DynamicState)
            {
                return UNKNOWN_VALUE;
            }
            return super.concatenate(rightOperand);
        }


        public StringState convertToString() => this;


        public BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return isIdentical(rightOperand);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is StringState)
            {
                String rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value == rightValue);
            }
            else if (rightOperand is DynamicState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            return BoolState.FALSE_STATE;
        }


        public IntState stringLength()
        {
            if (value == null)
            {
                return IntState.UNKNOWN_VALUE;
            }
            return new IntState(value.length);
        }


        public String toString() => value == null ? "-unknown-" : "'$value'";
    }

    /**
     * The state of an object representing a symbol.
     */
    public class SymbolState : InstanceState
    {
        /**
         * The value of this instance.
         */
        public readonly String value;

        /**
         * Initialize a newly created state to represent the given [value].
         */
        public SymbolState(this.value);


        public int get hashCode => value == null ? 0 : value.hashCode;


   public String get typeName => "Symbol";


    //bool operator == (Object object) =>
    //  object is SymbolState && (value == object.value);


   public StringState convertToString()
        {
            if (value == null)
            {
                return StringState.UNKNOWN_VALUE;
            }
            return new StringState(value);
        }


        public BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return isIdentical(rightOperand);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (value == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is SymbolState)
            {
                String rightValue = rightOperand.value;
                if (rightValue == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(value == rightValue);
            }
            else if (rightOperand is DynamicState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            return BoolState.FALSE_STATE;
        }


        public String toString() => value == null ? "-unknown-" : "#$value";
    }

    /**
     * The state of an object representing a type.
     */
    public class TypeState : InstanceState
    {
        /**
         * The element representing the type being modeled.
         */
        public readonly DartType _type;

        /**
         * Initialize a newly created state to represent the given [value].
         */
        public TypeState(this._type);


        public int get hashCode => _type?.hashCode ?? 0;


    public String get typeName => "Type";


    //bool operator == (Object object) =>
    //  object is TypeState && (_type == object._type);


    public StringState convertToString()
        {
            if (_type == null)
            {
                return StringState.UNKNOWN_VALUE;
            }
            return new StringState(_type.displayName);
        }


        public BoolState equalEqual(InstanceState rightOperand)
        {
            assertBoolNumStringOrNull(rightOperand);
            return isIdentical(rightOperand);
        }


        public BoolState isIdentical(InstanceState rightOperand)
        {
            if (_type == null)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            if (rightOperand is TypeState)
            {
                DartType rightType = rightOperand._type;
                if (rightType == null)
                {
                    return BoolState.UNKNOWN_VALUE;
                }
                return BoolState.from(_type == rightType);
            }
            else if (rightOperand is DynamicState)
            {
                return BoolState.UNKNOWN_VALUE;
            }
            return BoolState.FALSE_STATE;
        }


        public String toString() => _type?.toString() ?? "-unknown-";
    }
}