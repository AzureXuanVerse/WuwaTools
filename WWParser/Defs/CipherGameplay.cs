// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CipherGameplay : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static CipherGameplay GetRootAsCipherGameplay(ByteBuffer _bb) { return GetRootAsCipherGameplay(_bb, new CipherGameplay()); }
  public static CipherGameplay GetRootAsCipherGameplay(ByteBuffer _bb, CipherGameplay obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CipherGameplay __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Id { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetIdArray() { return __p.__vector_as_array<byte>(4); }
  public int Password { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.CipherGameplay> CreateCipherGameplay(FlatBufferBuilder builder,
      StringOffset idOffset = default(StringOffset),
      int password = 0) {
    builder.StartTable(2);
    CipherGameplay.AddPassword(builder, password);
    CipherGameplay.AddId(builder, idOffset);
    return CipherGameplay.EndCipherGameplay(builder);
  }

  public static void StartCipherGameplay(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, StringOffset idOffset) { builder.AddOffset(0, idOffset.Value, 0); }
  public static void AddPassword(FlatBufferBuilder builder, int password) { builder.AddInt(1, password, 0); }
  public static Offset<WWParser.Defs.CipherGameplay> EndCipherGameplay(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.CipherGameplay>(o);
  }
  public CipherGameplayT UnPack() {
    var _o = new CipherGameplayT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CipherGameplayT _o) {
    _o.Id = this.Id;
    _o.Password = this.Password;
  }
  public static Offset<WWParser.Defs.CipherGameplay> Pack(FlatBufferBuilder builder, CipherGameplayT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.CipherGameplay>);
    var _id = _o.Id == null ? default(StringOffset) : builder.CreateString(_o.Id);
    return CreateCipherGameplay(
      builder,
      _id,
      _o.Password);
  }
}

public class CipherGameplayT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public string Id { get; set; }
  [Newtonsoft.Json.JsonProperty("password")]
  public int Password { get; set; }

  public CipherGameplayT() {
    this.Id = null;
    this.Password = 0;
  }
}


static public class CipherGameplayVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Id*/, false)
      && verifier.VerifyField(tablePos, 6 /*Password*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
