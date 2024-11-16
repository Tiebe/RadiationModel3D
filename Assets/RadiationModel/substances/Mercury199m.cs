using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury199m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury199m";
        public override double halfLife { get; } = 2560.2d;
        public override double atomicWeight { get; } = 198.96885d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((532500.0, 0.00233)), new Mercury199() } },

        };
    }
}
    
    