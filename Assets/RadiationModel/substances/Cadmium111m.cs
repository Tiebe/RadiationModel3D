using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium111m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium111m";
        public override double halfLife { get; } = 2910.0d;
        public override double atomicWeight { get; } = 110.90461d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00313, 396200.0), new Cadmium111() } },

        };
    }
}
    
    