using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium98n : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium98n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 97.9345d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00019, 6630000.0), new Cadmium98() } },

        };
    }
}
    
    