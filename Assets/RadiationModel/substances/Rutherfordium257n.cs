using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium257n : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium257n";
        public override double halfLife { get; } = 0.00011d;
        public override double atomicWeight { get; } = 257.10416d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00107, 1156000.0), new Rutherfordium257() } },

        };
    }
}
    
    