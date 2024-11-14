using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium171";
        public override double halfLife { get; } = 15.2d;
        public override double atomicWeight { get; } = 170.95572d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5836000.0), new Tungsten171() } },

        };
    }
}
    
    