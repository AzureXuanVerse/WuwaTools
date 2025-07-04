// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AreaReport : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static AreaReport GetRootAsAreaReport(ByteBuffer _bb) { return GetRootAsAreaReport(_bb, new AreaReport()); }
  public static AreaReport GetRootAsAreaReport(ByteBuffer _bb, AreaReport obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AreaReport __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AreaId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Stage { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Content { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetContentBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetContentBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetContentArray() { return __p.__vector_as_array<byte>(10); }
  public int Unlock { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string LockText { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLockTextBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetLockTextBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetLockTextArray() { return __p.__vector_as_array<byte>(14); }
  public string PicResource { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPicResourceBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetPicResourceBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetPicResourceArray() { return __p.__vector_as_array<byte>(16); }
  public string StageTitle { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStageTitleBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetStageTitleBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetStageTitleArray() { return __p.__vector_as_array<byte>(18); }

  public static Offset<WWParser.Defs.AreaReport> CreateAreaReport(FlatBufferBuilder builder,
      int id = 0,
      int area_id = 0,
      int stage = 0,
      StringOffset contentOffset = default(StringOffset),
      int unlock = 0,
      StringOffset lock_textOffset = default(StringOffset),
      StringOffset pic_resourceOffset = default(StringOffset),
      StringOffset stage_titleOffset = default(StringOffset)) {
    builder.StartTable(8);
    AreaReport.AddStageTitle(builder, stage_titleOffset);
    AreaReport.AddPicResource(builder, pic_resourceOffset);
    AreaReport.AddLockText(builder, lock_textOffset);
    AreaReport.AddUnlock(builder, unlock);
    AreaReport.AddContent(builder, contentOffset);
    AreaReport.AddStage(builder, stage);
    AreaReport.AddAreaId(builder, area_id);
    AreaReport.AddId(builder, id);
    return AreaReport.EndAreaReport(builder);
  }

  public static void StartAreaReport(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddAreaId(FlatBufferBuilder builder, int areaId) { builder.AddInt(1, areaId, 0); }
  public static void AddStage(FlatBufferBuilder builder, int stage) { builder.AddInt(2, stage, 0); }
  public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset) { builder.AddOffset(3, contentOffset.Value, 0); }
  public static void AddUnlock(FlatBufferBuilder builder, int unlock) { builder.AddInt(4, unlock, 0); }
  public static void AddLockText(FlatBufferBuilder builder, StringOffset lockTextOffset) { builder.AddOffset(5, lockTextOffset.Value, 0); }
  public static void AddPicResource(FlatBufferBuilder builder, StringOffset picResourceOffset) { builder.AddOffset(6, picResourceOffset.Value, 0); }
  public static void AddStageTitle(FlatBufferBuilder builder, StringOffset stageTitleOffset) { builder.AddOffset(7, stageTitleOffset.Value, 0); }
  public static Offset<WWParser.Defs.AreaReport> EndAreaReport(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.AreaReport>(o);
  }
  public AreaReportT UnPack() {
    var _o = new AreaReportT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AreaReportT _o) {
    _o.Id = this.Id;
    _o.AreaId = this.AreaId;
    _o.Stage = this.Stage;
    _o.Content = this.Content;
    _o.Unlock = this.Unlock;
    _o.LockText = this.LockText;
    _o.PicResource = this.PicResource;
    _o.StageTitle = this.StageTitle;
  }
  public static Offset<WWParser.Defs.AreaReport> Pack(FlatBufferBuilder builder, AreaReportT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.AreaReport>);
    var _content = _o.Content == null ? default(StringOffset) : builder.CreateString(_o.Content);
    var _lock_text = _o.LockText == null ? default(StringOffset) : builder.CreateString(_o.LockText);
    var _pic_resource = _o.PicResource == null ? default(StringOffset) : builder.CreateString(_o.PicResource);
    var _stage_title = _o.StageTitle == null ? default(StringOffset) : builder.CreateString(_o.StageTitle);
    return CreateAreaReport(
      builder,
      _o.Id,
      _o.AreaId,
      _o.Stage,
      _content,
      _o.Unlock,
      _lock_text,
      _pic_resource,
      _stage_title);
  }
}

public class AreaReportT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("area_id")]
  public int AreaId { get; set; }
  [Newtonsoft.Json.JsonProperty("stage")]
  public int Stage { get; set; }
  [Newtonsoft.Json.JsonProperty("content")]
  public string Content { get; set; }
  [Newtonsoft.Json.JsonProperty("unlock")]
  public int Unlock { get; set; }
  [Newtonsoft.Json.JsonProperty("lock_text")]
  public string LockText { get; set; }
  [Newtonsoft.Json.JsonProperty("pic_resource")]
  public string PicResource { get; set; }
  [Newtonsoft.Json.JsonProperty("stage_title")]
  public string StageTitle { get; set; }

  public AreaReportT() {
    this.Id = 0;
    this.AreaId = 0;
    this.Stage = 0;
    this.Content = null;
    this.Unlock = 0;
    this.LockText = null;
    this.PicResource = null;
    this.StageTitle = null;
  }
}


static public class AreaReportVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*AreaId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Stage*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*Content*/, false)
      && verifier.VerifyField(tablePos, 12 /*Unlock*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 14 /*LockText*/, false)
      && verifier.VerifyString(tablePos, 16 /*PicResource*/, false)
      && verifier.VerifyString(tablePos, 18 /*StageTitle*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
