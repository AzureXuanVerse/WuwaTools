// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LangOfLogo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static LangOfLogo GetRootAsLangOfLogo(ByteBuffer _bb) { return GetRootAsLangOfLogo(_bb, new LangOfLogo()); }
  public static LangOfLogo GetRootAsLangOfLogo(ByteBuffer _bb, LangOfLogo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LangOfLogo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public string ZhHansLogo { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetZhHansLogoBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetZhHansLogoBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetZhHansLogoArray() { return __p.__vector_as_array<byte>(6); }
  public string EnLogo { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEnLogoBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetEnLogoBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetEnLogoArray() { return __p.__vector_as_array<byte>(8); }
  public string JpLogo { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetJpLogoBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetJpLogoBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetJpLogoArray() { return __p.__vector_as_array<byte>(10); }
  public string ZhHantLogo { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetZhHantLogoBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetZhHantLogoBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetZhHantLogoArray() { return __p.__vector_as_array<byte>(12); }
  public string KrLogo { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKrLogoBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetKrLogoBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetKrLogoArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<WWParser.Defs.LangOfLogo> CreateLangOfLogo(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      StringOffset zh_hans_logoOffset = default(StringOffset),
      StringOffset en_logoOffset = default(StringOffset),
      StringOffset jp_logoOffset = default(StringOffset),
      StringOffset zh_hant_logoOffset = default(StringOffset),
      StringOffset kr_logoOffset = default(StringOffset)) {
    builder.StartTable(6);
    LangOfLogo.AddKrLogo(builder, kr_logoOffset);
    LangOfLogo.AddZhHantLogo(builder, zh_hant_logoOffset);
    LangOfLogo.AddJpLogo(builder, jp_logoOffset);
    LangOfLogo.AddEnLogo(builder, en_logoOffset);
    LangOfLogo.AddZhHansLogo(builder, zh_hans_logoOffset);
    LangOfLogo.AddName(builder, nameOffset);
    return LangOfLogo.EndLangOfLogo(builder);
  }

  public static void StartLangOfLogo(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddZhHansLogo(FlatBufferBuilder builder, StringOffset zhHansLogoOffset) { builder.AddOffset(1, zhHansLogoOffset.Value, 0); }
  public static void AddEnLogo(FlatBufferBuilder builder, StringOffset enLogoOffset) { builder.AddOffset(2, enLogoOffset.Value, 0); }
  public static void AddJpLogo(FlatBufferBuilder builder, StringOffset jpLogoOffset) { builder.AddOffset(3, jpLogoOffset.Value, 0); }
  public static void AddZhHantLogo(FlatBufferBuilder builder, StringOffset zhHantLogoOffset) { builder.AddOffset(4, zhHantLogoOffset.Value, 0); }
  public static void AddKrLogo(FlatBufferBuilder builder, StringOffset krLogoOffset) { builder.AddOffset(5, krLogoOffset.Value, 0); }
  public static Offset<WWParser.Defs.LangOfLogo> EndLangOfLogo(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.LangOfLogo>(o);
  }
  public LangOfLogoT UnPack() {
    var _o = new LangOfLogoT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LangOfLogoT _o) {
    _o.Name = this.Name;
    _o.ZhHansLogo = this.ZhHansLogo;
    _o.EnLogo = this.EnLogo;
    _o.JpLogo = this.JpLogo;
    _o.ZhHantLogo = this.ZhHantLogo;
    _o.KrLogo = this.KrLogo;
  }
  public static Offset<WWParser.Defs.LangOfLogo> Pack(FlatBufferBuilder builder, LangOfLogoT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.LangOfLogo>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _zh_hans_logo = _o.ZhHansLogo == null ? default(StringOffset) : builder.CreateString(_o.ZhHansLogo);
    var _en_logo = _o.EnLogo == null ? default(StringOffset) : builder.CreateString(_o.EnLogo);
    var _jp_logo = _o.JpLogo == null ? default(StringOffset) : builder.CreateString(_o.JpLogo);
    var _zh_hant_logo = _o.ZhHantLogo == null ? default(StringOffset) : builder.CreateString(_o.ZhHantLogo);
    var _kr_logo = _o.KrLogo == null ? default(StringOffset) : builder.CreateString(_o.KrLogo);
    return CreateLangOfLogo(
      builder,
      _name,
      _zh_hans_logo,
      _en_logo,
      _jp_logo,
      _zh_hant_logo,
      _kr_logo);
  }
}

public class LangOfLogoT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("zh_hans_logo")]
  public string ZhHansLogo { get; set; }
  [Newtonsoft.Json.JsonProperty("en_logo")]
  public string EnLogo { get; set; }
  [Newtonsoft.Json.JsonProperty("jp_logo")]
  public string JpLogo { get; set; }
  [Newtonsoft.Json.JsonProperty("zh_hant_logo")]
  public string ZhHantLogo { get; set; }
  [Newtonsoft.Json.JsonProperty("kr_logo")]
  public string KrLogo { get; set; }

  public LangOfLogoT() {
    this.Name = null;
    this.ZhHansLogo = null;
    this.EnLogo = null;
    this.JpLogo = null;
    this.ZhHantLogo = null;
    this.KrLogo = null;
  }
}


static public class LangOfLogoVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Name*/, false)
      && verifier.VerifyString(tablePos, 6 /*ZhHansLogo*/, false)
      && verifier.VerifyString(tablePos, 8 /*EnLogo*/, false)
      && verifier.VerifyString(tablePos, 10 /*JpLogo*/, false)
      && verifier.VerifyString(tablePos, 12 /*ZhHantLogo*/, false)
      && verifier.VerifyString(tablePos, 14 /*KrLogo*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
