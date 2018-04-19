// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: connection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from connection.proto</summary>
public static partial class ConnectionReflection {

  #region Descriptor
  /// <summary>File descriptor for connection.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ConnectionReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBjb25uZWN0aW9uLnByb3RvIhgKFkNvbm5lY3Rpb25PZmZlclJlcXVlc3Qi",
          "NQoXQ29ubmVjdGlvbk9mZmVyUmVzcG9uc2USCwoDZGlkGAEgASgJEg0KBW5v",
          "bmNlGAIgASgJIjUKF0Nvbm5lY3Rpb25DcmVhdGVSZXF1ZXN0EgsKA2RpZBgB",
          "IAEoCRINCgVub25jZRgDIAEoCSKxAQoYQ29ubmVjdGlvbkNyZWF0ZVJlc3Bv",
          "bnNlEjAKBnN0YXR1cxgBIAEoDjIgLkNvbm5lY3Rpb25DcmVhdGVSZXNwb25z",
          "ZS5TdGF0dXMiYwoGU3RhdHVzEhAKDFNUQVRVU19VTlNFVBAAEgYKAk9LEAES",
          "FQoRSU5WQUxJRF9TSUdOQVRVUkUQAhIVChFNSVNTSU5HX1NJR05BVFVSRRAD",
          "EhEKDVVOS05PV05fRVJST1IQBGIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ConnectionOfferRequest), global::ConnectionOfferRequest.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ConnectionOfferResponse), global::ConnectionOfferResponse.Parser, new[]{ "Did", "Nonce" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ConnectionCreateRequest), global::ConnectionCreateRequest.Parser, new[]{ "Did", "Nonce" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ConnectionCreateResponse), global::ConnectionCreateResponse.Parser, new[]{ "Status" }, null, new[]{ typeof(global::ConnectionCreateResponse.Types.Status) }, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ConnectionOfferRequest : pb::IMessage<ConnectionOfferRequest> {
  private static readonly pb::MessageParser<ConnectionOfferRequest> _parser = new pb::MessageParser<ConnectionOfferRequest>(() => new ConnectionOfferRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ConnectionOfferRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ConnectionReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionOfferRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionOfferRequest(ConnectionOfferRequest other) : this() {
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionOfferRequest Clone() {
    return new ConnectionOfferRequest(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ConnectionOfferRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ConnectionOfferRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ConnectionOfferRequest other) {
    if (other == null) {
      return;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
      }
    }
  }

}

public sealed partial class ConnectionOfferResponse : pb::IMessage<ConnectionOfferResponse> {
  private static readonly pb::MessageParser<ConnectionOfferResponse> _parser = new pb::MessageParser<ConnectionOfferResponse>(() => new ConnectionOfferResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ConnectionOfferResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ConnectionReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionOfferResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionOfferResponse(ConnectionOfferResponse other) : this() {
    did_ = other.did_;
    nonce_ = other.nonce_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionOfferResponse Clone() {
    return new ConnectionOfferResponse(this);
  }

  /// <summary>Field number for the "did" field.</summary>
  public const int DidFieldNumber = 1;
  private string did_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Did {
    get { return did_; }
    set {
      did_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "nonce" field.</summary>
  public const int NonceFieldNumber = 2;
  private string nonce_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Nonce {
    get { return nonce_; }
    set {
      nonce_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ConnectionOfferResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ConnectionOfferResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Did != other.Did) return false;
    if (Nonce != other.Nonce) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Did.Length != 0) hash ^= Did.GetHashCode();
    if (Nonce.Length != 0) hash ^= Nonce.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Did.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Did);
    }
    if (Nonce.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Nonce);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Did.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Did);
    }
    if (Nonce.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Nonce);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ConnectionOfferResponse other) {
    if (other == null) {
      return;
    }
    if (other.Did.Length != 0) {
      Did = other.Did;
    }
    if (other.Nonce.Length != 0) {
      Nonce = other.Nonce;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Did = input.ReadString();
          break;
        }
        case 18: {
          Nonce = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class ConnectionCreateRequest : pb::IMessage<ConnectionCreateRequest> {
  private static readonly pb::MessageParser<ConnectionCreateRequest> _parser = new pb::MessageParser<ConnectionCreateRequest>(() => new ConnectionCreateRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ConnectionCreateRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ConnectionReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionCreateRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionCreateRequest(ConnectionCreateRequest other) : this() {
    did_ = other.did_;
    nonce_ = other.nonce_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionCreateRequest Clone() {
    return new ConnectionCreateRequest(this);
  }

  /// <summary>Field number for the "did" field.</summary>
  public const int DidFieldNumber = 1;
  private string did_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Did {
    get { return did_; }
    set {
      did_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "nonce" field.</summary>
  public const int NonceFieldNumber = 3;
  private string nonce_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Nonce {
    get { return nonce_; }
    set {
      nonce_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ConnectionCreateRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ConnectionCreateRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Did != other.Did) return false;
    if (Nonce != other.Nonce) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Did.Length != 0) hash ^= Did.GetHashCode();
    if (Nonce.Length != 0) hash ^= Nonce.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Did.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Did);
    }
    if (Nonce.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Nonce);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Did.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Did);
    }
    if (Nonce.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Nonce);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ConnectionCreateRequest other) {
    if (other == null) {
      return;
    }
    if (other.Did.Length != 0) {
      Did = other.Did;
    }
    if (other.Nonce.Length != 0) {
      Nonce = other.Nonce;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Did = input.ReadString();
          break;
        }
        case 26: {
          Nonce = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class ConnectionCreateResponse : pb::IMessage<ConnectionCreateResponse> {
  private static readonly pb::MessageParser<ConnectionCreateResponse> _parser = new pb::MessageParser<ConnectionCreateResponse>(() => new ConnectionCreateResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ConnectionCreateResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ConnectionReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionCreateResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionCreateResponse(ConnectionCreateResponse other) : this() {
    status_ = other.status_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ConnectionCreateResponse Clone() {
    return new ConnectionCreateResponse(this);
  }

  /// <summary>Field number for the "status" field.</summary>
  public const int StatusFieldNumber = 1;
  private global::ConnectionCreateResponse.Types.Status status_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::ConnectionCreateResponse.Types.Status Status {
    get { return status_; }
    set {
      status_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ConnectionCreateResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ConnectionCreateResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Status != other.Status) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Status != 0) hash ^= Status.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Status != 0) {
      output.WriteRawTag(8);
      output.WriteEnum((int) Status);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Status != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ConnectionCreateResponse other) {
    if (other == null) {
      return;
    }
    if (other.Status != 0) {
      Status = other.Status;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          status_ = (global::ConnectionCreateResponse.Types.Status) input.ReadEnum();
          break;
        }
      }
    }
  }

  #region Nested types
  /// <summary>Container for nested types declared in the ConnectionCreateResponse message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static partial class Types {
    public enum Status {
      [pbr::OriginalName("STATUS_UNSET")] Unset = 0,
      [pbr::OriginalName("OK")] Ok = 1,
      [pbr::OriginalName("INVALID_SIGNATURE")] InvalidSignature = 2,
      [pbr::OriginalName("MISSING_SIGNATURE")] MissingSignature = 3,
      [pbr::OriginalName("UNKNOWN_ERROR")] UnknownError = 4,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
