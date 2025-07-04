// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FishingGridItemShape : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static FishingGridItemShape GetRootAsFishingGridItemShape(ByteBuffer _bb) { return GetRootAsFishingGridItemShape(_bb, new FishingGridItemShape()); }
  public static FishingGridItemShape GetRootAsFishingGridItemShape(ByteBuffer _bb, FishingGridItemShape obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FishingGridItemShape __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public WWParser.Defs.IntArray? FillState(int j) { int o = __p.__offset(6); return o != 0 ? (WWParser.Defs.IntArray?)(new WWParser.Defs.IntArray()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int FillStateLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<WWParser.Defs.FishingGridItemShape> CreateFishingGridItemShape(FlatBufferBuilder builder,
      int id = 0,
      VectorOffset fill_stateOffset = default(VectorOffset)) {
    builder.StartTable(2);
    FishingGridItemShape.AddFillState(builder, fill_stateOffset);
    FishingGridItemShape.AddId(builder, id);
    return FishingGridItemShape.EndFishingGridItemShape(builder);
  }

  public static void StartFishingGridItemShape(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddFillState(FlatBufferBuilder builder, VectorOffset fillStateOffset) { builder.AddOffset(1, fillStateOffset.Value, 0); }
  public static VectorOffset CreateFillStateVector(FlatBufferBuilder builder, Offset<WWParser.Defs.IntArray>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateFillStateVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.IntArray>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFillStateVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.IntArray>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFillStateVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.IntArray>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartFillStateVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<WWParser.Defs.FishingGridItemShape> EndFishingGridItemShape(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.FishingGridItemShape>(o);
  }
  public FishingGridItemShapeT UnPack() {
    var _o = new FishingGridItemShapeT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FishingGridItemShapeT _o) {
    _o.Id = this.Id;
    _o.FillState = new List<WWParser.Defs.IntArrayT>();
    for (var _j = 0; _j < this.FillStateLength; ++_j) {_o.FillState.Add(this.FillState(_j).HasValue ? this.FillState(_j).Value.UnPack() : null);}
  }
  public static Offset<WWParser.Defs.FishingGridItemShape> Pack(FlatBufferBuilder builder, FishingGridItemShapeT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.FishingGridItemShape>);
    var _fill_state = default(VectorOffset);
    if (_o.FillState != null) {
      var __fill_state = new Offset<WWParser.Defs.IntArray>[_o.FillState.Count];
      for (var _j = 0; _j < __fill_state.Length; ++_j) { __fill_state[_j] = WWParser.Defs.IntArray.Pack(builder, _o.FillState[_j]); }
      _fill_state = CreateFillStateVector(builder, __fill_state);
    }
    return CreateFishingGridItemShape(
      builder,
      _o.Id,
      _fill_state);
  }
}

public class FishingGridItemShapeT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("fill_state")]
  public List<WWParser.Defs.IntArrayT> FillState { get; set; }

  public FishingGridItemShapeT() {
    this.Id = 0;
    this.FillState = null;
  }
}


static public class FishingGridItemShapeVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 6 /*FillState*/, WWParser.Defs.IntArrayVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
