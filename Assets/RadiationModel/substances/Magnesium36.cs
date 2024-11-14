using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium36 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium36";
        public override double halfLife { get; } = 0.0039d;
        public override double atomicWeight { get; } = 36.02188d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14430000.0), new Aluminum36() } },

        };
    }
}
    
    