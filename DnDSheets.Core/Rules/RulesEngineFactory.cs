namespace DnDSheets.Core.Rules;

public class RulesEngineFactory
{
    private readonly IEnumerable<IRulesEngine> _engines;

    public RulesEngineFactory(IEnumerable<IRulesEngine> engines) => _engines = engines;

    public IRulesEngine For(RuleSet ruleSet) =>
        _engines.First(e => e.RuleSet == ruleSet);
}