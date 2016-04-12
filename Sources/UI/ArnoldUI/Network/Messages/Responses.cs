// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Responses.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GoodAI.Arnold.Network {

  /// <summary>Holder for reflection information generated from Responses.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ResponsesReflection {

    #region Descriptor
    /// <summary>File descriptor for Responses.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResponsesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9SZXNwb25zZXMucHJvdG8SFUdvb2RBSS5Bcm5vbGQuTmV0d29yayIYCgVF",
            "cnJvchIPCgdNZXNzYWdlGAEgASgJIpYBCglTdGF0ZURhdGESOQoFU3RhdGUY",
            "ASABKA4yKi5Hb29kQUkuQXJub2xkLk5ldHdvcmsuU3RhdGVEYXRhLlN0YXRl",
            "VHlwZSJOCglTdGF0ZVR5cGUSCQoFRW1wdHkQABILCgdSdW5uaW5nEAESCgoG",
            "UGF1c2VkEAISEAoMU2h1dHRpbmdEb3duEAMSCwoHSW52YWxpZBAEIoIBCg1T",
            "dGF0ZVJlc3BvbnNlEi0KBUVycm9yGAEgASgLMhwuR29vZEFJLkFybm9sZC5O",
            "ZXR3b3JrLkVycm9ySAASMAoERGF0YRgCIAEoCzIgLkdvb2RBSS5Bcm5vbGQu",
            "TmV0d29yay5TdGF0ZURhdGFIAEIQCg5yZXNwb25zZV9vbmVvZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::GoodAI.Arnold.Network.Error), global::GoodAI.Arnold.Network.Error.Parser, new[]{ "Message" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::GoodAI.Arnold.Network.StateData), global::GoodAI.Arnold.Network.StateData.Parser, new[]{ "State" }, null, new[]{ typeof(global::GoodAI.Arnold.Network.StateData.Types.StateType) }, null),
            new pbr::GeneratedCodeInfo(typeof(global::GoodAI.Arnold.Network.StateResponse), global::GoodAI.Arnold.Network.StateResponse.Parser, new[]{ "Error", "Data" }, new[]{ "ResponseOneof" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Error : pb::IMessage<Error> {
    private static readonly pb::MessageParser<Error> _parser = new pb::MessageParser<Error>(() => new Error());
    public static pb::MessageParser<Error> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::GoodAI.Arnold.Network.ResponsesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Error() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Error(Error other) : this() {
      message_ = other.message_;
    }

    public Error Clone() {
      return new Error(this);
    }

    /// <summary>Field number for the "Message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Error);
    }

    public bool Equals(Error other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    public void MergeFrom(Error other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
    }

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

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class StateData : pb::IMessage<StateData> {
    private static readonly pb::MessageParser<StateData> _parser = new pb::MessageParser<StateData>(() => new StateData());
    public static pb::MessageParser<StateData> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::GoodAI.Arnold.Network.ResponsesReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public StateData() {
      OnConstruction();
    }

    partial void OnConstruction();

    public StateData(StateData other) : this() {
      state_ = other.state_;
    }

    public StateData Clone() {
      return new StateData(this);
    }

    /// <summary>Field number for the "State" field.</summary>
    public const int StateFieldNumber = 1;
    private global::GoodAI.Arnold.Network.StateData.Types.StateType state_ = global::GoodAI.Arnold.Network.StateData.Types.StateType.Empty;
    public global::GoodAI.Arnold.Network.StateData.Types.StateType State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as StateData);
    }

    public bool Equals(StateData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (State != other.State) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (State != global::GoodAI.Arnold.Network.StateData.Types.StateType.Empty) hash ^= State.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (State != global::GoodAI.Arnold.Network.StateData.Types.StateType.Empty) {
        output.WriteRawTag(8);
        output.WriteEnum((int) State);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (State != global::GoodAI.Arnold.Network.StateData.Types.StateType.Empty) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      return size;
    }

    public void MergeFrom(StateData other) {
      if (other == null) {
        return;
      }
      if (other.State != global::GoodAI.Arnold.Network.StateData.Types.StateType.Empty) {
        State = other.State;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            state_ = (global::GoodAI.Arnold.Network.StateData.Types.StateType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the StateData message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum StateType {
        Empty = 0,
        Running = 1,
        Paused = 2,
        ShuttingDown = 3,
        Invalid = 4,
      }

    }
    #endregion

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class StateResponse : pb::IMessage<StateResponse> {
    private static readonly pb::MessageParser<StateResponse> _parser = new pb::MessageParser<StateResponse>(() => new StateResponse());
    public static pb::MessageParser<StateResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::GoodAI.Arnold.Network.ResponsesReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public StateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public StateResponse(StateResponse other) : this() {
      switch (other.ResponseOneofCase) {
        case ResponseOneofOneofCase.Error:
          Error = other.Error.Clone();
          break;
        case ResponseOneofOneofCase.Data:
          Data = other.Data.Clone();
          break;
      }

    }

    public StateResponse Clone() {
      return new StateResponse(this);
    }

    /// <summary>Field number for the "Error" field.</summary>
    public const int ErrorFieldNumber = 1;
    public global::GoodAI.Arnold.Network.Error Error {
      get { return responseOneofCase_ == ResponseOneofOneofCase.Error ? (global::GoodAI.Arnold.Network.Error) responseOneof_ : null; }
      set {
        responseOneof_ = value;
        responseOneofCase_ = value == null ? ResponseOneofOneofCase.None : ResponseOneofOneofCase.Error;
      }
    }

    /// <summary>Field number for the "Data" field.</summary>
    public const int DataFieldNumber = 2;
    public global::GoodAI.Arnold.Network.StateData Data {
      get { return responseOneofCase_ == ResponseOneofOneofCase.Data ? (global::GoodAI.Arnold.Network.StateData) responseOneof_ : null; }
      set {
        responseOneof_ = value;
        responseOneofCase_ = value == null ? ResponseOneofOneofCase.None : ResponseOneofOneofCase.Data;
      }
    }

    private object responseOneof_;
    /// <summary>Enum of possible cases for the "response_oneof" oneof.</summary>
    public enum ResponseOneofOneofCase {
      None = 0,
      Error = 1,
      Data = 2,
    }
    private ResponseOneofOneofCase responseOneofCase_ = ResponseOneofOneofCase.None;
    public ResponseOneofOneofCase ResponseOneofCase {
      get { return responseOneofCase_; }
    }

    public void ClearResponseOneof() {
      responseOneofCase_ = ResponseOneofOneofCase.None;
      responseOneof_ = null;
    }

    public override bool Equals(object other) {
      return Equals(other as StateResponse);
    }

    public bool Equals(StateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Error, other.Error)) return false;
      if (!object.Equals(Data, other.Data)) return false;
      if (ResponseOneofCase != other.ResponseOneofCase) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (responseOneofCase_ == ResponseOneofOneofCase.Error) hash ^= Error.GetHashCode();
      if (responseOneofCase_ == ResponseOneofOneofCase.Data) hash ^= Data.GetHashCode();
      hash ^= (int) responseOneofCase_;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (responseOneofCase_ == ResponseOneofOneofCase.Error) {
        output.WriteRawTag(10);
        output.WriteMessage(Error);
      }
      if (responseOneofCase_ == ResponseOneofOneofCase.Data) {
        output.WriteRawTag(18);
        output.WriteMessage(Data);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (responseOneofCase_ == ResponseOneofOneofCase.Error) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Error);
      }
      if (responseOneofCase_ == ResponseOneofOneofCase.Data) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      return size;
    }

    public void MergeFrom(StateResponse other) {
      if (other == null) {
        return;
      }
      switch (other.ResponseOneofCase) {
        case ResponseOneofOneofCase.Error:
          Error = other.Error;
          break;
        case ResponseOneofOneofCase.Data:
          Data = other.Data;
          break;
      }

    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            global::GoodAI.Arnold.Network.Error subBuilder = new global::GoodAI.Arnold.Network.Error();
            if (responseOneofCase_ == ResponseOneofOneofCase.Error) {
              subBuilder.MergeFrom(Error);
            }
            input.ReadMessage(subBuilder);
            Error = subBuilder;
            break;
          }
          case 18: {
            global::GoodAI.Arnold.Network.StateData subBuilder = new global::GoodAI.Arnold.Network.StateData();
            if (responseOneofCase_ == ResponseOneofOneofCase.Data) {
              subBuilder.MergeFrom(Data);
            }
            input.ReadMessage(subBuilder);
            Data = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
