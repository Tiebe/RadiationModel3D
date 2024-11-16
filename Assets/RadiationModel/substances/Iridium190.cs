using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium190 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium190";
        public override double halfLife { get; } = 1017792.0d;
        public override double atomicWeight { get; } = 189.96054d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1954200.0), new Osmium190() } },
            { 2e-05d, new List<RadioactiveSubstance> { new BetaParticle(1, 1954200.0), new Osmium190() } },

        };
    }
}
    
    