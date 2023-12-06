using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StoreProduct
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 StoreProductGroupId { get; set; }
        [Key(2)] public System.Int32 StoreType { get; set; }
        [Key(3)] public System.String ProductId { get; set; }
        [Key(4)] public System.Int64 PaidStoneCount { get; set; }
        [Key(5)] public System.Int64 FreeStoneCount { get; set; }
        [Key(6)] public System.Int64 Price { get; set; }
        [Key(7)] public System.String PriceUsd { get; set; }
        [Key(8)] public System.String AutoProductDescription { get; set; }
        [Key(9)] public System.String AutoProductDescriptionEn { get; set; }
    }
}
