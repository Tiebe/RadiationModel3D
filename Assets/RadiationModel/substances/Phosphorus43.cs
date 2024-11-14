using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus43 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus43";
        public override double halfLife { get; } = 0.0358d;
        public override double atomicWeight { get; } = 43.00541d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 17235000.0), new Sulfur43() } },

        };
    }
}
    
    