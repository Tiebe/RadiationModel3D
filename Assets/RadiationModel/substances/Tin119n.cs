using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin119n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin119n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 118.90559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2127000.0, 0.00058)), new Tin119() } },

        };
    }
}
    
    