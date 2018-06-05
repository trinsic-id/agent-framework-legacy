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
namespace Indy.Agent.Messages {

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
            "Cg5tZXNzYWdlcy5wcm90bxoZZ29vZ2xlL3Byb3RvYnVmL2FueS5wcm90byJc",
            "Cg1TaWduZWRNZXNzYWdlEiUKB2NvbnRlbnQYASABKAsyFC5nb29nbGUucHJv",
            "dG9idWYuQW55EhEKCXNpZ25hdHVyZRgCIAEoDBIRCglzaWduZXJEaWQYAyAB",
            "KAkiOAoPVW5zaWduZWRNZXNzYWdlEiUKB2NvbnRlbnQYASABKAsyFC5nb29n",
            "bGUucHJvdG9idWYuQW55KlwKBlN0YXR1cxIGCgJPSxAAEgkKBUVSUk9SEAES",
            "FQoRSU5WQUxJRF9TSUdOQVRVUkUQAhIVChFNSVNTSU5HX1NJR05BVFVSRRAD",
            "EhEKDVVOS05PV05fRVJST1IQBEIWqgITSW5keS5BZ2VudC5NZXNzYWdlc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Indy.Agent.Messages.Status), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.SignedMessage), global::Indy.Agent.Messages.SignedMessage.Parser, new[]{ "Content", "Signature", "SignerDid" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Indy.Agent.Messages.UnsignedMessage), global::Indy.Agent.Messages.UnsignedMessage.Parser, new[]{ "Content" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Status {
    [pbr::OriginalName("OK")] Ok = 0,
    [pbr::OriginalName("ERROR")] Error = 1,
    [pbr::OriginalName("INVALID_SIGNATURE")] InvalidSignature = 2,
    [pbr::OriginalName("MISSING_SIGNATURE")] MissingSignature = 3,
    [pbr::OriginalName("UNKNOWN_ERROR")] UnknownError = 4,
  }

  #endregion

  #region Messages
  public sealed partial class SignedMessage : pb::IMessage<SignedMessage> {
    private static readonly pb::MessageParser<SignedMessage> _parser = new pb::MessageParser<SignedMessage>(() => new SignedMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SignedMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.MessagesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SignedMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SignedMessage(SignedMessage other) : this() {
      Content = other.content_ != null ? other.Content.Clone() : null;
      signature_ = other.signature_;
      signerDid_ = other.signerDid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SignedMessage Clone() {
      return new SignedMessage(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Any content_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any Content {
      get { return content_; }
      set {
        content_ = value;
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 2;
    private pb::ByteString signature_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "signerDid" field.</summary>
    public const int SignerDidFieldNumber = 3;
    private string signerDid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SignerDid {
      get { return signerDid_; }
      set {
        signerDid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SignedMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SignedMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Content, other.Content)) return false;
      if (Signature != other.Signature) return false;
      if (SignerDid != other.SignerDid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (content_ != null) hash ^= Content.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (SignerDid.Length != 0) hash ^= SignerDid.GetHashCode();
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
      if (content_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Content);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Signature);
      }
      if (SignerDid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SignerDid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (content_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Content);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature);
      }
      if (SignerDid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SignerDid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SignedMessage other) {
      if (other == null) {
        return;
      }
      if (other.content_ != null) {
        if (content_ == null) {
          content_ = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Content.MergeFrom(other.Content);
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.SignerDid.Length != 0) {
        SignerDid = other.SignerDid;
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
            if (content_ == null) {
              content_ = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(content_);
            break;
          }
          case 18: {
            Signature = input.ReadBytes();
            break;
          }
          case 26: {
            SignerDid = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class UnsignedMessage : pb::IMessage<UnsignedMessage> {
    private static readonly pb::MessageParser<UnsignedMessage> _parser = new pb::MessageParser<UnsignedMessage>(() => new UnsignedMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnsignedMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Indy.Agent.Messages.MessagesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnsignedMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnsignedMessage(UnsignedMessage other) : this() {
      Content = other.content_ != null ? other.Content.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnsignedMessage Clone() {
      return new UnsignedMessage(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Any content_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any Content {
      get { return content_; }
      set {
        content_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnsignedMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnsignedMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Content, other.Content)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (content_ != null) hash ^= Content.GetHashCode();
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
      if (content_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Content);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (content_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Content);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnsignedMessage other) {
      if (other == null) {
        return;
      }
      if (other.content_ != null) {
        if (content_ == null) {
          content_ = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Content.MergeFrom(other.Content);
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
            if (content_ == null) {
              content_ = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(content_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
