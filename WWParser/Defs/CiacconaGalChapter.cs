// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CiacconaGalChapter : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static CiacconaGalChapter GetRootAsCiacconaGalChapter(ByteBuffer _bb) { return GetRootAsCiacconaGalChapter(_bb, new CiacconaGalChapter()); }
  public static CiacconaGalChapter GetRootAsCiacconaGalChapter(ByteBuffer _bb, CiacconaGalChapter obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CiacconaGalChapter __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Title { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTitleBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTitleBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTitleArray() { return __p.__vector_as_array<byte>(6); }
  public string Desc { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDescBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescArray() { return __p.__vector_as_array<byte>(8); }
  public int Steps(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int StepsLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetStepsBytes() { return __p.__vector_as_span<int>(10, 4); }
#else
  public ArraySegment<byte>? GetStepsBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public int[] GetStepsArray() { return __p.__vector_as_array<int>(10); }
  public string ChapterImageSmall { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetChapterImageSmallBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetChapterImageSmallBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetChapterImageSmallArray() { return __p.__vector_as_array<byte>(12); }
  public string ChapterImageLarge { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetChapterImageLargeBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetChapterImageLargeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetChapterImageLargeArray() { return __p.__vector_as_array<byte>(14); }
  public string MusicEvent { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMusicEventBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetMusicEventBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetMusicEventArray() { return __p.__vector_as_array<byte>(16); }
  public int SubEnding1 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SubEnding2 { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SubEnding3 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BranchPoint { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.CiacconaGalChapter> CreateCiacconaGalChapter(FlatBufferBuilder builder,
      int id = 0,
      StringOffset titleOffset = default(StringOffset),
      StringOffset descOffset = default(StringOffset),
      VectorOffset stepsOffset = default(VectorOffset),
      StringOffset chapter_image_smallOffset = default(StringOffset),
      StringOffset chapter_image_largeOffset = default(StringOffset),
      StringOffset music_eventOffset = default(StringOffset),
      int sub_ending1 = 0,
      int sub_ending2 = 0,
      int sub_ending3 = 0,
      int branch_point = 0) {
    builder.StartTable(11);
    CiacconaGalChapter.AddBranchPoint(builder, branch_point);
    CiacconaGalChapter.AddSubEnding3(builder, sub_ending3);
    CiacconaGalChapter.AddSubEnding2(builder, sub_ending2);
    CiacconaGalChapter.AddSubEnding1(builder, sub_ending1);
    CiacconaGalChapter.AddMusicEvent(builder, music_eventOffset);
    CiacconaGalChapter.AddChapterImageLarge(builder, chapter_image_largeOffset);
    CiacconaGalChapter.AddChapterImageSmall(builder, chapter_image_smallOffset);
    CiacconaGalChapter.AddSteps(builder, stepsOffset);
    CiacconaGalChapter.AddDesc(builder, descOffset);
    CiacconaGalChapter.AddTitle(builder, titleOffset);
    CiacconaGalChapter.AddId(builder, id);
    return CiacconaGalChapter.EndCiacconaGalChapter(builder);
  }

  public static void StartCiacconaGalChapter(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddTitle(FlatBufferBuilder builder, StringOffset titleOffset) { builder.AddOffset(1, titleOffset.Value, 0); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset) { builder.AddOffset(2, descOffset.Value, 0); }
  public static void AddSteps(FlatBufferBuilder builder, VectorOffset stepsOffset) { builder.AddOffset(3, stepsOffset.Value, 0); }
  public static VectorOffset CreateStepsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStepsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStepsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddChapterImageSmall(FlatBufferBuilder builder, StringOffset chapterImageSmallOffset) { builder.AddOffset(4, chapterImageSmallOffset.Value, 0); }
  public static void AddChapterImageLarge(FlatBufferBuilder builder, StringOffset chapterImageLargeOffset) { builder.AddOffset(5, chapterImageLargeOffset.Value, 0); }
  public static void AddMusicEvent(FlatBufferBuilder builder, StringOffset musicEventOffset) { builder.AddOffset(6, musicEventOffset.Value, 0); }
  public static void AddSubEnding1(FlatBufferBuilder builder, int subEnding1) { builder.AddInt(7, subEnding1, 0); }
  public static void AddSubEnding2(FlatBufferBuilder builder, int subEnding2) { builder.AddInt(8, subEnding2, 0); }
  public static void AddSubEnding3(FlatBufferBuilder builder, int subEnding3) { builder.AddInt(9, subEnding3, 0); }
  public static void AddBranchPoint(FlatBufferBuilder builder, int branchPoint) { builder.AddInt(10, branchPoint, 0); }
  public static Offset<WWParser.Defs.CiacconaGalChapter> EndCiacconaGalChapter(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.CiacconaGalChapter>(o);
  }
  public CiacconaGalChapterT UnPack() {
    var _o = new CiacconaGalChapterT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CiacconaGalChapterT _o) {
    _o.Id = this.Id;
    _o.Title = this.Title;
    _o.Desc = this.Desc;
    _o.Steps = new List<int>();
    for (var _j = 0; _j < this.StepsLength; ++_j) {_o.Steps.Add(this.Steps(_j));}
    _o.ChapterImageSmall = this.ChapterImageSmall;
    _o.ChapterImageLarge = this.ChapterImageLarge;
    _o.MusicEvent = this.MusicEvent;
    _o.SubEnding1 = this.SubEnding1;
    _o.SubEnding2 = this.SubEnding2;
    _o.SubEnding3 = this.SubEnding3;
    _o.BranchPoint = this.BranchPoint;
  }
  public static Offset<WWParser.Defs.CiacconaGalChapter> Pack(FlatBufferBuilder builder, CiacconaGalChapterT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.CiacconaGalChapter>);
    var _title = _o.Title == null ? default(StringOffset) : builder.CreateString(_o.Title);
    var _desc = _o.Desc == null ? default(StringOffset) : builder.CreateString(_o.Desc);
    var _steps = default(VectorOffset);
    if (_o.Steps != null) {
      var __steps = _o.Steps.ToArray();
      _steps = CreateStepsVector(builder, __steps);
    }
    var _chapter_image_small = _o.ChapterImageSmall == null ? default(StringOffset) : builder.CreateString(_o.ChapterImageSmall);
    var _chapter_image_large = _o.ChapterImageLarge == null ? default(StringOffset) : builder.CreateString(_o.ChapterImageLarge);
    var _music_event = _o.MusicEvent == null ? default(StringOffset) : builder.CreateString(_o.MusicEvent);
    return CreateCiacconaGalChapter(
      builder,
      _o.Id,
      _title,
      _desc,
      _steps,
      _chapter_image_small,
      _chapter_image_large,
      _music_event,
      _o.SubEnding1,
      _o.SubEnding2,
      _o.SubEnding3,
      _o.BranchPoint);
  }
}

public class CiacconaGalChapterT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("title")]
  public string Title { get; set; }
  [Newtonsoft.Json.JsonProperty("desc")]
  public string Desc { get; set; }
  [Newtonsoft.Json.JsonProperty("steps")]
  public List<int> Steps { get; set; }
  [Newtonsoft.Json.JsonProperty("chapter_image_small")]
  public string ChapterImageSmall { get; set; }
  [Newtonsoft.Json.JsonProperty("chapter_image_large")]
  public string ChapterImageLarge { get; set; }
  [Newtonsoft.Json.JsonProperty("music_event")]
  public string MusicEvent { get; set; }
  [Newtonsoft.Json.JsonProperty("sub_ending1")]
  public int SubEnding1 { get; set; }
  [Newtonsoft.Json.JsonProperty("sub_ending2")]
  public int SubEnding2 { get; set; }
  [Newtonsoft.Json.JsonProperty("sub_ending3")]
  public int SubEnding3 { get; set; }
  [Newtonsoft.Json.JsonProperty("branch_point")]
  public int BranchPoint { get; set; }

  public CiacconaGalChapterT() {
    this.Id = 0;
    this.Title = null;
    this.Desc = null;
    this.Steps = null;
    this.ChapterImageSmall = null;
    this.ChapterImageLarge = null;
    this.MusicEvent = null;
    this.SubEnding1 = 0;
    this.SubEnding2 = 0;
    this.SubEnding3 = 0;
    this.BranchPoint = 0;
  }
}


static public class CiacconaGalChapterVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*Title*/, false)
      && verifier.VerifyString(tablePos, 8 /*Desc*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*Steps*/, 4 /*int*/, false)
      && verifier.VerifyString(tablePos, 12 /*ChapterImageSmall*/, false)
      && verifier.VerifyString(tablePos, 14 /*ChapterImageLarge*/, false)
      && verifier.VerifyString(tablePos, 16 /*MusicEvent*/, false)
      && verifier.VerifyField(tablePos, 18 /*SubEnding1*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*SubEnding2*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*SubEnding3*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*BranchPoint*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
