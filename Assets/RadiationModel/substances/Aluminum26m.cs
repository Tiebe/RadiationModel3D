using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum26m : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum26m";
        public override double halfLife { get; } = 6.346d;
        public override double atomicWeight { get; } = 25.98714d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4232714.0), new Magnesium26() } },

        };
    }
}
    
    