using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium190p : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium190p";
        public override double halfLife { get; } = 11113.2d;
        public override double atomicWeight { get; } = 189.96095d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.914d, new List<RadioactiveSubstance> { new BetaParticle(1, 2330600.0), new Osmium190() } },
            { 0.086d, new List<RadioactiveSubstance> { new GammaParticle(0.00329), new Iridium190() } },

        };
    }
}
    
    