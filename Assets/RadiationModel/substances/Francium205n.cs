using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium205n : RadioactiveSubstance
    {
        public override string name { get; } = "Francium205n";
        public override double halfLife { get; } = 0.00115d;
        public override double atomicWeight { get; } = 204.99925d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00204, 609000.0), new Francium205() } },

        };
    }
}
    
    