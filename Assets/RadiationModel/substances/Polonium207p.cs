using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium207p : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium207p";
        public override double halfLife { get; } = 2.79d;
        public override double atomicWeight { get; } = 206.98308d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0009), new Polonium207() } },

        };
    }
}
    
    