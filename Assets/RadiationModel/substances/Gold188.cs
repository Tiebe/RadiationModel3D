using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold188 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold188";
        public override double halfLife { get; } = 530.4d;
        public override double atomicWeight { get; } = 187.96525d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5449700.0), new Platinum188() } },

        };
    }
}
    
    