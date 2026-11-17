namespace DnDSheets.Core.Rules;

public class Rules2024 : RulesBase
{
    public override RuleSet RuleSet => RuleSet.DnD2024;
    public override string SpeciesLabel => "Especie";
    public override string AbilityBonusSource => "Trasfondo";
    public override bool HasWeaponMastery => true;
    public override IReadOnlyList<string> CreationSteps =>
        new[] { "Clase", "Trasfondo", "Especie", "Atributos", "Equipo" };
}