using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static Dart2CSharpTranspiler.Parser.DartLibrary;

//https://github.com/dart-lang/sdk/blob/master/pkg/analyzer/lib/src/summary/format.dart

namespace Dart2CSharpTranspiler.Parser
{
    // Copyright (c) 2015, the Dart project authors.  Please see the AUTHORS file
    // for details. All rights reserved. Use of this source code is governed by a
    // BSD-style license that can be found in the LICENSE file.
    //
    // This file has been automatically generated.  Please do not edit it manually.
    // To regenerate the file, use the script "pkg/analyzer/tool/generate_files".

    //    library analyzer.src.summary.format;

    //    import 'dart:convert' as convert;

    //import 'package:analyzer/src/summary/api_signature.dart' as api_sig;
    //import 'package:analyzer/src/summary/flat_buffers.dart' as fb;

    //import 'idl.dart' as idl;
    public class _EntityRefKindReader : fb.Reader<idl.EntityRefKind>
    {
        public _EntityRefKindReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.EntityRefKind read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.EntityRefKind.values.length
                ? idl.EntityRefKind.values[index]
                : idl.EntityRefKind.named;
        }
    }
    public class _IndexNameKindReader : fb.Reader<idl.IndexNameKind>
    {
        public _IndexNameKindReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.IndexNameKind read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.IndexNameKind.values.length
                ? idl.IndexNameKind.values[index]
                : idl.IndexNameKind.topLevel;
        }
    }
    public class _IndexRelationKindReader : fb.Reader<idl.IndexRelationKind>
    {
        public _IndexRelationKindReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.IndexRelationKind read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.IndexRelationKind.values.length
                ? idl.IndexRelationKind.values[index]
                : idl.IndexRelationKind.IS_ANCESTOR_OF;
        }
    }
    public class _IndexSyntheticElementKindReader
        : fb.Reader<idl.IndexSyntheticElementKind>
    {
        public _IndexSyntheticElementKindReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.IndexSyntheticElementKind read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.IndexSyntheticElementKind.values.length
                ? idl.IndexSyntheticElementKind.values[index]
                : idl.IndexSyntheticElementKind.notSynthetic;
        }
    }
    public class _ReferenceKindReader : fb.Reader<idl.ReferenceKind>
    {
        public _ReferenceKindReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.ReferenceKind read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.ReferenceKind.values.length
                ? idl.ReferenceKind.values[index]
                : idl.ReferenceKind.classOrEnum;
        }
    }
    public class _TopLevelInferenceErrorKindReader
        : fb.Reader<idl.TopLevelInferenceErrorKind>
    {
        public _TopLevelInferenceErrorKindReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.TopLevelInferenceErrorKind read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.TopLevelInferenceErrorKind.values.length
                ? idl.TopLevelInferenceErrorKind.values[index]
                : idl.TopLevelInferenceErrorKind.assignment;
        }
    }
    public class _TypedefStyleReader : fb.Reader<idl.TypedefStyle>
    {
        public _TypedefStyleReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.TypedefStyle read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.TypedefStyle.values.length
                ? idl.TypedefStyle.values[index]
                : idl.TypedefStyle.functionType;
        }
    }
    public class _UnlinkedConstructorInitializerKindReader
        : fb.Reader<idl.UnlinkedConstructorInitializerKind>
    {
        public _UnlinkedConstructorInitializerKindReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.UnlinkedConstructorInitializerKind read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.UnlinkedConstructorInitializerKind.values.length
                ? idl.UnlinkedConstructorInitializerKind.values[index]
                : idl.UnlinkedConstructorInitializerKind.field;
        }
    }
    public class _UnlinkedExecutableKindReader
        : fb.Reader<idl.UnlinkedExecutableKind>
    {
        public _UnlinkedExecutableKindReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.UnlinkedExecutableKind read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.UnlinkedExecutableKind.values.length
                ? idl.UnlinkedExecutableKind.values[index]
                : idl.UnlinkedExecutableKind.functionOrMethod;
        }
    }
    public class _UnlinkedExprAssignOperatorReader
        : fb.Reader<idl.UnlinkedExprAssignOperator>
    {
        public _UnlinkedExprAssignOperatorReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.UnlinkedExprAssignOperator read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.UnlinkedExprAssignOperator.values.length
                ? idl.UnlinkedExprAssignOperator.values[index]
                : idl.UnlinkedExprAssignOperator.assign;
        }
    }
    public class _UnlinkedExprOperationReader
        : fb.Reader<idl.UnlinkedExprOperation>
    {
        public _UnlinkedExprOperationReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.UnlinkedExprOperation read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.UnlinkedExprOperation.values.length
                ? idl.UnlinkedExprOperation.values[index]
                : idl.UnlinkedExprOperation.pushInt;
        }
    }
    public class _UnlinkedParamKindReader : fb.Reader<idl.UnlinkedParamKind>
    {
        public _UnlinkedParamKindReader()
        {
        }

        ////@override
        public int size
        {
            get => 1;
        }

        ////@override
        idl.UnlinkedParamKind read(fb.BufferContext bc, int offset)
        {
            int index = new fb.Uint8Reader().read(bc, offset);
            return index < idl.UnlinkedParamKind.values.length
                ? idl.UnlinkedParamKind.values[index]
                : idl.UnlinkedParamKind.required;
        }
    }
    public class AnalysisDriverExceptionContextBuilder : Object


        with _AnalysisDriverExceptionContextMixin
    : idl.AnalysisDriverExceptionContext
    {
        String _exception;
        List<AnalysisDriverExceptionFileBuilder> _files;
        String _path;
        String _stackTrace;

        ////@override
        public String exception
        {
            get => _exception ??= "";
        }

        /**
         * The exception string.
         */
        void setexception(String value)
        {
            this._exception = value;
        }

        ////@override
        List<AnalysisDriverExceptionFileBuilder> get files =>
            _files ??= new Dictionary<AnalysisDriverExceptionFileBuilder>{} };

    /**
     * The state of files when the exception happened.
     */
    void setfiles(List<AnalysisDriverExceptionFileBuilder> value)
    {
        this._files = value;
    }

    ////@override
    public String path
    {
        get => _path ??= "";
    }

    /**
     * The path of the file being analyzed when the exception happened.
     */
    void setpath(String value)
    {
        this._path = value;
    }

    ////@override
    public String stackTrace
    {
        get => _stackTrace ??= "";
    }

    /**
     * The exception stack trace string.
     */
    void setstackTrace(String value)
    {
        this._stackTrace = value;
    }

    AnalysisDriverExceptionContextBuilder(
            {
        String exception,
       List< AnalysisDriverExceptionFileBuilder > files,
      String path,
      String stackTrace)
      : _exception = exception,
        _files = files,
        _path = path,
        _stackTrace = stackTrace;

        /**
         * Flush [informative] data recursively.
         */
        void flushInformative()
        {
            _files?.forEach((b) => b.flushInformative());
        }

        /**
         * Accumulate non-[informative] data into [signature].
         */
        void collectApiSignature(api_sig.ApiSignature signature)
        {
            signature.addString(this._path ?? "");
            signature.addString(this._exception ?? "");
            signature.addString(this._stackTrace ?? "");
            if (this._files == null)
            {
                signature.addInt(0);
            }
            else
            {
                signature.addInt(this._files.length);
                foreach (var x in this._files)
                {
                    x?.collectApiSignature(signature);
                }
            }
        }

        List<int> toBuffer()
        {
            fb.Builder fbBuilder = new fb.Builder();
            return fbBuilder.finish(finish(fbBuilder), "ADEC");
        }

        fb.Offset finish(fb.Builder fbBuilder)
        {
            fb.Offset offset_exception;
            fb.Offset offset_files;
            fb.Offset offset_path;
            fb.Offset offset_stackTrace;
            if (_exception != null)
            {
                offset_exception = fbBuilder.writeString(_exception);
            }
            if (!(_files == null || _files.isEmpty))
            {
                offset_files =
                    fbBuilder.writeList(_files.map((b) => b.finish(fbBuilder)).toList());
            }
            if (_path != null)
            {
                offset_path = fbBuilder.writeString(_path);
            }
            if (_stackTrace != null)
            {
                offset_stackTrace = fbBuilder.writeString(_stackTrace);
            }
            fbBuilder.startTable();
            if (offset_exception != null)
            {
                fbBuilder.addOffset(1, offset_exception);
            }
            if (offset_files != null)
            {
                fbBuilder.addOffset(3, offset_files);
            }
            if (offset_path != null)
            {
                fbBuilder.addOffset(0, offset_path);
            }
            if (offset_stackTrace != null)
            {
                fbBuilder.addOffset(2, offset_stackTrace);
            }
            return fbBuilder.endTable();
        }
    }

    idl.AnalysisDriverExceptionContext readAnalysisDriverExceptionContext(
List<int> buffer)
    {
        fb.BufferContext rootRef = new fb.BufferContext.fromBytes(buffer);
        return new _AnalysisDriverExceptionContextReader().read(rootRef, 0);
    }
    public class _AnalysisDriverExceptionContextReader
        : fb.TableReader<_AnalysisDriverExceptionContextImpl>
    {
        public _AnalysisDriverExceptionContextReader();

        ////@override
        _AnalysisDriverExceptionContextImpl createObject(
          fb.BufferContext bc, int offset) =>
      new _AnalysisDriverExceptionContextImpl(bc, offset);
    }
    public class _AnalysisDriverExceptionContextImpl : Object
    
        with _AnalysisDriverExceptionContextMixin
    : idl.AnalysisDriverExceptionContext
    {
        public readonly fb.BufferContext _bc;
        public readonly int _bcOffset;

        _AnalysisDriverExceptionContextImpl(this._bc, this._bcOffset);

        String _exception;
        List<idl.AnalysisDriverExceptionFile> _files;
        String _path;
        String _stackTrace;

        ////@override
        String get exception {
        _exception ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 1, "");
        return _exception;
    }

    ////@override
    List<idl.AnalysisDriverExceptionFile> get files {
        _files ??= new fb.ListReader<idl.AnalysisDriverExceptionFile>(
public _AnalysisDriverExceptionFileReader())
        .vTableGet(
            _bc, _bcOffset, 3, new List<idl.AnalysisDriverExceptionFile>{);
        return _files;
    }

////@override
String get path {
        _path ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _path;
    }

    ////@override
    String get stackTrace {
        _stackTrace ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 2, "");
        return _stackTrace;
    }
    }
public abstract class _AnalysisDriverExceptionContextMixin
    : idl.AnalysisDriverExceptionContext
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (exception != "") _result["exception"] = exception;
        if (files.isNotEmpty)
            _result["files"] = files.map((_value) => _value.toJson()).toList();
        if (path != "") _result["path"] = path;
        if (stackTrace != "") _result["stackTrace"] = stackTrace;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "exception": exception,
        "files": files,
        "path": path,
        "stackTrace": stackTrace,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class AnalysisDriverExceptionFileBuilder : Object
    with _AnalysisDriverExceptionFileMixin
    : idl.AnalysisDriverExceptionFile
{
    String _content;
    String _path;

    ////@override
    public String content
    {
        get => _content ??= "";
    }

    /**
     * The content of the file.
     */
    void setcontent(String value)
    {
        this._content = value;
    }

    ////@override
    public String path
    {
        get => _path ??= "";
    }

    /**
     * The path of the file.
     */
    void setpath(String value)
    {
        this._path = value;
    }

    AnalysisDriverExceptionFileBuilder(String content, String path)
      : _content = content,
        _path = path;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative() { }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._path ?? "");
        signature.addString(this._content ?? "");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_content;
        fb.Offset offset_path;
        if (_content != null)
        {
            offset_content = fbBuilder.writeString(_content);
        }
        if (_path != null)
        {
            offset_path = fbBuilder.writeString(_path);
        }
        fbBuilder.startTable();
        if (offset_content != null)
        {
            fbBuilder.addOffset(1, offset_content);
        }
        if (offset_path != null)
        {
            fbBuilder.addOffset(0, offset_path);
        }
        return fbBuilder.endTable();
    }
}
public class _AnalysisDriverExceptionFileReader
    : fb.TableReader<_AnalysisDriverExceptionFileImpl>
{
    public _AnalysisDriverExceptionFileReader();

    ////@override
    _AnalysisDriverExceptionFileImpl createObject(
          fb.BufferContext bc, int offset) =>
      new _AnalysisDriverExceptionFileImpl(bc, offset);
}
public class _AnalysisDriverExceptionFileImpl : Object
    with _AnalysisDriverExceptionFileMixin
    : idl.AnalysisDriverExceptionFile
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _AnalysisDriverExceptionFileImpl(this._bc, this._bcOffset);

    String _content;
    String _path;

    ////@override
    String get content {
        _content ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 1, "");
        return _content;
    }

////@override
String get path {
        _path ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _path;
    }
    }
public abstract class _AnalysisDriverExceptionFileMixin
    : idl.AnalysisDriverExceptionFile
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (content != "") _result["content"] = content;
        if (path != "") _result["path"] = path;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "content": content,
        "path": path,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class AnalysisDriverResolvedUnitBuilder : Object
    with _AnalysisDriverResolvedUnitMixin
    : idl.AnalysisDriverResolvedUnit
{
    List<AnalysisDriverUnitErrorBuilder> _errors;
    AnalysisDriverUnitIndexBuilder _index;

    ////@override
    List<AnalysisDriverUnitErrorBuilder> get errors =>
        _errors ??= new Dictionary<AnalysisDriverUnitErrorBuilder>{};

/**
 * The full list of analysis errors, both syntactic and semantic.
 */
void seterrors(List<AnalysisDriverUnitErrorBuilder> value)
{
    this._errors = value;
}

////@override
public AnalysisDriverUnitIndexBuilder index
{
    get => _index;
}

/**
 * The index of the unit.
 */
void setindex(AnalysisDriverUnitIndexBuilder value)
{
    this._index = value;
}

AnalysisDriverResolvedUnitBuilder(
        {
    List<AnalysisDriverUnitErrorBuilder> errors,
   AnalysisDriverUnitIndexBuilder index)
      : _errors = errors,
        _index = index;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _errors?.forEach((b) => b.flushInformative());
        _index?.flushInformative();
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._errors == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._errors.length);
            foreach (var x in this._errors)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._index != null);
        this._index?.collectApiSignature(signature);
    }

    List<int> toBuffer()
    {
        fb.Builder fbBuilder = new fb.Builder();
        return fbBuilder.finish(finish(fbBuilder), "ADRU");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_errors;
        fb.Offset offset_index;
        if (!(_errors == null || _errors.isEmpty))
        {
            offset_errors =
                fbBuilder.writeList(_errors.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_index != null)
        {
            offset_index = _index.finish(fbBuilder);
        }
        fbBuilder.startTable();
        if (offset_errors != null)
        {
            fbBuilder.addOffset(0, offset_errors);
        }
        if (offset_index != null)
        {
            fbBuilder.addOffset(1, offset_index);
        }
        return fbBuilder.endTable();
    }
}

idl.AnalysisDriverResolvedUnit readAnalysisDriverResolvedUnit(
List<int> buffer)
{
    fb.BufferContext rootRef = new fb.BufferContext.fromBytes(buffer);
    return new _AnalysisDriverResolvedUnitReader().read(rootRef, 0);
}
public class _AnalysisDriverResolvedUnitReader
    : fb.TableReader<_AnalysisDriverResolvedUnitImpl>
{
    public _AnalysisDriverResolvedUnitReader();

    ////@override
    _AnalysisDriverResolvedUnitImpl createObject(
          fb.BufferContext bc, int offset) =>
      new _AnalysisDriverResolvedUnitImpl(bc, offset);
}
public class _AnalysisDriverResolvedUnitImpl : Object
    with _AnalysisDriverResolvedUnitMixin
    : idl.AnalysisDriverResolvedUnit
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _AnalysisDriverResolvedUnitImpl(this._bc, this._bcOffset);

    List<idl.AnalysisDriverUnitError> _errors;
    idl.AnalysisDriverUnitIndex _index;

    ////@override
    List<idl.AnalysisDriverUnitError> get errors {
        _errors ??= new fb.ListReader<idl.AnalysisDriverUnitError>(
public _AnalysisDriverUnitErrorReader())
        .vTableGet(_bc, _bcOffset, 0, new List<idl.AnalysisDriverUnitError>{);
        return _errors;
    }

////@override
idl.AnalysisDriverUnitIndex get index {
        _index ??= new _AnalysisDriverUnitIndexReader()
          .vTableGet(_bc, _bcOffset, 1, null);
        return _index;
    }
    }
public abstract class _AnalysisDriverResolvedUnitMixin
    : idl.AnalysisDriverResolvedUnit
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (errors.isNotEmpty)
            _result["errors"] = errors.map((_value) => _value.toJson()).toList();
        if (index != null) _result["index"] = index.toJson();
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "errors": errors,
        "index": index,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class AnalysisDriverSubtypeBuilder : Object
    with _AnalysisDriverSubtypeMixin
    : idl.AnalysisDriverSubtype
{
    List<int> _members;
    int _name;

    ////@override
    public List<int> members
    {
        get => _members ??= new Dictionary<int> { };
    }

    /**
     * The names of defined instance members.
     * They are indexes into [AnalysisDriverUnitError.strings] list.
     * The list is sorted in ascending order.
     */
    void setmembers(List<int> value)
    {
        assert(value == null || value.every((e) => e >= 0));
        this._members = value;
    }

    ////@override
    public int name
    {
        get => _name ??= 0;
    }

    /**
     * The name of the class.
     * It is an index into [AnalysisDriverUnitError.strings] list.
     */
    void setname(int value)
    {
        assert(value == null || value >= 0);
        this._name = value;
    }

    AnalysisDriverSubtypeBuilder(List<int> members, int name)
      : _members = members,
        _name = name;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative() { }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addInt(this._name ?? 0);
        if (this._members == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._members.length);
            foreach (var x in this._members)
            {
                signature.addInt(x);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_members;
        if (!(_members == null || _members.isEmpty))
        {
            offset_members = fbBuilder.writeListUint32(_members);
        }
        fbBuilder.startTable();
        if (offset_members != null)
        {
            fbBuilder.addOffset(1, offset_members);
        }
        if (_name != null && _name != 0)
        {
            fbBuilder.addUint32(0, _name);
        }
        return fbBuilder.endTable();
    }
}
public class _AnalysisDriverSubtypeReader
    : fb.TableReader<_AnalysisDriverSubtypeImpl>
{
    public _AnalysisDriverSubtypeReader();

    ////@override
    _AnalysisDriverSubtypeImpl createObject(fb.BufferContext bc, int offset) =>
      new _AnalysisDriverSubtypeImpl(bc, offset);
}
public class _AnalysisDriverSubtypeImpl : Object
    with _AnalysisDriverSubtypeMixin
    : idl.AnalysisDriverSubtype
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _AnalysisDriverSubtypeImpl(this._bc, this._bcOffset);

    List<int> _members;
    int _name;

    ////@override
    List<int> get members {
        _members ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 1, new List<int>{);
        return _members;
    }

////@override
int get name {
        _name ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _name;
    }
    }
public abstract class _AnalysisDriverSubtypeMixin
    : idl.AnalysisDriverSubtype
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (members.isNotEmpty) _result["members"] = members;
        if (name != 0) _result["name"] = name;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "members": members,
        "name": name,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class AnalysisDriverUnitErrorBuilder : Object
    with _AnalysisDriverUnitErrorMixin
    : idl.AnalysisDriverUnitError
{
    String _correction;
    int _length;
    String _message;
    int _offset;
    String _uniqueName;

    ////@override
    public String correction
    {
        get => _correction ??= "";
    }

    /**
     * The optional correction hint for the error.
     */
    void setcorrection(String value)
    {
        this._correction = value;
    }

    ////@override
    public int length
    {
        get => _length ??= 0;
    }

    /**
     * The length of the error in the file.
     */
    void setlength(int value)
    {
        assert(value == null || value >= 0);
        this._length = value;
    }

    ////@override
    public String message
    {
        get => _message ??= "";
    }

    /**
     * The message of the error.
     */
    void setmessage(String value)
    {
        this._message = value;
    }

    ////@override
    public int offset
    {
        get => _offset ??= 0;
    }

    /**
     * The offset from the beginning of the file.
     */
    void setoffset(int value)
    {
        assert(value == null || value >= 0);
        this._offset = value;
    }

    ////@override
    public String uniqueName
    {
        get => _uniqueName ??= "";
    }

    /**
     * The unique name of the error code.
     */
    void setuniqueName(String value)
    {
        this._uniqueName = value;
    }

    AnalysisDriverUnitErrorBuilder(
        {
        String correction,
      int length,
      String message,
      int offset,
      String uniqueName)
      : _correction = correction,
        _length = length,
        _message = message,
        _offset = offset,
        _uniqueName = uniqueName;

        /**
         * Flush [informative] data recursively.
         */
        void flushInformative() { }

        /**
         * Accumulate non-[informative] data into [signature].
         */
        void collectApiSignature(api_sig.ApiSignature signature)
        {
            signature.addInt(this._offset ?? 0);
            signature.addInt(this._length ?? 0);
            signature.addString(this._uniqueName ?? "");
            signature.addString(this._message ?? "");
            signature.addString(this._correction ?? "");
        }

        fb.Offset finish(fb.Builder fbBuilder)
        {
            fb.Offset offset_correction;
            fb.Offset offset_message;
            fb.Offset offset_uniqueName;
            if (_correction != null)
            {
                offset_correction = fbBuilder.writeString(_correction);
            }
            if (_message != null)
            {
                offset_message = fbBuilder.writeString(_message);
            }
            if (_uniqueName != null)
            {
                offset_uniqueName = fbBuilder.writeString(_uniqueName);
            }
            fbBuilder.startTable();
            if (offset_correction != null)
            {
                fbBuilder.addOffset(4, offset_correction);
            }
            if (_length != null && _length != 0)
            {
                fbBuilder.addUint32(1, _length);
            }
            if (offset_message != null)
            {
                fbBuilder.addOffset(3, offset_message);
            }
            if (_offset != null && _offset != 0)
            {
                fbBuilder.addUint32(0, _offset);
            }
            if (offset_uniqueName != null)
            {
                fbBuilder.addOffset(2, offset_uniqueName);
            }
            return fbBuilder.endTable();
        }
    }
    public class _AnalysisDriverUnitErrorReader
        : fb.TableReader<_AnalysisDriverUnitErrorImpl>
    {
        public _AnalysisDriverUnitErrorReader();

        ////@override
        _AnalysisDriverUnitErrorImpl createObject(fb.BufferContext bc, int offset) =>
          new _AnalysisDriverUnitErrorImpl(bc, offset);
    }
    public class _AnalysisDriverUnitErrorImpl : Object
    
        with _AnalysisDriverUnitErrorMixin
    : idl.AnalysisDriverUnitError
    {
        public readonly fb.BufferContext _bc;
        public readonly int _bcOffset;

        _AnalysisDriverUnitErrorImpl(this._bc, this._bcOffset);

        String _correction;
        int _length;
        String _message;
        int _offset;
        String _uniqueName;

        ////@override
        String get correction {
        _correction ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 4, "");
        return _correction;
    }

    ////@override
    int get length {
        _length ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _length;
    }

////@override
String get message {
        _message ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 3, "");
        return _message;
    }

    ////@override
    int get offset {
        _offset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _offset;
    }

    ////@override
    String get uniqueName {
        _uniqueName ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 2, "");
        return _uniqueName;
    }
    }
public abstract class _AnalysisDriverUnitErrorMixin
    : idl.AnalysisDriverUnitError
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (correction != "") _result["correction"] = correction;
        if (length != 0) _result["length"] = length;
        if (message != "") _result["message"] = message;
        if (offset != 0) _result["offset"] = offset;
        if (uniqueName != "") _result["uniqueName"] = uniqueName;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "correction": correction,
        "length": length,
        "message": message,
        "offset": offset,
        "uniqueName": uniqueName,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class AnalysisDriverUnitIndexBuilder : Object
    with _AnalysisDriverUnitIndexMixin
    : idl.AnalysisDriverUnitIndex
{
    List<idl.IndexSyntheticElementKind> _elementKinds;
    List<int> _elementNameClassMemberIds;
    List<int> _elementNameParameterIds;
    List<int> _elementNameUnitMemberIds;
    List<int> _elementUnits;
    int _nullStringId;
    List<String> _strings;
    List<AnalysisDriverSubtypeBuilder> _subtypes;
    List<int> _supertypes;
    List<int> _unitLibraryUris;
    List<int> _unitUnitUris;
    List<bool> _usedElementIsQualifiedFlags;
    List<idl.IndexRelationKind> _usedElementKinds;
    List<int> _usedElementLengths;
    List<int> _usedElementOffsets;
    List<int> _usedElements;
    List<bool> _usedNameIsQualifiedFlags;
    List<idl.IndexRelationKind> _usedNameKinds;
    List<int> _usedNameOffsets;
    List<int> _usedNames;

    ////@override
    List<idl.IndexSyntheticElementKind> get elementKinds =>
        _elementKinds ??= new Dictionary<idl.IndexSyntheticElementKind>{};

/**
 * Each item of this list corresponds to a unique referenced element.  It is
 * the kind of the synthetic element.
 */
void setelementKinds(List<idl.IndexSyntheticElementKind> value)
{
    this._elementKinds = value;
}

////@override
List<int> get elementNameClassMemberIds =>
        _elementNameClassMemberIds ??= new List<int>{};

    /**
     * Each item of this list corresponds to a unique referenced element.  It is
     * the identifier of the class member element name, or `null` if the element
     * is a top-level element.  The list is sorted in ascending order, so that the
     * client can quickly check whether an element is referenced in this index.
     */
    void setelementNameClassMemberIds(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._elementNameClassMemberIds = value;
}

////@override
public List<int> elementNameParameterIds
{
    get => _elementNameParameterIds ??= new Dictionary<int> { };
}

/**
 * Each item of this list corresponds to a unique referenced element.  It is
 * the identifier of the named parameter name, or `null` if the element is not
 * a named parameter.  The list is sorted in ascending order, so that the
 * client can quickly check whether an element is referenced in this index.
 */
void setelementNameParameterIds(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._elementNameParameterIds = value;
}

////@override
List<int> get elementNameUnitMemberIds =>
        _elementNameUnitMemberIds ??= new Dictionary<int>{};

    /**
     * Each item of this list corresponds to a unique referenced element.  It is
     * the identifier of the top-level element name, or `null` if the element is
     * the unit.  The list is sorted in ascending order, so that the client can
     * quickly check whether an element is referenced in this index.
     */
    void setelementNameUnitMemberIds(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._elementNameUnitMemberIds = value;
}

////@override
public List<int> elementUnits
{
    get => _elementUnits ??= new Dictionary<int> { };
}

/**
 * Each item of this list corresponds to a unique referenced element.  It is
 * the index into [unitLibraryUris] and [unitUnitUris] for the library
 * specific unit where the element is declared.
 */
void setelementUnits(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._elementUnits = value;
}

////@override
public int nullStringId
{
    get => _nullStringId ??= 0;
}

/**
 * Identifier of the null string in [strings].
 */
void setnullStringId(int value)
{
    assert(value == null || value >= 0);
    this._nullStringId = value;
}

////@override
public List<String> strings
{
    get => _strings ??= new List<String> { };
}

/**
 * List of unique element strings used in this index.  The list is sorted in
 * ascending order, so that the client can quickly check the presence of a
 * string in this index.
 */
void setstrings(List<String> value)
{
    this._strings = value;
}

////@override
List<AnalysisDriverSubtypeBuilder> get subtypes =>
        _subtypes ??= new Dictionary<AnalysisDriverSubtypeBuilder>{};

    /**
     * The list of classes declared in the unit.
     */
    void setsubtypes(List<AnalysisDriverSubtypeBuilder> value)
{
    this._subtypes = value;
}

////@override
public List<int> supertypes
{
    get => _supertypes ??= new List<int> { };
}

/**
 * The identifiers of supertypes of elements at corresponding indexes
 * in [subtypes].  They are indexes into [strings] list. The list is sorted
 * in ascending order.  There might be more than one element with the same
 * value if there is more than one subtype of this supertype.
 */
void setsupertypes(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._supertypes = value;
}

////@override
public List<int> unitLibraryUris
{
    get => _unitLibraryUris ??= new List<int> { };
}

/**
 * Each item of this list corresponds to the library URI of a unique library
 * specific unit referenced in the index.  It is an index into [strings] list.
 */
void setunitLibraryUris(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._unitLibraryUris = value;
}

////@override
public List<int> unitUnitUris
{
    get => _unitUnitUris ??= new List<int> { };
}

/**
 * Each item of this list corresponds to the unit URI of a unique library
 * specific unit referenced in the index.  It is an index into [strings] list.
 */
void setunitUnitUris(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._unitUnitUris = value;
}

////@override
List<bool> get usedElementIsQualifiedFlags =>
        _usedElementIsQualifiedFlags ??= new List<bool>{};

    /**
     * Each item of this list is the `true` if the corresponding element usage
     * is qualified with some prefix.
     */
    void setusedElementIsQualifiedFlags(List<bool> value)
{
    this._usedElementIsQualifiedFlags = value;
}

////@override
List<idl.IndexRelationKind> get usedElementKinds =>
        _usedElementKinds ??= new List<idl.IndexRelationKind>{};

    /**
     * Each item of this list is the kind of the element usage.
     */
    void setusedElementKinds(List<idl.IndexRelationKind> value)
{
    this._usedElementKinds = value;
}

////@override
public List<int> usedElementLengths
{
    get => _usedElementLengths ??= new List<int> { };
}

/**
 * Each item of this list is the length of the element usage.
 */
void setusedElementLengths(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._usedElementLengths = value;
}

////@override
public List<int> usedElementOffsets
{
    get => _usedElementOffsets ??= new List<int> { };
}

/**
 * Each item of this list is the offset of the element usage relative to the
 * beginning of the file.
 */
void setusedElementOffsets(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._usedElementOffsets = value;
}

////@override
public List<int> usedElements
{
    get => _usedElements ??= new List<int> { };
}

/**
 * Each item of this list is the index into [elementUnits],
 * [elementNameUnitMemberIds], [elementNameClassMemberIds] and
 * [elementNameParameterIds].  The list is sorted in ascending order, so
 * that the client can quickly find element references in this index.
 */
void setusedElements(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._usedElements = value;
}

////@override
List<bool> get usedNameIsQualifiedFlags =>
        _usedNameIsQualifiedFlags ??= new Dictionary<bool>{};

    /**
     * Each item of this list is the `true` if the corresponding name usage
     * is qualified with some prefix.
     */
    void setusedNameIsQualifiedFlags(List<bool> value)
{
    this._usedNameIsQualifiedFlags = value;
}

////@override
List<idl.IndexRelationKind> get usedNameKinds =>
        _usedNameKinds ??= new List<idl.IndexRelationKind>{};

    /**
     * Each item of this list is the kind of the name usage.
     */
    void setusedNameKinds(List<idl.IndexRelationKind> value)
{
    this._usedNameKinds = value;
}

////@override
public List<int> usedNameOffsets
{
    get => _usedNameOffsets ??= new List<int> { };
}

/**
 * Each item of this list is the offset of the name usage relative to the
 * beginning of the file.
 */
void setusedNameOffsets(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._usedNameOffsets = value;
}

////@override
public List<int> usedNames
{
    get => _usedNames ??= new List<int> { };
}

/**
 * Each item of this list is the index into [strings] for a used name.  The
 * list is sorted in ascending order, so that the client can quickly find
 * whether a name is used in this index.
 */
void setusedNames(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._usedNames = value;
}

AnalysisDriverUnitIndexBuilder(
        {
    List<idl.IndexSyntheticElementKind> elementKinds,
   List< int > elementNameClassMemberIds,
      List<int> elementNameParameterIds,
      List< int > elementNameUnitMemberIds,
      List<int> elementUnits,
      int nullStringId,
      List< String > strings,
      List<AnalysisDriverSubtypeBuilder> subtypes,
      List< int > supertypes,
      List<int> unitLibraryUris,
      List< int > unitUnitUris,
      List<bool> usedElementIsQualifiedFlags,
      List< idl.IndexRelationKind > usedElementKinds,
      List<int> usedElementLengths,
      List< int > usedElementOffsets,
      List<int> usedElements,
      List< bool > usedNameIsQualifiedFlags,
      List<idl.IndexRelationKind> usedNameKinds,
      List< int > usedNameOffsets,
      List<int> usedNames)
      : _elementKinds = elementKinds,
        _elementNameClassMemberIds = elementNameClassMemberIds,
        _elementNameParameterIds = elementNameParameterIds,
        _elementNameUnitMemberIds = elementNameUnitMemberIds,
        _elementUnits = elementUnits,
        _nullStringId = nullStringId,
        _strings = strings,
        _subtypes = subtypes,
        _supertypes = supertypes,
        _unitLibraryUris = unitLibraryUris,
        _unitUnitUris = unitUnitUris,
        _usedElementIsQualifiedFlags = usedElementIsQualifiedFlags,
        _usedElementKinds = usedElementKinds,
        _usedElementLengths = usedElementLengths,
        _usedElementOffsets = usedElementOffsets,
        _usedElements = usedElements,
        _usedNameIsQualifiedFlags = usedNameIsQualifiedFlags,
        _usedNameKinds = usedNameKinds,
        _usedNameOffsets = usedNameOffsets,
        _usedNames = usedNames;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _subtypes?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._strings == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._strings.length);
            foreach (var x in this._strings)
            {
                signature.addString(x);
            }
        }
        signature.addInt(this._nullStringId ?? 0);
        if (this._unitLibraryUris == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._unitLibraryUris.length);
            foreach (var x in this._unitLibraryUris)
            {
                signature.addInt(x);
            }
        }
        if (this._unitUnitUris == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._unitUnitUris.length);
            foreach (var x in this._unitUnitUris)
            {
                signature.addInt(x);
            }
        }
        if (this._elementKinds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._elementKinds.length);
            foreach (var x in this._elementKinds)
            {
                signature.addInt(x.index);
            }
        }
        if (this._elementUnits == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._elementUnits.length);
            foreach (var x in this._elementUnits)
            {
                signature.addInt(x);
            }
        }
        if (this._elementNameUnitMemberIds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._elementNameUnitMemberIds.length);
            foreach (var x in this._elementNameUnitMemberIds)
            {
                signature.addInt(x);
            }
        }
        if (this._elementNameClassMemberIds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._elementNameClassMemberIds.length);
            foreach (var x in this._elementNameClassMemberIds)
            {
                signature.addInt(x);
            }
        }
        if (this._elementNameParameterIds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._elementNameParameterIds.length);
            foreach (var x in this._elementNameParameterIds)
            {
                signature.addInt(x);
            }
        }
        if (this._usedElements == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedElements.length);
            foreach (var x in this._usedElements)
            {
                signature.addInt(x);
            }
        }
        if (this._usedElementKinds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedElementKinds.length);
            foreach (var x in this._usedElementKinds)
            {
                signature.addInt(x.index);
            }
        }
        if (this._usedElementOffsets == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedElementOffsets.length);
            foreach (var x in this._usedElementOffsets)
            {
                signature.addInt(x);
            }
        }
        if (this._usedElementLengths == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedElementLengths.length);
            foreach (var x in this._usedElementLengths)
            {
                signature.addInt(x);
            }
        }
        if (this._usedElementIsQualifiedFlags == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedElementIsQualifiedFlags.length);
            foreach (var x in this._usedElementIsQualifiedFlags)
            {
                signature.addBool(x);
            }
        }
        if (this._usedNames == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedNames.length);
            foreach (var x in this._usedNames)
            {
                signature.addInt(x);
            }
        }
        if (this._usedNameKinds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedNameKinds.length);
            foreach (var x in this._usedNameKinds)
            {
                signature.addInt(x.index);
            }
        }
        if (this._usedNameOffsets == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedNameOffsets.length);
            foreach (var x in this._usedNameOffsets)
            {
                signature.addInt(x);
            }
        }
        if (this._usedNameIsQualifiedFlags == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedNameIsQualifiedFlags.length);
            foreach (var x in this._usedNameIsQualifiedFlags)
            {
                signature.addBool(x);
            }
        }
        if (this._supertypes == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._supertypes.length);
            foreach (var x in this._supertypes)
            {
                signature.addInt(x);
            }
        }
        if (this._subtypes == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._subtypes.length);
            foreach (var x in this._subtypes)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    List<int> toBuffer()
    {
        fb.Builder fbBuilder = new fb.Builder();
        return fbBuilder.finish(finish(fbBuilder), "ADUI");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_elementKinds;
        fb.Offset offset_elementNameClassMemberIds;
        fb.Offset offset_elementNameParameterIds;
        fb.Offset offset_elementNameUnitMemberIds;
        fb.Offset offset_elementUnits;
        fb.Offset offset_strings;
        fb.Offset offset_subtypes;
        fb.Offset offset_supertypes;
        fb.Offset offset_unitLibraryUris;
        fb.Offset offset_unitUnitUris;
        fb.Offset offset_usedElementIsQualifiedFlags;
        fb.Offset offset_usedElementKinds;
        fb.Offset offset_usedElementLengths;
        fb.Offset offset_usedElementOffsets;
        fb.Offset offset_usedElements;
        fb.Offset offset_usedNameIsQualifiedFlags;
        fb.Offset offset_usedNameKinds;
        fb.Offset offset_usedNameOffsets;
        fb.Offset offset_usedNames;
        if (!(_elementKinds == null || _elementKinds.isEmpty))
        {
            offset_elementKinds =
                fbBuilder.writeListUint8(_elementKinds.map((b) => b.index).toList());
        }
        if (!(_elementNameClassMemberIds == null ||
            _elementNameClassMemberIds.isEmpty))
        {
            offset_elementNameClassMemberIds =
                fbBuilder.writeListUint32(_elementNameClassMemberIds);
        }
        if (!(_elementNameParameterIds == null ||
            _elementNameParameterIds.isEmpty))
        {
            offset_elementNameParameterIds =
                fbBuilder.writeListUint32(_elementNameParameterIds);
        }
        if (!(_elementNameUnitMemberIds == null ||
            _elementNameUnitMemberIds.isEmpty))
        {
            offset_elementNameUnitMemberIds =
                fbBuilder.writeListUint32(_elementNameUnitMemberIds);
        }
        if (!(_elementUnits == null || _elementUnits.isEmpty))
        {
            offset_elementUnits = fbBuilder.writeListUint32(_elementUnits);
        }
        if (!(_strings == null || _strings.isEmpty))
        {
            offset_strings = fbBuilder
                .writeList(_strings.map((b) => fbBuilder.writeString(b)).toList());
        }
        if (!(_subtypes == null || _subtypes.isEmpty))
        {
            offset_subtypes = fbBuilder
                .writeList(_subtypes.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_supertypes == null || _supertypes.isEmpty))
        {
            offset_supertypes = fbBuilder.writeListUint32(_supertypes);
        }
        if (!(_unitLibraryUris == null || _unitLibraryUris.isEmpty))
        {
            offset_unitLibraryUris = fbBuilder.writeListUint32(_unitLibraryUris);
        }
        if (!(_unitUnitUris == null || _unitUnitUris.isEmpty))
        {
            offset_unitUnitUris = fbBuilder.writeListUint32(_unitUnitUris);
        }
        if (!(_usedElementIsQualifiedFlags == null ||
            _usedElementIsQualifiedFlags.isEmpty))
        {
            offset_usedElementIsQualifiedFlags =
                fbBuilder.writeListBool(_usedElementIsQualifiedFlags);
        }
        if (!(_usedElementKinds == null || _usedElementKinds.isEmpty))
        {
            offset_usedElementKinds = fbBuilder
                .writeListUint8(_usedElementKinds.map((b) => b.index).toList());
        }
        if (!(_usedElementLengths == null || _usedElementLengths.isEmpty))
        {
            offset_usedElementLengths =
                fbBuilder.writeListUint32(_usedElementLengths);
        }
        if (!(_usedElementOffsets == null || _usedElementOffsets.isEmpty))
        {
            offset_usedElementOffsets =
                fbBuilder.writeListUint32(_usedElementOffsets);
        }
        if (!(_usedElements == null || _usedElements.isEmpty))
        {
            offset_usedElements = fbBuilder.writeListUint32(_usedElements);
        }
        if (!(_usedNameIsQualifiedFlags == null ||
            _usedNameIsQualifiedFlags.isEmpty))
        {
            offset_usedNameIsQualifiedFlags =
                fbBuilder.writeListBool(_usedNameIsQualifiedFlags);
        }
        if (!(_usedNameKinds == null || _usedNameKinds.isEmpty))
        {
            offset_usedNameKinds =
                fbBuilder.writeListUint8(_usedNameKinds.map((b) => b.index).toList());
        }
        if (!(_usedNameOffsets == null || _usedNameOffsets.isEmpty))
        {
            offset_usedNameOffsets = fbBuilder.writeListUint32(_usedNameOffsets);
        }
        if (!(_usedNames == null || _usedNames.isEmpty))
        {
            offset_usedNames = fbBuilder.writeListUint32(_usedNames);
        }
        fbBuilder.startTable();
        if (offset_elementKinds != null)
        {
            fbBuilder.addOffset(4, offset_elementKinds);
        }
        if (offset_elementNameClassMemberIds != null)
        {
            fbBuilder.addOffset(7, offset_elementNameClassMemberIds);
        }
        if (offset_elementNameParameterIds != null)
        {
            fbBuilder.addOffset(8, offset_elementNameParameterIds);
        }
        if (offset_elementNameUnitMemberIds != null)
        {
            fbBuilder.addOffset(6, offset_elementNameUnitMemberIds);
        }
        if (offset_elementUnits != null)
        {
            fbBuilder.addOffset(5, offset_elementUnits);
        }
        if (_nullStringId != null && _nullStringId != 0)
        {
            fbBuilder.addUint32(1, _nullStringId);
        }
        if (offset_strings != null)
        {
            fbBuilder.addOffset(0, offset_strings);
        }
        if (offset_subtypes != null)
        {
            fbBuilder.addOffset(19, offset_subtypes);
        }
        if (offset_supertypes != null)
        {
            fbBuilder.addOffset(18, offset_supertypes);
        }
        if (offset_unitLibraryUris != null)
        {
            fbBuilder.addOffset(2, offset_unitLibraryUris);
        }
        if (offset_unitUnitUris != null)
        {
            fbBuilder.addOffset(3, offset_unitUnitUris);
        }
        if (offset_usedElementIsQualifiedFlags != null)
        {
            fbBuilder.addOffset(13, offset_usedElementIsQualifiedFlags);
        }
        if (offset_usedElementKinds != null)
        {
            fbBuilder.addOffset(10, offset_usedElementKinds);
        }
        if (offset_usedElementLengths != null)
        {
            fbBuilder.addOffset(12, offset_usedElementLengths);
        }
        if (offset_usedElementOffsets != null)
        {
            fbBuilder.addOffset(11, offset_usedElementOffsets);
        }
        if (offset_usedElements != null)
        {
            fbBuilder.addOffset(9, offset_usedElements);
        }
        if (offset_usedNameIsQualifiedFlags != null)
        {
            fbBuilder.addOffset(17, offset_usedNameIsQualifiedFlags);
        }
        if (offset_usedNameKinds != null)
        {
            fbBuilder.addOffset(15, offset_usedNameKinds);
        }
        if (offset_usedNameOffsets != null)
        {
            fbBuilder.addOffset(16, offset_usedNameOffsets);
        }
        if (offset_usedNames != null)
        {
            fbBuilder.addOffset(14, offset_usedNames);
        }
        return fbBuilder.endTable();
    }
}

idl.AnalysisDriverUnitIndex readAnalysisDriverUnitIndex(List<int> buffer)
{
    fb.BufferContext rootRef = new fb.BufferContext.fromBytes(buffer);
    return new _AnalysisDriverUnitIndexReader().read(rootRef, 0);
}
public class _AnalysisDriverUnitIndexReader
    : fb.TableReader<_AnalysisDriverUnitIndexImpl>
{
    public _AnalysisDriverUnitIndexReader();

    ////@override
    _AnalysisDriverUnitIndexImpl createObject(fb.BufferContext bc, int offset) =>
      new _AnalysisDriverUnitIndexImpl(bc, offset);
}
public class _AnalysisDriverUnitIndexImpl : Object
    with _AnalysisDriverUnitIndexMixin
    : idl.AnalysisDriverUnitIndex
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _AnalysisDriverUnitIndexImpl(this._bc, this._bcOffset);

    List<idl.IndexSyntheticElementKind> _elementKinds;
    List<int> _elementNameClassMemberIds;
    List<int> _elementNameParameterIds;
    List<int> _elementNameUnitMemberIds;
    List<int> _elementUnits;
    int _nullStringId;
    List<String> _strings;
    List<idl.AnalysisDriverSubtype> _subtypes;
    List<int> _supertypes;
    List<int> _unitLibraryUris;
    List<int> _unitUnitUris;
    List<bool> _usedElementIsQualifiedFlags;
    List<idl.IndexRelationKind> _usedElementKinds;
    List<int> _usedElementLengths;
    List<int> _usedElementOffsets;
    List<int> _usedElements;
    List<bool> _usedNameIsQualifiedFlags;
    List<idl.IndexRelationKind> _usedNameKinds;
    List<int> _usedNameOffsets;
    List<int> _usedNames;

    ////@override
    List<idl.IndexSyntheticElementKind> get elementKinds {
        _elementKinds ??= new fb.ListReader<idl.IndexSyntheticElementKind>(
public _IndexSyntheticElementKindReader())
        .vTableGet(_bc, _bcOffset, 4, new List<idl.IndexSyntheticElementKind>{);
        return _elementKinds;
    }

////@override
List<int> get elementNameClassMemberIds {
        _elementNameClassMemberIds ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 7, new List<int>{);
        return _elementNameClassMemberIds;
    }

    ////@override
    List<int> get elementNameParameterIds {
        _elementNameParameterIds ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 8, new List<int>{);
        return _elementNameParameterIds;
    }

    ////@override
    List<int> get elementNameUnitMemberIds {
        _elementNameUnitMemberIds ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 6, new List<int>{);
        return _elementNameUnitMemberIds;
    }

    ////@override
    List<int> get elementUnits {
        _elementUnits ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 5, new List<int>{);
        return _elementUnits;
    }

    ////@override
    int get nullStringId {
        _nullStringId ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _nullStringId;
    }

    ////@override
    List<String> get strings {
        _strings ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 0, new List<String>{);
        return _strings;
    }

    ////@override
    List<idl.AnalysisDriverSubtype> get subtypes {
        _subtypes ??= new fb.ListReader<idl.AnalysisDriverSubtype>(
public _AnalysisDriverSubtypeReader())
        .vTableGet(_bc, _bcOffset, 19, new List<idl.AnalysisDriverSubtype>{);
        return _subtypes;
    }

    ////@override
    List<int> get supertypes {
        _supertypes ??= new fb.Uint32ListReader()
          .vTableGet(_bc, _bcOffset, 18, new List<int>{);
        return _supertypes;
    }

    ////@override
    List<int> get unitLibraryUris {
        _unitLibraryUris ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 2, new List<int>{);
        return _unitLibraryUris;
    }

    ////@override
    List<int> get unitUnitUris {
        _unitUnitUris ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 3, new List<int>{);
        return _unitUnitUris;
    }

    ////@override
    List<bool> get usedElementIsQualifiedFlags {
        _usedElementIsQualifiedFlags ??=
public fb.BoolListReader().vTableGet(_bc, _bcOffset, 13, new List<bool>{);
        return _usedElementIsQualifiedFlags;
    }

    ////@override
    List<idl.IndexRelationKind> get usedElementKinds {
        _usedElementKinds ??= new fb.ListReader<idl.IndexRelationKind>(
public _IndexRelationKindReader())
        .vTableGet(_bc, _bcOffset, 10, new List<idl.IndexRelationKind>{);
        return _usedElementKinds;
    }

    ////@override
    List<int> get usedElementLengths {
        _usedElementLengths ??= new fb.Uint32ListReader()
          .vTableGet(_bc, _bcOffset, 12, new List<int>{);
        return _usedElementLengths;
    }

    ////@override
    List<int> get usedElementOffsets {
        _usedElementOffsets ??= new fb.Uint32ListReader()
          .vTableGet(_bc, _bcOffset, 11, new List<int>{);
        return _usedElementOffsets;
    }

    ////@override
    List<int> get usedElements {
        _usedElements ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 9, new List<int>{);
        return _usedElements;
    }

    ////@override
    List<bool> get usedNameIsQualifiedFlags {
        _usedNameIsQualifiedFlags ??=
public fb.BoolListReader().vTableGet(_bc, _bcOffset, 17, new List<bool>{);
        return _usedNameIsQualifiedFlags;
    }

    ////@override
    List<idl.IndexRelationKind> get usedNameKinds {
        _usedNameKinds ??= new fb.ListReader<idl.IndexRelationKind>(
public _IndexRelationKindReader())
        .vTableGet(_bc, _bcOffset, 15, new List<idl.IndexRelationKind>{);
        return _usedNameKinds;
    }

    ////@override
    List<int> get usedNameOffsets {
        _usedNameOffsets ??= new fb.Uint32ListReader()
          .vTableGet(_bc, _bcOffset, 16, new List<int>{);
        return _usedNameOffsets;
    }

    ////@override
    List<int> get usedNames {
        _usedNames ??= new fb.Uint32ListReader()
          .vTableGet(_bc, _bcOffset, 14, new List<int>{);
        return _usedNames;
    }
    }
public abstract class _AnalysisDriverUnitIndexMixin
    : idl.AnalysisDriverUnitIndex
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (elementKinds.isNotEmpty)
            _result["elementKinds"] = elementKinds
                .map((_value) => _value.toString().split(".")[1])
                .toList();
        if (elementNameClassMemberIds.isNotEmpty)
            _result["elementNameClassMemberIds"] = elementNameClassMemberIds;
        if (elementNameParameterIds.isNotEmpty)
            _result["elementNameParameterIds"] = elementNameParameterIds;
        if (elementNameUnitMemberIds.isNotEmpty)
            _result["elementNameUnitMemberIds"] = elementNameUnitMemberIds;
        if (elementUnits.isNotEmpty) _result["elementUnits"] = elementUnits;
        if (nullStringId != 0) _result["nullStringId"] = nullStringId;
        if (strings.isNotEmpty) _result["strings"] = strings;
        if (subtypes.isNotEmpty)
            _result["subtypes"] = subtypes.map((_value) => _value.toJson()).toList();
        if (supertypes.isNotEmpty) _result["supertypes"] = supertypes;
        if (unitLibraryUris.isNotEmpty)
            _result["unitLibraryUris"] = unitLibraryUris;
        if (unitUnitUris.isNotEmpty) _result["unitUnitUris"] = unitUnitUris;
        if (usedElementIsQualifiedFlags.isNotEmpty)
            _result["usedElementIsQualifiedFlags"] = usedElementIsQualifiedFlags;
        if (usedElementKinds.isNotEmpty)
            _result["usedElementKinds"] = usedElementKinds
                .map((_value) => _value.toString().split(".")[1])
                .toList();
        if (usedElementLengths.isNotEmpty)
            _result["usedElementLengths"] = usedElementLengths;
        if (usedElementOffsets.isNotEmpty)
            _result["usedElementOffsets"] = usedElementOffsets;
        if (usedElements.isNotEmpty) _result["usedElements"] = usedElements;
        if (usedNameIsQualifiedFlags.isNotEmpty)
            _result["usedNameIsQualifiedFlags"] = usedNameIsQualifiedFlags;
        if (usedNameKinds.isNotEmpty)
            _result["usedNameKinds"] = usedNameKinds
                .map((_value) => _value.toString().split(".")[1])
                .toList();
        if (usedNameOffsets.isNotEmpty)
            _result["usedNameOffsets"] = usedNameOffsets;
        if (usedNames.isNotEmpty) _result["usedNames"] = usedNames;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "elementKinds": elementKinds,
        "elementNameClassMemberIds": elementNameClassMemberIds,
        "elementNameParameterIds": elementNameParameterIds,
        "elementNameUnitMemberIds": elementNameUnitMemberIds,
        "elementUnits": elementUnits,
        "nullStringId": nullStringId,
        "strings": strings,
        "subtypes": subtypes,
        "supertypes": supertypes,
        "unitLibraryUris": unitLibraryUris,
        "unitUnitUris": unitUnitUris,
        "usedElementIsQualifiedFlags": usedElementIsQualifiedFlags,
        "usedElementKinds": usedElementKinds,
        "usedElementLengths": usedElementLengths,
        "usedElementOffsets": usedElementOffsets,
        "usedElements": usedElements,
        "usedNameIsQualifiedFlags": usedNameIsQualifiedFlags,
        "usedNameKinds": usedNameKinds,
        "usedNameOffsets": usedNameOffsets,
        "usedNames": usedNames,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class AnalysisDriverUnlinkedUnitBuilder : Object
    with _AnalysisDriverUnlinkedUnitMixin
    : idl.AnalysisDriverUnlinkedUnit
{
    List<String> _definedClassMemberNames;
    List<String> _definedTopLevelNames;
    List<String> _referencedNames;
    List<String> _subtypedNames;
    UnlinkedUnitBuilder _unit;

    ////@override
    List<String> get definedClassMemberNames =>
        _definedClassMemberNames ??= new Dictionary<String>{};

/**
 * List of class member names defined by the unit.
 */
void setdefinedClassMemberNames(List<String> value)
{
    this._definedClassMemberNames = value;
}

////@override
public List<String> definedTopLevelNames
{
    get => _definedTopLevelNames ??= new List<String> { };
}

/**
 * List of top-level names defined by the unit.
 */
void setdefinedTopLevelNames(List<String> value)
{
    this._definedTopLevelNames = value;
}

////@override
public List<String> referencedNames
{
    get => _referencedNames ??= new List<String> { };
}

/**
 * List of external names referenced by the unit.
 */
void setreferencedNames(List<String> value)
{
    this._referencedNames = value;
}

////@override
public List<String> subtypedNames
{
    get => _subtypedNames ??= new List<String> { };
}

/**
 * List of names which are used in `extends`, `with` or `implements` clauses
 * in the file. Import prefixes and type arguments are not included.
 */
void setsubtypedNames(List<String> value)
{
    this._subtypedNames = value;
}

////@override
public UnlinkedUnitBuilder unit
{
    get => _unit;
}

/**
 * Unlinked information for the unit.
 */
void setunit(UnlinkedUnitBuilder value)
{
    this._unit = value;
}

AnalysisDriverUnlinkedUnitBuilder(
        {
    List<String> definedClassMemberNames,
   List< String > definedTopLevelNames,
      List<String> referencedNames,
      List< String > subtypedNames,
      UnlinkedUnitBuilder unit)
      : _definedClassMemberNames = definedClassMemberNames,
        _definedTopLevelNames = definedTopLevelNames,
        _referencedNames = referencedNames,
        _subtypedNames = subtypedNames,
        _unit = unit;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _unit?.flushInformative();
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._referencedNames == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._referencedNames.length);
            foreach (var x in this._referencedNames)
            {
                signature.addString(x);
            }
        }
        signature.addBool(this._unit != null);
        this._unit?.collectApiSignature(signature);
        if (this._definedTopLevelNames == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._definedTopLevelNames.length);
            foreach (var x in this._definedTopLevelNames)
            {
                signature.addString(x);
            }
        }
        if (this._definedClassMemberNames == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._definedClassMemberNames.length);
            foreach (var x in this._definedClassMemberNames)
            {
                signature.addString(x);
            }
        }
        if (this._subtypedNames == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._subtypedNames.length);
            foreach (var x in this._subtypedNames)
            {
                signature.addString(x);
            }
        }
    }

    List<int> toBuffer()
    {
        fb.Builder fbBuilder = new fb.Builder();
        return fbBuilder.finish(finish(fbBuilder), "ADUU");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_definedClassMemberNames;
        fb.Offset offset_definedTopLevelNames;
        fb.Offset offset_referencedNames;
        fb.Offset offset_subtypedNames;
        fb.Offset offset_unit;
        if (!(_definedClassMemberNames == null ||
            _definedClassMemberNames.isEmpty))
        {
            offset_definedClassMemberNames = fbBuilder.writeList(
                _definedClassMemberNames
                    .map((b) => fbBuilder.writeString(b))
                    .toList());
        }
        if (!(_definedTopLevelNames == null || _definedTopLevelNames.isEmpty))
        {
            offset_definedTopLevelNames = fbBuilder.writeList(
                _definedTopLevelNames.map((b) => fbBuilder.writeString(b)).toList());
        }
        if (!(_referencedNames == null || _referencedNames.isEmpty))
        {
            offset_referencedNames = fbBuilder.writeList(
                _referencedNames.map((b) => fbBuilder.writeString(b)).toList());
        }
        if (!(_subtypedNames == null || _subtypedNames.isEmpty))
        {
            offset_subtypedNames = fbBuilder.writeList(
                _subtypedNames.map((b) => fbBuilder.writeString(b)).toList());
        }
        if (_unit != null)
        {
            offset_unit = _unit.finish(fbBuilder);
        }
        fbBuilder.startTable();
        if (offset_definedClassMemberNames != null)
        {
            fbBuilder.addOffset(3, offset_definedClassMemberNames);
        }
        if (offset_definedTopLevelNames != null)
        {
            fbBuilder.addOffset(2, offset_definedTopLevelNames);
        }
        if (offset_referencedNames != null)
        {
            fbBuilder.addOffset(0, offset_referencedNames);
        }
        if (offset_subtypedNames != null)
        {
            fbBuilder.addOffset(4, offset_subtypedNames);
        }
        if (offset_unit != null)
        {
            fbBuilder.addOffset(1, offset_unit);
        }
        return fbBuilder.endTable();
    }
}

idl.AnalysisDriverUnlinkedUnit readAnalysisDriverUnlinkedUnit(
List<int> buffer)
{
    fb.BufferContext rootRef = new fb.BufferContext.fromBytes(buffer);
    return new _AnalysisDriverUnlinkedUnitReader().read(rootRef, 0);
}
public class _AnalysisDriverUnlinkedUnitReader
    : fb.TableReader<_AnalysisDriverUnlinkedUnitImpl>
{
    public _AnalysisDriverUnlinkedUnitReader();

    ////@override
    _AnalysisDriverUnlinkedUnitImpl createObject(
          fb.BufferContext bc, int offset) =>
      new _AnalysisDriverUnlinkedUnitImpl(bc, offset);
}
public class _AnalysisDriverUnlinkedUnitImpl : Object
    with _AnalysisDriverUnlinkedUnitMixin
    : idl.AnalysisDriverUnlinkedUnit
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _AnalysisDriverUnlinkedUnitImpl(this._bc, this._bcOffset);

    List<String> _definedClassMemberNames;
    List<String> _definedTopLevelNames;
    List<String> _referencedNames;
    List<String> _subtypedNames;
    idl.UnlinkedUnit _unit;

    ////@override
    List<String> get definedClassMemberNames {
        _definedClassMemberNames ??=
public fb.ListReader<String>(const fb.StringReader())
            .vTableGet(_bc, _bcOffset, 3, new List<String>{);
        return _definedClassMemberNames;
    }

////@override
List<String> get definedTopLevelNames {
        _definedTopLevelNames ??=
public fb.ListReader<String>(const fb.StringReader())
            .vTableGet(_bc, _bcOffset, 2, new List<String>{);
        return _definedTopLevelNames;
    }

    ////@override
    List<String> get referencedNames {
        _referencedNames ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 0, new List<String>{);
        return _referencedNames;
    }

    ////@override
    List<String> get subtypedNames {
        _subtypedNames ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 4, new List<String>{);
        return _subtypedNames;
    }

    ////@override
    idl.UnlinkedUnit get unit {
        _unit ??= new _UnlinkedUnitReader().vTableGet(_bc, _bcOffset, 1, null);
        return _unit;
    }
    }
public abstract class _AnalysisDriverUnlinkedUnitMixin
    : idl.AnalysisDriverUnlinkedUnit
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (definedClassMemberNames.isNotEmpty)
            _result["definedClassMemberNames"] = definedClassMemberNames;
        if (definedTopLevelNames.isNotEmpty)
            _result["definedTopLevelNames"] = definedTopLevelNames;
        if (referencedNames.isNotEmpty)
            _result["referencedNames"] = referencedNames;
        if (subtypedNames.isNotEmpty) _result["subtypedNames"] = subtypedNames;
        if (unit != null) _result["unit"] = unit.toJson();
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "definedClassMemberNames": definedClassMemberNames,
        "definedTopLevelNames": definedTopLevelNames,
        "referencedNames": referencedNames,
        "subtypedNames": subtypedNames,
        "unit": unit,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class CodeRangeBuilder : Object
    with _CodeRangeMixin
    : idl.CodeRange
{
    int _length;
    int _offset;

    ////@override
    public int length
    {
        get => _length ??= 0;
    }

    /**
     * Length of the element code.
     */
    void setlength(int value)
    {
        assert(value == null || value >= 0);
        this._length = value;
    }

    ////@override
    public int offset
    {
        get => _offset ??= 0;
    }

    /**
     * Offset of the element code relative to the beginning of the file.
     */
    void setoffset(int value)
    {
        assert(value == null || value >= 0);
        this._offset = value;
    }

    CodeRangeBuilder(int length, int offset)
      : _length = length,
        _offset = offset;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative() { }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addInt(this._offset ?? 0);
        signature.addInt(this._length ?? 0);
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fbBuilder.startTable();
        if (_length != null && _length != 0)
        {
            fbBuilder.addUint32(1, _length);
        }
        if (_offset != null && _offset != 0)
        {
            fbBuilder.addUint32(0, _offset);
        }
        return fbBuilder.endTable();
    }
}
public class _CodeRangeReader : fb.TableReader<_CodeRangeImpl>
{
    public _CodeRangeReader();

    ////@override
    _CodeRangeImpl createObject(fb.BufferContext bc, int offset) =>
      new _CodeRangeImpl(bc, offset);
}
public class _CodeRangeImpl : Object
    with _CodeRangeMixin
    : idl.CodeRange
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _CodeRangeImpl(this._bc, this._bcOffset);

    int _length;
    int _offset;

    ////@override
    int get length {
        _length ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _length;
    }

////@override
int get offset {
        _offset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _offset;
    }
    }
public abstract class _CodeRangeMixin : idl.CodeRange
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (length != 0) _result["length"] = length;
        if (offset != 0) _result["offset"] = offset;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "length": length,
        "offset": offset,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class EntityRefBuilder : Object
    with _EntityRefMixin
    : idl.EntityRef
{
    idl.EntityRefKind _entityKind;
    List<int> _implicitFunctionTypeIndices;
    int _paramReference;
    int _reference;
    int _refinedSlot;
    int _slot;
    List<UnlinkedParamBuilder> _syntheticParams;
    EntityRefBuilder _syntheticReturnType;
    List<EntityRefBuilder> _typeArguments;
    List<UnlinkedTypeParamBuilder> _typeParameters;

    ////@override
    public idl.EntityRefKind entityKind
    {
        get => _entityKind ??= idl.EntityRefKind.named;
    }

    /**
     * The kind of entity being represented.
     */
    void setentityKind(idl.EntityRefKind value)
    {
        this._entityKind = value;
    }

    ////@override
    List<int> get implicitFunctionTypeIndices =>
        _implicitFunctionTypeIndices ??= new Dictionary<int>{};

/**
 * Notice: This will be deprecated. However, its not deprecated yet, as we're
 * keeping it for backwards compatibilty, and marking it deprecated makes it
 * unreadable.
 *
 * TODO(mfairhurst) mark this deprecated, and remove its logic.
 *
 * If this is a reference to a function type implicitly defined by a
 * function-typed parameter, a list of zero-based indices indicating the path
 * from the entity referred to by [reference] to the appropriate type
 * parameter.  Otherwise the empty list.
 *
 * If there are N indices in this list, then the entity being referred to is
 * the function type implicitly defined by a function-typed parameter of a
 * function-typed parameter, to N levels of nesting.  The first index in the
 * list refers to the outermost level of nesting; for example if [reference]
 * refers to the entity defined by:
 *
 *     void f(x, void g(y, z, int h(String w))) { ... }
 *
 * Then to refer to the function type implicitly defined by parameter `h`
 * (which is parameter 2 of parameter 1 of `f`), then
 * [implicitFunctionTypeIndices] should be [1, 2].
 *
 * Note that if the entity being referred to is a generic method inside a
 * generic class, then the type arguments in [typeArguments] are applied
 * first to the class and then to the method.
 */
void setimplicitFunctionTypeIndices(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._implicitFunctionTypeIndices = value;
}

////@override
public int paramReference
{
    get => _paramReference ??= 0;
}

/**
 * If this is a reference to a type parameter, one-based index into the list
 * of [UnlinkedTypeParam]s currently in effect.  Indexing is done using De
 * Bruijn index conventions; that is, innermost parameters come first, and
 * if a class or method has multiple parameters, they are indexed from right
 * to left.  So for instance, if the enclosing declaration is
 *
 *     class C<T,U> {
 *       m<V,W> {
 *         ...
 *       }
 *     }
 *
 * Then [paramReference] values of 1, 2, 3, and 4 represent W, V, U, and T,
 * respectively.
 *
 * If the type being referred to is not a type parameter, [paramReference] is
 * zero.
 */
void setparamReference(int value)
{
    assert(value == null || value >= 0);
    this._paramReference = value;
}

////@override
public int reference
{
    get => _reference ??= 0;
}

/**
 * Index into [UnlinkedUnit.references] for the entity being referred to, or
 * zero if this is a reference to a type parameter.
 */
void setreference(int value)
{
    assert(value == null || value >= 0);
    this._reference = value;
}

////@override
public int refinedSlot
{
    get => _refinedSlot ??= 0;
}

/**
 * If this [EntityRef] appears in a syntactic context where its type arguments
 * might need to be inferred by a method other than instantiate-to-bounds,
 * and [typeArguments] is empty, a slot id (which is unique within the
 * compilation unit).  If an entry appears in [LinkedUnit.types] whose [slot]
 * matches this value, that entry will contain the complete inferred type.
 *
 * This is called `refinedSlot` to clarify that if it points to an inferred
 * type, it points to a type that is a "refinement" of this one (one in which
 * some type arguments have been inferred).
 */
void setrefinedSlot(int value)
{
    assert(value == null || value >= 0);
    this._refinedSlot = value;
}

////@override
public int slot
{
    get => _slot ??= 0;
}

/**
 * If this [EntityRef] is contained within [LinkedUnit.types], slot id (which
 * is unique within the compilation unit) identifying the target of type
 * propagation or type inference with which this [EntityRef] is associated.
 *
 * Otherwise zero.
 */
void setslot(int value)
{
    assert(value == null || value >= 0);
    this._slot = value;
}

////@override
List<UnlinkedParamBuilder> get syntheticParams =>
        _syntheticParams ??= new Dictionary<UnlinkedParamBuilder>{};

    /**
     * If this [EntityRef] is a reference to a function type whose
     * [FunctionElement] is not in any library (e.g. a function type that was
     * synthesized by a LUB computation), the function parameters.  Otherwise
     * empty.
     */
    void setsyntheticParams(List<UnlinkedParamBuilder> value)
{
    this._syntheticParams = value;
}

////@override
public EntityRefBuilder syntheticReturnType
{
    get => _syntheticReturnType;
}

/**
 * If this [EntityRef] is a reference to a function type whose
 * [FunctionElement] is not in any library (e.g. a function type that was
 * synthesized by a LUB computation), the return type of the function.
 * Otherwise `null`.
 */
void setsyntheticReturnType(EntityRefBuilder value)
{
    this._syntheticReturnType = value;
}

////@override
List<EntityRefBuilder> get typeArguments =>
        _typeArguments ??= new Dictionary<EntityRefBuilder>{};

    /**
     * If this is an instantiation of a generic type or generic executable, the
     * type arguments used to instantiate it (if any).
     */
    void settypeArguments(List<EntityRefBuilder> value)
{
    this._typeArguments = value;
}

////@override
List<UnlinkedTypeParamBuilder> get typeParameters =>
        _typeParameters ??= new Dictionary<UnlinkedTypeParamBuilder>{};

    /**
     * If this is a function type, the type parameters defined for the function
     * type (if any).
     */
    void settypeParameters(List<UnlinkedTypeParamBuilder> value)
{
    this._typeParameters = value;
}

EntityRefBuilder(
        {
    idl.EntityRefKind entityKind,
   List< int > implicitFunctionTypeIndices,
      int paramReference,
      int reference,
      int refinedSlot,
      int slot,
      List< UnlinkedParamBuilder > syntheticParams,
      EntityRefBuilder syntheticReturnType,
      List< EntityRefBuilder > typeArguments,
      List<UnlinkedTypeParamBuilder> typeParameters)
      : _entityKind = entityKind,
        _implicitFunctionTypeIndices = implicitFunctionTypeIndices,
        _paramReference = paramReference,
        _reference = reference,
        _refinedSlot = refinedSlot,
        _slot = slot,
        _syntheticParams = syntheticParams,
        _syntheticReturnType = syntheticReturnType,
        _typeArguments = typeArguments,
        _typeParameters = typeParameters;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _syntheticParams?.forEach((b) => b.flushInformative());
        _syntheticReturnType?.flushInformative();
        _typeArguments?.forEach((b) => b.flushInformative());
        _typeParameters?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addInt(this._reference ?? 0);
        if (this._typeArguments == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._typeArguments.length);
            foreach (var x in this._typeArguments)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addInt(this._slot ?? 0);
        signature.addInt(this._paramReference ?? 0);
        if (this._implicitFunctionTypeIndices == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._implicitFunctionTypeIndices.length);
            foreach (var x in this._implicitFunctionTypeIndices)
            {
                signature.addInt(x);
            }
        }
        signature.addBool(this._syntheticReturnType != null);
        this._syntheticReturnType?.collectApiSignature(signature);
        if (this._syntheticParams == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._syntheticParams.length);
            foreach (var x in this._syntheticParams)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._typeParameters == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._typeParameters.length);
            foreach (var x in this._typeParameters)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addInt(this._entityKind == null ? 0 : this._entityKind.index);
        signature.addInt(this._refinedSlot ?? 0);
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_implicitFunctionTypeIndices;
        fb.Offset offset_syntheticParams;
        fb.Offset offset_syntheticReturnType;
        fb.Offset offset_typeArguments;
        fb.Offset offset_typeParameters;
        if (!(_implicitFunctionTypeIndices == null ||
            _implicitFunctionTypeIndices.isEmpty))
        {
            offset_implicitFunctionTypeIndices =
                fbBuilder.writeListUint32(_implicitFunctionTypeIndices);
        }
        if (!(_syntheticParams == null || _syntheticParams.isEmpty))
        {
            offset_syntheticParams = fbBuilder
                .writeList(_syntheticParams.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_syntheticReturnType != null)
        {
            offset_syntheticReturnType = _syntheticReturnType.finish(fbBuilder);
        }
        if (!(_typeArguments == null || _typeArguments.isEmpty))
        {
            offset_typeArguments = fbBuilder
                .writeList(_typeArguments.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_typeParameters == null || _typeParameters.isEmpty))
        {
            offset_typeParameters = fbBuilder
                .writeList(_typeParameters.map((b) => b.finish(fbBuilder)).toList());
        }
        fbBuilder.startTable();
        if (_entityKind != null && _entityKind != idl.EntityRefKind.named)
        {
            fbBuilder.addUint8(8, _entityKind.index);
        }
        if (offset_implicitFunctionTypeIndices != null)
        {
            fbBuilder.addOffset(4, offset_implicitFunctionTypeIndices);
        }
        if (_paramReference != null && _paramReference != 0)
        {
            fbBuilder.addUint32(3, _paramReference);
        }
        if (_reference != null && _reference != 0)
        {
            fbBuilder.addUint32(0, _reference);
        }
        if (_refinedSlot != null && _refinedSlot != 0)
        {
            fbBuilder.addUint32(9, _refinedSlot);
        }
        if (_slot != null && _slot != 0)
        {
            fbBuilder.addUint32(2, _slot);
        }
        if (offset_syntheticParams != null)
        {
            fbBuilder.addOffset(6, offset_syntheticParams);
        }
        if (offset_syntheticReturnType != null)
        {
            fbBuilder.addOffset(5, offset_syntheticReturnType);
        }
        if (offset_typeArguments != null)
        {
            fbBuilder.addOffset(1, offset_typeArguments);
        }
        if (offset_typeParameters != null)
        {
            fbBuilder.addOffset(7, offset_typeParameters);
        }
        return fbBuilder.endTable();
    }
}
public class _EntityRefReader : fb.TableReader<_EntityRefImpl>
{
    public _EntityRefReader();

    ////@override
    _EntityRefImpl createObject(fb.BufferContext bc, int offset) =>
      new _EntityRefImpl(bc, offset);
}
public class _EntityRefImpl : Object
    with _EntityRefMixin
    : idl.EntityRef
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _EntityRefImpl(this._bc, this._bcOffset);

    idl.EntityRefKind _entityKind;
    List<int> _implicitFunctionTypeIndices;
    int _paramReference;
    int _reference;
    int _refinedSlot;
    int _slot;
    List<idl.UnlinkedParam> _syntheticParams;
    idl.EntityRef _syntheticReturnType;
    List<idl.EntityRef> _typeArguments;
    List<idl.UnlinkedTypeParam> _typeParameters;

    ////@override
    idl.EntityRefKind get entityKind {
        _entityKind ??= new _EntityRefKindReader()
          .vTableGet(_bc, _bcOffset, 8, idl.EntityRefKind.named);
        return _entityKind;
    }

////@override
List<int> get implicitFunctionTypeIndices {
        _implicitFunctionTypeIndices ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 4, new List<int>{);
        return _implicitFunctionTypeIndices;
    }

    ////@override
    int get paramReference {
        _paramReference ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 3, 0);
        return _paramReference;
    }

    ////@override
    int get reference {
        _reference ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _reference;
    }

    ////@override
    int get refinedSlot {
        _refinedSlot ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 9, 0);
        return _refinedSlot;
    }

    ////@override
    int get slot {
        _slot ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 2, 0);
        return _slot;
    }

    ////@override
    List<idl.UnlinkedParam> get syntheticParams {
        _syntheticParams ??=
public fb.ListReader<idl.UnlinkedParam>(const _UnlinkedParamReader())
            .vTableGet(_bc, _bcOffset, 6, new List<idl.UnlinkedParam>{);
        return _syntheticParams;
    }

    ////@override
    idl.EntityRef get syntheticReturnType {
        _syntheticReturnType ??=
public _EntityRefReader().vTableGet(_bc, _bcOffset, 5, null);
        return _syntheticReturnType;
    }

    ////@override
    List<idl.EntityRef> get typeArguments {
        _typeArguments ??=
public fb.ListReader<idl.EntityRef>(const _EntityRefReader())
            .vTableGet(_bc, _bcOffset, 1, new List<idl.EntityRef>{);
        return _typeArguments;
    }

    ////@override
    List<idl.UnlinkedTypeParam> get typeParameters {
        _typeParameters ??= new fb.ListReader<idl.UnlinkedTypeParam>(
public _UnlinkedTypeParamReader())
        .vTableGet(_bc, _bcOffset, 7, new List<idl.UnlinkedTypeParam>{);
        return _typeParameters;
    }
    }
public abstract class _EntityRefMixin : idl.EntityRef
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (entityKind != idl.EntityRefKind.named)
            _result["entityKind"] = entityKind.toString().split(".")[1];
        if (implicitFunctionTypeIndices.isNotEmpty)
            _result["implicitFunctionTypeIndices"] = implicitFunctionTypeIndices;
        if (paramReference != 0) _result["paramReference"] = paramReference;
        if (reference != 0) _result["reference"] = reference;
        if (refinedSlot != 0) _result["refinedSlot"] = refinedSlot;
        if (slot != 0) _result["slot"] = slot;
        if (syntheticParams.isNotEmpty)
            _result["syntheticParams"] =
                syntheticParams.map((_value) => _value.toJson()).toList();
        if (syntheticReturnType != null)
            _result["syntheticReturnType"] = syntheticReturnType.toJson();
        if (typeArguments.isNotEmpty)
            _result["typeArguments"] =
                typeArguments.map((_value) => _value.toJson()).toList();
        if (typeParameters.isNotEmpty)
            _result["typeParameters"] =
                typeParameters.map((_value) => _value.toJson()).toList();
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "entityKind": entityKind,
        "implicitFunctionTypeIndices": implicitFunctionTypeIndices,
        "paramReference": paramReference,
        "reference": reference,
        "refinedSlot": refinedSlot,
        "slot": slot,
        "syntheticParams": syntheticParams,
        "syntheticReturnType": syntheticReturnType,
        "typeArguments": typeArguments,
        "typeParameters": typeParameters,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class LinkedDependencyBuilder : Object
    with _LinkedDependencyMixin
    : idl.LinkedDependency
{
    List<String> _parts;
    String _uri;

    ////@override
    public List<String> parts
    {
        get => _parts ??= new Dictionary<String> { };
    }

    /**
     * Absolute URI for the compilation units listed in the library's `part`
     * declarations, empty string for invalid URI.
     */
    void setparts(List<String> value)
    {
        this._parts = value;
    }

    ////@override
    public String uri
    {
        get => _uri ??= "";
    }

    /**
     * The absolute URI of the dependent library, e.g. `package:foo/bar.dart`.
     */
    void seturi(String value)
    {
        this._uri = value;
    }

    LinkedDependencyBuilder(List<String> parts, String uri)
      : _parts = parts,
        _uri = uri;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative() { }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._uri ?? "");
        if (this._parts == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._parts.length);
            foreach (var x in this._parts)
            {
                signature.addString(x);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_parts;
        fb.Offset offset_uri;
        if (!(_parts == null || _parts.isEmpty))
        {
            offset_parts = fbBuilder
                .writeList(_parts.map((b) => fbBuilder.writeString(b)).toList());
        }
        if (_uri != null)
        {
            offset_uri = fbBuilder.writeString(_uri);
        }
        fbBuilder.startTable();
        if (offset_parts != null)
        {
            fbBuilder.addOffset(1, offset_parts);
        }
        if (offset_uri != null)
        {
            fbBuilder.addOffset(0, offset_uri);
        }
        return fbBuilder.endTable();
    }
}
public class _LinkedDependencyReader : fb.TableReader<_LinkedDependencyImpl>
{
    public _LinkedDependencyReader();

    ////@override
    _LinkedDependencyImpl createObject(fb.BufferContext bc, int offset) =>
      new _LinkedDependencyImpl(bc, offset);
}
public class _LinkedDependencyImpl : Object
    with _LinkedDependencyMixin
    : idl.LinkedDependency
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _LinkedDependencyImpl(this._bc, this._bcOffset);

    List<String> _parts;
    String _uri;

    ////@override
    List<String> get parts {
        _parts ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 1, new List<String>{);
        return _parts;
    }

////@override
String get uri {
        _uri ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _uri;
    }
    }
public abstract class _LinkedDependencyMixin : idl.LinkedDependency
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (parts.isNotEmpty) _result["parts"] = parts;
        if (uri != "") _result["uri"] = uri;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "parts": parts,
        "uri": uri,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class LinkedExportNameBuilder : Object
    with _LinkedExportNameMixin
    : idl.LinkedExportName
{
    int _dependency;
    idl.ReferenceKind _kind;
    String _name;
    int _unit;

    ////@override
    public int dependency
    {
        get => _dependency ??= 0;
    }

    /**
     * Index into [LinkedLibrary.dependencies] for the library in which the
     * entity is defined.
     */
    void setdependency(int value)
    {
        assert(value == null || value >= 0);
        this._dependency = value;
    }

    ////@override
    public idl.ReferenceKind kind
    {
        get => _kind ??= idl.ReferenceKind.classOrEnum;
    }

    /**
     * The kind of the entity being referred to.
     */
    void setkind(idl.ReferenceKind value)
    {
        this._kind = value;
    }

    ////@override
    public String name
    {
        get => _name ??= "";
    }

    /**
     * Name of the exported entity.  For an exported setter, this name includes
     * the trailing '='.
     */
    void setname(String value)
    {
        this._name = value;
    }

    ////@override
    public int unit
    {
        get => _unit ??= 0;
    }

    /**
     * Integer index indicating which unit in the exported library contains the
     * definition of the entity.  As with indices into [LinkedLibrary.units],
     * zero represents the defining compilation unit, and nonzero values
     * represent parts in the order of the corresponding `part` declarations.
     */
    void setunit(int value)
    {
        assert(value == null || value >= 0);
        this._unit = value;
    }

    LinkedExportNameBuilder(
      {
        int dependency, idl.ReferenceKind kind, String name, int unit)
      : _dependency = dependency,
        _kind = kind,
        _name = name,
        _unit = unit;

        /**
         * Flush [informative] data recursively.
         */
        void flushInformative() { }

        /**
         * Accumulate non-[informative] data into [signature].
         */
        void collectApiSignature(api_sig.ApiSignature signature)
        {
            signature.addInt(this._dependency ?? 0);
            signature.addString(this._name ?? "");
            signature.addInt(this._unit ?? 0);
            signature.addInt(this._kind == null ? 0 : this._kind.index);
        }

        fb.Offset finish(fb.Builder fbBuilder)
        {
            fb.Offset offset_name;
            if (_name != null)
            {
                offset_name = fbBuilder.writeString(_name);
            }
            fbBuilder.startTable();
            if (_dependency != null && _dependency != 0)
            {
                fbBuilder.addUint32(0, _dependency);
            }
            if (_kind != null && _kind != idl.ReferenceKind.classOrEnum)
            {
                fbBuilder.addUint8(3, _kind.index);
            }
            if (offset_name != null)
            {
                fbBuilder.addOffset(1, offset_name);
            }
            if (_unit != null && _unit != 0)
            {
                fbBuilder.addUint32(2, _unit);
            }
            return fbBuilder.endTable();
        }
    }
    public class _LinkedExportNameReader : fb.TableReader<_LinkedExportNameImpl>
    {
        public _LinkedExportNameReader();

        ////@override
        _LinkedExportNameImpl createObject(fb.BufferContext bc, int offset) =>
          new _LinkedExportNameImpl(bc, offset);
    }
    public class _LinkedExportNameImpl : Object
    
        with _LinkedExportNameMixin
    : idl.LinkedExportName
    {
        public readonly fb.BufferContext _bc;
        public readonly int _bcOffset;

        _LinkedExportNameImpl(this._bc, this._bcOffset);

        int _dependency;
        idl.ReferenceKind _kind;
        String _name;
        int _unit;

        ////@override
        int get dependency {
        _dependency ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _dependency;
    }

    ////@override
    idl.ReferenceKind get kind {
        _kind ??= new _ReferenceKindReader()
          .vTableGet(_bc, _bcOffset, 3, idl.ReferenceKind.classOrEnum);
        return _kind;
    }

////@override
String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 1, "");
        return _name;
    }

    ////@override
    int get unit {
        _unit ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 2, 0);
        return _unit;
    }
    }
public abstract class _LinkedExportNameMixin : idl.LinkedExportName
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (dependency != 0) _result["dependency"] = dependency;
        if (kind != idl.ReferenceKind.classOrEnum)
            _result["kind"] = kind.toString().split(".")[1];
        if (name != "") _result["name"] = name;
        if (unit != 0) _result["unit"] = unit;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "dependency": dependency,
        "kind": kind,
        "name": name,
        "unit": unit,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class LinkedLibraryBuilder : Object
    with _LinkedLibraryMixin
    : idl.LinkedLibrary
{
    List<LinkedDependencyBuilder> _dependencies;
    List<int> _exportDependencies;
    List<LinkedExportNameBuilder> _exportNames;
    List<int> _importDependencies;
    int _numPrelinkedDependencies;
    List<LinkedUnitBuilder> _units;

    ////@override
    List<LinkedDependencyBuilder> get dependencies =>
        _dependencies ??= new Dictionary<LinkedDependencyBuilder>{};

/**
 * The libraries that this library depends on (either via an explicit import
 * statement or via the implicit dependencies on `dart:core` and
 * `dart:async`).  The first element of this array is a pseudo-dependency
 * representing the library itself (it is also used for `dynamic` and
 * `void`).  This is followed by elements representing "prelinked"
 * dependencies (direct imports and the transitive closure of exports).
 * After the prelinked dependencies are elements representing "linked"
 * dependencies.
 *
 * A library is only included as a "linked" dependency if it is a true
 * dependency (e.g. a propagated or inferred type or constant value
 * implicitly refers to an element declared in the library) or
 * anti-dependency (e.g. the result of type propagation or type inference
 * depends on the lack of a certain declaration in the library).
 */
void setdependencies(List<LinkedDependencyBuilder> value)
{
    this._dependencies = value;
}

////@override
public List<int> exportDependencies
{
    get => _exportDependencies ??= new List<int> { };
}

/**
 * For each export in [UnlinkedUnit.exports], an index into [dependencies]
 * of the library being exported.
 */
void setexportDependencies(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._exportDependencies = value;
}

////@override
List<LinkedExportNameBuilder> get exportNames =>
        _exportNames ??= new Dictionary<LinkedExportNameBuilder>{};

    /**
     * Information about entities in the export namespace of the library that are
     * not in the public namespace of the library (that is, entities that are
     * brought into the namespace via `export` directives).
     *
     * Sorted by name.
     */
    void setexportNames(List<LinkedExportNameBuilder> value)
{
    this._exportNames = value;
}

////@override
Null get fallbackMode =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
public List<int> importDependencies
{
    get => _importDependencies ??= new Dictionary<int> { };
}

/**
 * For each import in [UnlinkedUnit.imports], an index into [dependencies]
 * of the library being imported.
 */
void setimportDependencies(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._importDependencies = value;
}

////@override
public int numPrelinkedDependencies
{
    get => _numPrelinkedDependencies ??= 0;
}

/**
 * The number of elements in [dependencies] which are not "linked"
 * dependencies (that is, the number of libraries in the direct imports plus
 * the transitive closure of exports, plus the library itself).
 */
void setnumPrelinkedDependencies(int value)
{
    assert(value == null || value >= 0);
    this._numPrelinkedDependencies = value;
}

////@override
public List<LinkedUnitBuilder> units
{
    get => _units ??= new Dictionary<LinkedUnitBuilder> { };
}

/**
 * The linked summary of all the compilation units constituting the
 * library.  The summary of the defining compilation unit is listed first,
 * followed by the summary of each part, in the order of the `part`
 * declarations in the defining compilation unit.
 */
void setunits(List<LinkedUnitBuilder> value)
{
    this._units = value;
}

LinkedLibraryBuilder(
        {
    List<LinkedDependencyBuilder> dependencies,
   List< int > exportDependencies,
      List<LinkedExportNameBuilder> exportNames,
      List< int > importDependencies,
      int numPrelinkedDependencies,
      List< LinkedUnitBuilder > units)
      : _dependencies = dependencies,
        _exportDependencies = exportDependencies,
        _exportNames = exportNames,
        _importDependencies = importDependencies,
        _numPrelinkedDependencies = numPrelinkedDependencies,
        _units = units;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _dependencies?.forEach((b) => b.flushInformative());
        _exportNames?.forEach((b) => b.flushInformative());
        _units?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._dependencies == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._dependencies.length);
            foreach (var x in this._dependencies)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._importDependencies == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._importDependencies.length);
            foreach (var x in this._importDependencies)
            {
                signature.addInt(x);
            }
        }
        signature.addInt(this._numPrelinkedDependencies ?? 0);
        if (this._units == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._units.length);
            foreach (var x in this._units)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._exportNames == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._exportNames.length);
            foreach (var x in this._exportNames)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._exportDependencies == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._exportDependencies.length);
            foreach (var x in this._exportDependencies)
            {
                signature.addInt(x);
            }
        }
    }

    List<int> toBuffer()
    {
        fb.Builder fbBuilder = new fb.Builder();
        return fbBuilder.finish(finish(fbBuilder), "LLib");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_dependencies;
        fb.Offset offset_exportDependencies;
        fb.Offset offset_exportNames;
        fb.Offset offset_importDependencies;
        fb.Offset offset_units;
        if (!(_dependencies == null || _dependencies.isEmpty))
        {
            offset_dependencies = fbBuilder
                .writeList(_dependencies.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_exportDependencies == null || _exportDependencies.isEmpty))
        {
            offset_exportDependencies =
                fbBuilder.writeListUint32(_exportDependencies);
        }
        if (!(_exportNames == null || _exportNames.isEmpty))
        {
            offset_exportNames = fbBuilder
                .writeList(_exportNames.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_importDependencies == null || _importDependencies.isEmpty))
        {
            offset_importDependencies =
                fbBuilder.writeListUint32(_importDependencies);
        }
        if (!(_units == null || _units.isEmpty))
        {
            offset_units =
                fbBuilder.writeList(_units.map((b) => b.finish(fbBuilder)).toList());
        }
        fbBuilder.startTable();
        if (offset_dependencies != null)
        {
            fbBuilder.addOffset(0, offset_dependencies);
        }
        if (offset_exportDependencies != null)
        {
            fbBuilder.addOffset(6, offset_exportDependencies);
        }
        if (offset_exportNames != null)
        {
            fbBuilder.addOffset(4, offset_exportNames);
        }
        if (offset_importDependencies != null)
        {
            fbBuilder.addOffset(1, offset_importDependencies);
        }
        if (_numPrelinkedDependencies != null && _numPrelinkedDependencies != 0)
        {
            fbBuilder.addUint32(2, _numPrelinkedDependencies);
        }
        if (offset_units != null)
        {
            fbBuilder.addOffset(3, offset_units);
        }
        return fbBuilder.endTable();
    }
}

idl.LinkedLibrary readLinkedLibrary(List<int> buffer)
{
    fb.BufferContext rootRef = new fb.BufferContext.fromBytes(buffer);
    return new _LinkedLibraryReader().read(rootRef, 0);
}
public class _LinkedLibraryReader : fb.TableReader<_LinkedLibraryImpl>
{
    public _LinkedLibraryReader();

    ////@override
    _LinkedLibraryImpl createObject(fb.BufferContext bc, int offset) =>
      new _LinkedLibraryImpl(bc, offset);
}
public class _LinkedLibraryImpl : Object
    with _LinkedLibraryMixin
    : idl.LinkedLibrary
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _LinkedLibraryImpl(this._bc, this._bcOffset);

    List<idl.LinkedDependency> _dependencies;
    List<int> _exportDependencies;
    List<idl.LinkedExportName> _exportNames;
    List<int> _importDependencies;
    int _numPrelinkedDependencies;
    List<idl.LinkedUnit> _units;

    ////@override
    List<idl.LinkedDependency> get dependencies {
        _dependencies ??= new fb.ListReader<idl.LinkedDependency>(
public _LinkedDependencyReader())
        .vTableGet(_bc, _bcOffset, 0, new List<idl.LinkedDependency>{);
        return _dependencies;
    }

////@override
List<int> get exportDependencies {
        _exportDependencies ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 6, new List<int>{);
        return _exportDependencies;
    }

    ////@override
    List<idl.LinkedExportName> get exportNames {
        _exportNames ??= new fb.ListReader<idl.LinkedExportName>(
public _LinkedExportNameReader())
        .vTableGet(_bc, _bcOffset, 4, new List<idl.LinkedExportName>{);
        return _exportNames;
    }

    ////@override
    Null get fallbackMode =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
List<int> get importDependencies {
        _importDependencies ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 1, new List<int>{);
        return _importDependencies;
    }

    ////@override
    int get numPrelinkedDependencies {
        _numPrelinkedDependencies ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 2, 0);
        return _numPrelinkedDependencies;
    }

    ////@override
    List<idl.LinkedUnit> get units {
        _units ??= new fb.ListReader<idl.LinkedUnit>(const _LinkedUnitReader())
        .vTableGet(_bc, _bcOffset, 3, new List<idl.LinkedUnit>{);
        return _units;
    }
    }
public abstract class _LinkedLibraryMixin : idl.LinkedLibrary
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (dependencies.isNotEmpty)
            _result["dependencies"] =
                dependencies.map((_value) => _value.toJson()).toList();
        if (exportDependencies.isNotEmpty)
            _result["exportDependencies"] = exportDependencies;
        if (exportNames.isNotEmpty)
            _result["exportNames"] =
                exportNames.map((_value) => _value.toJson()).toList();
        if (importDependencies.isNotEmpty)
            _result["importDependencies"] = importDependencies;
        if (numPrelinkedDependencies != 0)
            _result["numPrelinkedDependencies"] = numPrelinkedDependencies;
        if (units.isNotEmpty)
            _result["units"] = units.map((_value) => _value.toJson()).toList();
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "dependencies": dependencies,
        "exportDependencies": exportDependencies,
        "exportNames": exportNames,
        "importDependencies": importDependencies,
        "numPrelinkedDependencies": numPrelinkedDependencies,
        "units": units,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class LinkedReferenceBuilder : Object
    with _LinkedReferenceMixin
    : idl.LinkedReference
{
    int _containingReference;
    int _dependency;
    idl.ReferenceKind _kind;
    String _name;
    int _numTypeParameters;
    int _unit;

    ////@override
    public int containingReference
    {
        get => _containingReference ??= 0;
    }

    /**
     * If this [LinkedReference] doesn't have an associated [UnlinkedReference],
     * and the entity being referred to is contained within another entity, index
     * of the containing entity.  This behaves similarly to
     * [UnlinkedReference.prefixReference], however it is only used for class
     * members, not for prefixed imports.
     *
     * Containing references must always point backward; that is, for all i, if
     * LinkedUnit.references[i].containingReference != 0, then
     * LinkedUnit.references[i].containingReference < i.
     */
    void setcontainingReference(int value)
    {
        assert(value == null || value >= 0);
        this._containingReference = value;
    }

    ////@override
    public int dependency
    {
        get => _dependency ??= 0;
    }

    /**
     * Index into [LinkedLibrary.dependencies] indicating which imported library
     * declares the entity being referred to.
     *
     * Zero if this entity is contained within another entity (e.g. a class
     * member), or if [kind] is [ReferenceKind.prefix].
     */
    void setdependency(int value)
    {
        assert(value == null || value >= 0);
        this._dependency = value;
    }

    ////@override
    public idl.ReferenceKind kind
    {
        get => _kind ??= idl.ReferenceKind.classOrEnum;
    }

    /**
     * The kind of the entity being referred to.  For the pseudo-types `dynamic`
     * and `void`, the kind is [ReferenceKind.classOrEnum].
     */
    void setkind(idl.ReferenceKind value)
    {
        this._kind = value;
    }

    ////@override
    Null get localIndex =>
      throw new NotImplementedException("attempt to access deprecated field");

    ////@override
    public String name
    {
        get => _name ??= "";
    }

    /**
     * If this [LinkedReference] doesn't have an associated [UnlinkedReference],
     * name of the entity being referred to.  For the pseudo-type `dynamic`, the
     * string is "dynamic".  For the pseudo-type `void`, the string is "void".
     */
    void setname(String value)
    {
        this._name = value;
    }

    ////@override
    public int numTypeParameters
    {
        get => _numTypeParameters ??= 0;
    }

    /**
     * If the entity being referred to is generic, the number of type parameters
     * it declares (does not include type parameters of enclosing entities).
     * Otherwise zero.
     */
    void setnumTypeParameters(int value)
    {
        assert(value == null || value >= 0);
        this._numTypeParameters = value;
    }

    ////@override
    public int unit
    {
        get => _unit ??= 0;
    }

    /**
     * Integer index indicating which unit in the imported library contains the
     * definition of the entity.  As with indices into [LinkedLibrary.units],
     * zero represents the defining compilation unit, and nonzero values
     * represent parts in the order of the corresponding `part` declarations.
     *
     * Zero if this entity is contained within another entity (e.g. a class
     * member).
     */
    void setunit(int value)
    {
        assert(value == null || value >= 0);
        this._unit = value;
    }

    LinkedReferenceBuilder(
      {
        int containingReference,
      int dependency,
      idl.ReferenceKind kind,
      String name,
      int numTypeParameters,
      int unit)
      : _containingReference = containingReference,
        _dependency = dependency,
        _kind = kind,
        _name = name,
        _numTypeParameters = numTypeParameters,
        _unit = unit;

        /**
         * Flush [informative] data recursively.
         */
        void flushInformative() { }

        /**
         * Accumulate non-[informative] data into [signature].
         */
        void collectApiSignature(api_sig.ApiSignature signature)
        {
            signature.addInt(this._unit ?? 0);
            signature.addInt(this._dependency ?? 0);
            signature.addInt(this._kind == null ? 0 : this._kind.index);
            signature.addString(this._name ?? "");
            signature.addInt(this._numTypeParameters ?? 0);
            signature.addInt(this._containingReference ?? 0);
        }

        fb.Offset finish(fb.Builder fbBuilder)
        {
            fb.Offset offset_name;
            if (_name != null)
            {
                offset_name = fbBuilder.writeString(_name);
            }
            fbBuilder.startTable();
            if (_containingReference != null && _containingReference != 0)
            {
                fbBuilder.addUint32(5, _containingReference);
            }
            if (_dependency != null && _dependency != 0)
            {
                fbBuilder.addUint32(1, _dependency);
            }
            if (_kind != null && _kind != idl.ReferenceKind.classOrEnum)
            {
                fbBuilder.addUint8(2, _kind.index);
            }
            if (offset_name != null)
            {
                fbBuilder.addOffset(3, offset_name);
            }
            if (_numTypeParameters != null && _numTypeParameters != 0)
            {
                fbBuilder.addUint32(4, _numTypeParameters);
            }
            if (_unit != null && _unit != 0)
            {
                fbBuilder.addUint32(0, _unit);
            }
            return fbBuilder.endTable();
        }
    }
    public class _LinkedReferenceReader : fb.TableReader<_LinkedReferenceImpl>
    {
        public _LinkedReferenceReader();

        ////@override
        _LinkedReferenceImpl createObject(fb.BufferContext bc, int offset) =>
          new _LinkedReferenceImpl(bc, offset);
    }
    public class _LinkedReferenceImpl : Object
    
        with _LinkedReferenceMixin
    : idl.LinkedReference
    {
        public readonly fb.BufferContext _bc;
        public readonly int _bcOffset;

        _LinkedReferenceImpl(this._bc, this._bcOffset);

        int _containingReference;
        int _dependency;
        idl.ReferenceKind _kind;
        String _name;
        int _numTypeParameters;
        int _unit;

        ////@override
        int get containingReference {
        _containingReference ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 5, 0);
        return _containingReference;
    }

    ////@override
    int get dependency {
        _dependency ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _dependency;
    }

////@override
idl.ReferenceKind get kind {
        _kind ??= new _ReferenceKindReader()
          .vTableGet(_bc, _bcOffset, 2, idl.ReferenceKind.classOrEnum);
        return _kind;
    }

    ////@override
    Null get localIndex =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 3, "");
        return _name;
    }

    ////@override
    int get numTypeParameters {
        _numTypeParameters ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 4, 0);
        return _numTypeParameters;
    }

    ////@override
    int get unit {
        _unit ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _unit;
    }
    }
public abstract class _LinkedReferenceMixin : idl.LinkedReference
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (containingReference != 0)
            _result["containingReference"] = containingReference;
        if (dependency != 0) _result["dependency"] = dependency;
        if (kind != idl.ReferenceKind.classOrEnum)
            _result["kind"] = kind.toString().split(".")[1];
        if (name != "") _result["name"] = name;
        if (numTypeParameters != 0)
            _result["numTypeParameters"] = numTypeParameters;
        if (unit != 0) _result["unit"] = unit;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "containingReference": containingReference,
        "dependency": dependency,
        "kind": kind,
        "name": name,
        "numTypeParameters": numTypeParameters,
        "unit": unit,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class LinkedUnitBuilder : Object
    with _LinkedUnitMixin
    : idl.LinkedUnit
{
    List<int> _constCycles;
    List<int> _parametersInheritingCovariant;
    List<LinkedReferenceBuilder> _references;
    List<TopLevelInferenceErrorBuilder> _topLevelInferenceErrors;
    List<EntityRefBuilder> _types;

    ////@override
    public List<int> constCycles
    {
        get => _constCycles ??= new Dictionary<int> { };
    }

    /**
     * List of slot ids (referring to [UnlinkedExecutable.constCycleSlot])
     * corresponding to const constructors that are part of cycles.
     */
    void setconstCycles(List<int> value)
    {
        assert(value == null || value.every((e) => e >= 0));
        this._constCycles = value;
    }

    ////@override
    List<int> get parametersInheritingCovariant =>
        _parametersInheritingCovariant ??= new List<int>{};

/**
 * List of slot ids (referring to [UnlinkedParam.inheritsCovariantSlot] or
 * [UnlinkedVariable.inheritsCovariantSlot]) corresponding to parameters
 * that inherit `//@covariant` behavior from a base class.
 */
void setparametersInheritingCovariant(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._parametersInheritingCovariant = value;
}

////@override
List<LinkedReferenceBuilder> get references =>
        _references ??= new List<LinkedReferenceBuilder>{};

    /**
     * Information about the resolution of references within the compilation
     * unit.  Each element of [UnlinkedUnit.references] has a corresponding
     * element in this list (at the same index).  If this list has additional
     * elements beyond the number of elements in [UnlinkedUnit.references], those
     * additional elements are references that are only referred to implicitly
     * (e.g. elements involved in inferred or propagated types).
     */
    void setreferences(List<LinkedReferenceBuilder> value)
{
    this._references = value;
}

////@override
List<TopLevelInferenceErrorBuilder> get topLevelInferenceErrors =>
        _topLevelInferenceErrors ??= new Dictionary<TopLevelInferenceErrorBuilder>{};

    /**
     * The list of type inference errors.
     */
    void settopLevelInferenceErrors(List<TopLevelInferenceErrorBuilder> value)
{
    this._topLevelInferenceErrors = value;
}

////@override
public List<EntityRefBuilder> types
{
    get => _types ??= new List<EntityRefBuilder> { };
}

/**
 * List associating slot ids found inside the unlinked summary for the
 * compilation unit with propagated and inferred types.
 */
void settypes(List<EntityRefBuilder> value)
{
    this._types = value;
}

LinkedUnitBuilder(
        {
    List<int> constCycles,
   List< int > parametersInheritingCovariant,
      List<LinkedReferenceBuilder> references,
      List< TopLevelInferenceErrorBuilder > topLevelInferenceErrors,
      List<EntityRefBuilder> types)
      : _constCycles = constCycles,
        _parametersInheritingCovariant = parametersInheritingCovariant,
        _references = references,
        _topLevelInferenceErrors = topLevelInferenceErrors,
        _types = types;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _references?.forEach((b) => b.flushInformative());
        _topLevelInferenceErrors?.forEach((b) => b.flushInformative());
        _types?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._references == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._references.length);
            foreach (var x in this._references)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._types == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._types.length);
            foreach (var x in this._types)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._constCycles == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._constCycles.length);
            foreach (var x in this._constCycles)
            {
                signature.addInt(x);
            }
        }
        if (this._parametersInheritingCovariant == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._parametersInheritingCovariant.length);
            foreach (var x in this._parametersInheritingCovariant)
            {
                signature.addInt(x);
            }
        }
        if (this._topLevelInferenceErrors == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._topLevelInferenceErrors.length);
            foreach (var x in this._topLevelInferenceErrors)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_constCycles;
        fb.Offset offset_parametersInheritingCovariant;
        fb.Offset offset_references;
        fb.Offset offset_topLevelInferenceErrors;
        fb.Offset offset_types;
        if (!(_constCycles == null || _constCycles.isEmpty))
        {
            offset_constCycles = fbBuilder.writeListUint32(_constCycles);
        }
        if (!(_parametersInheritingCovariant == null ||
            _parametersInheritingCovariant.isEmpty))
        {
            offset_parametersInheritingCovariant =
                fbBuilder.writeListUint32(_parametersInheritingCovariant);
        }
        if (!(_references == null || _references.isEmpty))
        {
            offset_references = fbBuilder
                .writeList(_references.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_topLevelInferenceErrors == null ||
            _topLevelInferenceErrors.isEmpty))
        {
            offset_topLevelInferenceErrors = fbBuilder.writeList(
                _topLevelInferenceErrors.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_types == null || _types.isEmpty))
        {
            offset_types =
                fbBuilder.writeList(_types.map((b) => b.finish(fbBuilder)).toList());
        }
        fbBuilder.startTable();
        if (offset_constCycles != null)
        {
            fbBuilder.addOffset(2, offset_constCycles);
        }
        if (offset_parametersInheritingCovariant != null)
        {
            fbBuilder.addOffset(3, offset_parametersInheritingCovariant);
        }
        if (offset_references != null)
        {
            fbBuilder.addOffset(0, offset_references);
        }
        if (offset_topLevelInferenceErrors != null)
        {
            fbBuilder.addOffset(4, offset_topLevelInferenceErrors);
        }
        if (offset_types != null)
        {
            fbBuilder.addOffset(1, offset_types);
        }
        return fbBuilder.endTable();
    }
}
public class _LinkedUnitReader : fb.TableReader<_LinkedUnitImpl>
{
    public _LinkedUnitReader();

    ////@override
    _LinkedUnitImpl createObject(fb.BufferContext bc, int offset) =>
      new _LinkedUnitImpl(bc, offset);
}
public class _LinkedUnitImpl : Object
    with _LinkedUnitMixin
    : idl.LinkedUnit
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _LinkedUnitImpl(this._bc, this._bcOffset);

    List<int> _constCycles;
    List<int> _parametersInheritingCovariant;
    List<idl.LinkedReference> _references;
    List<idl.TopLevelInferenceError> _topLevelInferenceErrors;
    List<idl.EntityRef> _types;

    ////@override
    List<int> get constCycles {
        _constCycles ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 2, new List<int>{);
        return _constCycles;
    }

////@override
List<int> get parametersInheritingCovariant {
        _parametersInheritingCovariant ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 3, new List<int>{);
        return _parametersInheritingCovariant;
    }

    ////@override
    List<idl.LinkedReference> get references {
        _references ??=
public fb.ListReader<idl.LinkedReference>(const _LinkedReferenceReader())
            .vTableGet(_bc, _bcOffset, 0, new List<idl.LinkedReference>{);
        return _references;
    }

    ////@override
    List<idl.TopLevelInferenceError> get topLevelInferenceErrors {
        _topLevelInferenceErrors ??=
public fb.ListReader<idl.TopLevelInferenceError>(
public _TopLevelInferenceErrorReader())
            .vTableGet(_bc, _bcOffset, 4, new List<idl.TopLevelInferenceError>{);
        return _topLevelInferenceErrors;
    }

    ////@override
    List<idl.EntityRef> get types {
        _types ??= new fb.ListReader<idl.EntityRef>(const _EntityRefReader())
        .vTableGet(_bc, _bcOffset, 1, new List<idl.EntityRef>{);
        return _types;
    }
    }
public abstract class _LinkedUnitMixin : idl.LinkedUnit
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (constCycles.isNotEmpty) _result["constCycles"] = constCycles;
        if (parametersInheritingCovariant.isNotEmpty)
            _result["parametersInheritingCovariant"] = parametersInheritingCovariant;
        if (references.isNotEmpty)
            _result["references"] =
                references.map((_value) => _value.toJson()).toList();
        if (topLevelInferenceErrors.isNotEmpty)
            _result["topLevelInferenceErrors"] =
                topLevelInferenceErrors.map((_value) => _value.toJson()).toList();
        if (types.isNotEmpty)
            _result["types"] = types.map((_value) => _value.toJson()).toList();
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "constCycles": constCycles,
        "parametersInheritingCovariant": parametersInheritingCovariant,
        "references": references,
        "topLevelInferenceErrors": topLevelInferenceErrors,
        "types": types,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class PackageBundleBuilder : Object
    with _PackageBundleMixin
    : idl.PackageBundle
{
    List<LinkedLibraryBuilder> _linkedLibraries;
    List<String> _linkedLibraryUris;
    int _majorVersion;
    int _minorVersion;
    List<UnlinkedUnitBuilder> _unlinkedUnits;
    List<String> _unlinkedUnitUris;

    ////@override
    Null get apiSignature =>
        throw new NotImplementedException("attempt to access deprecated field");

    ////@override
    Null get dependencies =>
      throw new NotImplementedException("attempt to access deprecated field");

    ////@override
    List<LinkedLibraryBuilder> get linkedLibraries =>
        _linkedLibraries ??= new Dictionary<LinkedLibraryBuilder>{};

/**
 * Linked libraries.
 */
void setlinkedLibraries(List<LinkedLibraryBuilder> value)
{
    this._linkedLibraries = value;
}

////@override
public List<String> linkedLibraryUris
{
    get => _linkedLibraryUris ??= new List<String> { };
}

/**
 * The list of URIs of items in [linkedLibraries], e.g. `dart:core` or
 * `package:foo/bar.dart`.
 */
void setlinkedLibraryUris(List<String> value)
{
    this._linkedLibraryUris = value;
}

////@override
public int majorVersion
{
    get => _majorVersion ??= 0;
}

/**
 * Major version of the summary format.  See
 * [PackageBundleAssembler.currentMajorVersion].
 */
void setmajorVersion(int value)
{
    assert(value == null || value >= 0);
    this._majorVersion = value;
}

////@override
public int minorVersion
{
    get => _minorVersion ??= 0;
}

/**
 * Minor version of the summary format.  See
 * [PackageBundleAssembler.currentMinorVersion].
 */
void setminorVersion(int value)
{
    assert(value == null || value >= 0);
    this._minorVersion = value;
}

////@override
Null get unlinkedUnitHashes =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
List<UnlinkedUnitBuilder> get unlinkedUnits =>
        _unlinkedUnits ??= new Dictionary<UnlinkedUnitBuilder>{};

    /**
     * Unlinked information for the compilation units constituting the package.
     */
    void setunlinkedUnits(List<UnlinkedUnitBuilder> value)
{
    this._unlinkedUnits = value;
}

////@override
public List<String> unlinkedUnitUris
{
    get => _unlinkedUnitUris ??= new List<String> { };
}

/**
 * The list of URIs of items in [unlinkedUnits], e.g. `dart:core/bool.dart`.
 */
void setunlinkedUnitUris(List<String> value)
{
    this._unlinkedUnitUris = value;
}

PackageBundleBuilder(
        {
    List<LinkedLibraryBuilder> linkedLibraries,
   List< String > linkedLibraryUris,
      int majorVersion,
      int minorVersion,
      List< UnlinkedUnitBuilder > unlinkedUnits,
      List<String> unlinkedUnitUris)
      : _linkedLibraries = linkedLibraries,
        _linkedLibraryUris = linkedLibraryUris,
        _majorVersion = majorVersion,
        _minorVersion = minorVersion,
        _unlinkedUnits = unlinkedUnits,
        _unlinkedUnitUris = unlinkedUnitUris;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _linkedLibraries?.forEach((b) => b.flushInformative());
        _unlinkedUnits?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._linkedLibraries == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._linkedLibraries.length);
            foreach (var x in this._linkedLibraries)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._linkedLibraryUris == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._linkedLibraryUris.length);
            foreach (var x in this._linkedLibraryUris)
            {
                signature.addString(x);
            }
        }
        if (this._unlinkedUnits == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._unlinkedUnits.length);
            foreach (var x in this._unlinkedUnits)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._unlinkedUnitUris == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._unlinkedUnitUris.length);
            foreach (var x in this._unlinkedUnitUris)
            {
                signature.addString(x);
            }
        }
        signature.addInt(this._majorVersion ?? 0);
        signature.addInt(this._minorVersion ?? 0);
    }

    List<int> toBuffer()
    {
        fb.Builder fbBuilder = new fb.Builder();
        return fbBuilder.finish(finish(fbBuilder), "PBdl");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_linkedLibraries;
        fb.Offset offset_linkedLibraryUris;
        fb.Offset offset_unlinkedUnits;
        fb.Offset offset_unlinkedUnitUris;
        if (!(_linkedLibraries == null || _linkedLibraries.isEmpty))
        {
            offset_linkedLibraries = fbBuilder
                .writeList(_linkedLibraries.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_linkedLibraryUris == null || _linkedLibraryUris.isEmpty))
        {
            offset_linkedLibraryUris = fbBuilder.writeList(
                _linkedLibraryUris.map((b) => fbBuilder.writeString(b)).toList());
        }
        if (!(_unlinkedUnits == null || _unlinkedUnits.isEmpty))
        {
            offset_unlinkedUnits = fbBuilder
                .writeList(_unlinkedUnits.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_unlinkedUnitUris == null || _unlinkedUnitUris.isEmpty))
        {
            offset_unlinkedUnitUris = fbBuilder.writeList(
                _unlinkedUnitUris.map((b) => fbBuilder.writeString(b)).toList());
        }
        fbBuilder.startTable();
        if (offset_linkedLibraries != null)
        {
            fbBuilder.addOffset(0, offset_linkedLibraries);
        }
        if (offset_linkedLibraryUris != null)
        {
            fbBuilder.addOffset(1, offset_linkedLibraryUris);
        }
        if (_majorVersion != null && _majorVersion != 0)
        {
            fbBuilder.addUint32(5, _majorVersion);
        }
        if (_minorVersion != null && _minorVersion != 0)
        {
            fbBuilder.addUint32(6, _minorVersion);
        }
        if (offset_unlinkedUnits != null)
        {
            fbBuilder.addOffset(2, offset_unlinkedUnits);
        }
        if (offset_unlinkedUnitUris != null)
        {
            fbBuilder.addOffset(3, offset_unlinkedUnitUris);
        }
        return fbBuilder.endTable();
    }
}

idl.PackageBundle readPackageBundle(List<int> buffer)
{
    fb.BufferContext rootRef = new fb.BufferContext.fromBytes(buffer);
    return new _PackageBundleReader().read(rootRef, 0);
}
public class _PackageBundleReader : fb.TableReader<_PackageBundleImpl>
{
    public _PackageBundleReader();

    ////@override
    _PackageBundleImpl createObject(fb.BufferContext bc, int offset) =>
      new _PackageBundleImpl(bc, offset);
}
public class _PackageBundleImpl : Object
    with _PackageBundleMixin
    : idl.PackageBundle
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _PackageBundleImpl(this._bc, this._bcOffset);

    List<idl.LinkedLibrary> _linkedLibraries;
    List<String> _linkedLibraryUris;
    int _majorVersion;
    int _minorVersion;
    List<idl.UnlinkedUnit> _unlinkedUnits;
    List<String> _unlinkedUnitUris;

    ////@override
    Null get apiSignature =>
        throw new NotImplementedException("attempt to access deprecated field");

    ////@override
    Null get dependencies =>
      throw new NotImplementedException("attempt to access deprecated field");

    ////@override
    List<idl.LinkedLibrary> get linkedLibraries {
        _linkedLibraries ??=
public fb.ListReader<idl.LinkedLibrary>(const _LinkedLibraryReader())
            .vTableGet(_bc, _bcOffset, 0, new List<idl.LinkedLibrary>{);
        return _linkedLibraries;
    }

////@override
List<String> get linkedLibraryUris {
        _linkedLibraryUris ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 1, new List<String>{);
        return _linkedLibraryUris;
    }

    ////@override
    int get majorVersion {
        _majorVersion ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 5, 0);
        return _majorVersion;
    }

    ////@override
    int get minorVersion {
        _minorVersion ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 6, 0);
        return _minorVersion;
    }

    ////@override
    Null get unlinkedUnitHashes =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
List<idl.UnlinkedUnit> get unlinkedUnits {
        _unlinkedUnits ??=
public fb.ListReader<idl.UnlinkedUnit>(const _UnlinkedUnitReader())
            .vTableGet(_bc, _bcOffset, 2, new List<idl.UnlinkedUnit>{);
        return _unlinkedUnits;
    }

    ////@override
    List<String> get unlinkedUnitUris {
        _unlinkedUnitUris ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 3, new List<String>{);
        return _unlinkedUnitUris;
    }
    }
public abstract class _PackageBundleMixin : idl.PackageBundle
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (linkedLibraries.isNotEmpty)
            _result["linkedLibraries"] =
                linkedLibraries.map((_value) => _value.toJson()).toList();
        if (linkedLibraryUris.isNotEmpty)
            _result["linkedLibraryUris"] = linkedLibraryUris;
        if (majorVersion != 0) _result["majorVersion"] = majorVersion;
        if (minorVersion != 0) _result["minorVersion"] = minorVersion;
        if (unlinkedUnits.isNotEmpty)
            _result["unlinkedUnits"] =
                unlinkedUnits.map((_value) => _value.toJson()).toList();
        if (unlinkedUnitUris.isNotEmpty)
            _result["unlinkedUnitUris"] = unlinkedUnitUris;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "linkedLibraries": linkedLibraries,
        "linkedLibraryUris": linkedLibraryUris,
        "majorVersion": majorVersion,
        "minorVersion": minorVersion,
        "unlinkedUnits": unlinkedUnits,
        "unlinkedUnitUris": unlinkedUnitUris,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class PackageIndexBuilder : Object
    with _PackageIndexMixin
    : idl.PackageIndex
{
    List<idl.IndexSyntheticElementKind> _elementKinds;
    List<int> _elementNameClassMemberIds;
    List<int> _elementNameParameterIds;
    List<int> _elementNameUnitMemberIds;
    List<int> _elementUnits;
    List<String> _strings;
    List<int> _unitLibraryUris;
    List<UnitIndexBuilder> _units;
    List<int> _unitUnitUris;

    ////@override
    List<idl.IndexSyntheticElementKind> get elementKinds =>
        _elementKinds ??= new Dictionary<idl.IndexSyntheticElementKind>{};

/**
 * Each item of this list corresponds to a unique referenced element.  It is
 * the kind of the synthetic element.
 */
void setelementKinds(List<idl.IndexSyntheticElementKind> value)
{
    this._elementKinds = value;
}

////@override
List<int> get elementNameClassMemberIds =>
        _elementNameClassMemberIds ??= new List<int>{};

    /**
     * Each item of this list corresponds to a unique referenced element.  It is
     * the identifier of the class member element name, or `null` if the element
     * is a top-level element.  The list is sorted in ascending order, so that the
     * client can quickly check whether an element is referenced in this
     * [PackageIndex].
     */
    void setelementNameClassMemberIds(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._elementNameClassMemberIds = value;
}

////@override
public List<int> elementNameParameterIds
{
    get => _elementNameParameterIds ??= new Dictionary<int> { };
}

/**
 * Each item of this list corresponds to a unique referenced element.  It is
 * the identifier of the named parameter name, or `null` if the element is not
 * a named parameter.  The list is sorted in ascending order, so that the
 * client can quickly check whether an element is referenced in this
 * [PackageIndex].
 */
void setelementNameParameterIds(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._elementNameParameterIds = value;
}

////@override
List<int> get elementNameUnitMemberIds =>
        _elementNameUnitMemberIds ??= new Dictionary<int>{};

    /**
     * Each item of this list corresponds to a unique referenced element.  It is
     * the identifier of the top-level element name, or `null` if the element is
     * the unit.  The list is sorted in ascending order, so that the client can
     * quickly check whether an element is referenced in this [PackageIndex].
     */
    void setelementNameUnitMemberIds(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._elementNameUnitMemberIds = value;
}

////@override
public List<int> elementUnits
{
    get => _elementUnits ??= new Dictionary<int> { };
}

/**
 * Each item of this list corresponds to a unique referenced element.  It is
 * the index into [unitLibraryUris] and [unitUnitUris] for the library
 * specific unit where the element is declared.
 */
void setelementUnits(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._elementUnits = value;
}

////@override
public List<String> strings
{
    get => _strings ??= new List<String> { };
}

/**
 * List of unique element strings used in this [PackageIndex].  The list is
 * sorted in ascending order, so that the client can quickly check the
 * presence of a string in this [PackageIndex].
 */
void setstrings(List<String> value)
{
    this._strings = value;
}

////@override
public List<int> unitLibraryUris
{
    get => _unitLibraryUris ??= new Dictionary<int> { };
}

/**
 * Each item of this list corresponds to the library URI of a unique library
 * specific unit referenced in the [PackageIndex].  It is an index into
 * [strings] list.
 */
void setunitLibraryUris(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._unitLibraryUris = value;
}

////@override
public List<UnitIndexBuilder> units
{
    get => _units ??= new List<UnitIndexBuilder> { };
}

/**
 * List of indexes of each unit in this [PackageIndex].
 */
void setunits(List<UnitIndexBuilder> value)
{
    this._units = value;
}

////@override
public List<int> unitUnitUris
{
    get => _unitUnitUris ??= new List<int> { };
}

/**
 * Each item of this list corresponds to the unit URI of a unique library
 * specific unit referenced in the [PackageIndex].  It is an index into
 * [strings] list.
 */
void setunitUnitUris(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._unitUnitUris = value;
}

PackageIndexBuilder(
        {
    List<idl.IndexSyntheticElementKind> elementKinds,
   List< int > elementNameClassMemberIds,
      List<int> elementNameParameterIds,
      List< int > elementNameUnitMemberIds,
      List<int> elementUnits,
      List< String > strings,
      List<int> unitLibraryUris,
      List< UnitIndexBuilder > units,
      List<int> unitUnitUris)
      : _elementKinds = elementKinds,
        _elementNameClassMemberIds = elementNameClassMemberIds,
        _elementNameParameterIds = elementNameParameterIds,
        _elementNameUnitMemberIds = elementNameUnitMemberIds,
        _elementUnits = elementUnits,
        _strings = strings,
        _unitLibraryUris = unitLibraryUris,
        _units = units,
        _unitUnitUris = unitUnitUris;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _units?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._elementUnits == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._elementUnits.length);
            foreach (var x in this._elementUnits)
            {
                signature.addInt(x);
            }
        }
        if (this._elementNameUnitMemberIds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._elementNameUnitMemberIds.length);
            foreach (var x in this._elementNameUnitMemberIds)
            {
                signature.addInt(x);
            }
        }
        if (this._unitLibraryUris == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._unitLibraryUris.length);
            foreach (var x in this._unitLibraryUris)
            {
                signature.addInt(x);
            }
        }
        if (this._unitUnitUris == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._unitUnitUris.length);
            foreach (var x in this._unitUnitUris)
            {
                signature.addInt(x);
            }
        }
        if (this._units == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._units.length);
            foreach (var x in this._units)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._elementKinds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._elementKinds.length);
            foreach (var x in this._elementKinds)
            {
                signature.addInt(x.index);
            }
        }
        if (this._strings == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._strings.length);
            foreach (var x in this._strings)
            {
                signature.addString(x);
            }
        }
        if (this._elementNameClassMemberIds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._elementNameClassMemberIds.length);
            foreach (var x in this._elementNameClassMemberIds)
            {
                signature.addInt(x);
            }
        }
        if (this._elementNameParameterIds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._elementNameParameterIds.length);
            foreach (var x in this._elementNameParameterIds)
            {
                signature.addInt(x);
            }
        }
    }

    List<int> toBuffer()
    {
        fb.Builder fbBuilder = new fb.Builder();
        return fbBuilder.finish(finish(fbBuilder), "Indx");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_elementKinds;
        fb.Offset offset_elementNameClassMemberIds;
        fb.Offset offset_elementNameParameterIds;
        fb.Offset offset_elementNameUnitMemberIds;
        fb.Offset offset_elementUnits;
        fb.Offset offset_strings;
        fb.Offset offset_unitLibraryUris;
        fb.Offset offset_units;
        fb.Offset offset_unitUnitUris;
        if (!(_elementKinds == null || _elementKinds.isEmpty))
        {
            offset_elementKinds =
                fbBuilder.writeListUint8(_elementKinds.map((b) => b.index).toList());
        }
        if (!(_elementNameClassMemberIds == null ||
            _elementNameClassMemberIds.isEmpty))
        {
            offset_elementNameClassMemberIds =
                fbBuilder.writeListUint32(_elementNameClassMemberIds);
        }
        if (!(_elementNameParameterIds == null ||
            _elementNameParameterIds.isEmpty))
        {
            offset_elementNameParameterIds =
                fbBuilder.writeListUint32(_elementNameParameterIds);
        }
        if (!(_elementNameUnitMemberIds == null ||
            _elementNameUnitMemberIds.isEmpty))
        {
            offset_elementNameUnitMemberIds =
                fbBuilder.writeListUint32(_elementNameUnitMemberIds);
        }
        if (!(_elementUnits == null || _elementUnits.isEmpty))
        {
            offset_elementUnits = fbBuilder.writeListUint32(_elementUnits);
        }
        if (!(_strings == null || _strings.isEmpty))
        {
            offset_strings = fbBuilder
                .writeList(_strings.map((b) => fbBuilder.writeString(b)).toList());
        }
        if (!(_unitLibraryUris == null || _unitLibraryUris.isEmpty))
        {
            offset_unitLibraryUris = fbBuilder.writeListUint32(_unitLibraryUris);
        }
        if (!(_units == null || _units.isEmpty))
        {
            offset_units =
                fbBuilder.writeList(_units.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_unitUnitUris == null || _unitUnitUris.isEmpty))
        {
            offset_unitUnitUris = fbBuilder.writeListUint32(_unitUnitUris);
        }
        fbBuilder.startTable();
        if (offset_elementKinds != null)
        {
            fbBuilder.addOffset(5, offset_elementKinds);
        }
        if (offset_elementNameClassMemberIds != null)
        {
            fbBuilder.addOffset(7, offset_elementNameClassMemberIds);
        }
        if (offset_elementNameParameterIds != null)
        {
            fbBuilder.addOffset(8, offset_elementNameParameterIds);
        }
        if (offset_elementNameUnitMemberIds != null)
        {
            fbBuilder.addOffset(1, offset_elementNameUnitMemberIds);
        }
        if (offset_elementUnits != null)
        {
            fbBuilder.addOffset(0, offset_elementUnits);
        }
        if (offset_strings != null)
        {
            fbBuilder.addOffset(6, offset_strings);
        }
        if (offset_unitLibraryUris != null)
        {
            fbBuilder.addOffset(2, offset_unitLibraryUris);
        }
        if (offset_units != null)
        {
            fbBuilder.addOffset(4, offset_units);
        }
        if (offset_unitUnitUris != null)
        {
            fbBuilder.addOffset(3, offset_unitUnitUris);
        }
        return fbBuilder.endTable();
    }
}

idl.PackageIndex readPackageIndex(List<int> buffer)
{
    fb.BufferContext rootRef = new fb.BufferContext.fromBytes(buffer);
    return new _PackageIndexReader().read(rootRef, 0);
}
public class _PackageIndexReader : fb.TableReader<_PackageIndexImpl>
{
    public _PackageIndexReader();

    ////@override
    _PackageIndexImpl createObject(fb.BufferContext bc, int offset) =>
      new _PackageIndexImpl(bc, offset);
}
public class _PackageIndexImpl : Object
    with _PackageIndexMixin
    : idl.PackageIndex
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _PackageIndexImpl(this._bc, this._bcOffset);

    List<idl.IndexSyntheticElementKind> _elementKinds;
    List<int> _elementNameClassMemberIds;
    List<int> _elementNameParameterIds;
    List<int> _elementNameUnitMemberIds;
    List<int> _elementUnits;
    List<String> _strings;
    List<int> _unitLibraryUris;
    List<idl.UnitIndex> _units;
    List<int> _unitUnitUris;

    ////@override
    List<idl.IndexSyntheticElementKind> get elementKinds {
        _elementKinds ??= new fb.ListReader<idl.IndexSyntheticElementKind>(
public _IndexSyntheticElementKindReader())
        .vTableGet(_bc, _bcOffset, 5, new List<idl.IndexSyntheticElementKind>{);
        return _elementKinds;
    }

////@override
List<int> get elementNameClassMemberIds {
        _elementNameClassMemberIds ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 7, new List<int>{);
        return _elementNameClassMemberIds;
    }

    ////@override
    List<int> get elementNameParameterIds {
        _elementNameParameterIds ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 8, new List<int>{);
        return _elementNameParameterIds;
    }

    ////@override
    List<int> get elementNameUnitMemberIds {
        _elementNameUnitMemberIds ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 1, new List<int>{);
        return _elementNameUnitMemberIds;
    }

    ////@override
    List<int> get elementUnits {
        _elementUnits ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 0, new List<int>{);
        return _elementUnits;
    }

    ////@override
    List<String> get strings {
        _strings ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 6, new List<String>{);
        return _strings;
    }

    ////@override
    List<int> get unitLibraryUris {
        _unitLibraryUris ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 2, new List<int>{);
        return _unitLibraryUris;
    }

    ////@override
    List<idl.UnitIndex> get units {
        _units ??= new fb.ListReader<idl.UnitIndex>(const _UnitIndexReader())
        .vTableGet(_bc, _bcOffset, 4, new List<idl.UnitIndex>{);
        return _units;
    }

    ////@override
    List<int> get unitUnitUris {
        _unitUnitUris ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 3, new List<int>{);
        return _unitUnitUris;
    }
    }
public abstract class _PackageIndexMixin : idl.PackageIndex
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (elementKinds.isNotEmpty)
            _result["elementKinds"] = elementKinds
                .map((_value) => _value.toString().split(".")[1])
                .toList();
        if (elementNameClassMemberIds.isNotEmpty)
            _result["elementNameClassMemberIds"] = elementNameClassMemberIds;
        if (elementNameParameterIds.isNotEmpty)
            _result["elementNameParameterIds"] = elementNameParameterIds;
        if (elementNameUnitMemberIds.isNotEmpty)
            _result["elementNameUnitMemberIds"] = elementNameUnitMemberIds;
        if (elementUnits.isNotEmpty) _result["elementUnits"] = elementUnits;
        if (strings.isNotEmpty) _result["strings"] = strings;
        if (unitLibraryUris.isNotEmpty)
            _result["unitLibraryUris"] = unitLibraryUris;
        if (units.isNotEmpty)
            _result["units"] = units.map((_value) => _value.toJson()).toList();
        if (unitUnitUris.isNotEmpty) _result["unitUnitUris"] = unitUnitUris;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "elementKinds": elementKinds,
        "elementNameClassMemberIds": elementNameClassMemberIds,
        "elementNameParameterIds": elementNameParameterIds,
        "elementNameUnitMemberIds": elementNameUnitMemberIds,
        "elementUnits": elementUnits,
        "strings": strings,
        "unitLibraryUris": unitLibraryUris,
        "units": units,
        "unitUnitUris": unitUnitUris,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class TopLevelInferenceErrorBuilder : Object
    with _TopLevelInferenceErrorMixin
    : idl.TopLevelInferenceError
{
    List<String> _arguments;
    idl.TopLevelInferenceErrorKind _kind;
    int _slot;

    ////@override
    public List<String> arguments
    {
        get => _arguments ??= new Dictionary<String> { };
    }

    /**
     * The [kind] specific arguments.
     */
    void setarguments(List<String> value)
    {
        this._arguments = value;
    }

    ////@override
    idl.TopLevelInferenceErrorKind get kind =>
        _kind ??= idl.TopLevelInferenceErrorKind.assignment;

    /**
     * The kind of the error.
     */
    void setkind(idl.TopLevelInferenceErrorKind value)
    {
        this._kind = value;
    }

    ////@override
    public int slot
    {
        get => _slot ??= 0;
    }

    /**
     * The slot id (which is unique within the compilation unit) identifying the
     * target of type inference with which this [TopLevelInferenceError] is
     * associated.
     */
    void setslot(int value)
    {
        assert(value == null || value >= 0);
        this._slot = value;
    }

    TopLevelInferenceErrorBuilder(
        {
        List<String> arguments, idl.TopLevelInferenceErrorKind kind, int slot)
      : _arguments = arguments,
        _kind = kind,
        _slot = slot;

        /**
         * Flush [informative] data recursively.
         */
        void flushInformative() { }

        /**
         * Accumulate non-[informative] data into [signature].
         */
        void collectApiSignature(api_sig.ApiSignature signature)
        {
            signature.addInt(this._slot ?? 0);
            signature.addInt(this._kind == null ? 0 : this._kind.index);
            if (this._arguments == null)
            {
                signature.addInt(0);
            }
            else
            {
                signature.addInt(this._arguments.length);
                foreach (var x in this._arguments)
                {
                    signature.addString(x);
                }
            }
        }

        fb.Offset finish(fb.Builder fbBuilder)
        {
            fb.Offset offset_arguments;
            if (!(_arguments == null || _arguments.isEmpty))
            {
                offset_arguments = fbBuilder
                    .writeList(_arguments.map((b) => fbBuilder.writeString(b)).toList());
            }
            fbBuilder.startTable();
            if (offset_arguments != null)
            {
                fbBuilder.addOffset(2, offset_arguments);
            }
            if (_kind != null && _kind != idl.TopLevelInferenceErrorKind.assignment)
            {
                fbBuilder.addUint8(1, _kind.index);
            }
            if (_slot != null && _slot != 0)
            {
                fbBuilder.addUint32(0, _slot);
            }
            return fbBuilder.endTable();
        }
    }
    public class _TopLevelInferenceErrorReader
        : fb.TableReader<_TopLevelInferenceErrorImpl>
    {
        public _TopLevelInferenceErrorReader();

        ////@override
        _TopLevelInferenceErrorImpl createObject(fb.BufferContext bc, int offset) =>
          new _TopLevelInferenceErrorImpl(bc, offset);
    }
    public class _TopLevelInferenceErrorImpl : Object
    
        with _TopLevelInferenceErrorMixin
    : idl.TopLevelInferenceError
    {
        public readonly fb.BufferContext _bc;
        public readonly int _bcOffset;

        _TopLevelInferenceErrorImpl(this._bc, this._bcOffset);

        List<String> _arguments;
        idl.TopLevelInferenceErrorKind _kind;
        int _slot;

        ////@override
        List<String> get arguments {
        _arguments ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 2, new List<String>{);
        return _arguments;
    }

    ////@override
    idl.TopLevelInferenceErrorKind get kind {
        _kind ??= new _TopLevelInferenceErrorKindReader().vTableGet(
            _bc, _bcOffset, 1, idl.TopLevelInferenceErrorKind.assignment);
        return _kind;
    }

////@override
int get slot {
        _slot ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _slot;
    }
    }
public abstract class _TopLevelInferenceErrorMixin
    : idl.TopLevelInferenceError
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (arguments.isNotEmpty) _result["arguments"] = arguments;
        if (kind != idl.TopLevelInferenceErrorKind.assignment)
            _result["kind"] = kind.toString().split(".")[1];
        if (slot != 0) _result["slot"] = slot;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "arguments": arguments,
        "kind": kind,
        "slot": slot,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnitIndexBuilder : Object
    with _UnitIndexMixin
    : idl.UnitIndex
{
    List<idl.IndexNameKind> _definedNameKinds;
    List<int> _definedNameOffsets;
    List<int> _definedNames;
    int _unit;
    List<bool> _usedElementIsQualifiedFlags;
    List<idl.IndexRelationKind> _usedElementKinds;
    List<int> _usedElementLengths;
    List<int> _usedElementOffsets;
    List<int> _usedElements;
    List<bool> _usedNameIsQualifiedFlags;
    List<idl.IndexRelationKind> _usedNameKinds;
    List<int> _usedNameOffsets;
    List<int> _usedNames;

    ////@override
    List<idl.IndexNameKind> get definedNameKinds =>
        _definedNameKinds ??= new Dictionary<idl.IndexNameKind>{};

/**
 * Each item of this list is the kind of an element defined in this unit.
 */
void setdefinedNameKinds(List<idl.IndexNameKind> value)
{
    this._definedNameKinds = value;
}

////@override
public List<int> definedNameOffsets
{
    get => _definedNameOffsets ??= new List<int> { };
}

/**
 * Each item of this list is the name offset of an element defined in this
 * unit relative to the beginning of the file.
 */
void setdefinedNameOffsets(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._definedNameOffsets = value;
}

////@override
public List<int> definedNames
{
    get => _definedNames ??= new List<int> { };
}

/**
 * Each item of this list corresponds to an element defined in this unit.  It
 * is an index into [PackageIndex.strings] list.  The list is sorted in
 * ascending order, so that the client can quickly find name definitions in
 * this [UnitIndex].
 */
void setdefinedNames(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._definedNames = value;
}

////@override
public int unit
{
    get => _unit ??= 0;
}

/**
 * Index into [PackageIndex.unitLibraryUris] and [PackageIndex.unitUnitUris]
 * for the library specific unit that corresponds to this [UnitIndex].
 */
void setunit(int value)
{
    assert(value == null || value >= 0);
    this._unit = value;
}

////@override
List<bool> get usedElementIsQualifiedFlags =>
        _usedElementIsQualifiedFlags ??= new Dictionary<bool>{};

    /**
     * Each item of this list is the `true` if the corresponding element usage
     * is qualified with some prefix.
     */
    void setusedElementIsQualifiedFlags(List<bool> value)
{
    this._usedElementIsQualifiedFlags = value;
}

////@override
List<idl.IndexRelationKind> get usedElementKinds =>
        _usedElementKinds ??= new List<idl.IndexRelationKind>{};

    /**
     * Each item of this list is the kind of the element usage.
     */
    void setusedElementKinds(List<idl.IndexRelationKind> value)
{
    this._usedElementKinds = value;
}

////@override
public List<int> usedElementLengths
{
    get => _usedElementLengths ??= new List<int> { };
}

/**
 * Each item of this list is the length of the element usage.
 */
void setusedElementLengths(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._usedElementLengths = value;
}

////@override
public List<int> usedElementOffsets
{
    get => _usedElementOffsets ??= new List<int> { };
}

/**
 * Each item of this list is the offset of the element usage relative to the
 * beginning of the file.
 */
void setusedElementOffsets(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._usedElementOffsets = value;
}

////@override
public List<int> usedElements
{
    get => _usedElements ??= new List<int> { };
}

/**
 * Each item of this list is the index into [PackageIndex.elementUnits] and
 * [PackageIndex.elementOffsets].  The list is sorted in ascending order, so
 * that the client can quickly find element references in this [UnitIndex].
 */
void setusedElements(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._usedElements = value;
}

////@override
List<bool> get usedNameIsQualifiedFlags =>
        _usedNameIsQualifiedFlags ??= new Dictionary<bool>{};

    /**
     * Each item of this list is the `true` if the corresponding name usage
     * is qualified with some prefix.
     */
    void setusedNameIsQualifiedFlags(List<bool> value)
{
    this._usedNameIsQualifiedFlags = value;
}

////@override
List<idl.IndexRelationKind> get usedNameKinds =>
        _usedNameKinds ??= new List<idl.IndexRelationKind>{};

    /**
     * Each item of this list is the kind of the name usage.
     */
    void setusedNameKinds(List<idl.IndexRelationKind> value)
{
    this._usedNameKinds = value;
}

////@override
public List<int> usedNameOffsets
{
    get => _usedNameOffsets ??= new List<int> { };
}

/**
 * Each item of this list is the offset of the name usage relative to the
 * beginning of the file.
 */
void setusedNameOffsets(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._usedNameOffsets = value;
}

////@override
public List<int> usedNames
{
    get => _usedNames ??= new List<int> { };
}

/**
 * Each item of this list is the index into [PackageIndex.strings] for a
 * used name.  The list is sorted in ascending order, so that the client can
 * quickly find name uses in this [UnitIndex].
 */
void setusedNames(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._usedNames = value;
}

UnitIndexBuilder(
        {
    List<idl.IndexNameKind> definedNameKinds,
   List< int > definedNameOffsets,
      List<int> definedNames,
      int unit,
      List< bool > usedElementIsQualifiedFlags,
      List<idl.IndexRelationKind> usedElementKinds,
      List< int > usedElementLengths,
      List<int> usedElementOffsets,
      List< int > usedElements,
      List<bool> usedNameIsQualifiedFlags,
      List< idl.IndexRelationKind > usedNameKinds,
      List<int> usedNameOffsets,
      List< int > usedNames)
      : _definedNameKinds = definedNameKinds,
        _definedNameOffsets = definedNameOffsets,
        _definedNames = definedNames,
        _unit = unit,
        _usedElementIsQualifiedFlags = usedElementIsQualifiedFlags,
        _usedElementKinds = usedElementKinds,
        _usedElementLengths = usedElementLengths,
        _usedElementOffsets = usedElementOffsets,
        _usedElements = usedElements,
        _usedNameIsQualifiedFlags = usedNameIsQualifiedFlags,
        _usedNameKinds = usedNameKinds,
        _usedNameOffsets = usedNameOffsets,
        _usedNames = usedNames;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative() { }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addInt(this._unit ?? 0);
        if (this._usedElementLengths == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedElementLengths.length);
            foreach (var x in this._usedElementLengths)
            {
                signature.addInt(x);
            }
        }
        if (this._usedElementOffsets == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedElementOffsets.length);
            foreach (var x in this._usedElementOffsets)
            {
                signature.addInt(x);
            }
        }
        if (this._usedElements == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedElements.length);
            foreach (var x in this._usedElements)
            {
                signature.addInt(x);
            }
        }
        if (this._usedElementKinds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedElementKinds.length);
            foreach (var x in this._usedElementKinds)
            {
                signature.addInt(x.index);
            }
        }
        if (this._definedNames == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._definedNames.length);
            foreach (var x in this._definedNames)
            {
                signature.addInt(x);
            }
        }
        if (this._definedNameKinds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._definedNameKinds.length);
            foreach (var x in this._definedNameKinds)
            {
                signature.addInt(x.index);
            }
        }
        if (this._definedNameOffsets == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._definedNameOffsets.length);
            foreach (var x in this._definedNameOffsets)
            {
                signature.addInt(x);
            }
        }
        if (this._usedNames == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedNames.length);
            foreach (var x in this._usedNames)
            {
                signature.addInt(x);
            }
        }
        if (this._usedNameOffsets == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedNameOffsets.length);
            foreach (var x in this._usedNameOffsets)
            {
                signature.addInt(x);
            }
        }
        if (this._usedNameKinds == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedNameKinds.length);
            foreach (var x in this._usedNameKinds)
            {
                signature.addInt(x.index);
            }
        }
        if (this._usedElementIsQualifiedFlags == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedElementIsQualifiedFlags.length);
            foreach (var x in this._usedElementIsQualifiedFlags)
            {
                signature.addBool(x);
            }
        }
        if (this._usedNameIsQualifiedFlags == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._usedNameIsQualifiedFlags.length);
            foreach (var x in this._usedNameIsQualifiedFlags)
            {
                signature.addBool(x);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_definedNameKinds;
        fb.Offset offset_definedNameOffsets;
        fb.Offset offset_definedNames;
        fb.Offset offset_usedElementIsQualifiedFlags;
        fb.Offset offset_usedElementKinds;
        fb.Offset offset_usedElementLengths;
        fb.Offset offset_usedElementOffsets;
        fb.Offset offset_usedElements;
        fb.Offset offset_usedNameIsQualifiedFlags;
        fb.Offset offset_usedNameKinds;
        fb.Offset offset_usedNameOffsets;
        fb.Offset offset_usedNames;
        if (!(_definedNameKinds == null || _definedNameKinds.isEmpty))
        {
            offset_definedNameKinds = fbBuilder
                .writeListUint8(_definedNameKinds.map((b) => b.index).toList());
        }
        if (!(_definedNameOffsets == null || _definedNameOffsets.isEmpty))
        {
            offset_definedNameOffsets =
                fbBuilder.writeListUint32(_definedNameOffsets);
        }
        if (!(_definedNames == null || _definedNames.isEmpty))
        {
            offset_definedNames = fbBuilder.writeListUint32(_definedNames);
        }
        if (!(_usedElementIsQualifiedFlags == null ||
            _usedElementIsQualifiedFlags.isEmpty))
        {
            offset_usedElementIsQualifiedFlags =
                fbBuilder.writeListBool(_usedElementIsQualifiedFlags);
        }
        if (!(_usedElementKinds == null || _usedElementKinds.isEmpty))
        {
            offset_usedElementKinds = fbBuilder
                .writeListUint8(_usedElementKinds.map((b) => b.index).toList());
        }
        if (!(_usedElementLengths == null || _usedElementLengths.isEmpty))
        {
            offset_usedElementLengths =
                fbBuilder.writeListUint32(_usedElementLengths);
        }
        if (!(_usedElementOffsets == null || _usedElementOffsets.isEmpty))
        {
            offset_usedElementOffsets =
                fbBuilder.writeListUint32(_usedElementOffsets);
        }
        if (!(_usedElements == null || _usedElements.isEmpty))
        {
            offset_usedElements = fbBuilder.writeListUint32(_usedElements);
        }
        if (!(_usedNameIsQualifiedFlags == null ||
            _usedNameIsQualifiedFlags.isEmpty))
        {
            offset_usedNameIsQualifiedFlags =
                fbBuilder.writeListBool(_usedNameIsQualifiedFlags);
        }
        if (!(_usedNameKinds == null || _usedNameKinds.isEmpty))
        {
            offset_usedNameKinds =
                fbBuilder.writeListUint8(_usedNameKinds.map((b) => b.index).toList());
        }
        if (!(_usedNameOffsets == null || _usedNameOffsets.isEmpty))
        {
            offset_usedNameOffsets = fbBuilder.writeListUint32(_usedNameOffsets);
        }
        if (!(_usedNames == null || _usedNames.isEmpty))
        {
            offset_usedNames = fbBuilder.writeListUint32(_usedNames);
        }
        fbBuilder.startTable();
        if (offset_definedNameKinds != null)
        {
            fbBuilder.addOffset(6, offset_definedNameKinds);
        }
        if (offset_definedNameOffsets != null)
        {
            fbBuilder.addOffset(7, offset_definedNameOffsets);
        }
        if (offset_definedNames != null)
        {
            fbBuilder.addOffset(5, offset_definedNames);
        }
        if (_unit != null && _unit != 0)
        {
            fbBuilder.addUint32(0, _unit);
        }
        if (offset_usedElementIsQualifiedFlags != null)
        {
            fbBuilder.addOffset(11, offset_usedElementIsQualifiedFlags);
        }
        if (offset_usedElementKinds != null)
        {
            fbBuilder.addOffset(4, offset_usedElementKinds);
        }
        if (offset_usedElementLengths != null)
        {
            fbBuilder.addOffset(1, offset_usedElementLengths);
        }
        if (offset_usedElementOffsets != null)
        {
            fbBuilder.addOffset(2, offset_usedElementOffsets);
        }
        if (offset_usedElements != null)
        {
            fbBuilder.addOffset(3, offset_usedElements);
        }
        if (offset_usedNameIsQualifiedFlags != null)
        {
            fbBuilder.addOffset(12, offset_usedNameIsQualifiedFlags);
        }
        if (offset_usedNameKinds != null)
        {
            fbBuilder.addOffset(10, offset_usedNameKinds);
        }
        if (offset_usedNameOffsets != null)
        {
            fbBuilder.addOffset(9, offset_usedNameOffsets);
        }
        if (offset_usedNames != null)
        {
            fbBuilder.addOffset(8, offset_usedNames);
        }
        return fbBuilder.endTable();
    }
}
public class _UnitIndexReader : fb.TableReader<_UnitIndexImpl>
{
    public _UnitIndexReader();

    ////@override
    _UnitIndexImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnitIndexImpl(bc, offset);
}
public class _UnitIndexImpl : Object
    with _UnitIndexMixin
    : idl.UnitIndex
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnitIndexImpl(this._bc, this._bcOffset);

    List<idl.IndexNameKind> _definedNameKinds;
    List<int> _definedNameOffsets;
    List<int> _definedNames;
    int _unit;
    List<bool> _usedElementIsQualifiedFlags;
    List<idl.IndexRelationKind> _usedElementKinds;
    List<int> _usedElementLengths;
    List<int> _usedElementOffsets;
    List<int> _usedElements;
    List<bool> _usedNameIsQualifiedFlags;
    List<idl.IndexRelationKind> _usedNameKinds;
    List<int> _usedNameOffsets;
    List<int> _usedNames;

    ////@override
    List<idl.IndexNameKind> get definedNameKinds {
        _definedNameKinds ??=
public fb.ListReader<idl.IndexNameKind>(const _IndexNameKindReader())
            .vTableGet(_bc, _bcOffset, 6, new List<idl.IndexNameKind>{);
        return _definedNameKinds;
    }

////@override
List<int> get definedNameOffsets {
        _definedNameOffsets ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 7, new List<int>{);
        return _definedNameOffsets;
    }

    ////@override
    List<int> get definedNames {
        _definedNames ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 5, new List<int>{);
        return _definedNames;
    }

    ////@override
    int get unit {
        _unit ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _unit;
    }

    ////@override
    List<bool> get usedElementIsQualifiedFlags {
        _usedElementIsQualifiedFlags ??=
public fb.BoolListReader().vTableGet(_bc, _bcOffset, 11, new List<bool>{);
        return _usedElementIsQualifiedFlags;
    }

    ////@override
    List<idl.IndexRelationKind> get usedElementKinds {
        _usedElementKinds ??= new fb.ListReader<idl.IndexRelationKind>(
public _IndexRelationKindReader())
        .vTableGet(_bc, _bcOffset, 4, new List<idl.IndexRelationKind>{);
        return _usedElementKinds;
    }

    ////@override
    List<int> get usedElementLengths {
        _usedElementLengths ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 1, new List<int>{);
        return _usedElementLengths;
    }

    ////@override
    List<int> get usedElementOffsets {
        _usedElementOffsets ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 2, new List<int>{);
        return _usedElementOffsets;
    }

    ////@override
    List<int> get usedElements {
        _usedElements ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 3, new List<int>{);
        return _usedElements;
    }

    ////@override
    List<bool> get usedNameIsQualifiedFlags {
        _usedNameIsQualifiedFlags ??=
public fb.BoolListReader().vTableGet(_bc, _bcOffset, 12, new List<bool>{);
        return _usedNameIsQualifiedFlags;
    }

    ////@override
    List<idl.IndexRelationKind> get usedNameKinds {
        _usedNameKinds ??= new fb.ListReader<idl.IndexRelationKind>(
public _IndexRelationKindReader())
        .vTableGet(_bc, _bcOffset, 10, new List<idl.IndexRelationKind>{);
        return _usedNameKinds;
    }

    ////@override
    List<int> get usedNameOffsets {
        _usedNameOffsets ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 9, new List<int>{);
        return _usedNameOffsets;
    }

    ////@override
    List<int> get usedNames {
        _usedNames ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 8, new List<int>{);
        return _usedNames;
    }
    }
public abstract class _UnitIndexMixin : idl.UnitIndex
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (definedNameKinds.isNotEmpty)
            _result["definedNameKinds"] = definedNameKinds
                .map((_value) => _value.toString().split(".")[1])
                .toList();
        if (definedNameOffsets.isNotEmpty)
            _result["definedNameOffsets"] = definedNameOffsets;
        if (definedNames.isNotEmpty) _result["definedNames"] = definedNames;
        if (unit != 0) _result["unit"] = unit;
        if (usedElementIsQualifiedFlags.isNotEmpty)
            _result["usedElementIsQualifiedFlags"] = usedElementIsQualifiedFlags;
        if (usedElementKinds.isNotEmpty)
            _result["usedElementKinds"] = usedElementKinds
                .map((_value) => _value.toString().split(".")[1])
                .toList();
        if (usedElementLengths.isNotEmpty)
            _result["usedElementLengths"] = usedElementLengths;
        if (usedElementOffsets.isNotEmpty)
            _result["usedElementOffsets"] = usedElementOffsets;
        if (usedElements.isNotEmpty) _result["usedElements"] = usedElements;
        if (usedNameIsQualifiedFlags.isNotEmpty)
            _result["usedNameIsQualifiedFlags"] = usedNameIsQualifiedFlags;
        if (usedNameKinds.isNotEmpty)
            _result["usedNameKinds"] = usedNameKinds
                .map((_value) => _value.toString().split(".")[1])
                .toList();
        if (usedNameOffsets.isNotEmpty)
            _result["usedNameOffsets"] = usedNameOffsets;
        if (usedNames.isNotEmpty) _result["usedNames"] = usedNames;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "definedNameKinds": definedNameKinds,
        "definedNameOffsets": definedNameOffsets,
        "definedNames": definedNames,
        "unit": unit,
        "usedElementIsQualifiedFlags": usedElementIsQualifiedFlags,
        "usedElementKinds": usedElementKinds,
        "usedElementLengths": usedElementLengths,
        "usedElementOffsets": usedElementOffsets,
        "usedElements": usedElements,
        "usedNameIsQualifiedFlags": usedNameIsQualifiedFlags,
        "usedNameKinds": usedNameKinds,
        "usedNameOffsets": usedNameOffsets,
        "usedNames": usedNames,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedClassBuilder : Object
    with _UnlinkedClassMixin
    : idl.UnlinkedClass
{
    List<UnlinkedExprBuilder> _annotations;
    CodeRangeBuilder _codeRange;
    UnlinkedDocumentationCommentBuilder _documentationComment;
    List<UnlinkedExecutableBuilder> _executables;
    List<UnlinkedVariableBuilder> _fields;
    bool _hasNoSupertype;
    List<EntityRefBuilder> _interfaces;
    bool _isAbstract;
    bool _isMixinApplication;
    List<EntityRefBuilder> _mixins;
    String _name;
    int _nameOffset;
    List<EntityRefBuilder> _superclassConstraints;
    List<String> _superInvokedNames;
    EntityRefBuilder _supertype;
    List<UnlinkedTypeParamBuilder> _typeParameters;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this class.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
public CodeRangeBuilder codeRange
{
    get => _codeRange;
}

/**
 * Code range of the class.
 */
void setcodeRange(CodeRangeBuilder value)
{
    this._codeRange = value;
}

////@override
UnlinkedDocumentationCommentBuilder get documentationComment =>
      _documentationComment;

    /**
     * Documentation comment for the class, or `null` if there is no
     * documentation comment.
     */
    void setdocumentationComment(UnlinkedDocumentationCommentBuilder value)
{
    this._documentationComment = value;
}

////@override
List<UnlinkedExecutableBuilder> get executables =>
        _executables ??= new Dictionary<UnlinkedExecutableBuilder>{};

    /**
     * Executable objects (methods, getters, and setters) contained in the class.
     */
    void setexecutables(List<UnlinkedExecutableBuilder> value)
{
    this._executables = value;
}

////@override
List<UnlinkedVariableBuilder> get fields =>
        _fields ??= new Dictionary<UnlinkedVariableBuilder>{};

    /**
     * Field declarations contained in the class.
     */
    void setfields(List<UnlinkedVariableBuilder> value)
{
    this._fields = value;
}

////@override
public bool hasNoSupertype
{
    get => _hasNoSupertype ??= false;
}

/**
 * Indicates whether this class is the core "Object" class (and hence has no
 * supertype)
 */
void sethasNoSupertype(bool value)
{
    this._hasNoSupertype = value;
}

////@override
public List<EntityRefBuilder> interfaces
{
    get => _interfaces ??= new List<EntityRefBuilder> { };
}

/**
 * Interfaces appearing in an `implements` clause, if any.
 */
void setinterfaces(List<EntityRefBuilder> value)
{
    this._interfaces = value;
}

////@override
public bool isAbstract
{
    get => _isAbstract ??= false;
}

/**
 * Indicates whether the class is declared with the `abstract` keyword.
 */
void setisAbstract(bool value)
{
    this._isAbstract = value;
}

////@override
public bool isMixinApplication
{
    get => _isMixinApplication ??= false;
}

/**
 * Indicates whether the class is declared using mixin application syntax.
 */
void setisMixinApplication(bool value)
{
    this._isMixinApplication = value;
}

////@override
public List<EntityRefBuilder> mixins
{
    get => _mixins ??= new Dictionary<EntityRefBuilder> { };
}

/**
 * Mixins appearing in a `with` clause, if any.
 */
void setmixins(List<EntityRefBuilder> value)
{
    this._mixins = value;
}

////@override
public String name
{
    get => _name ??= "";
}

/**
 * Name of the class.
 */
void setname(String value)
{
    this._name = value;
}

////@override
public int nameOffset
{
    get => _nameOffset ??= 0;
}

/**
 * Offset of the class name relative to the beginning of the file.
 */
void setnameOffset(int value)
{
    assert(value == null || value >= 0);
    this._nameOffset = value;
}

////@override
List<EntityRefBuilder> get superclassConstraints =>
        _superclassConstraints ??= new Dictionary<EntityRefBuilder>{};

    /**
     * Superclass constraints for this mixin declaration. The list will be empty
     * if this class is not a mixin declaration, or if the declaration does not
     * have an `on` clause (in which case the type `Object` is implied).
     */
    void setsuperclassConstraints(List<EntityRefBuilder> value)
{
    this._superclassConstraints = value;
}

////@override
public List<String> superInvokedNames
{
    get => _superInvokedNames ??= new Dictionary<String> { };
}

/**
 * Names of methods, getters, setters, and operators that this mixin
 * declaration super-invokes.  For setters this includes the trailing "=".
 * The list will be empty if this class is not a mixin declaration.
 */
void setsuperInvokedNames(List<String> value)
{
    this._superInvokedNames = value;
}

////@override
public EntityRefBuilder supertype
{
    get => _supertype;
}

/**
 * Supertype of the class, or `null` if either (a) the class doesn't
 * explicitly declare a supertype (and hence has supertype `Object`), or (b)
 * the class *is* `Object` (and hence has no supertype).
 */
void setsupertype(EntityRefBuilder value)
{
    this._supertype = value;
}

////@override
List<UnlinkedTypeParamBuilder> get typeParameters =>
        _typeParameters ??= new Dictionary<UnlinkedTypeParamBuilder>{};

    /**
     * Type parameters of the class, if any.
     */
    void settypeParameters(List<UnlinkedTypeParamBuilder> value)
{
    this._typeParameters = value;
}

UnlinkedClassBuilder(
        {
    List<UnlinkedExprBuilder> annotations,
   CodeRangeBuilder codeRange,
      UnlinkedDocumentationCommentBuilder documentationComment,
      List< UnlinkedExecutableBuilder > executables,
      List<UnlinkedVariableBuilder> fields,
      bool hasNoSupertype,
      List< EntityRefBuilder > interfaces,
      bool isAbstract,
      bool isMixinApplication,
      List< EntityRefBuilder > mixins,
      String name,
      int nameOffset,
      List< EntityRefBuilder > superclassConstraints,
      List<String> superInvokedNames,
      EntityRefBuilder supertype,
      List<UnlinkedTypeParamBuilder> typeParameters)
      : _annotations = annotations,
        _codeRange = codeRange,
        _documentationComment = documentationComment,
        _executables = executables,
        _fields = fields,
        _hasNoSupertype = hasNoSupertype,
        _interfaces = interfaces,
        _isAbstract = isAbstract,
        _isMixinApplication = isMixinApplication,
        _mixins = mixins,
        _name = name,
        _nameOffset = nameOffset,
        _superclassConstraints = superclassConstraints,
        _superInvokedNames = superInvokedNames,
        _supertype = supertype,
        _typeParameters = typeParameters;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _codeRange = null;
        _documentationComment = null;
        _executables?.forEach((b) => b.flushInformative());
        _fields?.forEach((b) => b.flushInformative());
        _interfaces?.forEach((b) => b.flushInformative());
        _mixins?.forEach((b) => b.flushInformative());
        _nameOffset = null;
        _superclassConstraints?.forEach((b) => b.flushInformative());
        _supertype?.flushInformative();
        _typeParameters?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        if (this._executables == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._executables.length);
            foreach (var x in this._executables)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._supertype != null);
        this._supertype?.collectApiSignature(signature);
        if (this._fields == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._fields.length);
            foreach (var x in this._fields)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._interfaces == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._interfaces.length);
            foreach (var x in this._interfaces)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._isAbstract == true);
        if (this._typeParameters == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._typeParameters.length);
            foreach (var x in this._typeParameters)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._mixins == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._mixins.length);
            foreach (var x in this._mixins)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._isMixinApplication == true);
        signature.addBool(this._hasNoSupertype == true);
        if (this._superclassConstraints == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._superclassConstraints.length);
            foreach (var x in this._superclassConstraints)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._superInvokedNames == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._superInvokedNames.length);
            foreach (var x in this._superInvokedNames)
            {
                signature.addString(x);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        fb.Offset offset_codeRange;
        fb.Offset offset_documentationComment;
        fb.Offset offset_executables;
        fb.Offset offset_fields;
        fb.Offset offset_interfaces;
        fb.Offset offset_mixins;
        fb.Offset offset_name;
        fb.Offset offset_superclassConstraints;
        fb.Offset offset_superInvokedNames;
        fb.Offset offset_supertype;
        fb.Offset offset_typeParameters;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_codeRange != null)
        {
            offset_codeRange = _codeRange.finish(fbBuilder);
        }
        if (_documentationComment != null)
        {
            offset_documentationComment = _documentationComment.finish(fbBuilder);
        }
        if (!(_executables == null || _executables.isEmpty))
        {
            offset_executables = fbBuilder
                .writeList(_executables.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_fields == null || _fields.isEmpty))
        {
            offset_fields =
                fbBuilder.writeList(_fields.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_interfaces == null || _interfaces.isEmpty))
        {
            offset_interfaces = fbBuilder
                .writeList(_interfaces.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_mixins == null || _mixins.isEmpty))
        {
            offset_mixins =
                fbBuilder.writeList(_mixins.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        if (!(_superclassConstraints == null || _superclassConstraints.isEmpty))
        {
            offset_superclassConstraints = fbBuilder.writeList(
                _superclassConstraints.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_superInvokedNames == null || _superInvokedNames.isEmpty))
        {
            offset_superInvokedNames = fbBuilder.writeList(
                _superInvokedNames.map((b) => fbBuilder.writeString(b)).toList());
        }
        if (_supertype != null)
        {
            offset_supertype = _supertype.finish(fbBuilder);
        }
        if (!(_typeParameters == null || _typeParameters.isEmpty))
        {
            offset_typeParameters = fbBuilder
                .writeList(_typeParameters.map((b) => b.finish(fbBuilder)).toList());
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(5, offset_annotations);
        }
        if (offset_codeRange != null)
        {
            fbBuilder.addOffset(13, offset_codeRange);
        }
        if (offset_documentationComment != null)
        {
            fbBuilder.addOffset(6, offset_documentationComment);
        }
        if (offset_executables != null)
        {
            fbBuilder.addOffset(2, offset_executables);
        }
        if (offset_fields != null)
        {
            fbBuilder.addOffset(4, offset_fields);
        }
        if (_hasNoSupertype == true)
        {
            fbBuilder.addBool(12, true);
        }
        if (offset_interfaces != null)
        {
            fbBuilder.addOffset(7, offset_interfaces);
        }
        if (_isAbstract == true)
        {
            fbBuilder.addBool(8, true);
        }
        if (_isMixinApplication == true)
        {
            fbBuilder.addBool(11, true);
        }
        if (offset_mixins != null)
        {
            fbBuilder.addOffset(10, offset_mixins);
        }
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        if (_nameOffset != null && _nameOffset != 0)
        {
            fbBuilder.addUint32(1, _nameOffset);
        }
        if (offset_superclassConstraints != null)
        {
            fbBuilder.addOffset(14, offset_superclassConstraints);
        }
        if (offset_superInvokedNames != null)
        {
            fbBuilder.addOffset(15, offset_superInvokedNames);
        }
        if (offset_supertype != null)
        {
            fbBuilder.addOffset(3, offset_supertype);
        }
        if (offset_typeParameters != null)
        {
            fbBuilder.addOffset(9, offset_typeParameters);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedClassReader : fb.TableReader<_UnlinkedClassImpl>
{
    public _UnlinkedClassReader();

    ////@override
    _UnlinkedClassImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedClassImpl(bc, offset);
}
public class _UnlinkedClassImpl : Object
    with _UnlinkedClassMixin
    : idl.UnlinkedClass
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedClassImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    idl.CodeRange _codeRange;
    idl.UnlinkedDocumentationComment _documentationComment;
    List<idl.UnlinkedExecutable> _executables;
    List<idl.UnlinkedVariable> _fields;
    bool _hasNoSupertype;
    List<idl.EntityRef> _interfaces;
    bool _isAbstract;
    bool _isMixinApplication;
    List<idl.EntityRef> _mixins;
    String _name;
    int _nameOffset;
    List<idl.EntityRef> _superclassConstraints;
    List<String> _superInvokedNames;
    idl.EntityRef _supertype;
    List<idl.UnlinkedTypeParam> _typeParameters;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 5, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
idl.CodeRange get codeRange {
        _codeRange ??= new _CodeRangeReader().vTableGet(_bc, _bcOffset, 13, null);
        return _codeRange;
    }

    ////@override
    idl.UnlinkedDocumentationComment get documentationComment {
        _documentationComment ??= new _UnlinkedDocumentationCommentReader()
          .vTableGet(_bc, _bcOffset, 6, null);
        return _documentationComment;
    }

    ////@override
    List<idl.UnlinkedExecutable> get executables {
        _executables ??= new fb.ListReader<idl.UnlinkedExecutable>(
public _UnlinkedExecutableReader())
        .vTableGet(_bc, _bcOffset, 2, new List<idl.UnlinkedExecutable>{);
        return _executables;
    }

    ////@override
    List<idl.UnlinkedVariable> get fields {
        _fields ??= new fb.ListReader<idl.UnlinkedVariable>(
public _UnlinkedVariableReader())
        .vTableGet(_bc, _bcOffset, 4, new List<idl.UnlinkedVariable>{);
        return _fields;
    }

    ////@override
    bool get hasNoSupertype {
        _hasNoSupertype ??=
public fb.BoolReader().vTableGet(_bc, _bcOffset, 12, false);
        return _hasNoSupertype;
    }

    ////@override
    List<idl.EntityRef> get interfaces {
        _interfaces ??= new fb.ListReader<idl.EntityRef>(const _EntityRefReader())
        .vTableGet(_bc, _bcOffset, 7, new List<idl.EntityRef>{);
        return _interfaces;
    }

    ////@override
    bool get isAbstract {
        _isAbstract ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 8, false);
        return _isAbstract;
    }

    ////@override
    bool get isMixinApplication {
        _isMixinApplication ??=
public fb.BoolReader().vTableGet(_bc, _bcOffset, 11, false);
        return _isMixinApplication;
    }

    ////@override
    List<idl.EntityRef> get mixins {
        _mixins ??= new fb.ListReader<idl.EntityRef>(const _EntityRefReader())
        .vTableGet(_bc, _bcOffset, 10, new List<idl.EntityRef>{);
        return _mixins;
    }

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }

    ////@override
    int get nameOffset {
        _nameOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _nameOffset;
    }

    ////@override
    List<idl.EntityRef> get superclassConstraints {
        _superclassConstraints ??=
public fb.ListReader<idl.EntityRef>(const _EntityRefReader())
            .vTableGet(_bc, _bcOffset, 14, new List<idl.EntityRef>{);
        return _superclassConstraints;
    }

    ////@override
    List<String> get superInvokedNames {
        _superInvokedNames ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 15, new List<String>{);
        return _superInvokedNames;
    }

    ////@override
    idl.EntityRef get supertype {
        _supertype ??= new _EntityRefReader().vTableGet(_bc, _bcOffset, 3, null);
        return _supertype;
    }

    ////@override
    List<idl.UnlinkedTypeParam> get typeParameters {
        _typeParameters ??= new fb.ListReader<idl.UnlinkedTypeParam>(
public _UnlinkedTypeParamReader())
        .vTableGet(_bc, _bcOffset, 9, new List<idl.UnlinkedTypeParam>{);
        return _typeParameters;
    }
    }
public abstract class _UnlinkedClassMixin : idl.UnlinkedClass
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (codeRange != null) _result["codeRange"] = codeRange.toJson();
        if (documentationComment != null)
            _result["documentationComment"] = documentationComment.toJson();
        if (executables.isNotEmpty)
            _result["executables"] =
                executables.map((_value) => _value.toJson()).toList();
        if (fields.isNotEmpty)
            _result["fields"] = fields.map((_value) => _value.toJson()).toList();
        if (hasNoSupertype != false) _result["hasNoSupertype"] = hasNoSupertype;
        if (interfaces.isNotEmpty)
            _result["interfaces"] =
                interfaces.map((_value) => _value.toJson()).toList();
        if (isAbstract != false) _result["isAbstract"] = isAbstract;
        if (isMixinApplication != false)
            _result["isMixinApplication"] = isMixinApplication;
        if (mixins.isNotEmpty)
            _result["mixins"] = mixins.map((_value) => _value.toJson()).toList();
        if (name != "") _result["name"] = name;
        if (nameOffset != 0) _result["nameOffset"] = nameOffset;
        if (superclassConstraints.isNotEmpty)
            _result["superclassConstraints"] =
                superclassConstraints.map((_value) => _value.toJson()).toList();
        if (superInvokedNames.isNotEmpty)
            _result["superInvokedNames"] = superInvokedNames;
        if (supertype != null) _result["supertype"] = supertype.toJson();
        if (typeParameters.isNotEmpty)
            _result["typeParameters"] =
                typeParameters.map((_value) => _value.toJson()).toList();
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "codeRange": codeRange,
        "documentationComment": documentationComment,
        "executables": executables,
        "fields": fields,
        "hasNoSupertype": hasNoSupertype,
        "interfaces": interfaces,
        "isAbstract": isAbstract,
        "isMixinApplication": isMixinApplication,
        "mixins": mixins,
        "name": name,
        "nameOffset": nameOffset,
        "superclassConstraints": superclassConstraints,
        "superInvokedNames": superInvokedNames,
        "supertype": supertype,
        "typeParameters": typeParameters,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedCombinatorBuilder : Object
    with _UnlinkedCombinatorMixin
    : idl.UnlinkedCombinator
{
    int _end;
    List<String> _hides;
    int _offset;
    List<String> _shows;

    ////@override
    public int end
    {
        get => _end ??= 0;
    }

    /**
     * If this is a `show` combinator, offset of the end of the list of shown
     * names.  Otherwise zero.
     */
    void setend(int value)
    {
        assert(value == null || value >= 0);
        this._end = value;
    }

    ////@override
    public List<String> hides
    {
        get => _hides ??= new Dictionary<String> { };
    }

    /**
     * List of names which are hidden.  Empty if this is a `show` combinator.
     */
    void sethides(List<String> value)
    {
        this._hides = value;
    }

    ////@override
    public int offset
    {
        get => _offset ??= 0;
    }

    /**
     * If this is a `show` combinator, offset of the `show` keyword.  Otherwise
     * zero.
     */
    void setoffset(int value)
    {
        assert(value == null || value >= 0);
        this._offset = value;
    }

    ////@override
    public List<String> shows
    {
        get => _shows ??= new Dictionary<String> { };
    }

    /**
     * List of names which are shown.  Empty if this is a `hide` combinator.
     */
    void setshows(List<String> value)
    {
        this._shows = value;
    }

    UnlinkedCombinatorBuilder(
      {
        int end, List< String > hides, int offset, List< String > shows)
      : _end = end,
        _hides = hides,
        _offset = offset,
        _shows = shows;

        /**
         * Flush [informative] data recursively.
         */
        void flushInformative()
        {
            _end = null;
            _offset = null;
        }

        /**
         * Accumulate non-[informative] data into [signature].
         */
        void collectApiSignature(api_sig.ApiSignature signature)
        {
            if (this._shows == null)
            {
                signature.addInt(0);
            }
            else
            {
                signature.addInt(this._shows.length);
                foreach (var x in this._shows)
                {
                    signature.addString(x);
                }
            }
            if (this._hides == null)
            {
                signature.addInt(0);
            }
            else
            {
                signature.addInt(this._hides.length);
                foreach (var x in this._hides)
                {
                    signature.addString(x);
                }
            }
        }

        fb.Offset finish(fb.Builder fbBuilder)
        {
            fb.Offset offset_hides;
            fb.Offset offset_shows;
            if (!(_hides == null || _hides.isEmpty))
            {
                offset_hides = fbBuilder
                    .writeList(_hides.map((b) => fbBuilder.writeString(b)).toList());
            }
            if (!(_shows == null || _shows.isEmpty))
            {
                offset_shows = fbBuilder
                    .writeList(_shows.map((b) => fbBuilder.writeString(b)).toList());
            }
            fbBuilder.startTable();
            if (_end != null && _end != 0)
            {
                fbBuilder.addUint32(3, _end);
            }
            if (offset_hides != null)
            {
                fbBuilder.addOffset(1, offset_hides);
            }
            if (_offset != null && _offset != 0)
            {
                fbBuilder.addUint32(2, _offset);
            }
            if (offset_shows != null)
            {
                fbBuilder.addOffset(0, offset_shows);
            }
            return fbBuilder.endTable();
        }
    }
    public class _UnlinkedCombinatorReader
        : fb.TableReader<_UnlinkedCombinatorImpl>
    {
        public _UnlinkedCombinatorReader();

        ////@override
        _UnlinkedCombinatorImpl createObject(fb.BufferContext bc, int offset) =>
          new _UnlinkedCombinatorImpl(bc, offset);
    }
    public class _UnlinkedCombinatorImpl : Object
    
        with _UnlinkedCombinatorMixin
    : idl.UnlinkedCombinator
    {
        public readonly fb.BufferContext _bc;
        public readonly int _bcOffset;

        _UnlinkedCombinatorImpl(this._bc, this._bcOffset);

        int _end;
        List<String> _hides;
        int _offset;
        List<String> _shows;

        ////@override
        int get end {
        _end ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 3, 0);
        return _end;
    }

    ////@override
    List<String> get hides {
        _hides ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 1, new List<String>{);
        return _hides;
    }

////@override
int get offset {
        _offset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 2, 0);
        return _offset;
    }

    ////@override
    List<String> get shows {
        _shows ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 0, new List<String>{);
        return _shows;
    }
    }
public abstract class _UnlinkedCombinatorMixin : idl.UnlinkedCombinator
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (end != 0) _result["end"] = end;
        if (hides.isNotEmpty) _result["hides"] = hides;
        if (offset != 0) _result["offset"] = offset;
        if (shows.isNotEmpty) _result["shows"] = shows;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "end": end,
        "hides": hides,
        "offset": offset,
        "shows": shows,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedConfigurationBuilder : Object
    with _UnlinkedConfigurationMixin
    : idl.UnlinkedConfiguration
{
    String _name;
    String _uri;
    String _value;

    ////@override
    public String name
    {
        get => _name ??= "";
    }

    /**
     * The name of the declared variable whose value is being used in the
     * condition.
     */
    void setname(String value)
    {
        this._name = value;
    }

    ////@override
    public String uri
    {
        get => _uri ??= "";
    }

    /**
     * The URI of the implementation library to be used if the condition is true.
     */
    void seturi(String value)
    {
        this._uri = value;
    }

    ////@override
    public String value
    {
        get => _value ??= "";
    }

    /**
     * The value to which the value of the declared variable will be compared,
     * or `true` if the condition does not include an equality test.
     */
    void setvalue(String value)
    {
        this._value = value;
    }

    UnlinkedConfigurationBuilder(String name, String uri, String value)
      : _name = name,
        _uri = uri,
        _value = value;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative() { }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        signature.addString(this._value ?? "");
        signature.addString(this._uri ?? "");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_name;
        fb.Offset offset_uri;
        fb.Offset offset_value;
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        if (_uri != null)
        {
            offset_uri = fbBuilder.writeString(_uri);
        }
        if (_value != null)
        {
            offset_value = fbBuilder.writeString(_value);
        }
        fbBuilder.startTable();
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        if (offset_uri != null)
        {
            fbBuilder.addOffset(2, offset_uri);
        }
        if (offset_value != null)
        {
            fbBuilder.addOffset(1, offset_value);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedConfigurationReader
    : fb.TableReader<_UnlinkedConfigurationImpl>
{
    public _UnlinkedConfigurationReader();

    ////@override
    _UnlinkedConfigurationImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedConfigurationImpl(bc, offset);
}
public class _UnlinkedConfigurationImpl : Object
    with _UnlinkedConfigurationMixin
    : idl.UnlinkedConfiguration
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedConfigurationImpl(this._bc, this._bcOffset);

    String _name;
    String _uri;
    String _value;

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }

////@override
String get uri {
        _uri ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 2, "");
        return _uri;
    }

    ////@override
    String get value {
        _value ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 1, "");
        return _value;
    }
    }
public abstract class _UnlinkedConfigurationMixin
    : idl.UnlinkedConfiguration
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (name != "") _result["name"] = name;
        if (uri != "") _result["uri"] = uri;
        if (value != "") _result["value"] = value;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "name": name,
        "uri": uri,
        "value": value,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedConstructorInitializerBuilder : Object
    with _UnlinkedConstructorInitializerMixin
    : idl.UnlinkedConstructorInitializer
{
    List<String> _argumentNames;
    List<UnlinkedExprBuilder> _arguments;
    UnlinkedExprBuilder _expression;
    idl.UnlinkedConstructorInitializerKind _kind;
    String _name;

    ////@override
    public List<String> argumentNames
    {
        get => _argumentNames ??= new Dictionary<String> { };
    }

    /**
     * If there are `m` [arguments] and `n` [argumentNames], then each argument
     * from [arguments] with index `i` such that `n + i - m >= 0`, should be used
     * with the name at `n + i - m`.
     */
    void setargumentNames(List<String> value)
    {
        this._argumentNames = value;
    }

    ////@override
    List<UnlinkedExprBuilder> get arguments =>
        _arguments ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * If [kind] is `thisInvocation` or `superInvocation`, the arguments of the
 * invocation.  Otherwise empty.
 */
void setarguments(List<UnlinkedExprBuilder> value)
{
    this._arguments = value;
}

////@override
public UnlinkedExprBuilder expression
{
    get => _expression;
}

/**
 * If [kind] is `field`, the expression of the field initializer.
 * Otherwise `null`.
 */
void setexpression(UnlinkedExprBuilder value)
{
    this._expression = value;
}

////@override
idl.UnlinkedConstructorInitializerKind get kind =>
        _kind ??= idl.UnlinkedConstructorInitializerKind.field;

    /**
     * The kind of the constructor initializer (field, redirect, super).
     */
    void setkind(idl.UnlinkedConstructorInitializerKind value)
{
    this._kind = value;
}

////@override
public String name
{
    get => _name ??= "";
}

/**
 * If [kind] is `field`, the name of the field declared in the class.  If
 * [kind] is `thisInvocation`, the name of the constructor, declared in this
 * class, to redirect to.  If [kind] is `superInvocation`, the name of the
 * constructor, declared in the superclass, to invoke.
 */
void setname(String value)
{
    this._name = value;
}

UnlinkedConstructorInitializerBuilder(
        {
    List<String> argumentNames,
   List< UnlinkedExprBuilder > arguments,
      UnlinkedExprBuilder expression,
      idl.UnlinkedConstructorInitializerKind kind,
      String name)
      : _argumentNames = argumentNames,
        _arguments = arguments,
        _expression = expression,
        _kind = kind,
        _name = name;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _arguments?.forEach((b) => b.flushInformative());
        _expression?.flushInformative();
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        signature.addBool(this._expression != null);
        this._expression?.collectApiSignature(signature);
        signature.addInt(this._kind == null ? 0 : this._kind.index);
        if (this._arguments == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._arguments.length);
            foreach (var x in this._arguments)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._argumentNames == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._argumentNames.length);
            foreach (var x in this._argumentNames)
            {
                signature.addString(x);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_argumentNames;
        fb.Offset offset_arguments;
        fb.Offset offset_expression;
        fb.Offset offset_name;
        if (!(_argumentNames == null || _argumentNames.isEmpty))
        {
            offset_argumentNames = fbBuilder.writeList(
                _argumentNames.map((b) => fbBuilder.writeString(b)).toList());
        }
        if (!(_arguments == null || _arguments.isEmpty))
        {
            offset_arguments = fbBuilder
                .writeList(_arguments.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_expression != null)
        {
            offset_expression = _expression.finish(fbBuilder);
        }
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        fbBuilder.startTable();
        if (offset_argumentNames != null)
        {
            fbBuilder.addOffset(4, offset_argumentNames);
        }
        if (offset_arguments != null)
        {
            fbBuilder.addOffset(3, offset_arguments);
        }
        if (offset_expression != null)
        {
            fbBuilder.addOffset(1, offset_expression);
        }
        if (_kind != null &&
            _kind != idl.UnlinkedConstructorInitializerKind.field)
        {
            fbBuilder.addUint8(2, _kind.index);
        }
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedConstructorInitializerReader
    : fb.TableReader<_UnlinkedConstructorInitializerImpl>
{
    public _UnlinkedConstructorInitializerReader();

    ////@override
    _UnlinkedConstructorInitializerImpl createObject(
          fb.BufferContext bc, int offset) =>
      new _UnlinkedConstructorInitializerImpl(bc, offset);
}
public class _UnlinkedConstructorInitializerImpl : Object
    with _UnlinkedConstructorInitializerMixin
    : idl.UnlinkedConstructorInitializer
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedConstructorInitializerImpl(this._bc, this._bcOffset);

    List<String> _argumentNames;
    List<idl.UnlinkedExpr> _arguments;
    idl.UnlinkedExpr _expression;
    idl.UnlinkedConstructorInitializerKind _kind;
    String _name;

    ////@override
    List<String> get argumentNames {
        _argumentNames ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 4, new List<String>{);
        return _argumentNames;
    }

////@override
List<idl.UnlinkedExpr> get arguments {
        _arguments ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 3, new List<idl.UnlinkedExpr>{);
        return _arguments;
    }

    ////@override
    idl.UnlinkedExpr get expression {
        _expression ??=
public _UnlinkedExprReader().vTableGet(_bc, _bcOffset, 1, null);
        return _expression;
    }

    ////@override
    idl.UnlinkedConstructorInitializerKind get kind {
        _kind ??= new _UnlinkedConstructorInitializerKindReader().vTableGet(
            _bc, _bcOffset, 2, idl.UnlinkedConstructorInitializerKind.field);
        return _kind;
    }

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }
    }
public abstract class _UnlinkedConstructorInitializerMixin
    : idl.UnlinkedConstructorInitializer
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (argumentNames.isNotEmpty) _result["argumentNames"] = argumentNames;
        if (arguments.isNotEmpty)
            _result["arguments"] =
                arguments.map((_value) => _value.toJson()).toList();
        if (expression != null) _result["expression"] = expression.toJson();
        if (kind != idl.UnlinkedConstructorInitializerKind.field)
            _result["kind"] = kind.toString().split(".")[1];
        if (name != "") _result["name"] = name;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "argumentNames": argumentNames,
        "arguments": arguments,
        "expression": expression,
        "kind": kind,
        "name": name,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedDocumentationCommentBuilder : Object
    with _UnlinkedDocumentationCommentMixin
    : idl.UnlinkedDocumentationComment
{
    String _text;

    ////@override
    Null get length =>
        throw new NotImplementedException("attempt to access deprecated field");

    ////@override
    Null get offset =>
      throw new NotImplementedException("attempt to access deprecated field");

    ////@override
    public String text
    {
        get => _text ??= "";
    }

    /**
     * Text of the documentation comment, with '\r\n' replaced by '\n'.
     *
     * References appearing within the doc comment in square brackets are not
     * specially encoded.
     */
    void settext(String value)
    {
        this._text = value;
    }

    UnlinkedDocumentationCommentBuilder(String text) : _text = text;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative() { }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._text ?? "");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_text;
        if (_text != null)
        {
            offset_text = fbBuilder.writeString(_text);
        }
        fbBuilder.startTable();
        if (offset_text != null)
        {
            fbBuilder.addOffset(1, offset_text);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedDocumentationCommentReader
    : fb.TableReader<_UnlinkedDocumentationCommentImpl>
{
    public _UnlinkedDocumentationCommentReader();

    ////@override
    _UnlinkedDocumentationCommentImpl createObject(
          fb.BufferContext bc, int offset) =>
      new _UnlinkedDocumentationCommentImpl(bc, offset);
}
public class _UnlinkedDocumentationCommentImpl : Object
    with _UnlinkedDocumentationCommentMixin
    : idl.UnlinkedDocumentationComment
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedDocumentationCommentImpl(this._bc, this._bcOffset);

    String _text;

    ////@override
    Null get length =>
        throw new NotImplementedException("attempt to access deprecated field");

    ////@override
    Null get offset =>
      throw new NotImplementedException("attempt to access deprecated field");

    ////@override
    String get text {
        _text ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 1, "");
        return _text;
    }
    }
public abstract class _UnlinkedDocumentationCommentMixin
    : idl.UnlinkedDocumentationComment
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (text != "") _result["text"] = text;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "text": text,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedEnumBuilder : Object
    with _UnlinkedEnumMixin
    : idl.UnlinkedEnum
{
    List<UnlinkedExprBuilder> _annotations;
    CodeRangeBuilder _codeRange;
    UnlinkedDocumentationCommentBuilder _documentationComment;
    String _name;
    int _nameOffset;
    List<UnlinkedEnumValueBuilder> _values;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this enum.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
public CodeRangeBuilder codeRange
{
    get => _codeRange;
}

/**
 * Code range of the enum.
 */
void setcodeRange(CodeRangeBuilder value)
{
    this._codeRange = value;
}

////@override
UnlinkedDocumentationCommentBuilder get documentationComment =>
      _documentationComment;

    /**
     * Documentation comment for the enum, or `null` if there is no documentation
     * comment.
     */
    void setdocumentationComment(UnlinkedDocumentationCommentBuilder value)
{
    this._documentationComment = value;
}

////@override
public String name
{
    get => _name ??= "";
}

/**
 * Name of the enum type.
 */
void setname(String value)
{
    this._name = value;
}

////@override
public int nameOffset
{
    get => _nameOffset ??= 0;
}

/**
 * Offset of the enum name relative to the beginning of the file.
 */
void setnameOffset(int value)
{
    assert(value == null || value >= 0);
    this._nameOffset = value;
}

////@override
List<UnlinkedEnumValueBuilder> get values =>
        _values ??= new Dictionary<UnlinkedEnumValueBuilder>{};

    /**
     * Values listed in the enum declaration, in declaration order.
     */
    void setvalues(List<UnlinkedEnumValueBuilder> value)
{
    this._values = value;
}

UnlinkedEnumBuilder(
        {
    List<UnlinkedExprBuilder> annotations,
   CodeRangeBuilder codeRange,
      UnlinkedDocumentationCommentBuilder documentationComment,
      String name,
      int nameOffset,
      List< UnlinkedEnumValueBuilder > values)
      : _annotations = annotations,
        _codeRange = codeRange,
        _documentationComment = documentationComment,
        _name = name,
        _nameOffset = nameOffset,
        _values = values;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _codeRange = null;
        _documentationComment = null;
        _nameOffset = null;
        _values?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        if (this._values == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._values.length);
            foreach (var x in this._values)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        fb.Offset offset_codeRange;
        fb.Offset offset_documentationComment;
        fb.Offset offset_name;
        fb.Offset offset_values;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_codeRange != null)
        {
            offset_codeRange = _codeRange.finish(fbBuilder);
        }
        if (_documentationComment != null)
        {
            offset_documentationComment = _documentationComment.finish(fbBuilder);
        }
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        if (!(_values == null || _values.isEmpty))
        {
            offset_values =
                fbBuilder.writeList(_values.map((b) => b.finish(fbBuilder)).toList());
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(4, offset_annotations);
        }
        if (offset_codeRange != null)
        {
            fbBuilder.addOffset(5, offset_codeRange);
        }
        if (offset_documentationComment != null)
        {
            fbBuilder.addOffset(3, offset_documentationComment);
        }
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        if (_nameOffset != null && _nameOffset != 0)
        {
            fbBuilder.addUint32(1, _nameOffset);
        }
        if (offset_values != null)
        {
            fbBuilder.addOffset(2, offset_values);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedEnumReader : fb.TableReader<_UnlinkedEnumImpl>
{
    public _UnlinkedEnumReader();

    ////@override
    _UnlinkedEnumImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedEnumImpl(bc, offset);
}
public class _UnlinkedEnumImpl : Object
    with _UnlinkedEnumMixin
    : idl.UnlinkedEnum
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedEnumImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    idl.CodeRange _codeRange;
    idl.UnlinkedDocumentationComment _documentationComment;
    String _name;
    int _nameOffset;
    List<idl.UnlinkedEnumValue> _values;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 4, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
idl.CodeRange get codeRange {
        _codeRange ??= new _CodeRangeReader().vTableGet(_bc, _bcOffset, 5, null);
        return _codeRange;
    }

    ////@override
    idl.UnlinkedDocumentationComment get documentationComment {
        _documentationComment ??= new _UnlinkedDocumentationCommentReader()
          .vTableGet(_bc, _bcOffset, 3, null);
        return _documentationComment;
    }

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }

    ////@override
    int get nameOffset {
        _nameOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _nameOffset;
    }

    ////@override
    List<idl.UnlinkedEnumValue> get values {
        _values ??= new fb.ListReader<idl.UnlinkedEnumValue>(
public _UnlinkedEnumValueReader())
        .vTableGet(_bc, _bcOffset, 2, new List<idl.UnlinkedEnumValue>{);
        return _values;
    }
    }
public abstract class _UnlinkedEnumMixin : idl.UnlinkedEnum
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (codeRange != null) _result["codeRange"] = codeRange.toJson();
        if (documentationComment != null)
            _result["documentationComment"] = documentationComment.toJson();
        if (name != "") _result["name"] = name;
        if (nameOffset != 0) _result["nameOffset"] = nameOffset;
        if (values.isNotEmpty)
            _result["values"] = values.map((_value) => _value.toJson()).toList();
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "codeRange": codeRange,
        "documentationComment": documentationComment,
        "name": name,
        "nameOffset": nameOffset,
        "values": values,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedEnumValueBuilder : Object
    with _UnlinkedEnumValueMixin
    : idl.UnlinkedEnumValue
{
    List<UnlinkedExprBuilder> _annotations;
    UnlinkedDocumentationCommentBuilder _documentationComment;
    String _name;
    int _nameOffset;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this value.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
UnlinkedDocumentationCommentBuilder get documentationComment =>
      _documentationComment;

    /**
     * Documentation comment for the enum value, or `null` if there is no
     * documentation comment.
     */
    void setdocumentationComment(UnlinkedDocumentationCommentBuilder value)
{
    this._documentationComment = value;
}

////@override
public String name
{
    get => _name ??= "";
}

/**
 * Name of the enumerated value.
 */
void setname(String value)
{
    this._name = value;
}

////@override
public int nameOffset
{
    get => _nameOffset ??= 0;
}

/**
 * Offset of the enum value name relative to the beginning of the file.
 */
void setnameOffset(int value)
{
    assert(value == null || value >= 0);
    this._nameOffset = value;
}

UnlinkedEnumValueBuilder(
        {
    List<UnlinkedExprBuilder> annotations,
   UnlinkedDocumentationCommentBuilder documentationComment,
      String name,
      int nameOffset)
      : _annotations = annotations,
        _documentationComment = documentationComment,
        _name = name,
        _nameOffset = nameOffset;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _documentationComment = null;
        _nameOffset = null;
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        fb.Offset offset_documentationComment;
        fb.Offset offset_name;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_documentationComment != null)
        {
            offset_documentationComment = _documentationComment.finish(fbBuilder);
        }
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(3, offset_annotations);
        }
        if (offset_documentationComment != null)
        {
            fbBuilder.addOffset(2, offset_documentationComment);
        }
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        if (_nameOffset != null && _nameOffset != 0)
        {
            fbBuilder.addUint32(1, _nameOffset);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedEnumValueReader : fb.TableReader<_UnlinkedEnumValueImpl>
{
    public _UnlinkedEnumValueReader();

    ////@override
    _UnlinkedEnumValueImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedEnumValueImpl(bc, offset);
}
public class _UnlinkedEnumValueImpl : Object
    with _UnlinkedEnumValueMixin
    : idl.UnlinkedEnumValue
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedEnumValueImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    idl.UnlinkedDocumentationComment _documentationComment;
    String _name;
    int _nameOffset;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 3, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
idl.UnlinkedDocumentationComment get documentationComment {
        _documentationComment ??= new _UnlinkedDocumentationCommentReader()
          .vTableGet(_bc, _bcOffset, 2, null);
        return _documentationComment;
    }

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }

    ////@override
    int get nameOffset {
        _nameOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _nameOffset;
    }
    }
public abstract class _UnlinkedEnumValueMixin : idl.UnlinkedEnumValue
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (documentationComment != null)
            _result["documentationComment"] = documentationComment.toJson();
        if (name != "") _result["name"] = name;
        if (nameOffset != 0) _result["nameOffset"] = nameOffset;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "documentationComment": documentationComment,
        "name": name,
        "nameOffset": nameOffset,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedExecutableBuilder : Object
    with _UnlinkedExecutableMixin
    : idl.UnlinkedExecutable
{
    List<UnlinkedExprBuilder> _annotations;
    UnlinkedExprBuilder _bodyExpr;
    CodeRangeBuilder _codeRange;
    List<UnlinkedConstructorInitializerBuilder> _constantInitializers;
    int _constCycleSlot;
    UnlinkedDocumentationCommentBuilder _documentationComment;
    int _inferredReturnTypeSlot;
    bool _isAbstract;
    bool _isAsynchronous;
    bool _isConst;
    bool _isExternal;
    bool _isFactory;
    bool _isGenerator;
    bool _isRedirectedConstructor;
    bool _isStatic;
    idl.UnlinkedExecutableKind _kind;
    List<UnlinkedExecutableBuilder> _localFunctions;
    String _name;
    int _nameEnd;
    int _nameOffset;
    List<UnlinkedParamBuilder> _parameters;
    int _periodOffset;
    EntityRefBuilder _redirectedConstructor;
    String _redirectedConstructorName;
    EntityRefBuilder _returnType;
    List<UnlinkedTypeParamBuilder> _typeParameters;
    int _visibleLength;
    int _visibleOffset;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this executable.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
public UnlinkedExprBuilder bodyExpr
{
    get => _bodyExpr;
}

/**
 * If this executable's function body is declared using `=>`, the expression
 * to the right of the `=>`.  May be omitted if neither type inference nor
 * constant evaluation depends on the function body.
 */
void setbodyExpr(UnlinkedExprBuilder value)
{
    this._bodyExpr = value;
}

////@override
public CodeRangeBuilder codeRange
{
    get => _codeRange;
}

/**
 * Code range of the executable.
 */
void setcodeRange(CodeRangeBuilder value)
{
    this._codeRange = value;
}

////@override
List<UnlinkedConstructorInitializerBuilder> get constantInitializers =>
        _constantInitializers ??= new Dictionary<UnlinkedConstructorInitializerBuilder>{};

    /**
     * If a constant [UnlinkedExecutableKind.constructor], the constructor
     * initializers.  Otherwise empty.
     */
    void setconstantInitializers(
        List<UnlinkedConstructorInitializerBuilder> value)
{
    this._constantInitializers = value;
}

////@override
public int constCycleSlot
{
    get => _constCycleSlot ??= 0;
}

/**
 * If [kind] is [UnlinkedExecutableKind.constructor] and [isConst] is `true`,
 * a nonzero slot id which is unique within this compilation unit.  If this id
 * is found in [LinkedUnit.constCycles], then this constructor is part of a
 * cycle.
 *
 * Otherwise, zero.
 */
void setconstCycleSlot(int value)
{
    assert(value == null || value >= 0);
    this._constCycleSlot = value;
}

////@override
UnlinkedDocumentationCommentBuilder get documentationComment =>
      _documentationComment;

    /**
     * Documentation comment for the executable, or `null` if there is no
     * documentation comment.
     */
    void setdocumentationComment(UnlinkedDocumentationCommentBuilder value)
{
    this._documentationComment = value;
}

////@override
public int inferredReturnTypeSlot
{
    get => _inferredReturnTypeSlot ??= 0;
}

/**
 * If this executable's return type is inferable, nonzero slot id
 * identifying which entry in [LinkedUnit.types] contains the inferred
 * return type.  If there is no matching entry in [LinkedUnit.types], then
 * no return type was inferred for this variable, so its static type is
 * `dynamic`.
 */
void setinferredReturnTypeSlot(int value)
{
    assert(value == null || value >= 0);
    this._inferredReturnTypeSlot = value;
}

////@override
public bool isAbstract
{
    get => _isAbstract ??= false;
}

/**
 * Indicates whether the executable is declared using the `abstract` keyword.
 */
void setisAbstract(bool value)
{
    this._isAbstract = value;
}

////@override
public bool isAsynchronous
{
    get => _isAsynchronous ??= false;
}

/**
 * Indicates whether the executable has body marked as being asynchronous.
 */
void setisAsynchronous(bool value)
{
    this._isAsynchronous = value;
}

////@override
public bool isConst
{
    get => _isConst ??= false;
}

/**
 * Indicates whether the executable is declared using the `const` keyword.
 */
void setisConst(bool value)
{
    this._isConst = value;
}

////@override
public bool isExternal
{
    get => _isExternal ??= false;
}

/**
 * Indicates whether the executable is declared using the `external` keyword.
 */
void setisExternal(bool value)
{
    this._isExternal = value;
}

////@override
public bool isFactory
{
    get => _isFactory ??= false;
}

/**
 * Indicates whether the executable is declared using the `factory` keyword.
 */
void setisFactory(bool value)
{
    this._isFactory = value;
}

////@override
public bool isGenerator
{
    get => _isGenerator ??= false;
}

/**
 * Indicates whether the executable has body marked as being a generator.
 */
void setisGenerator(bool value)
{
    this._isGenerator = value;
}

////@override
public bool isRedirectedConstructor
{
    get => _isRedirectedConstructor ??= false;
}

/**
 * Indicates whether the executable is a redirected constructor.
 */
void setisRedirectedConstructor(bool value)
{
    this._isRedirectedConstructor = value;
}

////@override
public bool isStatic
{
    get => _isStatic ??= false;
}

/**
 * Indicates whether the executable is declared using the `static` keyword.
 *
 * Note that for top level executables, this flag is false, since they are
 * not declared using the `static` keyword (even though they are considered
 * static for semantic purposes).
 */
void setisStatic(bool value)
{
    this._isStatic = value;
}

////@override
idl.UnlinkedExecutableKind get kind =>
        _kind ??= idl.UnlinkedExecutableKind.functionOrMethod;

    /**
     * The kind of the executable (function/method, getter, setter, or
     * constructor).
     */
    void setkind(idl.UnlinkedExecutableKind value)
{
    this._kind = value;
}

////@override
List<UnlinkedExecutableBuilder> get localFunctions =>
        _localFunctions ??= new Dictionary<UnlinkedExecutableBuilder>{};

    /**
     * The list of local functions.
     */
    void setlocalFunctions(List<UnlinkedExecutableBuilder> value)
{
    this._localFunctions = value;
}

////@override
Null get localLabels =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
Null get localVariables =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
public String name
{
    get => _name ??= "";
}

/**
 * Name of the executable.  For setters, this includes the trailing "=".  For
 * named constructors, this excludes the class name and excludes the ".".
 * For unnamed constructors, this is the empty string.
 */
void setname(String value)
{
    this._name = value;
}

////@override
public int nameEnd
{
    get => _nameEnd ??= 0;
}

/**
 * If [kind] is [UnlinkedExecutableKind.constructor] and [name] is not empty,
 * the offset of the end of the constructor name.  Otherwise zero.
 */
void setnameEnd(int value)
{
    assert(value == null || value >= 0);
    this._nameEnd = value;
}

////@override
public int nameOffset
{
    get => _nameOffset ??= 0;
}

/**
 * Offset of the executable name relative to the beginning of the file.  For
 * named constructors, this excludes the class name and excludes the ".".
 * For unnamed constructors, this is the offset of the class name (i.e. the
 * offset of the second "C" in "class C { C(); }").
 */
void setnameOffset(int value)
{
    assert(value == null || value >= 0);
    this._nameOffset = value;
}

////@override
List<UnlinkedParamBuilder> get parameters =>
        _parameters ??= new Dictionary<UnlinkedParamBuilder>{};

    /**
     * Parameters of the executable, if any.  Note that getters have no
     * parameters (hence this will be the empty list), and setters have a single
     * parameter.
     */
    void setparameters(List<UnlinkedParamBuilder> value)
{
    this._parameters = value;
}

////@override
public int periodOffset
{
    get => _periodOffset ??= 0;
}

/**
 * If [kind] is [UnlinkedExecutableKind.constructor] and [name] is not empty,
 * the offset of the period before the constructor name.  Otherwise zero.
 */
void setperiodOffset(int value)
{
    assert(value == null || value >= 0);
    this._periodOffset = value;
}

////@override
public EntityRefBuilder redirectedConstructor
{
    get => _redirectedConstructor;
}

/**
 * If [isRedirectedConstructor] and [isFactory] are both `true`, the
 * constructor to which this constructor redirects; otherwise empty.
 */
void setredirectedConstructor(EntityRefBuilder value)
{
    this._redirectedConstructor = value;
}

////@override
public String redirectedConstructorName
{
    get => _redirectedConstructorName ??= "";
}

/**
 * If [isRedirectedConstructor] is `true` and [isFactory] is `false`, the
 * name of the constructor that this constructor redirects to; otherwise
 * empty.
 */
void setredirectedConstructorName(String value)
{
    this._redirectedConstructorName = value;
}

////@override
public EntityRefBuilder returnType
{
    get => _returnType;
}

/**
 * Declared return type of the executable.  Absent if the executable is a
 * constructor or the return type is implicit.  Absent for executables
 * associated with variable initializers and closures, since these
 * executables may have return types that are not accessible via direct
 * imports.
 */
void setreturnType(EntityRefBuilder value)
{
    this._returnType = value;
}

////@override
List<UnlinkedTypeParamBuilder> get typeParameters =>
        _typeParameters ??= new Dictionary<UnlinkedTypeParamBuilder>{};

    /**
     * Type parameters of the executable, if any.  Empty if support for generic
     * method syntax is disabled.
     */
    void settypeParameters(List<UnlinkedTypeParamBuilder> value)
{
    this._typeParameters = value;
}

////@override
public int visibleLength
{
    get => _visibleLength ??= 0;
}

/**
 * If a local function, the length of the visible range; zero otherwise.
 */
void setvisibleLength(int value)
{
    assert(value == null || value >= 0);
    this._visibleLength = value;
}

////@override
public int visibleOffset
{
    get => _visibleOffset ??= 0;
}

/**
 * If a local function, the beginning of the visible range; zero otherwise.
 */
void setvisibleOffset(int value)
{
    assert(value == null || value >= 0);
    this._visibleOffset = value;
}

UnlinkedExecutableBuilder(
        {
    List<UnlinkedExprBuilder> annotations,
   UnlinkedExprBuilder bodyExpr,
      CodeRangeBuilder codeRange,
      List< UnlinkedConstructorInitializerBuilder > constantInitializers,
      int constCycleSlot,
      UnlinkedDocumentationCommentBuilder documentationComment,
      int inferredReturnTypeSlot,
      bool isAbstract,
      bool isAsynchronous,
      bool isConst,
      bool isExternal,
      bool isFactory,
      bool isGenerator,
      bool isRedirectedConstructor,
      bool isStatic,
      idl.UnlinkedExecutableKind kind,
      List< UnlinkedExecutableBuilder > localFunctions,
      String name,
      int nameEnd,
      int nameOffset,
      List< UnlinkedParamBuilder > parameters,
      int periodOffset,
      EntityRefBuilder redirectedConstructor,
      String redirectedConstructorName,
      EntityRefBuilder returnType,
      List<UnlinkedTypeParamBuilder> typeParameters,
      int visibleLength,
      int visibleOffset)
      : _annotations = annotations,
        _bodyExpr = bodyExpr,
        _codeRange = codeRange,
        _constantInitializers = constantInitializers,
        _constCycleSlot = constCycleSlot,
        _documentationComment = documentationComment,
        _inferredReturnTypeSlot = inferredReturnTypeSlot,
        _isAbstract = isAbstract,
        _isAsynchronous = isAsynchronous,
        _isConst = isConst,
        _isExternal = isExternal,
        _isFactory = isFactory,
        _isGenerator = isGenerator,
        _isRedirectedConstructor = isRedirectedConstructor,
        _isStatic = isStatic,
        _kind = kind,
        _localFunctions = localFunctions,
        _name = name,
        _nameEnd = nameEnd,
        _nameOffset = nameOffset,
        _parameters = parameters,
        _periodOffset = periodOffset,
        _redirectedConstructor = redirectedConstructor,
        _redirectedConstructorName = redirectedConstructorName,
        _returnType = returnType,
        _typeParameters = typeParameters,
        _visibleLength = visibleLength,
        _visibleOffset = visibleOffset;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _bodyExpr?.flushInformative();
        _codeRange = null;
        _constantInitializers?.forEach((b) => b.flushInformative());
        _documentationComment = null;
        _isAsynchronous = null;
        _isGenerator = null;
        _localFunctions?.forEach((b) => b.flushInformative());
        _nameEnd = null;
        _nameOffset = null;
        _parameters?.forEach((b) => b.flushInformative());
        _periodOffset = null;
        _redirectedConstructor?.flushInformative();
        _returnType?.flushInformative();
        _typeParameters?.forEach((b) => b.flushInformative());
        _visibleLength = null;
        _visibleOffset = null;
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        if (this._parameters == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._parameters.length);
            foreach (var x in this._parameters)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._returnType != null);
        this._returnType?.collectApiSignature(signature);
        signature.addInt(this._kind == null ? 0 : this._kind.index);
        signature.addInt(this._inferredReturnTypeSlot ?? 0);
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._isFactory == true);
        signature.addBool(this._isStatic == true);
        signature.addBool(this._isAbstract == true);
        signature.addBool(this._isExternal == true);
        signature.addBool(this._isConst == true);
        signature.addBool(this._isRedirectedConstructor == true);
        if (this._constantInitializers == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._constantInitializers.length);
            foreach (var x in this._constantInitializers)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._redirectedConstructor != null);
        this._redirectedConstructor?.collectApiSignature(signature);
        if (this._typeParameters == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._typeParameters.length);
            foreach (var x in this._typeParameters)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addString(this._redirectedConstructorName ?? "");
        if (this._localFunctions == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._localFunctions.length);
            foreach (var x in this._localFunctions)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addInt(this._constCycleSlot ?? 0);
        signature.addBool(this._bodyExpr != null);
        this._bodyExpr?.collectApiSignature(signature);
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        fb.Offset offset_bodyExpr;
        fb.Offset offset_codeRange;
        fb.Offset offset_constantInitializers;
        fb.Offset offset_documentationComment;
        fb.Offset offset_localFunctions;
        fb.Offset offset_name;
        fb.Offset offset_parameters;
        fb.Offset offset_redirectedConstructor;
        fb.Offset offset_redirectedConstructorName;
        fb.Offset offset_returnType;
        fb.Offset offset_typeParameters;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_bodyExpr != null)
        {
            offset_bodyExpr = _bodyExpr.finish(fbBuilder);
        }
        if (_codeRange != null)
        {
            offset_codeRange = _codeRange.finish(fbBuilder);
        }
        if (!(_constantInitializers == null || _constantInitializers.isEmpty))
        {
            offset_constantInitializers = fbBuilder.writeList(
                _constantInitializers.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_documentationComment != null)
        {
            offset_documentationComment = _documentationComment.finish(fbBuilder);
        }
        if (!(_localFunctions == null || _localFunctions.isEmpty))
        {
            offset_localFunctions = fbBuilder
                .writeList(_localFunctions.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        if (!(_parameters == null || _parameters.isEmpty))
        {
            offset_parameters = fbBuilder
                .writeList(_parameters.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_redirectedConstructor != null)
        {
            offset_redirectedConstructor = _redirectedConstructor.finish(fbBuilder);
        }
        if (_redirectedConstructorName != null)
        {
            offset_redirectedConstructorName =
                fbBuilder.writeString(_redirectedConstructorName);
        }
        if (_returnType != null)
        {
            offset_returnType = _returnType.finish(fbBuilder);
        }
        if (!(_typeParameters == null || _typeParameters.isEmpty))
        {
            offset_typeParameters = fbBuilder
                .writeList(_typeParameters.map((b) => b.finish(fbBuilder)).toList());
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(6, offset_annotations);
        }
        if (offset_bodyExpr != null)
        {
            fbBuilder.addOffset(29, offset_bodyExpr);
        }
        if (offset_codeRange != null)
        {
            fbBuilder.addOffset(26, offset_codeRange);
        }
        if (offset_constantInitializers != null)
        {
            fbBuilder.addOffset(14, offset_constantInitializers);
        }
        if (_constCycleSlot != null && _constCycleSlot != 0)
        {
            fbBuilder.addUint32(25, _constCycleSlot);
        }
        if (offset_documentationComment != null)
        {
            fbBuilder.addOffset(7, offset_documentationComment);
        }
        if (_inferredReturnTypeSlot != null && _inferredReturnTypeSlot != 0)
        {
            fbBuilder.addUint32(5, _inferredReturnTypeSlot);
        }
        if (_isAbstract == true)
        {
            fbBuilder.addBool(10, true);
        }
        if (_isAsynchronous == true)
        {
            fbBuilder.addBool(27, true);
        }
        if (_isConst == true)
        {
            fbBuilder.addBool(12, true);
        }
        if (_isExternal == true)
        {
            fbBuilder.addBool(11, true);
        }
        if (_isFactory == true)
        {
            fbBuilder.addBool(8, true);
        }
        if (_isGenerator == true)
        {
            fbBuilder.addBool(28, true);
        }
        if (_isRedirectedConstructor == true)
        {
            fbBuilder.addBool(13, true);
        }
        if (_isStatic == true)
        {
            fbBuilder.addBool(9, true);
        }
        if (_kind != null && _kind != idl.UnlinkedExecutableKind.functionOrMethod)
        {
            fbBuilder.addUint8(4, _kind.index);
        }
        if (offset_localFunctions != null)
        {
            fbBuilder.addOffset(18, offset_localFunctions);
        }
        if (offset_name != null)
        {
            fbBuilder.addOffset(1, offset_name);
        }
        if (_nameEnd != null && _nameEnd != 0)
        {
            fbBuilder.addUint32(23, _nameEnd);
        }
        if (_nameOffset != null && _nameOffset != 0)
        {
            fbBuilder.addUint32(0, _nameOffset);
        }
        if (offset_parameters != null)
        {
            fbBuilder.addOffset(2, offset_parameters);
        }
        if (_periodOffset != null && _periodOffset != 0)
        {
            fbBuilder.addUint32(24, _periodOffset);
        }
        if (offset_redirectedConstructor != null)
        {
            fbBuilder.addOffset(15, offset_redirectedConstructor);
        }
        if (offset_redirectedConstructorName != null)
        {
            fbBuilder.addOffset(17, offset_redirectedConstructorName);
        }
        if (offset_returnType != null)
        {
            fbBuilder.addOffset(3, offset_returnType);
        }
        if (offset_typeParameters != null)
        {
            fbBuilder.addOffset(16, offset_typeParameters);
        }
        if (_visibleLength != null && _visibleLength != 0)
        {
            fbBuilder.addUint32(20, _visibleLength);
        }
        if (_visibleOffset != null && _visibleOffset != 0)
        {
            fbBuilder.addUint32(21, _visibleOffset);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedExecutableReader
    : fb.TableReader<_UnlinkedExecutableImpl>
{
    public _UnlinkedExecutableReader();

    ////@override
    _UnlinkedExecutableImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedExecutableImpl(bc, offset);
}
public class _UnlinkedExecutableImpl : Object
    with _UnlinkedExecutableMixin
    : idl.UnlinkedExecutable
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedExecutableImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    idl.UnlinkedExpr _bodyExpr;
    idl.CodeRange _codeRange;
    List<idl.UnlinkedConstructorInitializer> _constantInitializers;
    int _constCycleSlot;
    idl.UnlinkedDocumentationComment _documentationComment;
    int _inferredReturnTypeSlot;
    bool _isAbstract;
    bool _isAsynchronous;
    bool _isConst;
    bool _isExternal;
    bool _isFactory;
    bool _isGenerator;
    bool _isRedirectedConstructor;
    bool _isStatic;
    idl.UnlinkedExecutableKind _kind;
    List<idl.UnlinkedExecutable> _localFunctions;
    String _name;
    int _nameEnd;
    int _nameOffset;
    List<idl.UnlinkedParam> _parameters;
    int _periodOffset;
    idl.EntityRef _redirectedConstructor;
    String _redirectedConstructorName;
    idl.EntityRef _returnType;
    List<idl.UnlinkedTypeParam> _typeParameters;
    int _visibleLength;
    int _visibleOffset;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 6, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
idl.UnlinkedExpr get bodyExpr {
        _bodyExpr ??=
public _UnlinkedExprReader().vTableGet(_bc, _bcOffset, 29, null);
        return _bodyExpr;
    }

    ////@override
    idl.CodeRange get codeRange {
        _codeRange ??= new _CodeRangeReader().vTableGet(_bc, _bcOffset, 26, null);
        return _codeRange;
    }

    ////@override
    List<idl.UnlinkedConstructorInitializer> get constantInitializers {
        _constantInitializers ??=
public fb.ListReader<idl.UnlinkedConstructorInitializer>(
public _UnlinkedConstructorInitializerReader())
            .vTableGet(_bc, _bcOffset, 14,
                  new List<idl.UnlinkedConstructorInitializer>{);
        return _constantInitializers;
    }

    ////@override
    int get constCycleSlot {
        _constCycleSlot ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 25, 0);
        return _constCycleSlot;
    }

    ////@override
    idl.UnlinkedDocumentationComment get documentationComment {
        _documentationComment ??= new _UnlinkedDocumentationCommentReader()
          .vTableGet(_bc, _bcOffset, 7, null);
        return _documentationComment;
    }

    ////@override
    int get inferredReturnTypeSlot {
        _inferredReturnTypeSlot ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 5, 0);
        return _inferredReturnTypeSlot;
    }

    ////@override
    bool get isAbstract {
        _isAbstract ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 10, false);
        return _isAbstract;
    }

    ////@override
    bool get isAsynchronous {
        _isAsynchronous ??=
public fb.BoolReader().vTableGet(_bc, _bcOffset, 27, false);
        return _isAsynchronous;
    }

    ////@override
    bool get isConst {
        _isConst ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 12, false);
        return _isConst;
    }

    ////@override
    bool get isExternal {
        _isExternal ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 11, false);
        return _isExternal;
    }

    ////@override
    bool get isFactory {
        _isFactory ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 8, false);
        return _isFactory;
    }

    ////@override
    bool get isGenerator {
        _isGenerator ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 28, false);
        return _isGenerator;
    }

    ////@override
    bool get isRedirectedConstructor {
        _isRedirectedConstructor ??=
public fb.BoolReader().vTableGet(_bc, _bcOffset, 13, false);
        return _isRedirectedConstructor;
    }

    ////@override
    bool get isStatic {
        _isStatic ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 9, false);
        return _isStatic;
    }

    ////@override
    idl.UnlinkedExecutableKind get kind {
        _kind ??= new _UnlinkedExecutableKindReader().vTableGet(
            _bc, _bcOffset, 4, idl.UnlinkedExecutableKind.functionOrMethod);
        return _kind;
    }

    ////@override
    List<idl.UnlinkedExecutable> get localFunctions {
        _localFunctions ??= new fb.ListReader<idl.UnlinkedExecutable>(
public _UnlinkedExecutableReader())
        .vTableGet(_bc, _bcOffset, 18, new List<idl.UnlinkedExecutable>{);
        return _localFunctions;
    }

    ////@override
    Null get localLabels =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
Null get localVariables =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 1, "");
        return _name;
    }

    ////@override
    int get nameEnd {
        _nameEnd ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 23, 0);
        return _nameEnd;
    }

    ////@override
    int get nameOffset {
        _nameOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _nameOffset;
    }

    ////@override
    List<idl.UnlinkedParam> get parameters {
        _parameters ??=
public fb.ListReader<idl.UnlinkedParam>(const _UnlinkedParamReader())
            .vTableGet(_bc, _bcOffset, 2, new List<idl.UnlinkedParam>{);
        return _parameters;
    }

    ////@override
    int get periodOffset {
        _periodOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 24, 0);
        return _periodOffset;
    }

    ////@override
    idl.EntityRef get redirectedConstructor {
        _redirectedConstructor ??=
public _EntityRefReader().vTableGet(_bc, _bcOffset, 15, null);
        return _redirectedConstructor;
    }

    ////@override
    String get redirectedConstructorName {
        _redirectedConstructorName ??=
public fb.StringReader().vTableGet(_bc, _bcOffset, 17, "");
        return _redirectedConstructorName;
    }

    ////@override
    idl.EntityRef get returnType {
        _returnType ??= new _EntityRefReader().vTableGet(_bc, _bcOffset, 3, null);
        return _returnType;
    }

    ////@override
    List<idl.UnlinkedTypeParam> get typeParameters {
        _typeParameters ??= new fb.ListReader<idl.UnlinkedTypeParam>(
public _UnlinkedTypeParamReader())
        .vTableGet(_bc, _bcOffset, 16, new List<idl.UnlinkedTypeParam>{);
        return _typeParameters;
    }

    ////@override
    int get visibleLength {
        _visibleLength ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 20, 0);
        return _visibleLength;
    }

    ////@override
    int get visibleOffset {
        _visibleOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 21, 0);
        return _visibleOffset;
    }
    }
public abstract class _UnlinkedExecutableMixin : idl.UnlinkedExecutable
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (bodyExpr != null) _result["bodyExpr"] = bodyExpr.toJson();
        if (codeRange != null) _result["codeRange"] = codeRange.toJson();
        if (constantInitializers.isNotEmpty)
            _result["constantInitializers"] =
                constantInitializers.map((_value) => _value.toJson()).toList();
        if (constCycleSlot != 0) _result["constCycleSlot"] = constCycleSlot;
        if (documentationComment != null)
            _result["documentationComment"] = documentationComment.toJson();
        if (inferredReturnTypeSlot != 0)
            _result["inferredReturnTypeSlot"] = inferredReturnTypeSlot;
        if (isAbstract != false) _result["isAbstract"] = isAbstract;
        if (isAsynchronous != false) _result["isAsynchronous"] = isAsynchronous;
        if (isConst != false) _result["isConst"] = isConst;
        if (isExternal != false) _result["isExternal"] = isExternal;
        if (isFactory != false) _result["isFactory"] = isFactory;
        if (isGenerator != false) _result["isGenerator"] = isGenerator;
        if (isRedirectedConstructor != false)
            _result["isRedirectedConstructor"] = isRedirectedConstructor;
        if (isStatic != false) _result["isStatic"] = isStatic;
        if (kind != idl.UnlinkedExecutableKind.functionOrMethod)
            _result["kind"] = kind.toString().split(".")[1];
        if (localFunctions.isNotEmpty)
            _result["localFunctions"] =
                localFunctions.map((_value) => _value.toJson()).toList();
        if (name != "") _result["name"] = name;
        if (nameEnd != 0) _result["nameEnd"] = nameEnd;
        if (nameOffset != 0) _result["nameOffset"] = nameOffset;
        if (parameters.isNotEmpty)
            _result["parameters"] =
                parameters.map((_value) => _value.toJson()).toList();
        if (periodOffset != 0) _result["periodOffset"] = periodOffset;
        if (redirectedConstructor != null)
            _result["redirectedConstructor"] = redirectedConstructor.toJson();
        if (redirectedConstructorName != "")
            _result["redirectedConstructorName"] = redirectedConstructorName;
        if (returnType != null) _result["returnType"] = returnType.toJson();
        if (typeParameters.isNotEmpty)
            _result["typeParameters"] =
                typeParameters.map((_value) => _value.toJson()).toList();
        if (visibleLength != 0) _result["visibleLength"] = visibleLength;
        if (visibleOffset != 0) _result["visibleOffset"] = visibleOffset;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "bodyExpr": bodyExpr,
        "codeRange": codeRange,
        "constantInitializers": constantInitializers,
        "constCycleSlot": constCycleSlot,
        "documentationComment": documentationComment,
        "inferredReturnTypeSlot": inferredReturnTypeSlot,
        "isAbstract": isAbstract,
        "isAsynchronous": isAsynchronous,
        "isConst": isConst,
        "isExternal": isExternal,
        "isFactory": isFactory,
        "isGenerator": isGenerator,
        "isRedirectedConstructor": isRedirectedConstructor,
        "isStatic": isStatic,
        "kind": kind,
        "localFunctions": localFunctions,
        "name": name,
        "nameEnd": nameEnd,
        "nameOffset": nameOffset,
        "parameters": parameters,
        "periodOffset": periodOffset,
        "redirectedConstructor": redirectedConstructor,
        "redirectedConstructorName": redirectedConstructorName,
        "returnType": returnType,
        "typeParameters": typeParameters,
        "visibleLength": visibleLength,
        "visibleOffset": visibleOffset,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedExportNonPublicBuilder : Object
    with _UnlinkedExportNonPublicMixin
    : idl.UnlinkedExportNonPublic
{
    List<UnlinkedExprBuilder> _annotations;
    int _offset;
    int _uriEnd;
    int _uriOffset;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this export directive.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
public int offset
{
    get => _offset ??= 0;
}

/**
 * Offset of the "export" keyword.
 */
void setoffset(int value)
{
    assert(value == null || value >= 0);
    this._offset = value;
}

////@override
public int uriEnd
{
    get => _uriEnd ??= 0;
}

/**
 * End of the URI string (including quotes) relative to the beginning of the
 * file.
 */
void seturiEnd(int value)
{
    assert(value == null || value >= 0);
    this._uriEnd = value;
}

////@override
public int uriOffset
{
    get => _uriOffset ??= 0;
}

/**
 * Offset of the URI string (including quotes) relative to the beginning of
 * the file.
 */
void seturiOffset(int value)
{
    assert(value == null || value >= 0);
    this._uriOffset = value;
}

UnlinkedExportNonPublicBuilder(
        {
    List<UnlinkedExprBuilder> annotations,
      int offset,
      int uriEnd,
      int uriOffset)
      : _annotations = annotations,
        _offset = offset,
        _uriEnd = uriEnd,
        _uriOffset = uriOffset;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _offset = null;
        _uriEnd = null;
        _uriOffset = null;
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(3, offset_annotations);
        }
        if (_offset != null && _offset != 0)
        {
            fbBuilder.addUint32(0, _offset);
        }
        if (_uriEnd != null && _uriEnd != 0)
        {
            fbBuilder.addUint32(1, _uriEnd);
        }
        if (_uriOffset != null && _uriOffset != 0)
        {
            fbBuilder.addUint32(2, _uriOffset);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedExportNonPublicReader
    : fb.TableReader<_UnlinkedExportNonPublicImpl>
{
    public _UnlinkedExportNonPublicReader();

    ////@override
    _UnlinkedExportNonPublicImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedExportNonPublicImpl(bc, offset);
}
public class _UnlinkedExportNonPublicImpl : Object
    with _UnlinkedExportNonPublicMixin
    : idl.UnlinkedExportNonPublic
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedExportNonPublicImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    int _offset;
    int _uriEnd;
    int _uriOffset;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 3, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
int get offset {
        _offset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _offset;
    }

    ////@override
    int get uriEnd {
        _uriEnd ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _uriEnd;
    }

    ////@override
    int get uriOffset {
        _uriOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 2, 0);
        return _uriOffset;
    }
    }
public abstract class _UnlinkedExportNonPublicMixin
    : idl.UnlinkedExportNonPublic
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (offset != 0) _result["offset"] = offset;
        if (uriEnd != 0) _result["uriEnd"] = uriEnd;
        if (uriOffset != 0) _result["uriOffset"] = uriOffset;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "offset": offset,
        "uriEnd": uriEnd,
        "uriOffset": uriOffset,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedExportPublicBuilder : Object
    with _UnlinkedExportPublicMixin
    : idl.UnlinkedExportPublic
{
    List<UnlinkedCombinatorBuilder> _combinators;
    List<UnlinkedConfigurationBuilder> _configurations;
    String _uri;

    ////@override
    List<UnlinkedCombinatorBuilder> get combinators =>
        _combinators ??= new Dictionary<UnlinkedCombinatorBuilder>{};

/**
 * Combinators contained in this export declaration.
 */
void setcombinators(List<UnlinkedCombinatorBuilder> value)
{
    this._combinators = value;
}

////@override
List<UnlinkedConfigurationBuilder> get configurations =>
        _configurations ??= new List<UnlinkedConfigurationBuilder>{};

    /**
     * Configurations used to control which library will actually be loaded at
     * run-time.
     */
    void setconfigurations(List<UnlinkedConfigurationBuilder> value)
{
    this._configurations = value;
}

////@override
public String uri
{
    get => _uri ??= "";
}

/**
 * URI used in the source code to reference the exported library.
 */
void seturi(String value)
{
    this._uri = value;
}

UnlinkedExportPublicBuilder(
        {
    List<UnlinkedCombinatorBuilder> combinators,
   List< UnlinkedConfigurationBuilder > configurations,
      String uri)
      : _combinators = combinators,
        _configurations = configurations,
        _uri = uri;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _combinators?.forEach((b) => b.flushInformative());
        _configurations?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._uri ?? "");
        if (this._combinators == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._combinators.length);
            foreach (var x in this._combinators)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._configurations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._configurations.length);
            foreach (var x in this._configurations)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_combinators;
        fb.Offset offset_configurations;
        fb.Offset offset_uri;
        if (!(_combinators == null || _combinators.isEmpty))
        {
            offset_combinators = fbBuilder
                .writeList(_combinators.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_configurations == null || _configurations.isEmpty))
        {
            offset_configurations = fbBuilder
                .writeList(_configurations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_uri != null)
        {
            offset_uri = fbBuilder.writeString(_uri);
        }
        fbBuilder.startTable();
        if (offset_combinators != null)
        {
            fbBuilder.addOffset(1, offset_combinators);
        }
        if (offset_configurations != null)
        {
            fbBuilder.addOffset(2, offset_configurations);
        }
        if (offset_uri != null)
        {
            fbBuilder.addOffset(0, offset_uri);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedExportPublicReader
    : fb.TableReader<_UnlinkedExportPublicImpl>
{
    public _UnlinkedExportPublicReader();

    ////@override
    _UnlinkedExportPublicImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedExportPublicImpl(bc, offset);
}
public class _UnlinkedExportPublicImpl : Object
    with _UnlinkedExportPublicMixin
    : idl.UnlinkedExportPublic
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedExportPublicImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedCombinator> _combinators;
    List<idl.UnlinkedConfiguration> _configurations;
    String _uri;

    ////@override
    List<idl.UnlinkedCombinator> get combinators {
        _combinators ??= new fb.ListReader<idl.UnlinkedCombinator>(
public _UnlinkedCombinatorReader())
        .vTableGet(_bc, _bcOffset, 1, new List<idl.UnlinkedCombinator>{);
        return _combinators;
    }

////@override
List<idl.UnlinkedConfiguration> get configurations {
        _configurations ??= new fb.ListReader<idl.UnlinkedConfiguration>(
public _UnlinkedConfigurationReader())
        .vTableGet(_bc, _bcOffset, 2, new List<idl.UnlinkedConfiguration>{);
        return _configurations;
    }

    ////@override
    String get uri {
        _uri ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _uri;
    }
    }
public abstract class _UnlinkedExportPublicMixin : idl.UnlinkedExportPublic
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (combinators.isNotEmpty)
            _result["combinators"] =
                combinators.map((_value) => _value.toJson()).toList();
        if (configurations.isNotEmpty)
            _result["configurations"] =
                configurations.map((_value) => _value.toJson()).toList();
        if (uri != "") _result["uri"] = uri;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "combinators": combinators,
        "configurations": configurations,
        "uri": uri,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedExprBuilder : Object
    with _UnlinkedExprMixin
    : idl.UnlinkedExpr
{
    List<idl.UnlinkedExprAssignOperator> _assignmentOperators;
    List<double> _doubles;
    List<int> _ints;
    bool _isValidConst;
    List<idl.UnlinkedExprOperation> _operations;
    List<EntityRefBuilder> _references;
    List<String> _strings;

    ////@override
    List<idl.UnlinkedExprAssignOperator> get assignmentOperators =>
        _assignmentOperators ??= new Dictionary<idl.UnlinkedExprAssignOperator>{};

/**
 * Sequence of operators used by assignment operations.
 */
void setassignmentOperators(List<idl.UnlinkedExprAssignOperator> value)
{
    this._assignmentOperators = value;
}

////@override
public List<double> doubles
{
    get => _doubles ??= new List<double> { };
}

/**
 * Sequence of 64-bit doubles consumed by the operation `pushDouble`.
 */
void setdoubles(List<double> value)
{
    this._doubles = value;
}

////@override
public List<int> ints
{
    get => _ints ??= new List<int> { };
}

/**
 * Sequence of unsigned 32-bit integers consumed by the operations
 * `pushArgument`, `pushInt`, `shiftOr`, `concatenate`, `invokeConstructor`,
 * `makeList`, and `makeMap`.
 */
void setints(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._ints = value;
}

////@override
public bool isValidConst
{
    get => _isValidConst ??= false;
}

/**
 * Indicates whether the expression is a valid potentially constant
 * expression.
 */
void setisValidConst(bool value)
{
    this._isValidConst = value;
}

////@override
List<idl.UnlinkedExprOperation> get operations =>
        _operations ??= new Dictionary<idl.UnlinkedExprOperation>{};

    /**
     * Sequence of operations to execute (starting with an empty stack) to form
     * the constant value.
     */
    void setoperations(List<idl.UnlinkedExprOperation> value)
{
    this._operations = value;
}

////@override
public List<EntityRefBuilder> references
{
    get => _references ??= new List<EntityRefBuilder> { };
}

/**
 * Sequence of language constructs consumed by the operations
 * `pushReference`, `invokeConstructor`, `makeList`, and `makeMap`.  Note
 * that in the case of `pushReference` (and sometimes `invokeConstructor` the
 * actual entity being referred to may be something other than a type.
 */
void setreferences(List<EntityRefBuilder> value)
{
    this._references = value;
}

////@override
public List<String> strings
{
    get => _strings ??= new Dictionary<String> { };
}

/**
 * Sequence of strings consumed by the operations `pushString` and
 * `invokeConstructor`.
 */
void setstrings(List<String> value)
{
    this._strings = value;
}

UnlinkedExprBuilder(
        {
    List<idl.UnlinkedExprAssignOperator> assignmentOperators,
   List< double > doubles,
      List<int> ints,
      bool isValidConst,
      List< idl.UnlinkedExprOperation > operations,
      List<EntityRefBuilder> references,
      List< String > strings)
      : _assignmentOperators = assignmentOperators,
        _doubles = doubles,
        _ints = ints,
        _isValidConst = isValidConst,
        _operations = operations,
        _references = references,
        _strings = strings;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _references?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._operations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._operations.length);
            foreach (var x in this._operations)
            {
                signature.addInt(x.index);
            }
        }
        if (this._ints == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._ints.length);
            foreach (var x in this._ints)
            {
                signature.addInt(x);
            }
        }
        if (this._references == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._references.length);
            foreach (var x in this._references)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._strings == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._strings.length);
            foreach (var x in this._strings)
            {
                signature.addString(x);
            }
        }
        if (this._doubles == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._doubles.length);
            foreach (var x in this._doubles)
            {
                signature.addDouble(x);
            }
        }
        signature.addBool(this._isValidConst == true);
        if (this._assignmentOperators == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._assignmentOperators.length);
            foreach (var x in this._assignmentOperators)
            {
                signature.addInt(x.index);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_assignmentOperators;
        fb.Offset offset_doubles;
        fb.Offset offset_ints;
        fb.Offset offset_operations;
        fb.Offset offset_references;
        fb.Offset offset_strings;
        if (!(_assignmentOperators == null || _assignmentOperators.isEmpty))
        {
            offset_assignmentOperators = fbBuilder
                .writeListUint8(_assignmentOperators.map((b) => b.index).toList());
        }
        if (!(_doubles == null || _doubles.isEmpty))
        {
            offset_doubles = fbBuilder.writeListFloat64(_doubles);
        }
        if (!(_ints == null || _ints.isEmpty))
        {
            offset_ints = fbBuilder.writeListUint32(_ints);
        }
        if (!(_operations == null || _operations.isEmpty))
        {
            offset_operations =
                fbBuilder.writeListUint8(_operations.map((b) => b.index).toList());
        }
        if (!(_references == null || _references.isEmpty))
        {
            offset_references = fbBuilder
                .writeList(_references.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_strings == null || _strings.isEmpty))
        {
            offset_strings = fbBuilder
                .writeList(_strings.map((b) => fbBuilder.writeString(b)).toList());
        }
        fbBuilder.startTable();
        if (offset_assignmentOperators != null)
        {
            fbBuilder.addOffset(6, offset_assignmentOperators);
        }
        if (offset_doubles != null)
        {
            fbBuilder.addOffset(4, offset_doubles);
        }
        if (offset_ints != null)
        {
            fbBuilder.addOffset(1, offset_ints);
        }
        if (_isValidConst == true)
        {
            fbBuilder.addBool(5, true);
        }
        if (offset_operations != null)
        {
            fbBuilder.addOffset(0, offset_operations);
        }
        if (offset_references != null)
        {
            fbBuilder.addOffset(2, offset_references);
        }
        if (offset_strings != null)
        {
            fbBuilder.addOffset(3, offset_strings);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedExprReader : fb.TableReader<_UnlinkedExprImpl>
{
    public _UnlinkedExprReader();

    ////@override
    _UnlinkedExprImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedExprImpl(bc, offset);
}
public class _UnlinkedExprImpl : Object
    with _UnlinkedExprMixin
    : idl.UnlinkedExpr
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedExprImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExprAssignOperator> _assignmentOperators;
    List<double> _doubles;
    List<int> _ints;
    bool _isValidConst;
    List<idl.UnlinkedExprOperation> _operations;
    List<idl.EntityRef> _references;
    List<String> _strings;

    ////@override
    List<idl.UnlinkedExprAssignOperator> get assignmentOperators {
        _assignmentOperators ??=
public fb.ListReader<idl.UnlinkedExprAssignOperator>(
public _UnlinkedExprAssignOperatorReader())
            .vTableGet(
                _bc, _bcOffset, 6, new List<idl.UnlinkedExprAssignOperator>{);
        return _assignmentOperators;
    }

////@override
List<double> get doubles {
        _doubles ??= new fb.Float64ListReader()
          .vTableGet(_bc, _bcOffset, 4, new List<double>{);
        return _doubles;
    }

    ////@override
    List<int> get ints {
        _ints ??=
public fb.Uint32ListReader().vTableGet(_bc, _bcOffset, 1, new List<int>{);
        return _ints;
    }

    ////@override
    bool get isValidConst {
        _isValidConst ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 5, false);
        return _isValidConst;
    }

    ////@override
    List<idl.UnlinkedExprOperation> get operations {
        _operations ??= new fb.ListReader<idl.UnlinkedExprOperation>(
public _UnlinkedExprOperationReader())
        .vTableGet(_bc, _bcOffset, 0, new List<idl.UnlinkedExprOperation>{);
        return _operations;
    }

    ////@override
    List<idl.EntityRef> get references {
        _references ??= new fb.ListReader<idl.EntityRef>(const _EntityRefReader())
        .vTableGet(_bc, _bcOffset, 2, new List<idl.EntityRef>{);
        return _references;
    }

    ////@override
    List<String> get strings {
        _strings ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 3, new List<String>{);
        return _strings;
    }
    }
public abstract class _UnlinkedExprMixin : idl.UnlinkedExpr
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (assignmentOperators.isNotEmpty)
            _result["assignmentOperators"] = assignmentOperators
                .map((_value) => _value.toString().split(".")[1])
                .toList();
        if (doubles.isNotEmpty)
            _result["doubles"] = doubles
                .map((_value) => _value.isFinite ? _value : _value.toString())
                .toList();
        if (ints.isNotEmpty) _result["ints"] = ints;
        if (isValidConst != false) _result["isValidConst"] = isValidConst;
        if (operations.isNotEmpty)
            _result["operations"] =
                operations.map((_value) => _value.toString().split(".")[1]).toList();
        if (references.isNotEmpty)
            _result["references"] =
                references.map((_value) => _value.toJson()).toList();
        if (strings.isNotEmpty) _result["strings"] = strings;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "assignmentOperators": assignmentOperators,
        "doubles": doubles,
        "ints": ints,
        "isValidConst": isValidConst,
        "operations": operations,
        "references": references,
        "strings": strings,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedImportBuilder : Object
    with _UnlinkedImportMixin
    : idl.UnlinkedImport
{
    List<UnlinkedExprBuilder> _annotations;
    List<UnlinkedCombinatorBuilder> _combinators;
    List<UnlinkedConfigurationBuilder> _configurations;
    bool _isDeferred;
    bool _isImplicit;
    int _offset;
    int _prefixOffset;
    int _prefixReference;
    String _uri;
    int _uriEnd;
    int _uriOffset;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this import declaration.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
List<UnlinkedCombinatorBuilder> get combinators =>
        _combinators ??= new List<UnlinkedCombinatorBuilder>{};

    /**
     * Combinators contained in this import declaration.
     */
    void setcombinators(List<UnlinkedCombinatorBuilder> value)
{
    this._combinators = value;
}

////@override
List<UnlinkedConfigurationBuilder> get configurations =>
        _configurations ??= new List<UnlinkedConfigurationBuilder>{};

    /**
     * Configurations used to control which library will actually be loaded at
     * run-time.
     */
    void setconfigurations(List<UnlinkedConfigurationBuilder> value)
{
    this._configurations = value;
}

////@override
public bool isDeferred
{
    get => _isDeferred ??= false;
}

/**
 * Indicates whether the import declaration uses the `deferred` keyword.
 */
void setisDeferred(bool value)
{
    this._isDeferred = value;
}

////@override
public bool isImplicit
{
    get => _isImplicit ??= false;
}

/**
 * Indicates whether the import declaration is implicit.
 */
void setisImplicit(bool value)
{
    this._isImplicit = value;
}

////@override
public int offset
{
    get => _offset ??= 0;
}

/**
 * If [isImplicit] is false, offset of the "import" keyword.  If [isImplicit]
 * is true, zero.
 */
void setoffset(int value)
{
    assert(value == null || value >= 0);
    this._offset = value;
}

////@override
public int prefixOffset
{
    get => _prefixOffset ??= 0;
}

/**
 * Offset of the prefix name relative to the beginning of the file, or zero
 * if there is no prefix.
 */
void setprefixOffset(int value)
{
    assert(value == null || value >= 0);
    this._prefixOffset = value;
}

////@override
public int prefixReference
{
    get => _prefixReference ??= 0;
}

/**
 * Index into [UnlinkedUnit.references] of the prefix declared by this
 * import declaration, or zero if this import declaration declares no prefix.
 *
 * Note that multiple imports can declare the same prefix.
 */
void setprefixReference(int value)
{
    assert(value == null || value >= 0);
    this._prefixReference = value;
}

////@override
public String uri
{
    get => _uri ??= "";
}

/**
 * URI used in the source code to reference the imported library.
 */
void seturi(String value)
{
    this._uri = value;
}

////@override
public int uriEnd
{
    get => _uriEnd ??= 0;
}

/**
 * End of the URI string (including quotes) relative to the beginning of the
 * file.  If [isImplicit] is true, zero.
 */
void seturiEnd(int value)
{
    assert(value == null || value >= 0);
    this._uriEnd = value;
}

////@override
public int uriOffset
{
    get => _uriOffset ??= 0;
}

/**
 * Offset of the URI string (including quotes) relative to the beginning of
 * the file.  If [isImplicit] is true, zero.
 */
void seturiOffset(int value)
{
    assert(value == null || value >= 0);
    this._uriOffset = value;
}

UnlinkedImportBuilder(
        {
    List<UnlinkedExprBuilder> annotations,
   List< UnlinkedCombinatorBuilder > combinators,
      List<UnlinkedConfigurationBuilder> configurations,
      bool isDeferred,
      bool isImplicit,
      int offset,
      int prefixOffset,
      int prefixReference,
      String uri,
      int uriEnd,
      int uriOffset)
      : _annotations = annotations,
        _combinators = combinators,
        _configurations = configurations,
        _isDeferred = isDeferred,
        _isImplicit = isImplicit,
        _offset = offset,
        _prefixOffset = prefixOffset,
        _prefixReference = prefixReference,
        _uri = uri,
        _uriEnd = uriEnd,
        _uriOffset = uriOffset;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _combinators?.forEach((b) => b.flushInformative());
        _configurations?.forEach((b) => b.flushInformative());
        _offset = null;
        _prefixOffset = null;
        _uriEnd = null;
        _uriOffset = null;
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._uri ?? "");
        if (this._combinators == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._combinators.length);
            foreach (var x in this._combinators)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._isImplicit == true);
        signature.addInt(this._prefixReference ?? 0);
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._isDeferred == true);
        if (this._configurations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._configurations.length);
            foreach (var x in this._configurations)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        fb.Offset offset_combinators;
        fb.Offset offset_configurations;
        fb.Offset offset_uri;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_combinators == null || _combinators.isEmpty))
        {
            offset_combinators = fbBuilder
                .writeList(_combinators.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_configurations == null || _configurations.isEmpty))
        {
            offset_configurations = fbBuilder
                .writeList(_configurations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_uri != null)
        {
            offset_uri = fbBuilder.writeString(_uri);
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(8, offset_annotations);
        }
        if (offset_combinators != null)
        {
            fbBuilder.addOffset(4, offset_combinators);
        }
        if (offset_configurations != null)
        {
            fbBuilder.addOffset(10, offset_configurations);
        }
        if (_isDeferred == true)
        {
            fbBuilder.addBool(9, true);
        }
        if (_isImplicit == true)
        {
            fbBuilder.addBool(5, true);
        }
        if (_offset != null && _offset != 0)
        {
            fbBuilder.addUint32(0, _offset);
        }
        if (_prefixOffset != null && _prefixOffset != 0)
        {
            fbBuilder.addUint32(6, _prefixOffset);
        }
        if (_prefixReference != null && _prefixReference != 0)
        {
            fbBuilder.addUint32(7, _prefixReference);
        }
        if (offset_uri != null)
        {
            fbBuilder.addOffset(1, offset_uri);
        }
        if (_uriEnd != null && _uriEnd != 0)
        {
            fbBuilder.addUint32(2, _uriEnd);
        }
        if (_uriOffset != null && _uriOffset != 0)
        {
            fbBuilder.addUint32(3, _uriOffset);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedImportReader : fb.TableReader<_UnlinkedImportImpl>
{
    public _UnlinkedImportReader();

    ////@override
    _UnlinkedImportImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedImportImpl(bc, offset);
}
public class _UnlinkedImportImpl : Object
    with _UnlinkedImportMixin
    : idl.UnlinkedImport
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedImportImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    List<idl.UnlinkedCombinator> _combinators;
    List<idl.UnlinkedConfiguration> _configurations;
    bool _isDeferred;
    bool _isImplicit;
    int _offset;
    int _prefixOffset;
    int _prefixReference;
    String _uri;
    int _uriEnd;
    int _uriOffset;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 8, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
List<idl.UnlinkedCombinator> get combinators {
        _combinators ??= new fb.ListReader<idl.UnlinkedCombinator>(
public _UnlinkedCombinatorReader())
        .vTableGet(_bc, _bcOffset, 4, new List<idl.UnlinkedCombinator>{);
        return _combinators;
    }

    ////@override
    List<idl.UnlinkedConfiguration> get configurations {
        _configurations ??= new fb.ListReader<idl.UnlinkedConfiguration>(
public _UnlinkedConfigurationReader())
        .vTableGet(_bc, _bcOffset, 10, new List<idl.UnlinkedConfiguration>{);
        return _configurations;
    }

    ////@override
    bool get isDeferred {
        _isDeferred ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 9, false);
        return _isDeferred;
    }

    ////@override
    bool get isImplicit {
        _isImplicit ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 5, false);
        return _isImplicit;
    }

    ////@override
    int get offset {
        _offset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _offset;
    }

    ////@override
    int get prefixOffset {
        _prefixOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 6, 0);
        return _prefixOffset;
    }

    ////@override
    int get prefixReference {
        _prefixReference ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 7, 0);
        return _prefixReference;
    }

    ////@override
    String get uri {
        _uri ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 1, "");
        return _uri;
    }

    ////@override
    int get uriEnd {
        _uriEnd ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 2, 0);
        return _uriEnd;
    }

    ////@override
    int get uriOffset {
        _uriOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 3, 0);
        return _uriOffset;
    }
    }
public abstract class _UnlinkedImportMixin : idl.UnlinkedImport
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (combinators.isNotEmpty)
            _result["combinators"] =
                combinators.map((_value) => _value.toJson()).toList();
        if (configurations.isNotEmpty)
            _result["configurations"] =
                configurations.map((_value) => _value.toJson()).toList();
        if (isDeferred != false) _result["isDeferred"] = isDeferred;
        if (isImplicit != false) _result["isImplicit"] = isImplicit;
        if (offset != 0) _result["offset"] = offset;
        if (prefixOffset != 0) _result["prefixOffset"] = prefixOffset;
        if (prefixReference != 0) _result["prefixReference"] = prefixReference;
        if (uri != "") _result["uri"] = uri;
        if (uriEnd != 0) _result["uriEnd"] = uriEnd;
        if (uriOffset != 0) _result["uriOffset"] = uriOffset;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "combinators": combinators,
        "configurations": configurations,
        "isDeferred": isDeferred,
        "isImplicit": isImplicit,
        "offset": offset,
        "prefixOffset": prefixOffset,
        "prefixReference": prefixReference,
        "uri": uri,
        "uriEnd": uriEnd,
        "uriOffset": uriOffset,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedParamBuilder : Object
    with _UnlinkedParamMixin
    : idl.UnlinkedParam
{
    List<UnlinkedExprBuilder> _annotations;
    CodeRangeBuilder _codeRange;
    String _defaultValueCode;
    int _inferredTypeSlot;
    int _inheritsCovariantSlot;
    UnlinkedExecutableBuilder _initializer;
    bool _isExplicitlyCovariant;
    bool _isFinal;
    bool _isFunctionTyped;
    bool _isInitializingFormal;
    idl.UnlinkedParamKind _kind;
    String _name;
    int _nameOffset;
    List<UnlinkedParamBuilder> _parameters;
    EntityRefBuilder _type;
    int _visibleLength;
    int _visibleOffset;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this parameter.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
public CodeRangeBuilder codeRange
{
    get => _codeRange;
}

/**
 * Code range of the parameter.
 */
void setcodeRange(CodeRangeBuilder value)
{
    this._codeRange = value;
}

////@override
public String defaultValueCode
{
    get => _defaultValueCode ??= "";
}

/**
 * If the parameter has a default value, the source text of the constant
 * expression in the default value.  Otherwise the empty string.
 */
void setdefaultValueCode(String value)
{
    this._defaultValueCode = value;
}

////@override
public int inferredTypeSlot
{
    get => _inferredTypeSlot ??= 0;
}

/**
 * If this parameter's type is inferable, nonzero slot id identifying which
 * entry in [LinkedLibrary.types] contains the inferred type.  If there is no
 * matching entry in [LinkedLibrary.types], then no type was inferred for
 * this variable, so its static type is `dynamic`.
 *
 * Note that although strong mode considers initializing formals to be
 * inferable, they are not marked as such in the summary; if their type is
 * not specified, they always inherit the static type of the corresponding
 * field.
 */
void setinferredTypeSlot(int value)
{
    assert(value == null || value >= 0);
    this._inferredTypeSlot = value;
}

////@override
public int inheritsCovariantSlot
{
    get => _inheritsCovariantSlot ??= 0;
}

/**
 * If this is a parameter of an instance method, a nonzero slot id which is
 * unique within this compilation unit.  If this id is found in
 * [LinkedUnit.parametersInheritingCovariant], then this parameter inherits
 * `//@covariant` behavior from a base class.
 *
 * Otherwise, zero.
 */
void setinheritsCovariantSlot(int value)
{
    assert(value == null || value >= 0);
    this._inheritsCovariantSlot = value;
}

////@override
public UnlinkedExecutableBuilder initializer
{
    get => _initializer;
}

/**
 * The synthetic initializer function of the parameter.  Absent if the
 * variable does not have an initializer.
 */
void setinitializer(UnlinkedExecutableBuilder value)
{
    this._initializer = value;
}

////@override
public bool isExplicitlyCovariant
{
    get => _isExplicitlyCovariant ??= false;
}

/**
 * Indicates whether this parameter is explicitly marked as being covariant.
 */
void setisExplicitlyCovariant(bool value)
{
    this._isExplicitlyCovariant = value;
}

////@override
public bool isFinal
{
    get => _isFinal ??= false;
}

/**
 * Indicates whether the parameter is declared using the `final` keyword.
 */
void setisFinal(bool value)
{
    this._isFinal = value;
}

////@override
public bool isFunctionTyped
{
    get => _isFunctionTyped ??= false;
}

/**
 * Indicates whether this is a function-typed parameter. A parameter is
 * function-typed if the declaration of the parameter has explicit formal
 * parameters
 * ```
 * int functionTyped(int p)
 * ```
 * but is not function-typed if it does not, even if the type of the parameter
 * is a function type.
 */
void setisFunctionTyped(bool value)
{
    this._isFunctionTyped = value;
}

////@override
public bool isInitializingFormal
{
    get => _isInitializingFormal ??= false;
}

/**
 * Indicates whether this is an initializing formal parameter (i.e. it is
 * declared using `this.` syntax).
 */
void setisInitializingFormal(bool value)
{
    this._isInitializingFormal = value;
}

////@override
public idl.UnlinkedParamKind kind
{
    get => _kind ??= idl.UnlinkedParamKind.required;
}

/**
 * Kind of the parameter.
 */
void setkind(idl.UnlinkedParamKind value)
{
    this._kind = value;
}

////@override
public String name
{
    get => _name ??= "";
}

/**
 * Name of the parameter.
 */
void setname(String value)
{
    this._name = value;
}

////@override
public int nameOffset
{
    get => _nameOffset ??= 0;
}

/**
 * Offset of the parameter name relative to the beginning of the file.
 */
void setnameOffset(int value)
{
    assert(value == null || value >= 0);
    this._nameOffset = value;
}

////@override
List<UnlinkedParamBuilder> get parameters =>
        _parameters ??= new Dictionary<UnlinkedParamBuilder>{};

    /**
     * If [isFunctionTyped] is `true`, the parameters of the function type.
     */
    void setparameters(List<UnlinkedParamBuilder> value)
{
    this._parameters = value;
}

////@override
public EntityRefBuilder type
{
    get => _type;
}

/**
 * If [isFunctionTyped] is `true`, the declared return type.  If
 * [isFunctionTyped] is `false`, the declared type.  Absent if the type is
 * implicit.
 */
void settype(EntityRefBuilder value)
{
    this._type = value;
}

////@override
public int visibleLength
{
    get => _visibleLength ??= 0;
}

/**
 * The length of the visible range.
 */
void setvisibleLength(int value)
{
    assert(value == null || value >= 0);
    this._visibleLength = value;
}

////@override
public int visibleOffset
{
    get => _visibleOffset ??= 0;
}

/**
 * The beginning of the visible range.
 */
void setvisibleOffset(int value)
{
    assert(value == null || value >= 0);
    this._visibleOffset = value;
}

UnlinkedParamBuilder(
        {
    List<UnlinkedExprBuilder> annotations,
   CodeRangeBuilder codeRange,
      String defaultValueCode,
      int inferredTypeSlot,
      int inheritsCovariantSlot,
      UnlinkedExecutableBuilder initializer,
      bool isExplicitlyCovariant,
      bool isFinal,
      bool isFunctionTyped,
      bool isInitializingFormal,
      idl.UnlinkedParamKind kind,
      String name,
      int nameOffset,
      List< UnlinkedParamBuilder > parameters,
      EntityRefBuilder type,
      int visibleLength,
      int visibleOffset)
      : _annotations = annotations,
        _codeRange = codeRange,
        _defaultValueCode = defaultValueCode,
        _inferredTypeSlot = inferredTypeSlot,
        _inheritsCovariantSlot = inheritsCovariantSlot,
        _initializer = initializer,
        _isExplicitlyCovariant = isExplicitlyCovariant,
        _isFinal = isFinal,
        _isFunctionTyped = isFunctionTyped,
        _isInitializingFormal = isInitializingFormal,
        _kind = kind,
        _name = name,
        _nameOffset = nameOffset,
        _parameters = parameters,
        _type = type,
        _visibleLength = visibleLength,
        _visibleOffset = visibleOffset;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _codeRange = null;
        _defaultValueCode = null;
        _initializer?.flushInformative();
        _nameOffset = null;
        _parameters?.forEach((b) => b.flushInformative());
        _type?.flushInformative();
        _visibleLength = null;
        _visibleOffset = null;
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        signature.addInt(this._inferredTypeSlot ?? 0);
        signature.addBool(this._type != null);
        this._type?.collectApiSignature(signature);
        signature.addInt(this._kind == null ? 0 : this._kind.index);
        signature.addBool(this._isFunctionTyped == true);
        signature.addBool(this._isInitializingFormal == true);
        if (this._parameters == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._parameters.length);
            foreach (var x in this._parameters)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._initializer != null);
        this._initializer?.collectApiSignature(signature);
        signature.addInt(this._inheritsCovariantSlot ?? 0);
        signature.addBool(this._isExplicitlyCovariant == true);
        signature.addBool(this._isFinal == true);
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        fb.Offset offset_codeRange;
        fb.Offset offset_defaultValueCode;
        fb.Offset offset_initializer;
        fb.Offset offset_name;
        fb.Offset offset_parameters;
        fb.Offset offset_type;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_codeRange != null)
        {
            offset_codeRange = _codeRange.finish(fbBuilder);
        }
        if (_defaultValueCode != null)
        {
            offset_defaultValueCode = fbBuilder.writeString(_defaultValueCode);
        }
        if (_initializer != null)
        {
            offset_initializer = _initializer.finish(fbBuilder);
        }
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        if (!(_parameters == null || _parameters.isEmpty))
        {
            offset_parameters = fbBuilder
                .writeList(_parameters.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_type != null)
        {
            offset_type = _type.finish(fbBuilder);
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(9, offset_annotations);
        }
        if (offset_codeRange != null)
        {
            fbBuilder.addOffset(7, offset_codeRange);
        }
        if (offset_defaultValueCode != null)
        {
            fbBuilder.addOffset(13, offset_defaultValueCode);
        }
        if (_inferredTypeSlot != null && _inferredTypeSlot != 0)
        {
            fbBuilder.addUint32(2, _inferredTypeSlot);
        }
        if (_inheritsCovariantSlot != null && _inheritsCovariantSlot != 0)
        {
            fbBuilder.addUint32(14, _inheritsCovariantSlot);
        }
        if (offset_initializer != null)
        {
            fbBuilder.addOffset(12, offset_initializer);
        }
        if (_isExplicitlyCovariant == true)
        {
            fbBuilder.addBool(15, true);
        }
        if (_isFinal == true)
        {
            fbBuilder.addBool(16, true);
        }
        if (_isFunctionTyped == true)
        {
            fbBuilder.addBool(5, true);
        }
        if (_isInitializingFormal == true)
        {
            fbBuilder.addBool(6, true);
        }
        if (_kind != null && _kind != idl.UnlinkedParamKind.required)
        {
            fbBuilder.addUint8(4, _kind.index);
        }
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        if (_nameOffset != null && _nameOffset != 0)
        {
            fbBuilder.addUint32(1, _nameOffset);
        }
        if (offset_parameters != null)
        {
            fbBuilder.addOffset(8, offset_parameters);
        }
        if (offset_type != null)
        {
            fbBuilder.addOffset(3, offset_type);
        }
        if (_visibleLength != null && _visibleLength != 0)
        {
            fbBuilder.addUint32(10, _visibleLength);
        }
        if (_visibleOffset != null && _visibleOffset != 0)
        {
            fbBuilder.addUint32(11, _visibleOffset);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedParamReader : fb.TableReader<_UnlinkedParamImpl>
{
    public _UnlinkedParamReader();

    ////@override
    _UnlinkedParamImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedParamImpl(bc, offset);
}
public class _UnlinkedParamImpl : Object
    with _UnlinkedParamMixin
    : idl.UnlinkedParam
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedParamImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    idl.CodeRange _codeRange;
    String _defaultValueCode;
    int _inferredTypeSlot;
    int _inheritsCovariantSlot;
    idl.UnlinkedExecutable _initializer;
    bool _isExplicitlyCovariant;
    bool _isFinal;
    bool _isFunctionTyped;
    bool _isInitializingFormal;
    idl.UnlinkedParamKind _kind;
    String _name;
    int _nameOffset;
    List<idl.UnlinkedParam> _parameters;
    idl.EntityRef _type;
    int _visibleLength;
    int _visibleOffset;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 9, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
idl.CodeRange get codeRange {
        _codeRange ??= new _CodeRangeReader().vTableGet(_bc, _bcOffset, 7, null);
        return _codeRange;
    }

    ////@override
    String get defaultValueCode {
        _defaultValueCode ??=
public fb.StringReader().vTableGet(_bc, _bcOffset, 13, "");
        return _defaultValueCode;
    }

    ////@override
    int get inferredTypeSlot {
        _inferredTypeSlot ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 2, 0);
        return _inferredTypeSlot;
    }

    ////@override
    int get inheritsCovariantSlot {
        _inheritsCovariantSlot ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 14, 0);
        return _inheritsCovariantSlot;
    }

    ////@override
    idl.UnlinkedExecutable get initializer {
        _initializer ??=
public _UnlinkedExecutableReader().vTableGet(_bc, _bcOffset, 12, null);
        return _initializer;
    }

    ////@override
    bool get isExplicitlyCovariant {
        _isExplicitlyCovariant ??=
public fb.BoolReader().vTableGet(_bc, _bcOffset, 15, false);
        return _isExplicitlyCovariant;
    }

    ////@override
    bool get isFinal {
        _isFinal ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 16, false);
        return _isFinal;
    }

    ////@override
    bool get isFunctionTyped {
        _isFunctionTyped ??=
public fb.BoolReader().vTableGet(_bc, _bcOffset, 5, false);
        return _isFunctionTyped;
    }

    ////@override
    bool get isInitializingFormal {
        _isInitializingFormal ??=
public fb.BoolReader().vTableGet(_bc, _bcOffset, 6, false);
        return _isInitializingFormal;
    }

    ////@override
    idl.UnlinkedParamKind get kind {
        _kind ??= new _UnlinkedParamKindReader()
          .vTableGet(_bc, _bcOffset, 4, idl.UnlinkedParamKind.required);
        return _kind;
    }

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }

    ////@override
    int get nameOffset {
        _nameOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _nameOffset;
    }

    ////@override
    List<idl.UnlinkedParam> get parameters {
        _parameters ??=
public fb.ListReader<idl.UnlinkedParam>(const _UnlinkedParamReader())
            .vTableGet(_bc, _bcOffset, 8, new List<idl.UnlinkedParam>{);
        return _parameters;
    }

    ////@override
    idl.EntityRef get type {
        _type ??= new _EntityRefReader().vTableGet(_bc, _bcOffset, 3, null);
        return _type;
    }

    ////@override
    int get visibleLength {
        _visibleLength ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 10, 0);
        return _visibleLength;
    }

    ////@override
    int get visibleOffset {
        _visibleOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 11, 0);
        return _visibleOffset;
    }
    }
public abstract class _UnlinkedParamMixin : idl.UnlinkedParam
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (codeRange != null) _result["codeRange"] = codeRange.toJson();
        if (defaultValueCode != "") _result["defaultValueCode"] = defaultValueCode;
        if (inferredTypeSlot != 0) _result["inferredTypeSlot"] = inferredTypeSlot;
        if (inheritsCovariantSlot != 0)
            _result["inheritsCovariantSlot"] = inheritsCovariantSlot;
        if (initializer != null) _result["initializer"] = initializer.toJson();
        if (isExplicitlyCovariant != false)
            _result["isExplicitlyCovariant"] = isExplicitlyCovariant;
        if (isFinal != false) _result["isFinal"] = isFinal;
        if (isFunctionTyped != false) _result["isFunctionTyped"] = isFunctionTyped;
        if (isInitializingFormal != false)
            _result["isInitializingFormal"] = isInitializingFormal;
        if (kind != idl.UnlinkedParamKind.required)
            _result["kind"] = kind.toString().split(".")[1];
        if (name != "") _result["name"] = name;
        if (nameOffset != 0) _result["nameOffset"] = nameOffset;
        if (parameters.isNotEmpty)
            _result["parameters"] =
                parameters.map((_value) => _value.toJson()).toList();
        if (type != null) _result["type"] = type.toJson();
        if (visibleLength != 0) _result["visibleLength"] = visibleLength;
        if (visibleOffset != 0) _result["visibleOffset"] = visibleOffset;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "codeRange": codeRange,
        "defaultValueCode": defaultValueCode,
        "inferredTypeSlot": inferredTypeSlot,
        "inheritsCovariantSlot": inheritsCovariantSlot,
        "initializer": initializer,
        "isExplicitlyCovariant": isExplicitlyCovariant,
        "isFinal": isFinal,
        "isFunctionTyped": isFunctionTyped,
        "isInitializingFormal": isInitializingFormal,
        "kind": kind,
        "name": name,
        "nameOffset": nameOffset,
        "parameters": parameters,
        "type": type,
        "visibleLength": visibleLength,
        "visibleOffset": visibleOffset,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedPartBuilder : Object
    with _UnlinkedPartMixin
    : idl.UnlinkedPart
{
    List<UnlinkedExprBuilder> _annotations;
    int _uriEnd;
    int _uriOffset;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this part declaration.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
public int uriEnd
{
    get => _uriEnd ??= 0;
}

/**
 * End of the URI string (including quotes) relative to the beginning of the
 * file.
 */
void seturiEnd(int value)
{
    assert(value == null || value >= 0);
    this._uriEnd = value;
}

////@override
public int uriOffset
{
    get => _uriOffset ??= 0;
}

/**
 * Offset of the URI string (including quotes) relative to the beginning of
 * the file.
 */
void seturiOffset(int value)
{
    assert(value == null || value >= 0);
    this._uriOffset = value;
}

UnlinkedPartBuilder(
        {
    List<UnlinkedExprBuilder> annotations, int uriEnd, int uriOffset)
      : _annotations = annotations,
        _uriEnd = uriEnd,
        _uriOffset = uriOffset;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _uriEnd = null;
        _uriOffset = null;
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(2, offset_annotations);
        }
        if (_uriEnd != null && _uriEnd != 0)
        {
            fbBuilder.addUint32(0, _uriEnd);
        }
        if (_uriOffset != null && _uriOffset != 0)
        {
            fbBuilder.addUint32(1, _uriOffset);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedPartReader : fb.TableReader<_UnlinkedPartImpl>
{
    public _UnlinkedPartReader();

    ////@override
    _UnlinkedPartImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedPartImpl(bc, offset);
}
public class _UnlinkedPartImpl : Object
    with _UnlinkedPartMixin
    : idl.UnlinkedPart
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedPartImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    int _uriEnd;
    int _uriOffset;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 2, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
int get uriEnd {
        _uriEnd ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 0, 0);
        return _uriEnd;
    }

    ////@override
    int get uriOffset {
        _uriOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _uriOffset;
    }
    }
public abstract class _UnlinkedPartMixin : idl.UnlinkedPart
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (uriEnd != 0) _result["uriEnd"] = uriEnd;
        if (uriOffset != 0) _result["uriOffset"] = uriOffset;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "uriEnd": uriEnd,
        "uriOffset": uriOffset,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedPublicNameBuilder : Object
    with _UnlinkedPublicNameMixin
    : idl.UnlinkedPublicName
{
    idl.ReferenceKind _kind;
    List<UnlinkedPublicNameBuilder> _members;
    String _name;
    int _numTypeParameters;

    ////@override
    public idl.ReferenceKind kind
    {
        get => _kind ??= idl.ReferenceKind.classOrEnum;
    }

    /**
     * The kind of object referred to by the name.
     */
    void setkind(idl.ReferenceKind value)
    {
        this._kind = value;
    }

    ////@override
    List<UnlinkedPublicNameBuilder> get members =>
        _members ??= new Dictionary<UnlinkedPublicNameBuilder>{};

/**
 * If this [UnlinkedPublicName] is a class, the list of members which can be
 * referenced statically - static fields, static methods, and constructors.
 * Otherwise empty.
 *
 * Unnamed constructors are not included since they do not constitute a
 * separate name added to any namespace.
 */
void setmembers(List<UnlinkedPublicNameBuilder> value)
{
    this._members = value;
}

////@override
public String name
{
    get => _name ??= "";
}

/**
 * The name itself.
 */
void setname(String value)
{
    this._name = value;
}

////@override
public int numTypeParameters
{
    get => _numTypeParameters ??= 0;
}

/**
 * If the entity being referred to is generic, the number of type parameters
 * it accepts.  Otherwise zero.
 */
void setnumTypeParameters(int value)
{
    assert(value == null || value >= 0);
    this._numTypeParameters = value;
}

UnlinkedPublicNameBuilder(
        {
    idl.ReferenceKind kind,
   List< UnlinkedPublicNameBuilder > members,
      String name,
      int numTypeParameters)
      : _kind = kind,
        _members = members,
        _name = name,
        _numTypeParameters = numTypeParameters;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _members?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        signature.addInt(this._kind == null ? 0 : this._kind.index);
        if (this._members == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._members.length);
            foreach (var x in this._members)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addInt(this._numTypeParameters ?? 0);
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_members;
        fb.Offset offset_name;
        if (!(_members == null || _members.isEmpty))
        {
            offset_members = fbBuilder
                .writeList(_members.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        fbBuilder.startTable();
        if (_kind != null && _kind != idl.ReferenceKind.classOrEnum)
        {
            fbBuilder.addUint8(1, _kind.index);
        }
        if (offset_members != null)
        {
            fbBuilder.addOffset(2, offset_members);
        }
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        if (_numTypeParameters != null && _numTypeParameters != 0)
        {
            fbBuilder.addUint32(3, _numTypeParameters);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedPublicNameReader
    : fb.TableReader<_UnlinkedPublicNameImpl>
{
    public _UnlinkedPublicNameReader();

    ////@override
    _UnlinkedPublicNameImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedPublicNameImpl(bc, offset);
}
public class _UnlinkedPublicNameImpl : Object
    with _UnlinkedPublicNameMixin
    : idl.UnlinkedPublicName
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedPublicNameImpl(this._bc, this._bcOffset);

    idl.ReferenceKind _kind;
    List<idl.UnlinkedPublicName> _members;
    String _name;
    int _numTypeParameters;

    ////@override
    idl.ReferenceKind get kind {
        _kind ??= new _ReferenceKindReader()
          .vTableGet(_bc, _bcOffset, 1, idl.ReferenceKind.classOrEnum);
        return _kind;
    }

////@override
List<idl.UnlinkedPublicName> get members {
        _members ??= new fb.ListReader<idl.UnlinkedPublicName>(
public _UnlinkedPublicNameReader())
        .vTableGet(_bc, _bcOffset, 2, new List<idl.UnlinkedPublicName>{);
        return _members;
    }

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }

    ////@override
    int get numTypeParameters {
        _numTypeParameters ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 3, 0);
        return _numTypeParameters;
    }
    }
public abstract class _UnlinkedPublicNameMixin : idl.UnlinkedPublicName
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (kind != idl.ReferenceKind.classOrEnum)
            _result["kind"] = kind.toString().split(".")[1];
        if (members.isNotEmpty)
            _result["members"] = members.map((_value) => _value.toJson()).toList();
        if (name != "") _result["name"] = name;
        if (numTypeParameters != 0)
            _result["numTypeParameters"] = numTypeParameters;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "kind": kind,
        "members": members,
        "name": name,
        "numTypeParameters": numTypeParameters,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedPublicNamespaceBuilder : Object
    with _UnlinkedPublicNamespaceMixin
    : idl.UnlinkedPublicNamespace
{
    List<UnlinkedExportPublicBuilder> _exports;
    List<UnlinkedPublicNameBuilder> _names;
    List<String> _parts;

    ////@override
    List<UnlinkedExportPublicBuilder> get exports =>
        _exports ??= new Dictionary<UnlinkedExportPublicBuilder>{};

/**
 * Export declarations in the compilation unit.
 */
void setexports(List<UnlinkedExportPublicBuilder> value)
{
    this._exports = value;
}

////@override
List<UnlinkedPublicNameBuilder> get names =>
        _names ??= new List<UnlinkedPublicNameBuilder>{};

    /**
     * Public names defined in the compilation unit.
     *
     * TODO(paulberry): consider sorting these names to reduce unnecessary
     * relinking.
     */
    void setnames(List<UnlinkedPublicNameBuilder> value)
{
    this._names = value;
}

////@override
public List<String> parts
{
    get => _parts ??= new List<String> { };
}

/**
 * URIs referenced by part declarations in the compilation unit.
 */
void setparts(List<String> value)
{
    this._parts = value;
}

UnlinkedPublicNamespaceBuilder(
        {
    List<UnlinkedExportPublicBuilder> exports,
   List< UnlinkedPublicNameBuilder > names,
      List<String> parts)
      : _exports = exports,
        _names = names,
        _parts = parts;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _exports?.forEach((b) => b.flushInformative());
        _names?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        if (this._names == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._names.length);
            foreach (var x in this._names)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._parts == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._parts.length);
            foreach (var x in this._parts)
            {
                signature.addString(x);
            }
        }
        if (this._exports == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._exports.length);
            foreach (var x in this._exports)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    List<int> toBuffer()
    {
        fb.Builder fbBuilder = new fb.Builder();
        return fbBuilder.finish(finish(fbBuilder), "UPNS");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_exports;
        fb.Offset offset_names;
        fb.Offset offset_parts;
        if (!(_exports == null || _exports.isEmpty))
        {
            offset_exports = fbBuilder
                .writeList(_exports.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_names == null || _names.isEmpty))
        {
            offset_names =
                fbBuilder.writeList(_names.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_parts == null || _parts.isEmpty))
        {
            offset_parts = fbBuilder
                .writeList(_parts.map((b) => fbBuilder.writeString(b)).toList());
        }
        fbBuilder.startTable();
        if (offset_exports != null)
        {
            fbBuilder.addOffset(2, offset_exports);
        }
        if (offset_names != null)
        {
            fbBuilder.addOffset(0, offset_names);
        }
        if (offset_parts != null)
        {
            fbBuilder.addOffset(1, offset_parts);
        }
        return fbBuilder.endTable();
    }
}

idl.UnlinkedPublicNamespace readUnlinkedPublicNamespace(List<int> buffer)
{
    fb.BufferContext rootRef = new fb.BufferContext.fromBytes(buffer);
    return new _UnlinkedPublicNamespaceReader().read(rootRef, 0);
}
public class _UnlinkedPublicNamespaceReader
    : fb.TableReader<_UnlinkedPublicNamespaceImpl>
{
    public _UnlinkedPublicNamespaceReader();

    ////@override
    _UnlinkedPublicNamespaceImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedPublicNamespaceImpl(bc, offset);
}
public class _UnlinkedPublicNamespaceImpl : Object
    with _UnlinkedPublicNamespaceMixin
    : idl.UnlinkedPublicNamespace
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedPublicNamespaceImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExportPublic> _exports;
    List<idl.UnlinkedPublicName> _names;
    List<String> _parts;

    ////@override
    List<idl.UnlinkedExportPublic> get exports {
        _exports ??= new fb.ListReader<idl.UnlinkedExportPublic>(
public _UnlinkedExportPublicReader())
        .vTableGet(_bc, _bcOffset, 2, new List<idl.UnlinkedExportPublic>{);
        return _exports;
    }

////@override
List<idl.UnlinkedPublicName> get names {
        _names ??= new fb.ListReader<idl.UnlinkedPublicName>(
public _UnlinkedPublicNameReader())
        .vTableGet(_bc, _bcOffset, 0, new List<idl.UnlinkedPublicName>{);
        return _names;
    }

    ////@override
    List<String> get parts {
        _parts ??= new fb.ListReader<String>(const fb.StringReader())
        .vTableGet(_bc, _bcOffset, 1, new List<String>{);
        return _parts;
    }
    }
public abstract class _UnlinkedPublicNamespaceMixin
    : idl.UnlinkedPublicNamespace
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (exports.isNotEmpty)
            _result["exports"] = exports.map((_value) => _value.toJson()).toList();
        if (names.isNotEmpty)
            _result["names"] = names.map((_value) => _value.toJson()).toList();
        if (parts.isNotEmpty) _result["parts"] = parts;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "exports": exports,
        "names": names,
        "parts": parts,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedReferenceBuilder : Object
    with _UnlinkedReferenceMixin
    : idl.UnlinkedReference
{
    String _name;
    int _prefixReference;

    ////@override
    public String name
    {
        get => _name ??= "";
    }

    /**
     * Name of the entity being referred to.  For the pseudo-type `dynamic`, the
     * string is "dynamic".  For the pseudo-type `void`, the string is "void".
     * For the pseudo-type `bottom`, the string is "*bottom*".
     */
    void setname(String value)
    {
        this._name = value;
    }

    ////@override
    public int prefixReference
    {
        get => _prefixReference ??= 0;
    }

    /**
     * Prefix used to refer to the entity, or zero if no prefix is used.  This is
     * an index into [UnlinkedUnit.references].
     *
     * Prefix references must always point backward; that is, for all i, if
     * UnlinkedUnit.references[i].prefixReference != 0, then
     * UnlinkedUnit.references[i].prefixReference < i.
     */
    void setprefixReference(int value)
    {
        assert(value == null || value >= 0);
        this._prefixReference = value;
    }

    UnlinkedReferenceBuilder(String name, int prefixReference)
      : _name = name,
        _prefixReference = prefixReference;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative() { }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        signature.addInt(this._prefixReference ?? 0);
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_name;
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        fbBuilder.startTable();
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        if (_prefixReference != null && _prefixReference != 0)
        {
            fbBuilder.addUint32(1, _prefixReference);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedReferenceReader : fb.TableReader<_UnlinkedReferenceImpl>
{
    public _UnlinkedReferenceReader();

    ////@override
    _UnlinkedReferenceImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedReferenceImpl(bc, offset);
}
public class _UnlinkedReferenceImpl : Object
    with _UnlinkedReferenceMixin
    : idl.UnlinkedReference
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedReferenceImpl(this._bc, this._bcOffset);

    String _name;
    int _prefixReference;

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }

////@override
int get prefixReference {
        _prefixReference ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _prefixReference;
    }
    }
public abstract class _UnlinkedReferenceMixin : idl.UnlinkedReference
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (name != "") _result["name"] = name;
        if (prefixReference != 0) _result["prefixReference"] = prefixReference;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "name": name,
        "prefixReference": prefixReference,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedTypedefBuilder : Object
    with _UnlinkedTypedefMixin
    : idl.UnlinkedTypedef
{
    List<UnlinkedExprBuilder> _annotations;
    CodeRangeBuilder _codeRange;
    UnlinkedDocumentationCommentBuilder _documentationComment;
    String _name;
    int _nameOffset;
    List<UnlinkedParamBuilder> _parameters;
    EntityRefBuilder _returnType;
    idl.TypedefStyle _style;
    List<UnlinkedTypeParamBuilder> _typeParameters;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this typedef.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
public CodeRangeBuilder codeRange
{
    get => _codeRange;
}

/**
 * Code range of the typedef.
 */
void setcodeRange(CodeRangeBuilder value)
{
    this._codeRange = value;
}

////@override
UnlinkedDocumentationCommentBuilder get documentationComment =>
      _documentationComment;

    /**
     * Documentation comment for the typedef, or `null` if there is no
     * documentation comment.
     */
    void setdocumentationComment(UnlinkedDocumentationCommentBuilder value)
{
    this._documentationComment = value;
}

////@override
public String name
{
    get => _name ??= "";
}

/**
 * Name of the typedef.
 */
void setname(String value)
{
    this._name = value;
}

////@override
public int nameOffset
{
    get => _nameOffset ??= 0;
}

/**
 * Offset of the typedef name relative to the beginning of the file.
 */
void setnameOffset(int value)
{
    assert(value == null || value >= 0);
    this._nameOffset = value;
}

////@override
List<UnlinkedParamBuilder> get parameters =>
        _parameters ??= new Dictionary<UnlinkedParamBuilder>{};

    /**
     * Parameters of the executable, if any.
     */
    void setparameters(List<UnlinkedParamBuilder> value)
{
    this._parameters = value;
}

////@override
public EntityRefBuilder returnType
{
    get => _returnType;
}

/**
 * If [style] is [TypedefStyle.functionType], the return type of the typedef.
 * If [style] is [TypedefStyle.genericFunctionType], the function type being
 * defined.
 */
void setreturnType(EntityRefBuilder value)
{
    this._returnType = value;
}

////@override
public idl.TypedefStyle style
{
    get => _style ??= idl.TypedefStyle.functionType;
}

/**
 * The style of the typedef.
 */
void setstyle(idl.TypedefStyle value)
{
    this._style = value;
}

////@override
List<UnlinkedTypeParamBuilder> get typeParameters =>
        _typeParameters ??= new Dictionary<UnlinkedTypeParamBuilder>{};

    /**
     * Type parameters of the typedef, if any.
     */
    void settypeParameters(List<UnlinkedTypeParamBuilder> value)
{
    this._typeParameters = value;
}

UnlinkedTypedefBuilder(
        {
    List<UnlinkedExprBuilder> annotations,
   CodeRangeBuilder codeRange,
      UnlinkedDocumentationCommentBuilder documentationComment,
      String name,
      int nameOffset,
      List< UnlinkedParamBuilder > parameters,
      EntityRefBuilder returnType,
      idl.TypedefStyle style,
      List< UnlinkedTypeParamBuilder > typeParameters)
      : _annotations = annotations,
        _codeRange = codeRange,
        _documentationComment = documentationComment,
        _name = name,
        _nameOffset = nameOffset,
        _parameters = parameters,
        _returnType = returnType,
        _style = style,
        _typeParameters = typeParameters;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _codeRange = null;
        _documentationComment = null;
        _nameOffset = null;
        _parameters?.forEach((b) => b.flushInformative());
        _returnType?.flushInformative();
        _typeParameters?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        signature.addBool(this._returnType != null);
        this._returnType?.collectApiSignature(signature);
        if (this._parameters == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._parameters.length);
            foreach (var x in this._parameters)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._typeParameters == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._typeParameters.length);
            foreach (var x in this._typeParameters)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addInt(this._style == null ? 0 : this._style.index);
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        fb.Offset offset_codeRange;
        fb.Offset offset_documentationComment;
        fb.Offset offset_name;
        fb.Offset offset_parameters;
        fb.Offset offset_returnType;
        fb.Offset offset_typeParameters;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_codeRange != null)
        {
            offset_codeRange = _codeRange.finish(fbBuilder);
        }
        if (_documentationComment != null)
        {
            offset_documentationComment = _documentationComment.finish(fbBuilder);
        }
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        if (!(_parameters == null || _parameters.isEmpty))
        {
            offset_parameters = fbBuilder
                .writeList(_parameters.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_returnType != null)
        {
            offset_returnType = _returnType.finish(fbBuilder);
        }
        if (!(_typeParameters == null || _typeParameters.isEmpty))
        {
            offset_typeParameters = fbBuilder
                .writeList(_typeParameters.map((b) => b.finish(fbBuilder)).toList());
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(4, offset_annotations);
        }
        if (offset_codeRange != null)
        {
            fbBuilder.addOffset(7, offset_codeRange);
        }
        if (offset_documentationComment != null)
        {
            fbBuilder.addOffset(6, offset_documentationComment);
        }
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        if (_nameOffset != null && _nameOffset != 0)
        {
            fbBuilder.addUint32(1, _nameOffset);
        }
        if (offset_parameters != null)
        {
            fbBuilder.addOffset(3, offset_parameters);
        }
        if (offset_returnType != null)
        {
            fbBuilder.addOffset(2, offset_returnType);
        }
        if (_style != null && _style != idl.TypedefStyle.functionType)
        {
            fbBuilder.addUint8(8, _style.index);
        }
        if (offset_typeParameters != null)
        {
            fbBuilder.addOffset(5, offset_typeParameters);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedTypedefReader : fb.TableReader<_UnlinkedTypedefImpl>
{
    public _UnlinkedTypedefReader();

    ////@override
    _UnlinkedTypedefImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedTypedefImpl(bc, offset);
}
public class _UnlinkedTypedefImpl : Object
    with _UnlinkedTypedefMixin
    : idl.UnlinkedTypedef
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedTypedefImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    idl.CodeRange _codeRange;
    idl.UnlinkedDocumentationComment _documentationComment;
    String _name;
    int _nameOffset;
    List<idl.UnlinkedParam> _parameters;
    idl.EntityRef _returnType;
    idl.TypedefStyle _style;
    List<idl.UnlinkedTypeParam> _typeParameters;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 4, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
idl.CodeRange get codeRange {
        _codeRange ??= new _CodeRangeReader().vTableGet(_bc, _bcOffset, 7, null);
        return _codeRange;
    }

    ////@override
    idl.UnlinkedDocumentationComment get documentationComment {
        _documentationComment ??= new _UnlinkedDocumentationCommentReader()
          .vTableGet(_bc, _bcOffset, 6, null);
        return _documentationComment;
    }

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }

    ////@override
    int get nameOffset {
        _nameOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _nameOffset;
    }

    ////@override
    List<idl.UnlinkedParam> get parameters {
        _parameters ??=
public fb.ListReader<idl.UnlinkedParam>(const _UnlinkedParamReader())
            .vTableGet(_bc, _bcOffset, 3, new List<idl.UnlinkedParam>{);
        return _parameters;
    }

    ////@override
    idl.EntityRef get returnType {
        _returnType ??= new _EntityRefReader().vTableGet(_bc, _bcOffset, 2, null);
        return _returnType;
    }

    ////@override
    idl.TypedefStyle get style {
        _style ??= new _TypedefStyleReader()
          .vTableGet(_bc, _bcOffset, 8, idl.TypedefStyle.functionType);
        return _style;
    }

    ////@override
    List<idl.UnlinkedTypeParam> get typeParameters {
        _typeParameters ??= new fb.ListReader<idl.UnlinkedTypeParam>(
public _UnlinkedTypeParamReader())
        .vTableGet(_bc, _bcOffset, 5, new List<idl.UnlinkedTypeParam>{);
        return _typeParameters;
    }
    }
public abstract class _UnlinkedTypedefMixin : idl.UnlinkedTypedef
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (codeRange != null) _result["codeRange"] = codeRange.toJson();
        if (documentationComment != null)
            _result["documentationComment"] = documentationComment.toJson();
        if (name != "") _result["name"] = name;
        if (nameOffset != 0) _result["nameOffset"] = nameOffset;
        if (parameters.isNotEmpty)
            _result["parameters"] =
                parameters.map((_value) => _value.toJson()).toList();
        if (returnType != null) _result["returnType"] = returnType.toJson();
        if (style != idl.TypedefStyle.functionType)
            _result["style"] = style.toString().split(".")[1];
        if (typeParameters.isNotEmpty)
            _result["typeParameters"] =
                typeParameters.map((_value) => _value.toJson()).toList();
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "codeRange": codeRange,
        "documentationComment": documentationComment,
        "name": name,
        "nameOffset": nameOffset,
        "parameters": parameters,
        "returnType": returnType,
        "style": style,
        "typeParameters": typeParameters,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedTypeParamBuilder : Object
    with _UnlinkedTypeParamMixin
    : idl.UnlinkedTypeParam
{
    List<UnlinkedExprBuilder> _annotations;
    EntityRefBuilder _bound;
    CodeRangeBuilder _codeRange;
    String _name;
    int _nameOffset;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this type parameter.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
public EntityRefBuilder bound
{
    get => _bound;
}

/**
 * Bound of the type parameter, if a bound is explicitly declared.  Otherwise
 * null.
 */
void setbound(EntityRefBuilder value)
{
    this._bound = value;
}

////@override
public CodeRangeBuilder codeRange
{
    get => _codeRange;
}

/**
 * Code range of the type parameter.
 */
void setcodeRange(CodeRangeBuilder value)
{
    this._codeRange = value;
}

////@override
public String name
{
    get => _name ??= "";
}

/**
 * Name of the type parameter.
 */
void setname(String value)
{
    this._name = value;
}

////@override
public int nameOffset
{
    get => _nameOffset ??= 0;
}

/**
 * Offset of the type parameter name relative to the beginning of the file.
 */
void setnameOffset(int value)
{
    assert(value == null || value >= 0);
    this._nameOffset = value;
}

UnlinkedTypeParamBuilder(
        {
    List<UnlinkedExprBuilder> annotations,
   EntityRefBuilder bound,
      CodeRangeBuilder codeRange,
      String name,
      int nameOffset)
      : _annotations = annotations,
        _bound = bound,
        _codeRange = codeRange,
        _name = name,
        _nameOffset = nameOffset;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _bound?.flushInformative();
        _codeRange = null;
        _nameOffset = null;
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        signature.addBool(this._bound != null);
        this._bound?.collectApiSignature(signature);
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        fb.Offset offset_bound;
        fb.Offset offset_codeRange;
        fb.Offset offset_name;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_bound != null)
        {
            offset_bound = _bound.finish(fbBuilder);
        }
        if (_codeRange != null)
        {
            offset_codeRange = _codeRange.finish(fbBuilder);
        }
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(3, offset_annotations);
        }
        if (offset_bound != null)
        {
            fbBuilder.addOffset(2, offset_bound);
        }
        if (offset_codeRange != null)
        {
            fbBuilder.addOffset(4, offset_codeRange);
        }
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        if (_nameOffset != null && _nameOffset != 0)
        {
            fbBuilder.addUint32(1, _nameOffset);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedTypeParamReader : fb.TableReader<_UnlinkedTypeParamImpl>
{
    public _UnlinkedTypeParamReader();

    ////@override
    _UnlinkedTypeParamImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedTypeParamImpl(bc, offset);
}
public class _UnlinkedTypeParamImpl : Object
    with _UnlinkedTypeParamMixin
    : idl.UnlinkedTypeParam
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedTypeParamImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    idl.EntityRef _bound;
    idl.CodeRange _codeRange;
    String _name;
    int _nameOffset;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 3, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
idl.EntityRef get bound {
        _bound ??= new _EntityRefReader().vTableGet(_bc, _bcOffset, 2, null);
        return _bound;
    }

    ////@override
    idl.CodeRange get codeRange {
        _codeRange ??= new _CodeRangeReader().vTableGet(_bc, _bcOffset, 4, null);
        return _codeRange;
    }

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }

    ////@override
    int get nameOffset {
        _nameOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _nameOffset;
    }
    }
public abstract class _UnlinkedTypeParamMixin : idl.UnlinkedTypeParam
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (bound != null) _result["bound"] = bound.toJson();
        if (codeRange != null) _result["codeRange"] = codeRange.toJson();
        if (name != "") _result["name"] = name;
        if (nameOffset != 0) _result["nameOffset"] = nameOffset;
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "bound": bound,
        "codeRange": codeRange,
        "name": name,
        "nameOffset": nameOffset,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedUnitBuilder : Object
    with _UnlinkedUnitMixin
    : idl.UnlinkedUnit
{
    List<int> _apiSignature;
    List<UnlinkedClassBuilder> _classes;
    CodeRangeBuilder _codeRange;
    List<UnlinkedEnumBuilder> _enums;
    List<UnlinkedExecutableBuilder> _executables;
    List<UnlinkedExportNonPublicBuilder> _exports;
    List<UnlinkedImportBuilder> _imports;
    bool _isPartOf;
    List<UnlinkedExprBuilder> _libraryAnnotations;
    UnlinkedDocumentationCommentBuilder _libraryDocumentationComment;
    String _libraryName;
    int _libraryNameLength;
    int _libraryNameOffset;
    List<int> _lineStarts;
    List<UnlinkedClassBuilder> _mixins;
    List<UnlinkedPartBuilder> _parts;
    UnlinkedPublicNamespaceBuilder _publicNamespace;
    List<UnlinkedReferenceBuilder> _references;
    List<UnlinkedTypedefBuilder> _typedefs;
    List<UnlinkedVariableBuilder> _variables;

    ////@override
    public List<int> apiSignature
    {
        get => _apiSignature ??= new Dictionary<int> { };
    }

    /**
     * MD5 hash of the non-informative fields of the [UnlinkedUnit] (not
     * including this one) as 16 unsigned 8-bit integer values.  This can be used
     * to identify when the API of a unit may have changed.
     */
    void setapiSignature(List<int> value)
    {
        assert(value == null || value.every((e) => e >= 0));
        this._apiSignature = value;
    }

    ////@override
    List<UnlinkedClassBuilder> get classes =>
        _classes ??= new List<UnlinkedClassBuilder>{};

/**
 * Classes declared in the compilation unit.
 */
void setclasses(List<UnlinkedClassBuilder> value)
{
    this._classes = value;
}

////@override
public CodeRangeBuilder codeRange
{
    get => _codeRange;
}

/**
 * Code range of the unit.
 */
void setcodeRange(CodeRangeBuilder value)
{
    this._codeRange = value;
}

////@override
public List<UnlinkedEnumBuilder> enums
{
    get => _enums ??= new List<UnlinkedEnumBuilder> { };
}

/**
 * Enums declared in the compilation unit.
 */
void setenums(List<UnlinkedEnumBuilder> value)
{
    this._enums = value;
}

////@override
List<UnlinkedExecutableBuilder> get executables =>
        _executables ??= new List<UnlinkedExecutableBuilder>{};

    /**
     * Top level executable objects (functions, getters, and setters) declared in
     * the compilation unit.
     */
    void setexecutables(List<UnlinkedExecutableBuilder> value)
{
    this._executables = value;
}

////@override
List<UnlinkedExportNonPublicBuilder> get exports =>
        _exports ??= new Dictionary<UnlinkedExportNonPublicBuilder>{};

    /**
     * Export declarations in the compilation unit.
     */
    void setexports(List<UnlinkedExportNonPublicBuilder> value)
{
    this._exports = value;
}

////@override
Null get fallbackModePath =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
List<UnlinkedImportBuilder> get imports =>
        _imports ??= new List<UnlinkedImportBuilder>{};

    /**
     * Import declarations in the compilation unit.
     */
    void setimports(List<UnlinkedImportBuilder> value)
{
    this._imports = value;
}

////@override
public bool isPartOf
{
    get => _isPartOf ??= false;
}

/**
 * Indicates whether the unit contains a "part of" declaration.
 */
void setisPartOf(bool value)
{
    this._isPartOf = value;
}

////@override
List<UnlinkedExprBuilder> get libraryAnnotations =>
        _libraryAnnotations ??= new List<UnlinkedExprBuilder>{};

    /**
     * Annotations for the library declaration, or the empty list if there is no
     * library declaration.
     */
    void setlibraryAnnotations(List<UnlinkedExprBuilder> value)
{
    this._libraryAnnotations = value;
}

////@override
UnlinkedDocumentationCommentBuilder get libraryDocumentationComment =>
      _libraryDocumentationComment;

    /**
     * Documentation comment for the library, or `null` if there is no
     * documentation comment.
     */
    void setlibraryDocumentationComment(
        UnlinkedDocumentationCommentBuilder value)
{
    this._libraryDocumentationComment = value;
}

////@override
public String libraryName
{
    get => _libraryName ??= "";
}

/**
 * Name of the library (from a "library" declaration, if present).
 */
void setlibraryName(String value)
{
    this._libraryName = value;
}

////@override
public int libraryNameLength
{
    get => _libraryNameLength ??= 0;
}

/**
 * Length of the library name as it appears in the source code (or 0 if the
 * library has no name).
 */
void setlibraryNameLength(int value)
{
    assert(value == null || value >= 0);
    this._libraryNameLength = value;
}

////@override
public int libraryNameOffset
{
    get => _libraryNameOffset ??= 0;
}

/**
 * Offset of the library name relative to the beginning of the file (or 0 if
 * the library has no name).
 */
void setlibraryNameOffset(int value)
{
    assert(value == null || value >= 0);
    this._libraryNameOffset = value;
}

////@override
public List<int> lineStarts
{
    get => _lineStarts ??= new Dictionary<int> { };
}

/**
 * Offsets of the first character of each line in the source code.
 */
void setlineStarts(List<int> value)
{
    assert(value == null || value.every((e) => e >= 0));
    this._lineStarts = value;
}

////@override
public List<UnlinkedClassBuilder> mixins
{
    get => _mixins ??= new List<UnlinkedClassBuilder> { };
}

/**
 * Mixins declared in the compilation unit.
 */
void setmixins(List<UnlinkedClassBuilder> value)
{
    this._mixins = value;
}

////@override
public List<UnlinkedPartBuilder> parts
{
    get => _parts ??= new List<UnlinkedPartBuilder> { };
}

/**
 * Part declarations in the compilation unit.
 */
void setparts(List<UnlinkedPartBuilder> value)
{
    this._parts = value;
}

////@override
public UnlinkedPublicNamespaceBuilder publicNamespace
{
    get => _publicNamespace;
}

/**
 * Unlinked public namespace of this compilation unit.
 */
void setpublicNamespace(UnlinkedPublicNamespaceBuilder value)
{
    this._publicNamespace = value;
}

////@override
List<UnlinkedReferenceBuilder> get references =>
        _references ??= new List<UnlinkedReferenceBuilder>{};

    /**
     * Top level and prefixed names referred to by this compilation unit.  The
     * zeroth element of this array is always populated and is used to represent
     * the absence of a reference in places where a reference is optional (for
     * example [UnlinkedReference.prefixReference or
     * UnlinkedImport.prefixReference]).
     */
    void setreferences(List<UnlinkedReferenceBuilder> value)
{
    this._references = value;
}

////@override
List<UnlinkedTypedefBuilder> get typedefs =>
        _typedefs ??= new List<UnlinkedTypedefBuilder>{};

    /**
     * Typedefs declared in the compilation unit.
     */
    void settypedefs(List<UnlinkedTypedefBuilder> value)
{
    this._typedefs = value;
}

////@override
List<UnlinkedVariableBuilder> get variables =>
        _variables ??= new List<UnlinkedVariableBuilder>{};

    /**
     * Top level variables declared in the compilation unit.
     */
    void setvariables(List<UnlinkedVariableBuilder> value)
{
    this._variables = value;
}

UnlinkedUnitBuilder(
        {
    List<int> apiSignature,
   List< UnlinkedClassBuilder > classes,
      CodeRangeBuilder codeRange,
      List< UnlinkedEnumBuilder > enums,
      List<UnlinkedExecutableBuilder> executables,
      List< UnlinkedExportNonPublicBuilder > exports,
      List<UnlinkedImportBuilder> imports,
      bool isPartOf,
      List< UnlinkedExprBuilder > libraryAnnotations,
      UnlinkedDocumentationCommentBuilder libraryDocumentationComment,
      String libraryName,
      int libraryNameLength,
      int libraryNameOffset,
      List< int > lineStarts,
      List<UnlinkedClassBuilder> mixins,
      List< UnlinkedPartBuilder > parts,
      UnlinkedPublicNamespaceBuilder publicNamespace,
      List< UnlinkedReferenceBuilder > references,
      List<UnlinkedTypedefBuilder> typedefs,
      List< UnlinkedVariableBuilder > variables)
      : _apiSignature = apiSignature,
        _classes = classes,
        _codeRange = codeRange,
        _enums = enums,
        _executables = executables,
        _exports = exports,
        _imports = imports,
        _isPartOf = isPartOf,
        _libraryAnnotations = libraryAnnotations,
        _libraryDocumentationComment = libraryDocumentationComment,
        _libraryName = libraryName,
        _libraryNameLength = libraryNameLength,
        _libraryNameOffset = libraryNameOffset,
        _lineStarts = lineStarts,
        _mixins = mixins,
        _parts = parts,
        _publicNamespace = publicNamespace,
        _references = references,
        _typedefs = typedefs,
        _variables = variables;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _classes?.forEach((b) => b.flushInformative());
        _codeRange = null;
        _enums?.forEach((b) => b.flushInformative());
        _executables?.forEach((b) => b.flushInformative());
        _exports?.forEach((b) => b.flushInformative());
        _imports?.forEach((b) => b.flushInformative());
        _libraryAnnotations?.forEach((b) => b.flushInformative());
        _libraryDocumentationComment = null;
        _libraryNameLength = null;
        _libraryNameOffset = null;
        _lineStarts = null;
        _mixins?.forEach((b) => b.flushInformative());
        _parts?.forEach((b) => b.flushInformative());
        _publicNamespace?.flushInformative();
        _references?.forEach((b) => b.flushInformative());
        _typedefs?.forEach((b) => b.flushInformative());
        _variables?.forEach((b) => b.flushInformative());
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addBool(this._publicNamespace != null);
        this._publicNamespace?.collectApiSignature(signature);
        if (this._references == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._references.length);
            foreach (var x in this._references)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._classes == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._classes.length);
            foreach (var x in this._classes)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._variables == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._variables.length);
            foreach (var x in this._variables)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._executables == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._executables.length);
            foreach (var x in this._executables)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._imports == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._imports.length);
            foreach (var x in this._imports)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addString(this._libraryName ?? "");
        if (this._typedefs == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._typedefs.length);
            foreach (var x in this._typedefs)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._parts == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._parts.length);
            foreach (var x in this._parts)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._enums == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._enums.length);
            foreach (var x in this._enums)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._exports == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._exports.length);
            foreach (var x in this._exports)
            {
                x?.collectApiSignature(signature);
            }
        }
        if (this._libraryAnnotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._libraryAnnotations.length);
            foreach (var x in this._libraryAnnotations)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addBool(this._isPartOf == true);
        if (this._apiSignature == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._apiSignature.length);
            foreach (var x in this._apiSignature)
            {
                signature.addInt(x);
            }
        }
        if (this._mixins == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._mixins.length);
            foreach (var x in this._mixins)
            {
                x?.collectApiSignature(signature);
            }
        }
    }

    List<int> toBuffer()
    {
        fb.Builder fbBuilder = new fb.Builder();
        return fbBuilder.finish(finish(fbBuilder), "UUnt");
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_apiSignature;
        fb.Offset offset_classes;
        fb.Offset offset_codeRange;
        fb.Offset offset_enums;
        fb.Offset offset_executables;
        fb.Offset offset_exports;
        fb.Offset offset_imports;
        fb.Offset offset_libraryAnnotations;
        fb.Offset offset_libraryDocumentationComment;
        fb.Offset offset_libraryName;
        fb.Offset offset_lineStarts;
        fb.Offset offset_mixins;
        fb.Offset offset_parts;
        fb.Offset offset_publicNamespace;
        fb.Offset offset_references;
        fb.Offset offset_typedefs;
        fb.Offset offset_variables;
        if (!(_apiSignature == null || _apiSignature.isEmpty))
        {
            offset_apiSignature = fbBuilder.writeListUint32(_apiSignature);
        }
        if (!(_classes == null || _classes.isEmpty))
        {
            offset_classes = fbBuilder
                .writeList(_classes.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_codeRange != null)
        {
            offset_codeRange = _codeRange.finish(fbBuilder);
        }
        if (!(_enums == null || _enums.isEmpty))
        {
            offset_enums =
                fbBuilder.writeList(_enums.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_executables == null || _executables.isEmpty))
        {
            offset_executables = fbBuilder
                .writeList(_executables.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_exports == null || _exports.isEmpty))
        {
            offset_exports = fbBuilder
                .writeList(_exports.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_imports == null || _imports.isEmpty))
        {
            offset_imports = fbBuilder
                .writeList(_imports.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_libraryAnnotations == null || _libraryAnnotations.isEmpty))
        {
            offset_libraryAnnotations = fbBuilder.writeList(
                _libraryAnnotations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_libraryDocumentationComment != null)
        {
            offset_libraryDocumentationComment =
                _libraryDocumentationComment.finish(fbBuilder);
        }
        if (_libraryName != null)
        {
            offset_libraryName = fbBuilder.writeString(_libraryName);
        }
        if (!(_lineStarts == null || _lineStarts.isEmpty))
        {
            offset_lineStarts = fbBuilder.writeListUint32(_lineStarts);
        }
        if (!(_mixins == null || _mixins.isEmpty))
        {
            offset_mixins =
                fbBuilder.writeList(_mixins.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_parts == null || _parts.isEmpty))
        {
            offset_parts =
                fbBuilder.writeList(_parts.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_publicNamespace != null)
        {
            offset_publicNamespace = _publicNamespace.finish(fbBuilder);
        }
        if (!(_references == null || _references.isEmpty))
        {
            offset_references = fbBuilder
                .writeList(_references.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_typedefs == null || _typedefs.isEmpty))
        {
            offset_typedefs = fbBuilder
                .writeList(_typedefs.map((b) => b.finish(fbBuilder)).toList());
        }
        if (!(_variables == null || _variables.isEmpty))
        {
            offset_variables = fbBuilder
                .writeList(_variables.map((b) => b.finish(fbBuilder)).toList());
        }
        fbBuilder.startTable();
        if (offset_apiSignature != null)
        {
            fbBuilder.addOffset(19, offset_apiSignature);
        }
        if (offset_classes != null)
        {
            fbBuilder.addOffset(2, offset_classes);
        }
        if (offset_codeRange != null)
        {
            fbBuilder.addOffset(15, offset_codeRange);
        }
        if (offset_enums != null)
        {
            fbBuilder.addOffset(12, offset_enums);
        }
        if (offset_executables != null)
        {
            fbBuilder.addOffset(4, offset_executables);
        }
        if (offset_exports != null)
        {
            fbBuilder.addOffset(13, offset_exports);
        }
        if (offset_imports != null)
        {
            fbBuilder.addOffset(5, offset_imports);
        }
        if (_isPartOf == true)
        {
            fbBuilder.addBool(18, true);
        }
        if (offset_libraryAnnotations != null)
        {
            fbBuilder.addOffset(14, offset_libraryAnnotations);
        }
        if (offset_libraryDocumentationComment != null)
        {
            fbBuilder.addOffset(9, offset_libraryDocumentationComment);
        }
        if (offset_libraryName != null)
        {
            fbBuilder.addOffset(6, offset_libraryName);
        }
        if (_libraryNameLength != null && _libraryNameLength != 0)
        {
            fbBuilder.addUint32(7, _libraryNameLength);
        }
        if (_libraryNameOffset != null && _libraryNameOffset != 0)
        {
            fbBuilder.addUint32(8, _libraryNameOffset);
        }
        if (offset_lineStarts != null)
        {
            fbBuilder.addOffset(17, offset_lineStarts);
        }
        if (offset_mixins != null)
        {
            fbBuilder.addOffset(20, offset_mixins);
        }
        if (offset_parts != null)
        {
            fbBuilder.addOffset(11, offset_parts);
        }
        if (offset_publicNamespace != null)
        {
            fbBuilder.addOffset(0, offset_publicNamespace);
        }
        if (offset_references != null)
        {
            fbBuilder.addOffset(1, offset_references);
        }
        if (offset_typedefs != null)
        {
            fbBuilder.addOffset(10, offset_typedefs);
        }
        if (offset_variables != null)
        {
            fbBuilder.addOffset(3, offset_variables);
        }
        return fbBuilder.endTable();
    }
}

idl.UnlinkedUnit readUnlinkedUnit(List<int> buffer)
{
    fb.BufferContext rootRef = new fb.BufferContext.fromBytes(buffer);
    return new _UnlinkedUnitReader().read(rootRef, 0);
}
public class _UnlinkedUnitReader : fb.TableReader<_UnlinkedUnitImpl>
{
    public _UnlinkedUnitReader();

    ////@override
    _UnlinkedUnitImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedUnitImpl(bc, offset);
}
public class _UnlinkedUnitImpl : Object
    with _UnlinkedUnitMixin
    : idl.UnlinkedUnit
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedUnitImpl(this._bc, this._bcOffset);

    List<int> _apiSignature;
    List<idl.UnlinkedClass> _classes;
    idl.CodeRange _codeRange;
    List<idl.UnlinkedEnum> _enums;
    List<idl.UnlinkedExecutable> _executables;
    List<idl.UnlinkedExportNonPublic> _exports;
    List<idl.UnlinkedImport> _imports;
    bool _isPartOf;
    List<idl.UnlinkedExpr> _libraryAnnotations;
    idl.UnlinkedDocumentationComment _libraryDocumentationComment;
    String _libraryName;
    int _libraryNameLength;
    int _libraryNameOffset;
    List<int> _lineStarts;
    List<idl.UnlinkedClass> _mixins;
    List<idl.UnlinkedPart> _parts;
    idl.UnlinkedPublicNamespace _publicNamespace;
    List<idl.UnlinkedReference> _references;
    List<idl.UnlinkedTypedef> _typedefs;
    List<idl.UnlinkedVariable> _variables;

    ////@override
    List<int> get apiSignature {
        _apiSignature ??= new fb.Uint32ListReader()
          .vTableGet(_bc, _bcOffset, 19, new List<int>{);
        return _apiSignature;
    }

////@override
List<idl.UnlinkedClass> get classes {
        _classes ??=
public fb.ListReader<idl.UnlinkedClass>(const _UnlinkedClassReader())
            .vTableGet(_bc, _bcOffset, 2, new List<idl.UnlinkedClass>{);
        return _classes;
    }

    ////@override
    idl.CodeRange get codeRange {
        _codeRange ??= new _CodeRangeReader().vTableGet(_bc, _bcOffset, 15, null);
        return _codeRange;
    }

    ////@override
    List<idl.UnlinkedEnum> get enums {
        _enums ??=
public fb.ListReader<idl.UnlinkedEnum>(const _UnlinkedEnumReader())
            .vTableGet(_bc, _bcOffset, 12, new List<idl.UnlinkedEnum>{);
        return _enums;
    }

    ////@override
    List<idl.UnlinkedExecutable> get executables {
        _executables ??= new fb.ListReader<idl.UnlinkedExecutable>(
public _UnlinkedExecutableReader())
        .vTableGet(_bc, _bcOffset, 4, new List<idl.UnlinkedExecutable>{);
        return _executables;
    }

    ////@override
    List<idl.UnlinkedExportNonPublic> get exports {
        _exports ??= new fb.ListReader<idl.UnlinkedExportNonPublic>(
public _UnlinkedExportNonPublicReader())
        .vTableGet(_bc, _bcOffset, 13, new List<idl.UnlinkedExportNonPublic>{);
        return _exports;
    }

    ////@override
    Null get fallbackModePath =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
List<idl.UnlinkedImport> get imports {
        _imports ??=
public fb.ListReader<idl.UnlinkedImport>(const _UnlinkedImportReader())
            .vTableGet(_bc, _bcOffset, 5, new List<idl.UnlinkedImport>{);
        return _imports;
    }

    ////@override
    bool get isPartOf {
        _isPartOf ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 18, false);
        return _isPartOf;
    }

    ////@override
    List<idl.UnlinkedExpr> get libraryAnnotations {
        _libraryAnnotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 14, new List<idl.UnlinkedExpr>{);
        return _libraryAnnotations;
    }

    ////@override
    idl.UnlinkedDocumentationComment get libraryDocumentationComment {
        _libraryDocumentationComment ??= new _UnlinkedDocumentationCommentReader()
          .vTableGet(_bc, _bcOffset, 9, null);
        return _libraryDocumentationComment;
    }

    ////@override
    String get libraryName {
        _libraryName ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 6, "");
        return _libraryName;
    }

    ////@override
    int get libraryNameLength {
        _libraryNameLength ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 7, 0);
        return _libraryNameLength;
    }

    ////@override
    int get libraryNameOffset {
        _libraryNameOffset ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 8, 0);
        return _libraryNameOffset;
    }

    ////@override
    List<int> get lineStarts {
        _lineStarts ??= new fb.Uint32ListReader()
          .vTableGet(_bc, _bcOffset, 17, new List<int>{);
        return _lineStarts;
    }

    ////@override
    List<idl.UnlinkedClass> get mixins {
        _mixins ??=
public fb.ListReader<idl.UnlinkedClass>(const _UnlinkedClassReader())
            .vTableGet(_bc, _bcOffset, 20, new List<idl.UnlinkedClass>{);
        return _mixins;
    }

    ////@override
    List<idl.UnlinkedPart> get parts {
        _parts ??=
public fb.ListReader<idl.UnlinkedPart>(const _UnlinkedPartReader())
            .vTableGet(_bc, _bcOffset, 11, new List<idl.UnlinkedPart>{);
        return _parts;
    }

    ////@override
    idl.UnlinkedPublicNamespace get publicNamespace {
        _publicNamespace ??= new _UnlinkedPublicNamespaceReader()
          .vTableGet(_bc, _bcOffset, 0, null);
        return _publicNamespace;
    }

    ////@override
    List<idl.UnlinkedReference> get references {
        _references ??= new fb.ListReader<idl.UnlinkedReference>(
public _UnlinkedReferenceReader())
        .vTableGet(_bc, _bcOffset, 1, new List<idl.UnlinkedReference>{);
        return _references;
    }

    ////@override
    List<idl.UnlinkedTypedef> get typedefs {
        _typedefs ??=
public fb.ListReader<idl.UnlinkedTypedef>(const _UnlinkedTypedefReader())
            .vTableGet(_bc, _bcOffset, 10, new List<idl.UnlinkedTypedef>{);
        return _typedefs;
    }

    ////@override
    List<idl.UnlinkedVariable> get variables {
        _variables ??= new fb.ListReader<idl.UnlinkedVariable>(
public _UnlinkedVariableReader())
        .vTableGet(_bc, _bcOffset, 3, new List<idl.UnlinkedVariable>{);
        return _variables;
    }
    }
public abstract class _UnlinkedUnitMixin : idl.UnlinkedUnit
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (apiSignature.isNotEmpty) _result["apiSignature"] = apiSignature;
        if (classes.isNotEmpty)
            _result["classes"] = classes.map((_value) => _value.toJson()).toList();
        if (codeRange != null) _result["codeRange"] = codeRange.toJson();
        if (enums.isNotEmpty)
            _result["enums"] = enums.map((_value) => _value.toJson()).toList();
        if (executables.isNotEmpty)
            _result["executables"] =
                executables.map((_value) => _value.toJson()).toList();
        if (exports.isNotEmpty)
            _result["exports"] = exports.map((_value) => _value.toJson()).toList();
        if (imports.isNotEmpty)
            _result["imports"] = imports.map((_value) => _value.toJson()).toList();
        if (isPartOf != false) _result["isPartOf"] = isPartOf;
        if (libraryAnnotations.isNotEmpty)
            _result["libraryAnnotations"] =
                libraryAnnotations.map((_value) => _value.toJson()).toList();
        if (libraryDocumentationComment != null)
            _result["libraryDocumentationComment"] =
                libraryDocumentationComment.toJson();
        if (libraryName != "") _result["libraryName"] = libraryName;
        if (libraryNameLength != 0)
            _result["libraryNameLength"] = libraryNameLength;
        if (libraryNameOffset != 0)
            _result["libraryNameOffset"] = libraryNameOffset;
        if (lineStarts.isNotEmpty) _result["lineStarts"] = lineStarts;
        if (mixins.isNotEmpty)
            _result["mixins"] = mixins.map((_value) => _value.toJson()).toList();
        if (parts.isNotEmpty)
            _result["parts"] = parts.map((_value) => _value.toJson()).toList();
        if (publicNamespace != null)
            _result["publicNamespace"] = publicNamespace.toJson();
        if (references.isNotEmpty)
            _result["references"] =
                references.map((_value) => _value.toJson()).toList();
        if (typedefs.isNotEmpty)
            _result["typedefs"] = typedefs.map((_value) => _value.toJson()).toList();
        if (variables.isNotEmpty)
            _result["variables"] =
                variables.map((_value) => _value.toJson()).toList();
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "apiSignature": apiSignature,
        "classes": classes,
        "codeRange": codeRange,
        "enums": enums,
        "executables": executables,
        "exports": exports,
        "imports": imports,
        "isPartOf": isPartOf,
        "libraryAnnotations": libraryAnnotations,
        "libraryDocumentationComment": libraryDocumentationComment,
        "libraryName": libraryName,
        "libraryNameLength": libraryNameLength,
        "libraryNameOffset": libraryNameOffset,
        "lineStarts": lineStarts,
        "mixins": mixins,
        "parts": parts,
        "publicNamespace": publicNamespace,
        "references": references,
        "typedefs": typedefs,
        "variables": variables,
      };

////@override
String toString() => convert.json.encode(toJson());
}
public class UnlinkedVariableBuilder : Object
    with _UnlinkedVariableMixin
    : idl.UnlinkedVariable
{
    List<UnlinkedExprBuilder> _annotations;
    CodeRangeBuilder _codeRange;
    UnlinkedDocumentationCommentBuilder _documentationComment;
    int _inferredTypeSlot;
    int _inheritsCovariantSlot;
    UnlinkedExecutableBuilder _initializer;
    bool _isConst;
    bool _isCovariant;
    bool _isFinal;
    bool _isStatic;
    String _name;
    int _nameOffset;
    int _propagatedTypeSlot;
    EntityRefBuilder _type;

    ////@override
    List<UnlinkedExprBuilder> get annotations =>
        _annotations ??= new Dictionary<UnlinkedExprBuilder>{};

/**
 * Annotations for this variable.
 */
void setannotations(List<UnlinkedExprBuilder> value)
{
    this._annotations = value;
}

////@override
public CodeRangeBuilder codeRange
{
    get => _codeRange;
}

/**
 * Code range of the variable.
 */
void setcodeRange(CodeRangeBuilder value)
{
    this._codeRange = value;
}

////@override
UnlinkedDocumentationCommentBuilder get documentationComment =>
      _documentationComment;

    /**
     * Documentation comment for the variable, or `null` if there is no
     * documentation comment.
     */
    void setdocumentationComment(UnlinkedDocumentationCommentBuilder value)
{
    this._documentationComment = value;
}

////@override
public int inferredTypeSlot
{
    get => _inferredTypeSlot ??= 0;
}

/**
 * If this variable is inferable, nonzero slot id identifying which entry in
 * [LinkedLibrary.types] contains the inferred type for this variable.  If
 * there is no matching entry in [LinkedLibrary.types], then no type was
 * inferred for this variable, so its static type is `dynamic`.
 */
void setinferredTypeSlot(int value)
{
    assert(value == null || value >= 0);
    this._inferredTypeSlot = value;
}

////@override
public int inheritsCovariantSlot
{
    get => _inheritsCovariantSlot ??= 0;
}

/**
 * If this is an instance non-public readonly field, a nonzero slot id which is unique
 * within this compilation unit.  If this id is found in
 * [LinkedUnit.parametersInheritingCovariant], then the parameter of the
 * synthetic setter inherits `//@covariant` behavior from a base class.
 *
 * Otherwise, zero.
 */
void setinheritsCovariantSlot(int value)
{
    assert(value == null || value >= 0);
    this._inheritsCovariantSlot = value;
}

////@override
public UnlinkedExecutableBuilder initializer
{
    get => _initializer;
}

/**
 * The synthetic initializer function of the variable.  Absent if the variable
 * does not have an initializer.
 */
void setinitializer(UnlinkedExecutableBuilder value)
{
    this._initializer = value;
}

////@override
public bool isConst
{
    get => _isConst ??= false;
}

/**
 * Indicates whether the variable is declared using the `const` keyword.
 */
void setisConst(bool value)
{
    this._isConst = value;
}

////@override
public bool isCovariant
{
    get => _isCovariant ??= false;
}

/**
 * Indicates whether this variable is declared using the `covariant` keyword.
 * This should be false for everything except instance fields.
 */
void setisCovariant(bool value)
{
    this._isCovariant = value;
}

////@override
public bool isFinal
{
    get => _isFinal ??= false;
}

/**
 * Indicates whether the variable is declared using the `final` keyword.
 */
void setisFinal(bool value)
{
    this._isFinal = value;
}

////@override
public bool isStatic
{
    get => _isStatic ??= false;
}

/**
 * Indicates whether the variable is declared using the `static` keyword.
 *
 * Note that for top level variables, this flag is false, since they are not
 * declared using the `static` keyword (even though they are considered
 * static for semantic purposes).
 */
void setisStatic(bool value)
{
    this._isStatic = value;
}

////@override
public String name
{
    get => _name ??= "";
}

/**
 * Name of the variable.
 */
void setname(String value)
{
    this._name = value;
}

////@override
public int nameOffset
{
    get => _nameOffset ??= 0;
}

/**
 * Offset of the variable name relative to the beginning of the file.
 */
void setnameOffset(int value)
{
    assert(value == null || value >= 0);
    this._nameOffset = value;
}

////@override
public int propagatedTypeSlot
{
    get => _propagatedTypeSlot ??= 0;
}

/**
 * If this variable is propagable, nonzero slot id identifying which entry in
 * [LinkedLibrary.types] contains the propagated type for this variable.  If
 * there is no matching entry in [LinkedLibrary.types], then this variable's
 * propagated type is the same as its declared type.
 *
 * Non-propagable variables have a [propagatedTypeSlot] of zero.
 */
void setpropagatedTypeSlot(int value)
{
    assert(value == null || value >= 0);
    this._propagatedTypeSlot = value;
}

////@override
public EntityRefBuilder type
{
    get => _type;
}

/**
 * Declared type of the variable.  Absent if the type is implicit.
 */
void settype(EntityRefBuilder value)
{
    this._type = value;
}

////@override
Null get visibleLength =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
Null get visibleOffset =>
      throw new NotImplementedException("attempt to access deprecated field");

UnlinkedVariableBuilder(
        {
    List<UnlinkedExprBuilder> annotations,
   CodeRangeBuilder codeRange,
      UnlinkedDocumentationCommentBuilder documentationComment,
      int inferredTypeSlot,
      int inheritsCovariantSlot,
      UnlinkedExecutableBuilder initializer,
      bool isConst,
      bool isCovariant,
      bool isFinal,
      bool isStatic,
      String name,
      int nameOffset,
      int propagatedTypeSlot,
      EntityRefBuilder type)
      : _annotations = annotations,
        _codeRange = codeRange,
        _documentationComment = documentationComment,
        _inferredTypeSlot = inferredTypeSlot,
        _inheritsCovariantSlot = inheritsCovariantSlot,
        _initializer = initializer,
        _isConst = isConst,
        _isCovariant = isCovariant,
        _isFinal = isFinal,
        _isStatic = isStatic,
        _name = name,
        _nameOffset = nameOffset,
        _propagatedTypeSlot = propagatedTypeSlot,
        _type = type;

    /**
     * Flush [informative] data recursively.
     */
    void flushInformative()
    {
        _annotations?.forEach((b) => b.flushInformative());
        _codeRange = null;
        _documentationComment = null;
        _initializer?.flushInformative();
        _nameOffset = null;
        _type?.flushInformative();
    }

    /**
     * Accumulate non-[informative] data into [signature].
     */
    void collectApiSignature(api_sig.ApiSignature signature)
    {
        signature.addString(this._name ?? "");
        signature.addInt(this._propagatedTypeSlot ?? 0);
        signature.addBool(this._type != null);
        this._type?.collectApiSignature(signature);
        signature.addBool(this._isStatic == true);
        signature.addBool(this._isConst == true);
        signature.addBool(this._isFinal == true);
        if (this._annotations == null)
        {
            signature.addInt(0);
        }
        else
        {
            signature.addInt(this._annotations.length);
            foreach (var x in this._annotations)
            {
                x?.collectApiSignature(signature);
            }
        }
        signature.addInt(this._inferredTypeSlot ?? 0);
        signature.addBool(this._initializer != null);
        this._initializer?.collectApiSignature(signature);
        signature.addBool(this._isCovariant == true);
        signature.addInt(this._inheritsCovariantSlot ?? 0);
    }

    fb.Offset finish(fb.Builder fbBuilder)
    {
        fb.Offset offset_annotations;
        fb.Offset offset_codeRange;
        fb.Offset offset_documentationComment;
        fb.Offset offset_initializer;
        fb.Offset offset_name;
        fb.Offset offset_type;
        if (!(_annotations == null || _annotations.isEmpty))
        {
            offset_annotations = fbBuilder
                .writeList(_annotations.map((b) => b.finish(fbBuilder)).toList());
        }
        if (_codeRange != null)
        {
            offset_codeRange = _codeRange.finish(fbBuilder);
        }
        if (_documentationComment != null)
        {
            offset_documentationComment = _documentationComment.finish(fbBuilder);
        }
        if (_initializer != null)
        {
            offset_initializer = _initializer.finish(fbBuilder);
        }
        if (_name != null)
        {
            offset_name = fbBuilder.writeString(_name);
        }
        if (_type != null)
        {
            offset_type = _type.finish(fbBuilder);
        }
        fbBuilder.startTable();
        if (offset_annotations != null)
        {
            fbBuilder.addOffset(8, offset_annotations);
        }
        if (offset_codeRange != null)
        {
            fbBuilder.addOffset(5, offset_codeRange);
        }
        if (offset_documentationComment != null)
        {
            fbBuilder.addOffset(10, offset_documentationComment);
        }
        if (_inferredTypeSlot != null && _inferredTypeSlot != 0)
        {
            fbBuilder.addUint32(9, _inferredTypeSlot);
        }
        if (_inheritsCovariantSlot != null && _inheritsCovariantSlot != 0)
        {
            fbBuilder.addUint32(15, _inheritsCovariantSlot);
        }
        if (offset_initializer != null)
        {
            fbBuilder.addOffset(13, offset_initializer);
        }
        if (_isConst == true)
        {
            fbBuilder.addBool(6, true);
        }
        if (_isCovariant == true)
        {
            fbBuilder.addBool(14, true);
        }
        if (_isFinal == true)
        {
            fbBuilder.addBool(7, true);
        }
        if (_isStatic == true)
        {
            fbBuilder.addBool(4, true);
        }
        if (offset_name != null)
        {
            fbBuilder.addOffset(0, offset_name);
        }
        if (_nameOffset != null && _nameOffset != 0)
        {
            fbBuilder.addUint32(1, _nameOffset);
        }
        if (_propagatedTypeSlot != null && _propagatedTypeSlot != 0)
        {
            fbBuilder.addUint32(2, _propagatedTypeSlot);
        }
        if (offset_type != null)
        {
            fbBuilder.addOffset(3, offset_type);
        }
        return fbBuilder.endTable();
    }
}
public class _UnlinkedVariableReader : fb.TableReader<_UnlinkedVariableImpl>
{
    public _UnlinkedVariableReader();

    ////@override
    _UnlinkedVariableImpl createObject(fb.BufferContext bc, int offset) =>
      new _UnlinkedVariableImpl(bc, offset);
}
public class _UnlinkedVariableImpl : Object
    with _UnlinkedVariableMixin
    : idl.UnlinkedVariable
{
    public readonly fb.BufferContext _bc;
    public readonly int _bcOffset;

    _UnlinkedVariableImpl(this._bc, this._bcOffset);

    List<idl.UnlinkedExpr> _annotations;
    idl.CodeRange _codeRange;
    idl.UnlinkedDocumentationComment _documentationComment;
    int _inferredTypeSlot;
    int _inheritsCovariantSlot;
    idl.UnlinkedExecutable _initializer;
    bool _isConst;
    bool _isCovariant;
    bool _isFinal;
    bool _isStatic;
    String _name;
    int _nameOffset;
    int _propagatedTypeSlot;
    idl.EntityRef _type;

    ////@override
    List<idl.UnlinkedExpr> get annotations {
        _annotations ??=
public fb.ListReader<idl.UnlinkedExpr>(const _UnlinkedExprReader())
            .vTableGet(_bc, _bcOffset, 8, new List<idl.UnlinkedExpr>{);
        return _annotations;
    }

////@override
idl.CodeRange get codeRange {
        _codeRange ??= new _CodeRangeReader().vTableGet(_bc, _bcOffset, 5, null);
        return _codeRange;
    }

    ////@override
    idl.UnlinkedDocumentationComment get documentationComment {
        _documentationComment ??= new _UnlinkedDocumentationCommentReader()
          .vTableGet(_bc, _bcOffset, 10, null);
        return _documentationComment;
    }

    ////@override
    int get inferredTypeSlot {
        _inferredTypeSlot ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 9, 0);
        return _inferredTypeSlot;
    }

    ////@override
    int get inheritsCovariantSlot {
        _inheritsCovariantSlot ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 15, 0);
        return _inheritsCovariantSlot;
    }

    ////@override
    idl.UnlinkedExecutable get initializer {
        _initializer ??=
public _UnlinkedExecutableReader().vTableGet(_bc, _bcOffset, 13, null);
        return _initializer;
    }

    ////@override
    bool get isConst {
        _isConst ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 6, false);
        return _isConst;
    }

    ////@override
    bool get isCovariant {
        _isCovariant ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 14, false);
        return _isCovariant;
    }

    ////@override
    bool get isFinal {
        _isFinal ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 7, false);
        return _isFinal;
    }

    ////@override
    bool get isStatic {
        _isStatic ??= new fb.BoolReader().vTableGet(_bc, _bcOffset, 4, false);
        return _isStatic;
    }

    ////@override
    String get name {
        _name ??= new fb.StringReader().vTableGet(_bc, _bcOffset, 0, "");
        return _name;
    }

    ////@override
    int get nameOffset {
        _nameOffset ??= new fb.Uint32Reader().vTableGet(_bc, _bcOffset, 1, 0);
        return _nameOffset;
    }

    ////@override
    int get propagatedTypeSlot {
        _propagatedTypeSlot ??=
public fb.Uint32Reader().vTableGet(_bc, _bcOffset, 2, 0);
        return _propagatedTypeSlot;
    }

    ////@override
    idl.EntityRef get type {
        _type ??= new _EntityRefReader().vTableGet(_bc, _bcOffset, 3, null);
        return _type;
    }

    ////@override
    Null get visibleLength =>
      throw new NotImplementedException("attempt to access deprecated field");

////@override
Null get visibleOffset =>
      throw new NotImplementedException("attempt to access deprecated field");
    }
public abstract class _UnlinkedVariableMixin : idl.UnlinkedVariable
{
    ////@override
    Dictionary<String, Object> toJson()
    {
        Dictionary<String, Object> _result = new Dictionary<String, Object> { };
        if (annotations.isNotEmpty)
            _result["annotations"] =
                annotations.map((_value) => _value.toJson()).toList();
        if (codeRange != null) _result["codeRange"] = codeRange.toJson();
        if (documentationComment != null)
            _result["documentationComment"] = documentationComment.toJson();
        if (inferredTypeSlot != 0) _result["inferredTypeSlot"] = inferredTypeSlot;
        if (inheritsCovariantSlot != 0)
            _result["inheritsCovariantSlot"] = inheritsCovariantSlot;
        if (initializer != null) _result["initializer"] = initializer.toJson();
        if (isConst != false) _result["isConst"] = isConst;
        if (isCovariant != false) _result["isCovariant"] = isCovariant;
        if (isFinal != false) _result["isFinal"] = isFinal;
        if (isStatic != false) _result["isStatic"] = isStatic;
        if (name != "") _result["name"] = name;
        if (nameOffset != 0) _result["nameOffset"] = nameOffset;
        if (propagatedTypeSlot != 0)
            _result["propagatedTypeSlot"] = propagatedTypeSlot;
        if (type != null) _result["type"] = type.toJson();
        return _result;
    }

    ////@override
    Dictionary<String, Object> toMap() => {
        "annotations": annotations,
        "codeRange": codeRange,
        "documentationComment": documentationComment,
        "inferredTypeSlot": inferredTypeSlot,
        "inheritsCovariantSlot": inheritsCovariantSlot,
        "initializer": initializer,
        "isConst": isConst,
        "isCovariant": isCovariant,
        "isFinal": isFinal,
        "isStatic": isStatic,
        "name": name,
        "nameOffset": nameOffset,
        "propagatedTypeSlot": propagatedTypeSlot,
        "type": type,
      };

////@override
String toString() => convert.json.encode(toJson());
}
}
