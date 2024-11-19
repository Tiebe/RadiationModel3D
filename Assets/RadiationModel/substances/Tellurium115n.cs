using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium115n : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium115n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 114.9122d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((280000.0, 0.00443)), new Tellurium115() } },

        };
    }
}
    
    