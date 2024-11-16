using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine135 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine135";
        public override double halfLife { get; } = 23688.0d;
        public override double atomicWeight { get; } = 134.91006d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2633800.0), new Xenon135() } },

        };
    }
}
    
    