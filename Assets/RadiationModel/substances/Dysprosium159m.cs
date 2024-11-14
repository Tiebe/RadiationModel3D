using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium159m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium159m";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 158.92612d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00351), new Dysprosium159() } },

        };
    }
}
    
    