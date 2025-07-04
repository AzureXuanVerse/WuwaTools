// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ShopBank : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static ShopBank GetRootAsShopBank(ByteBuffer _bb) { return GetRootAsShopBank(_bb, new ShopBank()); }
  public static ShopBank GetRootAsShopBank(ByteBuffer _bb, ShopBank obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ShopBank __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CondId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.ShopBank> CreateShopBank(FlatBufferBuilder builder,
      int id = 0,
      int cond_id = 0) {
    builder.StartTable(2);
    ShopBank.AddCondId(builder, cond_id);
    ShopBank.AddId(builder, id);
    return ShopBank.EndShopBank(builder);
  }

  public static void StartShopBank(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddCondId(FlatBufferBuilder builder, int condId) { builder.AddInt(1, condId, 0); }
  public static Offset<WWParser.Defs.ShopBank> EndShopBank(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.ShopBank>(o);
  }
  public ShopBankT UnPack() {
    var _o = new ShopBankT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ShopBankT _o) {
    _o.Id = this.Id;
    _o.CondId = this.CondId;
  }
  public static Offset<WWParser.Defs.ShopBank> Pack(FlatBufferBuilder builder, ShopBankT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.ShopBank>);
    return CreateShopBank(
      builder,
      _o.Id,
      _o.CondId);
  }
}

public class ShopBankT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("cond_id")]
  public int CondId { get; set; }

  public ShopBankT() {
    this.Id = 0;
    this.CondId = 0;
  }
}


static public class ShopBankVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*CondId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
