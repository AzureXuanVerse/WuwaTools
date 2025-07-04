// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SListenEventExportDefine : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static SListenEventExportDefine GetRootAsSListenEventExportDefine(ByteBuffer _bb) { return GetRootAsSListenEventExportDefine(_bb, new SListenEventExportDefine()); }
  public static SListenEventExportDefine GetRootAsSListenEventExportDefine(ByteBuffer _bb, SListenEventExportDefine obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SListenEventExportDefine __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ListenConfigIds(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ListenConfigIdsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetListenConfigIdsBytes() { return __p.__vector_as_span<int>(4, 4); }
#else
  public ArraySegment<byte>? GetListenConfigIdsBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public int[] GetListenConfigIdsArray() { return __p.__vector_as_array<int>(4); }
  public float ListenRange { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<WWParser.Defs.SListenEventExportDefine> CreateSListenEventExportDefine(FlatBufferBuilder builder,
      VectorOffset listen_config_idsOffset = default(VectorOffset),
      float listen_range = 0.0f) {
    builder.StartTable(2);
    SListenEventExportDefine.AddListenRange(builder, listen_range);
    SListenEventExportDefine.AddListenConfigIds(builder, listen_config_idsOffset);
    return SListenEventExportDefine.EndSListenEventExportDefine(builder);
  }

  public static void StartSListenEventExportDefine(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddListenConfigIds(FlatBufferBuilder builder, VectorOffset listenConfigIdsOffset) { builder.AddOffset(0, listenConfigIdsOffset.Value, 0); }
  public static VectorOffset CreateListenConfigIdsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateListenConfigIdsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateListenConfigIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateListenConfigIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartListenConfigIdsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddListenRange(FlatBufferBuilder builder, float listenRange) { builder.AddFloat(1, listenRange, 0.0f); }
  public static Offset<WWParser.Defs.SListenEventExportDefine> EndSListenEventExportDefine(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.SListenEventExportDefine>(o);
  }
  public SListenEventExportDefineT UnPack() {
    var _o = new SListenEventExportDefineT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SListenEventExportDefineT _o) {
    _o.ListenConfigIds = new List<int>();
    for (var _j = 0; _j < this.ListenConfigIdsLength; ++_j) {_o.ListenConfigIds.Add(this.ListenConfigIds(_j));}
    _o.ListenRange = this.ListenRange;
  }
  public static Offset<WWParser.Defs.SListenEventExportDefine> Pack(FlatBufferBuilder builder, SListenEventExportDefineT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.SListenEventExportDefine>);
    var _listen_config_ids = default(VectorOffset);
    if (_o.ListenConfigIds != null) {
      var __listen_config_ids = _o.ListenConfigIds.ToArray();
      _listen_config_ids = CreateListenConfigIdsVector(builder, __listen_config_ids);
    }
    return CreateSListenEventExportDefine(
      builder,
      _listen_config_ids,
      _o.ListenRange);
  }
}

public class SListenEventExportDefineT
{
  [Newtonsoft.Json.JsonProperty("listen_config_ids")]
  public List<int> ListenConfigIds { get; set; }
  [Newtonsoft.Json.JsonProperty("listen_range")]
  public float ListenRange { get; set; }

  public SListenEventExportDefineT() {
    this.ListenConfigIds = null;
    this.ListenRange = 0.0f;
  }
}


static public class SListenEventExportDefineVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfData(tablePos, 4 /*ListenConfigIds*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 6 /*ListenRange*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
