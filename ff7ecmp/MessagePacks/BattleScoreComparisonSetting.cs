using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleScoreComparisonSetting
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 ElementDamageBattleScoreCoefficient { get; set; }
        [Key(2)] public System.Int32 ElementDamageBossCoefficientMultiple { get; set; }
        [Key(3)] public System.Int32 ElementDamageMinionCoefficientMultiple { get; set; }
        [Key(4)] public System.Int32 DefenseBattleScoreCoefficient { get; set; }
        [Key(5)] public System.Int32 DefenseBossCoefficient { get; set; }
        [Key(6)] public System.Int32 DefenseMinionCoefficient { get; set; }
        [Key(7)] public System.Int32 ResistDamageBattleScoreCoefficient { get; set; }
        [Key(8)] public System.Int32 ResistDamageBossCoefficientMultiple { get; set; }
        [Key(9)] public System.Int32 ResistDamageMinionCoefficientMultiple { get; set; }
        [Key(10)] public System.Int32 SkillNotesBattleScoreCoefficient { get; set; }
        [Key(11)] public System.Int32 SkillNotesEffectiveBaseValue { get; set; }
        [Key(12)] public System.Int32 SkillNotesCoefficientMultiple { get; set; }
        [Key(13)] public System.Int32 StatusConditionResistBossCoefficientMultiple { get; set; }
        [Key(14)] public System.Int32 StatusConditionResistMinionCoefficientMultiple { get; set; }
        [Key(15)] public System.Int32 ResistDebuffBossCoefficientMultiple { get; set; }
        [Key(16)] public System.Int32 ResistDebuffMinionCoefficientMultiple { get; set; }
        [Key(17)] public System.Int32 CharacterResistElementBattleScoreCoefficient { get; set; }
        [Key(18)] public System.Int32 CharacterResistElementBossCoefficientMultiple { get; set; }
        [Key(19)] public System.Int32 CharacterResistElementMinionCoefficientMultiple { get; set; }
        [Key(20)] public System.Int32 CharacterStatusConditionResistBattleScoreCoefficient { get; set; }
        [Key(21)] public System.Int32 CharacterStatusConditionResistBossCoefficientMultiple { get; set; }
        [Key(22)] public System.Int32 CharacterStatusConditionResistMinionCoefficientMultiple { get; set; }
        [Key(23)] public System.Int32 CharacterResistDebuffBattleScoreCoefficient { get; set; }
        [Key(24)] public System.Int32 CharacterResistDebuffBossCoefficientMultiple { get; set; }
        [Key(25)] public System.Int32 CharacterResistDebuffMinionCoefficientMultiple { get; set; }
    }
}
