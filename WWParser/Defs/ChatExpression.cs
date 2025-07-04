// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ChatExpression : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static ChatExpression GetRootAsChatExpression(ByteBuffer _bb) { return GetRootAsChatExpression(_bb, new ChatExpression()); }
  public static ChatExpression GetRootAsChatExpression(ByteBuffer _bb, ChatExpression obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ChatExpression __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int GroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public string ExpressionTexturePath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExpressionTexturePathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetExpressionTexturePathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetExpressionTexturePathArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<WWParser.Defs.ChatExpression> CreateChatExpression(FlatBufferBuilder builder,
      int id = 0,
      int group_id = 0,
      StringOffset nameOffset = default(StringOffset),
      StringOffset expression_texture_pathOffset = default(StringOffset)) {
    builder.StartTable(4);
    ChatExpression.AddExpressionTexturePath(builder, expression_texture_pathOffset);
    ChatExpression.AddName(builder, nameOffset);
    ChatExpression.AddGroupId(builder, group_id);
    ChatExpression.AddId(builder, id);
    return ChatExpression.EndChatExpression(builder);
  }

  public static void StartChatExpression(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, int groupId) { builder.AddInt(1, groupId, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddExpressionTexturePath(FlatBufferBuilder builder, StringOffset expressionTexturePathOffset) { builder.AddOffset(3, expressionTexturePathOffset.Value, 0); }
  public static Offset<WWParser.Defs.ChatExpression> EndChatExpression(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.ChatExpression>(o);
  }
  public ChatExpressionT UnPack() {
    var _o = new ChatExpressionT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ChatExpressionT _o) {
    _o.Id = this.Id;
    _o.GroupId = this.GroupId;
    _o.Name = this.Name;
    _o.ExpressionTexturePath = this.ExpressionTexturePath;
  }
  public static Offset<WWParser.Defs.ChatExpression> Pack(FlatBufferBuilder builder, ChatExpressionT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.ChatExpression>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _expression_texture_path = _o.ExpressionTexturePath == null ? default(StringOffset) : builder.CreateString(_o.ExpressionTexturePath);
    return CreateChatExpression(
      builder,
      _o.Id,
      _o.GroupId,
      _name,
      _expression_texture_path);
  }
}

public class ChatExpressionT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("group_id")]
  public int GroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("expression_texture_path")]
  public string ExpressionTexturePath { get; set; }

  public ChatExpressionT() {
    this.Id = 0;
    this.GroupId = 0;
    this.Name = null;
    this.ExpressionTexturePath = null;
  }
}


static public class ChatExpressionVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*GroupId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Name*/, false)
      && verifier.VerifyString(tablePos, 10 /*ExpressionTexturePath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
