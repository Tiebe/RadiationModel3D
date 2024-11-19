using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead203n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead203n";
        public override double halfLife { get; } = 0.48d;
        public override double atomicWeight { get; } = 202.97656d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2949000.0, 0.00042)), new Lead203() } },

        };
    }
}
    
    