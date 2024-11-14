using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus37 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus37";
        public override double halfLife { get; } = 2.31d;
        public override double atomicWeight { get; } = 36.9796d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7896430.0), new Sulfur37() } },

        };
    }
}
    
    