using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Gacha
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 GachaGroupId { get; set; }
        [Key(2)] public System.Int32 GachaType { get; set; }
        [Key(3)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(4)] public System.Int64 LockConditionSetId { get; set; }
        [Key(5)] public System.Int64 NameLanguageId { get; set; }
        [Key(6)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(7)] public System.Int64 AttentionLanguageId { get; set; }
        [Key(8)] public System.Int64 SummaryLanguageId { get; set; }
        [Key(9)] public System.Int64 GachaEmissionRateLanguageId { get; set; }
        [Key(10)] public System.Int64 WeaponEmissionRateLanguageId { get; set; }
        [Key(11)] public System.Int32 GachaDetailTemplateType { get; set; }
        [Key(12)] public System.Int64 TicketItemId { get; set; }
        [Key(13)] public System.Int64 GachaDirectionLotGroupId { get; set; }
        [Key(14)] public System.Int64 GachaAppealId0 { get; set; }
        [Key(15)] public System.Int64 GachaAppealId1 { get; set; }
        [Key(16)] public System.Int64 GachaAppealId2 { get; set; }
        [Key(17)] public System.Int64 GachaAppealId3 { get; set; }
        [Key(18)] public System.Int64 GachaAppealId4 { get; set; }
        [Key(19)] public System.Int64 GachaAppealId5 { get; set; }
        [Key(20)] public System.Int64 GachaAppealId6 { get; set; }
        [Key(21)] public System.Int64 GachaAppealId7 { get; set; }
        [Key(22)] public System.Int64 GachaAppealId8 { get; set; }
        [Key(23)] public System.Int64 GachaAppealId9 { get; set; }
        [Key(24)] public System.Int64 GachaStampSheetGroupId { get; set; }
        [Key(25)] public System.Int64 GachaRarityLotGroupId { get; set; }
        [Key(26)] public System.Int64 GachaWeaponLotSetId { get; set; }
        [Key(27)] public System.Int64 PickupGachaRarityLotGroupId { get; set; }
        [Key(28)] public System.Int64 PickupGachaWeaponLotSetId { get; set; }
        [Key(29)] public System.Int32 GachaNotiType { get; set; }
        [Key(30)] public System.Int64 ResourceId { get; set; }
        [Key(31)] public System.Int32 Priority { get; set; }
        [Key(32)] public System.Int64 GachaWishId { get; set; }
    }
}
