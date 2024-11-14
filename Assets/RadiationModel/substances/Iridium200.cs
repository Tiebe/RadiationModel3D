using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium200";
        public override double halfLife { get; } = 43.0d;
        public override double atomicWeight { get; } = 199.97684d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5029000.0), new Platinum200() } },

        };
    }
}
    
    