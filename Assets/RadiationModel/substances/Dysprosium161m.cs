using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium161m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium161m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 160.92746d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((485599.99999, 0.00255)), new Dysprosium161() } },

        };
    }
}
    
    