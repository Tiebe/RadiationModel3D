using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine140 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine140";
        public override double halfLife { get; } = 0.588d;
        public override double atomicWeight { get; } = 139.93172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9380500.0), new Xenon140() } },

        };
    }
}
    
    