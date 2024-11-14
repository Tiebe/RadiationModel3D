using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium22 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium22";
        public override double halfLife { get; } = 3.8745d;
        public override double atomicWeight { get; } = 21.99957d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4781400.0), new Sodium22() } },

        };
    }
}
    
    