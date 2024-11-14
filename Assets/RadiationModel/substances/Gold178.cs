using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold178 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold178";
        public override double halfLife { get; } = 3.4d;
        public override double atomicWeight { get; } = 177.97606d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.84d, new List<RadioactiveSubstance> { new BetaParticle(1, 9694000.0), new Platinum178() } },
            { 0.16d, new List<RadioactiveSubstance> { new AlphaParticle(7078047.4), new Iridium174() } },

        };
    }
}
    
    