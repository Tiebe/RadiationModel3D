using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium101";
        public override double halfLife { get; } = 81.6d;
        public override double atomicWeight { get; } = 100.91859d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5497500.0), new Silver101() } },

        };
    }
}
    
    