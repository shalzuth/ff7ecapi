using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SoloAreaGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 AreaGroupCategoryType { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
        [Key(3)] public System.Int64 NameLanguageId { get; set; }
    }
}
