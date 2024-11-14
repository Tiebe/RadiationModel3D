using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium96";
        public override double halfLife { get; } = 1.003d;
        public override double atomicWeight { get; } = 95.94034d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8940000.0), new Silver96() } },

        };
    }
}
    
    