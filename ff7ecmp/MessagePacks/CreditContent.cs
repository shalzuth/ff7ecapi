using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CreditContent
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 CreditId { get; set; }
        [Key(2)] public System.Int64 PrefixLanguageId { get; set; }
        [Key(3)] public System.Int64 NameLanguageId { get; set; }
        [Key(4)] public System.Int32 OrderNo { get; set; }
    }
}
