using System;
using System.Collections.Generic;
using System.Linq;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/dart/resolver/scope.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2014, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.

    //    library analyzer.src.dart.resolver.scope;

    //    import 'dart:collection';

    //import 'package:analyzer/dart/ast/ast.dart';
    //import 'package:analyzer/dart/element/element.dart';
    //import 'package:analyzer/src/dart/element/element.dart';
    //import 'package:analyzer/src/generated/engine.dart';
    //import 'package:analyzer/src/generated/java_engine.dart';
    //import 'package:analyzer/src/generated/source.dart';

    /**
     * The scope defined by a block.
     */
    public class BlockScope : EnclosedScope
    {
        /**
         * Initialize a newly created scope, enclosed within the [enclosingScope],
         * based on the given [block].
         */
        public BlockScope(Scope enclosingScope, Block block) : base(enclosingScope)
        {
            if (block == null)
            {
                throw new ArgumentException("block cannot be null");
            }
            _defineElements(block);
        }

        void _defineElements(Block block)
        {
            foreach (Element element in elementsInBlock(block))
            {
                define(element);
            }
        }

        /**
         * Return the elements that are declared directly in the given [block]. This
         * does not include elements declared in nested blocks.
         */
        //sync*
        public static Iterable<Element> elementsInBlock(Block block)
        {
            NodeList<IStatement> statements = block.statements;
            int statementCount = statements.Count;
            Iterable<Element> list = new Iterable<Element>();
            for (int i = 0; i < statementCount; i++)
            {
                IStatement statement = statements[i];
                if (statement is VariableDeclarationStatement vStatement)
                {
                    NodeList<VariableDeclaration> variables = vStatement.variables.variables;
                    int variableCount = variables.Count;
                    for (int j = 0; j < variableCount; j++)
                    {
                       list.Add(variables[j].declaredElement);
                    }
                }
                else if (statement is FunctionDeclarationStatement fStatement)
                {
                    list.Add(fStatement.functionDeclaration.declaredElement);
                }
            }

            return list;
        }
    }

    /**
     * The scope defined by a class.
     */
    public class ClassScope : EnclosedScope
    {
        /**
         * Initialize a newly created scope, enclosed within the [enclosingScope],
         * based on the given [classElement].
         */
        public ClassScope(Scope enclosingScope, ClassElement classElement)
          : base(enclosingScope)
        {
            if (classElement == null)
            {
                throw new ArgumentException("class element cannot be null");
            }
            _defineMembers(classElement);
        }

        /**
         * Define the instance members defined by the given [classElement].
         */
        void _defineMembers(ClassElement classElement)
        {
            List<PropertyAccessorElement> accessors = classElement.accessors;
            int accessorLength = accessors.Count;
            for (int i = 0; i < accessorLength; i++)
            {
                define(accessors[i]);
            }
            List<MethodElement> methods = classElement.methods;
            int methodLength = methods.Count;
            for (int i = 0; i < methodLength; i++)
            {
                define(methods[i]);
            }
        }
    }

    /**
     * The scope defined for the initializers in a constructor.
     */
    public class ConstructorInitializerScope : EnclosedScope
    {
        /**
         * Initialize a newly created scope, enclosed within the [enclosingScope].
         */
        public ConstructorInitializerScope(Scope enclosingScope, ConstructorElement element)
          : base(enclosingScope)
        {
            _initializeFieldFormalParameters(element);
        }

        /**
         * Initialize the local scope with all of the field formal parameters.
         */
        public void _initializeFieldFormalParameters(ConstructorElement element)
        {
            foreach (ParameterElement parameter in element.parameters)
            {
                if (parameter is FieldFormalParameterElement)
                {
                    define(parameter);
                }
            }
        }
    }

    /**
     * A scope that is lexically enclosed in another scope.
     */
    public class EnclosedScope : Scope
    {
        /**
         * The scope in which this scope is lexically enclosed.
         */

        public readonly Scope enclosingScope;

        /**
         * Initialize a newly created scope, enclosed within the [enclosingScope].
         */
        public EnclosedScope(Scope enclosingScope)
        {
            this.enclosingScope = enclosingScope;
        }


        public override Element internalLookup(
            Identifier identifier, String name, LibraryElement referencingLibrary)
        {
            Element element = localLookup(name, referencingLibrary);
            if (element != null)
            {
                return element;
            }
            // Check enclosing scope.
            return enclosingScope.internalLookup(identifier, name, referencingLibrary);
        }


        public override Element _internalLookupPrefixed(PrefixedIdentifier identifier, String prefix,
            String name, LibraryElement referencingLibrary)
        {
            return enclosingScope._internalLookupPrefixed(
                identifier, prefix, name, referencingLibrary);
        }
    }

    /**
     * The scope defined by a function.
     */
    public class FunctionScope : EnclosedScope
    {
        /**
         * The element representing the function that defines this scope.
         */
        readonly FunctionTypedElement _functionElement;

        /**
         * A flag indicating whether the parameters have already been defined, used to
         * prevent the parameters from being defined multiple times.
         */
        bool _parametersDefined = false;

        /**
         * Initialize a newly created scope, enclosed within the [enclosingScope],
         * that represents the given [_functionElement].
         */
        public FunctionScope(Scope enclosingScope, FunctionTypedElement _functionElement)
          : base(new EnclosedScope(new EnclosedScope(enclosingScope)))
        {
            this._functionElement = _functionElement;
            if (_functionElement == null)
            {
                throw new ArgumentException("function element cannot be null");
            }
            _defineTypeParameters();
        }

        /**
         * Define the parameters for the given function in the scope that encloses
         * this function.
         */
        public void defineParameters()
        {
            if (_parametersDefined)
            {
                return;
            }
            _parametersDefined = true;
            Scope parameterScope = enclosingScope;
            List<ParameterElement> parameters = _functionElement.parameters;
            int length = parameters.Count;
            for (int i = 0; i < length; i++)
            {
                ParameterElement parameter = parameters[i];
                if (!parameter.isInitializingFormal)
                {
                    parameterScope.define(parameter);
                }
            }
        }

        /**
         * Define the type parameters for the function.
         */
        void _defineTypeParameters()
        {
            Scope typeParameterScope = enclosingScope.enclosingScope;
            List<TypeParameterElement> typeParameters = _functionElement.typeParameters;
            int length = typeParameters.Count;
            for (int i = 0; i < length; i++)
            {
                TypeParameterElement typeParameter = typeParameters[i];
                typeParameterScope.define(typeParameter);
            }
        }
    }

    /**
     * The scope defined by a function type alias.
     */
    public class FunctionTypeScope : EnclosedScope
    {
        readonly FunctionTypeAliasElement _typeElement;

        bool _parametersDefined = false;

        /**
         * Initialize a newly created scope, enclosed within the [enclosingScope],
         * that represents the given [_typeElement].
         */
        public FunctionTypeScope(Scope enclosingScope, FunctionTypeAliasElement _typeElement)
          : base(new EnclosedScope(enclosingScope))
        {
            this._typeElement = _typeElement;
            _defineTypeParameters();
        }

        /**
         * Define the parameters for the function type alias.
         */
        public void defineParameters()
        {
            if (_parametersDefined)
            {
                return;
            }
            _parametersDefined = true;
            foreach (ParameterElement parameter in _typeElement.parameters)
            {
                define(parameter);
            }
        }

        /**
         * Define the type parameters for the function type alias.
         */
        void _defineTypeParameters()
        {
            Scope typeParameterScope = enclosingScope;
            foreach (TypeParameterElement typeParameter in _typeElement.typeParameters)
            {
                typeParameterScope.define(typeParameter);
            }
        }
    }

    /**
     * The scope statements that can be the target of unlabeled `break` and
     * `continue` statements.
     */
    class ImplicitLabelScope
    {
        /**
         * The implicit label scope associated with the top level of a function.
         */
        public static ImplicitLabelScope ROOT = new ImplicitLabelScope(null, null);

        /**
         * The implicit label scope enclosing this implicit label scope.
         */
        public readonly ImplicitLabelScope outerScope;

        /**
         * The statement that acts as a target for break and/or continue statements
         * at this scoping level.
         */
        public readonly Statement statement;

        /**
         * Initialize a newly created scope, enclosed within the [outerScope],
         * representing the given [statement].
         */
        public ImplicitLabelScope(ImplicitLabelScope outerScope, Statement statement)
        {
            this.outerScope = outerScope;
            this.statement = statement;

        }

        /**
         * Return the statement which should be the target of an unlabeled `break` or
         * `continue` statement, or `null` if there is no appropriate target.
         */
        public Statement getTarget(bool isContinue)
        {
            if (outerScope == null)
            {
                // This scope represents the toplevel of a function body, so it doesn't
                // match either break or continue.
                return null;
            }
            if (isContinue && statement is SwitchStatement)
            {
                return outerScope.getTarget(isContinue);
            }
            return statement;
        }

        /**
         * Initialize a newly created scope to represent a switch statement or loop
         * nested within the current scope.  [statement] is the statement associated
         * with the newly created scope.
         */
        public ImplicitLabelScope nest(Statement statement) =>
            new ImplicitLabelScope(this, statement);
    }

    /**
     * A scope in which a single label is defined.
     */
    public class LabelScope
    {
        /**
         * The label scope enclosing this label scope.
         */
        readonly LabelScope _outerScope;

        /**
         * The label defined in this scope.
         */
        readonly String _label;

        /**
         * The element to which the label resolves.
         */
        public readonly LabelElement element;

        /**
         * The AST node to which the label resolves.
         */
        public readonly AstNode node;

        /**
         * Initialize a newly created scope, enclosed within the [_outerScope],
         * representing the label [_label]. The [node] is the AST node the label
         * resolves to. The [element] is the element the label resolves to.
         */
        public LabelScope(LabelScope _outerScope, String _label, AstNode node, LabelElement element)
        {
            this._outerScope = _outerScope;
            this._label = _label;
            this.node = node;
            this.element = element;
        }

        /**
         * Return the LabelScope which defines [targetLabel], or `null` if it is not
         * defined in this scope.
         */
        public LabelScope lookup(String targetLabel)
        {
            if (_label == targetLabel)
            {
                return this;
            }
            return _outerScope?.lookup(targetLabel);
        }
    }

    /**
     * The scope containing all of the names available from imported libraries.
     */
    public class LibraryImportScope : Scope
    {
        /**
         * The element representing the library in which this scope is enclosed.
         */
        readonly LibraryElement _definingLibrary;

        /**
         * A list of the namespaces representing the names that are available in this scope from imported
         * libraries.
         */
        List<Namespace> _importedNamespaces;

        /**
         * A table mapping prefixes that have been referenced to a map from the names
         * that have been referenced to the element associated with the prefixed name.
         */
        Dictionary<String, Dictionary<String, Element>> _definedPrefixedNames;

        /**
         * Initialize a newly created scope representing the names imported into the
         * [_definingLibrary].
         */
        public LibraryImportScope(LibraryElement _definingLibrary)
        {
            this._definingLibrary = _definingLibrary;
            _createImportedNamespaces();
        }


        public void define(Element element)
        {
            if (!Scope.isPrivateName(element.displayName))
            {
                base.define(element);
            }
        }


        public Source getSource(AstNode node)
        {
            Source source = base.getSource(node);
            if (source == null)
            {
                source = _definingLibrary.definingCompilationUnit.source;
            }
            return source;
        }


        public override Element internalLookup(
            Identifier identifier, String name, LibraryElement referencingLibrary)
        {
            Element element = localLookup(name, referencingLibrary);
            if (element != null)
            {
                return element;
            }
            element = _lookupInImportedNamespaces(
                identifier, (Namespace @namespace) => @namespace.get(name));
            if (element != null)
            {
                defineNameWithoutChecking(name, element);
            }
            return element;
        }


        public bool shouldIgnoreUndefined(Identifier node)
        {
            List<NamespaceCombinator> getShowCombinators(
                    ImportElement importElement) =>
                importElement.combinators.Where((NamespaceCombinator combinator) =>
                    combinator is ShowElementCombinator).ToList();
            if (node is PrefixedIdentifier pNode)
            {
                String prefix = pNode.prefix.name;
                String name = pNode.identifier.name;
                List<ImportElement> imports = _definingLibrary.imports;
                int count = imports.Count;
                for (int i = 0; i < count; i++)
                {
                    ImportElement importElement = imports[i];
                    if (importElement.prefix?.name == prefix &&
                        importElement.importedLibrary?.isSynthetic != false)
                    {
                        List<NamespaceCombinator> showCombinators =
                            getShowCombinators(importElement);
                        if (showCombinators.isEmpty())
                        {
                            return true;
                        }
                        foreach (ShowElementCombinator combinator in showCombinators)
                        {
                            if (combinator.shownNames.Contains(name))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            else if (node is SimpleIdentifier)
            {
                String name = node.name;
                List<ImportElement> imports = _definingLibrary.imports;
                int count = imports.Count;
                for (int i = 0; i < count; i++)
                {
                    ImportElement importElement = imports[i];
                    if (importElement.prefix == null &&
                        importElement.importedLibrary?.isSynthetic != false)
                    {
                        foreach (ShowElementCombinator combinator
                            in getShowCombinators(importElement))
                        {
                            if (combinator.shownNames.Contains(name))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        /**
         * Create all of the namespaces associated with the libraries imported into
         * this library. The names are not added to this scope, but are stored for
         * later reference.
         */
        public void _createImportedNamespaces()
        {
            List<ImportElement> imports = _definingLibrary.imports;
            int count = imports.Count;
            _importedNamespaces = new List<Namespace>(count);
            for (int i = 0; i < count; i++)
            {
                _importedNamespaces[i] = imports[i].@namespace;
            }
        }

        /**
         * Add the given [element] to this scope without checking for duplication or
         * hiding.
         */
        public void _definePrefixedNameWithoutChecking(
            String prefix, String name, Element element)
        {
            if (_definedPrefixedNames == null)
                _definedPrefixedNames = new Dictionary<String, Dictionary<String, Element>>();
            Dictionary<String, Element> unprefixedNames = _definedPrefixedNames.putIfAbsent(
                prefix, () => new Dictionary<String, Element>());
            unprefixedNames.putIfAbsent(name, () => element);
        }


        public override Element _internalLookupPrefixed(PrefixedIdentifier identifier, String prefix,
            String name, LibraryElement referencingLibrary)
        {
            Element element = _localPrefixedLookup(prefix, name);
            if (element != null)
            {
                return element;
            }
            element = _lookupInImportedNamespaces(identifier.identifier,
                (Namespace @namespace) => @namespace.getPrefixed(prefix, name));
            if (element != null)
            {
                _definePrefixedNameWithoutChecking(prefix, name, element);
            }
            return element;
        }

        /**
         * Return the element with which the given [prefix] and [name] are associated,
         * or `null` if the name is not defined within this scope.
         */
        public Element _localPrefixedLookup(String prefix, String name)
        {
            if (_definedPrefixedNames != null)
            {
                Dictionary<String, Element> unprefixedNames = _definedPrefixedNames[prefix];
                if (unprefixedNames != null)
                {
                    return unprefixedNames[name];
                }
            }
            return null;
        }

        public Element _lookupInImportedNamespaces(
            Identifier identifier, Func<Namespace, Element> lookup)
        {
            Element result = null;

            bool hasPotentialConflict = false;
            for (int i = 0; i < _importedNamespaces.Count; i++)
            {
                Element element = lookup(_importedNamespaces[i]);
                if (element != null)
                {
                    if (result == null || result == element)
                    {
                        result = element;
                    }
                    else
                    {
                        hasPotentialConflict = true;
                    }
                }
            }

            if (hasPotentialConflict)
            {
                var sdkElements = new HashSet<Element>();
                var nonSdkElements = new HashSet<Element>();
                for (int i = 0; i < _importedNamespaces.Count; i++)
                {
                    Element element = lookup(_importedNamespaces[i]);
                    if (element != null)
                    {
                        if (element.library.isInSdk)
                        {
                            sdkElements.Add(element);
                        }
                        else
                        {
                            nonSdkElements.Add(element);
                        }
                    }
                }
                if (sdkElements.Count > 1 || nonSdkElements.Count > 1)
                {
                    var conflictingElements = new List<Element> { };
                    conflictingElements.addAll(sdkElements.ToList());
                    conflictingElements.addAll(nonSdkElements.ToList());
                    return new MultiplyDefinedElementImpl(_definingLibrary.context,
                        conflictingElements.First().name, conflictingElements);
                }
                if (nonSdkElements.isNotEmpty)
                {
                    result = nonSdkElements.First();
                }
                else if (sdkElements.isNotEmpty)
                {
                    result = sdkElements.First();
                }
            }

            return result;
        }
    }

    /**
     * A scope containing all of the names defined in a given library.
     */
    public class LibraryScope : EnclosedScope
    {
        /**
         * Initialize a newly created scope representing the names defined in the
         * [definingLibrary].
         */
        public LibraryScope(LibraryElement definingLibrary)
          : base(new LibraryImportScope(definingLibrary))
        {
            _defineTopLevelNames(definingLibrary);

            // For `dart:core` to be able to pass analysis, it has to have `dynamic`
            // added to its library scope. Note that this is not true of, for instance,
            // `Object`, because `Object` has a source definition which is not possible
            // for `dynamic`.
            if (definingLibrary.isDartCore)
            {
                define(DynamicElementImpl.instance);
            }
        }

        /**
         * Add to this scope all of the public top-level names that are defined in the
         * given [compilationUnit].
         */
        void _defineLocalNames(CompilationUnitElement compilationUnit)
        {
            foreach (PropertyAccessorElement element in compilationUnit.accessors)
            {
                define(element);
            }
            foreach (ClassElement element in compilationUnit.enums)
            {
                define(element);
            }
            foreach (FunctionElement element in compilationUnit.functions)
            {
                define(element);
            }
            foreach (FunctionTypeAliasElement element
            in compilationUnit.functionTypeAliases)
            {
                define(element);
            }
            foreach (ClassElement element in compilationUnit.mixins)
            {
                define(element);
            }
            foreach (ClassElement element in compilationUnit.types)
            {
                define(element);
            }
        }

        /**
         * Add to this scope all of the names that are explicitly defined in the
         * [definingLibrary].
         */
        void _defineTopLevelNames(LibraryElement definingLibrary)
        {
            foreach (PrefixElement prefix in definingLibrary.prefixes)
            {
                define(prefix);
            }
            _defineLocalNames(definingLibrary.definingCompilationUnit);
            foreach (CompilationUnitElement compilationUnit in definingLibrary.parts)
            {
                _defineLocalNames(compilationUnit);
            }
        }
    }

    /**
     * A mapping of identifiers to the elements represented by those identifiers.
     * Namespaces are the building blocks for scopes.
     */
    public class Namespace
    {
        /**
         * An empty namespace.
         */
        public static Namespace EMPTY = new Namespace(new Dictionary<String, Element>());

        /**
         * A table mapping names that are defined in this namespace to the element
         * representing the thing declared with that name.
         */
        readonly Dictionary<String, Element> _definedNames;

        /**
         * Initialize a newly created namespace to have the [_definedNames].
         */
        public Namespace(Dictionary<String, Element> _definedNames)
        {
            this._definedNames = _definedNames;
        }

        /**
         * Return a table containing the same mappings as those defined by this
         * namespace.
         */
        public Dictionary<String, Element> definedNames => _definedNames;

        /**
         * Return the element in this namespace that is available to the containing
         * scope using the given name, or `null` if there is no such element.
         */
        public Element get(String name) => _definedNames[name];

        /**
         * Return the element in this namespace whose name is the result of combining
         * the [prefix] and the [name], separated by a period, or `null` if there is
         * no such element.
         */
        public Element getPrefixed(String prefix, String name) => null;
    }

    /**
     * The builder used to build a namespace. Namespace builders are thread-safe and
     * re-usable.
     */
    public class NamespaceBuilder
    {
        /**
         * Create a namespace representing the export namespace of the given [element].
         */
        public Namespace createExportNamespaceForDirective(ExportElement element)
        {
            LibraryElement exportedLibrary = element.exportedLibrary;
            if (exportedLibrary == null)
            {
                //
                // The exported library will be null if the URI does not reference a valid
                // library.
                //
                return Namespace.EMPTY;
            }
            Dictionary<String, Element> exportedNames = _getExportMapping(exportedLibrary);
            exportedNames = _applyCombinators(exportedNames, element.combinators);
            return new Namespace(exportedNames);
        }

        /**
         * Create a namespace representing the export namespace of the given [library].
         */
        public Namespace createExportNamespaceForLibrary(LibraryElement library)
        {
            Dictionary<String, Element> exportedNames = _getExportMapping(library);
            return new Namespace(exportedNames);
        }

        /**
         * Create a namespace representing the import namespace of the given [element].
         */
        public Namespace createImportNamespaceForDirective(ImportElement element)
        {
            LibraryElement importedLibrary = element.importedLibrary;
            if (importedLibrary == null)
            {
                //
                // The imported library will be null if the URI does not reference a valid
                // library.
                //
                return Namespace.EMPTY;
            }
            Dictionary<String, Element> exportedNames = _getExportMapping(importedLibrary);
            exportedNames = _applyCombinators(exportedNames, element.combinators);
            PrefixElement prefix = element.prefix;
            if (prefix != null)
            {
                return new PrefixedNamespace(prefix.name, exportedNames);
            }
            return new Namespace(exportedNames);
        }

        /**
         * Create a namespace representing the public namespace of the given
         * [library].
         */
        public Namespace createPublicNamespaceForLibrary(LibraryElement library)
        {
            Dictionary<String, Element> definedNames = new Dictionary<String, Element>();
            _addPublicNames(definedNames, library.definingCompilationUnit);
            foreach (CompilationUnitElement compilationUnit in library.parts)
            {
                _addPublicNames(definedNames, compilationUnit);
            }

            // For libraries that import `dart:core` with a prefix, we have to add
            // `dynamic` to the `dart:core` [Namespace] specially. Note that this is not
            // true of, for instance, `Object`, because `Object` has a source definition
            // which is not possible for `dynamic`.
            if (library.isDartCore)
            {
                DynamicElementImpl.instance.library = library;
                definedNames["dynamic"] = DynamicElementImpl.instance;
            }

            return new Namespace(definedNames);
        }

        /**
         * Add all of the names in the given [namespace] to the table of
         * [definedNames].
         */
        public void _addAllFromNamespace(
            Dictionary<String, Element> definedNames, Namespace @namespace)
        {
            if (@namespace != null)
            {
                definedNames.addAll(@namespace.definedNames);
            }
        }

        /**
         * Add the given [element] to the table of [definedNames] if it has a
         * publicly visible name.
         */
        void _addIfPublic(Dictionary<String, Element> definedNames, Element element)
        {
            String name = element.name;
            if (name != null && !Scope.isPrivateName(name))
            {
                definedNames[name] = element;
            }
        }

        /**
         * Add to the table of [definedNames] all of the public top-level names that
         * are defined in the given [compilationUnit].
         *          namespace
         */
        public void _addPublicNames(Dictionary<String, Element> definedNames,
            CompilationUnitElement compilationUnit)
        {
            foreach (PropertyAccessorElement element in compilationUnit.accessors)
            {
                _addIfPublic(definedNames, element);
            }
            foreach (ClassElement element in compilationUnit.enums)
            {
                _addIfPublic(definedNames, element);
            }
            foreach (FunctionElement element in compilationUnit.functions)
            {
                _addIfPublic(definedNames, element);
            }
            foreach (FunctionTypeAliasElement element in compilationUnit.functionTypeAliases)
            {
                _addIfPublic(definedNames, element);
            }
            foreach (ClassElement element in compilationUnit.mixins)
            {
                _addIfPublic(definedNames, element);
            }
            foreach (ClassElement element in compilationUnit.types)
            {
                _addIfPublic(definedNames, element);
            }
        }

        /**
         * Apply the given [combinators] to all of the names in the given table of
         * [definedNames].
         */
        Dictionary<String, Element> _applyCombinators(Dictionary<String, Element> definedNames,
            List<NamespaceCombinator> combinators)
        {
            foreach (NamespaceCombinator combinator in combinators)
            {
                if (combinator is HideElementCombinator hCombinator)
                {
                    definedNames = _hide(definedNames, hCombinator.hiddenNames);
                }
                else if (combinator is ShowElementCombinator sCombinator)
                {
                    definedNames = _show(definedNames, sCombinator.shownNames);
                }
                else
                {
                    // Internal error.
                    AnalysisEngine.instance.logger
                        .logError("Unknown type of combinator: ${combinator.runtimeType}");
                }
            }
            return definedNames;
        }

        /**
         * Create a mapping table representing the export namespace of the given
         * [library]. The set of [visitedElements] contains the libraries that do not
         * need to be visited when processing the export directives of the given
         * library because all of the names defined by them will be added by another
         * library.
         */
        Dictionary<String, Element> _computeExportMapping(
            LibraryElement library, HashSet<LibraryElement> visitedElements)
        {
            visitedElements.Add(library);
            try
            {
                Dictionary<String, Element> definedNames = new Dictionary<String, Element>();
                foreach (ExportElement element in library.exports)
                {
                    LibraryElement exportedLibrary = element.exportedLibrary;
                    if (exportedLibrary != null &&
                        !visitedElements.Contains(exportedLibrary))
                    {
                        //
                        // The exported library will be null if the URI does not reference a
                        // valid library.
                        //
                        Dictionary<String, Element> exportedNames =
                            _computeExportMapping(exportedLibrary, visitedElements);
                        exportedNames = _applyCombinators(exportedNames, element.combinators);
                        definedNames.addAll(exportedNames);
                    }
                }
                _addAllFromNamespace(
                    definedNames,
                    (library.context as InternalAnalysisContext)
                        .getPublicNamespace(library));
                return definedNames;
            }
            finally
            {
                visitedElements.Remove(library);
            }
        }

        public Dictionary<String, Element> _getExportMapping(LibraryElement library)
        {
            if (library.exportNamespace != null)
            {
                return library.exportNamespace.definedNames;
            }
            if (library is LibraryElementImpl)
            {
                Dictionary<String, Element> exportMapping =
                    _computeExportMapping(library, new HashSet<LibraryElement>());
                library.exportNamespace = new Namespace(exportMapping);
                return exportMapping;
            }
            return _computeExportMapping(library, new HashSet<LibraryElement>());
        }

        /**
         * Return a new map of names which has all the names from [definedNames]
         * with exception of [hiddenNames].
         */
        public Dictionary<String, Element> _hide(
            Dictionary<String, Element> definedNames, List<String> hiddenNames)
        {
            Dictionary<String, Element> newNames =
                new Dictionary<String, Element>(definedNames);
            foreach (String name in hiddenNames)
            {
                newNames.Remove(name);
                newNames.Remove("$name=");
            }
            return newNames;
        }

        /**
         * Return a new map of names which has only [shownNames] from [definedNames].
         */
        Dictionary<String, Element> _show(
            Dictionary<String, Element> definedNames, List<String> shownNames)
        {
            Dictionary<String, Element> newNames = new Dictionary<String, Element>();
            foreach (String name in shownNames)
            {
                Element element = definedNames[name];
                if (element != null)
                {
                    newNames[name] = element;
                }
                String setterName = "$name=";
                element = definedNames[setterName];
                if (element != null)
                {
                    newNames[setterName] = element;
                }
            }
            return newNames;
        }
    }

    /**
     * A mapping of identifiers to the elements represented by those identifiers.
     * Namespaces are the building blocks for scopes.
     */
    public class PrefixedNamespace : Namespace
    {
        /**
         * The prefix that is prepended to each of the defined names.
         */
        readonly String _prefix;

        /**
         * The length of the prefix.
         */
        readonly int _length;

        /**
         * A table mapping names that are defined in this namespace to the element
         * representing the thing declared with that name.
         */
        readonly Dictionary<String, Element> _definedNames;

        /**
         * Initialize a newly created namespace to have the names resulting from
         * prefixing each of the [_definedNames] with the given [_prefix] (and a
         * period).
         */
        public PrefixedNamespace(String prefix, Dictionary<String, Element> _definedNames) : base(_definedNames)
        {
            _prefix = prefix;
            this._definedNames = _definedNames;
            _length = prefix.Length;
        }


        public Dictionary<String, Element> definedNames
        {
            get
            {
                Dictionary<String, Element> definedNames = new Dictionary<String, Element> { };
                _definedNames.forEach((String name, Element element) =>
                {
                    definedNames["$_prefix.$name"] = element;
                });
                return definedNames;
            }
        }


        public Element get(String name)
        {
            if (name.Length > _length && name.StartsWith(_prefix))
            {
                if (name.codeUnitAt(_length) == ".".codeUnitAt(0))
                {
                    return _definedNames[name.Substring(_length + 1)];
                }
            }
            return null;
        }


        public Element getPrefixed(String prefix, String name)
        {
            if (prefix == _prefix)
            {
                return _definedNames[name];
            }
            return null;
        }
    }

    /**
     * A name scope used by the resolver to determine which names are visible at any
     * given point in the code.
     */
    public abstract class Scope
    {
        /**
         * The prefix used to mark an identifier as being private to its library.
         */
        public static int PRIVATE_NAME_PREFIX = 0x5F;

        /**
         * The suffix added to the declared name of a setter when looking up the
         * setter. Used to disambiguate between a getter and a setter that have the
         * same name.
         */
        public static String SETTER_SUFFIX = "=";

        /**
         * The name used to look up the method used to implement the unary minus
         * operator. Used to disambiguate between the unary and binary operators.
         */
        public static String UNARY_MINUS = "unary-";

        /**
         * A table mapping names that are defined in this scope to the element
         * representing the thing declared with that name.
         */
        public Dictionary<String, Element> _definedNames = null;

        /**
         * Return the scope in which this scope is lexically enclosed.
         */
        public Scope enclosingScope => null;

        /**
         * Add the given [element] to this scope. If there is already an element with
         * the given name defined in this scope, then the original element will
         * continue to be mapped to the name.
         */
        public void define(Element element)
        {
            String name = _getName(element);
            if (name != null && !name.isEmpty())
            {
                if (_definedNames == null)
                    _definedNames = new Dictionary<String, Element>();
                _definedNames.putIfAbsent(name, () => element);
            }
        }

        /**
         * Add the given [element] to this scope without checking for duplication or
         * hiding.
         */
        public void defineNameWithoutChecking(String name, Element element)
        {
            if (_definedNames == null)
                _definedNames = new Dictionary<String, Element>();
            _definedNames[name] = element;
        }

        /**
         * Add the given [element] to this scope without checking for duplication or
         * hiding.
         */
        public void defineWithoutChecking(Element element)
        {
            if (_definedNames == null)
                _definedNames = new Dictionary<String, Element>();
            _definedNames[_getName(element)] = element;
        }

        /**
         * Return the source that contains the given [identifier], or the source
         * associated with this scope if the source containing the identifier could
         * not be determined.
         */
        public Source getSource(AstNode identifier)
        {
            CompilationUnit unit =
                identifier.getAncestor<CompilationUnit>((node) => node is CompilationUnit);
            if (unit != null)
            {
                CompilationUnitElement unitElement = unit.declaredElement;
                if (unitElement != null)
                {
                    return unitElement.source;
                }
            }
            return null;
        }

        /**
         * Return the element with which the given [name] is associated, or `null` if
         * the name is not defined within this scope. The [identifier] is the
         * identifier node to lookup element for, used to report correct kind of a
         * problem and associate problem with. The [referencingLibrary] is the library
         * that contains the reference to the name, used to implement library-level
         * privacy.
         */
        public abstract Element internalLookup(
            Identifier identifier, String name, LibraryElement referencingLibrary);

        /**
         * Return the element with which the given [name] is associated, or `null` if
         * the name is not defined within this scope. This method only returns
         * elements that are directly defined within this scope, not elements that are
         * defined in an enclosing scope. The [referencingLibrary] is the library that
         * contains the reference to the name, used to implement library-level privacy.
         */
        public Element localLookup(String name, LibraryElement referencingLibrary)
        {
            if (_definedNames != null)
            {
                return _definedNames[name];
            }
            return null;
        }

        /**
         * Return the element with which the given [identifier] is associated, or
         * `null` if the name is not defined within this scope. The
         * [referencingLibrary] is the library that contains the reference to the
         * name, used to implement library-level privacy.
         */
        public Element lookup(Identifier identifier, LibraryElement referencingLibrary)
        {
            if (identifier is PrefixedIdentifier pIdentifier)
            {
                return _internalLookupPrefixed(pIdentifier, pIdentifier.prefix.name,
                    pIdentifier.identifier.name, referencingLibrary);
            }
            return internalLookup(identifier, identifier.name, referencingLibrary);
        }

        /**
         * Return `true` if the fact that the given [node] is not defined should be
         * ignored (from the perspective of error reporting). This will be the case if
         * there is at least one import that defines the node's prefix, and if that
         * import either has no show combinators or has a show combinator that
         * explicitly lists the node's name.
         */
        public bool shouldIgnoreUndefined(Identifier node)
        {
            if (enclosingScope != null)
            {
                return enclosingScope.shouldIgnoreUndefined(node);
            }
            return false;
        }

        /**
         * Return the name that will be used to look up the given [element].
         */
        public String _getName(Element element)
        {
            if (element is MethodElement method)
            {
                if (method.name == "-" && method.parameters.Count == 0)
                {
                    return UNARY_MINUS;
                }
            }
            return element.name;
        }

        /**
         * Return the element with which the given [prefix] and [name] are associated,
         * or `null` if the name is not defined within this scope. The [identifier] is
         * the identifier node to lookup element for, used to report correct kind of a
         * problem and associate problem with. The [referencingLibrary] is the library
         * that contains the reference to the name, used to implement library-level
         * privacy.
         */
        public abstract Element _internalLookupPrefixed(PrefixedIdentifier identifier, String prefix,
            String name, LibraryElement referencingLibrary);

        /**
         * Return `true` if the given [name] is a library-private name.
         */
        public static bool isPrivateName(String name) =>
            name != null && StringUtilities.startsWithChar(name, PRIVATE_NAME_PREFIX);
    }

    /**
     * The scope defined by the type parameters in an element that defines type
     * parameters.
     */
    public class TypeParameterScope : EnclosedScope
    {
        /**
         * Initialize a newly created scope, enclosed within the [enclosingScope],
         * that defines the type parameters from the given [element].
         */
        public TypeParameterScope(Scope enclosingScope, TypeParameterizedElement element)
          : base(enclosingScope)
        {
            if (element == null)
            {
                throw new ArgumentException("element cannot be null");
            }
            _defineTypeParameters(element);
        }

        /**
         * Define the type parameters declared by the [element].
         */
        void _defineTypeParameters(TypeParameterizedElement element)
        {
            foreach (TypeParameterElement typeParameter in element.typeParameters)
            {
                define(typeParameter);
            }
        }
    }
}
