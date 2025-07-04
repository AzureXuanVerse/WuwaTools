// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FishingPosition : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static FishingPosition GetRootAsFishingPosition(ByteBuffer _bb) { return GetRootAsFishingPosition(_bb, new FishingPosition()); }
  public static FishingPosition GetRootAsFishingPosition(ByteBuffer _bb, FishingPosition obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FishingPosition __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Position(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int PositionLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetPositionBytes() { return __p.__vector_as_span<int>(6, 4); }
#else
  public ArraySegment<byte>? GetPositionBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public int[] GetPositionArray() { return __p.__vector_as_array<int>(6); }
  public int Rotation(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int RotationLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetRotationBytes() { return __p.__vector_as_span<int>(8, 4); }
#else
  public ArraySegment<byte>? GetRotationBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public int[] GetRotationArray() { return __p.__vector_as_array<int>(8); }

  public static Offset<WWParser.Defs.FishingPosition> CreateFishingPosition(FlatBufferBuilder builder,
      int id = 0,
      VectorOffset positionOffset = default(VectorOffset),
      VectorOffset rotationOffset = default(VectorOffset)) {
    builder.StartTable(3);
    FishingPosition.AddRotation(builder, rotationOffset);
    FishingPosition.AddPosition(builder, positionOffset);
    FishingPosition.AddId(builder, id);
    return FishingPosition.EndFishingPosition(builder);
  }

  public static void StartFishingPosition(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddPosition(FlatBufferBuilder builder, VectorOffset positionOffset) { builder.AddOffset(1, positionOffset.Value, 0); }
  public static VectorOffset CreatePositionVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePositionVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePositionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePositionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPositionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRotation(FlatBufferBuilder builder, VectorOffset rotationOffset) { builder.AddOffset(2, rotationOffset.Value, 0); }
  public static VectorOffset CreateRotationVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRotationVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRotationVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRotationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRotationVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<WWParser.Defs.FishingPosition> EndFishingPosition(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.FishingPosition>(o);
  }
  public FishingPositionT UnPack() {
    var _o = new FishingPositionT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FishingPositionT _o) {
    _o.Id = this.Id;
    _o.Position = new List<int>();
    for (var _j = 0; _j < this.PositionLength; ++_j) {_o.Position.Add(this.Position(_j));}
    _o.Rotation = new List<int>();
    for (var _j = 0; _j < this.RotationLength; ++_j) {_o.Rotation.Add(this.Rotation(_j));}
  }
  public static Offset<WWParser.Defs.FishingPosition> Pack(FlatBufferBuilder builder, FishingPositionT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.FishingPosition>);
    var _position = default(VectorOffset);
    if (_o.Position != null) {
      var __position = _o.Position.ToArray();
      _position = CreatePositionVector(builder, __position);
    }
    var _rotation = default(VectorOffset);
    if (_o.Rotation != null) {
      var __rotation = _o.Rotation.ToArray();
      _rotation = CreateRotationVector(builder, __rotation);
    }
    return CreateFishingPosition(
      builder,
      _o.Id,
      _position,
      _rotation);
  }
}

public class FishingPositionT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("position")]
  public List<int> Position { get; set; }
  [Newtonsoft.Json.JsonProperty("rotation")]
  public List<int> Rotation { get; set; }

  public FishingPositionT() {
    this.Id = 0;
    this.Position = null;
    this.Rotation = null;
  }
}


static public class FishingPositionVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*Position*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*Rotation*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
