using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium114n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium114n";
        public override double halfLife { get; } = 0.0431d;
        public override double atomicWeight { get; } = 113.90546d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00247, 501900.0), new Indium114() } },
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00398, 311600.0), new Indium114m() } },

        };
    }
}
    
    