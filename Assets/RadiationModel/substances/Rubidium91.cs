using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium91";
        public override double halfLife { get; } = 58.2d;
        public override double atomicWeight { get; } = 90.91654d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5907000.0), new Strontium91() } },

        };
    }
}
    
    