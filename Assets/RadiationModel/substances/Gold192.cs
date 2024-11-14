using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold192 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold192";
        public override double halfLife { get; } = 17784.0d;
        public override double atomicWeight { get; } = 191.96482d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3516500.0), new Platinum192() } },

        };
    }
}
    
    