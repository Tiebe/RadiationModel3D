using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury188 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury188";
        public override double halfLife { get; } = 195.0d;
        public override double atomicWeight { get; } = 187.96758d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2173300.0), new Gold188() } },
            { 3.7e-07d, new List<RadioactiveSubstance> { new AlphaParticle(5729047.4), new Platinum184() } },

        };
    }
}
    
    