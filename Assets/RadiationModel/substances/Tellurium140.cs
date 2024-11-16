using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium140";
        public override double halfLife { get; } = 0.351d;
        public override double atomicWeight { get; } = 139.93949d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7239000.0), new Iodine140() } },

        };
    }
}
    
    