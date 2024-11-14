using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium119m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium119m";
        public override double halfLife { get; } = 406080.0d;
        public override double atomicWeight { get; } = 118.90669d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2554000.0), new Antimony119() } },
            { 0.9959d, new List<RadioactiveSubstance> { new Antimony119() } },
            { 0.0040999999999999995d, new List<RadioactiveSubstance> { new BetaParticle(1, 2554000.0), new Antimony119() } },

        };
    }
}
    
    