// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ParkourChallenge : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static ParkourChallenge GetRootAsParkourChallenge(ByteBuffer _bb) { return GetRootAsParkourChallenge(_bb, new ParkourChallenge()); }
  public static ParkourChallenge GetRootAsParkourChallenge(ByteBuffer _bb, ParkourChallenge obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ParkourChallenge __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MarkId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BackGroundTexture { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBackGroundTextureBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetBackGroundTextureBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetBackGroundTextureArray() { return __p.__vector_as_array<byte>(8); }
  public string Title { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTitleBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetTitleBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetTitleArray() { return __p.__vector_as_array<byte>(10); }
  public int LevelPlayId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public WWParser.Defs.DicIntInt? Rewards(int j) { int o = __p.__offset(14); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RewardsLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public WWParser.Defs.IntPair? RewardList(int j) { int o = __p.__offset(16); return o != 0 ? (WWParser.Defs.IntPair?)(new WWParser.Defs.IntPair()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RewardListLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int LocationEntityConfigId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.ParkourChallenge> CreateParkourChallenge(FlatBufferBuilder builder,
      int id = 0,
      int mark_id = 0,
      StringOffset back_ground_textureOffset = default(StringOffset),
      StringOffset titleOffset = default(StringOffset),
      int level_play_id = 0,
      VectorOffset rewardsOffset = default(VectorOffset),
      VectorOffset reward_listOffset = default(VectorOffset),
      int location_entity_config_id = 0) {
    builder.StartTable(8);
    ParkourChallenge.AddLocationEntityConfigId(builder, location_entity_config_id);
    ParkourChallenge.AddRewardList(builder, reward_listOffset);
    ParkourChallenge.AddRewards(builder, rewardsOffset);
    ParkourChallenge.AddLevelPlayId(builder, level_play_id);
    ParkourChallenge.AddTitle(builder, titleOffset);
    ParkourChallenge.AddBackGroundTexture(builder, back_ground_textureOffset);
    ParkourChallenge.AddMarkId(builder, mark_id);
    ParkourChallenge.AddId(builder, id);
    return ParkourChallenge.EndParkourChallenge(builder);
  }

  public static void StartParkourChallenge(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddMarkId(FlatBufferBuilder builder, int markId) { builder.AddInt(1, markId, 0); }
  public static void AddBackGroundTexture(FlatBufferBuilder builder, StringOffset backGroundTextureOffset) { builder.AddOffset(2, backGroundTextureOffset.Value, 0); }
  public static void AddTitle(FlatBufferBuilder builder, StringOffset titleOffset) { builder.AddOffset(3, titleOffset.Value, 0); }
  public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId) { builder.AddInt(4, levelPlayId, 0); }
  public static void AddRewards(FlatBufferBuilder builder, VectorOffset rewardsOffset) { builder.AddOffset(5, rewardsOffset.Value, 0); }
  public static VectorOffset CreateRewardsVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRewardsVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardList(FlatBufferBuilder builder, VectorOffset rewardListOffset) { builder.AddOffset(6, rewardListOffset.Value, 0); }
  public static VectorOffset CreateRewardListVector(FlatBufferBuilder builder, Offset<WWParser.Defs.IntPair>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRewardListVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.IntPair>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.IntPair>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.IntPair>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLocationEntityConfigId(FlatBufferBuilder builder, int locationEntityConfigId) { builder.AddInt(7, locationEntityConfigId, 0); }
  public static Offset<WWParser.Defs.ParkourChallenge> EndParkourChallenge(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.ParkourChallenge>(o);
  }
  public ParkourChallengeT UnPack() {
    var _o = new ParkourChallengeT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ParkourChallengeT _o) {
    _o.Id = this.Id;
    _o.MarkId = this.MarkId;
    _o.BackGroundTexture = this.BackGroundTexture;
    _o.Title = this.Title;
    _o.LevelPlayId = this.LevelPlayId;
    _o.Rewards = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.RewardsLength; ++_j) {_o.Rewards.Add(this.Rewards(_j).HasValue ? this.Rewards(_j).Value.UnPack() : null);}
    _o.RewardList = new List<WWParser.Defs.IntPairT>();
    for (var _j = 0; _j < this.RewardListLength; ++_j) {_o.RewardList.Add(this.RewardList(_j).HasValue ? this.RewardList(_j).Value.UnPack() : null);}
    _o.LocationEntityConfigId = this.LocationEntityConfigId;
  }
  public static Offset<WWParser.Defs.ParkourChallenge> Pack(FlatBufferBuilder builder, ParkourChallengeT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.ParkourChallenge>);
    var _back_ground_texture = _o.BackGroundTexture == null ? default(StringOffset) : builder.CreateString(_o.BackGroundTexture);
    var _title = _o.Title == null ? default(StringOffset) : builder.CreateString(_o.Title);
    var _rewards = default(VectorOffset);
    if (_o.Rewards != null) {
      var __rewards = new Offset<WWParser.Defs.DicIntInt>[_o.Rewards.Count];
      for (var _j = 0; _j < __rewards.Length; ++_j) { __rewards[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.Rewards[_j]); }
      _rewards = CreateRewardsVector(builder, __rewards);
    }
    var _reward_list = default(VectorOffset);
    if (_o.RewardList != null) {
      var __reward_list = new Offset<WWParser.Defs.IntPair>[_o.RewardList.Count];
      for (var _j = 0; _j < __reward_list.Length; ++_j) { __reward_list[_j] = WWParser.Defs.IntPair.Pack(builder, _o.RewardList[_j]); }
      _reward_list = CreateRewardListVector(builder, __reward_list);
    }
    return CreateParkourChallenge(
      builder,
      _o.Id,
      _o.MarkId,
      _back_ground_texture,
      _title,
      _o.LevelPlayId,
      _rewards,
      _reward_list,
      _o.LocationEntityConfigId);
  }
}

public class ParkourChallengeT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("mark_id")]
  public int MarkId { get; set; }
  [Newtonsoft.Json.JsonProperty("back_ground_texture")]
  public string BackGroundTexture { get; set; }
  [Newtonsoft.Json.JsonProperty("title")]
  public string Title { get; set; }
  [Newtonsoft.Json.JsonProperty("level_play_id")]
  public int LevelPlayId { get; set; }
  [Newtonsoft.Json.JsonProperty("rewards")]
  public List<WWParser.Defs.DicIntIntT> Rewards { get; set; }
  [Newtonsoft.Json.JsonProperty("reward_list")]
  public List<WWParser.Defs.IntPairT> RewardList { get; set; }
  [Newtonsoft.Json.JsonProperty("location_entity_config_id")]
  public int LocationEntityConfigId { get; set; }

  public ParkourChallengeT() {
    this.Id = 0;
    this.MarkId = 0;
    this.BackGroundTexture = null;
    this.Title = null;
    this.LevelPlayId = 0;
    this.Rewards = null;
    this.RewardList = null;
    this.LocationEntityConfigId = 0;
  }
}


static public class ParkourChallengeVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*MarkId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*BackGroundTexture*/, false)
      && verifier.VerifyString(tablePos, 10 /*Title*/, false)
      && verifier.VerifyField(tablePos, 12 /*LevelPlayId*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 14 /*Rewards*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 16 /*RewardList*/, WWParser.Defs.IntPairVerify.Verify, false)
      && verifier.VerifyField(tablePos, 18 /*LocationEntityConfigId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
