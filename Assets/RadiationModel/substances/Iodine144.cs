using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine144 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine144";
        public override double halfLife { get; } = 0.094d;
        public override double atomicWeight { get; } = 143.95134d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11542000.0), new Xenon144() } },

        };
    }
}
    
    