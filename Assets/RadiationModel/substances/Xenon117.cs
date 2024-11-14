using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon117 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon117";
        public override double halfLife { get; } = 61.0d;
        public override double atomicWeight { get; } = 116.92036d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6254000.0), new Iodine117() } },

        };
    }
}
    
    