using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon121 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon121";
        public override double halfLife { get; } = 2406.0d;
        public override double atomicWeight { get; } = 120.91145d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3765000.0), new Iodine121() } },

        };
    }
}
    
    