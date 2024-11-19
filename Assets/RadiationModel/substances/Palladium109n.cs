using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium109n : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium109n";
        public override double halfLife { get; } = 282.18d;
        public override double atomicWeight { get; } = 108.90615d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00656, 189000.0), new Palladium109() } },

        };
    }
}
    
    