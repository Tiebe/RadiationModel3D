using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten184m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten184m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 183.95231d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00096), new Tungsten184() } },

        };
    }
}
    
    