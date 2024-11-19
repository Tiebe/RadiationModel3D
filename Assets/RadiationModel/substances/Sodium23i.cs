using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium23i : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium23i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 22.99824d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00016, 7891153.5), new Sodium23() } },

        };
    }
}
    
    