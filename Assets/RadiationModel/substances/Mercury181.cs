using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury181 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury181";
        public override double halfLife { get; } = 3.6d;
        public override double atomicWeight { get; } = 180.97782d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.73d, new List<RadioactiveSubstance> { new BetaParticle(1, 7210000.0), new Gold181() } },
            { 0.27d, new List<RadioactiveSubstance> { new AlphaParticle(7304047.4), new Platinum177() } },

        };
    }
}
    
    