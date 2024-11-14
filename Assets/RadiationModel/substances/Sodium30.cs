using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium30 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium30";
        public override double halfLife { get; } = 0.0459d;
        public override double atomicWeight { get; } = 30.0091d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 17356400.0), new Magnesium30() } },

        };
    }
}
    
    