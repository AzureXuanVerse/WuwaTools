// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TowerTarget : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static TowerTarget GetRootAsTowerTarget(ByteBuffer _bb) { return GetRootAsTowerTarget(_bb, new TowerTarget()); }
  public static TowerTarget GetRootAsTowerTarget(ByteBuffer _bb, TowerTarget obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TowerTarget __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TargetType { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Params(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ParamsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetParamsBytes() { return __p.__vector_as_span<int>(8, 4); }
#else
  public ArraySegment<byte>? GetParamsBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public int[] GetParamsArray() { return __p.__vector_as_array<int>(8); }
  public string DesText { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDesTextBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetDesTextBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetDesTextArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<WWParser.Defs.TowerTarget> CreateTowerTarget(FlatBufferBuilder builder,
      int id = 0,
      int target_type = 0,
      VectorOffset @paramsOffset = default(VectorOffset),
      StringOffset des_textOffset = default(StringOffset)) {
    builder.StartTable(4);
    TowerTarget.AddDesText(builder, des_textOffset);
    TowerTarget.AddParams(builder, @paramsOffset);
    TowerTarget.AddTargetType(builder, target_type);
    TowerTarget.AddId(builder, id);
    return TowerTarget.EndTowerTarget(builder);
  }

  public static void StartTowerTarget(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddTargetType(FlatBufferBuilder builder, int targetType) { builder.AddInt(1, targetType, 0); }
  public static void AddParams(FlatBufferBuilder builder, VectorOffset paramsOffset) { builder.AddOffset(2, paramsOffset.Value, 0); }
  public static VectorOffset CreateParamsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParamsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDesText(FlatBufferBuilder builder, StringOffset desTextOffset) { builder.AddOffset(3, desTextOffset.Value, 0); }
  public static Offset<WWParser.Defs.TowerTarget> EndTowerTarget(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.TowerTarget>(o);
  }
  public TowerTargetT UnPack() {
    var _o = new TowerTargetT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TowerTargetT _o) {
    _o.Id = this.Id;
    _o.TargetType = this.TargetType;
    _o.Params = new List<int>();
    for (var _j = 0; _j < this.ParamsLength; ++_j) {_o.Params.Add(this.Params(_j));}
    _o.DesText = this.DesText;
  }
  public static Offset<WWParser.Defs.TowerTarget> Pack(FlatBufferBuilder builder, TowerTargetT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.TowerTarget>);
    var _params = default(VectorOffset);
    if (_o.Params != null) {
      var __params = _o.Params.ToArray();
      _params = CreateParamsVector(builder, __params);
    }
    var _des_text = _o.DesText == null ? default(StringOffset) : builder.CreateString(_o.DesText);
    return CreateTowerTarget(
      builder,
      _o.Id,
      _o.TargetType,
      _params,
      _des_text);
  }
}

public class TowerTargetT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("target_type")]
  public int TargetType { get; set; }
  [Newtonsoft.Json.JsonProperty("params")]
  public List<int> Params { get; set; }
  [Newtonsoft.Json.JsonProperty("des_text")]
  public string DesText { get; set; }

  public TowerTargetT() {
    this.Id = 0;
    this.TargetType = 0;
    this.Params = null;
    this.DesText = null;
  }
}


static public class TowerTargetVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*TargetType*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*Params*/, 4 /*int*/, false)
      && verifier.VerifyString(tablePos, 10 /*DesText*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
