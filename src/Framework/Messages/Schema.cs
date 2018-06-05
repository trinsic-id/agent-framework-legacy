// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: schema.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Indy.Agent.Messages {

  /// <summary>Holder for reflection information generated from schema.proto</summary>
  public static partial class SchemaReflection {

    #region Descriptor
    /// <summary>File descriptor for schema.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SchemaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxzY2hlbWEucHJvdG8iTQoTU2NoZW1hQ3JlYXRlUmVxdWVzdBIMCgRuYW1l",
            "GAEgASgJEg8KB3ZlcnNpb24YAiABKAkSFwoPYXR0cmlidXRlX25hbWVzGAMg",
            "AygJIikKFFNjaGVtYUNyZWF0ZVJlc3BvbnNlEhEKCXNjaGVtYV9pZBgBIAEo",
            "CSI2CiFDcmVkZW50aWFsRGVmaW5pdGlvbkNyZWF0ZVJlcXVlc3QSEQoJc2No",
            "ZW1hX2lkGAEgASgJIkYKIkNyZWRlbnRpYWxEZWZpbml0aW9uQ3JlYXRlUmVz",
            "cG9uc2USIAoYY3JlZGVudGlhbF9kZWZpbml0aW9uX2lkGAEgASgJQhaqAhNJ",
            "bmR5LkFnZW50Lk1lc3NhZ2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.SchemaCreateRequest), global::Indy.Agent.Messages.SchemaCreateRequest.Parser, new[]{ "Name", "Version", "AttributeNames" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.SchemaCreateResponse), global::Indy.Agent.Messages.SchemaCreateResponse.Parser, new[]{ "SchemaId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.CredentialDefinitionCreateRequest), global::Indy.Agent.Messages.CredentialDefinitionCreateRequest.Parser, new[]{ "SchemaId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.CredentialDefinitionCreateResponse), global::Indy.Agent.Messages.CredentialDefinitionCreateResponse.Parser, new[]{ "CredentialDefinitionId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SchemaCreateRequest : pb::IMessage<SchemaCreateRequest> {
    private static readonly pb::MessageParser<SchemaCreateRequest> _parser = new pb::MessageParser<SchemaCreateRequest>(() => new SchemaCreateRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SchemaCreateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.SchemaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SchemaCreateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SchemaCreateRequest(SchemaCreateRequest other) : this() {
      name_ = other.name_;
      version_ = other.version_;
      attributeNames_ = other.attributeNames_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SchemaCreateRequest Clone() {
      return new SchemaCreateRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 2;
    private string version_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attribute_names" field.</summary>
    public const int AttributeNamesFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_attributeNames_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> attributeNames_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> AttributeNames {
      get { return attributeNames_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SchemaCreateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SchemaCreateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Version != other.Version) return false;
      if(!attributeNames_.Equals(other.attributeNames_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      hash ^= attributeNames_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Version.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Version);
      }
      attributeNames_.WriteTo(output, _repeated_attributeNames_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      size += attributeNames_.CalculateSize(_repeated_attributeNames_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SchemaCreateRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      attributeNames_.Add(other.attributeNames_);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Version = input.ReadString();
            break;
          }
          case 26: {
            attributeNames_.AddEntriesFrom(input, _repeated_attributeNames_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SchemaCreateResponse : pb::IMessage<SchemaCreateResponse> {
    private static readonly pb::MessageParser<SchemaCreateResponse> _parser = new pb::MessageParser<SchemaCreateResponse>(() => new SchemaCreateResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SchemaCreateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.SchemaReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SchemaCreateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SchemaCreateResponse(SchemaCreateResponse other) : this() {
      schemaId_ = other.schemaId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SchemaCreateResponse Clone() {
      return new SchemaCreateResponse(this);
    }

    /// <summary>Field number for the "schema_id" field.</summary>
    public const int SchemaIdFieldNumber = 1;
    private string schemaId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SchemaId {
      get { return schemaId_; }
      set {
        schemaId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SchemaCreateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SchemaCreateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SchemaId != other.SchemaId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SchemaId.Length != 0) hash ^= SchemaId.GetHashCode();
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
      if (SchemaId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SchemaId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SchemaId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SchemaId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SchemaCreateResponse other) {
      if (other == null) {
        return;
      }
      if (other.SchemaId.Length != 0) {
        SchemaId = other.SchemaId;
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
            SchemaId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CredentialDefinitionCreateRequest : pb::IMessage<CredentialDefinitionCreateRequest> {
    private static readonly pb::MessageParser<CredentialDefinitionCreateRequest> _parser = new pb::MessageParser<CredentialDefinitionCreateRequest>(() => new CredentialDefinitionCreateRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CredentialDefinitionCreateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.SchemaReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialDefinitionCreateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialDefinitionCreateRequest(CredentialDefinitionCreateRequest other) : this() {
      schemaId_ = other.schemaId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialDefinitionCreateRequest Clone() {
      return new CredentialDefinitionCreateRequest(this);
    }

    /// <summary>Field number for the "schema_id" field.</summary>
    public const int SchemaIdFieldNumber = 1;
    private string schemaId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SchemaId {
      get { return schemaId_; }
      set {
        schemaId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CredentialDefinitionCreateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CredentialDefinitionCreateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SchemaId != other.SchemaId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SchemaId.Length != 0) hash ^= SchemaId.GetHashCode();
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
      if (SchemaId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SchemaId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SchemaId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SchemaId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CredentialDefinitionCreateRequest other) {
      if (other == null) {
        return;
      }
      if (other.SchemaId.Length != 0) {
        SchemaId = other.SchemaId;
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
            SchemaId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CredentialDefinitionCreateResponse : pb::IMessage<CredentialDefinitionCreateResponse> {
    private static readonly pb::MessageParser<CredentialDefinitionCreateResponse> _parser = new pb::MessageParser<CredentialDefinitionCreateResponse>(() => new CredentialDefinitionCreateResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CredentialDefinitionCreateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.SchemaReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialDefinitionCreateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialDefinitionCreateResponse(CredentialDefinitionCreateResponse other) : this() {
      credentialDefinitionId_ = other.credentialDefinitionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialDefinitionCreateResponse Clone() {
      return new CredentialDefinitionCreateResponse(this);
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
      return Equals(other as CredentialDefinitionCreateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CredentialDefinitionCreateResponse other) {
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
    public void MergeFrom(CredentialDefinitionCreateResponse other) {
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

  #endregion

}

#endregion Designer generated code