using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum184m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum184m";
        public override double halfLife { get; } = 0.00101d;
        public override double atomicWeight { get; } = 183.9619d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1840000.0, 0.00067)), new Platinum184() } },

        };
    }
}
    
    