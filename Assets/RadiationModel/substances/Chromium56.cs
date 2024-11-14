using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium56 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium56";
        public override double halfLife { get; } = 356.4d;
        public override double atomicWeight { get; } = 55.94065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1626570.0), new Manganese56() } },

        };
    }
}
    
    