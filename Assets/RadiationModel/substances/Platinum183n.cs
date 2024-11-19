using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum183n : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum183n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 182.96181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00633, 196000.0), new Platinum183() } },

        };
    }
}
    
    