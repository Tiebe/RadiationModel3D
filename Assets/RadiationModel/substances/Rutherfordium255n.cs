using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium255n : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium255n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 255.10239d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1050000.0, 0.00118)), new Rutherfordium255() } },

        };
    }
}
    
    