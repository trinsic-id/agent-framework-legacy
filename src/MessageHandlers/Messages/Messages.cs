// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: messages.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from messages.proto</summary>
public static partial class MessagesReflection {

  #region Descriptor
  /// <summary>File descriptor for messages.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MessagesReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg5tZXNzYWdlcy5wcm90byJNCgNNc2cSIgoMbWVzc2FnZV90eXBlGAEgASgO",
          "MgwuTWVzc2FnZVR5cGUSDwoHY29udGVudBgCIAEoDBIRCgl0YXJnZXREaWQY",
          "AyABKAkijAEKD0FnZW50Q3JlZGVudGlhbBINCgV0b2tlbhgBIAEoCRItCgR0",
          "eXBlGAIgASgOMh8uQWdlbnRDcmVkZW50aWFsLkNyZWRlbnRpYWxUeXBlIjsK",
          "DkNyZWRlbnRpYWxUeXBlEhAKDEJFQVJFUl9UT0tFThAAEhcKE1ZFUklGSUNB",
          "VElPTl9SRVNVTFQQASInChNFbmRwb2ludFNlbmRSZXF1ZXN0EhAKCGVuZHBv",
          "aW50GAEgASgJIjQKFUFnZW50TnltQ3JlYXRlUmVxdWVzdBILCgNkaWQYASAB",
          "KAkSDgoGdmVya2V5GAIgASgJIjEKFkFnZW50TnltQ3JlYXRlUmVzcG9uc2US",
          "FwoGc3RhdHVzGAEgASgOMgcuU3RhdHVzIiMKCFJlc3BvbnNlEhcKBnN0YXR1",
          "cxgBIAEoDjIHLlN0YXR1cyr8BQoLTWVzc2FnZVR5cGUSCwoHREVGQVVMVBAA",
          "EhQKEEFHRU5UX0NSRURFTlRJQUwQARIcChhDT05ORUNUSU9OX09GRkVSX1JF",
          "UVVFU1QQZBIdChlDT05ORUNUSU9OX09GRkVSX1JFU1BPTlNFEGUSHQoZQ09O",
          "TkVDVElPTl9DUkVBVEVfUkVRVUVTVBBmEh4KGkNPTk5FQ1RJT05fQ1JFQVRF",
          "X1JFU1BPTlNFEGcSJQogQVVUSEVOVElDQVRJT05fQ0hBTExFTkdFX1JFUVVF",
          "U1QQyAESJgohQVVUSEVOVElDQVRJT05fQ0hBTExFTkdFX1JFU1BPTlNFEMkB",
          "EhsKFkFVVEhFTlRJQ0FUSU9OX1JFUVVFU1QQygESHAoXQVVUSEVOVElDQVRJ",
          "T05fUkVTUE9OU0UQywESGgoVU0NIRU1BX0NSRUFURV9SRVFVRVNUEKwCEhsK",
          "FlNDSEVNQV9DUkVBVEVfUkVTUE9OU0UQrQISKQokQ1JFREVOVElBTF9ERUZJ",
          "TklUSU9OX0NSRUFURV9SRVFVRVNUEN4CEioKJUNSRURFTlRJQUxfREVGSU5J",
          "VElPTl9DUkVBVEVfUkVTUE9OU0UQ3wISGQoVRU5EUE9JTlRfU0VORF9SRVFV",
          "RVNUEAkSHQoYQ1JFREVOVElBTF9PRkZFUl9SRVFVRVNUEJADEh4KGUNSRURF",
          "TlRJQUxfT0ZGRVJfUkVTUE9OU0UQkQMSFwoSQ1JFREVOVElBTF9SRVFVRVNU",
          "EJIDEhgKE0NSRURFTlRJQUxfUkVTUE9OU0UQkwMSGQoUUFJPT0ZfQ1JFQVRF",
          "X1JFUVVFU1QQ9AMSGgoVUFJPT0ZfQ1JFQVRFX1JFU1BPTlNFEPUDEhcKElBS",
          "T09GX1NFTkRfUkVRVUVTVBD2AxIYChNQUk9PRl9TRU5EX1JFU1BPTlNFEPcD",
          "Eh0KGEFHRU5UX05ZTV9DUkVBVEVfUkVRVUVTVBDYBBIeChlBR0VOVF9OWU1f",
          "Q1JFQVRFX1JFU1BPTlNFENkEKhsKBlN0YXR1cxIGCgJPSxAAEgkKBUVSUk9S",
          "EAFiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MessageType), typeof(global::Status), }, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Msg), global::Msg.Parser, new[]{ "MessageType", "Content", "TargetDid" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AgentCredential), global::AgentCredential.Parser, new[]{ "Token", "Type" }, null, new[]{ typeof(global::AgentCredential.Types.CredentialType) }, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::EndpointSendRequest), global::EndpointSendRequest.Parser, new[]{ "Endpoint" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AgentNymCreateRequest), global::AgentNymCreateRequest.Parser, new[]{ "Did", "Verkey" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AgentNymCreateResponse), global::AgentNymCreateResponse.Parser, new[]{ "Status" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Response), global::Response.Parser, new[]{ "Status" }, null, null, null)
        }));
  }
  #endregion

}
#region Enums
public enum MessageType {
  [pbr::OriginalName("DEFAULT")] Default = 0,
  [pbr::OriginalName("AGENT_CREDENTIAL")] AgentCredential = 1,
  [pbr::OriginalName("CONNECTION_OFFER_REQUEST")] ConnectionOfferRequest = 100,
  [pbr::OriginalName("CONNECTION_OFFER_RESPONSE")] ConnectionOfferResponse = 101,
  [pbr::OriginalName("CONNECTION_CREATE_REQUEST")] ConnectionCreateRequest = 102,
  [pbr::OriginalName("CONNECTION_CREATE_RESPONSE")] ConnectionCreateResponse = 103,
  [pbr::OriginalName("AUTHENTICATION_CHALLENGE_REQUEST")] AuthenticationChallengeRequest = 200,
  [pbr::OriginalName("AUTHENTICATION_CHALLENGE_RESPONSE")] AuthenticationChallengeResponse = 201,
  [pbr::OriginalName("AUTHENTICATION_REQUEST")] AuthenticationRequest = 202,
  [pbr::OriginalName("AUTHENTICATION_RESPONSE")] AuthenticationResponse = 203,
  [pbr::OriginalName("SCHEMA_CREATE_REQUEST")] SchemaCreateRequest = 300,
  [pbr::OriginalName("SCHEMA_CREATE_RESPONSE")] SchemaCreateResponse = 301,
  [pbr::OriginalName("CREDENTIAL_DEFINITION_CREATE_REQUEST")] CredentialDefinitionCreateRequest = 350,
  [pbr::OriginalName("CREDENTIAL_DEFINITION_CREATE_RESPONSE")] CredentialDefinitionCreateResponse = 351,
  [pbr::OriginalName("ENDPOINT_SEND_REQUEST")] EndpointSendRequest = 9,
  [pbr::OriginalName("CREDENTIAL_OFFER_REQUEST")] CredentialOfferRequest = 400,
  [pbr::OriginalName("CREDENTIAL_OFFER_RESPONSE")] CredentialOfferResponse = 401,
  [pbr::OriginalName("CREDENTIAL_REQUEST")] CredentialRequest = 402,
  [pbr::OriginalName("CREDENTIAL_RESPONSE")] CredentialResponse = 403,
  [pbr::OriginalName("PROOF_CREATE_REQUEST")] ProofCreateRequest = 500,
  [pbr::OriginalName("PROOF_CREATE_RESPONSE")] ProofCreateResponse = 501,
  [pbr::OriginalName("PROOF_SEND_REQUEST")] ProofSendRequest = 502,
  [pbr::OriginalName("PROOF_SEND_RESPONSE")] ProofSendResponse = 503,
  [pbr::OriginalName("AGENT_NYM_CREATE_REQUEST")] AgentNymCreateRequest = 600,
  [pbr::OriginalName("AGENT_NYM_CREATE_RESPONSE")] AgentNymCreateResponse = 601,
}

