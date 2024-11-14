using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium161m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium161m";
        public override double halfLife { get; } = 6.76d;
        public override double atomicWeight { get; } = 160.92809d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00587), new Holmium161() } },

        };
    }
}
    
    