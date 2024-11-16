using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury204n : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury204n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 203.98125d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00017), new Mercury204() } },

        };
    }
}
    
    