using System;
using System.Collections.Generic;
using System.Text;

namespace Dart2CSharpTranspiler.Parser
{
    /**
     * The base class for all of the elements in the element model. Generally
     * speaking, the element model is a semantic model of the program that
     * represents things that are declared with a name and hence can be referenced
     * elsewhere in the code.
     *
     * There are two exceptions to the general case. First, there are elements in
     * the element model that are created for the convenience of various kinds of
     * analysis but that do not have any corresponding declaration within the source
     * code. Such elements are marked as being <i>synthetic</i>. Examples of
     * synthetic elements include
     * * default constructors in classes that do not define any explicit
     *   constructors,
     * * getters and setters that are induced by explicit field declarations,
     * * fields that are induced by explicit declarations of getters and setters,
     *   and
     * * functions representing the initialization expression for a variable.
     *
     * Second, there are elements in the element model that do not have a name.
     * These correspond to unnamed functions and exist in order to more accurately
     * represent the semantic structure of the program.
     *
     * Clients may not extend, implement or mix-in this class.
     */
    public interface Element : AnalysisTarget
    {
        /**
         * A comparator that can be used to sort elements by their name offset.
         * Elements with a smaller offset will be sorted to be before elements with a
         * larger name offset.
         */
        //public static readonly Comparator<Element> SORT_BY_OFFSET =
        //    (Element firstElement, Element secondElement) =>
        //        firstElement.nameOffset - secondElement.nameOffset;

        /**
         * Return the analysis context in which this element is defined.
         */
        AnalysisContext context { get; }

        /**
         * Return the display name of this element, or `null` if this element does not
         * have a name.
         *
         * In most cases the name and the display name are the same. Differences
         * though are cases such as setters where the name of some setter `set f(x)`
         * is `f=`, instead of `f`.
         */
        String displayName { get; }

        /**
         * Return the content of the documentation comment (including delimiters) for
         * this element, or `null` if this element does not or cannot have
         * documentation.
         */
        String documentationComment { get; }

        /**
         * Return the element that either physically or logically encloses this
         * element. This will be `null` if this element is a library because libraries
         * are the top-level elements in the model.
         */
        Element enclosingElement { get; }

        /**
         * Return `true` if this element has an annotation of the form
         * `@alwaysThrows`.
         */
        bool hasAlwaysThrows { get; }

        /**
         * Return `true` if this element has an annotation of the form `[Obsolete]`
         * or `[Obsolete]('..')`.
         */
        bool hasDeprecated { get; }

        /**
         * Return `true` if this element has an annotation of the form `@factory`.
         */
        bool hasFactory { get; }

        /**
         * Return `true` if this element has an annotation of the form `@isTest`.
         */
        bool hasIsTest { get; }

        /**
         * Return `true` if this element has an annotation of the form `@isTestGroup`.
         */
        bool hasIsTestGroup { get; }

        /**
         * Return `true` if this element has an annotation of the form `@JS(..)`.
         */
        bool hasJS { get; }

        /**
         * Return `true` if this element has an annotation of the form `@override`.
         */
        bool hasOverride { get; }

        /**
         * Return `true` if this element has an annotation of the form `@protected`.
         */
        bool hasProtected { get; }

        /**
         * Return `true` if this element has an annotation of the form '@required'.
         */
        bool hasRequired { get; }

        /**
         * Return `true` if this element has an annotation of the form '@sealed'.
         */
        bool hasSealed { get; }

        /**
         * Return `true` if this element has an annotation of the form
         * `@visibleForTemplate`.
         */
        bool hasVisibleForTemplate { get; }

        /**
         * Return `true` if this element has an annotation of the form
         * `@visibleForTesting`.
         */
        bool hasVisibleForTesting { get; }

        /**
         * The unique integer identifier of this element.
         */
        int id { get; }

        /**
         * Return `true` if this element has an annotation of the form
         * '@alwaysThrows'.
         */
        [Obsolete]
        bool isAlwaysThrows { get; }

        /**
         * Return `true` if this element has an annotation of the form '[Obsolete]'
         * or '[Obsolete]('..')'.
         */
        [Obsolete]
        bool isDeprecated { get; }

        /**
         * Return `true` if this element has an annotation of the form '@factory'.
         */
        [Obsolete]
        bool isFactory { get; }

        /**
         * Return `true` if this element has an annotation of the form '@JS(..)'.
         */
        [Obsolete]
        bool isJS { get; }

        /**
         * Return `true` if this element has an annotation of the form '@override'.
         */
        [Obsolete]
        bool isOverride { get; }

