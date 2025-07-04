// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MapMarkPhantomGroup : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static MapMarkPhantomGroup GetRootAsMapMarkPhantomGroup(ByteBuffer _bb) { return GetRootAsMapMarkPhantomGroup(_bb, new MapMarkPhantomGroup()); }
  public static MapMarkPhantomGroup GetRootAsMapMarkPhantomGroup(ByteBuffer _bb, MapMarkPhantomGroup obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MapMarkPhantomGroup __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int MarkId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShowRange(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ShowRangeLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetShowRangeBytes() { return __p.__vector_as_span<int>(6, 4); }
#else
  public ArraySegment<byte>? GetShowRangeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public int[] GetShowRangeArray() { return __p.__vector_as_array<int>(6); }

  public static Offset<WWParser.Defs.MapMarkPhantomGroup> CreateMapMarkPhantomGroup(FlatBufferBuilder builder,
      int mark_id = 0,
      VectorOffset show_rangeOffset = default(VectorOffset)) {
    builder.StartTable(2);
    MapMarkPhantomGroup.AddShowRange(builder, show_rangeOffset);
    MapMarkPhantomGroup.AddMarkId(builder, mark_id);
    return MapMarkPhantomGroup.EndMapMarkPhantomGroup(builder);
  }

  public static void StartMapMarkPhantomGroup(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddMarkId(FlatBufferBuilder builder, int markId) { builder.AddInt(0, markId, 0); }
  public static void AddShowRange(FlatBufferBuilder builder, VectorOffset showRangeOffset) { builder.AddOffset(1, showRangeOffset.Value, 0); }
  public static VectorOffset CreateShowRangeVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateShowRangeVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShowRangeVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShowRangeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShowRangeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<WWParser.Defs.MapMarkPhantomGroup> EndMapMarkPhantomGroup(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.MapMarkPhantomGroup>(o);
  }
  public MapMarkPhantomGroupT UnPack() {
    var _o = new MapMarkPhantomGroupT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MapMarkPhantomGroupT _o) {
    _o.MarkId = this.MarkId;
    _o.ShowRange = new List<int>();
    for (var _j = 0; _j < this.ShowRangeLength; ++_j) {_o.ShowRange.Add(this.ShowRange(_j));}
  }
  public static Offset<WWParser.Defs.MapMarkPhantomGroup> Pack(FlatBufferBuilder builder, MapMarkPhantomGroupT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.MapMarkPhantomGroup>);
    var _show_range = default(VectorOffset);
    if (_o.ShowRange != null) {
      var __show_range = _o.ShowRange.ToArray();
      _show_range = CreateShowRangeVector(builder, __show_range);
    }
    return CreateMapMarkPhantomGroup(
      builder,
      _o.MarkId,
      _show_range);
  }
}

public class MapMarkPhantomGroupT
{
  [Newtonsoft.Json.JsonProperty("mark_id")]
  public int MarkId { get; set; }
  [Newtonsoft.Json.JsonProperty("show_range")]
  public List<int> ShowRange { get; set; }

  public MapMarkPhantomGroupT() {
    this.MarkId = 0;
    this.ShowRange = null;
  }
}


static public class MapMarkPhantomGroupVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*MarkId*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*ShowRange*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
