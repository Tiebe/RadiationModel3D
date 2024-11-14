using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium151";
        public override double halfLife { get; } = 1074.0d;
        public override double atomicWeight { get; } = 150.92619d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9440000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 2872000.0), new Terbium151() } },
            { 0.055999999999999994d, new List<RadioactiveSubstance> { new AlphaParticle(5199947.4), new Gadolinium147() } },

        };
    }
}
    
    