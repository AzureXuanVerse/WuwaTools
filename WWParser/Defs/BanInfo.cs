// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BanInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static BanInfo GetRootAsBanInfo(ByteBuffer _bb) { return GetRootAsBanInfo(_bb, new BanInfo()); }
  public static BanInfo GetRootAsBanInfo(ByteBuffer _bb, BanInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BanInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BanType { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BanReason { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BanDescribe { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBanDescribeBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetBanDescribeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetBanDescribeArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<WWParser.Defs.BanInfo> CreateBanInfo(FlatBufferBuilder builder,
      int id = 0,
      int ban_type = 0,
      int ban_reason = 0,
      StringOffset ban_describeOffset = default(StringOffset)) {
    builder.StartTable(4);
    BanInfo.AddBanDescribe(builder, ban_describeOffset);
    BanInfo.AddBanReason(builder, ban_reason);
    BanInfo.AddBanType(builder, ban_type);
    BanInfo.AddId(builder, id);
    return BanInfo.EndBanInfo(builder);
  }

  public static void StartBanInfo(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddBanType(FlatBufferBuilder builder, int banType) { builder.AddInt(1, banType, 0); }
  public static void AddBanReason(FlatBufferBuilder builder, int banReason) { builder.AddInt(2, banReason, 0); }
  public static void AddBanDescribe(FlatBufferBuilder builder, StringOffset banDescribeOffset) { builder.AddOffset(3, banDescribeOffset.Value, 0); }
  public static Offset<WWParser.Defs.BanInfo> EndBanInfo(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.BanInfo>(o);
  }
  public BanInfoT UnPack() {
    var _o = new BanInfoT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BanInfoT _o) {
    _o.Id = this.Id;
    _o.BanType = this.BanType;
    _o.BanReason = this.BanReason;
    _o.BanDescribe = this.BanDescribe;
  }
  public static Offset<WWParser.Defs.BanInfo> Pack(FlatBufferBuilder builder, BanInfoT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.BanInfo>);
    var _ban_describe = _o.BanDescribe == null ? default(StringOffset) : builder.CreateString(_o.BanDescribe);
    return CreateBanInfo(
      builder,
      _o.Id,
      _o.BanType,
      _o.BanReason,
      _ban_describe);
  }
}

public class BanInfoT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("ban_type")]
  public int BanType { get; set; }
  [Newtonsoft.Json.JsonProperty("ban_reason")]
  public int BanReason { get; set; }
  [Newtonsoft.Json.JsonProperty("ban_describe")]
  public string BanDescribe { get; set; }

  public BanInfoT() {
    this.Id = 0;
    this.BanType = 0;
    this.BanReason = 0;
    this.BanDescribe = null;
  }
}


static public class BanInfoVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*BanType*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*BanReason*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*BanDescribe*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
