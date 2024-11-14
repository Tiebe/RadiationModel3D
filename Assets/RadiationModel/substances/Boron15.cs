using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron15 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron15";
        public override double halfLife { get; } = 0.01018d;
        public override double atomicWeight { get; } = 15.03109d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 19083900.0), new Carbon15() } },

        };
    }
}
    
    