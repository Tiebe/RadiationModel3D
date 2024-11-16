using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese64m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese64m";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 63.95404d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00713), new Manganese64() } },

        };
    }
}
    
    