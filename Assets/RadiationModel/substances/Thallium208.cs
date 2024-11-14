using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium208";
        public override double halfLife { get; } = 183.18d;
        public override double atomicWeight { get; } = 207.98202d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4998400.0), new Lead208() } },

        };
    }
}
    
    