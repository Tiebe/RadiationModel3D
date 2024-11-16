using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium93";
        public override double halfLife { get; } = 1.17d;
        public override double atomicWeight { get; } = 92.93668d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10031800.0), new Rhodium93() } },

        };
    }
}
    
    