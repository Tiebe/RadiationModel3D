using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium96m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium96m";
        public override double halfLife { get; } = 0.511d;
        public override double atomicWeight { get; } = 95.94682d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 14970000.0), new Silver96() } },

        };
    }
}
    
    