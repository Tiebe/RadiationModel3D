using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum182n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum182n";
        public override double halfLife { get; } = 950.4d;
        public override double atomicWeight { get; } = 181.95071d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((519599.99999, 0.00239)), new Tantalum182() } },

        };
    }
}
    
    