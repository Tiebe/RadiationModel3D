using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium103";
        public override double halfLife { get; } = 0.053d;
        public override double atomicWeight { get; } = 102.94924d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11177000.0), new Yttrium103() } },

        };
    }
}
    
    