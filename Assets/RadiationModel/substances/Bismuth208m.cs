using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth208m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth208m";
        public override double halfLife { get; } = 0.00258d;
        public override double atomicWeight { get; } = 207.98143d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1571099.99999, 0.00079)), new Bismuth208() } },

        };
    }
}
    
    