public enum Status {
  [pbr::OriginalName("OK")] Ok = 0,
  [pbr::OriginalName("ERROR")] Error = 1,
}

#endregion

#region Messages
public sealed partial class Msg : pb::IMessage<Msg> {
  private static readonly pb::MessageParser<Msg> _parser = new pb::MessageParser<Msg>(() => new Msg());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Msg> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessagesReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Msg() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Msg(Msg other) : this() {
    messageType_ = other.messageType_;
    content_ = other.content_;
    targetDid_ = other.targetDid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Msg Clone() {
    return new Msg(this);
  }

  /// <summary>Field number for the "message_type" field.</summary>
  public const int MessageTypeFieldNumber = 1;
  private global::MessageType messageType_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::MessageType MessageType {
    get { return messageType_; }
    set {
      messageType_ = value;
    }
  }

  /// <summary>Field number for the "content" field.</summary>
  public const int ContentFieldNumber = 2;
  private pb::ByteString content_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Content {
    get { return content_; }
    set {
      content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "targetDid" field.</summary>
  public const int TargetDidFieldNumber = 3;
  private string targetDid_ = "";
  /// <summary>
  /// represents the target did the message is intended for. the message will may be encrypted using this did ver keys
  /// this field is user by cloud agents to route the message to the appropriate agent
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string TargetDid {
    get { return targetDid_; }
    set {
      targetDid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Msg);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Msg other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MessageType != other.MessageType) return false;
    if (Content != other.Content) return false;
    if (TargetDid != other.TargetDid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (MessageType != 0) hash ^= MessageType.GetHashCode();
    if (Content.Length != 0) hash ^= Content.GetHashCode();
    if (TargetDid.Length != 0) hash ^= TargetDid.GetHashCode();
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
    if (MessageType != 0) {
      output.WriteRawTag(8);
      output.WriteEnum((int) MessageType);
    }
    if (Content.Length != 0) {
      output.WriteRawTag(18);
      output.WriteBytes(Content);
    }
    if (TargetDid.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(TargetDid);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (MessageType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MessageType);
    }
    if (Content.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Content);
    }
    if (TargetDid.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetDid);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Msg other) {
    if (other == null) {
      return;
    }
    if (other.MessageType != 0) {
      MessageType = other.MessageType;
    }
    if (other.Content.Length != 0) {
      Content = other.Content;
    }
    if (other.TargetDid.Length != 0) {
      TargetDid = other.TargetDid;
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
          messageType_ = (global::MessageType) input.ReadEnum();
          break;
        }
        case 18: {
          Content = input.ReadBytes();
          break;
        }
        case 26: {
          TargetDid = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class AgentCredential : pb::IMessage<AgentCredential> {
  private static readonly pb::MessageParser<AgentCredential> _parser = new pb::MessageParser<AgentCredential>(() => new AgentCredential());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AgentCredential> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessagesReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentCredential() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentCredential(AgentCredential other) : this() {
    token_ = other.token_;
    type_ = other.type_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentCredential Clone() {
    return new AgentCredential(this);
  }

  /// <summary>Field number for the "token" field.</summary>
  public const int TokenFieldNumber = 1;
  private string token_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Token {
    get { return token_; }
    set {
      token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 2;
  private global::AgentCredential.Types.CredentialType type_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::AgentCredential.Types.CredentialType Type {
    get { return type_; }
    set {
      type_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AgentCredential);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AgentCredential other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Token != other.Token) return false;
    if (Type != other.Type) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Token.Length != 0) hash ^= Token.GetHashCode();
    if (Type != 0) hash ^= Type.GetHashCode();
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
    if (Token.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Token);
    }
    if (Type != 0) {
      output.WriteRawTag(16);
      output.WriteEnum((int) Type);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Token.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
    }
    if (Type != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(AgentCredential other) {
    if (other == null) {
      return;
    }
    if (other.Token.Length != 0) {
      Token = other.Token;
    }
    if (other.Type != 0) {
      Type = other.Type;
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
          Token = input.ReadString();
          break;
        }
        case 16: {
          type_ = (global::AgentCredential.Types.CredentialType) input.ReadEnum();
          break;
        }
      }
    }
  }

  #region Nested types
  /// <summary>Container for nested types declared in the AgentCredential message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static partial class Types {
    public enum CredentialType {
      [pbr::OriginalName("BEARER_TOKEN")] BearerToken = 0,
      [pbr::OriginalName("VERIFICATION_RESULT")] VerificationResult = 1,
    }

  }
  #endregion

}

public sealed partial class EndpointSendRequest : pb::IMessage<EndpointSendRequest> {
  private static readonly pb::MessageParser<EndpointSendRequest> _parser = new pb::MessageParser<EndpointSendRequest>(() => new EndpointSendRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<EndpointSendRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessagesReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EndpointSendRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EndpointSendRequest(EndpointSendRequest other) : this() {
    endpoint_ = other.endpoint_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EndpointSendRequest Clone() {
    return new EndpointSendRequest(this);
  }

  /// <summary>Field number for the "endpoint" field.</summary>
  public const int EndpointFieldNumber = 1;
  private string endpoint_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Endpoint {
    get { return endpoint_; }
    set {
      endpoint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as EndpointSendRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(EndpointSendRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Endpoint != other.Endpoint) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Endpoint.Length != 0) hash ^= Endpoint.GetHashCode();
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
    if (Endpoint.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Endpoint);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Endpoint.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Endpoint);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(EndpointSendRequest other) {
    if (other == null) {
      return;
    }
    if (other.Endpoint.Length != 0) {
      Endpoint = other.Endpoint;
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
          Endpoint = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class AgentNymCreateRequest : pb::IMessage<AgentNymCreateRequest> {
  private static readonly pb::MessageParser<AgentNymCreateRequest> _parser = new pb::MessageParser<AgentNymCreateRequest>(() => new AgentNymCreateRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AgentNymCreateRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessagesReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentNymCreateRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentNymCreateRequest(AgentNymCreateRequest other) : this() {
    did_ = other.did_;
    verkey_ = other.verkey_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentNymCreateRequest Clone() {
    return new AgentNymCreateRequest(this);
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

  /// <summary>Field number for the "verkey" field.</summary>
  public const int VerkeyFieldNumber = 2;
  private string verkey_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Verkey {
    get { return verkey_; }
    set {
      verkey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AgentNymCreateRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AgentNymCreateRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Did != other.Did) return false;
    if (Verkey != other.Verkey) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Did.Length != 0) hash ^= Did.GetHashCode();
    if (Verkey.Length != 0) hash ^= Verkey.GetHashCode();
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
    if (Verkey.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Verkey);
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
    if (Verkey.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Verkey);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(AgentNymCreateRequest other) {
    if (other == null) {
      return;
    }
    if (other.Did.Length != 0) {
      Did = other.Did;
    }
    if (other.Verkey.Length != 0) {
      Verkey = other.Verkey;
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
          Verkey = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class AgentNymCreateResponse : pb::IMessage<AgentNymCreateResponse> {
  private static readonly pb::MessageParser<AgentNymCreateResponse> _parser = new pb::MessageParser<AgentNymCreateResponse>(() => new AgentNymCreateResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AgentNymCreateResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessagesReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentNymCreateResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentNymCreateResponse(AgentNymCreateResponse other) : this() {
    status_ = other.status_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentNymCreateResponse Clone() {
    return new AgentNymCreateResponse(this);
  }

  /// <summary>Field number for the "status" field.</summary>
  public const int StatusFieldNumber = 1;
  private global::Status status_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Status Status {
    get { return status_; }
    set {
      status_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AgentNymCreateResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AgentNymCreateResponse other) {
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
  public void MergeFrom(AgentNymCreateResponse other) {
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
          status_ = (global::Status) input.ReadEnum();
          break;
        }
      }
    }
  }

}

public sealed partial class Response : pb::IMessage<Response> {
  private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Response> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessagesReflection.Descriptor.MessageTypes[5]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Response() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Response(Response other) : this() {
    status_ = other.status_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Response Clone() {
    return new Response(this);
  }

  /// <summary>Field number for the "status" field.</summary>
  public const int StatusFieldNumber = 1;
  private global::Status status_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Status Status {
    get { return status_; }
    set {
      status_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Response);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Response other) {
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
  public void MergeFrom(Response other) {
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
          status_ = (global::Status) input.ReadEnum();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
