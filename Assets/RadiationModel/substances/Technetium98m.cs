using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium98m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 97.90731d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((91000.0, 0.01362)), new Technetium98() } },

        };
    }
}
    
    