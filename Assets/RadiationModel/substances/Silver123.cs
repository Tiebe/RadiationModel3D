using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver123 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver123";
        public override double halfLife { get; } = 0.294d;
        public override double atomicWeight { get; } = 122.92531d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7844200.0), new Cadmium123() } },

        };
    }
}
    
    