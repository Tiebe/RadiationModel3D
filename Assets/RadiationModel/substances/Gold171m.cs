
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold171m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold171m";
        public override double halfLife { get; } = 0.00104d;
        public override double atomicWeight { get; } = 170.99215d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.6d, new List<RadioactiveSubstance> { new AlphaParticle(), new Iridium167() } },

            { 0.4d, new List<RadioactiveSubstance> { new ProtonParticle(), new Platinum170() } },

        };
    }
}
    
    