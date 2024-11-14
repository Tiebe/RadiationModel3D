using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium102";
        public override double halfLife { get; } = 0.069d;
        public override double atomicWeight { get; } = 101.944d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9013000.0), new Yttrium102() } },

        };
    }
}
    
    