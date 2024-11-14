using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold203 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold203";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 202.97515d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2126200.0), new Mercury203() } },

        };
    }
}
    
    