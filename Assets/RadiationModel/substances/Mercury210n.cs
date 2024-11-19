using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury210n : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury210n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 209.99582d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00088, 1410000.0), new Mercury210() } },

        };
    }
}
    
    