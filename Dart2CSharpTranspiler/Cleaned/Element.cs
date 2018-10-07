﻿using Dart2CSharpTranspiler.Parser;
using System;
using System.Collections.Generic;
using System.Text;
using static Dart2CSharpTranspiler.Parser.DartLibrary;

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2014, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    /**
     * Defines the element model. The element model describes the semantic (as
     * opposed to syntactic) structure of Dart code. The syntactic structure of the
     * code is modeled by the [AST
     * structure](../analyzer.dart.ast.ast/analyzer.dart.ast.ast-library.html).
     *
     * The element model consists of two closely related kinds of objects: elements
     * (instances of a subclass of [Element]) and types. This library defines the
     * elements, the types are defined in
     * [type.dart](../dart_element_type/dart_element_type-library.html).
     *
     * Generally speaking, an element represents something that is declared in the
     * code, such as a class, method, or variable. Elements are organized in a tree
     * structure in which the children of an element are the elements that are
     * logically (and often syntactically) part of the declaration of the parent.
     * For example, the elements representing the methods and fields in a class are
     * children of the element representing the class.
     *
     * Every complete element structure is rooted by an instance of the class
     * [LibraryElement]. A library element represents a single Dart library. Every
     * library is defined by one or more compilation units (the library and all of
     * its parts). The compilation units are represented by the class
     * [CompilationUnitElement] and are children of the library that is defined by
     * them. Each compilation unit can contain zero or more top-level declarations,
     * such as classes, functions, and variables. Each of these is in turn
     * represented as an element that is a child of the compilation unit. Classes
     * contain methods and fields, methods can contain local variables, etc.
     *
     * The element model does not contain everything in the code, only those things
     * that are declared by the code. For example, it does not include any
     * representation of the statements in a method body, but if one of those
     * statements declares a local variable then the local variable will be
     * represented by an element.
     */

    /**
     * An element that represents a class or a mixin. The class can be defined by
     * either a class declaration (with a class body), a mixin application (without
     * a class body), a mixin declaration, or an enum declaration.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class ClassElement : TypeParameterizedElement, ITypeDefiningElement
    {
        /**
         * An empty list of class elements.
         */
        [Obsolete]
        public static List<ClassElement> EMPTY_LIST = new List<ClassElement> { };

        /**
         * Return a list containing all of the accessors (getters and setters)
         * declared in this class.
         */
        public abstract List<PropertyAccessorElement> accessors { get; }

        /**
         * Return a list containing all the supertypes defined for this class and its
         * supertypes. This includes superclasses, mixins, interfaces and superclass
         * constraints.
         */
        public abstract List<InterfaceType> allSupertypes { get; }

        /**
         * Return a list containing all of the constructors declared in this class.
         * The list will be empty if there are no constructors defined for this class,
         * as is the case when this element represents an enum or a mixin.
         */
        public abstract List<ConstructorElement> constructors { get; }

        /**
         * Return a list containing all of the fields declared in this class.
         */
        public abstract List<FieldElement> fields { get; }

        /**
         * Return `true` if this class or its superclass declares a non-final instance
         * field.
         */
        public abstract bool hasNonFinalField { get; }

        /**
         * Return `true` if this class has at least one reference to `super` (and
         * hence cannot be used as a mixin), or `false` if this element represents a
         * mixin, even if the mixin has a reference to `super`, because it is allowed
         * to be used as a mixin.
         */
        public abstract bool hasReferenceToSuper { get; }

        /**
         * Return `true` if this class declares a static member.
         */
        public abstract bool hasStaticMember { get; }

        /**
         * Return a list containing all of the interfaces that are implemented by this
         * class.
         *
         * <b>Note:</b> Because the element model represents the state of the code, it
         * is possible for it to be semantically invalid. In particular, it is not
         * safe to assume that the inheritance structure of a class does not contain a
         * cycle. Clients that traverse the inheritance structure must explicitly
         * guard against infinite loops.
         */
        public abstract List<InterfaceType> interfaces { get; }

        /**
         * Return `true` if this class is abstract. A class is abstract if it has an
         * explicit `abstract` modifier or if it is implicitly abstract, such as a
         * class defined by a mixin declaration. Note, that this definition of
         * <i>abstract</i> is different from <i>has unimplemented members</i>.
         */
        public abstract bool isAbstract { get; }

        /**
         * Return `true` if this class is defined by an enum declaration.
         */
        public abstract bool isEnum { get; }

        /**
         * Return `true` if this class is defined by a mixin declaration.
         */
        public abstract bool isMixin { get; }

        /**
         * Return `true` if this class is a mixin application.  A class is a mixin
         * application if it was declared using the syntax "class A = B with C;".
         */
        public abstract bool isMixinApplication { get; }

        /**
         * Return `true` if this class [isProxy], or if it inherits the proxy
         * annotation from a supertype.
         */
        public abstract bool isOrInheritsProxy { get; }

        /**
         * Return `true` if this element has an annotation of the form '@proxy'.
         */
        public abstract bool isProxy { get; }

        /**
         * Return `true` if this class can validly be used as a mixin when defining
         * another class. For classes defined by a mixin declaration, the result is
         * always `true`. For classes defined by a class declaration or a mixin
         * application, the behavior of this method is defined by the Dart Language
         * Specification in section 9:
         * <blockquote>
         * It is a compile-time error if a declared or derived mixin refers to super.
         * It is a compile-time error if a declared or derived mixin explicitly
         * declares a constructor. It is a compile-time error if a mixin is derived
         * from a class whose superclass is not Object.
         * </blockquote>
         */
        public abstract bool isValidMixin { get; }

        /**
         * Return a list containing all of the methods declared in this class.
         */
        public abstract List<MethodElement> methods { get; }

        /**
         * Return a list containing all of the mixins that are applied to the class
         * being extended in order to derive the superclass of this class.
         *
         * <b>Note:</b> Because the element model represents the state of the code, it
         * is possible for it to be semantically invalid. In particular, it is not
         * safe to assume that the inheritance structure of a class does not contain a
         * cycle. Clients that traverse the inheritance structure must explicitly
         * guard against infinite loops.
         */
        public abstract List<InterfaceType> mixins { get; }

        /**
         * Return a list containing all of the superclass constraints defined for this
         * class. The list will be empty if this class does not represent a mixin
         * declaration. If this class _does_ represent a mixin declaration but the
         * declaration does not have an `on` clause, then the list will contain the
         * type for the class `Object`.
         *
         * <b>Note:</b> Because the element model represents the state of the code, it
         * is possible for it to be semantically invalid. In particular, it is not
         * safe to assume that the inheritance structure of a class does not contain a
         * cycle. Clients that traverse the inheritance structure must explicitly
         * guard against infinite loops.
         */
        public abstract List<InterfaceType> superclassConstraints { get; }

        /**
         * Return the superclass of this class, or `null` if either the class
         * represents the class 'Object' or if the class represents a mixin
         * declaration. All other classes will have a non-`null` superclass. If the
         * superclass was not explicitly declared then the implicit superclass
         * 'Object' will be returned.
         *
         * <b>Note:</b> Because the element model represents the state of the code, it
         * is possible for it to be semantically invalid. In particular, it is not
         * safe to assume that the inheritance structure of a class does not contain a
         * cycle. Clients that traverse the inheritance structure must explicitly
         * guard against infinite loops.
         */
        public abstract InterfaceType supertype { get; }


        //public abstract override DartType type { get; } //InterfaceType

        /**
         * Return the unnamed constructor declared in this class, or `null` if either
         * this class does not declare an unnamed constructor but does declare named
         * constructors or if this class represents a mixin declaration. The returned
         * constructor will be synthetic if this class does not declare any
         * constructors, in which case it will represent the default constructor for
         * the class.
         */
        ConstructorElement unnamedConstructor { get; }

        public abstract override AstNode computeNode(); //NamedCompilationUnitMember

        /**
         * Return the field (synthetic or explicit) defined in this class that has the
         * given [name], or `null` if this class does not define a field with the
         * given name.
         */
        public abstract FieldElement getField(String name);

        /**
         * Return the element representing the getter with the given [name] that is
         * declared in this class, or `null` if this class does not declare a getter
         * with the given name.
         */
        public abstract PropertyAccessorElement getGetter(String name);

        /**
         * Return the element representing the method with the given [name] that is
         * declared in this class, or `null` if this class does not declare a method
         * with the given name.
         */
        public abstract MethodElement getMethod(String name);

        /**
         * Return the named constructor declared in this class with the given [name],
         * or `null` if this class does not declare a named constructor with the given
         * name.
         */
        public abstract ConstructorElement getNamedConstructor(String name);

        /**
         * Return the element representing the setter with the given [name] that is
         * declared in this class, or `null` if this class does not declare a setter
         * with the given name.
         */
        public abstract PropertyAccessorElement getSetter(String name);

        /**
         * Return the element representing the method that results from looking up the
         * given [methodName] in this class with respect to the given [library],
         * ignoring abstract methods, or `null` if the look up fails. The behavior of
         * this method is defined by the Dart Language Specification in section
         * 16.15.1:
         * <blockquote>
         * The result of looking up method <i>m</i> in class <i>C</i> with respect to
         * library <i>L</i> is: If <i>C</i> declares an instance method named <i>m</i>
         * that is accessible to <i>L</i>, then that method is the result of the
         * lookup. Otherwise, if <i>C</i> has a superclass <i>S</i>, then the result
         * of the lookup is the result of looking up method <i>m</i> in <i>S</i> with
         * respect to <i>L</i>. Otherwise, we say that the lookup has failed.
         * </blockquote>
         */
        public abstract MethodElement lookUpConcreteMethod(String methodName, LibraryElement library);

        /**
         * Return the element representing the getter that results from looking up the
         * given [getterName] in this class with respect to the given [library], or
         * `null` if the look up fails. The behavior of this method is defined by the
         * Dart Language Specification in section 16.15.2:
         * <blockquote>
         * The result of looking up getter (respectively setter) <i>m</i> in class
         * <i>C</i> with respect to library <i>L</i> is: If <i>C</i> declares an
         * instance getter (respectively setter) named <i>m</i> that is accessible to
         * <i>L</i>, then that getter (respectively setter) is the result of the
         * lookup. Otherwise, if <i>C</i> has a superclass <i>S</i>, then the result
         * of the lookup is the result of looking up getter (respectively setter)
         * <i>m</i> in <i>S</i> with respect to <i>L</i>. Otherwise, we say that the
         * lookup has failed.
         * </blockquote>
         */
        public abstract PropertyAccessorElement lookUpGetter(
            String getterName, LibraryElement library);

        /**
         * Return the element representing the getter that results from looking up the
         * given [getterName] in the superclass of this class with respect to the
         * given [library], ignoring abstract getters, or `null` if the look up fails.
         * The behavior of this method is defined by the Dart Language Specification
         * in section 16.15.2:
         * <blockquote>
         * The result of looking up getter (respectively setter) <i>m</i> in class
         * <i>C</i> with respect to library <i>L</i> is: If <i>C</i> declares an
         * instance getter (respectively setter) named <i>m</i> that is accessible to
         * <i>L</i>, then that getter (respectively setter) is the result of the
         * lookup. Otherwise, if <i>C</i> has a superclass <i>S</i>, then the result
         * of the lookup is the result of looking up getter (respectively setter)
         * <i>m</i> in <i>S</i> with respect to <i>L</i>. Otherwise, we say that the
         * lookup has failed.
         * </blockquote>
         */
        public abstract PropertyAccessorElement lookUpInheritedConcreteGetter(
            String getterName, LibraryElement library);

        /**
         * Return the element representing the method that results from looking up the
         * given [methodName] in the superclass of this class with respect to the
         * given [library], ignoring abstract methods, or `null` if the look up fails.
         * The behavior of this method is defined by the Dart Language Specification
         * in section 16.15.1:
         * <blockquote>
         * The result of looking up method <i>m</i> in class <i>C</i> with respect to
         * library <i>L</i> is:  If <i>C</i> declares an instance method named
         * <i>m</i> that is accessible to <i>L</i>, then that method is the result of
         * the lookup. Otherwise, if <i>C</i> has a superclass <i>S</i>, then the
         * result of the lookup is the result of looking up method <i>m</i> in
         * <i>S</i> with respect to <i>L</i>. Otherwise, we say that the lookup has
         * failed.
         * </blockquote>
         */
        public abstract MethodElement lookUpInheritedConcreteMethod(
            String methodName, LibraryElement library);

        /**
         * Return the element representing the setter that results from looking up the
         * given [setterName] in the superclass of this class with respect to the
         * given [library], ignoring abstract setters, or `null` if the look up fails.
         * The behavior of this method is defined by the Dart Language Specification
         * in section 16.15.2:
         * <blockquote>
         * The result of looking up getter (respectively setter) <i>m</i> in class
         * <i>C</i> with respect to library <i>L</i> is:  If <i>C</i> declares an
         * instance getter (respectively setter) named <i>m</i> that is accessible to
         * <i>L</i>, then that getter (respectively setter) is the result of the
         * lookup. Otherwise, if <i>C</i> has a superclass <i>S</i>, then the result
         * of the lookup is the result of looking up getter (respectively setter)
         * <i>m</i> in <i>S</i> with respect to <i>L</i>. Otherwise, we say that the
         * lookup has failed.
         * </blockquote>
         */
        public abstract PropertyAccessorElement lookUpInheritedConcreteSetter(
            String setterName, LibraryElement library);

        /**
         * Return the element representing the method that results from looking up the
         * given [methodName] in the superclass of this class with respect to the
         * given [library], or `null` if the look up fails. The behavior of this
         * method is defined by the Dart Language Specification in section 16.15.1:
         * <blockquote>
         * The result of looking up method <i>m</i> in class <i>C</i> with respect to
         * library <i>L</i> is:  If <i>C</i> declares an instance method named
         * <i>m</i> that is accessible to <i>L</i>, then that method is the result of
         * the lookup. Otherwise, if <i>C</i> has a superclass <i>S</i>, then the
         * result of the lookup is the result of looking up method <i>m</i> in
         * <i>S</i> with respect to <i>L</i>. Otherwise, we say that the lookup has
         * failed.
         * </blockquote>
         */
        public abstract MethodElement lookUpInheritedMethod(
            String methodName, LibraryElement library);

        /**
         * Return the element representing the method that results from looking up the
         * given [methodName] in this class with respect to the given [library], or
         * `null` if the look up fails. The behavior of this method is defined by the
         * Dart Language Specification in section 16.15.1:
         * <blockquote>
         * The result of looking up method <i>m</i> in class <i>C</i> with respect to
         * library <i>L</i> is:  If <i>C</i> declares an instance method named
         * <i>m</i> that is accessible to <i>L</i>, then that method is the result of
         * the lookup. Otherwise, if <i>C</i> has a superclass <i>S</i>, then the
         * result of the lookup is the result of looking up method <i>m</i> in
         * <i>S</i> with respect to <i>L</i>. Otherwise, we say that the lookup has
         * failed.
         * </blockquote>
         */
        public abstract MethodElement lookUpMethod(String methodName, LibraryElement library);

        /**
         * Return the element representing the setter that results from looking up the
         * given [setterName] in this class with respect to the given [library], or
         * `null` if the look up fails. The behavior of this method is defined by the
         * Dart Language Specification in section 16.15.2:
         * <blockquote>
         * The result of looking up getter (respectively setter) <i>m</i> in class
         * <i>C</i> with respect to library <i>L</i> is: If <i>C</i> declares an
         * instance getter (respectively setter) named <i>m</i> that is accessible to
         * <i>L</i>, then that getter (respectively setter) is the result of the
         * lookup. Otherwise, if <i>C</i> has a superclass <i>S</i>, then the result
         * of the lookup is the result of looking up getter (respectively setter)
         * <i>m</i> in <i>S</i> with respect to <i>L</i>. Otherwise, we say that the
         * lookup has failed.
         * </blockquote>
         */
        public abstract PropertyAccessorElement lookUpSetter(
            String setterName, LibraryElement library);
    }

    /**
     * An element that is contained within a [ClassElement].
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public interface IClassMemberElement // : Element
    {

        //public abstract override Element enclosingElement { get; } //ClassElement

        /**
         * Return `true` if this element is a static element. A static element is an
         * element that is not associated with a particular instance, but rather with
         * an entire library or class.
         */
        bool isStatic { get; }
    }

    /**
     * An element representing a compilation unit.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class CompilationUnitElement : Element, IUriReferencedElement
    {
        /**
         * An empty list of compilation unit elements.
         */
        [Obsolete]
        public static List<CompilationUnitElement> EMPTY_LIST =
          new List<CompilationUnitElement> { };

        /**
         * Return a list containing all of the top-level accessors (getters and
         * setters) contained in this compilation unit.
         */
        public abstract List<PropertyAccessorElement> accessors { get; }


        /**
         * Return a list containing all of the enums contained in this compilation
         * unit.
         */
        public abstract List<ClassElement> enums { get; }

        /**
         * Return a list containing all of the top-level functions contained in this
         * compilation unit.
         */
        public abstract List<FunctionElement> functions { get; }

        /**
         * Return a list containing all of the function type aliases contained in this
         * compilation unit.
         */
        public abstract List<FunctionTypeAliasElement> functionTypeAliases { get; }

        /**
         * Return `true` if this compilation unit defines a top-level function named
         * `loadLibrary`.
         */
        public abstract bool hasLoadLibraryFunction { get; }

        /**
         * Return the [LineInfo] for the [source], or `null` if not computed yet.
         */
        public abstract LineInfo lineInfo { get; }

        /**
         * Return a list containing all of the mixins contained in this compilation
         * unit.
         */
        public abstract List<ClassElement> mixins { get; }

        /**
         * Return a list containing all of the top-level variables contained in this
         * compilation unit.
         */
        public abstract List<TopLevelVariableElement> topLevelVariables { get; }

        /**
         * Return a list containing all of the classes contained in this compilation
         * unit.
         */
        public abstract List<ClassElement> types { get; }

        public string uri { get; set; }

        public int uriEnd { get; set; }

        public int uriOffset { get; set; }

        /**
         * Return the enum defined in this compilation unit that has the given [name],
         * or `null` if this compilation unit does not define an enum with the given
         * name.
         */
        public abstract ClassElement getEnum(String name);

        /**
         * Return the class defined in this compilation unit that has the given
         * [name], or `null` if this compilation unit does not define a class with the
         * given name.
         */
        public abstract ClassElement getType(String name);
    }

    /**
     * An element representing a constructor or a factory method defined within a
     * class.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class ConstructorElement
        : ExecutableElement, IConstantEvaluationTarget, IClassMemberElement
    {
        /**
         * An empty list of constructor elements.
         */
        [Obsolete]
        public static List<ConstructorElement> EMPTY_LIST =
          new List<ConstructorElement> { };

        /**
         * Return `true` if this constructor is a new constructor.
         */
        public abstract bool isConst { get; }

        /**
         * Return `true` if this constructor can be used as a default constructor -
         * unnamed and has no required parameters.
         */
        public abstract bool isDefaultConstructor { get; }

        /**
         * Return `true` if this constructor represents a factory constructor.
         */
        public abstract override bool isFactory { get; }

        /**
         * Return the offset of the character immediately following the last character
         * of this constructor's name, or `null` if not named.
         */
        public abstract int nameEnd { get; }

        /**
         * Return the offset of the `.` before this constructor name, or `null` if
         * not named.
         */
        public abstract int periodOffset { get; }

        /**
         * Return the constructor to which this constructor is redirecting, or `null`
         * if this constructor does not redirect to another constructor or if the
         * library containing this constructor has not yet been resolved.
         */
        public abstract ConstructorElement redirectedConstructor { get; }


        public abstract override AstNode computeNode(); //ConstructorDeclaration
    }

    public interface IConstantEvaluationTarget
    { }


    /**
     * A single annotation associated with an element.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class ElementAnnotation : IConstantEvaluationTarget
    {
        /**
         * An empty list of annotations.
         */
        [Obsolete]
        public static List<ElementAnnotation> EMPTY_LIST = new List<ElementAnnotation> { };

        /**
         * Return a representation of the value of this annotation.
         *
         * Return `null` if the value of this annotation could not be computed because
         * of errors.
         */
        public abstract DartObject constantValue { get; }

        /**
         * Return the element representing the field, variable, or new constructor
         * being used as an annotation.
         */
        public abstract Element element { get; }

        /**
         * Return `true` if this annotation marks the associated function as always
         * throwing.
         */
        public abstract bool isAlwaysThrows { get; }

        /**
         * Return `true` if this annotation marks the associated element as being
         * deprecated.
         */
        public abstract bool isDeprecated { get; }

        /**
         * Return `true` if this annotation marks the associated member as a factory.
         */
        public abstract bool isFactory { get; }

        /**
         * Return `true` if this annotation marks the associated class and its
         * subclasses as being immutable.
         */
        public abstract bool isImmutable { get; }

        /**
         * Return `true` if this annotation marks the associated member as running
         * a single test.
         */
        public abstract bool isIsTest { get; }

        /**
         * Return `true` if this annotation marks the associated member as running
         * a test group.
         */
        public abstract bool isIsTestGroup { get; }

        /**
         * Return `true` if this annotation marks the associated element with the `JS`
         * annotation.
         */
        public abstract bool isJS { get; }

        /**
         * Return `true` if this annotation marks the associated member as requiring
         * overriding methods to call super.
         */
        public abstract bool isMustCallSuper { get; }

        /**
         * Return `true` if this annotation marks the associated method as being
         * expected to override an inherited method.
         */
        public abstract bool isOverride { get; }

        /**
         * Return `true` if this annotation marks the associated member as being
         * protected.
         */
        public abstract bool isProtected { get; }

        /**
         * Return `true` if this annotation marks the associated class as implementing
         * a proxy object.
         */
        public abstract bool isProxy { get; }

        /**
         * Return `true` if this annotation marks the associated member as being
         * required.
         */
        public abstract bool isRequired { get; }

        /**
         * Return `true` if this annotation marks the associated class as being
         * sealed.
         */
        public abstract bool isSealed { get; }

        /**
         * Return `true` if this annotation marks the associated member as being
         * visible for template files.
         */
        public abstract bool isVisibleForTemplate { get; }

        /**
         * Return `true` if this annotation marks the associated member as being
         * visible for testing.
         */
        public abstract bool isVisibleForTesting { get; }

        /**
         * Return a representation of the value of this annotation, forcing the value
         * to be computed if it had not previously been computed, or `null` if the
         * value of this annotation could not be computed because of errors.
         */
        public abstract DartObject computeConstantValue();

        /**
         * Return a textual description of this annotation in a form approximating
         * valid source. The returned string will not be valid source primarily in the
         * case where the annotation itself is not well-formed.
         */
        public abstract String toSource();
    }

    /**
     * The kind of elements in the element model.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public class ElementKind : Comparable<ElementKind>
    {
        public static ElementKind CLASS = new ElementKind("CLASS", 0, "class");

        public static ElementKind COMPILATION_UNIT =
          new ElementKind("COMPILATION_UNIT", 1, "compilation unit");

        public static ElementKind CONSTRUCTOR =
          new ElementKind("CONSTRUCTOR", 2, "constructor");

        public static ElementKind DYNAMIC =
          new ElementKind("DYNAMIC", 3, "<dynamic>");

        public static ElementKind ERROR = new ElementKind("ERROR", 4, "<error>");

        public static ElementKind EXPORT =
          new ElementKind("EXPORT", 5, "export directive");

        public static ElementKind FIELD = new ElementKind("FIELD", 6, "field");

        public static ElementKind FUNCTION =
          new ElementKind("FUNCTION", 7, "function");

        public static ElementKind GENERIC_FUNCTION_TYPE =
          new ElementKind("GENERIC_FUNCTION_TYPE", 8, "generic function type");

        public static ElementKind GETTER = new ElementKind("GETTER", 9, "getter");

        public static ElementKind IMPORT =
          new ElementKind("IMPORT", 10, "import directive");

        public static ElementKind LABEL = new ElementKind("LABEL", 11, "label");

        public static ElementKind LIBRARY =
          new ElementKind("LIBRARY", 12, "library");

        public static ElementKind LOCAL_VARIABLE =
          new ElementKind("LOCAL_VARIABLE", 13, "local variable");

        public static ElementKind METHOD = new ElementKind("METHOD", 14, "method");

        public static ElementKind NAME = new ElementKind("NAME", 15, "<name>");

        public static ElementKind PARAMETER =
          new ElementKind("PARAMETER", 16, "parameter");

        public static ElementKind PREFIX =
          new ElementKind("PREFIX", 17, "import prefix");

        public static ElementKind SETTER = new ElementKind("SETTER", 18, "setter");

        public static ElementKind TOP_LEVEL_VARIABLE =
          new ElementKind("TOP_LEVEL_VARIABLE", 19, "top level variable");

        public static ElementKind FUNCTION_TYPE_ALIAS =
          new ElementKind("FUNCTION_TYPE_ALIAS", 20, "function type alias");

        public static ElementKind TYPE_PARAMETER =
          new ElementKind("TYPE_PARAMETER", 21, "type parameter");

        public static ElementKind UNIVERSE =
          new ElementKind("UNIVERSE", 22, "<universe>");

        public static List<ElementKind> values = new List<ElementKind> {
                                                      CLASS,
                                                      COMPILATION_UNIT,
                                                      CONSTRUCTOR,
                                                      DYNAMIC,
                                                      ERROR,
                                                      EXPORT,
                                                      FIELD,
                                                      FUNCTION,
                                                      GENERIC_FUNCTION_TYPE,
                                                      GETTER,
                                                      IMPORT,
                                                      LABEL,
                                                      LIBRARY,
                                                      LOCAL_VARIABLE,
                                                      METHOD,
                                                      NAME,
                                                      PARAMETER,
                                                      PREFIX,
                                                      SETTER,
                                                      TOP_LEVEL_VARIABLE,
                                                      FUNCTION_TYPE_ALIAS,
                                                      TYPE_PARAMETER,
                                                      UNIVERSE
                                                    };

        /**
         * The name of this element kind.
         */
        public readonly String name;

        /**
         * The ordinal value of the element kind.
         */
        public readonly int ordinal;

        /**
         * The name displayed in the UI for this kind of element.
         */
        public readonly String displayName;

        /**
         * Initialize a newly created element kind to have the given [displayName].
         */
        public ElementKind(string name, int ordinal, string displayName)
        {
            this.name = name;
            this.ordinal = ordinal;
            this.displayName = displayName;
        }

        public virtual int hashCode => ordinal;

        public virtual int compareTo(ElementKind other) => ordinal - other.ordinal;

        public virtual String toString() => name;

        /**
         * Return the kind of the given [element], or [ERROR] if the element is
         * `null`. This is a utility method that can reduce the need for null checks
         * in other places.
         */
        static ElementKind of(Element element)
        {
            if (element == null)
            {
                return ERROR;
            }
            return element.kind;
        }
    }

    /**
     * The location of an element within the element model.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class ElementLocation
    {
        /**
         * Return the path to the element whose location is represented by this
         * object. Clients must not modify the returned array.
         */
        List<String> components { get; }

        /**
         * Return an encoded representation of this location that can be used to
         * create a location that is equal to this location.
         */
        String encoding { get; }
    }

    /**
     * An object that can be used to visit an element structure.
     *
     * Clients may not extend, implement or mix-in this class. There are classes
     * that implement this interface that provide useful default behaviors in
     * `package:analyzer/dart/ast/visitor.dart`. A couple of the most useful include
     * * SimpleElementVisitor which : every visit method by doing nothing,
     * * RecursiveElementVisitor which will cause every node in a structure to be
     *   visited, and
     * * ThrowingElementVisitor which : every visit method by throwing an
     *   exception.
     */
    public abstract class ElementVisitor<R>
    {
        public abstract R visitClassElement(ClassElement element);

        public abstract R visitCompilationUnitElement(CompilationUnitElement element);

        public abstract R visitConstructorElement(ConstructorElement element);

        public abstract R visitExportElement(ExportElement element);

        public abstract R visitFieldElement(FieldElement element);

        public abstract R visitFieldFormalParameterElement(FieldFormalParameterElement element);

        public abstract R visitFunctionElement(FunctionElement element);

        public abstract R visitFunctionTypeAliasElement(FunctionTypeAliasElement element);

        public abstract R visitGenericFunctionTypeElement(GenericFunctionTypeElement element);

        public abstract R visitImportElement(ImportElement element);

        public abstract R visitLabelElement(LabelElement element);

        public abstract R visitLibraryElement(LibraryElement element);

        public abstract R visitLocalVariableElement(LocalVariableElement element);

        public abstract R visitMethodElement(MethodElement element);

        public abstract R visitMultiplyDefinedElement(MultiplyDefinedElement element);

        public abstract R visitParameterElement(ParameterElement element);

        public abstract R visitPrefixElement(PrefixElement element);

        public abstract R visitPropertyAccessorElement(PropertyAccessorElement element);

        public abstract R visitTopLevelVariableElement(TopLevelVariableElement element);

        public abstract R visitTypeParameterElement(TypeParameterElement element);
    }

    /**
     * An element representing an executable object, including functions, methods,
     * constructors, getters, and setters.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class ExecutableElement : FunctionTypedElement
    {
        /**
         * An empty list of executable elements.
         */
        [Obsolete]
        public static List<ExecutableElement> EMPTY_LIST = new List<ExecutableElement> { };

        /**
         * Return `true` if this executable element did not have an explicit return
         * type specified for it in the original source. Note that if there was no
         * explicit return type, and if the element model is fully populated, then
         * the [returnType] will not be `null`.
         */
        public abstract bool hasImplicitReturnType { get; }

        /**
         * Return `true` if this executable element is abstract. Executable elements
         * are abstract if they are not external and have no body.
         */
        public abstract bool isAbstract { get; }

        /**
         * Return `true` if this executable element has body marked as being
         * asynchronous.
         */
        public abstract bool isAsynchronous { get; }

        /**
         * Return `true` if this executable element is external. Executable elements
         * are external if they are explicitly marked as such using the 'external'
         * keyword.
         */
        public abstract bool isExternal { get; }

        /**
         * Return `true` if this executable element has a body marked as being a
         * generator.
         */
        public abstract bool isGenerator { get; }

        /**
         * Return `true` if this executable element is an operator. The test may be
         * based on the name of the executable element, in which case the result will
         * be correct when the name is legal.
         */
        public abstract bool isOperator { get; }

        /**
         * Return `true` if this element is a static element. A static element is an
         * element that is not associated with a particular instance, but rather with
         * an entire library or class.
         */
        public abstract bool isStatic { get; }

        /**
         * Return `true` if this executable element has a body marked as being
         * synchronous.
         */
        public abstract bool isSynchronous { get; }
    }

    /**
     * An export directive within a library.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class ExportElement : Element, IUriReferencedElement
    {
        /**
         * An empty list of export elements.
         */
        [Obsolete]
        public static List<ExportElement> EMPTY_LIST = new List<ExportElement> { };

        /**
         * Return a list containing the combinators that were specified as part of the
         * export directive in the order in which they were specified.
         */
        public List<NamespaceCombinator> combinators { get; }

        /**
         * Return the library that is exported from this library by this export
         * directive.
         */
        public LibraryElement exportedLibrary { get; }

        public string uri { get; set; }

        public int uriEnd { get; set; }

        public int uriOffset { get; set; }
    }

    /**
     * A field defined within a type.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class FieldElement
        : PropertyInducingElement, IClassMemberElement
    {
        /**
         * An empty list of field elements.
         */
        [Obsolete]
        public static List<FieldElement> EMPTY_LIST = new List<FieldElement> { };

        /**
         * Return {@code true} if this element is an enum constant.
         */
        public abstract bool isEnumConstant { get; }

        /**
         * Returns `true` if this field can be overridden in strong mode.
         */
        [Obsolete]
        public abstract bool isVirtual { get; }


        public abstract override AstNode computeNode();
    }

    /**
     * A field formal parameter defined within a constructor element.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class FieldFormalParameterElement : ParameterElement
    {
        /**
         * Return the field element associated with this field formal parameter, or
         * `null` if the parameter references a field that doesn't exist.
         */
        FieldElement field { get; }
    }

    /**
     * A (non-method) function. This can be either a top-level function, a local
     * function, a closure, or the initialization expression for a field or
     * variable.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class FunctionElement : ExecutableElement, ILocalElement
    {
        /**
         * An empty list of function elements.
         */
        [Obsolete]
        public static List<FunctionElement> EMPTY_LIST = new List<FunctionElement> { };

        /**
         * The name of the method that can be implemented by a class to allow its
         * instances to be invoked as if they were a function.
         */
        public static readonly String CALL_METHOD_NAME = "call";

        /**
         * The name of the synthetic function defined for libraries that are deferred.
         */
        public static readonly String LOAD_LIBRARY_NAME = "loadLibrary";

        /**
         * The name of the function used as an entry point.
         */
        public static String MAIN_FUNCTION_NAME = "main";

        /**
         * The name of the method that will be invoked if an attempt is made to invoke
         * an undefined method on an object.
         */
        public static readonly String NO_SUCH_METHOD_METHOD_NAME = "noSuchMethod";

        /**
         * Return `true` if the function is an entry point, i.e. a top-level function
         * and has the name `main`.
         */
        public abstract bool isEntryPoint { get; }

        public SourceRange visibleRange { get; }

        public abstract override AstNode computeNode(); //FunctionDeclaration
    }

    /**
     * A function type alias (`typedef`).
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class FunctionTypeAliasElement
        : FunctionTypedElement, ITypeDefiningElement
    {
        /**
         * An empty array of type alias elements.
         */
        [Obsolete]
        static List<FunctionTypeAliasElement> EMPTY_LIST =
            new List<FunctionTypeAliasElement>(0);

        public abstract override Element enclosingElement { get; } //CompilationUnitElement

        public abstract override AstNode computeNode(); //TypeAlias

        /// Produces the function type resulting from instantiating this typedef with
        /// the given type arguments.
        ///
        /// Note that for a generic typedef, this instantiates the typedef, not the
        /// generic function type associated with it.  So, for example, if the typedef
        /// is:
        ///     typedef F<T> = void Function<U>(T, U);
        /// then a single type argument should be provided, and it will be substituted
        /// for T.
        public abstract FunctionType instantiate(List<DartType> argumentTypes);
    }

    /**
     * An element that has a [FunctionType] as its [type].
     *
     * This also provides convenient access to the parameters and return type.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class FunctionTypedElement : TypeParameterizedElement
    {
        /**
         * Return a list containing all of the parameters defined by this executable
         * element.
         */
        public abstract List<ParameterElement> parameters { get; }

        /**
         * Return the return type defined by this element. If the element model is
         * fully populated, then the [returnType] will not be `null`, even if no
         * return type was explicitly specified.
         */
        public abstract DartType returnType { get; }

        public abstract override DartType type { get; } //FunctionType
    }

    /**
     * The pseudo-declaration that defines a generic function type.
     *
     * Clients may not extend, implement, or mix-in this class.
     */
    public abstract class GenericFunctionTypeElement : FunctionTypedElement { }

    /**
     * A [FunctionTypeAliasElement] whose returned function type has a [type]
     * parameter.
     *
     * Clients may not extend, implement, or mix-in this class.
     */
    public abstract class GenericTypeAliasElement : FunctionTypeAliasElement
    {
        /**
         * Return the generic function type element representing the generic function
         * type on the right side of the equals.
         */
        GenericFunctionTypeElement function { get; }
    }

    /**
     * A combinator that causes some of the names in a namespace to be hidden when
     * being imported.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class HideElementCombinator : NamespaceCombinator
    {
        /**
         * Return a list containing the names that are not to be made visible in the
         * importing library even if they are defined in the imported library.
         */
        public List<String> hiddenNames { get; }
    }

    /**
     * A single import directive within a library.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class ImportElement : Element, IUriReferencedElement
    {
        /**
         * An empty list of import elements.
         */
        [Obsolete]
        public static List<ImportElement> EMPTY_LIST = new List<ImportElement> { };

        /**
         * Return a list containing the combinators that were specified as part of the
         * import directive in the order in which they were specified.
         */
        public List<NamespaceCombinator> combinators { get; }

        /**
         * Return the library that is imported into this library by this import
         * directive.
         */
        public LibraryElement importedLibrary { get; }

        /**
         * Return `true` if this import is for a deferred library.
         */
        public bool isDeferred { get; }

        /**
         * The [Namespace] that this directive contributes to the containing library.
         */
        public Namespace @namespace { get; }

        /**
         * Return the prefix that was specified as part of the import directive, or
         * `null` if there was no prefix specified.
         */
        public PrefixElement prefix { get; }

        /**
         * Return the offset of the prefix of this import in the file that contains
         * this import directive, or `-1` if this import is synthetic, does not have a
         * prefix, or otherwise does not have an offset.
         */
        public int prefixOffset { get; }

        public string uri { get; set; }

        public int uriEnd { get; set; }

        public int uriOffset { get; set; }
    }

    /**
     * A label associated with a statement.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class LabelElement : Element
    {
        /**
         * An empty list of label elements.
         */
        [Obsolete]
        public static List<LabelElement> EMPTY_LIST = new List<LabelElement> { };


        public abstract override Element enclosingElement { get; } //ExecutableElement
    }

    /**
     * A library.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class LibraryElement : Element
    {
        /**
         * An empty list of library elements.
         */
        [Obsolete]
        public static List<LibraryElement> EMPTY_LIST = new List<LibraryElement> { };

        /**
         * Return the compilation unit that defines this library.
         */
        public abstract CompilationUnitElement definingCompilationUnit { get; }

        /**
         * Return the entry point for this library, or `null` if this library does not
         * have an entry point. The entry point is defined to be a zero argument
         * top-level function whose name is `main`.
         */
        public abstract FunctionElement entryPoint { get; }

        /**
         * Return a list containing all of the libraries that are exported from this
         * library.
         */
        public abstract List<LibraryElement> exportedLibraries { get; }

        /**
         * The export [Namespace] of this library, `null` if it has not been
         * computed yet.
         */
        public abstract Namespace exportNamespace { get; }

        /**
         * Return a list containing all of the exports defined in this library.
         */
        public abstract List<ExportElement> exports { get; }

        /**
         * Return `true` if the defining compilation unit of this library contains at
         * least one import directive whose URI uses the "dart-ext" scheme.
         */
        public abstract bool hasExtUri { get; }

        /**
         * Return `true` if this library defines a top-level function named
         * `loadLibrary`.
         */
        public abstract bool hasLoadLibraryFunction { get; }

        /**
         * Return an identifier that uniquely identifies this element among the
         * children of this element's parent.
         */
        public abstract String identifier { get; }

        /**
         * Return a list containing all of the libraries that are imported into this
         * library. This includes all of the libraries that are imported using a
         * prefix (also available through the prefixes returned by [getPrefixes]) and
         * those that are imported without a prefix.
         */
        public abstract List<LibraryElement> importedLibraries { get; }

        /**
         * Return a list containing all of the imports defined in this library.
         */
        public abstract List<ImportElement> imports { get; }

        /**
         * Return `true` if this library is an application that can be run in the
         * browser.
         */
        public abstract bool isBrowserApplication { get; }

        /**
         * Return `true` if this library is the dart:async library.
         */
        public abstract bool isDartAsync { get; }

        /**
         * Return `true` if this library is the dart:core library.
         */
        public abstract bool isDartCore { get; }

        /**
         * Return `true` if this library is part of the SDK.
         */
        public abstract bool isInSdk { get; }

        /**
         * Return a list containing the strongly connected component in the
         * import/export graph in which the current library resides.
         */
        public abstract List<LibraryElement> libraryCycle { get; }

        /**
         * Return the element representing the synthetic function `loadLibrary` that
         * is implicitly defined for this library if the library is imported using a
         * deferred import.
         */
        public abstract FunctionElement loadLibraryFunction { get; }

        /**
         * Return a list containing all of the compilation units that are included in
         * this library using a `part` directive. This does not include the defining
         * compilation unit that contains the `part` directives.
         */
        public abstract List<CompilationUnitElement> parts { get; }

        /**
         * Return a list containing elements for each of the prefixes used to `import`
         * libraries into this library. Each prefix can be used in more than one
         * `import` directive.
         */
        public abstract List<PrefixElement> prefixes { get; }

        /**
         * The public [Namespace] of this library, `null` if it has not been
         * computed yet.
         */
        public abstract Namespace publicNamespace { get; }

        /**
         * Return a list containing all of the compilation units this library consists
         * of. This includes the defining compilation unit and units included using
         * the `part` directive.
         */
        public abstract List<CompilationUnitElement> units { get; }

        /**
         * Return a list containing all of the imports that share the given [prefix],
         * or an empty array if there are no such imports.
         */
        public abstract List<ImportElement> getImportsWithPrefix(PrefixElement prefix);

        /**
         * Return the class defined in this library that has the given [name], or
         * `null` if this library does not define a class with the given name.
         */
        public abstract ClassElement getType(String className);
    }

    /**
     * An element that can be (but is not required to be) defined within a method
     * or function (an [ExecutableElement]).
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public interface ILocalElement //: Element
    {
        /**
         * Return a source range that covers the approximate portion of the source in
         * which the name of this element is visible, or `null` if there is no single
         * range of characters within which the element name is visible.
         *
         * * For a local variable, this is the source range of the block that
         *   encloses the variable declaration.
         * * For a parameter, this includes the body of the method or function that
         *   declares the parameter.
         * * For a local function, this is the source range of the block that
         *   encloses the variable declaration.
         * * For top-level functions, `null` will be returned because they are
         *   potentially visible in multiple sources.
         */
        SourceRange visibleRange { get; }
    }

    /**
     * A local variable.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class LocalVariableElement : VariableElement, ILocalElement
    {
        /**
         * An empty list of field elements.
         */
        [Obsolete]
        public static List<LocalVariableElement> EMPTY_LIST =
          new List<LocalVariableElement> { };

        public SourceRange visibleRange { get; }
    }

    /**
     * An element that represents a method defined within a type.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class MethodElement : ExecutableElement, IClassMemberElement
    {
        /**
         * An empty list of method elements.
         */
        [Obsolete]
        public static List<MethodElement> EMPTY_LIST = new List<MethodElement> { };


        public abstract override AstNode computeNode(); //MethodDeclaration

        /**
         * Gets the reified type of a tear-off of this method.
         *
         * If any of the parameters in the method are covariant, they are replaced
         * with Object in the returned type. If no covariant parameters are present,
         * returns `this`.
         */
        [Obsolete]
        public abstract FunctionType getReifiedType(DartType objectType);
    }

    /**
     * A pseudo-element that represents multiple elements defined within a single
     * scope that have the same name. This situation is not allowed by the language,
     * so objects implementing this interface always represent an error. As a
     * result, most of the normal operations on elements do not make sense and will
     * return useless results.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class MultiplyDefinedElement : Element
    {
        /**
         * Return a list containing all of the elements that were defined within the
         * scope to have the same name.
         */
        List<Element> conflictingElements { get; }

        /**
         * Return the type of this element as the dynamic type.
         */
        DartType type { get; }
    }

    /**
     * An [ExecutableElement], with the additional information of a list of
     * [ExecutableElement]s from which this element was composed.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class MultiplyInheritedExecutableElement : ExecutableElement
    {
        /**
         * Return a list containing all of the executable elements defined within this
         * executable element.
         */
        List<ExecutableElement> inheritedElements { get; }
    }

    /**
     * An object that controls how namespaces are combined.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class NamespaceCombinator
    {
        /**
         * An empty list of namespace combinators.
         */
        [Obsolete]
        public static List<NamespaceCombinator> EMPTY_LIST =
          new List<NamespaceCombinator> { };
    }

    /**
     * A parameter defined within an executable element.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class ParameterElement
        :  VariableElement, IConstantEvaluationTarget, ILocalElement
    {
        /**
         * An empty list of parameter elements.
         */
        [Obsolete]
        public static List<ParameterElement> EMPTY_LIST = new List<ParameterElement> { };

        /**
         * Return the Dart code of the default value, or `null` if no default value.
         */
        public abstract String defaultValueCode { get; }

        /**
         * Return `true` if this parameter is covariant, meaning it is allowed to have
         * a narrower type in an override.
         */
        public abstract bool isCovariant { get; }

        /**
         * Return `true` if this parameter is an initializing formal parameter.
         */
        public abstract bool isInitializingFormal { get; }

        /**
         * Return `true` if this parameter is a named parameter. Named parameters are
         * always optional, even when they are annotated with the `@required`
         * annotation.
         */
        public abstract bool isNamed { get; }

        /**
         * Return `true` if this parameter is a required parameter. Required
         * parameters are always positional.
         *
         * Note: this will return `false` for a named parameter that is annotated with
         * the `@required` annotation.
         */
        // TODO(brianwilkerson) Rename this to `isRequired`.
        public abstract bool isNotOptional { get; }

        /**
         * Return `true` if this parameter is an optional parameter. Optional
         * parameters can either be positional or named.
         */
        public abstract bool isOptional { get; }

        /**
         * Return `true` if this parameter is both an optional and positional
         * parameter.
         */
        public abstract bool isOptionalPositional { get; }

        /**
         * Return `true` if this parameter is a positional parameter. Positional
         * parameters can either be required or optional.
         */
        public abstract bool isPositional { get; }

        /**
         * Return the kind of this parameter.
         */
        [Obsolete]
        public abstract ParameterKind parameterKind { get; }

        /**
         * Return a list containing all of the parameters defined by this parameter.
         * A parameter will only define other parameters if it is a function typed
         * parameter.
         */
        public abstract List<ParameterElement> parameters { get; }

        /**
         * Return a list containing all of the type parameters defined by this
         * parameter. A parameter will only define other parameters if it is a
         * function typed parameter.
         */
        public abstract List<TypeParameterElement> typeParameters { get; }

        public SourceRange visibleRange => throw new NotImplementedException();

        /**
         * Append the type, name and possibly the default value of this parameter to
         * the given [buffer].
         */
        public abstract void appendToWithoutDelimiters(StringBuffer buffer);


        public abstract override AstNode computeNode(); //FormalParameter
    }

    /**
     * A prefix used to import one or more libraries into another library.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class PrefixElement : Element
    {
        /**
         * An empty list of prefix elements.
         */
        [Obsolete]
        public static List<PrefixElement> EMPTY_LIST = new List<PrefixElement> { };

        public abstract override Element enclosingElement { get; } //LibraryElement

        /**
         * Return the empty list.
         *
         * Deprecated: this getter was intended to return a list containing all of
         * the libraries that are imported using this prefix, but it was never
         * implemented.  Due to lack of demand, it is being removed.
         */
        [Obsolete]
        public abstract List<LibraryElement> importedLibraries { get; }
    }

    /**
     * A getter or a setter. Note that explicitly defined property accessors
     * implicitly define a synthetic field. Symmetrically, synthetic accessors are
     * implicitly created for explicitly defined fields. The following rules apply:
     *
     * * Every explicit field is represented by a non-synthetic [FieldElement].
     * * Every explicit field induces a getter and possibly a setter, both of which
     *   are represented by synthetic [PropertyAccessorElement]s.
     * * Every explicit getter or setter is represented by a non-synthetic
     *   [PropertyAccessorElement].
     * * Every explicit getter or setter (or pair thereof if they have the same
     *   name) induces a field that is represented by a synthetic [FieldElement].
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class PropertyAccessorElement : ExecutableElement
    {
        /**
         * An empty list of property accessor elements.
         */
        [Obsolete]
        public static List<PropertyAccessorElement> EMPTY_LIST =
          new List<PropertyAccessorElement> { };

        /**
         * Return the accessor representing the getter that corresponds to (has the
         * same name as) this setter, or `null` if this accessor is not a setter or if
         * there is no corresponding getter.
         */
        public abstract PropertyAccessorElement correspondingGetter { get; }

        /**
         * Return the accessor representing the setter that corresponds to (has the
         * same name as) this getter, or `null` if this accessor is not a getter or if
         * there is no corresponding setter.
         */
        public abstract PropertyAccessorElement correspondingSetter { get; }

        /**
         * Return `true` if this accessor represents a getter.
         */
        public abstract bool isGetter { get; }

        /**
         * Return `true` if this accessor represents a setter.
         */
        public abstract bool isSetter { get; }

        /**
         * Return the field or top-level variable associated with this accessor. If
         * this accessor was explicitly defined (is not synthetic) then the variable
         * associated with it will be synthetic.
         */
        public abstract PropertyInducingElement variable { get; }
    }

    /**
     * A variable that has an associated getter and possibly a setter. Note that
     * explicitly defined variables implicitly define a synthetic getter and that
     * non-`final` explicitly defined variables implicitly define a synthetic
     * setter. Symmetrically, synthetic fields are implicitly created for explicitly
     * defined getters and setters. The following rules apply:
     *
     * * Every explicit variable is represented by a non-synthetic
     *   [PropertyInducingElement].
     * * Every explicit variable induces a getter and possibly a setter, both of
     *   which are represented by synthetic [PropertyAccessorElement]s.
     * * Every explicit getter or setter is represented by a non-synthetic
     *   [PropertyAccessorElement].
     * * Every explicit getter or setter (or pair thereof if they have the same
     *   name) induces a variable that is represented by a synthetic
     *   [PropertyInducingElement].
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class PropertyInducingElement : VariableElement
    {
        /**
         * An empty list of elements.
         */
        [Obsolete]
        public static List<PropertyInducingElement> EMPTY_LIST =
          new List<PropertyInducingElement> { };

        /**
         * Return the getter associated with this variable. If this variable was
         * explicitly defined (is not synthetic) then the getter associated with it
         * will be synthetic.
         */
        public abstract PropertyAccessorElement getter { get; }

        /**
         * Return the propagated type of this variable, or `null` if type propagation
         * has not been performed, for example because the variable is not final.
         */
        [Obsolete]
        public abstract DartType propagatedType { get; }

        /**
         * Return the setter associated with this variable, or `null` if the variable
         * is effectively `final` and therefore does not have a setter associated with
         * it. (This can happen either because the variable is explicitly defined as
         * being `final` or because the variable is induced by an explicit getter that
         * does not have a corresponding setter.) If this variable was explicitly
         * defined (is not synthetic) then the setter associated with it will be
         * synthetic.
         */
        public abstract PropertyAccessorElement setter { get; }
    }

    /**
     * A combinator that cause some of the names in a namespace to be visible (and
     * the rest hidden) when being imported.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class ShowElementCombinator : NamespaceCombinator
    {
        /**
         * Return the offset of the character immediately following the last character
         * of this node.
         */
        public abstract int end { get; }

        /**
         * Return the offset of the 'show' keyword of this element.
         */
        public abstract int offset { get; }

        /**
         * Return a list containing the names that are to be made visible in the
         * importing library if they are defined in the imported library.
         */
        public abstract List<String> shownNames { get; }
    }

    /**
     * A top-level variable.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class TopLevelVariableElement : PropertyInducingElement
    {
        /**
         * An empty list of top-level variable elements.
         */
        [Obsolete]
        public static List<TopLevelVariableElement> EMPTY_LIST =
          new List<TopLevelVariableElement> { };


        public abstract override AstNode computeNode(); // VariableDeclaration
    }

    /**
     * An element that defines a type.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public interface ITypeDefiningElement // : Element
    {
        /**
         * Return the type defined by this element.
         */
        DartType type { get; }
    }

    /**
     * A type parameter.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class TypeParameterElement : Element, ITypeDefiningElement
    {
        /**
         * An empty list of type parameter elements.
         */
        [Obsolete]
        public static List<TypeParameterElement> EMPTY_LIST =
          new List<TypeParameterElement> { };

        /**
         * Return the type representing the bound associated with this parameter, or
         * `null` if this parameter does not have an explicit bound.
         */
        public abstract DartType bound { get; }


        public abstract DartType type { get; } // TypeParameterType 

    }

    /**
     * An element that has type parameters, such as a class or a typedef. This also
     * includes functions and methods if support for generic methods is enabled.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class TypeParameterizedElement : Element
    {
        /**
         * The type of this element, which will be a parameterized type.
         */
        public abstract DartType type { get; } // ParameterizedType

        /**
         * Return a list containing all of the type parameters declared by this
         * element directly. This does not include type parameters that are declared
         * by any enclosing elements.
         */
        public abstract List<TypeParameterElement> typeParameters { get; }
    }

    /**
     * A pseudo-elements that represents names that are undefined. This situation is
     * not allowed by the language, so objects implementing this interface always
     * represent an error. As a result, most of the normal operations on elements do
     * not make sense and will return useless results.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class UndefinedElement : Element { }

    /**
     * An element included into a library using some URI.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public interface IUriReferencedElement //: Element
    {
        /**
         * Return the URI that is used to include this element into the enclosing
         * library, or `null` if this is the defining compilation unit of a library.
         */
        String uri { get; }

        /**
         * Return the offset of the character immediately following the last character
         * of this node's URI, or `-1` for synthetic import.
         */
        int uriEnd { get; }

        /**
         * Return the offset of the URI in the file, or `-1` if this element is
         * synthetic.
         */
        int uriOffset { get; }
    }

    /**
     * A variable. There are more specific subclasses for more specific kinds of
     * variables.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public abstract class VariableElement : Element, IConstantEvaluationTarget
    {
        /**
         * An empty list of variable elements.
         */
        [Obsolete]
        public static List<VariableElement> EMPTY_LIST = new List<VariableElement> { };

        /**
         * Return a representation of the value of this variable.
         *
         * Return `null` if either this variable was not declared with the 'const'
         * modifier or if the value of this variable could not be computed because of
         * errors.
         */
        public abstract DartObject constantValue { get; }

        /**
         * Return `true` if this variable element did not have an explicit type
         * specified for it.
         */
        public abstract bool hasImplicitType { get; }

        /**
         * Return a synthetic function representing this variable's initializer, or
         * `null` if this variable does not have an initializer. The function will
         * have no parameters. The return type of the function will be the
         * compile-time type of the initialization expression.
         */
        public abstract FunctionElement initializer { get; }

        /**
         * Return `true` if this variable was declared with the 'const' modifier.
         */
        public abstract bool isnew { get; }

        /**
         * Return `true` if this variable was declared with the 'final' modifier.
         * Variables that are declared with the 'const' modifier will return `false`
         * even though they are implicitly final.
         */
        public abstract bool isFinal { get; }

        /**
         * Return `true` if this variable is potentially mutated somewhere in a
         * closure. This information is only available for local variables (including
         * parameters) and only after the compilation unit containing the variable has
         * been resolved.
         *
         * This getter is deprecated--it now returns `true` for all local variables
         * and parameters.  Please use [FunctionBody.isPotentiallyMutatedInClosure]
         * instead.
         */
        [Obsolete]
        public abstract bool isPotentiallyMutatedInClosure { get; }

        /**
         * Return `true` if this variable is potentially mutated somewhere in its
         * scope. This information is only available for local variables (including
         * parameters) and only after the compilation unit containing the variable has
         * been resolved.
         *
         * This getter is deprecated--it now returns `true` for all local variables
         * and parameters.  Please use [FunctionBody.isPotentiallyMutatedInClosure]
         * instead.
         */
        [Obsolete]
        public abstract bool isPotentiallyMutatedInScope { get; }

        /**
         * Return `true` if this element is a static variable, as per section 8 of the
         * Dart Language Specification:
         *
         * > A static variable is a variable that is not associated with a particular
         * > instance, but rather with an entire library or class. Static variables
         * > include library variables and class variables. Class variables are
         * > variables whose declaration is immediately nested inside a class
         * > declaration and includes the modifier static. A library variable is
         * > implicitly static.
         */
        public abstract bool isStatic { get; }

        /**
         * Return the declared type of this variable, or `null` if the variable did
         * not have a declared type (such as if it was declared using the keyword
         * 'var').
         */
        public abstract DartType type { get; }

        /**
         * Return a representation of the value of this variable, forcing the value
         * to be computed if it had not previously been computed, or `null` if either
         * this variable was not declared with the 'const' modifier or if the value of
         * this variable could not be computed because of errors.
         */
        public abstract DartObject computeConstantValue();
    }
}
