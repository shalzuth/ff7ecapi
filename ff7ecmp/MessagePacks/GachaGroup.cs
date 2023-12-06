using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 GachaGroupType { get; set; }
        [Key(2)] public System.Int64 NameLanguageId { get; set; }
        [Key(3)] public System.Int32 Priority { get; set; }
    }
}
