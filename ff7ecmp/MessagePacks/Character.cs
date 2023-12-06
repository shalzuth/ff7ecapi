using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Character
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 StartDate { get; set; }
        [Key(2)] public System.Int64 ResourceId { get; set; }
        [Key(3)] public System.Int64 SkillAttackTacticsId { get; set; }
        [Key(4)] public System.Int64 CharacterPieceItemId { get; set; }
        [Key(5)] public System.Int64 NameLanguageId { get; set; }
        [Key(6)] public System.Int64 FullNameLanguageId { get; set; }
        [Key(7)] public System.Int64 PartyNameLanguageId { get; set; }
        [Key(8)] public System.Int64 DefaultWeaponId { get; set; }
        [Key(9)] public System.Int64 DefaultCharacterCostumeId { get; set; }
        [Key(10)] public System.Int64 DefaultLimitbreakId { get; set; }
        [Key(11)] public System.Int64 CharacterNovelId { get; set; }
        [Key(12)] public System.Int64 OverExpLimit { get; set; }
        [Key(13)] public System.Boolean IsExcludedSettingMission { get; set; }
        [Key(14)] public System.Int32 OrderNo { get; set; }
        [Key(15)] public System.Int64 WeaponMedalItemId { get; set; }
    }
}
