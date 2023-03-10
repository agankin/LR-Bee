using System.Collections;

namespace LRBee.GrammarDefinition
{
    public class ProductionRuleCollection<TSymbol> : IReadOnlyList<ProductionRule<TSymbol>>
    {
        private readonly IList<ProductionRule<TSymbol>> _rules = new List<ProductionRule<TSymbol>>();

        public int Count => _rules.Count;

        public ProductionRule<TSymbol> this[int index] => _rules[index];

        public void Add(ProductionRule<TSymbol> rule) => _rules.Add(rule);

        public IEnumerator<ProductionRule<TSymbol>> GetEnumerator() => _rules.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}