using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium143";
        public override double halfLife { get; } = 39.0d;
        public override double atomicWeight { get; } = 142.92675d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6011000.0), new Europium143() } },

        };
    }
}
    
    