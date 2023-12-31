// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/framework/full_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/framework/full_type.proto</summary>
  public static partial class FullTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/framework/full_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FullTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cil0ZW5zb3JmbG93L2NvcmUvZnJhbWV3b3JrL2Z1bGxfdHlwZS5wcm90bxIK",
            "dGVuc29yZmxvdyJ/CgtGdWxsVHlwZURlZhInCgd0eXBlX2lkGAEgASgOMhYu",
            "dGVuc29yZmxvdy5GdWxsVHlwZUlkEiUKBGFyZ3MYAiADKAsyFy50ZW5zb3Jm",
            "bG93LkZ1bGxUeXBlRGVmEgsKAXMYAyABKAlIABILCgFpGAQgASgDSABCBgoE",
            "YXR0cirDBAoKRnVsbFR5cGVJZBINCglURlRfVU5TRVQQABILCgdURlRfVkFS",
            "EAESCwoHVEZUX0FOWRACEg8KC1RGVF9QUk9EVUNUEAMSDQoJVEZUX05BTUVE",
            "EAQSEAoMVEZUX0ZPUl9FQUNIEBQSEAoMVEZUX0NBTExBQkxFEGQSDwoKVEZU",
            "X1RFTlNPUhDoBxIOCglURlRfQVJSQVkQ6QcSEQoMVEZUX09QVElPTkFMEOoH",
            "EhAKC1RGVF9MSVRFUkFMEOsHEhAKC1RGVF9FTkNPREVEEOwHEg0KCFRGVF9C",
            "T09MEMgBEg4KCVRGVF9VSU5UOBDJARIPCgpURlRfVUlOVDE2EMoBEg8KClRG",
            "VF9VSU5UMzIQywESDwoKVEZUX1VJTlQ2NBDMARINCghURlRfSU5UOBDNARIO",
            "CglURlRfSU5UMTYQzgESDgoJVEZUX0lOVDMyEM8BEg4KCVRGVF9JTlQ2NBDQ",
            "ARINCghURlRfSEFMRhDRARIOCglURlRfRkxPQVQQ0gESDwoKVEZUX0RPVUJM",
            "RRDTARIRCgxURlRfQkZMT0FUMTYQ1wESEgoNVEZUX0NPTVBMRVg2NBDUARIT",
            "Cg5URlRfQ09NUExFWDEyOBDVARIPCgpURlRfU1RSSU5HENYBEhAKC1RGVF9E",
            "QVRBU0VUEPZOEg8KClRGVF9SQUdHRUQQ904SEQoMVEZUX0lURVJBVE9SEPhO",
            "EhMKDlRGVF9NVVRFWF9MT0NLENpPEhcKElRGVF9MRUdBQ1lfVkFSSUFOVBDb",
            "T0KBAQoYb3JnLnRlbnNvcmZsb3cuZnJhbWV3b3JrQg5GdWxsVHlwZVByb3Rv",
            "c1ABWlBnaXRodWIuY29tL3RlbnNvcmZsb3cvdGVuc29yZmxvdy90ZW5zb3Jm",
            "bG93L2dvL2NvcmUvZnJhbWV3b3JrL2Z1bGxfdHlwZV9nb19wcm90b/gBAWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Tensorflow.FullTypeId), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.FullTypeDef), global::Tensorflow.FullTypeDef.Parser, new[]{ "TypeId", "Args", "S", "I" }, new[]{ "Attr" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// LINT.IfChange
  /// Experimental. Represents the complete type information of a TensorFlow value.
  /// </summary>
  public enum FullTypeId {
    /// <summary>
    /// The default represents an uninitialized values.
    /// </summary>
    [pbr::OriginalName("TFT_UNSET")] TftUnset = 0,
    /// <summary>
    /// Type variables may serve as placeholder for any other type ID in type
    /// templates.
    ///
    /// Examples:
    ///   TFT_DATASET[TFT_VAR["T"]] is a Dataset returning a type indicated by "T".
    ///   TFT_TENSOR[TFT_VAR["T"]] is a Tensor of n element type indicated by "T".
    ///   TFT_TENSOR[TFT_VAR["T"]], TFT_TENSOR[TFT_VAR["T"]] are two tensors of
    ///     identical element types.
    ///   TFT_TENSOR[TFT_VAR["P"]], TFT_TENSOR[TFT_VAR["Q"]] are two tensors of
    ///     independent element types.
    /// </summary>
    [pbr::OriginalName("TFT_VAR")] TftVar = 1,
    /// <summary>
    /// Wildcard type. Describes a parameter of unknown type. In TensorFlow, that
    /// can mean either a "Top" type (accepts any type), or a dynamically typed
    /// object whose type is unknown in context.
    /// Important: "unknown" does not necessarily mean undeterminable!
    /// </summary>
    [pbr::OriginalName("TFT_ANY")] TftAny = 2,
    /// <summary>
    /// The algebraic product type. This is an algebraic type that may be used just
    /// for logical grouping. Not to confused with TFT_TUPLE which describes a
    /// concrete object of several elements.
    ///
    /// Example:
    ///   TFT_DATASET[TFT_PRODUCT[TFT_TENSOR[TFT_INT32], TFT_TENSOR[TFT_FLOAT64]]]
    ///     is a Dataset producing two tensors, an integer one and a float one.
    /// </summary>
    [pbr::OriginalName("TFT_PRODUCT")] TftProduct = 3,
    /// <summary>
    /// Represents a named field, with the name stored in the attribute.
    ///
    /// Parametrization:
    ///   TFT_NAMED[&lt;type>]{&lt;name>}
    ///   * &lt;type> is the type of the field
    ///   * &lt;name> is the field name, as string (thpugh can theoretically be an int
    ///     as well)
    ///
    /// Example:
    ///   TFT_RECORD[
    ///     TFT_NAMED[TFT_TENSOR[TFT_INT32]]{'foo'},
    ///     TFT_NAMED[TFT_TENSOR[TFT_FLOAT32]]{'bar'},
    ///   ]
    ///     is a structure with two fields, an int tensor "foo" and a float tensor
    ///     "bar".
    /// </summary>
    [pbr::OriginalName("TFT_NAMED")] TftNamed = 4,
    /// <summary>
    /// Template definition. Expands the variables by repeating a template as
    /// arguments of container.
    ///
    /// Parametrization:
    ///   TFT_FOR_EACH[&lt;container_type>, &lt;template>, &lt;expansions>]
    ///   * &lt;container_type> is the type of the container that the template will be
    ///     expanded into
    ///   * &lt;template> is any type definition that potentially contains type
    ///     variables
    ///   * &lt;expansions> is a TFT_VAR and may include more types in the future
    ///
    /// Example:
    ///   TFT_FOR_EACH[
    ///         TFT_PRODUCT,
    ///         TFT_TENSOR[TFT_VAR["t"]],
    ///         TFT_VAR["t"]
    ///     ]
    ///     will substitute a T = TFT_INT32 to TFT_PRODUCT[TFT_TENSOR[TFT_INT32]]
    ///     and a T = (TFT_INT32, TFT_INT64) to
    ///     TFT_PRODUCT[TFT_TENSOR[TFT_INT32], TFT_TENSOR[TFT_INT64]].
    /// </summary>
    [pbr::OriginalName("TFT_FOR_EACH")] TftForEach = 20,
    /// <summary>
    /// Callable types describe functions and ops.
    ///
    /// Parametrization:
    ///   TFT_CALLABLE[&lt;arg type>, &lt;return type>]
    ///   * &lt;arg type> is the type of the arguments; TFT_PRODUCT represents
    ///   multiple
    ///     arguments.
    ///   * &lt;return type> is the return type; TFT_PRODUCT represents multiple
    ///     return values (that means that callables returning multiple things
    ///     don't necessarily return a single tuple).
    ///
    /// Example:
    ///   TFT_CALLABLE[
    ///     TFT_ANY,
    ///     TFT_PRODUCT[TFT_TENSOR[TFT_INT32], TFT_TENSOR[TFT_FLOAT64]],
    ///   ]
    ///     is a callable with unspecified (for now) input arguments, and
    ///     two return values of type tensor.
    /// </summary>
    [pbr::OriginalName("TFT_CALLABLE")] TftCallable = 100,
    /// <summary>
    /// The usual Tensor. This is a parametric type.
    ///
    /// Parametrization:
    ///   TFT_TENSOR[&lt;element type>, &lt;shape type>]
    ///   * &lt;element type> is currently limited to one of the element types
    ///     defined below.
    ///   * &lt;shape type> is not yet defined, and may only be TFT_UNKNOWN for now.
    ///
    /// A TFT_SHAPE type will be defined in the future.
    ///
    /// Example:
    ///   TFT_TENSOR[TFT_INT32, TFT_UNKNOWN]
    ///     is a Tensor of int32 element type and unknown shape.
    ///
    /// TODO(mdan): Define TFT_SHAPE and add more examples.
    /// </summary>
    [pbr::OriginalName("TFT_TENSOR")] TftTensor = 1000,
    /// <summary>
    /// Array (or tensorflow::TensorList in the variant type registry).
    /// Note: this is not to be confused with the deprecated `TensorArray*` ops
    /// which are not supported by FullType.
    /// This type represents a random-access list whose elements can be
    /// described by a single type. Although immutable, Array is expected to
    /// support efficient mutation semantics (i.e. element update) in the
    /// user-facing API.
    /// The element type may be generic or even TFT_ANY for a heterogenous list.
    ///
    /// Parametrization:
    ///   TFT_ARRAY[&lt;element type>]
    ///   * &lt;element type> may be any concrete type.
    ///
    /// Examples:
    ///   TFT_ARRAY[TFT_TENSOR[TFT_INT32]] is a TensorArray holding int32 Tensors
    ///     of any shape.
    ///   TFT_ARRAY[TFT_TENSOR[TFT_UNKNOWN]] is a TensorArray holding Tensors of
    ///     mixed element types.
    ///   TFT_ARRAY[TFT_UNKNOWN] is a TensorArray holding any element type.
    ///   TFT_ARRAY[] is equivalent to TFT_ARRAY[TFT_UNKNOWN].
    ///   TFT_ARRAY[TFT_ARRAY[]] is an array or arrays (of unknown types).
    /// </summary>
    [pbr::OriginalName("TFT_ARRAY")] TftArray = 1001,
    /// <summary>
    /// Optional (or tensorflow::OptionalVariant in the variant type registry).
    /// This type represents a value that may either hold an element of a single
    /// specified type, or nothing at all.
    ///
    /// Parametrization:
    ///   TFT_OPTIONAL[&lt;element type>]
    ///   * &lt;element type> may be any concrete type.
    ///
    /// Examples:
    ///   TFT_OPTIONAL[TFT_TENSOR[TFT_INT32]] is an Optional holding an int32
    ///     Tensor of any shape.
    /// </summary>
    [pbr::OriginalName("TFT_OPTIONAL")] TftOptional = 1002,
    /// <summary>
    /// Literal types describe compile-time constant values.
    /// Literal types may also participate in dependent types.
    ///
    /// Parametrization:
    ///   TFT_LITERAL[&lt;value type>]{&lt;value>}
    ///   * &lt;value type> may be any concrete type compatible that can hold &lt;value>
    ///   * &lt;value> is the type's attribute, and holds the actual literal value
    ///
    /// Examples:
    ///   TFT_LITERAL[TFT_INT32]{1} is the compile-time constant 1.
    /// </summary>
    [pbr::OriginalName("TFT_LITERAL")] TftLiteral = 1003,
    /// <summary>
    /// Encoding types describe a value of a certain type, encoded as a different
    /// type.
    ///
    /// Parametrization:
    ///   TFT_ENCODED[&lt;encoded type>, &lt;encoding type>]
    ///   * &lt;encoded type> may be any type
    ///   * &lt;encoding type> may be any type
    ///
    /// Examples:
    ///   TFT_ENCODING[TFT_INT32, TFT_STRING] is an integer encoded as string.
    /// </summary>
    [pbr::OriginalName("TFT_ENCODED")] TftEncoded = 1004,
    /// <summary>
    /// The bool element type.
    /// TODO(mdan): Quantized types, legacy representations (e.g. ref)
    /// </summary>
    [pbr::OriginalName("TFT_BOOL")] TftBool = 200,
    /// <summary>
    /// Integer element types.
    /// </summary>
    [pbr::OriginalName("TFT_UINT8")] TftUint8 = 201,
    [pbr::OriginalName("TFT_UINT16")] TftUint16 = 202,
    [pbr::OriginalName("TFT_UINT32")] TftUint32 = 203,
    [pbr::OriginalName("TFT_UINT64")] TftUint64 = 204,
    [pbr::OriginalName("TFT_INT8")] TftInt8 = 205,
    [pbr::OriginalName("TFT_INT16")] TftInt16 = 206,
    [pbr::OriginalName("TFT_INT32")] TftInt32 = 207,
    [pbr::OriginalName("TFT_INT64")] TftInt64 = 208,
    /// <summary>
    /// Floating-point element types.
    /// </summary>
    [pbr::OriginalName("TFT_HALF")] TftHalf = 209,
    [pbr::OriginalName("TFT_FLOAT")] TftFloat = 210,
    [pbr::OriginalName("TFT_DOUBLE")] TftDouble = 211,
    [pbr::OriginalName("TFT_BFLOAT16")] TftBfloat16 = 215,
    /// <summary>
    /// Complex element types.
    /// TODO(mdan): Represent as TFT_COMPLEX[TFT_DOUBLE] instead?
    /// </summary>
    [pbr::OriginalName("TFT_COMPLEX64")] TftComplex64 = 212,
    [pbr::OriginalName("TFT_COMPLEX128")] TftComplex128 = 213,
    /// <summary>
    /// The string element type.
    /// </summary>
    [pbr::OriginalName("TFT_STRING")] TftString = 214,
    /// <summary>
    /// Datasets created by tf.data ops and APIs. Datasets have generator/iterable
    /// semantics, that is, one can construct an iterator from them. Like
    /// Array, they are considered to return elements that can be described
    /// by a single type. Unlike Array, they do not support random access or
    /// mutation, and can potentially produce an infinite number of elements.
    /// A datasets can produce logical structures (e.g. multiple elements). This
    /// is expressed using TFT_PRODUCT.
    ///
    /// Parametrization: TFT_DATASET[&lt;element type>].
    ///   * &lt;element type> may be a concrete type or a type symbol. It represents
    ///     the data type of the elements produced by the dataset.
    ///
    /// Examples:
    ///   TFT_DATSET[TFT_TENSOR[TFT_INT32]] is a Dataset producing single int32
    ///     Tensors of unknown shape.
    ///   TFT_DATSET[TFT_PRODUCT[TFT_TENSOR[TFT_INT32], TFT_TENSOR[TFT_FLOAT32]] is
    ///     a Dataset producing pairs of Tensors, one integer and one float.
    /// Note: The high ID number is to prepare for the eventuality that Datasets
    /// will be supported by user types in the future.
    /// </summary>
    [pbr::OriginalName("TFT_DATASET")] TftDataset = 10102,
    /// <summary>
    /// A ragged tensor created by tf.ragged ops and APIs.
    ///
    /// Parametrization: TFT_RAGGED[&lt;element_type>].
    /// </summary>
    [pbr::OriginalName("TFT_RAGGED")] TftRagged = 10103,
    /// <summary>
    /// Iterators created by tf.data ops and APIs. Very similar to Datasets, except
    /// they are mutable.
    ///
    /// Parametrization: TFT_ITERATOR[&lt;element type>].
    ///   * &lt;element type> may be a concrete type or a type symbol. It represents
    ///     the data type of the elements produced by the dataset.
    /// </summary>
    [pbr::OriginalName("TFT_ITERATOR")] TftIterator = 10104,
    /// <summary>
    /// A mutex lock tensor, produced by tf.raw_ops.MutexLock.
    /// Unlike strict execution models, where ownership of a lock is denoted by
    /// "running after the lock has been acquired", in non-strict mode, lock
    /// ownership is in the true sense: "the op argument representing the lock is
    /// available".
    /// Mutex locks are the dynamic counterpart of control dependencies.
    /// TODO(mdan): Properly document this thing.
    ///
    /// Parametrization: TFT_MUTEX_LOCK[].
    /// </summary>
    [pbr::OriginalName("TFT_MUTEX_LOCK")] TftMutexLock = 10202,
    /// <summary>
    /// The equivalent of a Tensor with DT_VARIANT dtype, kept here to simplify
    /// translation. This type should not normally appear after type inference.
    /// Note that LEGACY_VARIANT != ANY: TENSOR[INT32] is a subtype of ANY, but is
    /// not a subtype of LEGACY_VARIANT.
    /// </summary>
    [pbr::OriginalName("TFT_LEGACY_VARIANT")] TftLegacyVariant = 10203,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Highly experimental and very likely to change.
  /// This encoding uses tags instead of dedicated messages for regularity. In
  /// particular the encoding imposes no restrictions on what the parameters of any
  /// type should be, which in particular needs to be true for type symbols.
  /// </summary>
  public sealed partial class FullTypeDef : pb::IMessage<FullTypeDef>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FullTypeDef> _parser = new pb::MessageParser<FullTypeDef>(() => new FullTypeDef());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FullTypeDef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.FullTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FullTypeDef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FullTypeDef(FullTypeDef other) : this() {
      typeId_ = other.typeId_;
      args_ = other.args_.Clone();
      switch (other.AttrCase) {
        case AttrOneofCase.S:
          S = other.S;
          break;
        case AttrOneofCase.I:
          I = other.I;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FullTypeDef Clone() {
      return new FullTypeDef(this);
    }

    /// <summary>Field number for the "type_id" field.</summary>
    public const int TypeIdFieldNumber = 1;
    private global::Tensorflow.FullTypeId typeId_ = global::Tensorflow.FullTypeId.TftUnset;
    /// <summary>
    /// The principal type represented by this object. This may be a concrete type
    /// (Tensor, Dataset) a type variable (used for dependent types) a type
    /// symbol (Any, Union). See FullTypeId for details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tensorflow.FullTypeId TypeId {
      get { return typeId_; }
      set {
        typeId_ = value;
      }
    }

    /// <summary>Field number for the "args" field.</summary>
    public const int ArgsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Tensorflow.FullTypeDef> _repeated_args_codec
        = pb::FieldCodec.ForMessage(18, global::Tensorflow.FullTypeDef.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.FullTypeDef> args_ = new pbc::RepeatedField<global::Tensorflow.FullTypeDef>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Tensorflow.FullTypeDef> Args {
      get { return args_; }
    }

    /// <summary>Field number for the "s" field.</summary>
    public const int SFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string S {
      get { return attrCase_ == AttrOneofCase.S ? (string) attr_ : ""; }
      set {
        attr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        attrCase_ = AttrOneofCase.S;
      }
    }

    /// <summary>Field number for the "i" field.</summary>
    public const int IFieldNumber = 4;
    /// <summary>
    /// TODO(mdan): list/tensor, map? Need to reconcile with TFT_RECORD, etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long I {
      get { return attrCase_ == AttrOneofCase.I ? (long) attr_ : 0L; }
      set {
        attr_ = value;
        attrCase_ = AttrOneofCase.I;
      }
    }

    private object attr_;
    /// <summary>Enum of possible cases for the "attr" oneof.</summary>
    public enum AttrOneofCase {
      None = 0,
      S = 3,
      I = 4,
    }
    private AttrOneofCase attrCase_ = AttrOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AttrOneofCase AttrCase {
      get { return attrCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAttr() {
      attrCase_ = AttrOneofCase.None;
      attr_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FullTypeDef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FullTypeDef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TypeId != other.TypeId) return false;
      if(!args_.Equals(other.args_)) return false;
      if (S != other.S) return false;
      if (I != other.I) return false;
      if (AttrCase != other.AttrCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TypeId != global::Tensorflow.FullTypeId.TftUnset) hash ^= TypeId.GetHashCode();
      hash ^= args_.GetHashCode();
      if (attrCase_ == AttrOneofCase.S) hash ^= S.GetHashCode();
      if (attrCase_ == AttrOneofCase.I) hash ^= I.GetHashCode();
      hash ^= (int) attrCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (TypeId != global::Tensorflow.FullTypeId.TftUnset) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TypeId);
      }
      args_.WriteTo(output, _repeated_args_codec);
      if (attrCase_ == AttrOneofCase.S) {
        output.WriteRawTag(26);
        output.WriteString(S);
      }
      if (attrCase_ == AttrOneofCase.I) {
        output.WriteRawTag(32);
        output.WriteInt64(I);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TypeId != global::Tensorflow.FullTypeId.TftUnset) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TypeId);
      }
      args_.WriteTo(ref output, _repeated_args_codec);
      if (attrCase_ == AttrOneofCase.S) {
        output.WriteRawTag(26);
        output.WriteString(S);
      }
      if (attrCase_ == AttrOneofCase.I) {
        output.WriteRawTag(32);
        output.WriteInt64(I);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (TypeId != global::Tensorflow.FullTypeId.TftUnset) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TypeId);
      }
      size += args_.CalculateSize(_repeated_args_codec);
      if (attrCase_ == AttrOneofCase.S) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(S);
      }
      if (attrCase_ == AttrOneofCase.I) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(I);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FullTypeDef other) {
      if (other == null) {
        return;
      }
      if (other.TypeId != global::Tensorflow.FullTypeId.TftUnset) {
        TypeId = other.TypeId;
      }
      args_.Add(other.args_);
      switch (other.AttrCase) {
        case AttrOneofCase.S:
          S = other.S;
          break;
        case AttrOneofCase.I:
          I = other.I;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            TypeId = (global::Tensorflow.FullTypeId) input.ReadEnum();
            break;
          }
          case 18: {
            args_.AddEntriesFrom(input, _repeated_args_codec);
            break;
          }
          case 26: {
            S = input.ReadString();
            break;
          }
          case 32: {
            I = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            TypeId = (global::Tensorflow.FullTypeId) input.ReadEnum();
            break;
          }
          case 18: {
            args_.AddEntriesFrom(ref input, _repeated_args_codec);
            break;
          }
          case 26: {
            S = input.ReadString();
            break;
          }
          case 32: {
            I = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
