using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury185m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury185m";
        public override double halfLife { get; } = 21.6d;
        public override double atomicWeight { get; } = 184.972d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.54d, new List<RadioactiveSubstance> { new GammaParticle(0.01192, 104000.0), new Mercury185() } },
            { 0.46d, new List<RadioactiveSubstance> { new BetaParticle(1, 5778100.0), new Gold185() } },
            { 0.0003d, new List<RadioactiveSubstance> { new AlphaParticle(6896047.4), new Platinum181() } },

        };
    }
}
    
    