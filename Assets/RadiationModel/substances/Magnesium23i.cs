using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium23i : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium23i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 23.0025d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((7802970.0, 0.00016)), new Magnesium23() } },
            { 0.0017000000000000001d, new List<RadioactiveSubstance> { new ProtonParticle(), new Sodium22() } },

        };
    }
}
    
    