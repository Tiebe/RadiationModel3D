using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium142n : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium142n";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 141.91593d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2829000.0, 0.00044)), new Promethium142() } },

        };
    }
}
    
    