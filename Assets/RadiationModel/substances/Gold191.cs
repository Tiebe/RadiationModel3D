using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold191 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold191";
        public override double halfLife { get; } = 11448.0d;
        public override double atomicWeight { get; } = 190.96372d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1900000.0), new Platinum191() } },

        };
    }
}
    
    