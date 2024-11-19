using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum204m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum204m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 203.98322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00062, 1990000.0), new Platinum204() } },

        };
    }
}
    
    