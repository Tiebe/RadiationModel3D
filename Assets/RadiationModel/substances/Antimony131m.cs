using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony131m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony131m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 130.91379d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1676100.00001, 0.00074)), new Antimony131() } },

        };
    }
}
    
    