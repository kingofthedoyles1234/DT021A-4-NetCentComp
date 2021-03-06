// <auto-generated>
//     Generated by the protocol buffer compiler.
//     source: Square/protos/square.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Example.Grpc {

  /// <summary>Holder for reflection information generated from Square/protos/square.proto</summary>
  public static partial class SquareReflection {

    #region Descriptor
    /// <summary>File descriptor for Square/protos/square.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SquareReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpTcXVhcmUvcHJvdG9zL3NxdWFyZS5wcm90bxIQY29tLmV4YW1wbGUuZ3Jw",
            "YyIlCg1TcXVhcmVSZXF1ZXN0EhQKDHJlcXVlc3RWYWx1ZRgBIAEoASInCg5T",
            "cXVhcmVSZXNwb25zZRIVCg1yZXNwb25zZVZhbHVlGAEgASgBMl8KDVNxdWFy",
            "ZVNlcnZpY2USTgoJZ2V0U3F1YXJlEh8uY29tLmV4YW1wbGUuZ3JwYy5TcXVh",
            "cmVSZXF1ZXN0GiAuY29tLmV4YW1wbGUuZ3JwYy5TcXVhcmVSZXNwb25zZUIu",
            "Chdpby5ncnBjLmV4YW1wbGVzLnNxdWFyZUILU3F1YXJlUHJvdG9QAaICA1NR",
            "UGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Grpc.SquareRequest), global::Com.Example.Grpc.SquareRequest.Parser, new[]{ "RequestValue" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Grpc.SquareResponse), global::Com.Example.Grpc.SquareResponse.Parser, new[]{ "ResponseValue" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SquareRequest : pb::IMessage<SquareRequest> {
    private static readonly pb::MessageParser<SquareRequest> _parser = new pb::MessageParser<SquareRequest>(() => new SquareRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SquareRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Grpc.SquareReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquareRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquareRequest(SquareRequest other) : this() {
      requestValue_ = other.requestValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquareRequest Clone() {
      return new SquareRequest(this);
    }

    /// <summary>Field number for the "requestValue" field.</summary>
    public const int RequestValueFieldNumber = 1;
    private double requestValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double RequestValue {
      get { return requestValue_; }
      set {
        requestValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SquareRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SquareRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(RequestValue, other.RequestValue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RequestValue != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(RequestValue);
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
      if (RequestValue != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(RequestValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RequestValue != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SquareRequest other) {
      if (other == null) {
        return;
      }
      if (other.RequestValue != 0D) {
        RequestValue = other.RequestValue;
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
          case 9: {
            RequestValue = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SquareResponse : pb::IMessage<SquareResponse> {
    private static readonly pb::MessageParser<SquareResponse> _parser = new pb::MessageParser<SquareResponse>(() => new SquareResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SquareResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Grpc.SquareReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquareResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquareResponse(SquareResponse other) : this() {
      responseValue_ = other.responseValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquareResponse Clone() {
      return new SquareResponse(this);
    }

    /// <summary>Field number for the "responseValue" field.</summary>
    public const int ResponseValueFieldNumber = 1;
    private double responseValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ResponseValue {
      get { return responseValue_; }
      set {
        responseValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SquareResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SquareResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ResponseValue, other.ResponseValue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResponseValue != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ResponseValue);
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
      if (ResponseValue != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(ResponseValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResponseValue != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SquareResponse other) {
      if (other == null) {
        return;
      }
      if (other.ResponseValue != 0D) {
        ResponseValue = other.ResponseValue;
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
          case 9: {
            ResponseValue = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
