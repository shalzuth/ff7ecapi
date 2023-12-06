using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaSupport
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MateriaSupportEffectGroupId { get; set; }
        [Key(2)] public System.Int64 MateriaSupportConditionId { get; set; }
        [Key(3)] public System.Int64 MateriaGroupId { get; set; }
        [Key(4)] public System.Int64 ResourceId { get; set; }
        [Key(5)] public System.Int64 NameLanguageId { get; set; }
    }
}
