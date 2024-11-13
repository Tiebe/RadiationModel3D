
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury195 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury195";
        public override double halfLife { get; } = 38484.0d;
        public override double atomicWeight { get; } = 194.96671d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gold195() } },

        };
    }
}
    
    