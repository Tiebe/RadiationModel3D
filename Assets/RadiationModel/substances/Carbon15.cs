using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon15 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon15";
        public override double halfLife { get; } = 2.449d;
        public override double atomicWeight { get; } = 15.0106d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9771661.899999999), new Nitrogen15() } },

        };
    }
}
    
    