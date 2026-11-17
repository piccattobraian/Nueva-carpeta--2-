using DnDSheets.Core.Entities;

namespace DnDSheets.Core.Rules;

public interface IRulesEngine
{
    RuleSet RuleSet { get; }
    string SpeciesLabel { get; }
    string AbilityBonusSource { get; }
    bool HasWeaponMastery { get; }
    IReadOnlyList<string> CreationSteps { get; }

    int AbilityModifier(int score);
    int ProficiencyBonus(int level);

    int SavingThrow(Character character, Ability ability);
    int SkillBonus(Character character, SkillInfo skill);
    int Initiative(Character character);
    int PassivePerception(Character character);
}