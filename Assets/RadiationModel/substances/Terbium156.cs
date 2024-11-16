using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium156";
        public override double halfLife { get; } = 462240.0d;
        public override double atomicWeight { get; } = 155.92475d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2444300.0), new Gadolinium156() } },

        };
    }
}
    
    