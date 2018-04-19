// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: authentication.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from authentication.proto</summary>
public static partial class AuthenticationReflection {

  #region Descriptor
  /// <summary>File descriptor for authentication.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AuthenticationReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChRhdXRoZW50aWNhdGlvbi5wcm90byIgCh5BdXRoZW50aWNhdGlvbkNoYWxs",
          "ZW5nZVJlcXVlc3QinAEKH0F1dGhlbnRpY2F0aW9uQ2hhbGxlbmdlUmVzcG9u",
          "c2USPQoJY2hhbGxlbmdlGAEgASgLMiouQXV0aGVudGljYXRpb25DaGFsbGVu",
          "Z2VSZXNwb25zZS5DaGFsbGVuZ2USEQoJc2lnbmF0dXJlGAMgASgMGicKCUNo",
          "YWxsZW5nZRILCgNkaWQYASABKAkSDQoFbm9uY2UYAiABKAkiNQoVQXV0aGVu",
          "dGljYXRpb25SZXF1ZXN0Eg0KBW5vbmNlGAEgASgJEg0KBXRva2VuGAIgASgJ",
          "IhgKFkF1dGhlbnRpY2F0aW9uUmVzcG9uc2ViBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AuthenticationChallengeRequest), global::AuthenticationChallengeRequest.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AuthenticationChallengeResponse), global::AuthenticationChallengeResponse.Parser, new[]{ "Challenge", "Signature" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::AuthenticationChallengeResponse.Types.Challenge), global::AuthenticationChallengeResponse.Types.Challenge.Parser, new[]{ "Did", "Nonce" }, null, null, null)}),
          new pbr::GeneratedClrTypeInfo(typeof(global::AuthenticationRequest), global::AuthenticationRequest.Parser, new[]{ "Nonce", "Token" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AuthenticationResponse), global::AuthenticationResponse.Parser, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AuthenticationChallengeRequest : pb::IMessage<AuthenticationChallengeRequest> {
  private static readonly pb::MessageParser<AuthenticationChallengeRequest> _parser = new pb::MessageParser<AuthenticationChallengeRequest>(() => new AuthenticationChallengeRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AuthenticationChallengeRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AuthenticationReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationChallengeRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationChallengeRequest(AuthenticationChallengeRequest other) : this() {
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationChallengeRequest Clone() {
    return new AuthenticationChallengeRequest(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AuthenticationChallengeRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AuthenticationChallengeRequest other) {
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
  public void MergeFrom(AuthenticationChallengeRequest other) {
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

public sealed partial class AuthenticationChallengeResponse : pb::IMessage<AuthenticationChallengeResponse> {
  private static readonly pb::MessageParser<AuthenticationChallengeResponse> _parser = new pb::MessageParser<AuthenticationChallengeResponse>(() => new AuthenticationChallengeResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AuthenticationChallengeResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AuthenticationReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationChallengeResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationChallengeResponse(AuthenticationChallengeResponse other) : this() {
    Challenge = other.challenge_ != null ? other.Challenge.Clone() : null;
    signature_ = other.signature_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationChallengeResponse Clone() {
    return new AuthenticationChallengeResponse(this);
  }

  /// <summary>Field number for the "challenge" field.</summary>
  public const int ChallengeFieldNumber = 1;
  private global::AuthenticationChallengeResponse.Types.Challenge challenge_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::AuthenticationChallengeResponse.Types.Challenge Challenge {
    get { return challenge_; }
    set {
      challenge_ = value;
    }
  }

  /// <summary>Field number for the "signature" field.</summary>
  public const int SignatureFieldNumber = 3;
  private pb::ByteString signature_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Signature {
    get { return signature_; }
    set {
      signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AuthenticationChallengeResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AuthenticationChallengeResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Challenge, other.Challenge)) return false;
    if (Signature != other.Signature) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (challenge_ != null) hash ^= Challenge.GetHashCode();
    if (Signature.Length != 0) hash ^= Signature.GetHashCode();
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
    if (challenge_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Challenge);
    }
    if (Signature.Length != 0) {
      output.WriteRawTag(26);
      output.WriteBytes(Signature);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (challenge_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Challenge);
    }
    if (Signature.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(AuthenticationChallengeResponse other) {
    if (other == null) {
      return;
    }
    if (other.challenge_ != null) {
      if (challenge_ == null) {
        challenge_ = new global::AuthenticationChallengeResponse.Types.Challenge();
      }
      Challenge.MergeFrom(other.Challenge);
    }
    if (other.Signature.Length != 0) {
      Signature = other.Signature;
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
          if (challenge_ == null) {
            challenge_ = new global::AuthenticationChallengeResponse.Types.Challenge();
          }
          input.ReadMessage(challenge_);
          break;
        }
        case 26: {
          Signature = input.ReadBytes();
          break;
        }
      }
    }
  }

  #region Nested types
  /// <summary>Container for nested types declared in the AuthenticationChallengeResponse message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static partial class Types {
    public sealed partial class Challenge : pb::IMessage<Challenge> {
      private static readonly pb::MessageParser<Challenge> _parser = new pb::MessageParser<Challenge>(() => new Challenge());
      private pb::UnknownFieldSet _unknownFields;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public static pb::MessageParser<Challenge> Parser { get { return _parser; } }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public static pbr::MessageDescriptor Descriptor {
        get { return global::AuthenticationChallengeResponse.Descriptor.NestedTypes[0]; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      pbr::MessageDescriptor pb::IMessage.Descriptor {
        get { return Descriptor; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public Challenge() {
        OnConstruction();
      }

      partial void OnConstruction();

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public Challenge(Challenge other) : this() {
        did_ = other.did_;
        nonce_ = other.nonce_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public Challenge Clone() {
        return new Challenge(this);
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
        return Equals(other as Challenge);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public bool Equals(Challenge other) {
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
      public void MergeFrom(Challenge other) {
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

  }
  #endregion

}

public sealed partial class AuthenticationRequest : pb::IMessage<AuthenticationRequest> {
  private static readonly pb::MessageParser<AuthenticationRequest> _parser = new pb::MessageParser<AuthenticationRequest>(() => new AuthenticationRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AuthenticationRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AuthenticationReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationRequest(AuthenticationRequest other) : this() {
    nonce_ = other.nonce_;
    token_ = other.token_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationRequest Clone() {
    return new AuthenticationRequest(this);
  }

  /// <summary>Field number for the "nonce" field.</summary>
  public const int NonceFieldNumber = 1;
  private string nonce_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Nonce {
    get { return nonce_; }
    set {
      nonce_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "token" field.</summary>
  public const int TokenFieldNumber = 2;
  private string token_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Token {
    get { return token_; }
    set {
      token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AuthenticationRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AuthenticationRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Nonce != other.Nonce) return false;
    if (Token != other.Token) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Nonce.Length != 0) hash ^= Nonce.GetHashCode();
    if (Token.Length != 0) hash ^= Token.GetHashCode();
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
    if (Nonce.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Nonce);
    }
    if (Token.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Token);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Nonce.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Nonce);
    }
    if (Token.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(AuthenticationRequest other) {
    if (other == null) {
      return;
    }
    if (other.Nonce.Length != 0) {
      Nonce = other.Nonce;
    }
    if (other.Token.Length != 0) {
      Token = other.Token;
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
          Nonce = input.ReadString();
          break;
        }
        case 18: {
          Token = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class AuthenticationResponse : pb::IMessage<AuthenticationResponse> {
  private static readonly pb::MessageParser<AuthenticationResponse> _parser = new pb::MessageParser<AuthenticationResponse>(() => new AuthenticationResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AuthenticationResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AuthenticationReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationResponse(AuthenticationResponse other) : this() {
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthenticationResponse Clone() {
    return new AuthenticationResponse(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AuthenticationResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AuthenticationResponse other) {
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
  public void MergeFrom(AuthenticationResponse other) {
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

#endregion


#endregion Designer generated code
