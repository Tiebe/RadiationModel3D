using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium184m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium184m";
        public override double halfLife { get; } = 0.00047d;
        public override double atomicWeight { get; } = 183.95772d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00549), new Iridium184() } },

        };
    }
}
    
    