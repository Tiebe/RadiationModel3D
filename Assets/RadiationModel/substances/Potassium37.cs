using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium37 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium37";
        public override double halfLife { get; } = 1.23651d;
        public override double atomicWeight { get; } = 36.97338d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6147480.0), new Argon37() } },

        };
    }
}
    
    