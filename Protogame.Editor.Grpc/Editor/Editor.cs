// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Editor.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protogame.Editor.Grpc.Editor {

  /// <summary>Holder for reflection information generated from Editor.proto</summary>
  public static partial class EditorReflection {

    #region Descriptor
    /// <summary>File descriptor for Editor.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EditorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxFZGl0b3IucHJvdG8iFQoTR2V0TWVudUl0ZW1zUmVxdWVzdCI0ChRHZXRN",
            "ZW51SXRlbXNSZXNwb25zZRIcCgltZW51SXRlbXMYASADKAsyCS5NZW51SXRl",
            "bSJECghNZW51SXRlbRIKCgJpZBgBIAEoAxINCgVvcmRlchgCIAEoAxIMCgR0",
            "ZXh0GAMgASgJEg8KB2VuYWJsZWQYBCABKAgiHQoKTG9nUmVxdWVzdBIPCgdt",
            "ZXNzYWdlGAEgASgJIg0KC0xvZ1Jlc3BvbnNlMkoKC01lbnVFbnRyaWVzEjsK",
            "DEdldE1lbnVJdGVtcxIULkdldE1lbnVJdGVtc1JlcXVlc3QaFS5HZXRNZW51",
            "SXRlbXNSZXNwb25zZTKjAQoHQ29uc29sZRIlCghMb2dEZWJ1ZxILLkxvZ1Jl",
            "cXVlc3QaDC5Mb2dSZXNwb25zZRIkCgdMb2dJbmZvEgsuTG9nUmVxdWVzdBoM",
            "LkxvZ1Jlc3BvbnNlEiQKB0xvZ1dhcm4SCy5Mb2dSZXF1ZXN0GgwuTG9nUmVz",
            "cG9uc2USJQoITG9nRXJyb3ISCy5Mb2dSZXF1ZXN0GgwuTG9nUmVzcG9uc2VC",
            "H6oCHFByb3RvZ2FtZS5FZGl0b3IuR3JwYy5FZGl0b3JiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.Editor.GetMenuItemsRequest), global::Protogame.Editor.Grpc.Editor.GetMenuItemsRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.Editor.GetMenuItemsResponse), global::Protogame.Editor.Grpc.Editor.GetMenuItemsResponse.Parser, new[]{ "MenuItems" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.Editor.MenuItem), global::Protogame.Editor.Grpc.Editor.MenuItem.Parser, new[]{ "Id", "Order", "Text", "Enabled" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.Editor.LogRequest), global::Protogame.Editor.Grpc.Editor.LogRequest.Parser, new[]{ "Message" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protogame.Editor.Grpc.Editor.LogResponse), global::Protogame.Editor.Grpc.Editor.LogResponse.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetMenuItemsRequest : pb::IMessage<GetMenuItemsRequest> {
    private static readonly pb::MessageParser<GetMenuItemsRequest> _parser = new pb::MessageParser<GetMenuItemsRequest>(() => new GetMenuItemsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMenuItemsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.Editor.EditorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMenuItemsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMenuItemsRequest(GetMenuItemsRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMenuItemsRequest Clone() {
      return new GetMenuItemsRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMenuItemsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMenuItemsRequest other) {
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
    public void MergeFrom(GetMenuItemsRequest other) {
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

  public sealed partial class GetMenuItemsResponse : pb::IMessage<GetMenuItemsResponse> {
    private static readonly pb::MessageParser<GetMenuItemsResponse> _parser = new pb::MessageParser<GetMenuItemsResponse>(() => new GetMenuItemsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMenuItemsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.Editor.EditorReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMenuItemsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMenuItemsResponse(GetMenuItemsResponse other) : this() {
      menuItems_ = other.menuItems_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMenuItemsResponse Clone() {
      return new GetMenuItemsResponse(this);
    }

    /// <summary>Field number for the "menuItems" field.</summary>
    public const int MenuItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Protogame.Editor.Grpc.Editor.MenuItem> _repeated_menuItems_codec
        = pb::FieldCodec.ForMessage(10, global::Protogame.Editor.Grpc.Editor.MenuItem.Parser);
    private readonly pbc::RepeatedField<global::Protogame.Editor.Grpc.Editor.MenuItem> menuItems_ = new pbc::RepeatedField<global::Protogame.Editor.Grpc.Editor.MenuItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Protogame.Editor.Grpc.Editor.MenuItem> MenuItems {
      get { return menuItems_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMenuItemsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMenuItemsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!menuItems_.Equals(other.menuItems_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= menuItems_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      menuItems_.WriteTo(output, _repeated_menuItems_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += menuItems_.CalculateSize(_repeated_menuItems_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMenuItemsResponse other) {
      if (other == null) {
        return;
      }
      menuItems_.Add(other.menuItems_);
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
            menuItems_.AddEntriesFrom(input, _repeated_menuItems_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class MenuItem : pb::IMessage<MenuItem> {
    private static readonly pb::MessageParser<MenuItem> _parser = new pb::MessageParser<MenuItem>(() => new MenuItem());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MenuItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.Editor.EditorReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MenuItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MenuItem(MenuItem other) : this() {
      id_ = other.id_;
      order_ = other.order_;
      text_ = other.text_;
      enabled_ = other.enabled_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MenuItem Clone() {
      return new MenuItem(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "order" field.</summary>
    public const int OrderFieldNumber = 2;
    private long order_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Order {
      get { return order_; }
      set {
        order_ = value;
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 3;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "enabled" field.</summary>
    public const int EnabledFieldNumber = 4;
    private bool enabled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Enabled {
      get { return enabled_; }
      set {
        enabled_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MenuItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MenuItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Order != other.Order) return false;
      if (Text != other.Text) return false;
      if (Enabled != other.Enabled) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Order != 0L) hash ^= Order.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (Enabled != false) hash ^= Enabled.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (Order != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Order);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Text);
      }
      if (Enabled != false) {
        output.WriteRawTag(32);
        output.WriteBool(Enabled);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Order != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Order);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (Enabled != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MenuItem other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Order != 0L) {
        Order = other.Order;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      if (other.Enabled != false) {
        Enabled = other.Enabled;
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
            Id = input.ReadInt64();
            break;
          }
          case 16: {
            Order = input.ReadInt64();
            break;
          }
          case 26: {
            Text = input.ReadString();
            break;
          }
          case 32: {
            Enabled = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class LogRequest : pb::IMessage<LogRequest> {
    private static readonly pb::MessageParser<LogRequest> _parser = new pb::MessageParser<LogRequest>(() => new LogRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LogRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.Editor.EditorReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogRequest(LogRequest other) : this() {
      message_ = other.message_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogRequest Clone() {
      return new LogRequest(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LogRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LogRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LogRequest other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
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
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class LogResponse : pb::IMessage<LogResponse> {
    private static readonly pb::MessageParser<LogResponse> _parser = new pb::MessageParser<LogResponse>(() => new LogResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LogResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protogame.Editor.Grpc.Editor.EditorReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogResponse(LogResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogResponse Clone() {
      return new LogResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LogResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LogResponse other) {
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
    public void MergeFrom(LogResponse other) {
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