using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium174n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium174n";
        public override double halfLife { get; } = 0.00011d;
        public override double atomicWeight { get; } = 173.94442d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00059, 2090000.0), new Thulium174() } },

        };
    }
}
    
    