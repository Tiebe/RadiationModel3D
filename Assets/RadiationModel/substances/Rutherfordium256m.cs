using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium256m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium256m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 256.10235d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1118000.0, 0.00111)), new Rutherfordium256() } },

        };
    }
}
    
    