using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium135n : RadioactiveSubstance
    {
        public override string name { get; } = "Barium135n";
        public override double halfLife { get; } = 0.00106d;
        public override double atomicWeight { get; } = 134.90825d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2387950.0, 0.00052)), new Barium135() } },

        };
    }
}
    
    