
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold193 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold193";
        public override double halfLife { get; } = 63540.0d;
        public override double atomicWeight { get; } = 192.96414d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum193() } },

        };
    }
}
    
    