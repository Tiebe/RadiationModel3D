using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium93n : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium93n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 92.91259d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2185199.99999, 0.00057)), new Technetium93() } },

        };
    }
}
    
    