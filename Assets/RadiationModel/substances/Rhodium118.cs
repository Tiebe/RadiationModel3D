using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium118";
        public override double halfLife { get; } = 0.282d;
        public override double atomicWeight { get; } = 117.93034d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10501400.0), new Palladium118() } },

        };
    }
}
    
    