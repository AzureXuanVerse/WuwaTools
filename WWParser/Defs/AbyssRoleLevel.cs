// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AbyssRoleLevel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static AbyssRoleLevel GetRootAsAbyssRoleLevel(ByteBuffer _bb) { return GetRootAsAbyssRoleLevel(_bb, new AbyssRoleLevel()); }
  public static AbyssRoleLevel GetRootAsAbyssRoleLevel(ByteBuffer _bb, AbyssRoleLevel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AbyssRoleLevel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int GroupId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public WWParser.Defs.DicIntInt? Consume(int j) { int o = __p.__offset(10); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ConsumeLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public WWParser.Defs.ConfigPropValue? Prop(int j) { int o = __p.__offset(12); return o != 0 ? (WWParser.Defs.ConfigPropValue?)(new WWParser.Defs.ConfigPropValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int PropLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int PluginNum { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.AbyssRoleLevel> CreateAbyssRoleLevel(FlatBufferBuilder builder,
      int id = 0,
      int level = 0,
      int group_id = 0,
      VectorOffset consumeOffset = default(VectorOffset),
      VectorOffset propOffset = default(VectorOffset),
      int plugin_num = 0) {
    builder.StartTable(6);
    AbyssRoleLevel.AddPluginNum(builder, plugin_num);
    AbyssRoleLevel.AddProp(builder, propOffset);
    AbyssRoleLevel.AddConsume(builder, consumeOffset);
    AbyssRoleLevel.AddGroupId(builder, group_id);
    AbyssRoleLevel.AddLevel(builder, level);
    AbyssRoleLevel.AddId(builder, id);
    return AbyssRoleLevel.EndAbyssRoleLevel(builder);
  }

  public static void StartAbyssRoleLevel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(1, level, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, int groupId) { builder.AddInt(2, groupId, 0); }
  public static void AddConsume(FlatBufferBuilder builder, VectorOffset consumeOffset) { builder.AddOffset(3, consumeOffset.Value, 0); }
  public static VectorOffset CreateConsumeVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateConsumeVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddProp(FlatBufferBuilder builder, VectorOffset propOffset) { builder.AddOffset(4, propOffset.Value, 0); }
  public static VectorOffset CreatePropVector(FlatBufferBuilder builder, Offset<WWParser.Defs.ConfigPropValue>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePropVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.ConfigPropValue>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePropVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.ConfigPropValue>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePropVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.ConfigPropValue>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPropVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPluginNum(FlatBufferBuilder builder, int pluginNum) { builder.AddInt(5, pluginNum, 0); }
  public static Offset<WWParser.Defs.AbyssRoleLevel> EndAbyssRoleLevel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.AbyssRoleLevel>(o);
  }
  public AbyssRoleLevelT UnPack() {
    var _o = new AbyssRoleLevelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AbyssRoleLevelT _o) {
    _o.Id = this.Id;
    _o.Level = this.Level;
    _o.GroupId = this.GroupId;
    _o.Consume = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.ConsumeLength; ++_j) {_o.Consume.Add(this.Consume(_j).HasValue ? this.Consume(_j).Value.UnPack() : null);}
    _o.Prop = new List<WWParser.Defs.ConfigPropValueT>();
    for (var _j = 0; _j < this.PropLength; ++_j) {_o.Prop.Add(this.Prop(_j).HasValue ? this.Prop(_j).Value.UnPack() : null);}
    _o.PluginNum = this.PluginNum;
  }
  public static Offset<WWParser.Defs.AbyssRoleLevel> Pack(FlatBufferBuilder builder, AbyssRoleLevelT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.AbyssRoleLevel>);
    var _consume = default(VectorOffset);
    if (_o.Consume != null) {
      var __consume = new Offset<WWParser.Defs.DicIntInt>[_o.Consume.Count];
      for (var _j = 0; _j < __consume.Length; ++_j) { __consume[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.Consume[_j]); }
      _consume = CreateConsumeVector(builder, __consume);
    }
    var _prop = default(VectorOffset);
    if (_o.Prop != null) {
      var __prop = new Offset<WWParser.Defs.ConfigPropValue>[_o.Prop.Count];
      for (var _j = 0; _j < __prop.Length; ++_j) { __prop[_j] = WWParser.Defs.ConfigPropValue.Pack(builder, _o.Prop[_j]); }
      _prop = CreatePropVector(builder, __prop);
    }
    return CreateAbyssRoleLevel(
      builder,
      _o.Id,
      _o.Level,
      _o.GroupId,
      _consume,
      _prop,
      _o.PluginNum);
  }
}

public class AbyssRoleLevelT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("level")]
  public int Level { get; set; }
  [Newtonsoft.Json.JsonProperty("group_id")]
  public int GroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("consume")]
  public List<WWParser.Defs.DicIntIntT> Consume { get; set; }
  [Newtonsoft.Json.JsonProperty("prop")]
  public List<WWParser.Defs.ConfigPropValueT> Prop { get; set; }
  [Newtonsoft.Json.JsonProperty("plugin_num")]
  public int PluginNum { get; set; }

  public AbyssRoleLevelT() {
    this.Id = 0;
    this.Level = 0;
    this.GroupId = 0;
    this.Consume = null;
    this.Prop = null;
    this.PluginNum = 0;
  }
}


static public class AbyssRoleLevelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Level*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*GroupId*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 10 /*Consume*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 12 /*Prop*/, WWParser.Defs.ConfigPropValueVerify.Verify, false)
      && verifier.VerifyField(tablePos, 14 /*PluginNum*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
