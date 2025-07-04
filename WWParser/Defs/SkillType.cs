// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SkillType : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static SkillType GetRootAsSkillType(ByteBuffer _bb) { return GetRootAsSkillType(_bb, new SkillType()); }
  public static SkillType GetRootAsSkillType(ByteBuffer _bb, SkillType obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SkillType __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string TypeName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTypeNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTypeNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTypeNameArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<WWParser.Defs.SkillType> CreateSkillType(FlatBufferBuilder builder,
      int id = 0,
      StringOffset type_nameOffset = default(StringOffset)) {
    builder.StartTable(2);
    SkillType.AddTypeName(builder, type_nameOffset);
    SkillType.AddId(builder, id);
    return SkillType.EndSkillType(builder);
  }

  public static void StartSkillType(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddTypeName(FlatBufferBuilder builder, StringOffset typeNameOffset) { builder.AddOffset(1, typeNameOffset.Value, 0); }
  public static Offset<WWParser.Defs.SkillType> EndSkillType(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.SkillType>(o);
  }
  public SkillTypeT UnPack() {
    var _o = new SkillTypeT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SkillTypeT _o) {
    _o.Id = this.Id;
    _o.TypeName = this.TypeName;
  }
  public static Offset<WWParser.Defs.SkillType> Pack(FlatBufferBuilder builder, SkillTypeT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.SkillType>);
    var _type_name = _o.TypeName == null ? default(StringOffset) : builder.CreateString(_o.TypeName);
    return CreateSkillType(
      builder,
      _o.Id,
      _type_name);
  }
}

public class SkillTypeT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("type_name")]
  public string TypeName { get; set; }

  public SkillTypeT() {
    this.Id = 0;
    this.TypeName = null;
  }
}


static public class SkillTypeVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*TypeName*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
