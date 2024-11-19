using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver109m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver109m";
        public override double halfLife { get; } = 39.79d;
        public override double atomicWeight { get; } = 108.90485d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01409, 88000.0), new Silver109() } },

        };
    }
}
    
    