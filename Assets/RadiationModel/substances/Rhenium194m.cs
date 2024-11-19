using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium194m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium194m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 193.9709d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((150000.0, 0.00827)), new Rhenium194() } },

        };
    }
}
    
    