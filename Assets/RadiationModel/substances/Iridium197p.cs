using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium197p : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium197p";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 196.97267d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00044), new Iridium197() } },

        };
    }
}
    
    