using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium52";
        public override double halfLife { get; } = 8.2d;
        public override double atomicWeight { get; } = 51.9565d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8953700.0), new Titanium52() } },

        };
    }
}
    
    