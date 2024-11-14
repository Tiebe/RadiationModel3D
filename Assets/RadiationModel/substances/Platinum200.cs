using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum200 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum200";
        public override double halfLife { get; } = 45360.0d;
        public override double atomicWeight { get; } = 199.97144d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 641000.0), new Gold200() } },

        };
    }
}
    
    