using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium119";
        public override double halfLife { get; } = 57780.0d;
        public override double atomicWeight { get; } = 118.90641d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2293000.0), new Antimony119() } },
            { 0.9793999999999999d, new List<RadioactiveSubstance> { new Antimony119() } },
            { 0.0206d, new List<RadioactiveSubstance> { new BetaParticle(1, 2293000.0), new Antimony119() } },

        };
    }
}
    
    