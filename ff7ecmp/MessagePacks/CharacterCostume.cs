using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CharacterCostume
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 CharacterId { get; set; }
        [Key(2)] public System.Int64 ResourceId { get; set; }
        [Key(3)] public System.Int64 SetWeaponId { get; set; }
        [Key(4)] public System.Int64 CharacterCostumeParameterId { get; set; }
        [Key(5)] public System.Int64 PassiveSkillId0 { get; set; }
        [Key(6)] public System.Int64 PassiveSkillId1 { get; set; }
        [Key(7)] public System.Int64 PassiveSkillPoint0 { get; set; }
        [Key(8)] public System.Int64 PassiveSkillPoint1 { get; set; }
        [Key(9)] public System.Int64 NameLanguageId { get; set; }
        [Key(10)] public System.Int64 CharacterNovelCostumeId { get; set; }
        [Key(11)] public System.Int64 PanelRenderEnvironmentId { get; set; }
        [Key(12)] public System.Int32 ItemRarityType { get; set; }
    }
}
