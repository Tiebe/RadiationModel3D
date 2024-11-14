using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium256p : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium256p";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 256.10373d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00052), new Rutherfordium256() } },

        };
    }
}
    
    