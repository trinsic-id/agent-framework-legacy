// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: credential.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Indy.Agent.Messages {

  /// <summary>Holder for reflection information generated from credential.proto</summary>
  public static partial class CredentialReflection {

    #region Descriptor
    /// <summary>File descriptor for credential.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CredentialReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBjcmVkZW50aWFsLnByb3RvIjoKFkNyZWRlbnRpYWxPZmZlclJlcXVlc3QS",
            "IAoYY3JlZGVudGlhbF9kZWZpbml0aW9uX2lkGAEgASgJIjgKF0NyZWRlbnRp",
            "YWxPZmZlclJlc3BvbnNlEh0KFWNyZWRlbnRpYWxfb2ZmZXJfanNvbhgBIAEo",
            "CSJzChFDcmVkZW50aWFsUmVxdWVzdBIdChVjcmVkZW50aWFsX29mZmVyX2pz",
            "b24YASABKAkSHwoXY3JlZGVudGlhbF9yZXF1ZXN0X2pzb24YAiABKAkSHgoW",
            "Y3JlZGVudGlhbF92YWx1ZXNfanNvbhgDIAEoCSIUChJDcmVkZW50aWFsUmVz",
            "cG9uc2UiewoZQ3JlZGVudGlhbElzc3VhbmNlUmVxdWVzdBIdChVjcmVkZW50",
            "aWFsX29mZmVyX2pzb24YASABKAkSHwoXY3JlZGVudGlhbF9yZXF1ZXN0X2pz",
            "b24YAiABKAkSHgoWY3JlZGVudGlhbF92YWx1ZXNfanNvbhgDIAEoCSJMChpD",
            "cmVkZW50aWFsSXNzdWFuY2VSZXNwb25zZRIXCg9jcmVkZW50aWFsX2pzb24Y",
            "ASABKAkSFQoNcmV2b2NhdGlvbl9pZBgCIAEoCUIWqgITSW5keS5BZ2VudC5N",
            "ZXNzYWdlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.CredentialOfferRequest), global::Indy.Agent.Messages.CredentialOfferRequest.Parser, new[]{ "CredentialDefinitionId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.CredentialOfferResponse), global::Indy.Agent.Messages.CredentialOfferResponse.Parser, new[]{ "CredentialOfferJson" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.CredentialRequest), global::Indy.Agent.Messages.CredentialRequest.Parser, new[]{ "CredentialOfferJson", "CredentialRequestJson", "CredentialValuesJson" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.CredentialResponse), global::Indy.Agent.Messages.CredentialResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.CredentialIssuanceRequest), global::Indy.Agent.Messages.CredentialIssuanceRequest.Parser, new[]{ "CredentialOfferJson", "CredentialRequestJson", "CredentialValuesJson" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.CredentialIssuanceResponse), global::Indy.Agent.Messages.CredentialIssuanceResponse.Parser, new[]{ "CredentialJson", "RevocationId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CredentialOfferRequest : pb::IMessage<CredentialOfferRequest> {
    private static readonly pb::MessageParser<CredentialOfferRequest> _parser = new pb::MessageParser<CredentialOfferRequest>(() => new CredentialOfferRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CredentialOfferRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.CredentialReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialOfferRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialOfferRequest(CredentialOfferRequest other) : this() {
      credentialDefinitionId_ = other.credentialDefinitionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialOfferRequest Clone() {
      return new CredentialOfferRequest(this);
    }

    /// <summary>Field number for the "credential_definition_id" field.</summary>
    public const int CredentialDefinitionIdFieldNumber = 1;
    private string credentialDefinitionId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CredentialDefinitionId {
      get { return credentialDefinitionId_; }
      set {
        credentialDefinitionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CredentialOfferRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CredentialOfferRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CredentialDefinitionId != other.CredentialDefinitionId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CredentialDefinitionId.Length != 0) hash ^= CredentialDefinitionId.GetHashCode();
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
      if (CredentialDefinitionId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CredentialDefinitionId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CredentialDefinitionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CredentialDefinitionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CredentialOfferRequest other) {
      if (other == null) {
        return;
      }
      if (other.CredentialDefinitionId.Length != 0) {
        CredentialDefinitionId = other.CredentialDefinitionId;
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
            CredentialDefinitionId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CredentialOfferResponse : pb::IMessage<CredentialOfferResponse> {
    private static readonly pb::MessageParser<CredentialOfferResponse> _parser = new pb::MessageParser<CredentialOfferResponse>(() => new CredentialOfferResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CredentialOfferResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.CredentialReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialOfferResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialOfferResponse(CredentialOfferResponse other) : this() {
      credentialOfferJson_ = other.credentialOfferJson_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialOfferResponse Clone() {
      return new CredentialOfferResponse(this);
    }

    /// <summary>Field number for the "credential_offer_json" field.</summary>
    public const int CredentialOfferJsonFieldNumber = 1;
    private string credentialOfferJson_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CredentialOfferJson {
      get { return credentialOfferJson_; }
      set {
        credentialOfferJson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CredentialOfferResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CredentialOfferResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CredentialOfferJson != other.CredentialOfferJson) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CredentialOfferJson.Length != 0) hash ^= CredentialOfferJson.GetHashCode();
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
      if (CredentialOfferJson.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CredentialOfferJson);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CredentialOfferJson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CredentialOfferJson);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CredentialOfferResponse other) {
      if (other == null) {
        return;
      }
      if (other.CredentialOfferJson.Length != 0) {
        CredentialOfferJson = other.CredentialOfferJson;
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
            CredentialOfferJson = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CredentialRequest : pb::IMessage<CredentialRequest> {
    private static readonly pb::MessageParser<CredentialRequest> _parser = new pb::MessageParser<CredentialRequest>(() => new CredentialRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CredentialRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.CredentialReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialRequest(CredentialRequest other) : this() {
      credentialOfferJson_ = other.credentialOfferJson_;
      credentialRequestJson_ = other.credentialRequestJson_;
      credentialValuesJson_ = other.credentialValuesJson_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialRequest Clone() {
      return new CredentialRequest(this);
    }

    /// <summary>Field number for the "credential_offer_json" field.</summary>
    public const int CredentialOfferJsonFieldNumber = 1;
    private string credentialOfferJson_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CredentialOfferJson {
      get { return credentialOfferJson_; }
      set {
        credentialOfferJson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "credential_request_json" field.</summary>
    public const int CredentialRequestJsonFieldNumber = 2;
    private string credentialRequestJson_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CredentialRequestJson {
      get { return credentialRequestJson_; }
      set {
        credentialRequestJson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "credential_values_json" field.</summary>
    public const int CredentialValuesJsonFieldNumber = 3;
    private string credentialValuesJson_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CredentialValuesJson {
      get { return credentialValuesJson_; }
      set {
        credentialValuesJson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CredentialRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CredentialRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CredentialOfferJson != other.CredentialOfferJson) return false;
      if (CredentialRequestJson != other.CredentialRequestJson) return false;
      if (CredentialValuesJson != other.CredentialValuesJson) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CredentialOfferJson.Length != 0) hash ^= CredentialOfferJson.GetHashCode();
      if (CredentialRequestJson.Length != 0) hash ^= CredentialRequestJson.GetHashCode();
      if (CredentialValuesJson.Length != 0) hash ^= CredentialValuesJson.GetHashCode();
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
      if (CredentialOfferJson.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CredentialOfferJson);
      }
      if (CredentialRequestJson.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CredentialRequestJson);
      }
      if (CredentialValuesJson.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CredentialValuesJson);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CredentialOfferJson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CredentialOfferJson);
      }
      if (CredentialRequestJson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CredentialRequestJson);
      }
      if (CredentialValuesJson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CredentialValuesJson);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CredentialRequest other) {
      if (other == null) {
        return;
      }
      if (other.CredentialOfferJson.Length != 0) {
        CredentialOfferJson = other.CredentialOfferJson;
      }
      if (other.CredentialRequestJson.Length != 0) {
        CredentialRequestJson = other.CredentialRequestJson;
      }
      if (other.CredentialValuesJson.Length != 0) {
        CredentialValuesJson = other.CredentialValuesJson;
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
            CredentialOfferJson = input.ReadString();
            break;
          }
          case 18: {
            CredentialRequestJson = input.ReadString();
            break;
          }
          case 26: {
            CredentialValuesJson = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CredentialResponse : pb::IMessage<CredentialResponse> {
    private static readonly pb::MessageParser<CredentialResponse> _parser = new pb::MessageParser<CredentialResponse>(() => new CredentialResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CredentialResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.CredentialReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialResponse(CredentialResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialResponse Clone() {
      return new CredentialResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CredentialResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CredentialResponse other) {
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
    public void MergeFrom(CredentialResponse other) {
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

  public sealed partial class CredentialIssuanceRequest : pb::IMessage<CredentialIssuanceRequest> {
    private static readonly pb::MessageParser<CredentialIssuanceRequest> _parser = new pb::MessageParser<CredentialIssuanceRequest>(() => new CredentialIssuanceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CredentialIssuanceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.CredentialReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialIssuanceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialIssuanceRequest(CredentialIssuanceRequest other) : this() {
      credentialOfferJson_ = other.credentialOfferJson_;
      credentialRequestJson_ = other.credentialRequestJson_;
      credentialValuesJson_ = other.credentialValuesJson_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialIssuanceRequest Clone() {
      return new CredentialIssuanceRequest(this);
    }

    /// <summary>Field number for the "credential_offer_json" field.</summary>
    public const int CredentialOfferJsonFieldNumber = 1;
    private string credentialOfferJson_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CredentialOfferJson {
      get { return credentialOfferJson_; }
      set {
        credentialOfferJson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "credential_request_json" field.</summary>
    public const int CredentialRequestJsonFieldNumber = 2;
    private string credentialRequestJson_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CredentialRequestJson {
      get { return credentialRequestJson_; }
      set {
        credentialRequestJson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "credential_values_json" field.</summary>
    public const int CredentialValuesJsonFieldNumber = 3;
    private string credentialValuesJson_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CredentialValuesJson {
      get { return credentialValuesJson_; }
      set {
        credentialValuesJson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CredentialIssuanceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CredentialIssuanceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CredentialOfferJson != other.CredentialOfferJson) return false;
      if (CredentialRequestJson != other.CredentialRequestJson) return false;
      if (CredentialValuesJson != other.CredentialValuesJson) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CredentialOfferJson.Length != 0) hash ^= CredentialOfferJson.GetHashCode();
      if (CredentialRequestJson.Length != 0) hash ^= CredentialRequestJson.GetHashCode();
      if (CredentialValuesJson.Length != 0) hash ^= CredentialValuesJson.GetHashCode();
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
      if (CredentialOfferJson.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CredentialOfferJson);
      }
      if (CredentialRequestJson.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CredentialRequestJson);
      }
      if (CredentialValuesJson.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CredentialValuesJson);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CredentialOfferJson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CredentialOfferJson);
      }
      if (CredentialRequestJson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CredentialRequestJson);
      }
      if (CredentialValuesJson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CredentialValuesJson);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CredentialIssuanceRequest other) {
      if (other == null) {
        return;
      }
      if (other.CredentialOfferJson.Length != 0) {
        CredentialOfferJson = other.CredentialOfferJson;
      }
      if (other.CredentialRequestJson.Length != 0) {
        CredentialRequestJson = other.CredentialRequestJson;
      }
      if (other.CredentialValuesJson.Length != 0) {
        CredentialValuesJson = other.CredentialValuesJson;
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
            CredentialOfferJson = input.ReadString();
            break;
          }
          case 18: {
            CredentialRequestJson = input.ReadString();
            break;
          }
          case 26: {
            CredentialValuesJson = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CredentialIssuanceResponse : pb::IMessage<CredentialIssuanceResponse> {
    private static readonly pb::MessageParser<CredentialIssuanceResponse> _parser = new pb::MessageParser<CredentialIssuanceResponse>(() => new CredentialIssuanceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CredentialIssuanceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.CredentialReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialIssuanceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialIssuanceResponse(CredentialIssuanceResponse other) : this() {
      credentialJson_ = other.credentialJson_;
      revocationId_ = other.revocationId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialIssuanceResponse Clone() {
      return new CredentialIssuanceResponse(this);
    }

    /// <summary>Field number for the "credential_json" field.</summary>
    public const int CredentialJsonFieldNumber = 1;
    private string credentialJson_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CredentialJson {
      get { return credentialJson_; }
      set {
        credentialJson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "revocation_id" field.</summary>
    public const int RevocationIdFieldNumber = 2;
    private string revocationId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RevocationId {
      get { return revocationId_; }
      set {
        revocationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CredentialIssuanceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CredentialIssuanceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CredentialJson != other.CredentialJson) return false;
      if (RevocationId != other.RevocationId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CredentialJson.Length != 0) hash ^= CredentialJson.GetHashCode();
      if (RevocationId.Length != 0) hash ^= RevocationId.GetHashCode();
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
      if (CredentialJson.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CredentialJson);
      }
      if (RevocationId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RevocationId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CredentialJson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CredentialJson);
      }
      if (RevocationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RevocationId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CredentialIssuanceResponse other) {
      if (other == null) {
        return;
      }
      if (other.CredentialJson.Length != 0) {
        CredentialJson = other.CredentialJson;
      }
      if (other.RevocationId.Length != 0) {
        RevocationId = other.RevocationId;
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
            CredentialJson = input.ReadString();
            break;
          }
          case 18: {
            RevocationId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
