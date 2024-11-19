using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium157m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium157m";
        public override double halfLife { get; } = 0.076d;
        public override double atomicWeight { get; } = 156.93209d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((155000.0, 0.008)), new Erbium157() } },

        };
    }
}
    
    