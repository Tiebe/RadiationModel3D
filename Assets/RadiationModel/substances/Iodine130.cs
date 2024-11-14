using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine130 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine130";
        public override double halfLife { get; } = 44496.0d;
        public override double atomicWeight { get; } = 129.90667d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2944474.0), new Xenon130() } },

        };
    }
}
    
    