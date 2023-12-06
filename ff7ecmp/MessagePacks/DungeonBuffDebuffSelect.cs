using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonBuffDebuffSelect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 DungeonBuffDebuffGroupId0 { get; set; }
        [Key(2)] public System.Int64 DungeonBuffDebuffGroupId1 { get; set; }
        [Key(3)] public System.Int64 DungeonBuffDebuffGroupId2 { get; set; }
    }
}
