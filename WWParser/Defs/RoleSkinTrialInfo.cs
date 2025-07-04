// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RoleSkinTrialInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RoleSkinTrialInfo GetRootAsRoleSkinTrialInfo(ByteBuffer _bb) { return GetRootAsRoleSkinTrialInfo(_bb, new RoleSkinTrialInfo()); }
  public static RoleSkinTrialInfo GetRootAsRoleSkinTrialInfo(ByteBuffer _bb, RoleSkinTrialInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RoleSkinTrialInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RoleId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TrialRoleId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PreviewSkinId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int InstanceId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AccessId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DropId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string RoleIcon { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRoleIconBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetRoleIconBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetRoleIconArray() { return __p.__vector_as_array<byte>(18); }
  public string Introduction { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIntroductionBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetIntroductionBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetIntroductionArray() { return __p.__vector_as_array<byte>(20); }
  public int UiConfigId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.RoleSkinTrialInfo> CreateRoleSkinTrialInfo(FlatBufferBuilder builder,
      int id = 0,
      int role_id = 0,
      int trial_role_id = 0,
      int preview_skin_id = 0,
      int instance_id = 0,
      int access_id = 0,
      int drop_id = 0,
      StringOffset role_iconOffset = default(StringOffset),
      StringOffset introductionOffset = default(StringOffset),
      int ui_config_id = 0) {
    builder.StartTable(10);
    RoleSkinTrialInfo.AddUiConfigId(builder, ui_config_id);
    RoleSkinTrialInfo.AddIntroduction(builder, introductionOffset);
    RoleSkinTrialInfo.AddRoleIcon(builder, role_iconOffset);
    RoleSkinTrialInfo.AddDropId(builder, drop_id);
    RoleSkinTrialInfo.AddAccessId(builder, access_id);
    RoleSkinTrialInfo.AddInstanceId(builder, instance_id);
    RoleSkinTrialInfo.AddPreviewSkinId(builder, preview_skin_id);
    RoleSkinTrialInfo.AddTrialRoleId(builder, trial_role_id);
    RoleSkinTrialInfo.AddRoleId(builder, role_id);
    RoleSkinTrialInfo.AddId(builder, id);
    return RoleSkinTrialInfo.EndRoleSkinTrialInfo(builder);
  }

  public static void StartRoleSkinTrialInfo(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddRoleId(FlatBufferBuilder builder, int roleId) { builder.AddInt(1, roleId, 0); }
  public static void AddTrialRoleId(FlatBufferBuilder builder, int trialRoleId) { builder.AddInt(2, trialRoleId, 0); }
  public static void AddPreviewSkinId(FlatBufferBuilder builder, int previewSkinId) { builder.AddInt(3, previewSkinId, 0); }
  public static void AddInstanceId(FlatBufferBuilder builder, int instanceId) { builder.AddInt(4, instanceId, 0); }
  public static void AddAccessId(FlatBufferBuilder builder, int accessId) { builder.AddInt(5, accessId, 0); }
  public static void AddDropId(FlatBufferBuilder builder, int dropId) { builder.AddInt(6, dropId, 0); }
  public static void AddRoleIcon(FlatBufferBuilder builder, StringOffset roleIconOffset) { builder.AddOffset(7, roleIconOffset.Value, 0); }
  public static void AddIntroduction(FlatBufferBuilder builder, StringOffset introductionOffset) { builder.AddOffset(8, introductionOffset.Value, 0); }
  public static void AddUiConfigId(FlatBufferBuilder builder, int uiConfigId) { builder.AddInt(9, uiConfigId, 0); }
  public static Offset<WWParser.Defs.RoleSkinTrialInfo> EndRoleSkinTrialInfo(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RoleSkinTrialInfo>(o);
  }
  public RoleSkinTrialInfoT UnPack() {
    var _o = new RoleSkinTrialInfoT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RoleSkinTrialInfoT _o) {
    _o.Id = this.Id;
    _o.RoleId = this.RoleId;
    _o.TrialRoleId = this.TrialRoleId;
    _o.PreviewSkinId = this.PreviewSkinId;
    _o.InstanceId = this.InstanceId;
    _o.AccessId = this.AccessId;
    _o.DropId = this.DropId;
    _o.RoleIcon = this.RoleIcon;
    _o.Introduction = this.Introduction;
    _o.UiConfigId = this.UiConfigId;
  }
  public static Offset<WWParser.Defs.RoleSkinTrialInfo> Pack(FlatBufferBuilder builder, RoleSkinTrialInfoT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RoleSkinTrialInfo>);
    var _role_icon = _o.RoleIcon == null ? default(StringOffset) : builder.CreateString(_o.RoleIcon);
    var _introduction = _o.Introduction == null ? default(StringOffset) : builder.CreateString(_o.Introduction);
    return CreateRoleSkinTrialInfo(
      builder,
      _o.Id,
      _o.RoleId,
      _o.TrialRoleId,
      _o.PreviewSkinId,
      _o.InstanceId,
      _o.AccessId,
      _o.DropId,
      _role_icon,
      _introduction,
      _o.UiConfigId);
  }
}

public class RoleSkinTrialInfoT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("role_id")]
  public int RoleId { get; set; }
  [Newtonsoft.Json.JsonProperty("trial_role_id")]
  public int TrialRoleId { get; set; }
  [Newtonsoft.Json.JsonProperty("preview_skin_id")]
  public int PreviewSkinId { get; set; }
  [Newtonsoft.Json.JsonProperty("instance_id")]
  public int InstanceId { get; set; }
  [Newtonsoft.Json.JsonProperty("access_id")]
  public int AccessId { get; set; }
  [Newtonsoft.Json.JsonProperty("drop_id")]
  public int DropId { get; set; }
  [Newtonsoft.Json.JsonProperty("role_icon")]
  public string RoleIcon { get; set; }
  [Newtonsoft.Json.JsonProperty("introduction")]
  public string Introduction { get; set; }
  [Newtonsoft.Json.JsonProperty("ui_config_id")]
  public int UiConfigId { get; set; }

  public RoleSkinTrialInfoT() {
    this.Id = 0;
    this.RoleId = 0;
    this.TrialRoleId = 0;
    this.PreviewSkinId = 0;
    this.InstanceId = 0;
    this.AccessId = 0;
    this.DropId = 0;
    this.RoleIcon = null;
    this.Introduction = null;
    this.UiConfigId = 0;
  }
}


static public class RoleSkinTrialInfoVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*RoleId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*TrialRoleId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*PreviewSkinId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*InstanceId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*AccessId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*DropId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 18 /*RoleIcon*/, false)
      && verifier.VerifyString(tablePos, 20 /*Introduction*/, false)
      && verifier.VerifyField(tablePos, 22 /*UiConfigId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
