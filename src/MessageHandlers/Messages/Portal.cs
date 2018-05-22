// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: portal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from portal.proto</summary>
public static partial class PortalReflection {

  #region Descriptor
  /// <summary>File descriptor for portal.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PortalReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cgxwb3J0YWwucHJvdG8iKgoVUmVnaXN0ZXJJc3N1ZXJSZXF1ZXN0EhEKCW93",
          "bmVyX2RpZBgBIAEoCSIsChZSZWdpc3Rlcklzc3VlclJlc3BvbnNlEhIKCmlz",
          "c3Vlcl9kaWQYASABKAliBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RegisterIssuerRequest), global::RegisterIssuerRequest.Parser, new[]{ "OwnerDid" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::RegisterIssuerResponse), global::RegisterIssuerResponse.Parser, new[]{ "IssuerDid" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class RegisterIssuerRequest : pb::IMessage<RegisterIssuerRequest> {
  private static readonly pb::MessageParser<RegisterIssuerRequest> _parser = new pb::MessageParser<RegisterIssuerRequest>(() => new RegisterIssuerRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RegisterIssuerRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PortalReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RegisterIssuerRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RegisterIssuerRequest(RegisterIssuerRequest other) : this() {
    ownerDid_ = other.ownerDid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RegisterIssuerRequest Clone() {
    return new RegisterIssuerRequest(this);
  }

  /// <summary>Field number for the "owner_did" field.</summary>
  public const int OwnerDidFieldNumber = 1;
  private string ownerDid_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string OwnerDid {
    get { return ownerDid_; }
    set {
      ownerDid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RegisterIssuerRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RegisterIssuerRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (OwnerDid != other.OwnerDid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (OwnerDid.Length != 0) hash ^= OwnerDid.GetHashCode();
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
    if (OwnerDid.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(OwnerDid);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (OwnerDid.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(OwnerDid);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RegisterIssuerRequest other) {
    if (other == null) {
      return;
    }
    if (other.OwnerDid.Length != 0) {
      OwnerDid = other.OwnerDid;
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
          OwnerDid = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class RegisterIssuerResponse : pb::IMessage<RegisterIssuerResponse> {
  private static readonly pb::MessageParser<RegisterIssuerResponse> _parser = new pb::MessageParser<RegisterIssuerResponse>(() => new RegisterIssuerResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RegisterIssuerResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PortalReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RegisterIssuerResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RegisterIssuerResponse(RegisterIssuerResponse other) : this() {
    issuerDid_ = other.issuerDid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RegisterIssuerResponse Clone() {
    return new RegisterIssuerResponse(this);
  }

  /// <summary>Field number for the "issuer_did" field.</summary>
  public const int IssuerDidFieldNumber = 1;
  private string issuerDid_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string IssuerDid {
    get { return issuerDid_; }
    set {
      issuerDid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RegisterIssuerResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RegisterIssuerResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IssuerDid != other.IssuerDid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (IssuerDid.Length != 0) hash ^= IssuerDid.GetHashCode();
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
    if (IssuerDid.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(IssuerDid);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (IssuerDid.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(IssuerDid);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RegisterIssuerResponse other) {
    if (other == null) {
      return;
    }
    if (other.IssuerDid.Length != 0) {
      IssuerDid = other.IssuerDid;
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
          IssuerDid = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
