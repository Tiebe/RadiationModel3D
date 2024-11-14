using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver104 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver104";
        public override double halfLife { get; } = 4152.0d;
        public override double atomicWeight { get; } = 103.90862d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4279100.0), new Palladium104() } },

        };
    }
}
    
    