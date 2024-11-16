using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium37 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium37";
        public override double halfLife { get; } = 0.181d;
        public override double atomicWeight { get; } = 36.9859d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11664100.0), new Potassium37() } },

        };
    }
}
    
    