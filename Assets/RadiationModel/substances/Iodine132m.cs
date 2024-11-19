using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine132m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine132m";
        public override double halfLife { get; } = 4993.2d;
        public override double atomicWeight { get; } = 131.90811d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new List<RadioactiveSubstance> { new GammaParticle((110000.0, 0.01127)), new Iodine132() } },
            { 0.14d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3684975.0), new Xenon132() } },

        };
    }
}
    
    