        /**
         * Return `true` if this element is private. Private elements are visible only
         * within the library in which they are declared.
         */
        bool isPrivate { get; }

        /**
         * Return `true` if this element has an annotation of the form '@protected'.
         */
        [Obsolete]
        bool isProtected { get; }

        /**
         * Return `true` if this element is public. Public elements are visible within
         * any library that imports the library in which they are declared.
         */
        bool isPublic { get; }

        /**
         * Return `true` if this element has an annotation of the form '@required'.
         */
        [Obsolete]
        bool isRequired { get; }

        /**
         * Return `true` if this element is synthetic. A synthetic element is an
         * element that is not represented in the source code explicitly, but is
         * implied by the source code, such as the default constructor for a class
         * that does not explicitly define any constructors.
         */
        bool isSynthetic { get; }

        /// Return `true` if this element has an annotation of the form
        /// '@visibleForTesting'.
        [Obsolete]
        bool isVisibleForTesting { get; }

        /**
         * Return the kind of element that this is.
         */
        ElementKind kind { get; }

        /**
         * Return the library that contains this element. This will be the element
         * itself if it is a library element. This will be `null` if this element is
         * an HTML file because HTML files are not contained in libraries.
         */
        LibraryElement library { get; }

        /**
         * Return an object representing the location of this element in the element
         * model. The object can be used to locate this element at a later time.
         */
        ElementLocation location { get; }

        /**
         * Return a list containing all of the metadata associated with this element.
         * The array will be empty if the element does not have any metadata or if the
         * library containing this element has not yet been resolved.
         */
        List<ElementAnnotation> metadata { get; }

        /**
         * Return the name of this element, or `null` if this element does not have a
         * name.
         */
        String name { get; }

        /**
         * Return the length of the name of this element in the file that contains the
         * declaration of this element, or `0` if this element does not have a name.
         */
        int nameLength { get; }

        /**
         * Return the offset of the name of this element in the file that contains the
         * declaration of this element, or `-1` if this element is synthetic, does not
         * have a name, or otherwise does not have an offset.
         */
        int nameOffset { get; }


        Source source { get; }

        /**
         * Return the resolved [CompilationUnit] that declares this element, or `null`
         * if this element is synthetic.
         *
         * This method is expensive, because resolved AST might have been already
         * evicted from cache, so parsing and resolving will be performed.
         */
        CompilationUnit unit { get; }

        /**
         * Use the given [visitor] to visit this element. Return the value returned by
         * the visitor as a result of visiting this element.
         */
        T accept<T>(ElementVisitor<T> visitor);

        /**
         * Return the documentation comment for this element as it appears in the
         * original source (complete with the beginning and ending delimiters), or
         * `null` if this element does not have a documentation comment associated
         * with it. This can be a long-running operation if the information needed to
         * access the comment is not cached.
         *
         * Throws [AnalysisException] if the documentation comment could not be
         * determined because the analysis could not be performed
         *
         * Deprecated.  Use [documentationComment] instead.
         */
        [Obsolete]
        String computeDocumentationComment();

        /**
         * Return the resolved [AstNode] node that declares this element, or `null` if
         * this element is synthetic or isn't contained in a compilation unit, such as
         * a [LibraryElement].
         *
         * This method is expensive, because resolved AST might be evicted from cache,
         * so parsing and resolving will be performed.
         *
         * <b>Note:</b> This method cannot be used in an async environment.
         */
        AstNode computeNode();

        /**
         * Return the most immediate ancestor of this element for which the
         * [predicate] returns `true`, or `null` if there is no such ancestor. Note
         * that this element will never be returned.
         */
        E getAncestor<E>(Predicate<Element> predicate) where E : Element;

        /**
         * Return a display name for the given element that includes the path to the
         * compilation unit in which the type is defined. If [shortName] is `null`
         * then [displayName] will be used as the name of this element. Otherwise
         * the provided name will be used.
         */
        // TODO(brianwilkerson) Make the parameter optional.
        String getExtendedDisplayName(String shortName);

        /**
         * Return `true` if this element, assuming that it is within scope, is
         * accessible to code in the given [library]. This is defined by the Dart
         * Language Specification in section 3.2:
         * <blockquote>
         * A declaration <i>m</i> is accessible to library <i>L</i> if <i>m</i> is
         * declared in <i>L</i> or if <i>m</i> is public.
         * </blockquote>
         */
        bool isAccessibleIn(LibraryElement library);

        /**
         * Use the given [visitor] to visit all of the children of this element. There
         * is no guarantee of the order in which the children will be visited.
         */
        void visitChildren(ElementVisitor visitor);
    }
}
