using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen14 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen14";
        public override double halfLife { get; } = 70.621d;
        public override double atomicWeight { get; } = 14.0086d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5144364.2), new Nitrogen14() } },

        };
    }
}
    
    