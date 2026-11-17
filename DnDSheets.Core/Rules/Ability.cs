namespace DnDSheets.Core.Rules;

public enum Ability
{
    Strength,
    Dexterity,
    Constitution,
    Intelligence,
    Wisdom,
    Charisma
}

public static class AbilityExtensions
{
    public static string Label(this Ability a) => a switch
    {
        Ability.Strength => "Fuerza",
        Ability.Dexterity => "Destreza",
        Ability.Constitution => "Constitución",
        Ability.Intelligence => "Inteligencia",
        Ability.Wisdom => "Sabiduría",
        Ability.Charisma => "Carisma",
        _ => a.ToString()
    };

    public static string Short(this Ability a) => a switch
    {
        Ability.Strength => "FUE",
        Ability.Dexterity => "DES",
        Ability.Constitution => "CON",
        Ability.Intelligence => "INT",
        Ability.Wisdom => "SAB",
        Ability.Charisma => "CAR",
        _ => a.ToString()
    };
}

public record SkillInfo(string Key, string Name, Ability Ability);

public static class SkillCatalog
{
    public static readonly IReadOnlyList<SkillInfo> All = new[]
    {
        new SkillInfo("Acrobatics", "Acrobacias", Ability.Dexterity),
        new SkillInfo("AnimalHandling", "Trato con animales", Ability.Wisdom),
        new SkillInfo("Arcana", "Arcanos", Ability.Intelligence),
        new SkillInfo("Athletics", "Atletismo", Ability.Strength),
        new SkillInfo("Deception", "Engaño", Ability.Charisma),
        new SkillInfo("History", "Historia", Ability.Intelligence),
        new SkillInfo("Insight", "Perspicacia", Ability.Wisdom),
        new SkillInfo("Intimidation", "Intimidación", Ability.Charisma),
        new SkillInfo("Investigation", "Investigación", Ability.Intelligence),
        new SkillInfo("Medicine", "Medicina", Ability.Wisdom),
        new SkillInfo("Nature", "Naturaleza", Ability.Intelligence),
        new SkillInfo("Perception", "Percepción", Ability.Wisdom),
        new SkillInfo("Performance", "Interpretación", Ability.Charisma),
        new SkillInfo("Persuasion", "Persuasión", Ability.Charisma),
        new SkillInfo("Religion", "Religión", Ability.Intelligence),
        new SkillInfo("SleightOfHand", "Juego de manos", Ability.Dexterity),
        new SkillInfo("Stealth", "Sigilo", Ability.Dexterity),
        new SkillInfo("Survival", "Supervivencia", Ability.Wisdom),
    };

    public static SkillInfo Get(string key) => All.First(s => s.Key == key);
}