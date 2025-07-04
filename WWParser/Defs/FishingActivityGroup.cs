// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FishingActivityGroup : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static FishingActivityGroup GetRootAsFishingActivityGroup(ByteBuffer _bb) { return GetRootAsFishingActivityGroup(_bb, new FishingActivityGroup()); }
  public static FishingActivityGroup GetRootAsFishingActivityGroup(ByteBuffer _bb, FishingActivityGroup obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FishingActivityGroup __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string GroupName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGroupNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetGroupNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetGroupNameArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<WWParser.Defs.FishingActivityGroup> CreateFishingActivityGroup(FlatBufferBuilder builder,
      int id = 0,
      StringOffset group_nameOffset = default(StringOffset)) {
    builder.StartTable(2);
    FishingActivityGroup.AddGroupName(builder, group_nameOffset);
    FishingActivityGroup.AddId(builder, id);
    return FishingActivityGroup.EndFishingActivityGroup(builder);
  }

  public static void StartFishingActivityGroup(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddGroupName(FlatBufferBuilder builder, StringOffset groupNameOffset) { builder.AddOffset(1, groupNameOffset.Value, 0); }
  public static Offset<WWParser.Defs.FishingActivityGroup> EndFishingActivityGroup(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.FishingActivityGroup>(o);
  }
  public FishingActivityGroupT UnPack() {
    var _o = new FishingActivityGroupT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FishingActivityGroupT _o) {
    _o.Id = this.Id;
    _o.GroupName = this.GroupName;
  }
  public static Offset<WWParser.Defs.FishingActivityGroup> Pack(FlatBufferBuilder builder, FishingActivityGroupT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.FishingActivityGroup>);
    var _group_name = _o.GroupName == null ? default(StringOffset) : builder.CreateString(_o.GroupName);
    return CreateFishingActivityGroup(
      builder,
      _o.Id,
      _group_name);
  }
}

public class FishingActivityGroupT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("group_name")]
  public string GroupName { get; set; }

  public FishingActivityGroupT() {
    this.Id = 0;
    this.GroupName = null;
  }
}


static public class FishingActivityGroupVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*GroupName*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
