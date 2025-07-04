// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BossRushMapMark : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static BossRushMapMark GetRootAsBossRushMapMark(ByteBuffer _bb) { return GetRootAsBossRushMapMark(_bb, new BossRushMapMark()); }
  public static BossRushMapMark GetRootAsBossRushMapMark(ByteBuffer _bb, BossRushMapMark obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BossRushMapMark __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ActivityId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MarkId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.BossRushMapMark> CreateBossRushMapMark(FlatBufferBuilder builder,
      int activity_id = 0,
      int mark_id = 0) {
    builder.StartTable(2);
    BossRushMapMark.AddMarkId(builder, mark_id);
    BossRushMapMark.AddActivityId(builder, activity_id);
    return BossRushMapMark.EndBossRushMapMark(builder);
  }

  public static void StartBossRushMapMark(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddActivityId(FlatBufferBuilder builder, int activityId) { builder.AddInt(0, activityId, 0); }
  public static void AddMarkId(FlatBufferBuilder builder, int markId) { builder.AddInt(1, markId, 0); }
  public static Offset<WWParser.Defs.BossRushMapMark> EndBossRushMapMark(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.BossRushMapMark>(o);
  }
  public BossRushMapMarkT UnPack() {
    var _o = new BossRushMapMarkT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BossRushMapMarkT _o) {
    _o.ActivityId = this.ActivityId;
    _o.MarkId = this.MarkId;
  }
  public static Offset<WWParser.Defs.BossRushMapMark> Pack(FlatBufferBuilder builder, BossRushMapMarkT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.BossRushMapMark>);
    return CreateBossRushMapMark(
      builder,
      _o.ActivityId,
      _o.MarkId);
  }
}

public class BossRushMapMarkT
{
  [Newtonsoft.Json.JsonProperty("activity_id")]
  public int ActivityId { get; set; }
  [Newtonsoft.Json.JsonProperty("mark_id")]
  public int MarkId { get; set; }

  public BossRushMapMarkT() {
    this.ActivityId = 0;
    this.MarkId = 0;
  }
}


static public class BossRushMapMarkVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ActivityId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*MarkId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
