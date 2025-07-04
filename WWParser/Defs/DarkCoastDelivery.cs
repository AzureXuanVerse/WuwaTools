// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct DarkCoastDelivery : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static DarkCoastDelivery GetRootAsDarkCoastDelivery(ByteBuffer _bb) { return GetRootAsDarkCoastDelivery(_bb, new DarkCoastDelivery()); }
  public static DarkCoastDelivery GetRootAsDarkCoastDelivery(ByteBuffer _bb, DarkCoastDelivery obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DarkCoastDelivery __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Icon { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(6); }
  public string LevelTexture { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLevelTextureBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetLevelTextureBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetLevelTextureArray() { return __p.__vector_as_array<byte>(8); }
  public string LevelIcon { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLevelIconBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetLevelIconBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetLevelIconArray() { return __p.__vector_as_array<byte>(10); }
  public string LevelSelectIcon { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLevelSelectIconBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetLevelSelectIconBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetLevelSelectIconArray() { return __p.__vector_as_array<byte>(12); }
  public string TipIcon { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTipIconBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetTipIconBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetTipIconArray() { return __p.__vector_as_array<byte>(14); }
  public string TipLockIcon { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTipLockIconBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetTipLockIconBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetTipLockIconArray() { return __p.__vector_as_array<byte>(16); }
  public string TipName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTipNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetTipNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetTipNameArray() { return __p.__vector_as_array<byte>(18); }
  public string TipDesc { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTipDescBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetTipDescBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetTipDescArray() { return __p.__vector_as_array<byte>(20); }
  public int RewardCount { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string UnlockCondition { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnlockConditionBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetUnlockConditionBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetUnlockConditionArray() { return __p.__vector_as_array<byte>(24); }
  public string VisionTexture { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVisionTextureBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetVisionTextureBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetVisionTextureArray() { return __p.__vector_as_array<byte>(26); }
  public int JumpId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int LevelPlayId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.DarkCoastDelivery> CreateDarkCoastDelivery(FlatBufferBuilder builder,
      int id = 0,
      StringOffset iconOffset = default(StringOffset),
      StringOffset level_textureOffset = default(StringOffset),
      StringOffset level_iconOffset = default(StringOffset),
      StringOffset level_select_iconOffset = default(StringOffset),
      StringOffset tip_iconOffset = default(StringOffset),
      StringOffset tip_lock_iconOffset = default(StringOffset),
      StringOffset tip_nameOffset = default(StringOffset),
      StringOffset tip_descOffset = default(StringOffset),
      int reward_count = 0,
      StringOffset unlock_conditionOffset = default(StringOffset),
      StringOffset vision_textureOffset = default(StringOffset),
      int jump_id = 0,
      int level_play_id = 0) {
    builder.StartTable(14);
    DarkCoastDelivery.AddLevelPlayId(builder, level_play_id);
    DarkCoastDelivery.AddJumpId(builder, jump_id);
    DarkCoastDelivery.AddVisionTexture(builder, vision_textureOffset);
    DarkCoastDelivery.AddUnlockCondition(builder, unlock_conditionOffset);
    DarkCoastDelivery.AddRewardCount(builder, reward_count);
    DarkCoastDelivery.AddTipDesc(builder, tip_descOffset);
    DarkCoastDelivery.AddTipName(builder, tip_nameOffset);
    DarkCoastDelivery.AddTipLockIcon(builder, tip_lock_iconOffset);
    DarkCoastDelivery.AddTipIcon(builder, tip_iconOffset);
    DarkCoastDelivery.AddLevelSelectIcon(builder, level_select_iconOffset);
    DarkCoastDelivery.AddLevelIcon(builder, level_iconOffset);
    DarkCoastDelivery.AddLevelTexture(builder, level_textureOffset);
    DarkCoastDelivery.AddIcon(builder, iconOffset);
    DarkCoastDelivery.AddId(builder, id);
    return DarkCoastDelivery.EndDarkCoastDelivery(builder);
  }

  public static void StartDarkCoastDelivery(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(1, iconOffset.Value, 0); }
  public static void AddLevelTexture(FlatBufferBuilder builder, StringOffset levelTextureOffset) { builder.AddOffset(2, levelTextureOffset.Value, 0); }
  public static void AddLevelIcon(FlatBufferBuilder builder, StringOffset levelIconOffset) { builder.AddOffset(3, levelIconOffset.Value, 0); }
  public static void AddLevelSelectIcon(FlatBufferBuilder builder, StringOffset levelSelectIconOffset) { builder.AddOffset(4, levelSelectIconOffset.Value, 0); }
  public static void AddTipIcon(FlatBufferBuilder builder, StringOffset tipIconOffset) { builder.AddOffset(5, tipIconOffset.Value, 0); }
  public static void AddTipLockIcon(FlatBufferBuilder builder, StringOffset tipLockIconOffset) { builder.AddOffset(6, tipLockIconOffset.Value, 0); }
  public static void AddTipName(FlatBufferBuilder builder, StringOffset tipNameOffset) { builder.AddOffset(7, tipNameOffset.Value, 0); }
  public static void AddTipDesc(FlatBufferBuilder builder, StringOffset tipDescOffset) { builder.AddOffset(8, tipDescOffset.Value, 0); }
  public static void AddRewardCount(FlatBufferBuilder builder, int rewardCount) { builder.AddInt(9, rewardCount, 0); }
  public static void AddUnlockCondition(FlatBufferBuilder builder, StringOffset unlockConditionOffset) { builder.AddOffset(10, unlockConditionOffset.Value, 0); }
  public static void AddVisionTexture(FlatBufferBuilder builder, StringOffset visionTextureOffset) { builder.AddOffset(11, visionTextureOffset.Value, 0); }
  public static void AddJumpId(FlatBufferBuilder builder, int jumpId) { builder.AddInt(12, jumpId, 0); }
  public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId) { builder.AddInt(13, levelPlayId, 0); }
  public static Offset<WWParser.Defs.DarkCoastDelivery> EndDarkCoastDelivery(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.DarkCoastDelivery>(o);
  }
  public DarkCoastDeliveryT UnPack() {
    var _o = new DarkCoastDeliveryT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(DarkCoastDeliveryT _o) {
    _o.Id = this.Id;
    _o.Icon = this.Icon;
    _o.LevelTexture = this.LevelTexture;
    _o.LevelIcon = this.LevelIcon;
    _o.LevelSelectIcon = this.LevelSelectIcon;
    _o.TipIcon = this.TipIcon;
    _o.TipLockIcon = this.TipLockIcon;
    _o.TipName = this.TipName;
    _o.TipDesc = this.TipDesc;
    _o.RewardCount = this.RewardCount;
    _o.UnlockCondition = this.UnlockCondition;
    _o.VisionTexture = this.VisionTexture;
    _o.JumpId = this.JumpId;
    _o.LevelPlayId = this.LevelPlayId;
  }
  public static Offset<WWParser.Defs.DarkCoastDelivery> Pack(FlatBufferBuilder builder, DarkCoastDeliveryT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.DarkCoastDelivery>);
    var _icon = _o.Icon == null ? default(StringOffset) : builder.CreateString(_o.Icon);
    var _level_texture = _o.LevelTexture == null ? default(StringOffset) : builder.CreateString(_o.LevelTexture);
    var _level_icon = _o.LevelIcon == null ? default(StringOffset) : builder.CreateString(_o.LevelIcon);
    var _level_select_icon = _o.LevelSelectIcon == null ? default(StringOffset) : builder.CreateString(_o.LevelSelectIcon);
    var _tip_icon = _o.TipIcon == null ? default(StringOffset) : builder.CreateString(_o.TipIcon);
    var _tip_lock_icon = _o.TipLockIcon == null ? default(StringOffset) : builder.CreateString(_o.TipLockIcon);
    var _tip_name = _o.TipName == null ? default(StringOffset) : builder.CreateString(_o.TipName);
    var _tip_desc = _o.TipDesc == null ? default(StringOffset) : builder.CreateString(_o.TipDesc);
    var _unlock_condition = _o.UnlockCondition == null ? default(StringOffset) : builder.CreateString(_o.UnlockCondition);
    var _vision_texture = _o.VisionTexture == null ? default(StringOffset) : builder.CreateString(_o.VisionTexture);
    return CreateDarkCoastDelivery(
      builder,
      _o.Id,
      _icon,
      _level_texture,
      _level_icon,
      _level_select_icon,
      _tip_icon,
      _tip_lock_icon,
      _tip_name,
      _tip_desc,
      _o.RewardCount,
      _unlock_condition,
      _vision_texture,
      _o.JumpId,
      _o.LevelPlayId);
  }
}

public class DarkCoastDeliveryT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("icon")]
  public string Icon { get; set; }
  [Newtonsoft.Json.JsonProperty("level_texture")]
  public string LevelTexture { get; set; }
  [Newtonsoft.Json.JsonProperty("level_icon")]
  public string LevelIcon { get; set; }
  [Newtonsoft.Json.JsonProperty("level_select_icon")]
  public string LevelSelectIcon { get; set; }
  [Newtonsoft.Json.JsonProperty("tip_icon")]
  public string TipIcon { get; set; }
  [Newtonsoft.Json.JsonProperty("tip_lock_icon")]
  public string TipLockIcon { get; set; }
  [Newtonsoft.Json.JsonProperty("tip_name")]
  public string TipName { get; set; }
  [Newtonsoft.Json.JsonProperty("tip_desc")]
  public string TipDesc { get; set; }
  [Newtonsoft.Json.JsonProperty("reward_count")]
  public int RewardCount { get; set; }
  [Newtonsoft.Json.JsonProperty("unlock_condition")]
  public string UnlockCondition { get; set; }
  [Newtonsoft.Json.JsonProperty("vision_texture")]
  public string VisionTexture { get; set; }
  [Newtonsoft.Json.JsonProperty("jump_id")]
  public int JumpId { get; set; }
  [Newtonsoft.Json.JsonProperty("level_play_id")]
  public int LevelPlayId { get; set; }

  public DarkCoastDeliveryT() {
    this.Id = 0;
    this.Icon = null;
    this.LevelTexture = null;
    this.LevelIcon = null;
    this.LevelSelectIcon = null;
    this.TipIcon = null;
    this.TipLockIcon = null;
    this.TipName = null;
    this.TipDesc = null;
    this.RewardCount = 0;
    this.UnlockCondition = null;
    this.VisionTexture = null;
    this.JumpId = 0;
    this.LevelPlayId = 0;
  }
}


static public class DarkCoastDeliveryVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*Icon*/, false)
      && verifier.VerifyString(tablePos, 8 /*LevelTexture*/, false)
      && verifier.VerifyString(tablePos, 10 /*LevelIcon*/, false)
      && verifier.VerifyString(tablePos, 12 /*LevelSelectIcon*/, false)
      && verifier.VerifyString(tablePos, 14 /*TipIcon*/, false)
      && verifier.VerifyString(tablePos, 16 /*TipLockIcon*/, false)
      && verifier.VerifyString(tablePos, 18 /*TipName*/, false)
      && verifier.VerifyString(tablePos, 20 /*TipDesc*/, false)
      && verifier.VerifyField(tablePos, 22 /*RewardCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 24 /*UnlockCondition*/, false)
      && verifier.VerifyString(tablePos, 26 /*VisionTexture*/, false)
      && verifier.VerifyField(tablePos, 28 /*JumpId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*LevelPlayId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
