using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum30 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum30";
        public override double halfLife { get; } = 3.62d;
        public override double atomicWeight { get; } = 29.98297d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8568862.0), new Silicon30() } },

        };
    }
}
    
    