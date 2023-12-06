using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Accessory
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 PassiveSkillId { get; set; }
        [Key(2)] public System.Int64 AccessorySaleGroupId { get; set; }
        [Key(3)] public System.Int64 ResourceId { get; set; }
        [Key(4)] public System.Int32 BaseSaleGil { get; set; }
        [Key(5)] public System.Int64 NameLanguageId { get; set; }
    }
}