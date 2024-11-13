
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold171 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold171";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 170.99188d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Platinum170() } },

        };
    }
}
    
    