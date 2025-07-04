// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ShopBankInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static ShopBankInfo GetRootAsShopBankInfo(ByteBuffer _bb) { return GetRootAsShopBankInfo(_bb, new ShopBankInfo()); }
  public static ShopBankInfo GetRootAsShopBankInfo(ByteBuffer _bb, ShopBankInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ShopBankInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BankId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ItemId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Weight { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ItemNum { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int LimitNum { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public WWParser.Defs.DicIntInt? OriginalPrice(int j) { int o = __p.__offset(16); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int OriginalPriceLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public WWParser.Defs.DicIntInt? Price(int j) { int o = __p.__offset(18); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int PriceLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool Show { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string Label { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLabelBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetLabelBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetLabelArray() { return __p.__vector_as_array<byte>(22); }

  public static Offset<WWParser.Defs.ShopBankInfo> CreateShopBankInfo(FlatBufferBuilder builder,
      int id = 0,
      int bank_id = 0,
      int item_id = 0,
      int weight = 0,
      int item_num = 0,
      int limit_num = 0,
      VectorOffset original_priceOffset = default(VectorOffset),
      VectorOffset priceOffset = default(VectorOffset),
      bool show = false,
      StringOffset labelOffset = default(StringOffset)) {
    builder.StartTable(10);
    ShopBankInfo.AddLabel(builder, labelOffset);
    ShopBankInfo.AddPrice(builder, priceOffset);
    ShopBankInfo.AddOriginalPrice(builder, original_priceOffset);
    ShopBankInfo.AddLimitNum(builder, limit_num);
    ShopBankInfo.AddItemNum(builder, item_num);
    ShopBankInfo.AddWeight(builder, weight);
    ShopBankInfo.AddItemId(builder, item_id);
    ShopBankInfo.AddBankId(builder, bank_id);
    ShopBankInfo.AddId(builder, id);
    ShopBankInfo.AddShow(builder, show);
    return ShopBankInfo.EndShopBankInfo(builder);
  }

  public static void StartShopBankInfo(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddBankId(FlatBufferBuilder builder, int bankId) { builder.AddInt(1, bankId, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int itemId) { builder.AddInt(2, itemId, 0); }
  public static void AddWeight(FlatBufferBuilder builder, int weight) { builder.AddInt(3, weight, 0); }
  public static void AddItemNum(FlatBufferBuilder builder, int itemNum) { builder.AddInt(4, itemNum, 0); }
  public static void AddLimitNum(FlatBufferBuilder builder, int limitNum) { builder.AddInt(5, limitNum, 0); }
  public static void AddOriginalPrice(FlatBufferBuilder builder, VectorOffset originalPriceOffset) { builder.AddOffset(6, originalPriceOffset.Value, 0); }
  public static VectorOffset CreateOriginalPriceVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateOriginalPriceVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOriginalPriceVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOriginalPriceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartOriginalPriceVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPrice(FlatBufferBuilder builder, VectorOffset priceOffset) { builder.AddOffset(7, priceOffset.Value, 0); }
  public static VectorOffset CreatePriceVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePriceVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePriceVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePriceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPriceVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShow(FlatBufferBuilder builder, bool show) { builder.AddBool(8, show, false); }
  public static void AddLabel(FlatBufferBuilder builder, StringOffset labelOffset) { builder.AddOffset(9, labelOffset.Value, 0); }
  public static Offset<WWParser.Defs.ShopBankInfo> EndShopBankInfo(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.ShopBankInfo>(o);
  }
  public ShopBankInfoT UnPack() {
    var _o = new ShopBankInfoT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ShopBankInfoT _o) {
    _o.Id = this.Id;
    _o.BankId = this.BankId;
    _o.ItemId = this.ItemId;
    _o.Weight = this.Weight;
    _o.ItemNum = this.ItemNum;
    _o.LimitNum = this.LimitNum;
    _o.OriginalPrice = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.OriginalPriceLength; ++_j) {_o.OriginalPrice.Add(this.OriginalPrice(_j).HasValue ? this.OriginalPrice(_j).Value.UnPack() : null);}
    _o.Price = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.PriceLength; ++_j) {_o.Price.Add(this.Price(_j).HasValue ? this.Price(_j).Value.UnPack() : null);}
    _o.Show = this.Show;
    _o.Label = this.Label;
  }
  public static Offset<WWParser.Defs.ShopBankInfo> Pack(FlatBufferBuilder builder, ShopBankInfoT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.ShopBankInfo>);
    var _original_price = default(VectorOffset);
    if (_o.OriginalPrice != null) {
      var __original_price = new Offset<WWParser.Defs.DicIntInt>[_o.OriginalPrice.Count];
      for (var _j = 0; _j < __original_price.Length; ++_j) { __original_price[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.OriginalPrice[_j]); }
      _original_price = CreateOriginalPriceVector(builder, __original_price);
    }
    var _price = default(VectorOffset);
    if (_o.Price != null) {
      var __price = new Offset<WWParser.Defs.DicIntInt>[_o.Price.Count];
      for (var _j = 0; _j < __price.Length; ++_j) { __price[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.Price[_j]); }
      _price = CreatePriceVector(builder, __price);
    }
    var _label = _o.Label == null ? default(StringOffset) : builder.CreateString(_o.Label);
    return CreateShopBankInfo(
      builder,
      _o.Id,
      _o.BankId,
      _o.ItemId,
      _o.Weight,
      _o.ItemNum,
      _o.LimitNum,
      _original_price,
      _price,
      _o.Show,
      _label);
  }
}

public class ShopBankInfoT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("bank_id")]
  public int BankId { get; set; }
  [Newtonsoft.Json.JsonProperty("item_id")]
  public int ItemId { get; set; }
  [Newtonsoft.Json.JsonProperty("weight")]
  public int Weight { get; set; }
  [Newtonsoft.Json.JsonProperty("item_num")]
  public int ItemNum { get; set; }
  [Newtonsoft.Json.JsonProperty("limit_num")]
  public int LimitNum { get; set; }
  [Newtonsoft.Json.JsonProperty("original_price")]
  public List<WWParser.Defs.DicIntIntT> OriginalPrice { get; set; }
  [Newtonsoft.Json.JsonProperty("price")]
  public List<WWParser.Defs.DicIntIntT> Price { get; set; }
  [Newtonsoft.Json.JsonProperty("show")]
  public bool Show { get; set; }
  [Newtonsoft.Json.JsonProperty("label")]
  public string Label { get; set; }

  public ShopBankInfoT() {
    this.Id = 0;
    this.BankId = 0;
    this.ItemId = 0;
    this.Weight = 0;
    this.ItemNum = 0;
    this.LimitNum = 0;
    this.OriginalPrice = null;
    this.Price = null;
    this.Show = false;
    this.Label = null;
  }
}


static public class ShopBankInfoVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*BankId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ItemId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Weight*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ItemNum*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*LimitNum*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 16 /*OriginalPrice*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 18 /*Price*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyField(tablePos, 20 /*Show*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 22 /*Label*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
