using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine130m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine130m";
        public override double halfLife { get; } = 530.4d;
        public override double atomicWeight { get; } = 129.90671d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.84d, new List<RadioactiveSubstance> { new GammaParticle(0.031), new Iodine130() } },
            { 0.16d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2984474.0), new Xenon130() } },

        };
    }
}
    
    