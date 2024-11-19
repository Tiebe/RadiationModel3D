using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth195n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth195n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 194.9832d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2381000.0, 0.00052)), new Bismuth195() } },

        };
    }
}
    
    