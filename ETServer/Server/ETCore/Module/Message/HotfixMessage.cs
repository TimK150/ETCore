// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: HotfixMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace ET {

  #region Messages
  /// <summary>
  ///测试向服务器发送消息
  /// </summary>
  public partial class C2G_ISuperTestMessage : pb::IMessage {
    private static readonly pb::MessageParser<C2G_ISuperTestMessage> _parser = new pb::MessageParser<C2G_ISuperTestMessage>(() => (C2G_ISuperTestMessage)MessagePool.Instance.Fetch(typeof(C2G_ISuperTestMessage)));
    public static pb::MessageParser<C2G_ISuperTestMessage> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long actorId_;
    public long ActorId {
      get { return actorId_; }
      set {
        actorId_ = value;
      }
    }

    private string info_ = "";
    public string Info {
      get { return info_; }
      set {
        info_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (ActorId != 0L) {
        output.WriteRawTag(216, 5);
        output.WriteInt64(ActorId);
      }
      if (Info.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Info);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (ActorId != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ActorId);
      }
      if (Info.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Info);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      actorId_ = 0;
      info_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            ActorId = input.ReadInt64();
            break;
          }
          case 738: {
            Info = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///测试向服务器返回消息
  /// </summary>
  public partial class G2C_ISuperTestMessage : pb::IMessage {
    private static readonly pb::MessageParser<G2C_ISuperTestMessage> _parser = new pb::MessageParser<G2C_ISuperTestMessage>(() => (G2C_ISuperTestMessage)MessagePool.Instance.Fetch(typeof(G2C_ISuperTestMessage)));
    public static pb::MessageParser<G2C_ISuperTestMessage> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
