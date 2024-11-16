using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold193m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold193m";
        public override double halfLife { get; } = 3.9d;
        public override double atomicWeight { get; } = 192.96445d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00428), new Gold193() } },
            { 0.0003d, new List<RadioactiveSubstance> { new BetaParticle(1, 1364700.0), new Platinum193() } },

        };
    }
}
    
    