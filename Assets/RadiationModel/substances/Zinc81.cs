
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc81 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc81";
        public override double halfLife { get; } = 0.2994d;
        public override double atomicWeight { get; } = 80.9504d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium81() } },

        };
    }
}
    
    