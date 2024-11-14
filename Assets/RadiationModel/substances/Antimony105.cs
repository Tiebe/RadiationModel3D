using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony105 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony105";
        public override double halfLife { get; } = 1.12d;
        public override double atomicWeight { get; } = 104.93128d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9323000.0), new Tin105() } },
            { 0.001d, new List<RadioactiveSubstance> { new ProtonParticle(), new Tin104() } },

        };
    }
}
    
    