using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium159m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium159m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 158.94086d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00085), new Promethium159() } },

        };
    }
}
    
    