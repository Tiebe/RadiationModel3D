using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold185 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold185";
        public override double halfLife { get; } = 255.0d;
        public override double atomicWeight { get; } = 184.9658d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9974d, new List<RadioactiveSubstance> { new BetaParticle(1, 4829900.0), new Platinum185() } },
            { 0.0026d, new List<RadioactiveSubstance> { new AlphaParticle(6201902.09), new Iridium181() } },

        };
    }
}
    
    