// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LongShanActivityConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static LongShanActivityConfig GetRootAsLongShanActivityConfig(ByteBuffer _bb) { return GetRootAsLongShanActivityConfig(_bb, new LongShanActivityConfig()); }
  public static LongShanActivityConfig GetRootAsLongShanActivityConfig(ByteBuffer _bb, LongShanActivityConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LongShanActivityConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ActivityId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Type { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)1; } }

  public static Offset<WWParser.Defs.LongShanActivityConfig> CreateLongShanActivityConfig(FlatBufferBuilder builder,
      int activity_id = 0,
      int type = 1) {
    builder.StartTable(2);
    LongShanActivityConfig.AddType(builder, type);
    LongShanActivityConfig.AddActivityId(builder, activity_id);
    return LongShanActivityConfig.EndLongShanActivityConfig(builder);
  }

  public static void StartLongShanActivityConfig(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddActivityId(FlatBufferBuilder builder, int activityId) { builder.AddInt(0, activityId, 0); }
  public static void AddType(FlatBufferBuilder builder, int type) { builder.AddInt(1, type, 1); }
  public static Offset<WWParser.Defs.LongShanActivityConfig> EndLongShanActivityConfig(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.LongShanActivityConfig>(o);
  }
  public LongShanActivityConfigT UnPack() {
    var _o = new LongShanActivityConfigT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LongShanActivityConfigT _o) {
    _o.ActivityId = this.ActivityId;
    _o.Type = this.Type;
  }
  public static Offset<WWParser.Defs.LongShanActivityConfig> Pack(FlatBufferBuilder builder, LongShanActivityConfigT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.LongShanActivityConfig>);
    return CreateLongShanActivityConfig(
      builder,
      _o.ActivityId,
      _o.Type);
  }
}

public class LongShanActivityConfigT
{
  [Newtonsoft.Json.JsonProperty("activity_id")]
  public int ActivityId { get; set; }
  [Newtonsoft.Json.JsonProperty("type")]
  public int Type { get; set; }

  public LongShanActivityConfigT() {
    this.ActivityId = 0;
    this.Type = 1;
  }
}


static public class LongShanActivityConfigVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ActivityId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Type*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
