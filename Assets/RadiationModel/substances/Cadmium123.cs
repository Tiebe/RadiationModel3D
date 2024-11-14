using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium123";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 122.91689d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6014800.0), new Indium123() } },

        };
    }
}
    
    