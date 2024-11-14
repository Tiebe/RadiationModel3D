using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium133";
        public override double halfLife { get; } = 13.5d;
        public override double atomicWeight { get; } = 132.92978d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6920000.0), new Neodymium133() } },

        };
    }
}
    
    