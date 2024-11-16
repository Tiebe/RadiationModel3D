using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium176";
        public override double halfLife { get; } = 8.7d;
        public override double atomicWeight { get; } = 175.96363d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9690000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 8249000.0), new Osmium176() } },
            { 0.031d, new List<RadioactiveSubstance> { new AlphaParticle(6285002.09), new Rhenium172() } },

        };
    }
}
    
    