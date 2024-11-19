using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur33i : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur33i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 32.97734d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00023, 5479788.3), new Sulfur33() } },

        };
    }
}
    
    