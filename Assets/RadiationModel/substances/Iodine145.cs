using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine145 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine145";
        public override double halfLife { get; } = 0.0897d;
        public override double atomicWeight { get; } = 144.95585d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10363000.0), new Xenon145() } },

        };
    }
}
    
    