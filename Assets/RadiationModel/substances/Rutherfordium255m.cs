using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium255m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium255m";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 255.10143d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00827, 150000.0), new Rutherfordium255() } },

        };
    }
}
    
    