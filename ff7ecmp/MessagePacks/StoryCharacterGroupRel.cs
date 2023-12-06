using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StoryCharacterGroupRel
    {
        [Key(0)] public System.Int64 StoryCharacterGroupId { get; set; }
        [Key(1)] public System.Int64 CharacterId { get; set; }
        [Key(2)] public System.Int64 DisplayCostumeId { get; set; }
        [Key(3)] public System.Boolean IsFix { get; set; }
        [Key(4)] public System.Boolean IsRental { get; set; }
        [Key(5)] public System.Boolean IsProvide { get; set; }
        [Key(6)] public System.Int64 DisplayWeaponId { get; set; }
        [Key(7)] public System.Int32 PartyIdx { get; set; }
    }
}
