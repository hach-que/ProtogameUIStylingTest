// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GameHost.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protogame.Editor.Grpc.GameHost {

  /// <summary>Holder for reflection information generated from GameHost.proto</summary>
  public static partial class GameHostReflection {

    #region Descriptor
    /// <summary>File descriptor for GameHost.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameHostReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5HYW1lSG9zdC5wcm90byIvChdTZXRNb3VzZVBvc2l0aW9uUmVxdWVzdBIJ",
            "CgF4GAEgASgFEgkKAXkYAiABKAUiGgoYU2V0TW91c2VQb3NpdGlvblJlc3Bv",
            "bnNlIhkKF0dldE1vdXNlUG9zaXRpb25SZXF1ZXN0IjAKGEdldE1vdXNlUG9z",
            "aXRpb25SZXNwb25zZRIJCgF4GAEgASgFEgkKAXkYAiABKAUiNgobUXVldWVT",
            "ZXJpYWxpemVkRXZlbnRSZXF1ZXN0EhcKD3NlcmlhbGl6ZWRFdmVudBgBIAEo",
            "DCIeChxRdWV1ZVNlcmlhbGl6ZWRFdmVudFJlc3BvbnNlIk0KF1NldFJlbmRl",
            "clRhcmdldHNSZXF1ZXN0EhUKDXNoYXJlZFBvaW50ZXIYASADKAMSGwoTc3lu",
            "Y01tYXBwZWRGaWxlTmFtZRgCIAEoCSIaChhTZXRSZW5kZXJUYXJnZXRzUmVz",
            "cG9uc2UiKQoWU2V0UGxheWJhY2tNb2RlUmVxdWVzdBIPCgdwbGF5aW5nGAEg",
            "ASgIIhkKF1NldFBsYXliYWNrTW9kZVJlc3BvbnNlMoYDCg5HYW1lSG9zdFNl",
            "cnZlchJHChBTZXRSZW5kZXJUYXJnZXRzEhguU2V0UmVuZGVyVGFyZ2V0c1Jl",
            "cXVlc3QaGS5TZXRSZW5kZXJUYXJnZXRzUmVzcG9uc2USRwoQU2V0TW91c2VQ",
            "b3NpdGlvbhIYLlNldE1vdXNlUG9zaXRpb25SZXF1ZXN0GhkuU2V0TW91c2VQ",
            "b3NpdGlvblJlc3BvbnNlEkcKEEdldE1vdXNlUG9zaXRpb24SGC5HZXRNb3Vz",
            "ZVBvc2l0aW9uUmVxdWVzdBoZLkdldE1vdXNlUG9zaXRpb25SZXNwb25zZRJT",
            "ChRRdWV1ZVNlcmlhbGl6ZWRFdmVudBIcLlF1ZXVlU2VyaWFsaXplZEV2ZW50",
            "UmVxdWVzdBodLlF1ZXVlU2VyaWFsaXplZEV2ZW50UmVzcG9uc2USRAoPU2V0",
            "UGxheWJhY2tNb2RlEhcuU2V0UGxheWJhY2tNb2RlUmVxdWVzdBoYLlNldFBs",
            "YXliYWNrTW9kZVJlc3BvbnNlQiGqAh5Qcm90b2dhbWUuRWRpdG9yLkdycGMu",
            "R2FtZUhvc3RiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest), global::Protogame.Editor.Grpc.GameHost.SetMousePositionRequest.Parser, new[]{ "X", "Y" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse), global::Protogame.Editor.Grpc.GameHost.SetMousePositionResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest), global::Protogame.Editor.Grpc.GameHost.GetMousePositionRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse), global::Protogame.Editor.Grpc.GameHost.GetMousePositionResponse.Parser, new[]{ "X", "Y" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest), global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventRequest.Parser, new[]{ "SerializedEvent" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse), global::Protogame.Editor.Grpc.GameHost.QueueSerializedEventResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest), global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsRequest.Parser, new[]{ "SharedPointer", "SyncMmappedFileName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse), global::Protogame.Editor.Grpc.GameHost.SetRenderTargetsResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest), global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeRequest.Parser, new[]{ "Playing" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse), global::Protogame.Editor.Grpc.GameHost.SetPlaybackModeResponse.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetMousePositionRequest : pb::IMessage<SetMousePositionRequest> {
    private static readonly pb::MessageParser<SetMousePositionRequest> _parser = new pb::MessageParser<SetMousePositionRequest>(() => new SetMousePositionRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetMousePositionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetMousePositionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetMousePositionRequest(SetMousePositionRequest other) : this() {
      x_ = other.x_;
      y_ = other.y_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetMousePositionRequest Clone() {
      return new SetMousePositionRequest(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private int x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private int y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetMousePositionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetMousePositionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0) hash ^= X.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(X);
      }
      if (Y != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Y);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(X);
      }
      if (Y != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Y);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetMousePositionRequest other) {
      if (other == null) {
        return;
      }
      if (other.X != 0) {
        X = other.X;
      }
      if (other.Y != 0) {
        Y = other.Y;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            X = input.ReadInt32();
            break;
          }
          case 16: {
            Y = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SetMousePositionResponse : pb::IMessage<SetMousePositionResponse> {
    private static readonly pb::MessageParser<SetMousePositionResponse> _parser = new pb::MessageParser<SetMousePositionResponse>(() => new SetMousePositionResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetMousePositionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetMousePositionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetMousePositionResponse(SetMousePositionResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetMousePositionResponse Clone() {
      return new SetMousePositionResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetMousePositionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetMousePositionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetMousePositionResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class GetMousePositionRequest : pb::IMessage<GetMousePositionRequest> {
    private static readonly pb::MessageParser<GetMousePositionRequest> _parser = new pb::MessageParser<GetMousePositionRequest>(() => new GetMousePositionRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMousePositionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMousePositionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMousePositionRequest(GetMousePositionRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMousePositionRequest Clone() {
      return new GetMousePositionRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMousePositionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMousePositionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMousePositionRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class GetMousePositionResponse : pb::IMessage<GetMousePositionResponse> {
    private static readonly pb::MessageParser<GetMousePositionResponse> _parser = new pb::MessageParser<GetMousePositionResponse>(() => new GetMousePositionResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMousePositionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMousePositionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMousePositionResponse(GetMousePositionResponse other) : this() {
      x_ = other.x_;
      y_ = other.y_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMousePositionResponse Clone() {
      return new GetMousePositionResponse(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private int x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private int y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMousePositionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMousePositionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0) hash ^= X.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(X);
      }
      if (Y != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Y);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(X);
      }
      if (Y != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Y);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMousePositionResponse other) {
      if (other == null) {
        return;
      }
      if (other.X != 0) {
        X = other.X;
      }
      if (other.Y != 0) {
        Y = other.Y;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            X = input.ReadInt32();
            break;
          }
          case 16: {
            Y = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class QueueSerializedEventRequest : pb::IMessage<QueueSerializedEventRequest> {
    private static readonly pb::MessageParser<QueueSerializedEventRequest> _parser = new pb::MessageParser<QueueSerializedEventRequest>(() => new QueueSerializedEventRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueueSerializedEventRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueueSerializedEventRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueueSerializedEventRequest(QueueSerializedEventRequest other) : this() {
      serializedEvent_ = other.serializedEvent_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueueSerializedEventRequest Clone() {
      return new QueueSerializedEventRequest(this);
    }

    /// <summary>Field number for the "serializedEvent" field.</summary>
    public const int SerializedEventFieldNumber = 1;
    private pb::ByteString serializedEvent_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString SerializedEvent {
      get { return serializedEvent_; }
      set {
        serializedEvent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueueSerializedEventRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueueSerializedEventRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SerializedEvent != other.SerializedEvent) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SerializedEvent.Length != 0) hash ^= SerializedEvent.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SerializedEvent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(SerializedEvent);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SerializedEvent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(SerializedEvent);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueueSerializedEventRequest other) {
      if (other == null) {
        return;
      }
      if (other.SerializedEvent.Length != 0) {
        SerializedEvent = other.SerializedEvent;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            SerializedEvent = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class QueueSerializedEventResponse : pb::IMessage<QueueSerializedEventResponse> {
    private static readonly pb::MessageParser<QueueSerializedEventResponse> _parser = new pb::MessageParser<QueueSerializedEventResponse>(() => new QueueSerializedEventResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueueSerializedEventResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueueSerializedEventResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueueSerializedEventResponse(QueueSerializedEventResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueueSerializedEventResponse Clone() {
      return new QueueSerializedEventResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueueSerializedEventResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueueSerializedEventResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueueSerializedEventResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class SetRenderTargetsRequest : pb::IMessage<SetRenderTargetsRequest> {
    private static readonly pb::MessageParser<SetRenderTargetsRequest> _parser = new pb::MessageParser<SetRenderTargetsRequest>(() => new SetRenderTargetsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetRenderTargetsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetRenderTargetsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetRenderTargetsRequest(SetRenderTargetsRequest other) : this() {
      sharedPointer_ = other.sharedPointer_.Clone();
      syncMmappedFileName_ = other.syncMmappedFileName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetRenderTargetsRequest Clone() {
      return new SetRenderTargetsRequest(this);
    }

    /// <summary>Field number for the "sharedPointer" field.</summary>
    public const int SharedPointerFieldNumber = 1;
    private static readonly pb::FieldCodec<long> _repeated_sharedPointer_codec
        = pb::FieldCodec.ForInt64(10);
    private readonly pbc::RepeatedField<long> sharedPointer_ = new pbc::RepeatedField<long>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> SharedPointer {
      get { return sharedPointer_; }
    }

    /// <summary>Field number for the "syncMmappedFileName" field.</summary>
    public const int SyncMmappedFileNameFieldNumber = 2;
    private string syncMmappedFileName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SyncMmappedFileName {
      get { return syncMmappedFileName_; }
      set {
        syncMmappedFileName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetRenderTargetsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetRenderTargetsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sharedPointer_.Equals(other.sharedPointer_)) return false;
      if (SyncMmappedFileName != other.SyncMmappedFileName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sharedPointer_.GetHashCode();
      if (SyncMmappedFileName.Length != 0) hash ^= SyncMmappedFileName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      sharedPointer_.WriteTo(output, _repeated_sharedPointer_codec);
      if (SyncMmappedFileName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SyncMmappedFileName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sharedPointer_.CalculateSize(_repeated_sharedPointer_codec);
      if (SyncMmappedFileName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SyncMmappedFileName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetRenderTargetsRequest other) {
      if (other == null) {
        return;
      }
      sharedPointer_.Add(other.sharedPointer_);
      if (other.SyncMmappedFileName.Length != 0) {
        SyncMmappedFileName = other.SyncMmappedFileName;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 8: {
            sharedPointer_.AddEntriesFrom(input, _repeated_sharedPointer_codec);
            break;
          }
          case 18: {
            SyncMmappedFileName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SetRenderTargetsResponse : pb::IMessage<SetRenderTargetsResponse> {
    private static readonly pb::MessageParser<SetRenderTargetsResponse> _parser = new pb::MessageParser<SetRenderTargetsResponse>(() => new SetRenderTargetsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetRenderTargetsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.MessageTypes[7]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetRenderTargetsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetRenderTargetsResponse(SetRenderTargetsResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetRenderTargetsResponse Clone() {
      return new SetRenderTargetsResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetRenderTargetsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetRenderTargetsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetRenderTargetsResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class SetPlaybackModeRequest : pb::IMessage<SetPlaybackModeRequest> {
    private static readonly pb::MessageParser<SetPlaybackModeRequest> _parser = new pb::MessageParser<SetPlaybackModeRequest>(() => new SetPlaybackModeRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetPlaybackModeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.MessageTypes[8]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlaybackModeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlaybackModeRequest(SetPlaybackModeRequest other) : this() {
      playing_ = other.playing_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlaybackModeRequest Clone() {
      return new SetPlaybackModeRequest(this);
    }

    /// <summary>Field number for the "playing" field.</summary>
    public const int PlayingFieldNumber = 1;
    private bool playing_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Playing {
      get { return playing_; }
      set {
        playing_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetPlaybackModeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetPlaybackModeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Playing != other.Playing) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Playing != false) hash ^= Playing.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Playing != false) {
        output.WriteRawTag(8);
        output.WriteBool(Playing);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Playing != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetPlaybackModeRequest other) {
      if (other == null) {
        return;
      }
      if (other.Playing != false) {
        Playing = other.Playing;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Playing = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SetPlaybackModeResponse : pb::IMessage<SetPlaybackModeResponse> {
    private static readonly pb::MessageParser<SetPlaybackModeResponse> _parser = new pb::MessageParser<SetPlaybackModeResponse>(() => new SetPlaybackModeResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetPlaybackModeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.MessageTypes[9]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlaybackModeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlaybackModeResponse(SetPlaybackModeResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlaybackModeResponse Clone() {
      return new SetPlaybackModeResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetPlaybackModeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetPlaybackModeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetPlaybackModeResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
