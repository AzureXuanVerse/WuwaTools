// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GuideGroup : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static GuideGroup GetRootAsGuideGroup(ByteBuffer _bb) { return GetRootAsGuideGroup(_bb, new GuideGroup()); }
  public static GuideGroup GetRootAsGuideGroup(ByteBuffer _bb, GuideGroup obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GuideGroup __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Step(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int StepLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetStepBytes() { return __p.__vector_as_span<int>(6, 4); }
#else
  public ArraySegment<byte>? GetStepBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public int[] GetStepArray() { return __p.__vector_as_array<int>(6); }
  public int OpenLimitCondition { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AutoOpenCondition { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int LimitRepeat(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int LimitRepeatLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetLimitRepeatBytes() { return __p.__vector_as_span<int>(12, 4); }
#else
  public ArraySegment<byte>? GetLimitRepeatBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public int[] GetLimitRepeatArray() { return __p.__vector_as_array<int>(12); }
  public int DungeonId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int DungeonIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetDungeonIdBytes() { return __p.__vector_as_span<int>(14, 4); }
#else
  public ArraySegment<byte>? GetDungeonIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public int[] GetDungeonIdArray() { return __p.__vector_as_array<int>(14); }
  public string DungeonSets(int j) { int o = __p.__offset(16); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int DungeonSetsLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool ResetInDungeon { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int OnlineMode { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)1; } }
  public int Priority { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.GuideGroup> CreateGuideGroup(FlatBufferBuilder builder,
      int id = 0,
      VectorOffset stepOffset = default(VectorOffset),
      int open_limit_condition = 0,
      int auto_open_condition = 0,
      VectorOffset limit_repeatOffset = default(VectorOffset),
      VectorOffset dungeon_idOffset = default(VectorOffset),
      VectorOffset dungeon_setsOffset = default(VectorOffset),
      bool reset_in_dungeon = false,
      int online_mode = 1,
      int priority = 0) {
    builder.StartTable(10);
    GuideGroup.AddPriority(builder, priority);
    GuideGroup.AddOnlineMode(builder, online_mode);
    GuideGroup.AddDungeonSets(builder, dungeon_setsOffset);
    GuideGroup.AddDungeonId(builder, dungeon_idOffset);
    GuideGroup.AddLimitRepeat(builder, limit_repeatOffset);
    GuideGroup.AddAutoOpenCondition(builder, auto_open_condition);
    GuideGroup.AddOpenLimitCondition(builder, open_limit_condition);
    GuideGroup.AddStep(builder, stepOffset);
    GuideGroup.AddId(builder, id);
    GuideGroup.AddResetInDungeon(builder, reset_in_dungeon);
    return GuideGroup.EndGuideGroup(builder);
  }

  public static void StartGuideGroup(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddStep(FlatBufferBuilder builder, VectorOffset stepOffset) { builder.AddOffset(1, stepOffset.Value, 0); }
  public static VectorOffset CreateStepVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStepVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStepVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOpenLimitCondition(FlatBufferBuilder builder, int openLimitCondition) { builder.AddInt(2, openLimitCondition, 0); }
  public static void AddAutoOpenCondition(FlatBufferBuilder builder, int autoOpenCondition) { builder.AddInt(3, autoOpenCondition, 0); }
  public static void AddLimitRepeat(FlatBufferBuilder builder, VectorOffset limitRepeatOffset) { builder.AddOffset(4, limitRepeatOffset.Value, 0); }
  public static VectorOffset CreateLimitRepeatVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateLimitRepeatVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLimitRepeatVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLimitRepeatVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLimitRepeatVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDungeonId(FlatBufferBuilder builder, VectorOffset dungeonIdOffset) { builder.AddOffset(5, dungeonIdOffset.Value, 0); }
  public static VectorOffset CreateDungeonIdVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDungeonIdVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDungeonIdVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDungeonIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDungeonIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDungeonSets(FlatBufferBuilder builder, VectorOffset dungeonSetsOffset) { builder.AddOffset(6, dungeonSetsOffset.Value, 0); }
  public static VectorOffset CreateDungeonSetsVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDungeonSetsVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDungeonSetsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDungeonSetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDungeonSetsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddResetInDungeon(FlatBufferBuilder builder, bool resetInDungeon) { builder.AddBool(7, resetInDungeon, false); }
  public static void AddOnlineMode(FlatBufferBuilder builder, int onlineMode) { builder.AddInt(8, onlineMode, 1); }
  public static void AddPriority(FlatBufferBuilder builder, int priority) { builder.AddInt(9, priority, 0); }
  public static Offset<WWParser.Defs.GuideGroup> EndGuideGroup(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.GuideGroup>(o);
  }
  public GuideGroupT UnPack() {
    var _o = new GuideGroupT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GuideGroupT _o) {
    _o.Id = this.Id;
    _o.Step = new List<int>();
    for (var _j = 0; _j < this.StepLength; ++_j) {_o.Step.Add(this.Step(_j));}
    _o.OpenLimitCondition = this.OpenLimitCondition;
    _o.AutoOpenCondition = this.AutoOpenCondition;
    _o.LimitRepeat = new List<int>();
    for (var _j = 0; _j < this.LimitRepeatLength; ++_j) {_o.LimitRepeat.Add(this.LimitRepeat(_j));}
    _o.DungeonId = new List<int>();
    for (var _j = 0; _j < this.DungeonIdLength; ++_j) {_o.DungeonId.Add(this.DungeonId(_j));}
    _o.DungeonSets = new List<string>();
    for (var _j = 0; _j < this.DungeonSetsLength; ++_j) {_o.DungeonSets.Add(this.DungeonSets(_j));}
    _o.ResetInDungeon = this.ResetInDungeon;
    _o.OnlineMode = this.OnlineMode;
    _o.Priority = this.Priority;
  }
  public static Offset<WWParser.Defs.GuideGroup> Pack(FlatBufferBuilder builder, GuideGroupT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.GuideGroup>);
    var _step = default(VectorOffset);
    if (_o.Step != null) {
      var __step = _o.Step.ToArray();
      _step = CreateStepVector(builder, __step);
    }
    var _limit_repeat = default(VectorOffset);
    if (_o.LimitRepeat != null) {
      var __limit_repeat = _o.LimitRepeat.ToArray();
      _limit_repeat = CreateLimitRepeatVector(builder, __limit_repeat);
    }
    var _dungeon_id = default(VectorOffset);
    if (_o.DungeonId != null) {
      var __dungeon_id = _o.DungeonId.ToArray();
      _dungeon_id = CreateDungeonIdVector(builder, __dungeon_id);
    }
    var _dungeon_sets = default(VectorOffset);
    if (_o.DungeonSets != null) {
      var __dungeon_sets = new StringOffset[_o.DungeonSets.Count];
      for (var _j = 0; _j < __dungeon_sets.Length; ++_j) { __dungeon_sets[_j] = builder.CreateString(_o.DungeonSets[_j]); }
      _dungeon_sets = CreateDungeonSetsVector(builder, __dungeon_sets);
    }
    return CreateGuideGroup(
      builder,
      _o.Id,
      _step,
      _o.OpenLimitCondition,
      _o.AutoOpenCondition,
      _limit_repeat,
      _dungeon_id,
      _dungeon_sets,
      _o.ResetInDungeon,
      _o.OnlineMode,
      _o.Priority);
  }
}

public class GuideGroupT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("step")]
  public List<int> Step { get; set; }
  [Newtonsoft.Json.JsonProperty("open_limit_condition")]
  public int OpenLimitCondition { get; set; }
  [Newtonsoft.Json.JsonProperty("auto_open_condition")]
  public int AutoOpenCondition { get; set; }
  [Newtonsoft.Json.JsonProperty("limit_repeat")]
  public List<int> LimitRepeat { get; set; }
  [Newtonsoft.Json.JsonProperty("dungeon_id")]
  public List<int> DungeonId { get; set; }
  [Newtonsoft.Json.JsonProperty("dungeon_sets")]
  public List<string> DungeonSets { get; set; }
  [Newtonsoft.Json.JsonProperty("reset_in_dungeon")]
  public bool ResetInDungeon { get; set; }
  [Newtonsoft.Json.JsonProperty("online_mode")]
  public int OnlineMode { get; set; }
  [Newtonsoft.Json.JsonProperty("priority")]
  public int Priority { get; set; }

  public GuideGroupT() {
    this.Id = 0;
    this.Step = null;
    this.OpenLimitCondition = 0;
    this.AutoOpenCondition = 0;
    this.LimitRepeat = null;
    this.DungeonId = null;
    this.DungeonSets = null;
    this.ResetInDungeon = false;
    this.OnlineMode = 1;
    this.Priority = 0;
  }
}


static public class GuideGroupVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*Step*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 8 /*OpenLimitCondition*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*AutoOpenCondition*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*LimitRepeat*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*DungeonId*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 16 /*DungeonSets*/, false)
      && verifier.VerifyField(tablePos, 18 /*ResetInDungeon*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 20 /*OnlineMode*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*Priority*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
