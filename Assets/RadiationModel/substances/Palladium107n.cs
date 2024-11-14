using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium107n : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium107n";
        public override double halfLife { get; } = 21.3d;
        public override double atomicWeight { get; } = 106.90536d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00578), new Palladium107() } },

        };
    }
}
    
    