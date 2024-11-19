using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper75m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper75m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 74.94159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.02009, 61700.0), new Copper75() } },

        };
    }
}
    
    